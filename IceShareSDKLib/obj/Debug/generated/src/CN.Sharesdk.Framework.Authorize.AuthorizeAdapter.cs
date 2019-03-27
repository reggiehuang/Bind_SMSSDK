using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework.Authorize {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/authorize/AuthorizeAdapter", DoNotGenerateAcw=true)]
	public partial class AuthorizeAdapter : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/framework/authorize/AuthorizeAdapter", typeof (AuthorizeAdapter));
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

		protected AuthorizeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/constructor[@name='AuthorizeAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthorizeAdapter ()
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

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				const string __id = "getActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBodyView;
#pragma warning disable 0169
		static Delegate GetGetBodyViewHandler ()
		{
			if (cb_getBodyView == null)
				cb_getBodyView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyView);
			return cb_getBodyView;
		}

		static IntPtr n_GetBodyView (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BodyView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.RelativeLayout BodyView {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='getBodyView' and count(parameter)=0]"
			[Register ("getBodyView", "()Landroid/widget/RelativeLayout;", "GetGetBodyViewHandler")]
			get {
				const string __id = "getBodyView.()Landroid/widget/RelativeLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformName;
#pragma warning disable 0169
		static Delegate GetGetPlatformNameHandler ()
		{
			if (cb_getPlatformName == null)
				cb_getPlatformName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatformName);
			return cb_getPlatformName;
		}

		static IntPtr n_GetPlatformName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlatformName);
		}
#pragma warning restore 0169

		public virtual unsafe string PlatformName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='getPlatformName' and count(parameter)=0]"
			[Register ("getPlatformName", "()Ljava/lang/String;", "GetGetPlatformNameHandler")]
			get {
				const string __id = "getPlatformName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitleLayout;
#pragma warning disable 0169
		static Delegate GetGetTitleLayoutHandler ()
		{
			if (cb_getTitleLayout == null)
				cb_getTitleLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleLayout);
			return cb_getTitleLayout;
		}

		static IntPtr n_GetTitleLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TitleLayout);
		}
#pragma warning restore 0169

		public virtual unsafe global::CN.Sharesdk.Framework.TitleLayout TitleLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='getTitleLayout' and count(parameter)=0]"
			[Register ("getTitleLayout", "()Lcn/sharesdk/framework/TitleLayout;", "GetGetTitleLayoutHandler")]
			get {
				const string __id = "getTitleLayout.()Lcn/sharesdk/framework/TitleLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.TitleLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWebBody;
#pragma warning disable 0169
		static Delegate GetGetWebBodyHandler ()
		{
			if (cb_getWebBody == null)
				cb_getWebBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebBody);
			return cb_getWebBody;
		}

		static IntPtr n_GetWebBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebBody);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Webkit.WebView WebBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='getWebBody' and count(parameter)=0]"
			[Register ("getWebBody", "()Landroid/webkit/WebView;", "GetGetWebBodyHandler")]
			get {
				const string __id = "getWebBody.()Landroid/webkit/WebView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_disablePopUpAnimation;
#pragma warning disable 0169
		static Delegate GetDisablePopUpAnimationHandler ()
		{
			if (cb_disablePopUpAnimation == null)
				cb_disablePopUpAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisablePopUpAnimation);
			return cb_disablePopUpAnimation;
		}

		static void n_DisablePopUpAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisablePopUpAnimation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='disablePopUpAnimation' and count(parameter)=0]"
		[Register ("disablePopUpAnimation", "()V", "GetDisablePopUpAnimationHandler")]
		protected virtual unsafe void DisablePopUpAnimation ()
		{
			const string __id = "disablePopUpAnimation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_hideShareSDKLogo;
#pragma warning disable 0169
		static Delegate GetHideShareSDKLogoHandler ()
		{
			if (cb_hideShareSDKLogo == null)
				cb_hideShareSDKLogo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideShareSDKLogo);
			return cb_hideShareSDKLogo;
		}

		static void n_HideShareSDKLogo (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideShareSDKLogo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='hideShareSDKLogo' and count(parameter)=0]"
		[Register ("hideShareSDKLogo", "()V", "GetHideShareSDKLogoHandler")]
		public virtual unsafe void HideShareSDKLogo ()
		{
			const string __id = "hideShareSDKLogo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCreate);
			return cb_onCreate;
		}

		static void n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "GetOnCreateHandler")]
		public virtual unsafe void OnCreate ()
		{
			const string __id = "onCreate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onFinish;
#pragma warning disable 0169
		static Delegate GetOnFinishHandler ()
		{
			if (cb_onFinish == null)
				cb_onFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnFinish);
			return cb_onFinish;
		}

		static bool n_OnFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnFinish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()Z", "GetOnFinishHandler")]
		public virtual unsafe bool OnFinish ()
		{
			const string __id = "onFinish.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onKeyEvent_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyEvent_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyEvent_ILandroid_view_KeyEvent_ == null)
				cb_onKeyEvent_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyEvent_ILandroid_view_KeyEvent_);
			return cb_onKeyEvent_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyEvent_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_e)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyEvent (keyCode, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onKeyEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyEvent", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyEvent_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyEvent (int keyCode, global::Android.Views.KeyEvent e)
		{
			const string __id = "onKeyEvent.(ILandroid/view/KeyEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (keyCode);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResize_IIII;
#pragma warning disable 0169
		static Delegate GetOnResize_IIIIHandler ()
		{
			if (cb_onResize_IIII == null)
				cb_onResize_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_OnResize_IIII);
			return cb_onResize_IIII;
		}

		static void n_OnResize_IIII (IntPtr jnienv, IntPtr native__this, int w, int h, int oldw, int oldh)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResize (w, h, oldw, oldh);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onResize' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onResize", "(IIII)V", "GetOnResize_IIIIHandler")]
		public virtual unsafe void OnResize (int w, int h, int oldw, int oldh)
		{
			const string __id = "onResize.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (w);
				__args [1] = new JniArgumentValue (h);
				__args [2] = new JniArgumentValue (oldw);
				__args [3] = new JniArgumentValue (oldh);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRestart;
#pragma warning disable 0169
		static Delegate GetOnRestartHandler ()
		{
			if (cb_onRestart == null)
				cb_onRestart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRestart);
			return cb_onRestart;
		}

		static void n_OnRestart (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onRestart' and count(parameter)=0]"
		[Register ("onRestart", "()V", "GetOnRestartHandler")]
		public virtual unsafe void OnRestart ()
		{
			const string __id = "onRestart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Authorize.AuthorizeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework.authorize']/class[@name='AuthorizeAdapter']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
