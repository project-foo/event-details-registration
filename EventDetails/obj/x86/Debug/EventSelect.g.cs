﻿#pragma checksum "C:\Users\darsh\source\repos\event-details-registration\EventDetails\EventSelect.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6EC635DDD8E8F6BD89E98AE2B7C1203C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventDetails
{
    partial class EventSelect : 
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
                    this.EventList = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 2:
                {
                    this.Modify = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\EventSelect.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Modify).Click += this.Modify_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\EventSelect.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.backbutton_click;
                    #line default
                }
                break;
            case 4:
                {
                    this.LogOutButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\EventSelect.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LogOutButton).Click += this.logoutbutton_click;
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

