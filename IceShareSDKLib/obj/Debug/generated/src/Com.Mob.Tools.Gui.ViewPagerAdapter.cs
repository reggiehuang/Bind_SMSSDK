using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/ViewPagerAdapter", DoNotGenerateAcw=true)]
	public abstract partial class ViewPagerAdapter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/ViewPagerAdapter", typeof (ViewPagerAdapter));
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

		protected ViewPagerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/constructor[@name='ViewPagerAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViewPagerAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
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
			global::Com.Mob.Tools.Gui.ViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public abstract int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")] get;
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
			global::Com.Mob.Tools.Gui.ViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public abstract global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2);

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.ViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public virtual unsafe void Invalidate ()
		{
			const string __id = "invalidate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onScreenChange_II;
#pragma warning disable 0169
		static Delegate GetOnScreenChange_IIHandler ()
		{
			if (cb_onScreenChange_II == null)
				cb_onScreenChange_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnScreenChange_II);
			return cb_onScreenChange_II;
		}

		static void n_OnScreenChange_II (IntPtr jnienv, IntPtr native__this, int currentScreen, int lastScreen)
		{
			global::Com.Mob.Tools.Gui.ViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScreenChange (currentScreen, lastScreen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/method[@name='onScreenChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onScreenChange", "(II)V", "GetOnScreenChange_IIHandler")]
		public virtual unsafe void OnScreenChange (int currentScreen, int lastScreen)
		{
			const string __id = "onScreenChange.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (currentScreen);
				__args [1] = new JniArgumentValue (lastScreen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onScreenChanging_F;
#pragma warning disable 0169
		static Delegate GetOnScreenChanging_FHandler ()
		{
			if (cb_onScreenChanging_F == null)
				cb_onScreenChanging_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnScreenChanging_F);
			return cb_onScreenChanging_F;
		}

		static void n_OnScreenChanging_F (IntPtr jnienv, IntPtr native__this, float position)
		{
			global::Com.Mob.Tools.Gui.ViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScreenChanging (position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/method[@name='onScreenChanging' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onScreenChanging", "(F)V", "GetOnScreenChanging_FHandler")]
		public virtual unsafe void OnScreenChanging (float position)
		{
			const string __id = "onScreenChanging.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/gui/ViewPagerAdapter", DoNotGenerateAcw=true)]
	internal partial class ViewPagerAdapterInvoker : ViewPagerAdapter {

		public ViewPagerAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/ViewPagerAdapter", typeof (ViewPagerAdapterInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/method[@name='getCount' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='ViewPagerAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
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

	}

}
