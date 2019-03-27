using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='IndicatorView']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/IndicatorView", DoNotGenerateAcw=true)]
	public partial class IndicatorView : global::Android.Views.View {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/IndicatorView", typeof (IndicatorView));
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

		protected IndicatorView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='IndicatorView']/constructor[@name='IndicatorView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe IndicatorView (global::Android.Content.Context context)
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

		static Delegate cb_onScreenChange_II;
#pragma warning disable 0169
		static Delegate GetOnScreenChange_IIHandler ()
		{
			if (cb_onScreenChange_II == null)
				cb_onScreenChange_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnScreenChange_II);
			return cb_onScreenChange_II;
		}

		static void n_OnScreenChange_II (IntPtr jnienv, IntPtr native__this, int currentScreen, int lastScreen)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.IndicatorView __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.IndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScreenChange (currentScreen, lastScreen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='IndicatorView']/method[@name='onScreenChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onScreenChange", "(II)V", "GetOnScreenChange_IIHandler")]
		public virtual unsafe void OnScreenChange (int currentScreen, int lastScreen)
		{
			const string __id = "onScreenChange.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (currentScreen);
				__args [1] = new JniArgumentValue (lastScreen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScreenCount_I;
#pragma warning disable 0169
		static Delegate GetSetScreenCount_IHandler ()
		{
			if (cb_setScreenCount_I == null)
				cb_setScreenCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScreenCount_I);
			return cb_setScreenCount_I;
		}

		static void n_SetScreenCount_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.IndicatorView __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.IndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScreenCount (count);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='IndicatorView']/method[@name='setScreenCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScreenCount", "(I)V", "GetSetScreenCount_IHandler")]
		public virtual unsafe void SetScreenCount (int count)
		{
			const string __id = "setScreenCount.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
