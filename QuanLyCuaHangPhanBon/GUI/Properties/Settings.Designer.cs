﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=tcp:vonhatdai.database.windows.net;Initial Catalog=QuanLyCuaHangPhanB" +
            "on;Persist Security Info=True;User ID=daigunny12;Password=Passla1den8")]
        public string QuanLyCuaHangPhanBonConnectionString {
            get {
                return ((string)(this["QuanLyCuaHangPhanBonConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-06L2JPG\\SQLEXPRESS;Initial Catalog=QuanLyCuaHangPhanBon;Integ" +
            "rated Security=True")]
        public string QuanLyCuaHangPhanBonConnectionString1 {
            get {
                return ((string)(this["QuanLyCuaHangPhanBonConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-06L2JPG;Initial Catalog=QuanLyCuaHangPhanBon;Integrated Secur" +
            "ity=True")]
        public string QuanLyCuaHangPhanBonConnectionString2 {
            get {
                return ((string)(this["QuanLyCuaHangPhanBonConnectionString2"]));
            }
        }
    }
}
