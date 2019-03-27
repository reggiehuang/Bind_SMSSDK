using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/PullToRequestAdatper", DoNotGenerateAcw=true)]
	public abstract partial class PullToRequestAdatper : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/gui/PullToRequestAdatper", typeof (PullToRequestAdatper));
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

		protected PullToRequestAdatper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/constructor[@name='PullToRequestAdatper' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.PullToRequestView']]"
		[Register (".ctor", "(Lcom/mob/tools/gui/PullToRequestView;)V", "")]
		public unsafe PullToRequestAdatper (global::Com.Mob.Tools.Gui.PullToRequestView view)
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
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BodyView);
		}
#pragma warning restore 0169

		public abstract global::Com.Mob.Tools.Gui.IScrollable BodyView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getBodyView' and count(parameter)=0]"
			[Register ("getBodyView", "()Lcom/mob/tools/gui/Scrollable;", "GetGetBodyViewHandler")] get;
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterView;
#pragma warning disable 0169
		static Delegate GetGetFooterViewHandler ()
		{
			if (cb_getFooterView == null)
				cb_getFooterView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFooterView);
			return cb_getFooterView;
		}

		static IntPtr n_GetFooterView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FooterView);
		}
#pragma warning restore 0169

		public abstract global::Android.Views.View FooterView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getFooterView' and count(parameter)=0]"
			[Register ("getFooterView", "()Landroid/view/View;", "GetGetFooterViewHandler")] get;
		}

		static Delegate cb_getHeaderView;
#pragma warning disable 0169
		static Delegate GetGetHeaderViewHandler ()
		{
			if (cb_getHeaderView == null)
				cb_getHeaderView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderView);
			return cb_getHeaderView;
		}

		static IntPtr n_GetHeaderView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderView);
		}
#pragma warning restore 0169

		public abstract global::Android.Views.View HeaderView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getHeaderView' and count(parameter)=0]"
			[Register ("getHeaderView", "()Landroid/view/View;", "GetGetHeaderViewHandler")] get;
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
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPullDownReady;
		}
#pragma warning restore 0169

		public abstract bool IsPullDownReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='isPullDownReady' and count(parameter)=0]"
			[Register ("isPullDownReady", "()Z", "GetIsPullDownReadyHandler")] get;
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
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPullUpReady;
		}
#pragma warning restore 0169

		public abstract bool IsPullUpReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='isPullUpReady' and count(parameter)=0]"
			[Register ("isPullUpReady", "()Z", "GetIsPullUpReadyHandler")] get;
		}

		static Delegate cb_getParent;
#pragma warning disable 0169
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParent);
			return cb_getParent;
		}

		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Mob.Tools.Gui.PullToRequestView Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lcom/mob/tools/gui/PullToRequestView;", "GetGetParentHandler")]
			get {
				const string __id = "getParent.()Lcom/mob/tools/gui/PullToRequestView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual unsafe void NotifyDataSetChanged ()
		{
			const string __id = "notifyDataSetChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPullDown_I;
#pragma warning disable 0169
		static Delegate GetOnPullDown_IHandler ()
		{
			if (cb_onPullDown_I == null)
				cb_onPullDown_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPullDown_I);
			return cb_onPullDown_I;
		}

		static void n_OnPullDown_I (IntPtr jnienv, IntPtr native__this, int percent)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullDown (percent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='onPullDown' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPullDown", "(I)V", "GetOnPullDown_IHandler")]
		public virtual unsafe void OnPullDown (int percent)
		{
			const string __id = "onPullDown.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (percent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPullUp_I;
#pragma warning disable 0169
		static Delegate GetOnPullUp_IHandler ()
		{
			if (cb_onPullUp_I == null)
				cb_onPullUp_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPullUp_I);
			return cb_onPullUp_I;
		}

		static void n_OnPullUp_I (IntPtr jnienv, IntPtr native__this, int percent)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullUp (percent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='onPullUp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPullUp", "(I)V", "GetOnPullUp_IHandler")]
		public virtual unsafe void OnPullUp (int percent)
		{
			const string __id = "onPullUp.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (percent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRefresh;
#pragma warning disable 0169
		static Delegate GetOnRefreshHandler ()
		{
			if (cb_onRefresh == null)
				cb_onRefresh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRefresh);
			return cb_onRefresh;
		}

		static void n_OnRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRefresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='onRefresh' and count(parameter)=0]"
		[Register ("onRefresh", "()V", "GetOnRefreshHandler")]
		public virtual unsafe void OnRefresh ()
		{
			const string __id = "onRefresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onRequestNext;
#pragma warning disable 0169
		static Delegate GetOnRequestNextHandler ()
		{
			if (cb_onRequestNext == null)
				cb_onRequestNext = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRequestNext);
			return cb_onRequestNext;
		}

		static void n_OnRequestNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestNext ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='onRequestNext' and count(parameter)=0]"
		[Register ("onRequestNext", "()V", "GetOnRequestNextHandler")]
		public virtual unsafe void OnRequestNext ()
		{
			const string __id = "onRequestNext.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onReversed;
#pragma warning disable 0169
		static Delegate GetOnReversedHandler ()
		{
			if (cb_onReversed == null)
				cb_onReversed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnReversed);
			return cb_onReversed;
		}

		static void n_OnReversed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestAdatper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReversed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestAdatper']/method[@name='onReversed' and count(parameter)=0]"
		[Register ("onReversed", "()V", "GetOnReversedHandler")]
		public virtual unsafe void OnReversed ()
		{
			const string __id = "onReversed.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/gui/PullToRequestAdatper", DoNotGenerateAcw=true)]
	internal partial class PullToRequestAdatperInvoker : PullToRequestAdatper {

		public PullToRequestAdatperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/gui/PullToRequestAdatper", typeof (PullToRequestAdatperInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
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
