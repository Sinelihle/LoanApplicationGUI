﻿#pragma checksum "..\..\RentWPF.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D2299F0B7E4DB9CFAE1D0FE64D749544F946768D92F0F389A05F4E197E1DB28"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoanApplication;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace LoanApplication {
    
    
    /// <summary>
    /// RentWPF
    /// </summary>
    public partial class RentWPF : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\RentWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rentBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\RentWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock displayRentBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\RentWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock displayGrossBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RentWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock displayTax;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RentWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RentWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vehicleBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RentWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShow;
        
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
            System.Uri resourceLocater = new System.Uri("/LoanApplication;component/rentwpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RentWPF.xaml"
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
            this.rentBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\RentWPF.xaml"
            this.rentBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.rentBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.displayRentBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.displayGrossBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.displayTax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\RentWPF.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.vehicleBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnShow = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\RentWPF.xaml"
            this.btnShow.Click += new System.Windows.RoutedEventHandler(this.btnShow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

