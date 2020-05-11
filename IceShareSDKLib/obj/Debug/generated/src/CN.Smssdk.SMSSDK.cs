using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']"
	[global::Android.Runtime.Register ("cn/smssdk/SMSSDK", DoNotGenerateAcw=true)]
	public partial class SMSSDK : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_CONTACTS']"
		[Register ("EVENT_GET_CONTACTS")]
		public const int EventGetContacts = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_FRIENDS_IN_APP']"
		[Register ("EVENT_GET_FRIENDS_IN_APP")]
		public const int EventGetFriendsInApp = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_NEW_FRIENDS_COUNT']"
		[Register ("EVENT_GET_NEW_FRIENDS_COUNT")]
		public const int EventGetNewFriendsCount = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_SUPPORTED_COUNTRIES']"
		[Register ("EVENT_GET_SUPPORTED_COUNTRIES")]
		public const int EventGetSupportedCountries = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_VERIFICATION_CODE']"
		[Register ("EVENT_GET_VERIFICATION_CODE")]
		public const int EventGetVerificationCode = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_GET_VOICE_VERIFICATION_CODE']"
		[Register ("EVENT_GET_VOICE_VERIFICATION_CODE")]
		public const int EventGetVoiceVerificationCode = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_SUBMIT_USER_INFO']"
		[Register ("EVENT_SUBMIT_USER_INFO")]
		public const int EventSubmitUserInfo = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='EVENT_SUBMIT_VERIFICATION_CODE']"
		[Register ("EVENT_SUBMIT_VERIFICATION_CODE")]
		public const int EventSubmitVerificationCode = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='RESULT_COMPLETE']"
		[Register ("RESULT_COMPLETE")]
		public const int ResultComplete = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/field[@name='RESULT_ERROR']"
		[Register ("RESULT_ERROR")]
		public const int ResultError = (int) 0;
		// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK.InitFlag']"
		[global::Android.Runtime.Register ("cn/smssdk/SMSSDK$InitFlag", DoNotGenerateAcw=true)]
		public sealed partial class InitFlag : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK.InitFlag']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::CN.Smssdk.SMSSDK.InitFlag Default {
				get {
					const string __id = "DEFAULT.Lcn/smssdk/SMSSDK$InitFlag;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::CN.Smssdk.SMSSDK.InitFlag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK.InitFlag']/field[@name='DISABLE_CONTACT']"
			[Register ("DISABLE_CONTACT")]
			public static global::CN.Smssdk.SMSSDK.InitFlag DisableContact {
				get {
					const string __id = "DISABLE_CONTACT.Lcn/smssdk/SMSSDK$InitFlag;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::CN.Smssdk.SMSSDK.InitFlag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK.InitFlag']/field[@name='WARNNING_READCONTACT']"
			[Register ("WARNNING_READCONTACT")]
			public static global::CN.Smssdk.SMSSDK.InitFlag WarnningReadcontact {
				get {
					const string __id = "WARNNING_READCONTACT.Lcn/smssdk/SMSSDK$InitFlag;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::CN.Smssdk.SMSSDK.InitFlag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK.InitFlag']/field[@name='WARNNING_READCONTACT_DIALOG_MODE']"
			[Register ("WARNNING_READCONTACT_DIALOG_MODE")]
			public static global::CN.Smssdk.SMSSDK.InitFlag WarnningReadcontactDialogMode {
				get {
					const string __id = "WARNNING_READCONTACT_DIALOG_MODE.Lcn/smssdk/SMSSDK$InitFlag;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::CN.Smssdk.SMSSDK.InitFlag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/SMSSDK$InitFlag", typeof (InitFlag));
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

			internal InitFlag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK.InitFlag']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcn/smssdk/SMSSDK$InitFlag;", "")]
			public static unsafe global::CN.Smssdk.SMSSDK.InitFlag ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcn/smssdk/SMSSDK$InitFlag;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::CN.Smssdk.SMSSDK.InitFlag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK.InitFlag']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcn/smssdk/SMSSDK$InitFlag;", "")]
			public static unsafe global::CN.Smssdk.SMSSDK.InitFlag[] Values ()
			{
				const string __id = "values.()[Lcn/smssdk/SMSSDK$InitFlag;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::CN.Smssdk.SMSSDK.InitFlag[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::CN.Smssdk.SMSSDK.InitFlag));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk']/interface[@name='SMSSDK.VerifyCodeReadListener']"
		[Register ("cn/smssdk/SMSSDK$VerifyCodeReadListener", "", "CN.Smssdk.SMSSDK/IVerifyCodeReadListenerInvoker")]
		public partial interface IVerifyCodeReadListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/interface[@name='SMSSDK.VerifyCodeReadListener']/method[@name='onReadVerifyCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onReadVerifyCode", "(Ljava/lang/String;)V", "GetOnReadVerifyCode_Ljava_lang_String_Handler:CN.Smssdk.SMSSDK/IVerifyCodeReadListenerInvoker, IceShareSDKLib")]
			void OnReadVerifyCode (string p0);

		}

		[global::Android.Runtime.Register ("cn/smssdk/SMSSDK$VerifyCodeReadListener", DoNotGenerateAcw=true)]
		internal partial class IVerifyCodeReadListenerInvoker : global::Java.Lang.Object, IVerifyCodeReadListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/SMSSDK$VerifyCodeReadListener", typeof (IVerifyCodeReadListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IVerifyCodeReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVerifyCodeReadListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.SMSSDK.VerifyCodeReadListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVerifyCodeReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onReadVerifyCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnReadVerifyCode_Ljava_lang_String_Handler ()
			{
				if (cb_onReadVerifyCode_Ljava_lang_String_ == null)
					cb_onReadVerifyCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadVerifyCode_Ljava_lang_String_);
				return cb_onReadVerifyCode_Ljava_lang_String_;
			}

			static void n_OnReadVerifyCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::CN.Smssdk.SMSSDK.IVerifyCodeReadListener __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.SMSSDK.IVerifyCodeReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadVerifyCode (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReadVerifyCode_Ljava_lang_String_;
			public unsafe void OnReadVerifyCode (string p0)
			{
				if (id_onReadVerifyCode_Ljava_lang_String_ == IntPtr.Zero)
					id_onReadVerifyCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReadVerifyCode", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadVerifyCode_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for cn.smssdk.SMSSDK.VerifyCodeReadListener.onReadVerifyCode
		public partial class VerifyCodeReadEventArgs : global::System.EventArgs {

			public VerifyCodeReadEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/cn/smssdk/SMSSDK_VerifyCodeReadListenerImplementor")]
		internal sealed partial class IVerifyCodeReadListenerImplementor : global::Java.Lang.Object, IVerifyCodeReadListener {

			object sender;

			public IVerifyCodeReadListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/smssdk/SMSSDK_VerifyCodeReadListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<VerifyCodeReadEventArgs> Handler;
#pragma warning restore 0649

			public void OnReadVerifyCode (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new VerifyCodeReadEventArgs (p0));
			}

			internal static bool __IsEmpty (IVerifyCodeReadListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/SMSSDK", typeof (SMSSDK));
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

		protected SMSSDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/constructor[@name='SMSSDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SMSSDK ()
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

		public static unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Character, global::System.Collections.Generic.IList<string[]>> GroupedCountryList {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getGroupedCountryList' and count(parameter)=0]"
			[Register ("getGroupedCountryList", "()Ljava/util/HashMap;", "")]
			get {
				const string __id = "getGroupedCountryList.()Ljava/util/HashMap;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaDictionary<global::Java.Lang.Character, global::System.Collections.Generic.IList<string[]>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getContacts' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getContacts", "(Z)V", "")]
		public static unsafe void GetContacts (bool p0)
		{
			const string __id = "getContacts.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCountry", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetCountry (string p0)
		{
			const string __id = "getCountry.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getCountryByMCC' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCountryByMCC", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetCountryByMCC (string p0)
		{
			const string __id = "getCountryByMCC.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getFriendsInApp' and count(parameter)=0]"
		[Register ("getFriendsInApp", "()V", "")]
		public static unsafe void GetFriendsInApp ()
		{
			const string __id = "getFriendsInApp.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getNewFriendsCount' and count(parameter)=0]"
		[Register ("getNewFriendsCount", "()V", "")]
		public static unsafe void GetNewFriendsCount ()
		{
			const string __id = "getNewFriendsCount.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getSupportedCountries' and count(parameter)=0]"
		[Register ("getSupportedCountries", "()V", "")]
		public static unsafe void GetSupportedCountries ()
		{
			const string __id = "getSupportedCountries.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVerificationCode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVerificationCode", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GetVerificationCode (string p0, string p1)
		{
			const string __id = "getVerificationCode.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVerificationCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='cn.smssdk.OnSendMessageHandler']]"
		[Register ("getVerificationCode", "(Ljava/lang/String;Ljava/lang/String;Lcn/smssdk/OnSendMessageHandler;)V", "")]
		public static unsafe void GetVerificationCode (string p0, string p1, global::CN.Smssdk.IOnSendMessageHandler p2)
		{
			const string __id = "getVerificationCode.(Ljava/lang/String;Ljava/lang/String;Lcn/smssdk/OnSendMessageHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVerificationCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getVerificationCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GetVerificationCode (string p0, string p1, string p2)
		{
			const string __id = "getVerificationCode.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVerificationCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='cn.smssdk.OnSendMessageHandler']]"
		[Register ("getVerificationCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcn/smssdk/OnSendMessageHandler;)V", "")]
		public static unsafe void GetVerificationCode (string p0, string p1, string p2, global::CN.Smssdk.IOnSendMessageHandler p3)
		{
			const string __id = "getVerificationCode.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcn/smssdk/OnSendMessageHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVerificationCode' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='cn.smssdk.OnSendMessageHandler']]"
		[Register ("getVerificationCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcn/smssdk/OnSendMessageHandler;)V", "")]
		public static unsafe void GetVerificationCode (string p0, string p1, string p2, string p3, global::CN.Smssdk.IOnSendMessageHandler p4)
		{
			const string __id = "getVerificationCode.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcn/smssdk/OnSendMessageHandler;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVoiceVerifyCode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVoiceVerifyCode", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GetVoiceVerifyCode (string p0, string p1)
		{
			const string __id = "getVoiceVerifyCode.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='getVoiceVerifyCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getVoiceVerifyCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GetVoiceVerifyCode (string p0, string p1, string p2)
		{
			const string __id = "getVoiceVerifyCode.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='readVerificationCode' and count(parameter)=2 and parameter[1][@type='android.telephony.SmsMessage'] and parameter[2][@type='cn.smssdk.SMSSDK.VerifyCodeReadListener']]"
		[Register ("readVerificationCode", "(Landroid/telephony/SmsMessage;Lcn/smssdk/SMSSDK$VerifyCodeReadListener;)V", "")]
		public static unsafe void ReadVerificationCode (global::Android.Telephony.SmsMessage p0, global::CN.Smssdk.SMSSDK.IVerifyCodeReadListener p1)
		{
			const string __id = "readVerificationCode.(Landroid/telephony/SmsMessage;Lcn/smssdk/SMSSDK$VerifyCodeReadListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='registerEventHandler' and count(parameter)=1 and parameter[1][@type='cn.smssdk.EventHandler']]"
		[Register ("registerEventHandler", "(Lcn/smssdk/EventHandler;)V", "")]
		public static unsafe void RegisterEventHandler (global::CN.Smssdk.EventHandler p0)
		{
			const string __id = "registerEventHandler.(Lcn/smssdk/EventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='setAskPermisionOnReadContact' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAskPermisionOnReadContact", "(Z)V", "")]
		public static unsafe void SetAskPermisionOnReadContact (bool p0)
		{
			const string __id = "setAskPermisionOnReadContact.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='setInitFlag' and count(parameter)=1 and parameter[1][@type='cn.smssdk.SMSSDK.InitFlag']]"
		[Register ("setInitFlag", "(Lcn/smssdk/SMSSDK$InitFlag;)V", "")]
		public static unsafe void SetInitFlag (global::CN.Smssdk.SMSSDK.InitFlag p0)
		{
			const string __id = "setInitFlag.(Lcn/smssdk/SMSSDK$InitFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='submitUserInfo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("submitUserInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SubmitUserInfo (string p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "submitUserInfo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='submitVerificationCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("submitVerificationCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SubmitVerificationCode (string p0, string p1, string p2)
		{
			const string __id = "submitVerificationCode.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='unregisterAllEventHandler' and count(parameter)=0]"
		[Register ("unregisterAllEventHandler", "()V", "")]
		public static unsafe void UnregisterAllEventHandler ()
		{
			const string __id = "unregisterAllEventHandler.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='SMSSDK']/method[@name='unregisterEventHandler' and count(parameter)=1 and parameter[1][@type='cn.smssdk.EventHandler']]"
		[Register ("unregisterEventHandler", "(Lcn/smssdk/EventHandler;)V", "")]
		public static unsafe void UnregisterEventHandler (global::CN.Smssdk.EventHandler p0)
		{
			const string __id = "unregisterEventHandler.(Lcn/smssdk/EventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
