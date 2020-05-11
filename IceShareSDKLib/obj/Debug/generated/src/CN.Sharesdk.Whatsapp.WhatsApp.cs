using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Whatsapp {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']"
	[global::Android.Runtime.Register ("cn/sharesdk/whatsapp/WhatsApp", DoNotGenerateAcw=true)]
	public partial class WhatsApp : global::CN.Sharesdk.Framework.Platform {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/whatsapp/WhatsApp", typeof (WhatsApp));
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

		protected WhatsApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/constructor[@name='WhatsApp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WhatsApp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_hasShareCallback;
#pragma warning disable 0169
		static Delegate GetHasShareCallbackHandler ()
		{
			if (cb_hasShareCallback == null)
				cb_hasShareCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasShareCallback);
			return cb_hasShareCallback;
		}

		static bool n_HasShareCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasShareCallback;
		}
#pragma warning restore 0169

		public override unsafe bool HasShareCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='hasShareCallback' and count(parameter)=0]"
			[Register ("hasShareCallback", "()Z", "GetHasShareCallbackHandler")]
			get {
				const string __id = "hasShareCallback.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformId;
#pragma warning disable 0169
		static Delegate GetGetPlatformIdHandler ()
		{
			if (cb_getPlatformId == null)
				cb_getPlatformId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPlatformId);
			return cb_getPlatformId;
		}

		static int n_GetPlatformId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlatformId;
		}
#pragma warning restore 0169

		protected override unsafe int PlatformId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='getPlatformId' and count(parameter)=0]"
			[Register ("getPlatformId", "()I", "GetGetPlatformIdHandler")]
			get {
				const string __id = "getPlatformId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		public override unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_checkAuthorize_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCheckAuthorize_ILjava_lang_Object_Handler ()
		{
			if (cb_checkAuthorize_ILjava_lang_Object_ == null)
				cb_checkAuthorize_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_CheckAuthorize_ILjava_lang_Object_);
			return cb_checkAuthorize_ILjava_lang_Object_;
		}

		static bool n_CheckAuthorize_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int action, IntPtr native_extra)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object extra = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_extra, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckAuthorize (action, extra);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='checkAuthorize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkAuthorize", "(ILjava/lang/Object;)Z", "GetCheckAuthorize_ILjava_lang_Object_Handler")]
		protected override unsafe bool CheckAuthorize (int action, global::Java.Lang.Object extra)
		{
			const string __id = "checkAuthorize.(ILjava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (action);
				__args [1] = new JniArgumentValue ((extra == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extra).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doAuthorize_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoAuthorize_arrayLjava_lang_String_Handler ()
		{
			if (cb_doAuthorize_arrayLjava_lang_String_ == null)
				cb_doAuthorize_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoAuthorize_arrayLjava_lang_String_);
			return cb_doAuthorize_arrayLjava_lang_String_;
		}

		static void n_DoAuthorize_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] permission = (string[]) JNIEnv.GetArray (native_permission, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.DoAuthorize (permission);
			if (permission != null)
				JNIEnv.CopyArray (permission, native_permission);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='doAuthorize' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("doAuthorize", "([Ljava/lang/String;)V", "GetDoAuthorize_arrayLjava_lang_String_Handler")]
		protected override unsafe void DoAuthorize (string[] permission)
		{
			const string __id = "doAuthorize.([Ljava/lang/String;)V";
			IntPtr native_permission = JNIEnv.NewArray (permission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_permission);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (permission != null) {
					JNIEnv.CopyArray (native_permission, permission);
					JNIEnv.DeleteLocalRef (native_permission);
				}
			}
		}

		static Delegate cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetDoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_Handler ()
		{
			if (cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_ == null)
				cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_DoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_);
			return cb_doCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_;
		}

		static void n_DoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_method, int customerAction, IntPtr native_values, IntPtr native_filePathes)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			var filePathes = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_filePathes, JniHandleOwnership.DoNotTransfer);
			__this.DoCustomerProtocol (url, method, customerAction, values, filePathes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='doCustomerProtocol' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[5][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("doCustomerProtocol", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/HashMap;Ljava/util/HashMap;)V", "GetDoCustomerProtocol_Ljava_lang_String_Ljava_lang_String_ILjava_util_HashMap_Ljava_util_HashMap_Handler")]
		protected override unsafe void DoCustomerProtocol (string url, string method, int customerAction, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> values, global::System.Collections.Generic.IDictionary<string, string> filePathes)
		{
			const string __id = "doCustomerProtocol.(Ljava/lang/String;Ljava/lang/String;ILjava/util/HashMap;Ljava/util/HashMap;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_method = JNIEnv.NewString (method);
			IntPtr native_values = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (values);
			IntPtr native_filePathes = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (filePathes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_method);
				__args [2] = new JniArgumentValue (customerAction);
				__args [3] = new JniArgumentValue (native_values);
				__args [4] = new JniArgumentValue (native_filePathes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_method);
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_filePathes);
			}
		}

		static Delegate cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_;
