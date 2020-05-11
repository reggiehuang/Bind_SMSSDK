using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework.Authorize {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='AuthorizeListener']"
	[Register ("cn/sharesdk/framework/authorize/AuthorizeListener", "", "CN.Sharesdk.Framework.Authorize.IAuthorizeListenerInvoker")]
	public partial interface IAuthorizeListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='AuthorizeListener']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:CN.Sharesdk.Framework.Authorize.IAuthorizeListenerInvoker, IceShareSDKLib")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='AuthorizeListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onComplete", "(Landroid/os/Bundle;)V", "GetOnComplete_Landroid_os_Bundle_Handler:CN.Sharesdk.Framework.Authorize.IAuthorizeListenerInvoker, IceShareSDKLib")]
		void OnComplete (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='AuthorizeListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:CN.Sharesdk.Framework.Authorize.IAuthorizeListenerInvoker, IceShareSDKLib")]
		void OnError (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("cn/sharesdk/framework/authorize/AuthorizeListener", DoNotGenerateAcw=true)]
	internal partial class IAuthorizeListenerInvoker : global::Java.Lang.Object, IAuthorizeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/authorize/AuthorizeListener", typeof (IAuthorizeListenerInvoker));

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

		public static IAuthorizeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthorizeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.sharesdk.framework.authorize.AuthorizeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthorizeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.IAuthorizeListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.IAuthorizeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
		}

		static Delegate cb_onComplete_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Landroid_os_Bundle_Handler ()
		{
			if (cb_onComplete_Landroid_os_Bundle_ == null)
				cb_onComplete_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Landroid_os_Bundle_);
			return cb_onComplete_Landroid_os_Bundle_;
		}

		static void n_OnComplete_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Authorize.IAuthorizeListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.IAuthorizeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Landroid_os_Bundle_;
		public unsafe void OnComplete (global::Android.OS.Bundle p0)
		{
			if (id_onComplete_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onComplete_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Authorize.IAuthorizeListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.IAuthorizeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
		}

	}

	// event args for cn.sharesdk.framework.authorize.AuthorizeListener.onComplete
	public partial class CompleteEventArgs : global::System.EventArgs {

		public CompleteEventArgs (global::Android.OS.Bundle p0)
		{
			this.p0 = p0;
		}

		global::Android.OS.Bundle p0;
		public global::Android.OS.Bundle P0 {
			get { return p0; }
		}
	}

	// event args for cn.sharesdk.framework.authorize.AuthorizeListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Java.Lang.Throwable p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Throwable p0;
		public global::Java.Lang.Throwable P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/cn/sharesdk/framework/authorize/AuthorizeListenerImplementor")]
	internal sealed partial class IAuthorizeListenerImplementor : global::Java.Lang.Object, IAuthorizeListener {

		object sender;

		public IAuthorizeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/sharesdk/framework/authorize/AuthorizeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnCancelHandler;
#pragma warning restore 0649

		public void OnCancel ()
		{
			var __h = OnCancelHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<CompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

		public void OnComplete (global::Android.OS.Bundle p0)
		{
			var __h = OnCompleteHandler;
			if (__h != null)
				__h (sender, new CompleteEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Java.Lang.Throwable p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}

		internal static bool __IsEmpty (IAuthorizeListenerImplementor value)
		{
			return value.OnCancelHandler == null && value.OnCompleteHandler == null && value.OnErrorHandler == null;
		}
	}

}
