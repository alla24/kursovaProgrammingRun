﻿#pragma checksum "..\..\CalculateArea.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "046A17B8973D917D64D0E559FCB0207D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
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


namespace AreaOfTheFunction {
    
    
    /// <summary>
    /// CalculateArea
    /// </summary>
    public partial class CalculateArea : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AreaOfTheFunction.CalculateArea Calculate_area;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox funcBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox leftBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rightBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox epsBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calcButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox output;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox myPlot;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\CalculateArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart myGraph;
        
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
            System.Uri resourceLocater = new System.Uri("/AreaOfTheFunction;component/calculatearea.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CalculateArea.xaml"
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
            this.Calculate_area = ((AreaOfTheFunction.CalculateArea)(target));
            return;
            case 2:
            this.funcBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.leftBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rightBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.epsBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.calcButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\CalculateArea.xaml"
            this.calcButton.Click += new System.Windows.RoutedEventHandler(this.calculate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.output = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.myPlot = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 10:
            this.myGraph = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

