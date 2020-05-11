using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']"
	[global::Android.Runtime.Register ("cn/smssdk/utils/SPHelper", DoNotGenerateAcw=true)]
	public partial class SPHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/utils/SPHelper", typeof (SPHelper));
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

		protected SPHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBufferedContacts;
#pragma warning disable 0169
		static Delegate GetGetBufferedContactsHandler ()
		{
			if (cb_getBufferedContacts == null)
				cb_getBufferedContacts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferedContacts);
			return cb_getBufferedContacts;
		}

		static IntPtr n_GetBufferedContacts (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.BufferedContacts);
		}
#pragma warning restore 0169

		static Delegate cb_setBufferedContacts_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetBufferedContacts_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setBufferedContacts_Ljava_util_ArrayList_ == null)
				cb_setBufferedContacts_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferedContacts_Ljava_util_ArrayList_);
			return cb_setBufferedContacts_Ljava_util_ArrayList_;
		}

		static void n_SetBufferedContacts_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BufferedContacts = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> BufferedContacts {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getBufferedContacts' and count(parameter)=0]"
			[Register ("getBufferedContacts", "()Ljava/util/ArrayList;", "GetGetBufferedContactsHandler")]
			get {
				const string __id = "getBufferedContacts.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setBufferedContacts' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;&gt;']]"
			[Register ("setBufferedContacts", "(Ljava/util/ArrayList;)V", "GetSetBufferedContacts_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setBufferedContacts.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBufferedContactsSignature;
#pragma warning disable 0169
		static Delegate GetGetBufferedContactsSignatureHandler ()
		{
			if (cb_getBufferedContactsSignature == null)
				cb_getBufferedContactsSignature = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferedContactsSignature);
			return cb_getBufferedContactsSignature;
		}

		static IntPtr n_GetBufferedContactsSignature (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BufferedContactsSignature);
		}
#pragma warning restore 0169

		static Delegate cb_setBufferedContactsSignature_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBufferedContactsSignature_Ljava_lang_String_Handler ()
		{
			if (cb_setBufferedContactsSignature_Ljava_lang_String_ == null)
				cb_setBufferedContactsSignature_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferedContactsSignature_Ljava_lang_String_);
			return cb_setBufferedContactsSignature_Ljava_lang_String_;
		}

		static void n_SetBufferedContactsSignature_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BufferedContactsSignature = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string BufferedContactsSignature {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getBufferedContactsSignature' and count(parameter)=0]"
			[Register ("getBufferedContactsSignature", "()Ljava/lang/String;", "GetGetBufferedContactsSignatureHandler")]
			get {
				const string __id = "getBufferedContactsSignature.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setBufferedContactsSignature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBufferedContactsSignature", "(Ljava/lang/String;)V", "GetSetBufferedContactsSignature_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBufferedContactsSignature.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBufferedCountrylist;
#pragma warning disable 0169
		static Delegate GetGetBufferedCountrylistHandler ()
		{
			if (cb_getBufferedCountrylist == null)
				cb_getBufferedCountrylist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferedCountrylist);
			return cb_getBufferedCountrylist;
		}

		static IntPtr n_GetBufferedCountrylist (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BufferedCountrylist);
		}
#pragma warning restore 0169

		static Delegate cb_setBufferedCountrylist_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBufferedCountrylist_Ljava_lang_String_Handler ()
		{
			if (cb_setBufferedCountrylist_Ljava_lang_String_ == null)
				cb_setBufferedCountrylist_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferedCountrylist_Ljava_lang_String_);
			return cb_setBufferedCountrylist_Ljava_lang_String_;
		}

		static void n_SetBufferedCountrylist_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BufferedCountrylist = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string BufferedCountrylist {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getBufferedCountrylist' and count(parameter)=0]"
			[Register ("getBufferedCountrylist", "()Ljava/lang/String;", "GetGetBufferedCountrylistHandler")]
			get {
				const string __id = "getBufferedCountrylist.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setBufferedCountrylist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBufferedCountrylist", "(Ljava/lang/String;)V", "GetSetBufferedCountrylist_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBufferedCountrylist.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBufferedFriends;
#pragma warning disable 0169
		static Delegate GetGetBufferedFriendsHandler ()
		{
			if (cb_getBufferedFriends == null)
				cb_getBufferedFriends = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferedFriends);
			return cb_getBufferedFriends;
		}

		static IntPtr n_GetBufferedFriends (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.BufferedFriends);
		}
