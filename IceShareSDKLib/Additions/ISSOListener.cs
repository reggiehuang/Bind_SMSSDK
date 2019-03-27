using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework.Authorize
{

    // Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='SSOListener']"
    [Register("cn/sharesdk/framework/authorize/SSOListener", "", "CN.Sharesdk.Framework.Authorize.ISSOListenerInvoker")]
    public partial interface ISSOListener : IJavaObject
    {

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='SSOListener']/method[@name='onCancel' and count(parameter)=0]"
        [Register("onCancel", "()V", "GetOnCancelHandler:CN.Sharesdk.Framework.Authorize.ISSOListenerInvoker, IceShareSDKLib")]
        void OnCancel();

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='SSOListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
        [Register("onComplete", "(Landroid/os/Bundle;)V", "GetOnComplete_Landroid_os_Bundle_Handler:CN.Sharesdk.Framework.Authorize.ISSOListenerInvoker, IceShareSDKLib")]
        void OnComplete(global::Android.OS.Bundle p0);

        // Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='SSOListener']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
        [Register("onFailed", "(Ljava/lang/Throwable;)V", "GetOnFailed_Ljava_lang_Throwable_Handler:CN.Sharesdk.Framework.Authorize.ISSOListenerInvoker, IceShareSDKLib")]
        void OnFailed(global::Java.Lang.Throwable p0);

    }

    [global::Android.Runtime.Register("cn/sharesdk/framework/authorize/SSOListener", DoNotGenerateAcw = true)]
    internal class ISSOListenerInvoker : global::Java.Lang.Object, ISSOListener
    {

        internal new static readonly JniPeerMembers _members = new JniPeerMembers("cn/sharesdk/framework/authorize/SSOListener", typeof(ISSOListenerInvoker));

        static IntPtr java_class_ref
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        IntPtr class_ref;

        public static ISSOListener GetObject(IntPtr handle, JniHandleOwnership transfer)
        {
            return global::Java.Lang.Object.GetObject<ISSOListener>(handle, transfer);
        }

        static IntPtr Validate(IntPtr handle)
        {
            if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                            JNIEnv.GetClassNameFromInstance(handle), "cn.sharesdk.framework.authorize.SSOListener"));
            return handle;
        }

        protected override void Dispose(bool disposing)
        {
            if (this.class_ref != IntPtr.Zero)
                JNIEnv.DeleteGlobalRef(this.class_ref);
            this.class_ref = IntPtr.Zero;
            base.Dispose(disposing);
        }

        public ISSOListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
        {
            IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
            this.class_ref = JNIEnv.NewGlobalRef(local_ref);
            JNIEnv.DeleteLocalRef(local_ref);
        }

        static Delegate cb_onCancel;
#pragma warning disable 0169
        static Delegate GetOnCancelHandler()
        {
            if (cb_onCancel == null)
                cb_onCancel = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_OnCancel);
            return cb_onCancel;
        }

        static void n_OnCancel(IntPtr jnienv, IntPtr native__this)
        {
            global::CN.Sharesdk.Framework.Authorize.ISSOListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.ISSOListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.OnCancel();
        }
#pragma warning restore 0169

        IntPtr id_onCancel;
        public unsafe void OnCancel()
        {
            if (id_onCancel == IntPtr.Zero)
                id_onCancel = JNIEnv.GetMethodID(class_ref, "onCancel", "()V");
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onCancel);
        }

        static Delegate cb_onComplete_Landroid_os_Bundle_;
#pragma warning disable 0169
        static Delegate GetOnComplete_Landroid_os_Bundle_Handler()
        {
            if (cb_onComplete_Landroid_os_Bundle_ == null)
                cb_onComplete_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnComplete_Landroid_os_Bundle_);
            return cb_onComplete_Landroid_os_Bundle_;
        }

        static void n_OnComplete_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::CN.Sharesdk.Framework.Authorize.ISSOListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.ISSOListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.OnComplete(p0);
        }
