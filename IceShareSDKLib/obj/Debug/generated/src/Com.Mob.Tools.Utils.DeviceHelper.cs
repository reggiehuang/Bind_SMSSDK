using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/DeviceHelper", DoNotGenerateAcw=true)]
	public partial class DeviceHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/DeviceHelper", typeof (DeviceHelper));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DeviceHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAdvertisingID;
#pragma warning disable 0169
		static Delegate GetGetAdvertisingIDHandler ()
		{
			if (cb_getAdvertisingID == null)
				cb_getAdvertisingID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdvertisingID);
			return cb_getAdvertisingID;
		}

		static IntPtr n_GetAdvertisingID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdvertisingID);
		}
#pragma warning restore 0169

		public virtual unsafe string AdvertisingID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAdvertisingID' and count(parameter)=0]"
			[Register ("getAdvertisingID", "()Ljava/lang/String;", "GetGetAdvertisingIDHandler")]
			get {
				const string __id = "getAdvertisingID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllApp;
#pragma warning disable 0169
		static Delegate GetGetAllAppHandler ()
		{
			if (cb_getAllApp == null)
				cb_getAllApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllApp);
			return cb_getAllApp;
		}

		static IntPtr n_GetAllApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (__this.AllApp);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>> AllApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAllApp' and count(parameter)=0]"
			[Register ("getAllApp", "()Ljava/util/ArrayList;", "GetGetAllAppHandler")]
			get {
				const string __id = "getAllApp.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAndroidID;
#pragma warning disable 0169
		static Delegate GetGetAndroidIDHandler ()
		{
			if (cb_getAndroidID == null)
				cb_getAndroidID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAndroidID);
			return cb_getAndroidID;
		}

		static IntPtr n_GetAndroidID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AndroidID);
		}
#pragma warning restore 0169

		public virtual unsafe string AndroidID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAndroidID' and count(parameter)=0]"
			[Register ("getAndroidID", "()Ljava/lang/String;", "GetGetAndroidIDHandler")]
			get {
				const string __id = "getAndroidID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppLanguage;
#pragma warning disable 0169
		static Delegate GetGetAppLanguageHandler ()
		{
			if (cb_getAppLanguage == null)
				cb_getAppLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppLanguage);
			return cb_getAppLanguage;
		}

		static IntPtr n_GetAppLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppLanguage);
		}
#pragma warning restore 0169

		public virtual unsafe string AppLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAppLanguage' and count(parameter)=0]"
			[Register ("getAppLanguage", "()Ljava/lang/String;", "GetGetAppLanguageHandler")]
			get {
				const string __id = "getAppLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppName;
#pragma warning disable 0169
		static Delegate GetGetAppNameHandler ()
		{
			if (cb_getAppName == null)
				cb_getAppName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppName);
			return cb_getAppName;
		}

		static IntPtr n_GetAppName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppName);
		}
#pragma warning restore 0169

		public virtual unsafe string AppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAppName' and count(parameter)=0]"
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				const string __id = "getAppName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppVersion;
#pragma warning disable 0169
		static Delegate GetGetAppVersionHandler ()
		{
			if (cb_getAppVersion == null)
				cb_getAppVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAppVersion);
			return cb_getAppVersion;
		}

		static int n_GetAppVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AppVersion;
		}
#pragma warning restore 0169

		public virtual unsafe int AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAppVersion' and count(parameter)=0]"
			[Register ("getAppVersion", "()I", "GetGetAppVersionHandler")]
			get {
				const string __id = "getAppVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAppVersionName;
#pragma warning disable 0169
		static Delegate GetGetAppVersionNameHandler ()
		{
			if (cb_getAppVersionName == null)
				cb_getAppVersionName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVersionName);
			return cb_getAppVersionName;
		}

		static IntPtr n_GetAppVersionName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVersionName);
		}
#pragma warning restore 0169

		public virtual unsafe string AppVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAppVersionName' and count(parameter)=0]"
			[Register ("getAppVersionName", "()Ljava/lang/String;", "GetGetAppVersionNameHandler")]
			get {
				const string __id = "getAppVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Android.Content.Context Application {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getApplication' and count(parameter)=0]"
			[Register ("getApplication", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getApplication.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getArpList;
#pragma warning disable 0169
		static Delegate GetGetArpListHandler ()
		{
			if (cb_getArpList == null)
				cb_getArpList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetArpList);
			return cb_getArpList;
		}

		static IntPtr n_GetArpList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.ArpList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> ArpList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getArpList' and count(parameter)=0]"
			[Register ("getArpList", "()Ljava/util/ArrayList;", "GetGetArpListHandler")]
			get {
				const string __id = "getArpList.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAvailableWifiList;
#pragma warning disable 0169
		static Delegate GetGetAvailableWifiListHandler ()
		{
			if (cb_getAvailableWifiList == null)
				cb_getAvailableWifiList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvailableWifiList);
			return cb_getAvailableWifiList;
		}

		static IntPtr n_GetAvailableWifiList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.AvailableWifiList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> AvailableWifiList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAvailableWifiList' and count(parameter)=0]"
			[Register ("getAvailableWifiList", "()Ljava/util/ArrayList;", "GetGetAvailableWifiListHandler")]
			get {
				const string __id = "getAvailableWifiList.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBluetoothName;
#pragma warning disable 0169
		static Delegate GetGetBluetoothNameHandler ()
		{
			if (cb_getBluetoothName == null)
				cb_getBluetoothName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBluetoothName);
			return cb_getBluetoothName;
		}

		static IntPtr n_GetBluetoothName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BluetoothName);
		}
#pragma warning restore 0169

		public virtual unsafe string BluetoothName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getBluetoothName' and count(parameter)=0]"
			[Register ("getBluetoothName", "()Ljava/lang/String;", "GetGetBluetoothNameHandler")]
			get {
				const string __id = "getBluetoothName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBssid;
#pragma warning disable 0169
		static Delegate GetGetBssidHandler ()
		{
			if (cb_getBssid == null)
				cb_getBssid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBssid);
			return cb_getBssid;
		}

		static IntPtr n_GetBssid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Bssid);
		}
