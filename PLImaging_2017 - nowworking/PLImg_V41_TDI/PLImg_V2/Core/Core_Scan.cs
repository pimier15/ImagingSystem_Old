﻿using Accord.Math;
using MachineControl.Camera.Dalsa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLImg_V2
{
    public partial class Core
    {
        
        public void ReadyNonTrigScan()
        {

        }

        public void ScanStart_Non()
        {

        }

        public void StartAreaScan()
        {
            var config = ScanConfig.Area;
            Cam.Disconnect()();
            CurrentConfig = config;
            StopStgBuffer( config );
            System.Threading.Thread.Sleep( 100 );
            ResetCamCofnig( config );
            System.Threading.Thread.Sleep( 100 );
            Grab();
        }

        public void StartAlignScan()
        {
            var config = ScanConfig.Align;
            Cam.Disconnect()();
            CurrentConfig = config;
            StopStgBuffer( config );
            System.Threading.Thread.Sleep( 100 );
            ResetCamCofnig( config );
            System.Threading.Thread.Sleep( 100 );
            Grab();
        }



        public void StartTrigScan( ScanConfig config )
        {
            "STart Trigger Scan".Print();
            Cam.Disconnect()();
            CurrentConfig = config;
            TrigLimit = SetTriggerLimit( config );
            TrigCount = 0;
            StopStgBuffer( config );
            StgReadyTrigScan( 0, config , true );

            System.Threading.Thread.Sleep( 100 );
            ResetCamCofnig( config );
            RunStgBuffer( config );
            System.Threading.Thread.Sleep( 100 );
            Grab();
            System.Threading.Thread.Sleep( 100 );
            MoveXYstg( "Y", TrigScanData.YStart );
            Stg.WaitEps( "Y" )( TrigScanData.YStart, 0.1 );
            System.Threading.Thread.Sleep( 100 );
            //ScanMoveXYstg( "Y", TrigScanData.EndYPos[config], TrigScanData.Scan_Stage_Speed );
            ScanMoveXYstg( "Y", TrigScanData.YEnd , TrigScanData.ScanSpeed );
            System.Threading.Thread.Sleep( 16000 / TrigScanData.ScanSpeed );
            StopStgBuffer( CurrentConfig );
        }

        void StgReadyTrigScan( int triggerNum, ScanConfig config , bool startonend = false )
        {
            //Console.WriteLine( $"Stage Ready Line Number = {triggerNum}" );
            var nextYpos = TrigScanData.YStart;
            if ( startonend )
            {
                nextYpos = TrigScanData.YEnd;
            }

			//var nextXpos = TrigScanData.StartXPos[config] - TrigScanData.XStep_Size * triggerNum;
			var nextXpos = TrigScanData.XstartList[triggerNum];

           // nextYpos.Print( "Next Y Pos" );
           // nextXpos.Print( "Next X Pos" );
           // "".Print();

            MoveXYstg( "Y", nextYpos);
            MoveXYstg( "X", nextXpos );
            Stg.WaitEps( "Y" )( nextYpos, 0.1 );
            Stg.WaitEps( "X" )( nextXpos, 0.1 );
            Stg.SetSpeed( "Y" )( TrigScanData.ScanSpeed );
        }

        void ResetCamCofnig( ScanConfig config )
        {
            Reconnector[config]();
            if ( config == ScanConfig.Area ) Cam.EvtResist( Cam.Xfer, GrabDoneEvt_Area );
            else if ( config == ScanConfig.Align ) Cam.EvtResist( Cam.Xfer, GrabDoneEvt_Align );
            else Cam.EvtResist( Cam.Xfer,  GrabDoneEvt_Trg );

        }

        int SetTriggerLimit( ScanConfig config )
        {
            switch ( config )
            {
                case ScanConfig.Trigger_1:
                    return 1;

                case ScanConfig.Trigger_2:
                    return 3;

                case ScanConfig.Trigger_4:
                    return 5;

                case ScanConfig.Trigger_6:
                    return 8;

                default:
                    return 1;
            }
        }
    }
}