#pragma warning restore 0169

		static Delegate cb_setBufferedFriends_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetBufferedFriends_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setBufferedFriends_Ljava_util_ArrayList_ == null)
				cb_setBufferedFriends_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferedFriends_Ljava_util_ArrayList_);
			return cb_setBufferedFriends_Ljava_util_ArrayList_;
		}

		static void n_SetBufferedFriends_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BufferedFriends = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> BufferedFriends {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getBufferedFriends' and count(parameter)=0]"
			[Register ("getBufferedFriends", "()Ljava/util/ArrayList;", "GetGetBufferedFriendsHandler")]
			get {
				const string __id = "getBufferedFriends.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setBufferedFriends' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;&gt;']]"
			[Register ("setBufferedFriends", "(Ljava/util/ArrayList;)V", "GetSetBufferedFriends_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setBufferedFriends.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBufferedNewFriends;
#pragma warning disable 0169
		static Delegate GetGetBufferedNewFriendsHandler ()
		{
			if (cb_getBufferedNewFriends == null)
				cb_getBufferedNewFriends = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferedNewFriends);
			return cb_getBufferedNewFriends;
		}

		static IntPtr n_GetBufferedNewFriends (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (__this.BufferedNewFriends);
		}
#pragma warning restore 0169

		static Delegate cb_setBufferedNewFriends_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetBufferedNewFriends_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setBufferedNewFriends_Ljava_util_ArrayList_ == null)
				cb_setBufferedNewFriends_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferedNewFriends_Ljava_util_ArrayList_);
			return cb_setBufferedNewFriends_Ljava_util_ArrayList_;
		}

		static void n_SetBufferedNewFriends_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BufferedNewFriends = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> BufferedNewFriends {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getBufferedNewFriends' and count(parameter)=0]"
			[Register ("getBufferedNewFriends", "()Ljava/util/ArrayList;", "GetGetBufferedNewFriendsHandler")]
			get {
				const string __id = "getBufferedNewFriends.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setBufferedNewFriends' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;&gt;']]"
			[Register ("setBufferedNewFriends", "(Ljava/util/ArrayList;)V", "GetSetBufferedNewFriends_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setBufferedNewFriends.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Config);
		}
#pragma warning restore 0169

		static Delegate cb_setConfig_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Ljava_lang_String_Handler ()
		{
			if (cb_setConfig_Ljava_lang_String_ == null)
				cb_setConfig_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfig_Ljava_lang_String_);
			return cb_setConfig_Ljava_lang_String_;
		}

		static void n_SetConfig_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Config = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Ljava/lang/String;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConfig", "(Ljava/lang/String;)V", "GetSetConfig_Ljava_lang_String_Handler")]
			set {
				const string __id = "setConfig.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static unsafe global::CN.Smssdk.Utils.SPHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcn/smssdk/utils/SPHelper;", "")]
			get {
				const string __id = "getInstance.()Lcn/smssdk/utils/SPHelper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAllowReadContact;
#pragma warning disable 0169
		static Delegate GetIsAllowReadContactHandler ()
		{
			if (cb_isAllowReadContact == null)
				cb_isAllowReadContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAllowReadContact);
			return cb_isAllowReadContact;
		}

		static bool n_IsAllowReadContact (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAllowReadContact;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAllowReadContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='isAllowReadContact' and count(parameter)=0]"
			[Register ("isAllowReadContact", "()Z", "GetIsAllowReadContactHandler")]
			get {
				const string __id = "isAllowReadContact.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastRequestNewFriendsTime;
#pragma warning disable 0169
		static Delegate GetGetLastRequestNewFriendsTimeHandler ()
		{
			if (cb_getLastRequestNewFriendsTime == null)
				cb_getLastRequestNewFriendsTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastRequestNewFriendsTime);
			return cb_getLastRequestNewFriendsTime;
		}

		static long n_GetLastRequestNewFriendsTime (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastRequestNewFriendsTime;
		}
#pragma warning restore 0169

		public virtual unsafe long LastRequestNewFriendsTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getLastRequestNewFriendsTime' and count(parameter)=0]"
			[Register ("getLastRequestNewFriendsTime", "()J", "GetGetLastRequestNewFriendsTimeHandler")]
			get {
				const string __id = "getLastRequestNewFriendsTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastZoneAt;
#pragma warning disable 0169
		static Delegate GetGetLastZoneAtHandler ()
		{
			if (cb_getLastZoneAt == null)
				cb_getLastZoneAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastZoneAt);
			return cb_getLastZoneAt;
		}

		static long n_GetLastZoneAt (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastZoneAt;
		}
#pragma warning restore 0169

		static Delegate cb_setLastZoneAt_J;
#pragma warning disable 0169
		static Delegate GetSetLastZoneAt_JHandler ()
		{
			if (cb_setLastZoneAt_J == null)
				cb_setLastZoneAt_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastZoneAt_J);
			return cb_setLastZoneAt_J;
		}

		static void n_SetLastZoneAt_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastZoneAt = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long LastZoneAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getLastZoneAt' and count(parameter)=0]"
			[Register ("getLastZoneAt", "()J", "GetGetLastZoneAtHandler")]
			get {
				const string __id = "getLastZoneAt.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setLastZoneAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastZoneAt", "(J)V", "GetSetLastZoneAt_JHandler")]
			set {
				const string __id = "setLastZoneAt.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLog;
#pragma warning disable 0169
		static Delegate GetGetLogHandler ()
		{
			if (cb_getLog == null)
				cb_getLog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLog);
			return cb_getLog;
		}

		static IntPtr n_GetLog (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Log);
		}
