﻿#pragma checksum "..\..\..\Pages\PPersonalRegistration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68F9C23FB822E24CDA7114878298FF7A0763621C5F1A7DFC418BF083BE44C3E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RegistrationOfAPass.Pages;
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


namespace RegistrationOfAPass.Pages {
    
    
    /// <summary>
    /// PersonalRegistration
    /// </summary>
    public partial class PersonalRegistration : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Pages\PPersonalRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPStartDate;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\PPersonalRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPEndDate;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Pages\PPersonalRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Photo;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\Pages\PPersonalRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BLoadPicture;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\Pages\PPersonalRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BLoadFile;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\Pages\PPersonalRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BClear;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\Pages\PPersonalRegistration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRegister;
        
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
            System.Uri resourceLocater = new System.Uri("/RegistrationOfAPass;component/pages/ppersonalregistration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PPersonalRegistration.xaml"
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
            this.DPStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.DPEndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.Photo = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.BLoadPicture = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\..\Pages\PPersonalRegistration.xaml"
            this.BLoadPicture.Click += new System.Windows.RoutedEventHandler(this.BLoadPicture_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BLoadFile = ((System.Windows.Controls.Button)(target));
            
            #line 186 "..\..\..\Pages\PPersonalRegistration.xaml"
            this.BLoadFile.Click += new System.Windows.RoutedEventHandler(this.BLoadFile_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BClear = ((System.Windows.Controls.Button)(target));
            
            #line 210 "..\..\..\Pages\PPersonalRegistration.xaml"
            this.BClear.Click += new System.Windows.RoutedEventHandler(this.BClear_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BRegister = ((System.Windows.Controls.Button)(target));
            
            #line 218 "..\..\..\Pages\PPersonalRegistration.xaml"
            this.BRegister.Click += new System.Windows.RoutedEventHandler(this.BRegister_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

