using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/FriendListPage", DoNotGenerateAcw=true)]
	public abstract partial class FriendListPage : global::CN.Sharesdk.Onekeyshare.OnekeySharePage, global::Android.Views.View.IOnClickListener, global::Android.Widget.AdapterView.IOnItemClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/FriendListPage", typeof (FriendListPage));
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

		protected FriendListPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/constructor[@name='FriendListPage' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.OnekeyShareThemeImpl']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/OnekeyShareThemeImpl;)V", "")]
		public unsafe FriendListPage (global::CN.Sharesdk.Onekeyshare.OnekeyShareThemeImpl impl)
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
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DesignTitleHeight;
		}
#pragma warning restore 0169

		protected abstract int DesignTitleHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/method[@name='getDesignTitleHeight' and count(parameter)=0]"
			[Register ("getDesignTitleHeight", "()I", "GetGetDesignTitleHeightHandler")] get;
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
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ratio;
		}
#pragma warning restore 0169

		protected abstract float Ratio {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/method[@name='getRatio' and count(parameter)=0]"
			[Register ("getRatio", "()F", "GetGetRatioHandler")] get;
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View v)
		{
			const string __id = "onClick.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
#pragma warning disable 0169
		static Delegate GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler ()
		{
			if (cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
				cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ);
			return cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		}

		static void n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_view, int position, long id)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView parent = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_parent, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnItemClick (parent, view, position, id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/method[@name='onItemClick' and count(parameter)=4 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
		public virtual unsafe void OnItemClick (global::Android.Widget.AdapterView parent, global::Android.Views.View view, int position, long id)
		{
			const string __id = "onItemClick.(Landroid/widget/AdapterView;Landroid/view/View;IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [2] = new JniArgumentValue (position);
				__args [3] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPlatform_Lcn_sharesdk_framework_Platform_;
#pragma warning disable 0169
		static Delegate GetSetPlatform_Lcn_sharesdk_framework_Platform_Handler ()
		{
			if (cb_setPlatform_Lcn_sharesdk_framework_Platform_ == null)
				cb_setPlatform_Lcn_sharesdk_framework_Platform_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlatform_Lcn_sharesdk_framework_Platform_);
			return cb_setPlatform_Lcn_sharesdk_framework_Platform_;
		}

		static void n_SetPlatform_Lcn_sharesdk_framework_Platform_ (IntPtr jnienv, IntPtr native__this, IntPtr native_platform)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.FriendListPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Framework.Platform platform = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform> (native_platform, JniHandleOwnership.DoNotTransfer);
			__this.SetPlatform (platform);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/method[@name='setPlatform' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Platform']]"
		[Register ("setPlatform", "(Lcn/sharesdk/framework/Platform;)V", "GetSetPlatform_Lcn_sharesdk_framework_Platform_Handler")]
		public virtual unsafe void SetPlatform (global::CN.Sharesdk.Framework.Platform platform)
		{
			const string __id = "setPlatform.(Lcn/sharesdk/framework/Platform;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((platform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) platform).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/FriendListPage", DoNotGenerateAcw=true)]
	internal partial class FriendListPageInvoker : FriendListPage {

		public FriendListPageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/FriendListPage", typeof (FriendListPageInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe int DesignTitleHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/method[@name='getDesignTitleHeight' and count(parameter)=0]"
			[Register ("getDesignTitleHeight", "()I", "GetGetDesignTitleHeightHandler")]
			get {
				const string __id = "getDesignTitleHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected override unsafe float Ratio {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='FriendListPage']/method[@name='getRatio' and count(parameter)=0]"
			[Register ("getRatio", "()F", "GetGetRatioHandler")]
			get {
				const string __id = "getRatio.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