#pragma warning restore 0169

		static Delegate cb_setLog_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLog_Ljava_lang_String_Handler ()
		{
			if (cb_setLog_Ljava_lang_String_ == null)
				cb_setLog_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLog_Ljava_lang_String_);
			return cb_setLog_Ljava_lang_String_;
		}

		static void n_SetLog_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Log = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Log {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getLog' and count(parameter)=0]"
			[Register ("getLog", "()Ljava/lang/String;", "GetGetLogHandler")]
			get {
				const string __id = "getLog.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLog", "(Ljava/lang/String;)V", "GetSetLog_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLog.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSMSID;
#pragma warning disable 0169
		static Delegate GetGetSMSIDHandler ()
		{
			if (cb_getSMSID == null)
				cb_getSMSID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSMSID);
			return cb_getSMSID;
		}

		static IntPtr n_GetSMSID (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SMSID);
		}
#pragma warning restore 0169

		static Delegate cb_setSMSID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSMSID_Ljava_lang_String_Handler ()
		{
			if (cb_setSMSID_Ljava_lang_String_ == null)
				cb_setSMSID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSMSID_Ljava_lang_String_);
			return cb_setSMSID_Ljava_lang_String_;
		}

		static void n_SetSMSID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SMSID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SMSID {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getSMSID' and count(parameter)=0]"
			[Register ("getSMSID", "()Ljava/lang/String;", "GetGetSMSIDHandler")]
			get {
				const string __id = "getSMSID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setSMSID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSMSID", "(Ljava/lang/String;)V", "GetSetSMSID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSMSID.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setToken.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVCodeHash;
#pragma warning disable 0169
		static Delegate GetGetVCodeHashHandler ()
		{
			if (cb_getVCodeHash == null)
				cb_getVCodeHash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVCodeHash);
			return cb_getVCodeHash;
		}

		static IntPtr n_GetVCodeHash (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VCodeHash);
		}
#pragma warning restore 0169

		static Delegate cb_setVCodeHash_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVCodeHash_Ljava_lang_String_Handler ()
		{
			if (cb_setVCodeHash_Ljava_lang_String_ == null)
				cb_setVCodeHash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVCodeHash_Ljava_lang_String_);
			return cb_setVCodeHash_Ljava_lang_String_;
		}

		static void n_SetVCodeHash_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VCodeHash = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string VCodeHash {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getVCodeHash' and count(parameter)=0]"
			[Register ("getVCodeHash", "()Ljava/lang/String;", "GetGetVCodeHashHandler")]
			get {
				const string __id = "getVCodeHash.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setVCodeHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVCodeHash", "(Ljava/lang/String;)V", "GetSetVCodeHash_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVCodeHash.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVerifyCountry;
#pragma warning disable 0169
		static Delegate GetGetVerifyCountryHandler ()
		{
			if (cb_getVerifyCountry == null)
				cb_getVerifyCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerifyCountry);
			return cb_getVerifyCountry;
		}

		static IntPtr n_GetVerifyCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VerifyCountry);
		}
