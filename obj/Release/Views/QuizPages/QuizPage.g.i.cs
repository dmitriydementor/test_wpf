﻿#pragma checksum "..\..\..\..\Views\QuizPages\QuizPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BFEF906A4655EFA5E750ED6D44485CF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
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


namespace LearnIT.Views.QuizPages {
    
    
    /// <summary>
    /// QuizPage
    /// </summary>
    public partial class QuizPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridWithLists;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxWords;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxTranslations;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock resultTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Test MAterial Design;component/views/quizpages/quizpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
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
            this.gridWithLists = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.listBoxWords = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
            this.listBoxWords.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FirstColumnSelected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listBoxTranslations = ((System.Windows.Controls.ListBox)(target));
            
            #line 49 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
            this.listBoxTranslations.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SecondColumnSelected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.resultTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 59 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToDictionariesListBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 65 "..\..\..\..\Views\QuizPages\QuizPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.QuizHelpBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

