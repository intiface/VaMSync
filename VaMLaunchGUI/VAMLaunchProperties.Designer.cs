﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VaMLaunchGUI {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class VAMLaunchProperties : global::System.Configuration.ApplicationSettingsBase {
        
        private static VAMLaunchProperties defaultInstance = ((VAMLaunchProperties)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new VAMLaunchProperties())));
        
        public static VAMLaunchProperties Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConnectOnStartup {
            get {
                return ((bool)(this["ConnectOnStartup"]));
            }
            set {
                this["ConnectOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ws://127.0.0.1:12345")]
        public string WebsocketAddress {
            get {
                return ((string)(this["WebsocketAddress"]));
            }
            set {
                this["WebsocketAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int PacketTimingGapInMS {
            get {
                return ((int)(this["PacketTimingGapInMS"]));
            }
            set {
                this["PacketTimingGapInMS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseEmbedded {
            get {
                return ((bool)(this["UseEmbedded"]));
            }
            set {
                this["UseEmbedded"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseRemote {
            get {
                return ((bool)(this["UseRemote"]));
            }
            set {
                this["UseRemote"] = value;
            }
        }
    }
}
