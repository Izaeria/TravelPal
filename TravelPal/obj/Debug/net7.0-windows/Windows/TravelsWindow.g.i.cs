﻿#pragma checksum "..\..\..\..\Windows\TravelsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47C737C53681532A85970A1B5EE65EE1DC820253"
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
    /// TravelsWindow
    /// </summary>
    public partial class TravelsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Windows\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTravelBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button checkDetailsBtn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removetravelsBtn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signOutBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/TravelPal;component/windows/travelswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\TravelsWindow.xaml"
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
            this.addTravelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Windows\TravelsWindow.xaml"
            this.addTravelBtn.Click += new System.Windows.RoutedEventHandler(this.addTravelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkDetailsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Windows\TravelsWindow.xaml"
            this.checkDetailsBtn.Click += new System.Windows.RoutedEventHandler(this.checkDetailsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.removetravelsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Windows\TravelsWindow.xaml"
            this.removetravelsBtn.Click += new System.Windows.RoutedEventHandler(this.removetravelsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.signOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Windows\TravelsWindow.xaml"
            this.signOutBtn.Click += new System.Windows.RoutedEventHandler(this.signOutBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

