using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk']/interface[@name='OnSendMessageHandler']"
	[Register ("cn/smssdk/OnSendMessageHandler", "", "CN.Smssdk.IOnSendMessageHandlerInvoker")]
	public partial interface IOnSendMessageHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/interface[@name='OnSendMessageHandler']/method[@name='onSendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSendMessage", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetOnSendMessage_Ljava_lang_String_Ljava_lang_String_Handler:CN.Smssdk.IOnSendMessageHandlerInvoker, IceShareSDKLib")]
		bool OnSendMessage (string p0, string p1);

	}

	[global::Android.Runtime.Register ("cn/smssdk/OnSendMessageHandler", DoNotGenerateAcw=true)]
	internal partial class IOnSendMessageHandlerInvoker : global::Java.Lang.Object, IOnSendMessageHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/smssdk/OnSendMessageHandler", typeof (IOnSendMessageHandlerInvoker));

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

		public static IOnSendMessageHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSendMessageHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.OnSendMessageHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSendMessageHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSendMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSendMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onSendMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onSendMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnSendMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_onSendMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_OnSendMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Smssdk.IOnSendMessageHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.IOnSendMessageHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSendMessage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onSendMessage_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool OnSendMessage (string p0, string p1)
		{
			if (id_onSendMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onSendMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSendMessage", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSendMessage_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
