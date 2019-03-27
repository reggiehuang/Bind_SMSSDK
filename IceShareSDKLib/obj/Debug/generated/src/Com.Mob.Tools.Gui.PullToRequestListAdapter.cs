using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/PullToRequestListAdapter", DoNotGenerateAcw=true)]
	public abstract partial class PullToRequestListAdapter : global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/gui/PullToRequestListAdapter", typeof (PullToRequestListAdapter));
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

		protected PullToRequestListAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/constructor[@name='PullToRequestListAdapter' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.PullToRequestView']]"
		[Register (".ctor", "(Lcom/mob/tools/gui/PullToRequestView;)V", "")]
		public unsafe PullToRequestListAdapter (global::Com.Mob.Tools.Gui.PullToRequestView view)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/mob/tools/gui/PullToRequestView;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBodyView;
#pragma warning disable 0169
		static Delegate GetGetBodyViewHandler ()
		{
			if (cb_getBodyView == null)
				cb_getBodyView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyView);
			return cb_getBodyView;
		}

		static IntPtr n_GetBodyView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BodyView);
		}
#pragma warning restore 0169

		public override unsafe global::Com.Mob.Tools.Gui.IScrollable BodyView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='getBodyView' and count(parameter)=0]"
			[Register ("getBodyView", "()Lcom/mob/tools/gui/Scrollable;", "GetGetBodyViewHandler")]
			get {
				const string __id = "getBodyView.()Lcom/mob/tools/gui/Scrollable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.IScrollable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isFling;
#pragma warning disable 0169
		static Delegate GetIsFlingHandler ()
		{
			if (cb_isFling == null)
				cb_isFling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFling);
			return cb_isFling;
		}

		static bool n_IsFling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFling;
		}
#pragma warning restore 0169

		public override unsafe bool IsFling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='isFling' and count(parameter)=0]"
			[Register ("isFling", "()Z", "GetIsFlingHandler")]
			get {
				const string __id = "isFling.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPullDownReady;
#pragma warning disable 0169
		static Delegate GetIsPullDownReadyHandler ()
		{
			if (cb_isPullDownReady == null)
				cb_isPullDownReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPullDownReady);
			return cb_isPullDownReady;
		}

		static bool n_IsPullDownReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPullDownReady;
		}
#pragma warning restore 0169

		public override unsafe bool IsPullDownReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='isPullDownReady' and count(parameter)=0]"
			[Register ("isPullDownReady", "()Z", "GetIsPullDownReadyHandler")]
			get {
				const string __id = "isPullDownReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPullUpReady;
#pragma warning disable 0169
		static Delegate GetIsPullUpReadyHandler ()
		{
			if (cb_isPullUpReady == null)
				cb_isPullUpReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPullUpReady);
			return cb_isPullUpReady;
		}

		static bool n_IsPullUpReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPullUpReady;
		}
