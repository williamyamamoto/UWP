﻿#pragma checksum "C:\Users\williamyamamoto\Documents\Visual Studio 2015\Projects\aulauwp\aulauwp\EditarPessoa.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F6E4486F9F3DFFFBDF929960DC84A27"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aulauwp
{
    partial class EditarPessoa : 
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
                    this.alterarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 11 "..\..\..\EditarPessoa.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.alterarButton).Click += this.alterarButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.excluirButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 12 "..\..\..\EditarPessoa.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.excluirButton).Click += this.excluirButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.pessoaNomeTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.pessoaSobreNomeTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