#pragma warning restore 0169

		public virtual unsafe string Bssid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getBssid' and count(parameter)=0]"
			[Register ("getBssid", "()Ljava/lang/String;", "GetGetBssidHandler")]
			get {
				const string __id = "getBssid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCPUInfo;
#pragma warning disable 0169
		static Delegate GetGetCPUInfoHandler ()
		{
			if (cb_getCPUInfo == null)
				cb_getCPUInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCPUInfo);
			return cb_getCPUInfo;
		}

		static IntPtr n_GetCPUInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.CPUInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> CPUInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCPUInfo' and count(parameter)=0]"
			[Register ("getCPUInfo", "()Ljava/util/HashMap;", "GetGetCPUInfoHandler")]
			get {
				const string __id = "getCPUInfo.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCarrier;
#pragma warning disable 0169
		static Delegate GetGetCarrierHandler ()
		{
			if (cb_getCarrier == null)
				cb_getCarrier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarrier);
			return cb_getCarrier;
		}

		static IntPtr n_GetCarrier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Carrier);
		}
#pragma warning restore 0169

		public virtual unsafe string Carrier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCarrier' and count(parameter)=0]"
			[Register ("getCarrier", "()Ljava/lang/String;", "GetGetCarrierHandler")]
			get {
				const string __id = "getCarrier.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCarrierName;
#pragma warning disable 0169
		static Delegate GetGetCarrierNameHandler ()
		{
			if (cb_getCarrierName == null)
				cb_getCarrierName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarrierName);
			return cb_getCarrierName;
		}

		static IntPtr n_GetCarrierName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CarrierName);
		}
#pragma warning restore 0169

		public virtual unsafe string CarrierName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCarrierName' and count(parameter)=0]"
			[Register ("getCarrierName", "()Ljava/lang/String;", "GetGetCarrierNameHandler")]
			get {
				const string __id = "getCarrierName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCdmaBid;
#pragma warning disable 0169
		static Delegate GetGetCdmaBidHandler ()
		{
			if (cb_getCdmaBid == null)
				cb_getCdmaBid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCdmaBid);
			return cb_getCdmaBid;
		}

		static int n_GetCdmaBid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CdmaBid;
		}
#pragma warning restore 0169

		public virtual unsafe int CdmaBid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCdmaBid' and count(parameter)=0]"
			[Register ("getCdmaBid", "()I", "GetGetCdmaBidHandler")]
			get {
				const string __id = "getCdmaBid.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCdmaLat;
#pragma warning disable 0169
		static Delegate GetGetCdmaLatHandler ()
		{
			if (cb_getCdmaLat == null)
				cb_getCdmaLat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCdmaLat);
			return cb_getCdmaLat;
		}

		static int n_GetCdmaLat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CdmaLat;
		}
#pragma warning restore 0169

		public virtual unsafe int CdmaLat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCdmaLat' and count(parameter)=0]"
			[Register ("getCdmaLat", "()I", "GetGetCdmaLatHandler")]
			get {
				const string __id = "getCdmaLat.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCdmaLon;
#pragma warning disable 0169
		static Delegate GetGetCdmaLonHandler ()
		{
			if (cb_getCdmaLon == null)
				cb_getCdmaLon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCdmaLon);
			return cb_getCdmaLon;
		}

		static int n_GetCdmaLon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CdmaLon;
		}
#pragma warning restore 0169

		public virtual unsafe int CdmaLon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCdmaLon' and count(parameter)=0]"
			[Register ("getCdmaLon", "()I", "GetGetCdmaLonHandler")]
			get {
				const string __id = "getCdmaLon.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCdmaNid;
#pragma warning disable 0169
		static Delegate GetGetCdmaNidHandler ()
		{
			if (cb_getCdmaNid == null)
				cb_getCdmaNid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCdmaNid);
			return cb_getCdmaNid;
		}

		static int n_GetCdmaNid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CdmaNid;
		}
#pragma warning restore 0169

		public virtual unsafe int CdmaNid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCdmaNid' and count(parameter)=0]"
			[Register ("getCdmaNid", "()I", "GetGetCdmaNidHandler")]
			get {
				const string __id = "getCdmaNid.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCdmaSid;
#pragma warning disable 0169
		static Delegate GetGetCdmaSidHandler ()
		{
			if (cb_getCdmaSid == null)
				cb_getCdmaSid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCdmaSid);
			return cb_getCdmaSid;
		}

		static int n_GetCdmaSid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CdmaSid;
		}
#pragma warning restore 0169

		public virtual unsafe int CdmaSid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCdmaSid' and count(parameter)=0]"
			[Register ("getCdmaSid", "()I", "GetGetCdmaSidHandler")]
			get {
				const string __id = "getCdmaSid.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCellId;
#pragma warning disable 0169
		static Delegate GetGetCellIdHandler ()
		{
			if (cb_getCellId == null)
				cb_getCellId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCellId);
			return cb_getCellId;
		}

		static int n_GetCellId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CellId;
		}
#pragma warning restore 0169

		public virtual unsafe int CellId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCellId' and count(parameter)=0]"
			[Register ("getCellId", "()I", "GetGetCellIdHandler")]
			get {
				const string __id = "getCellId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCellLac;
#pragma warning disable 0169
		static Delegate GetGetCellLacHandler ()
		{
			if (cb_getCellLac == null)
				cb_getCellLac = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCellLac);
			return cb_getCellLac;
		}

		static int n_GetCellLac (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CellLac;
		}
#pragma warning restore 0169

		public virtual unsafe int CellLac {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCellLac' and count(parameter)=0]"
			[Register ("getCellLac", "()I", "GetGetCellLacHandler")]
			get {
				const string __id = "getCellLac.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDetailNetworkTypeForStatic;
#pragma warning disable 0169
		static Delegate GetGetDetailNetworkTypeForStaticHandler ()
		{
			if (cb_getDetailNetworkTypeForStatic == null)
				cb_getDetailNetworkTypeForStatic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDetailNetworkTypeForStatic);
			return cb_getDetailNetworkTypeForStatic;
		}

		static IntPtr n_GetDetailNetworkTypeForStatic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DetailNetworkTypeForStatic);
		}
