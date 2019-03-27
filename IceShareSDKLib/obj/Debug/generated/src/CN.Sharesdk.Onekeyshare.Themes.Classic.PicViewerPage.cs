using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PicViewerPage']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/PicViewerPage", DoNotGenerateAcw=true)]
	public partial class PicViewerPage : global::CN.Sharesdk.Onekeyshare.OnekeySharePage, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/PicViewerPage", typeof (PicViewerPage));
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

		protected PicViewerPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PicViewerPage']/constructor[@name='PicViewerPage' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe PicViewerPage (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onGlobalLayout;
#pragma warning disable 0169
		static Delegate GetOnGlobalLayoutHandler ()
		{
			if (cb_onGlobalLayout == null)
				cb_onGlobalLayout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGlobalLayout);
			return cb_onGlobalLayout;
		}

		static void n_OnGlobalLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PicViewerPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PicViewerPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGlobalLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PicViewerPage']/method[@name='onGlobalLayout' and count(parameter)=0]"
		[Register ("onGlobalLayout", "()V", "GetOnGlobalLayoutHandler")]
		public virtual unsafe void OnGlobalLayout ()
		{
			const string __id = "onGlobalLayout.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setImageBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImageBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImageBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setImageBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageBitmap_Landroid_graphics_Bitmap_);
			return cb_setImageBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetImageBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pic)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PicViewerPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PicViewerPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap pic = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_pic, JniHandleOwnership.DoNotTransfer);
			__this.SetImageBitmap (pic);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PicViewerPage']/method[@name='setImageBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImageBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetImageBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetImageBitmap (global::Android.Graphics.Bitmap pic)
		{
			const string __id = "setImageBitmap.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pic).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
