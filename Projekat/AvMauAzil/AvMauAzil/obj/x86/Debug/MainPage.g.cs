﻿#pragma checksum "C:\Users\User\Grupa1-CodeX\Projekat\AvMauAzil\AvMauAzil\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E034C99664A7D5C82E59E5F25FBBB3A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvMauAzil
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btnRegister = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 170 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRegister).Click += this.btnRegister_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnLogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 155 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLogin).Click += this.btnLogin_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.ckBZapamti = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 4:
                {
                    this.txtSifra = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5:
                {
                    this.txtKorisnik = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 96 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtKorisnik).TextChanged += this.txtKorisnik_TextChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element7 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element7).SelectionChanged += this.TextBlock_SelectionChanged_4;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element8 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 55 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element8).SelectionChanged += this.TextBlock_SelectionChanged_4;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

