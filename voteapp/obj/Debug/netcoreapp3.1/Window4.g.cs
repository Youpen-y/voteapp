﻿#pragma checksum "..\..\..\Window4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D1221ADF814104C840F39024A759A143CF40358A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using voteapp;


namespace voteapp {
    
    
    /// <summary>
    /// Window4
    /// </summary>
    public partial class Window4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid createVoteWin;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox theme;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox choiceA;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox choiceB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox choiceC;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox choiceD;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createVoteBut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/voteapp;component/window4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window4.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.createVoteWin = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 10 "..\..\..\Window4.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.theme = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Window4.xaml"
            this.theme.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.theme_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.choiceA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.choiceB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.choiceC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.choiceD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.createVoteBut = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Window4.xaml"
            this.createVoteBut.Click += new System.Windows.RoutedEventHandler(this.createVote_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
