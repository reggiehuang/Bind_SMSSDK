using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/interface[@name='ShareContentCustomizeCallback']"
	[Register ("cn/sharesdk/onekeyshare/ShareContentCustomizeCallback", "", "CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallbackInvoker")]
	public partial interface IShareContentCustomizeCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare']/interface[@name='ShareContentCustomizeCallback']/method[@name='onShare' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.framework.Platform'] and parameter[2][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("onShare", "(Lcn/sharesdk/framework/Platform;Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetOnShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_Handler:CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallbackInvoker, IceShareSDKLib")]
		void OnShare (global::CN.Sharesdk.Framework.Platform p0, global::CN.Sharesdk.Framework.Platform.ShareParams p1);

	}

	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/ShareContentCustomizeCallback", DoNotGenerateAcw=true)]
	internal partial class IShareContentCustomizeCallbackInvoker : global::Java.Lang.Object, IShareContentCustomizeCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/ShareContentCustomizeCallback", typeof (IShareContentCustomizeCallbackInvoker));

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

		public static IShareContentCustomizeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShareContentCustomizeCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.sharesdk.onekeyshare.ShareContentCustomizeCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShareContentCustomizeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_;
#pragma warning disable 0169
		static Delegate GetOnShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_Handler ()
		{
			if (cb_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ == null)
				cb_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_);
			return cb_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_;
		}

		static void n_OnShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.IShareContentCustomizeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform p0 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform.ShareParams p1 = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnShare (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_;
		public unsafe void OnShare (global::CN.Sharesdk.Framework.Platform p0, global::CN.Sharesdk.Framework.Platform.ShareParams p1)
		{
			if (id_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ == IntPtr.Zero)
				id_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ = JNIEnv.GetMethodID (class_ref, "onShare", "(Lcn/sharesdk/framework/Platform;Lcn/sharesdk/framework/Platform$ShareParams;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShare_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_, __args);
		}

	}

}