#pragma warning restore 0169

		public virtual unsafe string DetailNetworkTypeForStatic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getDetailNetworkTypeForStatic' and count(parameter)=0]"
			[Register ("getDetailNetworkTypeForStatic", "()Ljava/lang/String;", "GetGetDetailNetworkTypeForStaticHandler")]
			get {
				const string __id = "getDetailNetworkTypeForStatic.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceData;
#pragma warning disable 0169
		static Delegate GetGetDeviceDataHandler ()
		{
			if (cb_getDeviceData == null)
				cb_getDeviceData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceData);
			return cb_getDeviceData;
		}

		static IntPtr n_GetDeviceData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceData);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getDeviceData' and count(parameter)=0]"
			[Register ("getDeviceData", "()Ljava/lang/String;", "GetGetDeviceDataHandler")]
			get {
				const string __id = "getDeviceData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceDataNotAES;
#pragma warning disable 0169
		static Delegate GetGetDeviceDataNotAESHandler ()
		{
			if (cb_getDeviceDataNotAES == null)
				cb_getDeviceDataNotAES = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceDataNotAES);
			return cb_getDeviceDataNotAES;
		}

		static IntPtr n_GetDeviceDataNotAES (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceDataNotAES);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceDataNotAES {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getDeviceDataNotAES' and count(parameter)=0]"
			[Register ("getDeviceDataNotAES", "()Ljava/lang/String;", "GetGetDeviceDataNotAESHandler")]
			get {
				const string __id = "getDeviceDataNotAES.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				const string __id = "getDeviceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceKey;
#pragma warning disable 0169
		static Delegate GetGetDeviceKeyHandler ()
		{
			if (cb_getDeviceKey == null)
				cb_getDeviceKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceKey);
			return cb_getDeviceKey;
		}

		static IntPtr n_GetDeviceKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceKey);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getDeviceKey' and count(parameter)=0]"
			[Register ("getDeviceKey", "()Ljava/lang/String;", "GetGetDeviceKeyHandler")]
			get {
				const string __id = "getDeviceKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceType);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Ljava/lang/String;", "GetGetDeviceTypeHandler")]
			get {
				const string __id = "getDeviceType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFixedString;
#pragma warning disable 0169
		static Delegate GetGetFixedStringHandler ()
		{
			if (cb_getFixedString == null)
				cb_getFixedString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFixedString);
			return cb_getFixedString;
		}

		static IntPtr n_GetFixedString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FixedString);
		}
#pragma warning restore 0169

		public virtual unsafe string FixedString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getFixedString' and count(parameter)=0]"
			[Register ("getFixedString", "()Ljava/lang/String;", "GetGetFixedStringHandler")]
			get {
				const string __id = "getFixedString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIMEI;
#pragma warning disable 0169
		static Delegate GetGetIMEIHandler ()
		{
			if (cb_getIMEI == null)
				cb_getIMEI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIMEI);
			return cb_getIMEI;
		}

		static IntPtr n_GetIMEI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IMEI);
		}
#pragma warning restore 0169

		public virtual unsafe string IMEI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getIMEI' and count(parameter)=0]"
			[Register ("getIMEI", "()Ljava/lang/String;", "GetGetIMEIHandler")]
			get {
				const string __id = "getIMEI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIMSI;
#pragma warning disable 0169
		static Delegate GetGetIMSIHandler ()
		{
			if (cb_getIMSI == null)
				cb_getIMSI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIMSI);
			return cb_getIMSI;
		}

		static IntPtr n_GetIMSI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IMSI);
		}
#pragma warning restore 0169

		public virtual unsafe string IMSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getIMSI' and count(parameter)=0]"
			[Register ("getIMSI", "()Ljava/lang/String;", "GetGetIMSIHandler")]
			get {
				const string __id = "getIMSI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIPAddress;
#pragma warning disable 0169
		static Delegate GetGetIPAddressHandler ()
		{
			if (cb_getIPAddress == null)
				cb_getIPAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIPAddress);
			return cb_getIPAddress;
		}

		static IntPtr n_GetIPAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IPAddress);
		}
#pragma warning restore 0169

		public virtual unsafe string IPAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getIPAddress' and count(parameter)=0]"
			[Register ("getIPAddress", "()Ljava/lang/String;", "GetGetIPAddressHandler")]
			get {
				const string __id = "getIPAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRooted;
#pragma warning disable 0169
		static Delegate GetIsRootedHandler ()
		{
			if (cb_isRooted == null)
				cb_isRooted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRooted);
			return cb_isRooted;
		}

		static bool n_IsRooted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRooted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRooted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='isRooted' and count(parameter)=0]"
			[Register ("isRooted", "()Z", "GetIsRootedHandler")]
			get {
				const string __id = "isRooted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLine1Number;
#pragma warning disable 0169
		static Delegate GetGetLine1NumberHandler ()
		{
			if (cb_getLine1Number == null)
				cb_getLine1Number = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLine1Number);
			return cb_getLine1Number;
		}

		static IntPtr n_GetLine1Number (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Line1Number);
		}
#pragma warning restore 0169

		public virtual unsafe string Line1Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getLine1Number' and count(parameter)=0]"
			[Register ("getLine1Number", "()Ljava/lang/String;", "GetGetLine1NumberHandler")]
			get {
				const string __id = "getLine1Number.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMCC;
#pragma warning disable 0169
		static Delegate GetGetMCCHandler ()
		{
			if (cb_getMCC == null)
				cb_getMCC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMCC);
			return cb_getMCC;
		}

		static IntPtr n_GetMCC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MCC);
		}
