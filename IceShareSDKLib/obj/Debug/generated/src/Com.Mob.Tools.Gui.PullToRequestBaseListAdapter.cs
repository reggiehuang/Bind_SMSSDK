using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/PullToRequestBaseListAdapter", DoNotGenerateAcw=true)]
	public abstract partial class PullToRequestBaseListAdapter : global::Com.Mob.Tools.Gui.PullToRequestAdatper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/gui/PullToRequestBaseListAdapter", typeof (PullToRequestBaseListAdapter));
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

		protected PullToRequestBaseListAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/constructor[@name='PullToRequestBaseListAdapter' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.PullToRequestView']]"
		[Register (".ctor", "(Lcom/mob/tools/gui/PullToRequestView;)V", "")]
		public unsafe PullToRequestBaseListAdapter (global::Com.Mob.Tools.Gui.PullToRequestView view)
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
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public abstract int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")] get;
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
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFling;
		}
#pragma warning restore 0169

		public abstract bool IsFling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='isFling' and count(parameter)=0]"
			[Register ("isFling", "()Z", "GetIsFlingHandler")] get;
		}

		static Delegate cb_getViewTypeCount;
#pragma warning disable 0169
		static Delegate GetGetViewTypeCountHandler ()
		{
			if (cb_getViewTypeCount == null)
				cb_getViewTypeCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetViewTypeCount);
			return cb_getViewTypeCount;
		}

		static int n_GetViewTypeCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewTypeCount;
		}
#pragma warning restore 0169

		public virtual unsafe int ViewTypeCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getViewTypeCount' and count(parameter)=0]"
			[Register ("getViewTypeCount", "()I", "GetGetViewTypeCountHandler")]
			get {
				const string __id = "getViewTypeCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public abstract global::Java.Lang.Object GetItem (int p0);

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public abstract long GetItemId (int p0);

		static Delegate cb_getItemViewType_I;
#pragma warning disable 0169
		static Delegate GetGetItemViewType_IHandler ()
		{
			if (cb_getItemViewType_I == null)
				cb_getItemViewType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetItemViewType_I);
			return cb_getItemViewType_I;
		}

		static int n_GetItemViewType_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemViewType (position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemViewType", "(I)I", "GetGetItemViewType_IHandler")]
		public virtual unsafe int GetItemViewType (int position)
		{
			const string __id = "getItemViewType.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public abstract global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2);

		static Delegate cb_onScroll_Lcom_mob_tools_gui_Scrollable_III;
#pragma warning disable 0169
		static Delegate GetOnScroll_Lcom_mob_tools_gui_Scrollable_IIIHandler ()
		{
			if (cb_onScroll_Lcom_mob_tools_gui_Scrollable_III == null)
				cb_onScroll_Lcom_mob_tools_gui_Scrollable_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Lcom_mob_tools_gui_Scrollable_III);
			return cb_onScroll_Lcom_mob_tools_gui_Scrollable_III;
		}

		static void n_OnScroll_Lcom_mob_tools_gui_Scrollable_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestBaseListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.IScrollable p0 = (global::Com.Mob.Tools.Gui.IScrollable)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.IScrollable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScroll (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='com.mob.tools.gui.Scrollable'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onScroll", "(Lcom/mob/tools/gui/Scrollable;III)V", "GetOnScroll_Lcom_mob_tools_gui_Scrollable_IIIHandler")]
		public abstract void OnScroll (global::Com.Mob.Tools.Gui.IScrollable p0, int p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/mob/tools/gui/PullToRequestBaseListAdapter", DoNotGenerateAcw=true)]
	internal partial class PullToRequestBaseListAdapterInvoker : PullToRequestBaseListAdapter {

		public PullToRequestBaseListAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/gui/PullToRequestBaseListAdapter", typeof (PullToRequestBaseListAdapterInvoker));

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

		public override unsafe bool IsFling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='isFling' and count(parameter)=0]"
			[Register ("isFling", "()Z", "GetIsFlingHandler")]
			get {
				const string __id = "isFling.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestBaseListAdapter']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='com.mob.tools.gui.Scrollable'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onScroll", "(Lcom/mob/tools/gui/Scrollable;III)V", "GetOnScroll_Lcom_mob_tools_gui_Scrollable_IIIHandler")]
		public override unsafe void OnScroll (global::Com.Mob.Tools.Gui.IScrollable p0, int p1, int p2, int p3)
		{
			const string __id = "onScroll.(Lcom/mob/tools/gui/Scrollable;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		public override unsafe global::Com.Mob.Tools.Gui.IScrollable BodyView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getBodyView' and count(parameter)=0]"
			[Register ("getBodyView", "()Lcom/mob/tools/gui/Scrollable;", "GetGetBodyViewHandler")]
			get {
				const string __id = "getBodyView.()Lcom/mob/tools/gui/Scrollable;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.IScrollable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		public override unsafe bool IsPullDownReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='isPullDownReady' and count(parameter)=0]"
			[Register ("isPullDownReady", "()Z", "GetIsPullDownReadyHandler")]
			get {
				const string __id = "isPullDownReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsPullUpReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='isPullUpReady' and count(parameter)=0]"
			[Register ("isPullUpReady", "()Z", "GetIsPullUpReadyHandler")]
			get {
				const string __id = "isPullUpReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
