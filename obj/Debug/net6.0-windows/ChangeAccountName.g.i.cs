﻿#pragma checksum "..\..\..\ChangeAccountName.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61373C16D8328FCF0D754ABF76DFF75AFD5AFD95"
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
    /// ChangeAccountName
    /// </summary>
    public partial class ChangeAccountName : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\ChangeAccountName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock accountNumberTextBlock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ChangeAccountName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ChangeAccountName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changAccountNameCancelButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ChangeAccountName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changAccountNameSaveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BankAppWPF;component/changeaccountname.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChangeAccountName.xaml"
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
            this.accountNumberTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.newNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.changAccountNameCancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\ChangeAccountName.xaml"
            this.changAccountNameCancelButton.Click += new System.Windows.RoutedEventHandler(this.changAccountNameCancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.changAccountNameSaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\ChangeAccountName.xaml"
            this.changAccountNameSaveButton.Click += new System.Windows.RoutedEventHandler(this.changAccountNameSaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