#pragma warning restore 0169

		public virtual unsafe string MCC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getMCC' and count(parameter)=0]"
			[Register ("getMCC", "()Ljava/lang/String;", "GetGetMCCHandler")]
			get {
				const string __id = "getMCC.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMIUIVersion;
#pragma warning disable 0169
		static Delegate GetGetMIUIVersionHandler ()
		{
			if (cb_getMIUIVersion == null)
				cb_getMIUIVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMIUIVersion);
			return cb_getMIUIVersion;
		}

		static IntPtr n_GetMIUIVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MIUIVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string MIUIVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getMIUIVersion' and count(parameter)=0]"
			[Register ("getMIUIVersion", "()Ljava/lang/String;", "GetGetMIUIVersionHandler")]
			get {
				const string __id = "getMIUIVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMNC;
#pragma warning disable 0169
		static Delegate GetGetMNCHandler ()
		{
			if (cb_getMNC == null)
				cb_getMNC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMNC);
			return cb_getMNC;
		}

		static IntPtr n_GetMNC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MNC);
		}
#pragma warning restore 0169

		public virtual unsafe string MNC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getMNC' and count(parameter)=0]"
			[Register ("getMNC", "()Ljava/lang/String;", "GetGetMNCHandler")]
			get {
				const string __id = "getMNC.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMacAddress;
#pragma warning disable 0169
		static Delegate GetGetMacAddressHandler ()
		{
			if (cb_getMacAddress == null)
				cb_getMacAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMacAddress);
			return cb_getMacAddress;
		}

		static IntPtr n_GetMacAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MacAddress);
		}
#pragma warning restore 0169

		public virtual unsafe string MacAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getMacAddress' and count(parameter)=0]"
			[Register ("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")]
			get {
				const string __id = "getMacAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getManufacturer;
#pragma warning disable 0169
		static Delegate GetGetManufacturerHandler ()
		{
			if (cb_getManufacturer == null)
				cb_getManufacturer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetManufacturer);
			return cb_getManufacturer;
		}

		static IntPtr n_GetManufacturer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Manufacturer);
		}
#pragma warning restore 0169

		public virtual unsafe string Manufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getManufacturer' and count(parameter)=0]"
			[Register ("getManufacturer", "()Ljava/lang/String;", "GetGetManufacturerHandler")]
			get {
				const string __id = "getManufacturer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMemoryInfo;
#pragma warning disable 0169
		static Delegate GetGetMemoryInfoHandler ()
		{
			if (cb_getMemoryInfo == null)
				cb_getMemoryInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMemoryInfo);
			return cb_getMemoryInfo;
		}

		static IntPtr n_GetMemoryInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.ToLocalJniHandle (__this.MemoryInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long> MemoryInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getMemoryInfo' and count(parameter)=0]"
			[Register ("getMemoryInfo", "()Ljava/util/HashMap;", "GetGetMemoryInfoHandler")]
			get {
				const string __id = "getMemoryInfo.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Long>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model);
		}
#pragma warning restore 0169

		public virtual unsafe string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
			get {
				const string __id = "getModel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNeighboringCellInfo;
#pragma warning disable 0169
		static Delegate GetGetNeighboringCellInfoHandler ()
		{
			if (cb_getNeighboringCellInfo == null)
				cb_getNeighboringCellInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNeighboringCellInfo);
			return cb_getNeighboringCellInfo;
		}

		static IntPtr n_GetNeighboringCellInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.NeighboringCellInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> NeighboringCellInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getNeighboringCellInfo' and count(parameter)=0]"
			[Register ("getNeighboringCellInfo", "()Ljava/util/ArrayList;", "GetGetNeighboringCellInfoHandler")]
			get {
				const string __id = "getNeighboringCellInfo.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkOperator;
#pragma warning disable 0169
		static Delegate GetGetNetworkOperatorHandler ()
		{
			if (cb_getNetworkOperator == null)
				cb_getNetworkOperator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkOperator);
			return cb_getNetworkOperator;
		}

		static IntPtr n_GetNetworkOperator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkOperator);
		}
#pragma warning restore 0169

		public virtual unsafe string NetworkOperator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getNetworkOperator' and count(parameter)=0]"
			[Register ("getNetworkOperator", "()Ljava/lang/String;", "GetGetNetworkOperatorHandler")]
			get {
				const string __id = "getNetworkOperator.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkType;
#pragma warning disable 0169
		static Delegate GetGetNetworkTypeHandler ()
		{
			if (cb_getNetworkType == null)
				cb_getNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkType);
			return cb_getNetworkType;
		}

		static IntPtr n_GetNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkType);
		}
#pragma warning restore 0169

		public virtual unsafe string NetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getNetworkType' and count(parameter)=0]"
			[Register ("getNetworkType", "()Ljava/lang/String;", "GetGetNetworkTypeHandler")]
			get {
				const string __id = "getNetworkType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkTypeForStatic;
#pragma warning disable 0169
		static Delegate GetGetNetworkTypeForStaticHandler ()
		{
			if (cb_getNetworkTypeForStatic == null)
				cb_getNetworkTypeForStatic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkTypeForStatic);
			return cb_getNetworkTypeForStatic;
		}

		static IntPtr n_GetNetworkTypeForStatic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkTypeForStatic);
		}
#pragma warning restore 0169

		public virtual unsafe string NetworkTypeForStatic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getNetworkTypeForStatic' and count(parameter)=0]"
			[Register ("getNetworkTypeForStatic", "()Ljava/lang/String;", "GetGetNetworkTypeForStaticHandler")]
			get {
				const string __id = "getNetworkTypeForStatic.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOSCountry;
#pragma warning disable 0169
		static Delegate GetGetOSCountryHandler ()
		{
			if (cb_getOSCountry == null)
				cb_getOSCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOSCountry);
			return cb_getOSCountry;
		}

		static IntPtr n_GetOSCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OSCountry);
		}
#pragma warning restore 0169

		public virtual unsafe string OSCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getOSCountry' and count(parameter)=0]"
			[Register ("getOSCountry", "()Ljava/lang/String;", "GetGetOSCountryHandler")]
			get {
				const string __id = "getOSCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOSLanguage;
#pragma warning disable 0169
		static Delegate GetGetOSLanguageHandler ()
		{
			if (cb_getOSLanguage == null)
				cb_getOSLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOSLanguage);
			return cb_getOSLanguage;
		}

		static IntPtr n_GetOSLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OSLanguage);
		}
