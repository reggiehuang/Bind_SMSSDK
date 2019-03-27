using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/PlatformDb", DoNotGenerateAcw=true)]
	public partial class PlatformDb : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/framework/PlatformDb", typeof (PlatformDb));
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

		protected PlatformDb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/constructor[@name='PlatformDb' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe PlatformDb (string name, int version)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (version);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static long n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresIn;
		}
#pragma warning restore 0169

		public virtual unsafe long ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()J", "GetGetExpiresInHandler")]
			get {
				const string __id = "getExpiresIn.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getExpiresTime;
#pragma warning disable 0169
		static Delegate GetGetExpiresTimeHandler ()
		{
			if (cb_getExpiresTime == null)
				cb_getExpiresTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiresTime);
			return cb_getExpiresTime;
		}

		static long n_GetExpiresTime (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresTime;
		}
#pragma warning restore 0169

		public virtual unsafe long ExpiresTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getExpiresTime' and count(parameter)=0]"
			[Register ("getExpiresTime", "()J", "GetGetExpiresTimeHandler")]
			get {
				const string __id = "getExpiresTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformNname;
#pragma warning disable 0169
		static Delegate GetGetPlatformNnameHandler ()
		{
			if (cb_getPlatformNname == null)
				cb_getPlatformNname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatformNname);
			return cb_getPlatformNname;
		}

		static IntPtr n_GetPlatformNname (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlatformNname);
		}
#pragma warning restore 0169

		public virtual unsafe string PlatformNname {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getPlatformNname' and count(parameter)=0]"
			[Register ("getPlatformNname", "()Ljava/lang/String;", "GetGetPlatformNnameHandler")]
			get {
				const string __id = "getPlatformNname.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformVersion;
#pragma warning disable 0169
		static Delegate GetGetPlatformVersionHandler ()
		{
			if (cb_getPlatformVersion == null)
				cb_getPlatformVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPlatformVersion);
			return cb_getPlatformVersion;
		}

		static int n_GetPlatformVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlatformVersion;
		}
#pragma warning restore 0169

		public virtual unsafe int PlatformVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getPlatformVersion' and count(parameter)=0]"
			[Register ("getPlatformVersion", "()I", "GetGetPlatformVersionHandler")]
			get {
				const string __id = "getPlatformVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
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
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenSecret;
#pragma warning disable 0169
		static Delegate GetGetTokenSecretHandler ()
		{
			if (cb_getTokenSecret == null)
				cb_getTokenSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenSecret);
			return cb_getTokenSecret;
		}

		static IntPtr n_GetTokenSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenSecret);
		}
#pragma warning restore 0169

		public virtual unsafe string TokenSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getTokenSecret' and count(parameter)=0]"
			[Register ("getTokenSecret", "()Ljava/lang/String;", "GetGetTokenSecretHandler")]
			get {
				const string __id = "getTokenSecret.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserGender;
#pragma warning disable 0169
		static Delegate GetGetUserGenderHandler ()
		{
			if (cb_getUserGender == null)
				cb_getUserGender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserGender);
			return cb_getUserGender;
		}

		static IntPtr n_GetUserGender (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserGender);
		}
#pragma warning restore 0169

		public virtual unsafe string UserGender {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getUserGender' and count(parameter)=0]"
			[Register ("getUserGender", "()Ljava/lang/String;", "GetGetUserGenderHandler")]
			get {
				const string __id = "getUserGender.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserIcon;
#pragma warning disable 0169
		static Delegate GetGetUserIconHandler ()
		{
			if (cb_getUserIcon == null)
				cb_getUserIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserIcon);
			return cb_getUserIcon;
		}

		static IntPtr n_GetUserIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserIcon);
		}
