﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "559827AE2A729DA6745334FF6FDF48BBE16B47EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Emgu.CV.UI;
using LiveCharts.Wpf;
using MahApps.Metro.Controls;
using PLImg_V2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Xceed.Wpf.Toolkit;


namespace PLImg_V2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbScatter;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbBackGoundRemove;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb1inch;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb2inch;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb4inch;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb6inch;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStartFixAreaScan;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveImg;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrigin;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnROrigin;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXMove;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnYMove;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZMove;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRMove;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbXDisa;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbYDisa;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbZDisa;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudlinerate;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudScanSpeed;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudGoXPos;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudGoYPos;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudGoZPos;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudGoRPos;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudPLBias;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown nudScBias;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PLImg_V2.UC_CamComunication ucComunication;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PLImg_V2.UC_ScanConfiguration ucScanconfig;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblXpos;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblYpos;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblZpos;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBuffNum;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig0;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig1;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig2;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig3;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig4;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig5;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig6;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig7;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig8;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxTrig9;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost windowOri;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Emgu.CV.UI.ImageBox imgboxOri;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dpnlImgResult;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig0;
        
        #line default
        #line hidden
        
        
        #line 246 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig1;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig2;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig3;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig4;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig5;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig6;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig7;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig8;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgboxScterTrig9;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost windowScterOri;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Emgu.CV.UI.ImageBox imgscterboxOri;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PLImg_V2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 15 "..\..\..\MainWindow.xaml"
            ((PLImg_V2.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.MetroWindow_Closing);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\MainWindow.xaml"
            ((PLImg_V2.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ckbScatter = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.ckbBackGoundRemove = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.rdb1inch = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rdb2inch = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.rdb4inch = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.rdb6inch = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.btnStartFixAreaScan = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\MainWindow.xaml"
            this.btnStartFixAreaScan.Click += new System.Windows.RoutedEventHandler(this.btnStartFixAreaScan_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSaveImg = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\MainWindow.xaml"
            this.btnSaveImg.Click += new System.Windows.RoutedEventHandler(this.btnSaveImg_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnOrigin = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\MainWindow.xaml"
            this.btnOrigin.Click += new System.Windows.RoutedEventHandler(this.btnOrigin_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnROrigin = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\MainWindow.xaml"
            this.btnROrigin.Click += new System.Windows.RoutedEventHandler(this.btnROrigin_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnXMove = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\MainWindow.xaml"
            this.btnXMove.Click += new System.Windows.RoutedEventHandler(this.btnXMove_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnYMove = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\MainWindow.xaml"
            this.btnYMove.Click += new System.Windows.RoutedEventHandler(this.btnYMove_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btnZMove = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\MainWindow.xaml"
            this.btnZMove.Click += new System.Windows.RoutedEventHandler(this.btnZMove_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btnRMove = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\MainWindow.xaml"
            this.btnRMove.Click += new System.Windows.RoutedEventHandler(this.btnRMove_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.ckbXDisa = ((System.Windows.Controls.CheckBox)(target));
            
            #line 124 "..\..\..\MainWindow.xaml"
            this.ckbXDisa.Checked += new System.Windows.RoutedEventHandler(this.ckbXDisa_Checked);
            
            #line default
            #line hidden
            
            #line 124 "..\..\..\MainWindow.xaml"
            this.ckbXDisa.Unchecked += new System.Windows.RoutedEventHandler(this.ckbXDisa_Unchecked);
            
            #line default
            #line hidden
            return;
            case 17:
            this.ckbYDisa = ((System.Windows.Controls.CheckBox)(target));
            
            #line 125 "..\..\..\MainWindow.xaml"
            this.ckbYDisa.Checked += new System.Windows.RoutedEventHandler(this.ckbYDisa_Checked);
            
            #line default
            #line hidden
            
            #line 125 "..\..\..\MainWindow.xaml"
            this.ckbYDisa.Unchecked += new System.Windows.RoutedEventHandler(this.ckbYDisa_Unchecked);
            
            #line default
            #line hidden
            return;
            case 18:
            this.ckbZDisa = ((System.Windows.Controls.CheckBox)(target));
            
            #line 126 "..\..\..\MainWindow.xaml"
            this.ckbZDisa.Checked += new System.Windows.RoutedEventHandler(this.ckbZDisa_Checked);
            
            #line default
            #line hidden
            
            #line 126 "..\..\..\MainWindow.xaml"
            this.ckbZDisa.Unchecked += new System.Windows.RoutedEventHandler(this.ckbZDisa_Unchecked);
            
            #line default
            #line hidden
            return;
            case 19:
            this.nudlinerate = ((MahApps.Metro.Controls.NumericUpDown)(target));
            
            #line 129 "..\..\..\MainWindow.xaml"
            this.nudlinerate.KeyUp += new System.Windows.Input.KeyEventHandler(this.nudlinerate_KeyUp);
            
            #line default
            #line hidden
            return;
            case 20:
            this.nudScanSpeed = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 21:
            this.nudGoXPos = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 22:
            this.nudGoYPos = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 23:
            this.nudGoZPos = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 24:
            this.nudGoRPos = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 25:
            this.nudPLBias = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 26:
            this.nudScBias = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 27:
            
            #line 145 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TabItem)(target)).AddHandler(System.Windows.Controls.Primitives.Selector.SelectedEvent, new System.Windows.RoutedEventHandler(this.TabItem_Selected));
            
            #line default
            #line hidden
            
            #line 145 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TabItem)(target)).AddHandler(System.Windows.Controls.Primitives.Selector.UnselectedEvent, new System.Windows.RoutedEventHandler(this.TabItem_Unselected));
            
            #line default
            #line hidden
            return;
            case 28:
            this.ucComunication = ((PLImg_V2.UC_CamComunication)(target));
            return;
            case 29:
            
            #line 149 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TabItem)(target)).AddHandler(System.Windows.Controls.Primitives.Selector.SelectedEvent, new System.Windows.RoutedEventHandler(this.TabItem_Selected));
            
            #line default
            #line hidden
            
            #line 149 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TabItem)(target)).AddHandler(System.Windows.Controls.Primitives.Selector.UnselectedEvent, new System.Windows.RoutedEventHandler(this.TabItem_Unselected));
            
            #line default
            #line hidden
            return;
            case 30:
            this.ucScanconfig = ((PLImg_V2.UC_ScanConfiguration)(target));
            return;
            case 31:
            this.lblXpos = ((System.Windows.Controls.Label)(target));
            return;
            case 32:
            this.lblYpos = ((System.Windows.Controls.Label)(target));
            return;
            case 33:
            this.lblZpos = ((System.Windows.Controls.Label)(target));
            return;
            case 34:
            this.lblBuffNum = ((System.Windows.Controls.Label)(target));
            return;
            case 35:
            this.imgboxTrig0 = ((System.Windows.Controls.Image)(target));
            return;
            case 36:
            this.imgboxTrig1 = ((System.Windows.Controls.Image)(target));
            return;
            case 37:
            this.imgboxTrig2 = ((System.Windows.Controls.Image)(target));
            return;
            case 38:
            this.imgboxTrig3 = ((System.Windows.Controls.Image)(target));
            return;
            case 39:
            this.imgboxTrig4 = ((System.Windows.Controls.Image)(target));
            return;
            case 40:
            this.imgboxTrig5 = ((System.Windows.Controls.Image)(target));
            return;
            case 41:
            this.imgboxTrig6 = ((System.Windows.Controls.Image)(target));
            return;
            case 42:
            this.imgboxTrig7 = ((System.Windows.Controls.Image)(target));
            return;
            case 43:
            this.imgboxTrig8 = ((System.Windows.Controls.Image)(target));
            return;
            case 44:
            this.imgboxTrig9 = ((System.Windows.Controls.Image)(target));
            return;
            case 45:
            this.windowOri = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 46:
            this.imgboxOri = ((Emgu.CV.UI.ImageBox)(target));
            return;
            case 47:
            this.dpnlImgResult = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 48:
            this.imgboxScterTrig0 = ((System.Windows.Controls.Image)(target));
            return;
            case 49:
            this.imgboxScterTrig1 = ((System.Windows.Controls.Image)(target));
            return;
            case 50:
            this.imgboxScterTrig2 = ((System.Windows.Controls.Image)(target));
            return;
            case 51:
            this.imgboxScterTrig3 = ((System.Windows.Controls.Image)(target));
            return;
            case 52:
            this.imgboxScterTrig4 = ((System.Windows.Controls.Image)(target));
            return;
            case 53:
            this.imgboxScterTrig5 = ((System.Windows.Controls.Image)(target));
            return;
            case 54:
            this.imgboxScterTrig6 = ((System.Windows.Controls.Image)(target));
            return;
            case 55:
            this.imgboxScterTrig7 = ((System.Windows.Controls.Image)(target));
            return;
            case 56:
            this.imgboxScterTrig8 = ((System.Windows.Controls.Image)(target));
            return;
            case 57:
            this.imgboxScterTrig9 = ((System.Windows.Controls.Image)(target));
            return;
            case 58:
            this.windowScterOri = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 59:
            this.imgscterboxOri = ((Emgu.CV.UI.ImageBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

