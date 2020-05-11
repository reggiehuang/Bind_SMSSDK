using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework.Authorize {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='ResizeLayout']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/authorize/ResizeLayout", DoNotGenerateAcw=true)]
	public partial class ResizeLayout : global::Android.Widget.LinearLayout {

		// Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='ResizeLayout.OnResizeListener']"
		[Register ("cn/sharesdk/framework/authorize/ResizeLayout$OnResizeListener", "", "CN.Sharesdk.Framework.Authorize.ResizeLayout/IOnResizeListenerInvoker")]
		public partial interface IOnResizeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/interface[@name='ResizeLayout.OnResizeListener']/method[@name='OnResize' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("OnResize", "(IIII)V", "GetOnResize_IIIIHandler:CN.Sharesdk.Framework.Authorize.ResizeLayout/IOnResizeListenerInvoker, IceShareSDKLib")]
			void OnResize (int p0, int p1, int p2, int p3);

		}

		[global::Android.Runtime.Register ("cn/sharesdk/framework/authorize/ResizeLayout$OnResizeListener", DoNotGenerateAcw=true)]
		internal partial class IOnResizeListenerInvoker : global::Java.Lang.Object, IOnResizeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/authorize/ResizeLayout$OnResizeListener", typeof (IOnResizeListenerInvoker));

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

			public static IOnResizeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnResizeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "cn.sharesdk.framework.authorize.ResizeLayout.OnResizeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnResizeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_OnResize_IIII;
#pragma warning disable 0169
			static Delegate GetOnResize_IIIIHandler ()
			{
				if (cb_OnResize_IIII == null)
					cb_OnResize_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_OnResize_IIII);
				return cb_OnResize_IIII;
			}

			static void n_OnResize_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
			{
				global::CN.Sharesdk.Framework.Authorize.ResizeLayout.IOnResizeListener __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.ResizeLayout.IOnResizeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnResize (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_OnResize_IIII;
			public unsafe void OnResize (int p0, int p1, int p2, int p3)
			{
				if (id_OnResize_IIII == IntPtr.Zero)
					id_OnResize_IIII = JNIEnv.GetMethodID (class_ref, "OnResize", "(IIII)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnResize_IIII, __args);
			}

		}

		// event args for cn.sharesdk.framework.authorize.ResizeLayout.OnResizeListener.OnResize
		public partial class ResizeEventArgs : global::System.EventArgs {

			public ResizeEventArgs (int p0, int p1, int p2, int p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/cn/sharesdk/framework/authorize/ResizeLayout_OnResizeListenerImplementor")]
		internal sealed partial class IOnResizeListenerImplementor : global::Java.Lang.Object, IOnResizeListener {

			object sender;

			public IOnResizeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/sharesdk/framework/authorize/ResizeLayout_OnResizeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ResizeEventArgs> Handler;
#pragma warning restore 0649

			public void OnResize (int p0, int p1, int p2, int p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ResizeEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnResizeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/authorize/ResizeLayout", typeof (ResizeLayout));
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

		protected ResizeLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='ResizeLayout']/constructor[@name='ResizeLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ResizeLayout (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='ResizeLayout']/constructor[@name='ResizeLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ResizeLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_;
#pragma warning disable 0169
		static Delegate GetA_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_Handler ()
		{
			if (cb_a_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_ == null)
				cb_a_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_);
			return cb_a_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_;
		}

		static void n_A_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Framework.Authorize.ResizeLayout __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.ResizeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Authorize.ResizeLayout.IOnResizeListener p0 = (global::CN.Sharesdk.Framework.Authorize.ResizeLayout.IOnResizeListener)global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.ResizeLayout.IOnResizeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='ResizeLayout']/method[@name='a' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.authorize.ResizeLayout.OnResizeListener']]"
		[Register ("a", "(Lcn/sharesdk/framework/authorize/ResizeLayout$OnResizeListener;)V", "GetA_Lcn_sharesdk_framework_authorize_ResizeLayout_OnResizeListener_Handler")]
		public virtual unsafe void A (global::CN.Sharesdk.Framework.Authorize.ResizeLayout.IOnResizeListener p0)
		{
			const string __id = "a.(Lcn/sharesdk/framework/authorize/ResizeLayout$OnResizeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