#pragma warning restore 0169

		public virtual unsafe string UserIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getUserIcon' and count(parameter)=0]"
			[Register ("getUserIcon", "()Ljava/lang/String;", "GetGetUserIconHandler")]
			get {
				const string __id = "getUserIcon.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				const string __id = "getUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		public virtual unsafe string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")]
			get {
				const string __id = "getUserName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_exportData;
#pragma warning disable 0169
		static Delegate GetExportDataHandler ()
		{
			if (cb_exportData == null)
				cb_exportData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExportData);
			return cb_exportData;
		}

		static IntPtr n_ExportData (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExportData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='exportData' and count(parameter)=0]"
		[Register ("exportData", "()Ljava/lang/String;", "GetExportDataHandler")]
		public virtual unsafe string ExportData ()
		{
			const string __id = "exportData.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe string Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_importData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportData_Ljava_lang_String_Handler ()
		{
			if (cb_importData_Ljava_lang_String_ == null)
				cb_importData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ImportData_Ljava_lang_String_);
			return cb_importData_Ljava_lang_String_;
		}

		static void n_ImportData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_json)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string json = JNIEnv.GetString (native_json, JniHandleOwnership.DoNotTransfer);
			__this.ImportData (json);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='importData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importData", "(Ljava/lang/String;)V", "GetImportData_Ljava_lang_String_Handler")]
		public virtual unsafe void ImportData (string json)
		{
			const string __id = "importData.(Ljava/lang/String;)V";
			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_json);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string key, string value)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_putExpiresIn_J;
#pragma warning disable 0169
		static Delegate GetPutExpiresIn_JHandler ()
		{
			if (cb_putExpiresIn_J == null)
				cb_putExpiresIn_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_PutExpiresIn_J);
			return cb_putExpiresIn_J;
		}

		static void n_PutExpiresIn_J (IntPtr jnienv, IntPtr native__this, long expires)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutExpiresIn (expires);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='putExpiresIn' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("putExpiresIn", "(J)V", "GetPutExpiresIn_JHandler")]
		public virtual unsafe void PutExpiresIn (long expires)
		{
			const string __id = "putExpiresIn.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expires);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_putToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutToken_Ljava_lang_String_Handler ()
		{
			if (cb_putToken_Ljava_lang_String_ == null)
				cb_putToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutToken_Ljava_lang_String_);
			return cb_putToken_Ljava_lang_String_;
		}

		static void n_PutToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string token = JNIEnv.GetString (native_token, JniHandleOwnership.DoNotTransfer);
			__this.PutToken (token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='putToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putToken", "(Ljava/lang/String;)V", "GetPutToken_Ljava_lang_String_Handler")]
		public virtual unsafe void PutToken (string token)
		{
			const string __id = "putToken.(Ljava/lang/String;)V";
			IntPtr native_token = JNIEnv.NewString (token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_token);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_token);
			}
		}

		static Delegate cb_putTokenSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutTokenSecret_Ljava_lang_String_Handler ()
		{
			if (cb_putTokenSecret_Ljava_lang_String_ == null)
				cb_putTokenSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutTokenSecret_Ljava_lang_String_);
			return cb_putTokenSecret_Ljava_lang_String_;
		}

		static void n_PutTokenSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secret)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string secret = JNIEnv.GetString (native_secret, JniHandleOwnership.DoNotTransfer);
			__this.PutTokenSecret (secret);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='putTokenSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putTokenSecret", "(Ljava/lang/String;)V", "GetPutTokenSecret_Ljava_lang_String_Handler")]
		public virtual unsafe void PutTokenSecret (string secret)
		{
			const string __id = "putTokenSecret.(Ljava/lang/String;)V";
			IntPtr native_secret = JNIEnv.NewString (secret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_secret);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_secret);
			}
		}

		static Delegate cb_putUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutUserId_Ljava_lang_String_Handler ()
		{
			if (cb_putUserId_Ljava_lang_String_ == null)
				cb_putUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutUserId_Ljava_lang_String_);
			return cb_putUserId_Ljava_lang_String_;
		}

		static void n_PutUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platformId)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string platformId = JNIEnv.GetString (native_platformId, JniHandleOwnership.DoNotTransfer);
			__this.PutUserId (platformId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='putUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putUserId", "(Ljava/lang/String;)V", "GetPutUserId_Ljava_lang_String_Handler")]
		public virtual unsafe void PutUserId (string platformId)
		{
			const string __id = "putUserId.(Ljava/lang/String;)V";
			IntPtr native_platformId = JNIEnv.NewString (platformId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_platformId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_platformId);
			}
		}

		static Delegate cb_removeAccount;
#pragma warning disable 0169
		static Delegate GetRemoveAccountHandler ()
		{
			if (cb_removeAccount == null)
				cb_removeAccount = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAccount);
			return cb_removeAccount;
		}

		static void n_RemoveAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.PlatformDb __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.PlatformDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAccount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='PlatformDb']/method[@name='removeAccount' and count(parameter)=0]"
		[Register ("removeAccount", "()V", "GetRemoveAccountHandler")]
		public virtual unsafe void RemoveAccount ()
		{
			const string __id = "removeAccount.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
