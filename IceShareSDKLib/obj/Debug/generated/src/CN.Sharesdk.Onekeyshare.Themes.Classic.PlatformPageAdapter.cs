using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Onekeyshare.Themes.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']"
	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter", DoNotGenerateAcw=true)]
	public abstract partial class PlatformPageAdapter : global::Com.Mob.Tools.Gui.ViewPagerAdapter, global::Android.Views.View.IOnClickListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='DESIGN_BOTTOM_HEIGHT']"
		[Register ("DESIGN_BOTTOM_HEIGHT")]
		public const int DesignBottomHeight = (int) 52;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='MIN_CLICK_INTERVAL']"
		[Register ("MIN_CLICK_INTERVAL")]
		protected const int MinClickInterval = (int) 1000;


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='cellHeight']"
		[Register ("cellHeight")]
		protected int CellHeight {
			get {
				const string __id = "cellHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cellHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='cells']"
		[Register ("cells")]
		protected IList<Java.Lang.Object[]> Cells {
			get {
				const string __id = "cells.[[Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Java.Lang.Object[]>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cells.[[Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Object[]>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='lineSize']"
		[Register ("lineSize")]
		protected int LineSize {
			get {
				const string __id = "lineSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lineSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='logoHeight']"
		[Register ("logoHeight")]
		protected int LogoHeight {
			get {
				const string __id = "logoHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "logoHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='paddingTop']"
		[Register ("paddingTop")]
		protected int PaddingTop {
			get {
				const string __id = "paddingTop.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "paddingTop.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/field[@name='sepLineWidth']"
		[Register ("sepLineWidth")]
		protected int SepLineWidth {
			get {
				const string __id = "sepLineWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sepLineWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter", typeof (PlatformPageAdapter));
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

		protected PlatformPageAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/constructor[@name='PlatformPageAdapter' and count(parameter)=2 and parameter[1][@type='cn.sharesdk.onekeyshare.themes.classic.PlatformPage'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register (".ctor", "(Lcn/sharesdk/onekeyshare/themes/classic/PlatformPage;Ljava/util/ArrayList;)V", "")]
		public unsafe PlatformPageAdapter (global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPage page, global::System.Collections.Generic.IList<global::Java.Lang.Object> cells)
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

		static Delegate cb_getBottomHeight;
#pragma warning disable 0169
		static Delegate GetGetBottomHeightHandler ()
		{
			if (cb_getBottomHeight == null)
				cb_getBottomHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBottomHeight);
			return cb_getBottomHeight;
		}

		static int n_GetBottomHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BottomHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int BottomHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='getBottomHeight' and count(parameter)=0]"
			[Register ("getBottomHeight", "()I", "GetGetBottomHeightHandler")]
			get {
				const string __id = "getBottomHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPanelHeight;
#pragma warning disable 0169
		static Delegate GetGetPanelHeightHandler ()
		{
			if (cb_getPanelHeight == null)
				cb_getPanelHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPanelHeight);
			return cb_getPanelHeight;
		}

		static int n_GetPanelHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PanelHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int PanelHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='getPanelHeight' and count(parameter)=0]"
			[Register ("getPanelHeight", "()I", "GetGetPanelHeightHandler")]
			get {
				const string __id = "getPanelHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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

		static void n_CalculateSize_Landroid_content_Context_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CalculateSize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='calculateSize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("calculateSize", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "GetCalculateSize_Landroid_content_Context_Ljava_util_ArrayList_Handler")]
		protected abstract void CalculateSize (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Java.Lang.Object> p1);

		static Delegate cb_collectCells_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetCollectCells_Ljava_util_ArrayList_Handler ()
		{
			if (cb_collectCells_Ljava_util_ArrayList_ == null)
				cb_collectCells_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CollectCells_Ljava_util_ArrayList_);
			return cb_collectCells_Ljava_util_ArrayList_;
		}

		static void n_CollectCells_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CollectCells (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='collectCells' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("collectCells", "(Ljava/util/ArrayList;)V", "GetCollectCells_Ljava_util_ArrayList_Handler")]
		protected abstract void CollectCells (global::System.Collections.Generic.IList<global::Java.Lang.Object> p0);

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_convertView, IntPtr native_parent)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View convertView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_convertView, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (index, convertView, parent));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int index, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
		{
			const string __id = "getView.(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((convertView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) convertView).Handle);
				__args [2] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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

		static Delegate cb_setIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_;
#pragma warning disable 0169
		static Delegate GetSetIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_Handler ()
		{
			if (cb_setIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_ == null)
				cb_setIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_);
			return cb_setIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_;
		}

		static void n_SetIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.PlatformPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Sharesdk.Onekeyshare.Themes.Classic.IndicatorView view = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Onekeyshare.Themes.Classic.IndicatorView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicator (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='setIndicator' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.onekeyshare.themes.classic.IndicatorView']]"
		[Register ("setIndicator", "(Lcn/sharesdk/onekeyshare/themes/classic/IndicatorView;)V", "GetSetIndicator_Lcn_sharesdk_onekeyshare_themes_classic_IndicatorView_Handler")]
		public virtual unsafe void SetIndicator (global::CN.Sharesdk.Onekeyshare.Themes.Classic.IndicatorView view)
		{
			const string __id = "setIndicator.(Lcn/sharesdk/onekeyshare/themes/classic/IndicatorView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter", DoNotGenerateAcw=true)]
	internal partial class PlatformPageAdapterInvoker : PlatformPageAdapter {

		public PlatformPageAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/sharesdk/onekeyshare/themes/classic/PlatformPageAdapter", typeof (PlatformPageAdapterInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='calculateSize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("calculateSize", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "GetCalculateSize_Landroid_content_Context_Ljava_util_ArrayList_Handler")]
		protected override unsafe void CalculateSize (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Java.Lang.Object> p1)
		{
			const string __id = "calculateSize.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.onekeyshare.themes.classic']/class[@name='PlatformPageAdapter']/method[@name='collectCells' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Object&gt;']]"
		[Register ("collectCells", "(Ljava/util/ArrayList;)V", "GetCollectCells_Ljava_util_ArrayList_Handler")]
		protected override unsafe void CollectCells (global::System.Collections.Generic.IList<global::Java.Lang.Object> p0)
		{
			const string __id = "collectCells.(Ljava/util/ArrayList;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
