﻿#pragma checksum "..\..\PrzeciaganieLiny.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5BC331045288818DBECFACF65669608E5B5F6B0B4999000E060670D79ECEAF8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
    /// PrzeciaganieLiny
    /// </summary>
    public partial class PrzeciaganieLiny : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 102 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SedziaImie;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SedziaNazwisko;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsuwanieSedziegoTextBox;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sedziowieStackPanel;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SedziaIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DruzynaNazwa;
        
        #line default
        #line hidden
        
        
        #line 319 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WycofanieDruzynyTextBox;
        
        #line default
        #line hidden
        
        
        #line 341 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel druzynyStackPanel;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\PrzeciaganieLiny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DruzynaIDTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/projektDyscypiny;component/przeciaganieliny.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PrzeciaganieLiny.xaml"
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
            this.SedziaImie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SedziaNazwisko = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 115 "..\..\PrzeciaganieLiny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DodajSedziegoClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UsuwanieSedziegoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 161 "..\..\PrzeciaganieLiny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UsunSedziegoClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sedziowieStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.SedziaIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 215 "..\..\PrzeciaganieLiny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SzukajSedziegoClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DruzynaNazwa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.WycofanieDruzynyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.druzynyStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 12:
            this.DruzynaIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 414 "..\..\PrzeciaganieLiny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RozpocznijTurniejClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 475 "..\..\PrzeciaganieLiny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Powrot);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

