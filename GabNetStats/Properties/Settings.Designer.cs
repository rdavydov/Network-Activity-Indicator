﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GabNetStats.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int BlinkDuration {
            get {
                return ((int)(this["BlinkDuration"]));
            }
            set {
                this["BlinkDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LoadOnStartup {
            get {
                return ((bool)(this["LoadOnStartup"]));
            }
            set {
                this["LoadOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool BandwidthVisualsDefault {
            get {
                return ((bool)(this["BandwidthVisualsDefault"]));
            }
            set {
                this["BandwidthVisualsDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BandwidthVisualsCustom {
            get {
                return ((bool)(this["BandwidthVisualsCustom"]));
            }
            set {
                this["BandwidthVisualsCustom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12500000")]
        public long BandwidthDownload {
            get {
                return ((long)(this["BandwidthDownload"]));
            }
            set {
                this["BandwidthDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12500000")]
        public long BandwidthUpload {
            get {
                return ((long)(this["BandwidthUpload"]));
            }
            set {
                this["BandwidthUpload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoCloseBalloon {
            get {
                return ((bool)(this["AutoCloseBalloon"]));
            }
            set {
                this["AutoCloseBalloon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public decimal AutoCloseBalloonAfter {
            get {
                return ((decimal)(this["AutoCloseBalloonAfter"]));
            }
            set {
                this["AutoCloseBalloonAfter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int BalloonOpacitySlider {
            get {
                return ((int)(this["BalloonOpacitySlider"]));
            }
            set {
                this["BalloonOpacitySlider"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double BalloonOpacity {
            get {
                return ((double)(this["BalloonOpacity"]));
            }
            set {
                this["BalloonOpacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BandwidthUnit {
            get {
                return ((int)(this["BandwidthUnit"]));
            }
            set {
                this["BandwidthUnit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public long BandwidthDownloadMultiplier {
            get {
                return ((long)(this["BandwidthDownloadMultiplier"]));
            }
            set {
                this["BandwidthDownloadMultiplier"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public long BandwidthUploadMultiplier {
            get {
                return ((long)(this["BandwidthUploadMultiplier"]));
            }
            set {
                this["BandwidthUploadMultiplier"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TOSET")]
        public string EnabledInterfaceMACList {
            get {
                return ((string)(this["EnabledInterfaceMACList"]));
            }
            set {
                this["EnabledInterfaceMACList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string KnownInterfaceMACList {
            get {
                return ((string)(this["KnownInterfaceMACList"]));
            }
            set {
                this["KnownInterfaceMACList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xp")]
        public string IconSet {
            get {
                return ((string)(this["IconSet"]));
            }
            set {
                this["IconSet"] = value;
            }
        }
    }
}
