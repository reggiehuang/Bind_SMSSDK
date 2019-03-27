using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PRTHeader']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/PRTHeader", DoNotGenerateAcw=true)]
	public partial class PRTHeader : global::Android.Widget.LinearLayout {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/PRTHeader", typeof (PRTHeader));
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

		protected PRTHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PRTHeader']/constructor[@name='PRTHeader' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PRTHeader (global::Android.Content.Context context)
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

		static Delegate cb_onPullDown_I;
#pragma warning disable 0169
		static Delegate GetOnPullDown_IHandler ()
		{
			if (cb_onPullDown_I == null)
				cb_onPullDown_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPullDown_I);
			return cb_onPullDown_I;
		}

		static void n_OnPullDown_I (IntPtr jnienv, IntPtr native__this, int percent)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PRTHeader __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PRTHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullDown (percent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PRTHeader']/method[@name='onPullDown' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPullDown", "(I)V", "GetOnPullDown_IHandler")]
		public virtual unsafe void OnPullDown (int percent)
		{
			const string __id = "onPullDown.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (percent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRequest;
#pragma warning disable 0169
		static Delegate GetOnRequestHandler ()
		{
			if (cb_onRequest == null)
				cb_onRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRequest);
			return cb_onRequest;
		}

		static void n_OnRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PRTHeader __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PRTHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PRTHeader']/method[@name='onRequest' and count(parameter)=0]"
		[Register ("onRequest", "()V", "GetOnRequestHandler")]
		public virtual unsafe void OnRequest ()
		{
			const string __id = "onRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reverse;
#pragma warning disable 0169
		static Delegate GetReverseHandler ()
		{
			if (cb_reverse == null)
				cb_reverse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reverse);
			return cb_reverse;
		}

		static void n_Reverse (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PRTHeader __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PRTHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reverse ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PRTHeader']/method[@name='reverse' and count(parameter)=0]"
		[Register ("reverse", "()V", "GetReverseHandler")]
		public virtual unsafe void Reverse ()
		{
			const string __id = "reverse.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
