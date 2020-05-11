using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/PullToRequestView", DoNotGenerateAcw=true)]
	public partial class PullToRequestView : global::Android.Widget.RelativeLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/PullToRequestView", typeof (PullToRequestView));
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

		protected PullToRequestView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/constructor[@name='PullToRequestView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PullToRequestView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/constructor[@name='PullToRequestView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PullToRequestView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/constructor[@name='PullToRequestView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PullToRequestView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_lockPullingDown;
#pragma warning disable 0169
		static Delegate GetLockPullingDownHandler ()
		{
			if (cb_lockPullingDown == null)
				cb_lockPullingDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LockPullingDown);
			return cb_lockPullingDown;
		}

		static void n_LockPullingDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LockPullingDown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='lockPullingDown' and count(parameter)=0]"
		[Register ("lockPullingDown", "()V", "GetLockPullingDownHandler")]
		public virtual unsafe void LockPullingDown ()
		{
			const string __id = "lockPullingDown.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_lockPullingUp;
#pragma warning disable 0169
		static Delegate GetLockPullingUpHandler ()
		{
			if (cb_lockPullingUp == null)
				cb_lockPullingUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LockPullingUp);
			return cb_lockPullingUp;
		}

		static void n_LockPullingUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LockPullingUp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='lockPullingUp' and count(parameter)=0]"
		[Register ("lockPullingUp", "()V", "GetLockPullingUpHandler")]
		public virtual unsafe void LockPullingUp ()
		{
			const string __id = "lockPullingUp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_performFresh;
#pragma warning disable 0169
		static Delegate GetPerformFreshHandler ()
		{
			if (cb_performFresh == null)
				cb_performFresh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PerformFresh);
			return cb_performFresh;
		}

		static void n_PerformFresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PerformFresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='performFresh' and count(parameter)=0]"
		[Register ("performFresh", "()V", "GetPerformFreshHandler")]
		protected virtual unsafe void PerformFresh ()
		{
			const string __id = "performFresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_performPullingDown_Z;
#pragma warning disable 0169
		static Delegate GetPerformPullingDown_ZHandler ()
		{
			if (cb_performPullingDown_Z == null)
				cb_performPullingDown_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PerformPullingDown_Z);
			return cb_performPullingDown_Z;
		}

		static void n_PerformPullingDown_Z (IntPtr jnienv, IntPtr native__this, bool request)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PerformPullingDown (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='performPullingDown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("performPullingDown", "(Z)V", "GetPerformPullingDown_ZHandler")]
		public virtual unsafe void PerformPullingDown (bool request)
		{
			const string __id = "performPullingDown.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (request);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_performPullingUp_Z;
#pragma warning disable 0169
		static Delegate GetPerformPullingUp_ZHandler ()
		{
			if (cb_performPullingUp_Z == null)
				cb_performPullingUp_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PerformPullingUp_Z);
			return cb_performPullingUp_Z;
		}

		static void n_PerformPullingUp_Z (IntPtr jnienv, IntPtr native__this, bool request)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PerformPullingUp (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='performPullingUp' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("performPullingUp", "(Z)V", "GetPerformPullingUp_ZHandler")]
		public virtual unsafe void PerformPullingUp (bool request)
		{
			const string __id = "performPullingUp.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (request);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_releasePullingDownLock;
#pragma warning disable 0169
		static Delegate GetReleasePullingDownLockHandler ()
		{
			if (cb_releasePullingDownLock == null)
				cb_releasePullingDownLock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleasePullingDownLock);
			return cb_releasePullingDownLock;
		}

		static void n_ReleasePullingDownLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleasePullingDownLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='releasePullingDownLock' and count(parameter)=0]"
		[Register ("releasePullingDownLock", "()V", "GetReleasePullingDownLockHandler")]
		public virtual unsafe void ReleasePullingDownLock ()
		{
			const string __id = "releasePullingDownLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_releasePullingUpLock;
#pragma warning disable 0169
		static Delegate GetReleasePullingUpLockHandler ()
		{
			if (cb_releasePullingUpLock == null)
				cb_releasePullingUpLock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleasePullingUpLock);
			return cb_releasePullingUpLock;
		}

		static void n_ReleasePullingUpLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleasePullingUpLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='releasePullingUpLock' and count(parameter)=0]"
		[Register ("releasePullingUpLock", "()V", "GetReleasePullingUpLockHandler")]
		public virtual unsafe void ReleasePullingUpLock ()
		{
			const string __id = "releasePullingUpLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_Handler ()
		{
			if (cb_setAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_ == null)
				cb_setAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_);
			return cb_setAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_;
		}

		static void n_SetAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.PullToRequestAdatper adapter = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestAdatper> (native_adapter, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (adapter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.PullToRequestAdatper']]"
		[Register ("setAdapter", "(Lcom/mob/tools/gui/PullToRequestAdatper;)V", "GetSetAdapter_Lcom_mob_tools_gui_PullToRequestAdatper_Handler")]
		public virtual unsafe void SetAdapter (global::Com.Mob.Tools.Gui.PullToRequestAdatper adapter)
		{
			const string __id = "setAdapter.(Lcom/mob/tools/gui/PullToRequestAdatper;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopPulling;
#pragma warning disable 0169
		static Delegate GetStopPullingHandler ()
		{
			if (cb_stopPulling == null)
				cb_stopPulling = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPulling);
			return cb_stopPulling;
		}

		static void n_StopPulling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.PullToRequestView __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.PullToRequestView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPulling ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='PullToRequestView']/method[@name='stopPulling' and count(parameter)=0]"
		[Register ("stopPulling", "()V", "GetStopPullingHandler")]
		public virtual unsafe void StopPulling ()
		{
			const string __id = "stopPulling.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
