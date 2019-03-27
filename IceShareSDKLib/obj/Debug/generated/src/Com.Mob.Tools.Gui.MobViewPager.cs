using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']"
	[global::Android.Runtime.Register ("com/mob/tools/gui/MobViewPager", DoNotGenerateAcw=true)]
	public partial class MobViewPager : global::Android.Views.ViewGroup {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/gui/MobViewPager", typeof (MobViewPager));
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

		protected MobViewPager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/constructor[@name='MobViewPager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobViewPager (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/constructor[@name='MobViewPager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MobViewPager (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/constructor[@name='MobViewPager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MobViewPager (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
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

		static Delegate cb_getCurrentScreen;
#pragma warning disable 0169
		static Delegate GetGetCurrentScreenHandler ()
		{
			if (cb_getCurrentScreen == null)
				cb_getCurrentScreen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentScreen);
			return cb_getCurrentScreen;
		}

		static int n_GetCurrentScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Gui.MobViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScreen;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentScreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/method[@name='getCurrentScreen' and count(parameter)=0]"
			[Register ("getCurrentScreen", "()I", "GetGetCurrentScreenHandler")]
			get {
				const string __id = "getCurrentScreen.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			global::Com.Mob.Tools.Gui.MobViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, l, t, r, b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool changed, int l, int t, int r, int b)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (l);
				__args [2] = new JniArgumentValue (t);
				__args [3] = new JniArgumentValue (r);
				__args [4] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollLeft_Z;
#pragma warning disable 0169
		static Delegate GetScrollLeft_ZHandler ()
		{
			if (cb_scrollLeft_Z == null)
				cb_scrollLeft_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ScrollLeft_Z);
			return cb_scrollLeft_Z;
		}

		static void n_ScrollLeft_Z (IntPtr jnienv, IntPtr native__this, bool immediate)
		{
			global::Com.Mob.Tools.Gui.MobViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollLeft (immediate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/method[@name='scrollLeft' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollLeft", "(Z)V", "GetScrollLeft_ZHandler")]
		public virtual unsafe void ScrollLeft (bool immediate)
		{
			const string __id = "scrollLeft.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (immediate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollRight_Z;
#pragma warning disable 0169
		static Delegate GetScrollRight_ZHandler ()
		{
			if (cb_scrollRight_Z == null)
				cb_scrollRight_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ScrollRight_Z);
			return cb_scrollRight_Z;
		}

		static void n_ScrollRight_Z (IntPtr jnienv, IntPtr native__this, bool immediate)
		{
			global::Com.Mob.Tools.Gui.MobViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollRight (immediate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/method[@name='scrollRight' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollRight", "(Z)V", "GetScrollRight_ZHandler")]
		public virtual unsafe void ScrollRight (bool immediate)
		{
			const string __id = "scrollRight.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (immediate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollToScreen_IZ;
#pragma warning disable 0169
		static Delegate GetScrollToScreen_IZHandler ()
		{
			if (cb_scrollToScreen_IZ == null)
				cb_scrollToScreen_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_ScrollToScreen_IZ);
			return cb_scrollToScreen_IZ;
		}

		static void n_ScrollToScreen_IZ (IntPtr jnienv, IntPtr native__this, int whichScreen, bool immediate)
		{
			global::Com.Mob.Tools.Gui.MobViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollToScreen (whichScreen, immediate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/method[@name='scrollToScreen' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("scrollToScreen", "(IZ)V", "GetScrollToScreen_IZHandler")]
		public virtual unsafe void ScrollToScreen (int whichScreen, bool immediate)
		{
			const string __id = "scrollToScreen.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (whichScreen);
				__args [1] = new JniArgumentValue (immediate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollToScreen_IZZ;
#pragma warning disable 0169
		static Delegate GetScrollToScreen_IZZHandler ()
		{
			if (cb_scrollToScreen_IZZ == null)
				cb_scrollToScreen_IZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool, bool>) n_ScrollToScreen_IZZ);
			return cb_scrollToScreen_IZZ;
		}

		static void n_ScrollToScreen_IZZ (IntPtr jnienv, IntPtr native__this, int whichScreen, bool immediate, bool skip)
		{
			global::Com.Mob.Tools.Gui.MobViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollToScreen (whichScreen, immediate, skip);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/method[@name='scrollToScreen' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("scrollToScreen", "(IZZ)V", "GetScrollToScreen_IZZHandler")]
		public virtual unsafe void ScrollToScreen (int whichScreen, bool immediate, bool skip)
		{
			const string __id = "scrollToScreen.(IZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (whichScreen);
				__args [1] = new JniArgumentValue (immediate);
				__args [2] = new JniArgumentValue (skip);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_Handler ()
		{
			if (cb_setAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_ == null)
				cb_setAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_);
			return cb_setAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_;
		}

		static void n_SetAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			global::Com.Mob.Tools.Gui.MobViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.MobViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.ViewPagerAdapter adapter = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.ViewPagerAdapter> (native_adapter, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (adapter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/class[@name='MobViewPager']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='com.mob.tools.gui.ViewPagerAdapter']]"
		[Register ("setAdapter", "(Lcom/mob/tools/gui/ViewPagerAdapter;)V", "GetSetAdapter_Lcom_mob_tools_gui_ViewPagerAdapter_Handler")]
		public virtual unsafe void SetAdapter (global::Com.Mob.Tools.Gui.ViewPagerAdapter adapter)
		{
			const string __id = "setAdapter.(Lcom/mob/tools/gui/ViewPagerAdapter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