#pragma warning restore 0169

		public override unsafe bool IsPullUpReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='isPullUpReady' and count(parameter)=0]"
			[Register ("isPullUpReady", "()Z", "GetIsPullUpReadyHandler")]
			get {
				const string __id = "isPullUpReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getListView;
#pragma warning disable 0169
		static Delegate GetGetListViewHandler ()
		{
			if (cb_getListView == null)
				cb_getListView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListView);
			return cb_getListView;
		}

		static IntPtr n_GetListView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.ListView ListView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='getListView' and count(parameter)=0]"
			[Register ("getListView", "()Landroid/widget/ListView;", "GetGetListViewHandler")]
			get {
				const string __id = "getListView.()Landroid/widget/ListView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onNewListView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnNewListView_Landroid_content_Context_Handler ()
		{
			if (cb_onNewListView_Landroid_content_Context_ == null)
				cb_onNewListView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNewListView_Landroid_content_Context_);
			return cb_onNewListView_Landroid_content_Context_;
		}

		static IntPtr n_OnNewListView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnNewListView (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='onNewListView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onNewListView", "(Landroid/content/Context;)Lcom/mob/tools/gui/ScrollableListView;", "GetOnNewListView_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Com.Mob.Tools.Gui.ScrollableListView OnNewListView (global::Android.Content.Context context)
		{
			const string __id = "onNewListView.(Landroid/content/Context;)Lcom/mob/tools/gui/ScrollableListView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ScrollableListView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onScroll_Lcom_mob_tools_gui_Scrollable_III;
#pragma warning disable 0169
		static Delegate GetOnScroll_Lcom_mob_tools_gui_Scrollable_IIIHandler ()
		{
			if (cb_onScroll_Lcom_mob_tools_gui_Scrollable_III == null)
				cb_onScroll_Lcom_mob_tools_gui_Scrollable_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Lcom_mob_tools_gui_Scrollable_III);
			return cb_onScroll_Lcom_mob_tools_gui_Scrollable_III;
		}

		static void n_OnScroll_Lcom_mob_tools_gui_Scrollable_III (IntPtr jnienv, IntPtr native__this, IntPtr native_scrollable, int firstVisibleItem, int visibleItemCount, int totalItemCount)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.IScrollable scrollable = (global::Com.Mob.Tools.Gui.IScrollable)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.IScrollable> (native_scrollable, JniHandleOwnership.DoNotTransfer);
			__this.OnScroll (scrollable, firstVisibleItem, visibleItemCount, totalItemCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='com.mob.tools.gui.Scrollable'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onScroll", "(Lcom/mob/tools/gui/Scrollable;III)V", "GetOnScroll_Lcom_mob_tools_gui_Scrollable_IIIHandler")]
		public override unsafe void OnScroll (global::Com.Mob.Tools.Gui.IScrollable scrollable, int firstVisibleItem, int visibleItemCount, int totalItemCount)
		{
			const string __id = "onScroll.(Lcom/mob/tools/gui/Scrollable;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((scrollable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scrollable).Handle);
				__args [1] = new JniArgumentValue (firstVisibleItem);
				__args [2] = new JniArgumentValue (visibleItemCount);
				__args [3] = new JniArgumentValue (totalItemCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDivider_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDivider_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDivider_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDivider_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDivider_Landroid_graphics_drawable_Drawable_);
			return cb_setDivider_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetDivider_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_divider)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable divider = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_divider, JniHandleOwnership.DoNotTransfer);
			__this.SetDivider (divider);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='setDivider' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDivider", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDivider_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetDivider (global::Android.Graphics.Drawables.Drawable divider)
		{
			const string __id = "setDivider.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((divider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) divider).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDividerHeight_I;
#pragma warning disable 0169
		static Delegate GetSetDividerHeight_IHandler ()
		{
			if (cb_setDividerHeight_I == null)
				cb_setDividerHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerHeight_I);
			return cb_setDividerHeight_I;
		}

		static void n_SetDividerHeight_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			global::Com.Mob.Tools.Gui.PullToRequestListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDividerHeight (height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestListAdapter']/method[@name='setDividerHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDividerHeight", "(I)V", "GetSetDividerHeight_IHandler")]
		public virtual unsafe void SetDividerHeight (int height)
		{
			const string __id = "setDividerHeight.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/gui/PullToRequestListAdapter", DoNotGenerateAcw=true)]
	internal partial class PullToRequestListAdapterInvoker : PullToRequestListAdapter {

		public PullToRequestListAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/gui/PullToRequestListAdapter", typeof (PullToRequestListAdapterInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override unsafe global::Java.Lang.Object GetItem (int p0)
		{
			const string __id = "getItem.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override unsafe long GetItemId (int p0)
		{
			const string __id = "getItemId.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			const string __id = "getView.(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public override unsafe global::Android.Views.View FooterView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getFooterView' and count(parameter)=0]"
			[Register ("getFooterView", "()Landroid/view/View;", "GetGetFooterViewHandler")]
			get {
				const string __id = "getFooterView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Views.View HeaderView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getHeaderView' and count(parameter)=0]"
			[Register ("getHeaderView", "()Landroid/view/View;", "GetGetHeaderViewHandler")]
			get {
				const string __id = "getHeaderView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