#pragma warning restore 0169

		public virtual unsafe string OSLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getOSLanguage' and count(parameter)=0]"
			[Register ("getOSLanguage", "()Ljava/lang/String;", "GetGetOSLanguageHandler")]
			get {
				const string __id = "getOSLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOSVersionInt;
#pragma warning disable 0169
		static Delegate GetGetOSVersionIntHandler ()
		{
			if (cb_getOSVersionInt == null)
				cb_getOSVersionInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOSVersionInt);
			return cb_getOSVersionInt;
		}

		static int n_GetOSVersionInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OSVersionInt;
		}
#pragma warning restore 0169

		public virtual unsafe int OSVersionInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getOSVersionInt' and count(parameter)=0]"
			[Register ("getOSVersionInt", "()I", "GetGetOSVersionIntHandler")]
			get {
				const string __id = "getOSVersionInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOSVersionName;
#pragma warning disable 0169
		static Delegate GetGetOSVersionNameHandler ()
		{
			if (cb_getOSVersionName == null)
				cb_getOSVersionName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOSVersionName);
			return cb_getOSVersionName;
		}

		static IntPtr n_GetOSVersionName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OSVersionName);
		}
#pragma warning restore 0169

		public virtual unsafe string OSVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getOSVersionName' and count(parameter)=0]"
			[Register ("getOSVersionName", "()Ljava/lang/String;", "GetGetOSVersionNameHandler")]
			get {
				const string __id = "getOSVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformCode;
#pragma warning disable 0169
		static Delegate GetGetPlatformCodeHandler ()
		{
			if (cb_getPlatformCode == null)
				cb_getPlatformCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPlatformCode);
			return cb_getPlatformCode;
		}

		static int n_GetPlatformCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlatformCode;
		}
#pragma warning restore 0169

		public virtual unsafe int PlatformCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getPlatformCode' and count(parameter)=0]"
			[Register ("getPlatformCode", "()I", "GetGetPlatformCodeHandler")]
			get {
				const string __id = "getPlatformCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPsc;
#pragma warning disable 0169
		static Delegate GetGetPscHandler ()
		{
			if (cb_getPsc == null)
				cb_getPsc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPsc);
			return cb_getPsc;
		}

		static int n_GetPsc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Psc;
		}
#pragma warning restore 0169

		public virtual unsafe int Psc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getPsc' and count(parameter)=0]"
			[Register ("getPsc", "()I", "GetGetPscHandler")]
			get {
				const string __id = "getPsc.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getQemuKernel;
#pragma warning disable 0169
		static Delegate GetGetQemuKernelHandler ()
		{
			if (cb_getQemuKernel == null)
				cb_getQemuKernel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQemuKernel);
			return cb_getQemuKernel;
		}

		static IntPtr n_GetQemuKernel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.QemuKernel);
		}
#pragma warning restore 0169

		public virtual unsafe string QemuKernel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getQemuKernel' and count(parameter)=0]"
			[Register ("getQemuKernel", "()Ljava/lang/String;", "GetGetQemuKernelHandler")]
			get {
				const string __id = "getQemuKernel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSSID;
#pragma warning disable 0169
		static Delegate GetGetSSIDHandler ()
		{
			if (cb_getSSID == null)
				cb_getSSID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSSID);
			return cb_getSSID;
		}

		static IntPtr n_GetSSID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SSID);
		}
#pragma warning restore 0169

		public virtual unsafe string SSID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSSID' and count(parameter)=0]"
			[Register ("getSSID", "()Ljava/lang/String;", "GetGetSSIDHandler")]
			get {
				const string __id = "getSSID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScreenBrightness;
#pragma warning disable 0169
		static Delegate GetGetScreenBrightnessHandler ()
		{
			if (cb_getScreenBrightness == null)
				cb_getScreenBrightness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScreenBrightness);
			return cb_getScreenBrightness;
		}

		static int n_GetScreenBrightness (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScreenBrightness;
		}
#pragma warning restore 0169

		public virtual unsafe int ScreenBrightness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getScreenBrightness' and count(parameter)=0]"
			[Register ("getScreenBrightness", "()I", "GetGetScreenBrightnessHandler")]
			get {
				const string __id = "getScreenBrightness.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScreenBrightnessMode;
#pragma warning disable 0169
		static Delegate GetGetScreenBrightnessModeHandler ()
		{
			if (cb_getScreenBrightnessMode == null)
				cb_getScreenBrightnessMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScreenBrightnessMode);
			return cb_getScreenBrightnessMode;
		}

		static int n_GetScreenBrightnessMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScreenBrightnessMode;
		}
#pragma warning restore 0169

		public virtual unsafe int ScreenBrightnessMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getScreenBrightnessMode' and count(parameter)=0]"
			[Register ("getScreenBrightnessMode", "()I", "GetGetScreenBrightnessModeHandler")]
			get {
				const string __id = "getScreenBrightnessMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScreenSize;
#pragma warning disable 0169
		static Delegate GetGetScreenSizeHandler ()
		{
			if (cb_getScreenSize == null)
				cb_getScreenSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScreenSize);
			return cb_getScreenSize;
		}

		static IntPtr n_GetScreenSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScreenSize);
		}
#pragma warning restore 0169

		public virtual unsafe string ScreenSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getScreenSize' and count(parameter)=0]"
			[Register ("getScreenSize", "()Ljava/lang/String;", "GetGetScreenSizeHandler")]
			get {
				const string __id = "getScreenSize.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSdcardPath;
#pragma warning disable 0169
		static Delegate GetGetSdcardPathHandler ()
		{
			if (cb_getSdcardPath == null)
				cb_getSdcardPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSdcardPath);
			return cb_getSdcardPath;
		}

		static IntPtr n_GetSdcardPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdcardPath);
		}
#pragma warning restore 0169

		public virtual unsafe string SdcardPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSdcardPath' and count(parameter)=0]"
			[Register ("getSdcardPath", "()Ljava/lang/String;", "GetGetSdcardPathHandler")]
			get {
				const string __id = "getSdcardPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSdcardState;
#pragma warning disable 0169
		static Delegate GetGetSdcardStateHandler ()
		{
			if (cb_getSdcardState == null)
				cb_getSdcardState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSdcardState);
			return cb_getSdcardState;
		}

		static bool n_GetSdcardState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SdcardState;
		}
