﻿#pragma checksum "..\..\..\Ex2KeyEvent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E8DEDDF739A15A0712780FCA03A01EC52B26BE75"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using _05_EVENT;


namespace _05_EVENT {
    
    
    /// <summary>
    /// Ex2KeyEvent
    /// </summary>
    public partial class Ex2KeyEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Ex2KeyEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/05_EVENT;component/ex2keyevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ex2KeyEvent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Ex2KeyEvent.xaml"
            this.txtbox.KeyDown += new System.Windows.Input.KeyEventHandler(this.KeyEvent);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Ex2KeyEvent.xaml"
            this.txtbox.KeyUp += new System.Windows.Input.KeyEventHandler(this.KeyEvent);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Ex2KeyEvent.xaml"
            this.txtbox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.KeyEvent);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Ex2KeyEvent.xaml"
            this.txtbox.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.KeyEvent);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Ex2KeyEvent.xaml"
            this.txtbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.MyTextInput);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Ex2KeyEvent.xaml"
            this.txtbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