#pragma warning restore 0169

		static Delegate cb_setVerifyCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVerifyCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setVerifyCountry_Ljava_lang_String_ == null)
				cb_setVerifyCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerifyCountry_Ljava_lang_String_);
			return cb_setVerifyCountry_Ljava_lang_String_;
		}

		static void n_SetVerifyCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VerifyCountry = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string VerifyCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getVerifyCountry' and count(parameter)=0]"
			[Register ("getVerifyCountry", "()Ljava/lang/String;", "GetGetVerifyCountryHandler")]
			get {
				const string __id = "getVerifyCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setVerifyCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVerifyCountry", "(Ljava/lang/String;)V", "GetSetVerifyCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVerifyCountry.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVerifyPhone;
#pragma warning disable 0169
		static Delegate GetGetVerifyPhoneHandler ()
		{
			if (cb_getVerifyPhone == null)
				cb_getVerifyPhone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerifyPhone);
			return cb_getVerifyPhone;
		}

		static IntPtr n_GetVerifyPhone (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VerifyPhone);
		}
#pragma warning restore 0169

		static Delegate cb_setVerifyPhone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVerifyPhone_Ljava_lang_String_Handler ()
		{
			if (cb_setVerifyPhone_Ljava_lang_String_ == null)
				cb_setVerifyPhone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerifyPhone_Ljava_lang_String_);
			return cb_setVerifyPhone_Ljava_lang_String_;
		}

		static void n_SetVerifyPhone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VerifyPhone = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string VerifyPhone {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getVerifyPhone' and count(parameter)=0]"
			[Register ("getVerifyPhone", "()Ljava/lang/String;", "GetGetVerifyPhoneHandler")]
			get {
				const string __id = "getVerifyPhone.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setVerifyPhone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVerifyPhone", "(Ljava/lang/String;)V", "GetSetVerifyPhone_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVerifyPhone.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isWarnWhenReadContact;
#pragma warning disable 0169
		static Delegate GetIsWarnWhenReadContactHandler ()
		{
			if (cb_isWarnWhenReadContact == null)
				cb_isWarnWhenReadContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWarnWhenReadContact);
			return cb_isWarnWhenReadContact;
		}

		static bool n_IsWarnWhenReadContact (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WarnWhenReadContact;
		}
#pragma warning restore 0169

		static Delegate cb_setWarnWhenReadContact_Z;
#pragma warning disable 0169
		static Delegate GetSetWarnWhenReadContact_ZHandler ()
		{
			if (cb_setWarnWhenReadContact_Z == null)
				cb_setWarnWhenReadContact_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWarnWhenReadContact_Z);
			return cb_setWarnWhenReadContact_Z;
		}

		static void n_SetWarnWhenReadContact_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WarnWhenReadContact = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool WarnWhenReadContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='isWarnWhenReadContact' and count(parameter)=0]"
			[Register ("isWarnWhenReadContact", "()Z", "GetIsWarnWhenReadContactHandler")]
			get {
				const string __id = "isWarnWhenReadContact.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setWarnWhenReadContact' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWarnWhenReadContact", "(Z)V", "GetSetWarnWhenReadContact_ZHandler")]
			set {
				const string __id = "setWarnWhenReadContact.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_clearBuffer;
#pragma warning disable 0169
		static Delegate GetClearBufferHandler ()
		{
			if (cb_clearBuffer == null)
				cb_clearBuffer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearBuffer);
			return cb_clearBuffer;
		}

		static void n_ClearBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearBuffer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='clearBuffer' and count(parameter)=0]"
		[Register ("clearBuffer", "()V", "GetClearBufferHandler")]
		public virtual unsafe void ClearBuffer ()
		{
			const string __id = "clearBuffer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearLog;
#pragma warning disable 0169
		static Delegate GetClearLogHandler ()
		{
			if (cb_clearLog == null)
				cb_clearLog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearLog);
			return cb_clearLog;
		}

		static void n_ClearLog (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearLog ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='clearLog' and count(parameter)=0]"
		[Register ("clearLog", "()V", "GetClearLogHandler")]
		public virtual unsafe void ClearLog ()
		{
			const string __id = "clearLog.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBufferedContactPhones;
#pragma warning disable 0169
		static Delegate GetGetBufferedContactPhonesHandler ()
		{
			if (cb_getBufferedContactPhones == null)
				cb_getBufferedContactPhones = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferedContactPhones);
			return cb_getBufferedContactPhones;
		}

		static IntPtr n_GetBufferedContactPhones (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBufferedContactPhones ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getBufferedContactPhones' and count(parameter)=0]"
		[Register ("getBufferedContactPhones", "()[Ljava/lang/String;", "GetGetBufferedContactPhonesHandler")]
		public virtual unsafe string[] GetBufferedContactPhones ()
		{
			const string __id = "getBufferedContactPhones.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getLastRequestTimeMillis_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLastRequestTimeMillis_Ljava_lang_String_Handler ()
		{
			if (cb_getLastRequestTimeMillis_Ljava_lang_String_ == null)
				cb_getLastRequestTimeMillis_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLastRequestTimeMillis_Ljava_lang_String_);
			return cb_getLastRequestTimeMillis_Ljava_lang_String_;
		}

		static long n_GetLastRequestTimeMillis_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLastRequestTimeMillis (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='getLastRequestTimeMillis' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLastRequestTimeMillis", "(Ljava/lang/String;)J", "GetGetLastRequestTimeMillis_Ljava_lang_String_Handler")]
		public virtual unsafe long GetLastRequestTimeMillis (string p0)
		{
			const string __id = "getLastRequestTimeMillis.(Ljava/lang/String;)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAllowReadContact;
#pragma warning disable 0169
		static Delegate GetSetAllowReadContactHandler ()
		{
			if (cb_setAllowReadContact == null)
				cb_setAllowReadContact = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetAllowReadContact);
			return cb_setAllowReadContact;
		}

		static void n_SetAllowReadContact (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowReadContact ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setAllowReadContact' and count(parameter)=0]"
		[Register ("setAllowReadContact", "()V", "GetSetAllowReadContactHandler")]
		public virtual unsafe void SetAllowReadContact ()
		{
			const string __id = "setAllowReadContact.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBufferedContactPhones_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBufferedContactPhones_arrayLjava_lang_String_Handler ()
		{
			if (cb_setBufferedContactPhones_arrayLjava_lang_String_ == null)
				cb_setBufferedContactPhones_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferedContactPhones_arrayLjava_lang_String_);
			return cb_setBufferedContactPhones_arrayLjava_lang_String_;
		}

		static void n_SetBufferedContactPhones_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetBufferedContactPhones (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setBufferedContactPhones' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setBufferedContactPhones", "([Ljava/lang/String;)V", "GetSetBufferedContactPhones_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetBufferedContactPhones (string[] p0)
		{
			const string __id = "setBufferedContactPhones.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setLastRequestTimeMillis_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSetLastRequestTimeMillis_Ljava_lang_String_JHandler ()
		{
			if (cb_setLastRequestTimeMillis_Ljava_lang_String_J == null)
				cb_setLastRequestTimeMillis_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_SetLastRequestTimeMillis_Ljava_lang_String_J);
			return cb_setLastRequestTimeMillis_Ljava_lang_String_J;
		}

		static void n_SetLastRequestTimeMillis_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLastRequestTimeMillis (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setLastRequestTimeMillis' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("setLastRequestTimeMillis", "(Ljava/lang/String;J)V", "GetSetLastRequestTimeMillis_Ljava_lang_String_JHandler")]
		public virtual unsafe void SetLastRequestTimeMillis (string p0, long p1)
		{
			const string __id = "setLastRequestTimeMillis.(Ljava/lang/String;J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRequestNewFriendsTime;
#pragma warning disable 0169
		static Delegate GetSetRequestNewFriendsTimeHandler ()
		{
			if (cb_setRequestNewFriendsTime == null)
				cb_setRequestNewFriendsTime = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetRequestNewFriendsTime);
			return cb_setRequestNewFriendsTime;
		}

		static void n_SetRequestNewFriendsTime (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Smssdk.Utils.SPHelper __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Utils.SPHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestNewFriendsTime ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.utils']/class[@name='SPHelper']/method[@name='setRequestNewFriendsTime' and count(parameter)=0]"
		[Register ("setRequestNewFriendsTime", "()V", "GetSetRequestNewFriendsTimeHandler")]
		public virtual unsafe void SetRequestNewFriendsTime ()
		{
			const string __id = "setRequestNewFriendsTime.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
