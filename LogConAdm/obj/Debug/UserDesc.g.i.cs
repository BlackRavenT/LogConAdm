﻿#pragma checksum "..\..\UserDesc.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F755AF42CE52967F842496C1483D8072E89D0D36"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LogConAdm;
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


namespace LogConAdm {
    
    
    /// <summary>
    /// UserDesc
    /// </summary>
    public partial class UserDesc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\UserDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\UserDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Del;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\UserDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\UserDesc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseApp;
        
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
            System.Uri resourceLocater = new System.Uri("/LogConAdm;component/userdesc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserDesc.xaml"
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
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\UserDesc.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Del = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\UserDesc.xaml"
            this.Del.Click += new System.Windows.RoutedEventHandler(this.Del_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Menu = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\UserDesc.xaml"
            this.Menu.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseApp = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\UserDesc.xaml"
            this.CloseApp.Click += new System.Windows.RoutedEventHandler(this.CloseApp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

