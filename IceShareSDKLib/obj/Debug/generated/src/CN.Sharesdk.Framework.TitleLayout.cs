using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='TitleLayout']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/TitleLayout", DoNotGenerateAcw=true)]
	public partial class TitleLayout : global::Android.Widget.LinearLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/TitleLayout", typeof (TitleLayout));
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

		protected TitleLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='TitleLayout']/constructor[@name='TitleLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TitleLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='TitleLayout']/constructor[@name='TitleLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TitleLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		static Delegate cb_getBtnBack;
#pragma warning disable 0169
		static Delegate GetGetBtnBackHandler ()
		{
			if (cb_getBtnBack == null)
				cb_getBtnBack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBtnBack);
			return cb_getBtnBack;
		}

		static IntPtr n_GetBtnBack (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.TitleLayout __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.TitleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BtnBack);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.ImageView BtnBack {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='TitleLayout']/method[@name='getBtnBack' and count(parameter)=0]"
			[Register ("getBtnBack", "()Landroid/widget/ImageView;", "GetGetBtnBackHandler")]
			get {
				const string __id = "getBtnBack.()Landroid/widget/ImageView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBtnRight;
#pragma warning disable 0169
		static Delegate GetGetBtnRightHandler ()
		{
			if (cb_getBtnRight == null)
				cb_getBtnRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBtnRight);
			return cb_getBtnRight;
		}

		static IntPtr n_GetBtnRight (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.TitleLayout __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.TitleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BtnRight);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView BtnRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='TitleLayout']/method[@name='getBtnRight' and count(parameter)=0]"
			[Register ("getBtnRight", "()Landroid/widget/TextView;", "GetGetBtnRightHandler")]
			get {
				const string __id = "getBtnRight.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTvTitle;
#pragma warning disable 0169
		static Delegate GetGetTvTitleHandler ()
		{
			if (cb_getTvTitle == null)
				cb_getTvTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTvTitle);
			return cb_getTvTitle;
		}

		static IntPtr n_GetTvTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.TitleLayout __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.TitleLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TvTitle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView TvTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='TitleLayout']/method[@name='getTvTitle' and count(parameter)=0]"
			[Register ("getTvTitle", "()Landroid/widget/TextView;", "GetGetTvTitleHandler")]
			get {
				const string __id = "getTvTitle.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
