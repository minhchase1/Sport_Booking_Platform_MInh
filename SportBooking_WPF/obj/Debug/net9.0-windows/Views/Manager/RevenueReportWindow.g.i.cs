﻿#pragma checksum "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C2C04F1AC1273963705845DF2C9066D217106AAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SportBooking_WPF.Views.Manager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace SportBooking_WPF.Views.Manager {
    
    
    /// <summary>
    /// RevenueReportWindow
    /// </summary>
    public partial class RevenueReportWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDaily;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMonthly;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChart;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRevenue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SportBooking_WPF;V1.0.0.0;component/views/manager/revenuereportwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnDaily = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
            this.BtnDaily.Click += new System.Windows.RoutedEventHandler(this.BtnDaily_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnMonthly = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
            this.BtnMonthly.Click += new System.Windows.RoutedEventHandler(this.BtnMonthly_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnChart = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\..\Views\Manager\RevenueReportWindow.xaml"
            this.BtnChart.Click += new System.Windows.RoutedEventHandler(this.BtnChart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgRevenue = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

