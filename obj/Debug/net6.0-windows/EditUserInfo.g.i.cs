﻿#pragma checksum "..\..\..\EditUserInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E5E26E2BDF5EFF195BDCC625D847B8E089F00D90"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BankAppWPF;
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


namespace BankAppWPF {
    
    
    /// <summary>
    /// EditUserInfo
    /// </summary>
    public partial class EditUserInfo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\EditUserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock contEdituserIDTextBlock;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\EditUserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contEditfristNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\EditUserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contEditlastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\EditUserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contEditemailTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\EditUserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contEditadressTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\EditUserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveEditedUserButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\EditUserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button canselEditButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BankAppWPF;component/edituserinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditUserInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.contEdituserIDTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.contEditfristNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.contEditlastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.contEditemailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.contEditadressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.saveEditedUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\EditUserInfo.xaml"
            this.saveEditedUserButton.Click += new System.Windows.RoutedEventHandler(this.saveEditedUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.canselEditButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\EditUserInfo.xaml"
            this.canselEditButton.Click += new System.Windows.RoutedEventHandler(this.canselEditButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
