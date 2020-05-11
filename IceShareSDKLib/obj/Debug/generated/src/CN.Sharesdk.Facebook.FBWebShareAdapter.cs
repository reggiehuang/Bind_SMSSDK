using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Facebook {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']"
	[global::Android.Runtime.Register ("cn/sharesdk/facebook/FBWebShareAdapter", DoNotGenerateAcw=true)]
	public partial class FBWebShareAdapter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/facebook/FBWebShareAdapter", typeof (FBWebShareAdapter));
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

		protected FBWebShareAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/constructor[@name='FBWebShareAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FBWebShareAdapter ()
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='getActivity' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BodyView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.RelativeLayout BodyView {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='getBodyView' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TitleLayout);
		}
#pragma warning restore 0169

		public virtual unsafe global::CN.Sharesdk.Framework.TitleLayout TitleLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='getTitleLayout' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebBody);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Webkit.WebView WebBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='getWebBody' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onCreate' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onDestroy' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnFinish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onFinish' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onRestart' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onResume' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onStart' and count(parameter)=0]"
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
			global::CN.Sharesdk.Facebook.FBWebShareAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Facebook.FBWebShareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.facebook']/class[@name='FBWebShareAdapter']/method[@name='onStop' and count(parameter)=0]"
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