#pragma warning restore 0169

		public virtual unsafe bool SdcardState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSdcardState' and count(parameter)=0]"
			[Register ("getSdcardState", "()Z", "GetGetSdcardStateHandler")]
			get {
				const string __id = "getSdcardState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSerialno;
#pragma warning disable 0169
		static Delegate GetGetSerialnoHandler ()
		{
			if (cb_getSerialno == null)
				cb_getSerialno = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialno);
			return cb_getSerialno;
		}

		static IntPtr n_GetSerialno (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Serialno);
		}
#pragma warning restore 0169

		public virtual unsafe string Serialno {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSerialno' and count(parameter)=0]"
			[Register ("getSerialno", "()Ljava/lang/String;", "GetGetSerialnoHandler")]
			get {
				const string __id = "getSerialno.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSignMD5;
#pragma warning disable 0169
		static Delegate GetGetSignMD5Handler ()
		{
			if (cb_getSignMD5 == null)
				cb_getSignMD5 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignMD5);
			return cb_getSignMD5;
		}

		static IntPtr n_GetSignMD5 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignMD5);
		}
#pragma warning restore 0169

		public virtual unsafe string SignMD5 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSignMD5' and count(parameter)=0]"
			[Register ("getSignMD5", "()Ljava/lang/String;", "GetGetSignMD5Handler")]
			get {
				const string __id = "getSignMD5.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSimSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSimSerialNumberHandler ()
		{
			if (cb_getSimSerialNumber == null)
				cb_getSimSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSimSerialNumber);
			return cb_getSimSerialNumber;
		}

		static IntPtr n_GetSimSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SimSerialNumber);
		}