#pragma warning disable 0169
		static Delegate GetDoShare_Lcn_sharesdk_framework_Platform_ShareParams_Handler ()
		{
			if (cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_ == null)
				cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoShare_Lcn_sharesdk_framework_Platform_ShareParams_);
			return cb_doShare_Lcn_sharesdk_framework_Platform_ShareParams_;
		}

		static void n_DoShare_Lcn_sharesdk_framework_Platform_ShareParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform.ShareParams @params = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native__params, JniHandleOwnership.DoNotTransfer);
			__this.DoShare (@params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='doShare' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("doShare", "(Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetDoShare_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		protected override unsafe void DoShare (global::CN.Sharesdk.Framework.Platform.ShareParams @params)
		{
			const string __id = "doShare.(Lcn/sharesdk/framework/Platform$ShareParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_filterFriendshipInfo_ILjava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetFilterFriendshipInfo_ILjava_util_HashMap_Handler ()
		{
			if (cb_filterFriendshipInfo_ILjava_util_HashMap_ == null)
				cb_filterFriendshipInfo_ILjava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_FilterFriendshipInfo_ILjava_util_HashMap_);
			return cb_filterFriendshipInfo_ILjava_util_HashMap_;
		}

		static IntPtr n_FilterFriendshipInfo_ILjava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, int action, IntPtr native_res)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var res = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_res, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.FilterFriendshipInfo (action, res));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='filterFriendshipInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("filterFriendshipInfo", "(ILjava/util/HashMap;)Ljava/util/HashMap;", "GetFilterFriendshipInfo_ILjava_util_HashMap_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> FilterFriendshipInfo (int action, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> res)
		{
			const string __id = "filterFriendshipInfo.(ILjava/util/HashMap;)Ljava/util/HashMap;";
			IntPtr native_res = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (res);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (action);
				__args [1] = new JniArgumentValue (native_res);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_res);
			}
		}

		static Delegate cb_follow_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFollow_Ljava_lang_String_Handler ()
		{
			if (cb_follow_Ljava_lang_String_ == null)
				cb_follow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Follow_Ljava_lang_String_);
			return cb_follow_Ljava_lang_String_;
		}

		static void n_Follow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.Follow (account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='follow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("follow", "(Ljava/lang/String;)V", "GetFollow_Ljava_lang_String_Handler")]
		protected override unsafe void Follow (string account)
		{
			const string __id = "follow.(Ljava/lang/String;)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_account);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_getBilaterals_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBilaterals_IILjava_lang_String_Handler ()
		{
			if (cb_getBilaterals_IILjava_lang_String_ == null)
				cb_getBilaterals_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetBilaterals_IILjava_lang_String_);
			return cb_getBilaterals_IILjava_lang_String_;
		}

		static IntPtr n_GetBilaterals_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int count, int cursor, IntPtr native_account)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetBilaterals (count, cursor, account));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='getBilaterals' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getBilaterals", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetBilaterals_IILjava_lang_String_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetBilaterals (int count, int cursor, string account)
		{
			const string __id = "getBilaterals.(IILjava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (cursor);
				__args [2] = new JniArgumentValue (native_account);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_getFollowers_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFollowers_IILjava_lang_String_Handler ()
		{
			if (cb_getFollowers_IILjava_lang_String_ == null)
				cb_getFollowers_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetFollowers_IILjava_lang_String_);
			return cb_getFollowers_IILjava_lang_String_;
		}

		static IntPtr n_GetFollowers_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int count, int cursor, IntPtr native_account)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetFollowers (count, cursor, account));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='getFollowers' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFollowers", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetFollowers_IILjava_lang_String_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetFollowers (int count, int cursor, string account)
		{
			const string __id = "getFollowers.(IILjava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (cursor);
				__args [2] = new JniArgumentValue (native_account);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_getFollowings_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFollowings_IILjava_lang_String_Handler ()
		{
			if (cb_getFollowings_IILjava_lang_String_ == null)
				cb_getFollowings_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetFollowings_IILjava_lang_String_);
			return cb_getFollowings_IILjava_lang_String_;
		}

		static IntPtr n_GetFollowings_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int count, int page, IntPtr native_account)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetFollowings (count, page, account));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='getFollowings' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFollowings", "(IILjava/lang/String;)Ljava/util/HashMap;", "GetGetFollowings_IILjava_lang_String_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetFollowings (int count, int page, string account)
		{
			const string __id = "getFollowings.(IILjava/lang/String;)Ljava/util/HashMap;";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (page);
				__args [2] = new JniArgumentValue (native_account);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_getFriendList_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFriendList_IILjava_lang_String_Handler ()
		{
			if (cb_getFriendList_IILjava_lang_String_ == null)
				cb_getFriendList_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_GetFriendList_IILjava_lang_String_);
			return cb_getFriendList_IILjava_lang_String_;
		}

		static void n_GetFriendList_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int count, int page, IntPtr native_account)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.GetFriendList (count, page, account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='getFriendList' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFriendList", "(IILjava/lang/String;)V", "GetGetFriendList_IILjava_lang_String_Handler")]
		protected override unsafe void GetFriendList (int count, int page, string account)
		{
			const string __id = "getFriendList.(IILjava/lang/String;)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (page);
				__args [2] = new JniArgumentValue (native_account);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_initDevInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitDevInfo_Ljava_lang_String_Handler ()
		{
			if (cb_initDevInfo_Ljava_lang_String_ == null)
				cb_initDevInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitDevInfo_Ljava_lang_String_);
			return cb_initDevInfo_Ljava_lang_String_;
		}

		static void n_InitDevInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.InitDevInfo (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='initDevInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initDevInfo", "(Ljava/lang/String;)V", "GetInitDevInfo_Ljava_lang_String_Handler")]
		protected override unsafe void InitDevInfo (string name)
		{
			const string __id = "initDevInfo.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setNetworkDevinfo;
#pragma warning disable 0169
		static Delegate GetSetNetworkDevinfoHandler ()
		{
			if (cb_setNetworkDevinfo == null)
				cb_setNetworkDevinfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetNetworkDevinfo);
			return cb_setNetworkDevinfo;
		}

		static void n_SetNetworkDevinfo (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNetworkDevinfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='setNetworkDevinfo' and count(parameter)=0]"
		[Register ("setNetworkDevinfo", "()V", "GetSetNetworkDevinfoHandler")]
		protected override unsafe void SetNetworkDevinfo ()
		{
			const string __id = "setNetworkDevinfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_timeline_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTimeline_IILjava_lang_String_Handler ()
		{
			if (cb_timeline_IILjava_lang_String_ == null)
				cb_timeline_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_Timeline_IILjava_lang_String_);
			return cb_timeline_IILjava_lang_String_;
		}

		static void n_Timeline_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int count, int page, IntPtr native_account)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.Timeline (count, page, account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='timeline' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("timeline", "(IILjava/lang/String;)V", "GetTimeline_IILjava_lang_String_Handler")]
		protected override unsafe void Timeline (int count, int page, string account)
		{
			const string __id = "timeline.(IILjava/lang/String;)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (page);
				__args [2] = new JniArgumentValue (native_account);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

		static Delegate cb_userInfor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUserInfor_Ljava_lang_String_Handler ()
		{
			if (cb_userInfor_Ljava_lang_String_ == null)
				cb_userInfor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UserInfor_Ljava_lang_String_);
			return cb_userInfor_Ljava_lang_String_;
		}

		static void n_UserInfor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_account)
		{
			global::CN.Sharesdk.Whatsapp.WhatsApp __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Whatsapp.WhatsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string account = JNIEnv.GetString (native_account, JniHandleOwnership.DoNotTransfer);
			__this.UserInfor (account);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.whatsapp']/class[@name='WhatsApp']/method[@name='userInfor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("userInfor", "(Ljava/lang/String;)V", "GetUserInfor_Ljava_lang_String_Handler")]
		protected override unsafe void UserInfor (string account)
		{
			const string __id = "userInfor.(Ljava/lang/String;)V";
			IntPtr native_account = JNIEnv.NewString (account);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_account);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_account);
			}
		}

	}
}
