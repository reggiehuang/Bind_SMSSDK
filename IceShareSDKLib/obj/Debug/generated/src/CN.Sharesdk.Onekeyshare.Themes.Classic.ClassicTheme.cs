using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='ClassicTheme']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/ClassicTheme", DoNotGenerateAcw=true)]
	public partial class ClassicTheme : global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/ClassicTheme", typeof (ClassicTheme));
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

		protected ClassicTheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='ClassicTheme']/constructor[@name='ClassicTheme' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClassicTheme ()
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

		static Delegate cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_;
#pragma warning disable 0169
		static Delegate GetShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_Handler ()
		{
			if (cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ == null)
				cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_);
			return cb_showEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_;
		}

		static void n_ShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_platform, IntPtr native_sp)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.ClassicTheme __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.ClassicTheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform platform = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_platform, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform.ShareParams sp = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.ShowEditPage (context, platform, sp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='ClassicTheme']/method[@name='showEditPage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.sharesdk.framework.Platform'] and parameter[3][@type='cn.sharesdk.framework.Platform.ShareParams']]"
		[Register ("showEditPage", "(Landroid/content/Context;Lcn/sharesdk/framework/Platform;Lcn/sharesdk/framework/Platform$ShareParams;)V", "GetShowEditPage_Landroid_content_Context_Lcn_sharesdk_framework_Platform_Lcn_sharesdk_framework_Platform_ShareParams_Handler")]
		protected override unsafe void ShowEditPage (global::Android.Content.Context context, global::CN.Sharesdk.Framework.Platform platform, global::CN.Sharesdk.Framework.Platform.ShareParams sp)
		{
			const string __id = "showEditPage.(Landroid/content/Context;Lcn/sharesdk/framework/Platform;Lcn/sharesdk/framework/Platform$ShareParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				__args [2] = new JniArgumentValue ((sp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showPlatformPage_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShowPlatformPage_Landroid_content_Context_Handler ()
		{
			if (cb_showPlatformPage_Landroid_content_Context_ == null)
				cb_showPlatformPage_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowPlatformPage_Landroid_content_Context_);
			return cb_showPlatformPage_Landroid_content_Context_;
		}

		static void n_ShowPlatformPage_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.ClassicTheme __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.ClassicTheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.ShowPlatformPage (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='ClassicTheme']/method[@name='showPlatformPage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("showPlatformPage", "(Landroid/content/Context;)V", "GetShowPlatformPage_Landroid_content_Context_Handler")]
		protected override unsafe void ShowPlatformPage (global::Android.Content.Context context)
		{
			const string __id = "showPlatformPage.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