#pragma warning restore 0169

        IntPtr id_onComplete_Landroid_os_Bundle_;
        public unsafe void OnComplete(global::Android.OS.Bundle p0)
        {
            if (id_onComplete_Landroid_os_Bundle_ == IntPtr.Zero)
                id_onComplete_Landroid_os_Bundle_ = JNIEnv.GetMethodID(class_ref, "onComplete", "(Landroid/os/Bundle;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onComplete_Landroid_os_Bundle_, __args);
        }

        static Delegate cb_onFailed_Ljava_lang_Throwable_;
#pragma warning disable 0169
        static Delegate GetOnFailed_Ljava_lang_Throwable_Handler()
        {
            if (cb_onFailed_Ljava_lang_Throwable_ == null)
                cb_onFailed_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnFailed_Ljava_lang_Throwable_);
            return cb_onFailed_Ljava_lang_Throwable_;
        }

        static void n_OnFailed_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::CN.Sharesdk.Framework.Authorize.ISSOListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.ISSOListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.OnFailed(p0);
        }
#pragma warning restore 0169

        IntPtr id_onFailed_Ljava_lang_Throwable_;
        public unsafe void OnFailed(global::Java.Lang.Throwable p0)
        {
            if (id_onFailed_Ljava_lang_Throwable_ == IntPtr.Zero)
                id_onFailed_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(class_ref, "onFailed", "(Ljava/lang/Throwable;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable)p0).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onFailed_Ljava_lang_Throwable_, __args);
        }

    }

    // event args for cn.sharesdk.framework.authorize.SSOListener.onComplete
    //public partial class CompleteEventArgs : global::System.EventArgs {

    //	public CompleteEventArgs (global::Android.OS.Bundle p0)
    //	{
    //		this.p0 = p0;
    //	}

    //	global::Android.OS.Bundle p01;
    //	public global::Android.OS.Bundle P0 {
    //		get { return p0; }
    //	}
    //}

    // event args for cn.sharesdk.framework.authorize.SSOListener.onFailed
    public partial class FailedEventArgs : global::System.EventArgs
    {

        public FailedEventArgs(global::Java.Lang.Throwable p0)
        {
            this.p0 = p0;
        }

        global::Java.Lang.Throwable p0;
        public global::Java.Lang.Throwable P0
        {
            get { return p0; }
        }
    }

    [global::Android.Runtime.Register("mono/cn/sharesdk/framework/authorize/SSOListenerImplementor")]
    internal sealed partial class ISSOListenerImplementor : global::Java.Lang.Object, ISSOListener
    {

        object sender;

        public ISSOListenerImplementor(object sender)
            : base(
                global::Android.Runtime.JNIEnv.StartCreateInstance("mono/cn/sharesdk/framework/authorize/SSOListenerImplementor", "()V"),
                JniHandleOwnership.TransferLocalRef)
        {
            global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
            this.sender = sender;
        }

#pragma warning disable 0649
        public EventHandler OnCancelHandler;
#pragma warning restore 0649

        public void OnCancel()
        {
            var __h = OnCancelHandler;
            if (__h != null)
                __h(sender, new EventArgs());
        }
#pragma warning disable 0649
        public EventHandler<CompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

        public void OnComplete(global::Android.OS.Bundle p0)
        {
            var __h = OnCompleteHandler;
            if (__h != null)
                __h(sender, new CompleteEventArgs(p0));
        }
#pragma warning disable 0649
        public EventHandler<FailedEventArgs> OnFailedHandler;
#pragma warning restore 0649

        public void OnFailed(global::Java.Lang.Throwable p0)
        {
            var __h = OnFailedHandler;
            if (__h != null)
                __h(sender, new FailedEventArgs(p0));
        }

        internal static bool __IsEmpty(ISSOListenerImplementor value)
        {
            return value.OnCancelHandler == null && value.OnCompleteHandler == null && value.OnFailedHandler == null;
        }
    }

}
