﻿#pragma checksum "..\..\..\..\View\Add\MaterialAddForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AC49CACFA1334540E87A06967F93054E467C55EC"
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
    /// MaterialAddForm
    /// </summary>
    public partial class MaterialAddForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VendorCodeTB;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTB;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UnitTB;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LengthTB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityTB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaterialTypeTB;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GOSTTB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MainSupplierCB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\Add\MaterialAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBT;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\Add\MaterialAddForm.xaml"
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
            System.Uri resourceLocater = new System.Uri("/FurnitureWPFApp;component/view/add/materialaddform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Add\MaterialAddForm.xaml"
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
            this.VendorCodeTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\..\View\Add\MaterialAddForm.xaml"
            this.VendorCodeTB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Int_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.UnitTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LengthTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\..\View\Add\MaterialAddForm.xaml"
            this.LengthTB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Int_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.QuantityTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\View\Add\MaterialAddForm.xaml"
            this.QuantityTB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Int_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MaterialTypeTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PriceTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\View\Add\MaterialAddForm.xaml"
            this.PriceTB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Int_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GOSTTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.MainSupplierCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.AddBT = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\View\Add\MaterialAddForm.xaml"
            this.AddBT.Click += new System.Windows.RoutedEventHandler(this.AddBT_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BackBT = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\View\Add\MaterialAddForm.xaml"
            this.BackBT.Click += new System.Windows.RoutedEventHandler(this.BackBT_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

