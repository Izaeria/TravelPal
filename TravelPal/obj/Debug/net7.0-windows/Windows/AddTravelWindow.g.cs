﻿#pragma checksum "..\..\..\..\Windows\AddTravelWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB718396715598D79CDD7C0563AC8180F82F4393"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TravelPal.Windows;


namespace TravelPal.Windows {
    
    
    /// <summary>
    /// AddTravelWindow
    /// </summary>
    public partial class AddTravelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\Windows\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox country;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Windows\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox travelers;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox workOrVacation;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveDetailsBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Windows\AddTravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goBackBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TravelPal;component/windows/addtravelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddTravelWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.country = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.city = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.travelers = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.workOrVacation = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.saveDetailsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Windows\AddTravelWindow.xaml"
            this.saveDetailsBtn.Click += new System.Windows.RoutedEventHandler(this.saveDetailsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.goBackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Windows\AddTravelWindow.xaml"
            this.goBackBtn.Click += new System.Windows.RoutedEventHandler(this.goBackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

