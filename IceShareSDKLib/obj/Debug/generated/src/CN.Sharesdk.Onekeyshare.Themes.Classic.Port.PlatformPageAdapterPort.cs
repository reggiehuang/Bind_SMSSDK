using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic.Port {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.port']/class[@name='PlatformPageAdapterPort']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/port/PlatformPageAdapterPort", DoNotGenerateAcw=true)]
	public partial class PlatformPageAdapterPort : global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/port/PlatformPageAdapterPort", typeof (PlatformPageAdapterPort));
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

		protected PlatformPageAdapterPort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.port']/class[@name='PlatformPageAdapterPort']/constructor[@name='PlatformPageAdapterPort' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.onekeyshare.themes.classic.PlatformPage'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/themes/classic/PlatformPage;Ljava/util/ArrayList;)V", "")]
		public unsafe PlatformPageAdapterPort (global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPage page, global::System.Collections.Generic.IList<global::Java.Lang.Object> cells)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcn/sharesdk/onekeyshare/themes/classic/PlatformPage;Ljava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_cells = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (cells);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((page == null) ? IntPtr.Zero : ((global::Java.Lang.Object) page).Handle);
				__args [1] = new JniArgumentValue (native_cells);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cells);
			}
		}

		static Delegate cb_calculateSize_Landroid_content_Context_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetCalculateSize_Landroid_content_Context_Ljava_util_ArrayList_Handler ()
		{
			if (cb_calculateSize_Landroid_content_Context_Ljava_util_ArrayList_ == null)
				cb_calculateSize_Landroid_content_Context_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CalculateSize_Landroid_content_Context_Ljava_util_ArrayList_);
			return cb_calculateSize_Landroid_content_Context_Ljava_util_ArrayList_;
		}

		static void n_CalculateSize_Landroid_content_Context_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_plats)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.Port.PlatformPageAdapterPort __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.Port.PlatformPageAdapterPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var plats = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_plats, JniHandleOwnership.DoNotTransfer);
			__this.CalculateSize (context, plats);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.port']/class[@name='PlatformPageAdapterPort']/method[@name='calculateSize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("calculateSize", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "GetCalculateSize_Landroid_content_Context_Ljava_util_ArrayList_Handler")]
		protected override unsafe void CalculateSize (global::Android.Content.Context context, global::System.Collections.Generic.IList<global::Java.Lang.Object> plats)
		{
			const string __id = "calculateSize.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_plats = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (plats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_plats);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_plats);
			}
		}

		static Delegate cb_collectCells_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetCollectCells_Ljava_util_ArrayList_Handler ()
		{
			if (cb_collectCells_Ljava_util_ArrayList_ == null)
				cb_collectCells_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CollectCells_Ljava_util_ArrayList_);
			return cb_collectCells_Ljava_util_ArrayList_;
		}

		static void n_CollectCells_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_plats)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.Port.PlatformPageAdapterPort __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.Port.PlatformPageAdapterPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var plats = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_plats, JniHandleOwnership.DoNotTransfer);
			__this.CollectCells (plats);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic.port']/class[@name='PlatformPageAdapterPort']/method[@name='collectCells' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("collectCells", "(Ljava/util/ArrayList;)V", "GetCollectCells_Ljava_util_ArrayList_Handler")]
		protected override unsafe void CollectCells (global::System.Collections.Generic.IList<global::Java.Lang.Object> plats)
		{
			const string __id = "collectCells.(Ljava/util/ArrayList;)V";
			IntPtr native_plats = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (plats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_plats);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_plats);
			}
		}

	}
}