#pragma warning restore 0169

		public virtual unsafe string SimSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSimSerialNumber' and count(parameter)=0]"
			[Register ("getSimSerialNumber", "()Ljava/lang/String;", "GetGetSimSerialNumberHandler")]
			get {
				const string __id = "getSimSerialNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSizeInfo;
#pragma warning disable 0169
		static Delegate GetGetSizeInfoHandler ()
		{
			if (cb_getSizeInfo == null)
				cb_getSizeInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSizeInfo);
			return cb_getSizeInfo;
		}

		static IntPtr n_GetSizeInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long>>.ToLocalJniHandle (__this.SizeInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long>> SizeInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSizeInfo' and count(parameter)=0]"
			[Register ("getSizeInfo", "()Ljava/util/HashMap;", "GetGetSizeInfoHandler")]
			get {
				const string __id = "getSizeInfo.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Long>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatusBarHeight;
#pragma warning disable 0169
		static Delegate GetGetStatusBarHeightHandler ()
		{
			if (cb_getStatusBarHeight == null)
				cb_getStatusBarHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusBarHeight);
			return cb_getStatusBarHeight;
		}

		static int n_GetStatusBarHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusBarHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int StatusBarHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getStatusBarHeight' and count(parameter)=0]"
			[Register ("getStatusBarHeight", "()I", "GetGetStatusBarHeightHandler")]
			get {
				const string __id = "getStatusBarHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSystemApp;
#pragma warning disable 0169
		static Delegate GetGetSystemAppHandler ()
		{
			if (cb_getSystemApp == null)
				cb_getSystemApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSystemApp);
			return cb_getSystemApp;
		}

		static IntPtr n_GetSystemApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (__this.SystemApp);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>> SystemApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSystemApp' and count(parameter)=0]"
			[Register ("getSystemApp", "()Ljava/util/ArrayList;", "GetGetSystemAppHandler")]
			get {
				const string __id = "getSystemApp.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTTYDriversInfo;
#pragma warning disable 0169
		static Delegate GetGetTTYDriversInfoHandler ()
		{
			if (cb_getTTYDriversInfo == null)
				cb_getTTYDriversInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTTYDriversInfo);
			return cb_getTTYDriversInfo;
		}

		static IntPtr n_GetTTYDriversInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.TTYDriversInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> TTYDriversInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getTTYDriversInfo' and count(parameter)=0]"
			[Register ("getTTYDriversInfo", "()Ljava/util/ArrayList;", "GetGetTTYDriversInfoHandler")]
			get {
				const string __id = "getTTYDriversInfo.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTopActivity;
#pragma warning disable 0169
		static Delegate GetGetTopActivityHandler ()
		{
			if (cb_getTopActivity == null)
				cb_getTopActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopActivity);
			return cb_getTopActivity;
		}

		static IntPtr n_GetTopActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopActivity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity TopActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getTopActivity' and count(parameter)=0]"
			[Register ("getTopActivity", "()Landroid/app/Activity;", "GetGetTopActivityHandler")]
			get {
				const string __id = "getTopActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWallPaper;
#pragma warning disable 0169
		static Delegate GetGetWallPaperHandler ()
		{
			if (cb_getWallPaper == null)
				cb_getWallPaper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWallPaper);
			return cb_getWallPaper;
		}

		static IntPtr n_GetWallPaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WallPaper);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap WallPaper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getWallPaper' and count(parameter)=0]"
			[Register ("getWallPaper", "()Landroid/graphics/Bitmap;", "GetGetWallPaperHandler")]
			get {
				const string __id = "getWallPaper.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_Base64AES_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBase64AES_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Base64AES_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_Base64AES_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Base64AES_Ljava_lang_String_Ljava_lang_String_);
			return cb_Base64AES_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Base64AES_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_key)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Base64AES (msg, key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='Base64AES' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Base64AES", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetBase64AES_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Base64AES (string msg, string key)
		{
			const string __id = "Base64AES.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_amIOnForeground;
#pragma warning disable 0169
		static Delegate GetAmIOnForegroundHandler ()
		{
			if (cb_amIOnForeground == null)
				cb_amIOnForeground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AmIOnForeground);
			return cb_amIOnForeground;
		}

		static bool n_AmIOnForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AmIOnForeground ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='amIOnForeground' and count(parameter)=0]"
		[Register ("amIOnForeground", "()Z", "GetAmIOnForegroundHandler")]
		public virtual unsafe bool AmIOnForeground ()
		{
			const string __id = "amIOnForeground.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkPermission_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckPermission_Ljava_lang_String_Handler ()
		{
			if (cb_checkPermission_Ljava_lang_String_ == null)
				cb_checkPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CheckPermission_Ljava_lang_String_);
			return cb_checkPermission_Ljava_lang_String_;
		}

		static bool n_CheckPermission_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckPermission (permission);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='checkPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkPermission", "(Ljava/lang/String;)Z", "GetCheckPermission_Ljava_lang_String_Handler")]
		public virtual unsafe bool CheckPermission (string permission)
		{
			const string __id = "checkPermission.(Ljava/lang/String;)Z";
			IntPtr native_permission = JNIEnv.NewString (permission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_permission);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='currentActivityThread' and count(parameter)=0]"
		[Register ("currentActivityThread", "()Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CurrentActivityThread ()
		{
			const string __id = "currentActivityThread.()Ljava/lang/Object;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAppList_ZZ;
#pragma warning disable 0169
		static Delegate GetGetAppList_ZZHandler ()
		{
			if (cb_getAppList_ZZ == null)
				cb_getAppList_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool, IntPtr>) n_GetAppList_ZZ);
			return cb_getAppList_ZZ;
		}

		static IntPtr n_GetAppList_ZZ (IntPtr jnienv, IntPtr native__this, bool onlySystem, bool includeSystemApp)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (__this.GetAppList (onlySystem, includeSystemApp));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getAppList' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("getAppList", "(ZZ)Ljava/util/ArrayList;", "GetGetAppList_ZZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>> GetAppList (bool onlySystem, bool includeSystemApp)
		{
			const string __id = "getAppList.(ZZ)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (onlySystem);
				__args [1] = new JniArgumentValue (includeSystemApp);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_;
#pragma warning disable 0169
		static Delegate GetGetBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_Handler ()
		{
			if (cb_getBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_ == null)
				cb_getBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_);
			return cb_getBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_;
		}

		static void n_GetBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable @callback = (global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetBatteryState (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getBatteryState' and count(parameter)=1 and parameter[1][@type='com.mob.tools.utils.ReflectHelper.ReflectRunnable&lt;java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;, java.lang.Void&gt;']]"
		[Register ("getBatteryState", "(Lcom/mob/tools/utils/ReflectHelper$ReflectRunnable;)V", "GetGetBatteryState_Lcom_mob_tools_utils_ReflectHelper_ReflectRunnable_Handler")]
		public virtual unsafe void GetBatteryState (global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable @callback)
		{
			const string __id = "getBatteryState.(Lcom/mob/tools/utils/ReflectHelper$ReflectRunnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCharAndNumr_I;
#pragma warning disable 0169
		static Delegate GetGetCharAndNumr_IHandler ()
		{
			if (cb_getCharAndNumr_I == null)
				cb_getCharAndNumr_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetCharAndNumr_I);
			return cb_getCharAndNumr_I;
		}

		static IntPtr n_GetCharAndNumr_I (IntPtr jnienv, IntPtr native__this, int length)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetCharAndNumr (length));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getCharAndNumr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCharAndNumr", "(I)Ljava/lang/String;", "GetGetCharAndNumr_IHandler")]
		public virtual unsafe string GetCharAndNumr (int length)
		{
			const string __id = "getCharAndNumr.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getInstalledApp_Z;
#pragma warning disable 0169
		static Delegate GetGetInstalledApp_ZHandler ()
		{
			if (cb_getInstalledApp_Z == null)
				cb_getInstalledApp_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_GetInstalledApp_Z);
			return cb_getInstalledApp_Z;
		}

		static IntPtr n_GetInstalledApp_Z (IntPtr jnienv, IntPtr native__this, bool includeSystemApp)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (__this.GetInstalledApp (includeSystemApp));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getInstalledApp' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getInstalledApp", "(Z)Ljava/util/ArrayList;", "GetGetInstalledApp_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>> GetInstalledApp (bool includeSystemApp)
		{
			const string __id = "getInstalledApp.(Z)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (includeSystemApp);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/mob/tools/utils/DeviceHelper;", "")]
		public static unsafe global::Com.Mob.Tools.Utils.DeviceHelper GetInstance (global::Android.Content.Context c)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/mob/tools/utils/DeviceHelper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLocation_IIZ;
#pragma warning disable 0169
		static Delegate GetGetLocation_IIZHandler ()
		{
			if (cb_getLocation_IIZ == null)
				cb_getLocation_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool, IntPtr>) n_GetLocation_IIZ);
			return cb_getLocation_IIZ;
		}

		static IntPtr n_GetLocation_IIZ (IntPtr jnienv, IntPtr native__this, int GPSTimeout, int networkTimeout, bool useLastKnown)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLocation (GPSTimeout, networkTimeout, useLastKnown));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getLocation' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getLocation", "(IIZ)Landroid/location/Location;", "GetGetLocation_IIZHandler")]
		public virtual unsafe global::Android.Locations.Location GetLocation (int GPSTimeout, int networkTimeout, bool useLastKnown)
		{
			const string __id = "getLocation.(IIZ)Landroid/location/Location;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (GPSTimeout);
				__args [1] = new JniArgumentValue (networkTimeout);
				__args [2] = new JniArgumentValue (useLastKnown);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSystemServiceSafe_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSystemServiceSafe_Ljava_lang_String_Handler ()
		{
			if (cb_getSystemServiceSafe_Ljava_lang_String_ == null)
				cb_getSystemServiceSafe_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSystemServiceSafe_Ljava_lang_String_);
			return cb_getSystemServiceSafe_Ljava_lang_String_;
		}

		static IntPtr n_GetSystemServiceSafe_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSystemServiceSafe (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getSystemServiceSafe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSystemServiceSafe", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetSystemServiceSafe_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetSystemServiceSafe (string name)
		{
			const string __id = "getSystemServiceSafe.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getWAbcd_I;
#pragma warning disable 0169
		static Delegate GetGetWAbcd_IHandler ()
		{
			if (cb_getWAbcd_I == null)
				cb_getWAbcd_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetWAbcd_I);
			return cb_getWAbcd_I;
		}

		static IntPtr n_GetWAbcd_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetWAbcd (type));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='getWAbcd' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWAbcd", "(I)Ljava/lang/String;", "GetGetWAbcd_IHandler")]
		public virtual unsafe string GetWAbcd (int type)
		{
			const string __id = "getWAbcd.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideSoftInput_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetHideSoftInput_Landroid_view_View_Handler ()
		{
			if (cb_hideSoftInput_Landroid_view_View_ == null)
				cb_hideSoftInput_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HideSoftInput_Landroid_view_View_);
			return cb_hideSoftInput_Landroid_view_View_;
		}

		static void n_HideSoftInput_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.HideSoftInput (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='hideSoftInput' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("hideSoftInput", "(Landroid/view/View;)V", "GetHideSoftInput_Landroid_view_View_Handler")]
		public virtual unsafe void HideSoftInput (global::Android.Views.View view)
		{
			const string __id = "hideSoftInput.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isPackageInstalled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsPackageInstalled_Ljava_lang_String_Handler ()
		{
			if (cb_isPackageInstalled_Ljava_lang_String_ == null)
				cb_isPackageInstalled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPackageInstalled_Ljava_lang_String_);
			return cb_isPackageInstalled_Ljava_lang_String_;
		}

		static bool n_IsPackageInstalled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPackageInstalled (packageName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='isPackageInstalled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPackageInstalled", "(Ljava/lang/String;)Z", "GetIsPackageInstalled_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsPackageInstalled (string packageName)
		{
			const string __id = "isPackageInstalled.(Ljava/lang/String;)Z";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packageName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		static Delegate cb_listNetworkHardware;
#pragma warning disable 0169
		static Delegate GetListNetworkHardwareHandler ()
		{
			if (cb_listNetworkHardware == null)
				cb_listNetworkHardware = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ListNetworkHardware);
			return cb_listNetworkHardware;
		}

		static IntPtr n_ListNetworkHardware (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ListNetworkHardware ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='listNetworkHardware' and count(parameter)=0]"
		[Register ("listNetworkHardware", "()Ljava/util/HashMap;", "GetListNetworkHardwareHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ListNetworkHardware ()
		{
			const string __id = "listNetworkHardware.()Ljava/util/HashMap;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ping_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetPing_Ljava_lang_String_IIHandler ()
		{
			if (cb_ping_Ljava_lang_String_II == null)
				cb_ping_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Ping_Ljava_lang_String_II);
			return cb_ping_Ljava_lang_String_II;
		}

		static IntPtr n_Ping_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_address, int count, int packetsize)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Ping (address, count, packetsize));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ping", "(Ljava/lang/String;II)Ljava/util/HashMap;", "GetPing_Ljava_lang_String_IIHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Ping (string address, int count, int packetsize)
		{
			const string __id = "ping.(Ljava/lang/String;II)Ljava/util/HashMap;";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue (count);
				__args [2] = new JniArgumentValue (packetsize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_queryIMEI;
#pragma warning disable 0169
		static Delegate GetQueryIMEIHandler ()
		{
			if (cb_queryIMEI == null)
				cb_queryIMEI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_QueryIMEI);
			return cb_queryIMEI;
		}

		static IntPtr n_QueryIMEI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.QueryIMEI ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='queryIMEI' and count(parameter)=0]"
		[Register ("queryIMEI", "()[Ljava/lang/String;", "GetQueryIMEIHandler")]
		public virtual unsafe string[] QueryIMEI ()
		{
			const string __id = "queryIMEI.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_queryIMSI;
#pragma warning disable 0169
		static Delegate GetQueryIMSIHandler ()
		{
			if (cb_queryIMSI == null)
				cb_queryIMSI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_QueryIMSI);
			return cb_queryIMSI;
		}

		static IntPtr n_QueryIMSI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.QueryIMSI ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='queryIMSI' and count(parameter)=0]"
		[Register ("queryIMSI", "()[Ljava/lang/String;", "GetQueryIMSIHandler")]
		public virtual unsafe string[] QueryIMSI ()
		{
			const string __id = "queryIMSI.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_saveWabcd_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSaveWabcd_Ljava_lang_String_IHandler ()
		{
			if (cb_saveWabcd_Ljava_lang_String_I == null)
				cb_saveWabcd_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SaveWabcd_Ljava_lang_String_I);
			return cb_saveWabcd_Ljava_lang_String_I;
		}

		static void n_SaveWabcd_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int type)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SaveWabcd (data, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='saveWabcd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("saveWabcd", "(Ljava/lang/String;I)V", "GetSaveWabcd_Ljava_lang_String_IHandler")]
		public virtual unsafe void SaveWabcd (string data, int type)
		{
			const string __id = "saveWabcd.(Ljava/lang/String;I)V";
			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static Delegate cb_scanWifiList;
#pragma warning disable 0169
		static Delegate GetScanWifiListHandler ()
		{
			if (cb_scanWifiList == null)
				cb_scanWifiList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ScanWifiList);
			return cb_scanWifiList;
		}

		static bool n_ScanWifiList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScanWifiList ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='scanWifiList' and count(parameter)=0]"
		[Register ("scanWifiList", "()Z", "GetScanWifiListHandler")]
		public virtual unsafe bool ScanWifiList ()
		{
			const string __id = "scanWifiList.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_showSoftInput_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetShowSoftInput_Landroid_view_View_Handler ()
		{
			if (cb_showSoftInput_Landroid_view_View_ == null)
				cb_showSoftInput_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowSoftInput_Landroid_view_View_);
			return cb_showSoftInput_Landroid_view_View_;
		}

		static void n_ShowSoftInput_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::Com.Mob.Tools.Utils.DeviceHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.DeviceHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.ShowSoftInput (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='DeviceHelper']/method[@name='showSoftInput' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("showSoftInput", "(Landroid/view/View;)V", "GetShowSoftInput_Landroid_view_View_Handler")]
		public virtual unsafe void ShowSoftInput (global::Android.Views.View view)
		{
			const string __id = "showSoftInput.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
