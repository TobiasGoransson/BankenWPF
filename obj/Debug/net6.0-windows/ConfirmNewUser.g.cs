﻿#pragma checksum "..\..\..\ConfirmNewUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04235227CDDBAFB368450C4316A130A3601DA73A"
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
    /// ConfirmNewUser
    /// </summary>
    public partial class ConfirmNewUser : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\ConfirmNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock confirmUserIdTextBlock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ConfirmNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock confirmFirstNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ConfirmNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock confirmLastNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ConfirmNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock confirmEmailTextBlock;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ConfirmNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock confirmAdressTextBlock;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ConfirmNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backToRegisterPasswordButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ConfirmNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BankAppWPF;component/confirmnewuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ConfirmNewUser.xaml"
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
            this.confirmUserIdTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.confirmFirstNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.confirmLastNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.confirmEmailTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.confirmAdressTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.backToRegisterPasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\ConfirmNewUser.xaml"
            this.backToRegisterPasswordButton.Click += new System.Windows.RoutedEventHandler(this.backToRegisterPasswordButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.confirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\ConfirmNewUser.xaml"
            this.confirmButton.Click += new System.Windows.RoutedEventHandler(this.confirmButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

