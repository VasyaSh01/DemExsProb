﻿#pragma checksum "..\..\..\..\View\Add\EquipmentTypeAddForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E1F617A4AB2F9406F9AB9AFDC5D7B9D6F5EA3B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FurnitureWPFApp.View.Add;
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


namespace FurnitureWPFApp.View.Add {
    
    
    /// <summary>
    /// EquipmentTypeAddForm
    /// </summary>
    public partial class EquipmentTypeAddForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\View\Add\EquipmentTypeAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EquipmentTypeTB;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\View\Add\EquipmentTypeAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBT;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\Add\EquipmentTypeAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBT;
        
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
            System.Uri resourceLocater = new System.Uri("/FurnitureWPFApp;component/view/add/equipmenttypeaddform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Add\EquipmentTypeAddForm.xaml"
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
            this.EquipmentTypeTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AddBT = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\View\Add\EquipmentTypeAddForm.xaml"
            this.AddBT.Click += new System.Windows.RoutedEventHandler(this.AddBT_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BackBT = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\View\Add\EquipmentTypeAddForm.xaml"
            this.BackBT.Click += new System.Windows.RoutedEventHandler(this.BackBT_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

