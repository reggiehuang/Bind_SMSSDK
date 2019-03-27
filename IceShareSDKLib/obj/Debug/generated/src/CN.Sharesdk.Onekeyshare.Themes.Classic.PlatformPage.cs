using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPage']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/PlatformPage", DoNotGenerateAcw=true)]
	public abstract partial class PlatformPage : global::CN.Sharesdk.Onekeyshare.OnekeySharePage {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/PlatformPage", typeof (PlatformPage));
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

		protected PlatformPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPage']/constructor[@name='PlatformPage' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe PlatformPage (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
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

		static Delegate cb_collectCells;
#pragma warning disable 0169
		static Delegate GetCollectCellsHandler ()
		{
			if (cb_collectCells == null)
				cb_collectCells = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CollectCells);
			return cb_collectCells;
		}

		static IntPtr n_CollectCells (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (__this.CollectCells ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPage']/method[@name='collectCells' and count(parameter)=0]"
		[Register ("collectCells", "()Ljava/util/ArrayList;", "GetCollectCellsHandler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object> CollectCells ()
		{
			const string __id = "collectCells.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_NewAdapter_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewAdapter (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPage']/method[@name='newAdapter' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("newAdapter", "(Ljava/util/ArrayList;)Lcn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter;", "GetNewAdapter_Ljava_util_ArrayList_Handler")]
		protected abstract global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter NewAdapter (global::System.Collections.Generic.IList<global::Java.Lang.Object> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPage']/method[@name='performCustomLogoClick' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='cn.sharesdk.onekeyshare.CustomerLogo']]"
		[Register ("performCustomLogoClick", "(Landroid/view/View;Lcn/sharesdk/onekeyshare/CustomerLogo;)V", "")]
		public unsafe void PerformCustomLogoClick (global::Android.Views.View v, global::CN.Sharesdk.Onekeyshare.CustomerLogo logo)
		{
			const string __id = "performCustomLogoClick.(Landroid/view/View;Lcn/sharesdk/onekeyshare/CustomerLogo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue ((logo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logo).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPage']/method[@name='showEditPage' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform']]"
		[Register ("showEditPage", "(Lcn/sharesdk/framework/Platform;)V", "")]
		public unsafe void ShowEditPage (global::CN.Sharesdk.Framework.Platform platform)
		{
			const string __id = "showEditPage.(Lcn/sharesdk/framework/Platform;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/PlatformPage", DoNotGenerateAcw=true)]
	internal partial class PlatformPageInvoker : PlatformPage {

		public PlatformPageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/PlatformPage", typeof (PlatformPageInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPage']/method[@name='newAdapter' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("newAdapter", "(Ljava/util/ArrayList;)Lcn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter;", "GetNewAdapter_Ljava_util_ArrayList_Handler")]
		protected override unsafe global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter NewAdapter (global::System.Collections.Generic.IList<global::Java.Lang.Object> p0)
		{
			const string __id = "newAdapter.(Ljava/util/ArrayList;)Lcn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
