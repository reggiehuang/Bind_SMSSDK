using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.framework']/interface[@name='PlatformActionListener']"
	[Register ("cn/sharesdk/framework/PlatformActionListener", "", "CN.Sharesdk.Framework.IPlatformActionListenerInvoker")]
	public partial interface IPlatformActionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/interface[@name='PlatformActionListener']/method[@name='onCancel' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int']]"
		[Register ("onCancel", "(Lcn/sharesdk/framework/Platform;I)V", "GetOnCancel_Lcn_sharesdk_framework_Platform_IHandler:CN.Sharesdk.Framework.IPlatformActionListenerInvoker, IceShareSDKLib")]
		void OnCancel (global::CN.Sharesdk.Framework.Platform p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/interface[@name='PlatformActionListener']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onComplete", "(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V", "GetOnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_Handler:CN.Sharesdk.Framework.IPlatformActionListenerInvoker, IceShareSDKLib")]
		void OnComplete (global::CN.Sharesdk.Framework.Platform p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/interface[@name='PlatformActionListener']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V", "GetOnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_Handler:CN.Sharesdk.Framework.IPlatformActionListenerInvoker, IceShareSDKLib")]
		void OnError (global::CN.Sharesdk.Framework.Platform p0, int p1, global::Java.Lang.Throwable p2);

	}

	[global::Android.Runtime.Register ("cn/sharesdk/framework/PlatformActionListener", DoNotGenerateAcw=true)]
	internal partial class IPlatformActionListenerInvoker : global::Java.Lang.Object, IPlatformActionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/PlatformActionListener", typeof (IPlatformActionListenerInvoker));

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

		public static IPlatformActionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlatformActionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.sharesdk.framework.PlatformActionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlatformActionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel_Lcn_sharesdk_framework_Platform_I;
#pragma warning disable 0169
		static Delegate GetOnCancel_Lcn_sharesdk_framework_Platform_IHandler ()
		{
			if (cb_onCancel_Lcn_sharesdk_framework_Platform_I == null)
				cb_onCancel_Lcn_sharesdk_framework_Platform_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnCancel_Lcn_sharesdk_framework_Platform_I);
			return cb_onCancel_Lcn_sharesdk_framework_Platform_I;
		}

		static void n_OnCancel_Lcn_sharesdk_framework_Platform_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::CN.Sharesdk.Framework.IPlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform p0 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCancel_Lcn_sharesdk_framework_Platform_I;
		public unsafe void OnCancel (global::CN.Sharesdk.Framework.Platform p0, int p1)
		{
			if (id_onCancel_Lcn_sharesdk_framework_Platform_I == IntPtr.Zero)
				id_onCancel_Lcn_sharesdk_framework_Platform_I = JNIEnv.GetMethodID (class_ref, "onCancel", "(Lcn/sharesdk/framework/Platform;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel_Lcn_sharesdk_framework_Platform_I, __args);
		}

		static Delegate cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_Handler ()
		{
			if (cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ == null)
				cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_);
			return cb_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_;
		}

		static void n_OnComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Framework.IPlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform p0 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_;
		public unsafe void OnComplete (global::CN.Sharesdk.Framework.Platform p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
		{
			if (id_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ == IntPtr.Zero)
				id_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcn/sharesdk/framework/Platform;ILjava/util/HashMap;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lcn_sharesdk_framework_Platform_ILjava_util_HashMap_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_Handler ()
		{
			if (cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ == null)
				cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_);
			return cb_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_;
		}

		static void n_OnError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::CN.Sharesdk.Framework.IPlatformActionListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.IPlatformActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform p0 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_;
		public unsafe void OnError (global::CN.Sharesdk.Framework.Platform p0, int p1, global::Java.Lang.Throwable p2)
		{
			if (id_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcn/sharesdk/framework/Platform;ILjava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcn_sharesdk_framework_Platform_ILjava_lang_Throwable_, __args);
		}

	}

	// event args for cn.sharesdk.framework.PlatformActionListener.onCancel
	public partial class CancelEventArgs : global::System.EventArgs {

		public CancelEventArgs (global::CN.Sharesdk.Framework.Platform p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::CN.Sharesdk.Framework.Platform p0;
		public global::CN.Sharesdk.Framework.Platform P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	// event args for cn.sharesdk.framework.PlatformActionListener.onComplete
	public partial class CompleteEventArgs : global::System.EventArgs {

		public CompleteEventArgs (global::CN.Sharesdk.Framework.Platform p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::CN.Sharesdk.Framework.Platform p0;
		public global::CN.Sharesdk.Framework.Platform P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> P2 {
			get { return p2; }
		}
	}

	// event args for cn.sharesdk.framework.PlatformActionListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::CN.Sharesdk.Framework.Platform p0, int p1, global::Java.Lang.Throwable p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::CN.Sharesdk.Framework.Platform p0;
		public global::CN.Sharesdk.Framework.Platform P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable p2;
		public global::Java.Lang.Throwable P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/cn/sharesdk/framework/PlatformActionListenerImplementor")]
	internal sealed partial class IPlatformActionListenerImplementor : global::Java.Lang.Object, IPlatformActionListener {

		object sender;

		public IPlatformActionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/sharesdk/framework/PlatformActionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CancelEventArgs> OnCancelHandler;
#pragma warning restore 0649

		public void OnCancel (global::CN.Sharesdk.Framework.Platform p0, int p1)
		{
			var __h = OnCancelHandler;
			if (__h != null)
				__h (sender, new CancelEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<CompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

		public void OnComplete (global::CN.Sharesdk.Framework.Platform p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
		{
			var __h = OnCompleteHandler;
			if (__h != null)
				__h (sender, new CompleteEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::CN.Sharesdk.Framework.Platform p0, int p1, global::Java.Lang.Throwable p2)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IPlatformActionListenerImplementor value)
		{
			return value.OnCancelHandler == null && value.OnCompleteHandler == null && value.OnErrorHandler == null;
		}
	}

}
