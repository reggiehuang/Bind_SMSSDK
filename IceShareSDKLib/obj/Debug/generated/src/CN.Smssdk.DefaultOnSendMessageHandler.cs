using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.smssdk']/class[@name='DefaultOnSendMessageHandler']"
	[global::Android.Runtime.Register ("cn/smssdk/DefaultOnSendMessageHandler", DoNotGenerateAcw=true)]
	public partial class DefaultOnSendMessageHandler : global::Java.Lang.Object, global::CN.Smssdk.IOnSendMessageHandler {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/smssdk/DefaultOnSendMessageHandler", typeof (DefaultOnSendMessageHandler));
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

		protected DefaultOnSendMessageHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.smssdk']/class[@name='DefaultOnSendMessageHandler']/constructor[@name='DefaultOnSendMessageHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultOnSendMessageHandler ()
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
			global::CN.Smssdk.DefaultOnSendMessageHandler __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.DefaultOnSendMessageHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSendMessage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk']/class[@name='DefaultOnSendMessageHandler']/method[@name='onSendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSendMessage", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetOnSendMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool OnSendMessage (string p0, string p1)
		{
			const string __id = "onSendMessage.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
