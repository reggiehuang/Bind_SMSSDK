using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic.Land {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.land']/class[@name='PlatformPageLand']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/land/PlatformPageLand", DoNotGenerateAcw=true)]
	public partial class PlatformPageLand : global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPage {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/land/PlatformPageLand", typeof (PlatformPageLand));
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

		protected PlatformPageLand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.land']/class[@name='PlatformPageLand']/constructor[@name='PlatformPageLand' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe PlatformPageLand (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
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

		static Delegate cb_newAdapter_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetNewAdapter_Ljava_util_ArrayList_Handler ()
		{
			if (cb_newAdapter_Ljava_util_ArrayList_ == null)
				cb_newAdapter_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewAdapter_Ljava_util_ArrayList_);
			return cb_newAdapter_Ljava_util_ArrayList_;
		}

		static IntPtr n_NewAdapter_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cells)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.Land.PlatformPageLand __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.Land.PlatformPageLand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cells = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_cells, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewAdapter (cells));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.land']/class[@name='PlatformPageLand']/method[@name='newAdapter' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("newAdapter", "(Ljava/util/ArrayList;)Lcn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter;", "GetNewAdapter_Ljava_util_ArrayList_Handler")]
		protected override unsafe global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter NewAdapter (global::System.Collections.Generic.IList<global::Java.Lang.Object> cells)
		{
			const string __id = "newAdapter.(Ljava/util/ArrayList;)Lcn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter;";
			IntPtr native_cells = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (cells);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cells);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cells);
			}
		}

	}
}
