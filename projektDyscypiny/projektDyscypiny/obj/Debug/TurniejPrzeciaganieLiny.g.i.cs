﻿#pragma checksum "..\..\TurniejPrzeciaganieLiny.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24E6BBA946245EA2A3BB37FA9B43C3F545D9C923D53984645077C5903C01E13B"
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
using projektDyscypiny;


namespace projektDyscypiny {
    
    
    /// <summary>
    /// TurniejPrzeciaganieLiny
    /// </summary>
    public partial class TurniejPrzeciaganieLiny : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\TurniejPrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label statusLabel;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\TurniejPrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DruzynaARadioButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\TurniejPrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DruzynaALabel;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\TurniejPrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DruzynaBRadioButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\TurniejPrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DruzynaBLabel;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\TurniejPrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel rankingStackPanel;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\TurniejPrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel wypisywanieMeczowStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/projektDyscypiny;component/turniejprzeciaganieliny.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TurniejPrzeciaganieLiny.xaml"
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
            
            #line 39 "..\..\TurniejPrzeciaganieLiny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WynikiTurniejuClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.statusLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.DruzynaARadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.DruzynaALabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.DruzynaBRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.DruzynaBLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.rankingStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.wypisywanieMeczowStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

