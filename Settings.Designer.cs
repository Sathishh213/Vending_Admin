﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vending_Admin.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.msg91.com/api/sendhttp.php?sender=BVCVM&route=4&authkey=225117AE3vsplg" +
            "1uG60e98873P1&country=91")]
        public string smsurl {
            get {
                return ((string)(this["smsurl"]));
            }
            set {
                this["smsurl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int machine_id {
            get {
                return ((int)(this["machine_id"]));
            }
            set {
                this["machine_id"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9894315987")]
        public string helpline {
            get {
                return ((string)(this["helpline"]));
            }
            set {
                this["helpline"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int max_quantity {
            get {
                return ((int)(this["max_quantity"]));
            }
            set {
                this["max_quantity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool vend_sensor {
            get {
                return ((bool)(this["vend_sensor"]));
            }
            set {
                this["vend_sensor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsAdminId {
            get {
                return ((bool)(this["IsAdminId"]));
            }
            set {
                this["IsAdminId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\BetaAutomation\\BillValidator\\BillValidator.exe")]
        public string BillValidatorApp {
            get {
                return ((string)(this["BillValidatorApp"]));
            }
            set {
                this["BillValidatorApp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://127.0.0.1:8888/")]
        public string upi_url {
            get {
                return ((string)(this["upi_url"]));
            }
            set {
                this["upi_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mohandas@betaautomation.com")]
        public string upi_email {
            get {
                return ((string)(this["upi_email"]));
            }
            set {
                this["upi_email"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsNoteDispenser {
            get {
                return ((bool)(this["IsNoteDispenser"]));
            }
            set {
                this["IsNoteDispenser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsCoupon {
            get {
                return ((bool)(this["IsCoupon"]));
            }
            set {
                this["IsCoupon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsCoinDispenser {
            get {
                return ((bool)(this["IsCoinDispenser"]));
            }
            set {
                this["IsCoinDispenser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.1.12")]
        public string face_ip {
            get {
                return ((string)(this["face_ip"]));
            }
            set {
                this["face_ip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9922")]
        public int face_port {
            get {
                return ((int)(this["face_port"]));
            }
            set {
                this["face_port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool plc_check_before_order {
            get {
                return ((bool)(this["plc_check_before_order"]));
            }
            set {
                this["plc_check_before_order"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:5272/")]
        public string ServerURL {
            get {
                return ((string)(this["ServerURL"]));
            }
            set {
                this["ServerURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8870703719")]
        public string upi_mobileno {
            get {
                return ((string)(this["upi_mobileno"]));
            }
            set {
                this["upi_mobileno"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sathish")]
        public string paytm_clientId {
            get {
                return ((string)(this["paytm_clientId"]));
            }
            set {
                this["paytm_clientId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CHATTE19664246519794")]
        public string paytm_mid {
            get {
                return ((string)(this["paytm_mid"]));
            }
            set {
                this["paytm_mid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("K7sebdIQdHK5%Ckk")]
        public string paytm_m_key {
            get {
                return ((string)(this["paytm_m_key"]));
            }
            set {
                this["paytm_m_key"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("v1")]
        public string paytm_version {
            get {
                return ((string)(this["paytm_version"]));
            }
            set {
                this["paytm_version"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("varsjacob@gmail.com")]
        public string FromMailAddress {
            get {
                return ((string)(this["FromMailAddress"]));
            }
            set {
                this["FromMailAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sathishkumarr2168@gmail.com")]
        public string ToMailAddress {
            get {
                return ((string)(this["ToMailAddress"]));
            }
            set {
                this["ToMailAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smtp.gmail.com")]
        public string SMTPClientAddress {
            get {
                return ((string)(this["SMTPClientAddress"]));
            }
            set {
                this["SMTPClientAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("goqvzhsvdxesivyr")]
        public string SMTPAppPassword {
            get {
                return ((string)(this["SMTPAppPassword"]));
            }
            set {
                this["SMTPAppPassword"] = value;
            }
        }
    }
}
