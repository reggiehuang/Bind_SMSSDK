using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='XView']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/XView", DoNotGenerateAcw=true)]
	public partial class XView : global::Android.Views.View {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/XView", typeof (XView));
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

		protected XView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='XView']/constructor[@name='XView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe XView (global::Android.Content.Context context)
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

		static Delegate cb_setRatio_F;
#pragma warning disable 0169
		static Delegate GetSetRatio_FHandler ()
		{
			if (cb_setRatio_F == null)
				cb_setRatio_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRatio_F);
			return cb_setRatio_F;
		}

		static void n_SetRatio_F (IntPtr jnienv, IntPtr native__this, float ratio)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.XView __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.XView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRatio (ratio);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='XView']/method[@name='setRatio' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRatio", "(F)V", "GetSetRatio_FHandler")]
		public virtual unsafe void SetRatio (float ratio)
		{
			const string __id = "setRatio.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ratio);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
