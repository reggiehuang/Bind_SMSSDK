using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic.Land {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.land']/class[@name='FriendListPageLand']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/land/FriendListPageLand", DoNotGenerateAcw=true)]
	public partial class FriendListPageLand : global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/land/FriendListPageLand", typeof (FriendListPageLand));
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

		protected FriendListPageLand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.land']/class[@name='FriendListPageLand']/constructor[@name='FriendListPageLand' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe FriendListPageLand (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
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

		static Delegate cb_getDesignTitleHeight;
#pragma warning disable 0169
		static Delegate GetGetDesignTitleHeightHandler ()
		{
			if (cb_getDesignTitleHeight == null)
				cb_getDesignTitleHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDesignTitleHeight);
			return cb_getDesignTitleHeight;
		}

		static int n_GetDesignTitleHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.Land.FriendListPageLand __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.Land.FriendListPageLand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DesignTitleHeight;
		}
#pragma warning restore 0169

		protected override unsafe int DesignTitleHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.land']/class[@name='FriendListPageLand']/method[@name='getDesignTitleHeight' and count(parameter)=0]"
			[Register ("getDesignTitleHeight", "()I", "GetGetDesignTitleHeightHandler")]
			get {
				const string __id = "getDesignTitleHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRatio;
#pragma warning disable 0169
		static Delegate GetGetRatioHandler ()
		{
			if (cb_getRatio == null)
				cb_getRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRatio);
			return cb_getRatio;
		}

		static float n_GetRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.Land.FriendListPageLand __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.Land.FriendListPageLand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ratio;
		}
#pragma warning restore 0169

		protected override unsafe float Ratio {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.land']/class[@name='FriendListPageLand']/method[@name='getRatio' and count(parameter)=0]"
			[Register ("getRatio", "()F", "GetGetRatioHandler")]
			get {
				const string __id = "getRatio.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
