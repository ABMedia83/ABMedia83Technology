﻿#pragma checksum "..\..\..\..\Controls\SketchPadControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36039C8E554DD270F57ABB5BC45DEEDB03A913E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Albert.Win32.Controls;
using Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Controls {
    
    
    /// <summary>
    /// SketchPadControl
    /// </summary>
    public partial class SketchPadControl : Controls.XView, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Controls\SketchPadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid workGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Controls\SketchPadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.ZoomBox canvasZoomBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Controls\SketchPadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid canvasGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Controls\SketchPadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.DrawCanvas drawCanvas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ABBuilderX;component/controls/sketchpadcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\SketchPadControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.workGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.canvasZoomBox = ((Albert.Win32.Controls.ZoomBox)(target));
            return;
            case 3:
            this.canvasGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.drawCanvas = ((Albert.Win32.Controls.DrawCanvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
