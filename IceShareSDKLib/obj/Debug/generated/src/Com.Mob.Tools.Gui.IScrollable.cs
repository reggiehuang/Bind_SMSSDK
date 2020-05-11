using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='Scrollable.OnScrollListener']"
	[Register ("com/mob/tools/gui/Scrollable$OnScrollListener", "", "Com.Mob.Tools.Gui.IScrollableOnScrollListenerInvoker")]
	public partial interface IScrollableOnScrollListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='Scrollable.OnScrollListener']/method[@name='onScrollChanged' and count(parameter)=5 and parameter[1][@type='com.mob.tools.gui.Scrollable'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onScrollChanged", "(Lcom/mob/tools/gui/Scrollable;IIII)V", "GetOnScrollChanged_Lcom_mob_tools_gui_Scrollable_IIIIHandler:Com.Mob.Tools.Gui.IScrollableOnScrollListenerInvoker, IceShareSDKLib")]
		void OnScrollChanged (global::Com.Mob.Tools.Gui.IScrollable p0, int p1, int p2, int p3, int p4);

	}

	[global::Android.Runtime.Register ("com/mob/tools/gui/Scrollable$OnScrollListener", DoNotGenerateAcw=true)]
	internal partial class IScrollableOnScrollListenerInvoker : global::Java.Lang.Object, IScrollableOnScrollListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/Scrollable$OnScrollListener", typeof (IScrollableOnScrollListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IScrollableOnScrollListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScrollableOnScrollListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.gui.Scrollable.OnScrollListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScrollableOnScrollListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII;
#pragma warning disable 0169
		static Delegate GetOnScrollChanged_Lcom_mob_tools_gui_Scrollable_IIIIHandler ()
		{
			if (cb_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII == null)
				cb_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_OnScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII);
			return cb_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII;
		}

		static void n_OnScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Mob.Tools.Gui.IScrollableOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.IScrollableOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Gui.IScrollable p0 = (global::Com.Mob.Tools.Gui.IScrollable)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.IScrollable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollChanged (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII;
		public unsafe void OnScrollChanged (global::Com.Mob.Tools.Gui.IScrollable p0, int p1, int p2, int p3, int p4)
		{
			if (id_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII == IntPtr.Zero)
				id_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII = JNIEnv.GetMethodID (class_ref, "onScrollChanged", "(Lcom/mob/tools/gui/Scrollable;IIII)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollChanged_Lcom_mob_tools_gui_Scrollable_IIII, __args);
		}

	}

	// event args for com.mob.tools.gui.Scrollable.OnScrollListener.onScrollChanged
	public partial class ScrollableOnScrollEventArgs : global::System.EventArgs {

		public ScrollableOnScrollEventArgs (global::Com.Mob.Tools.Gui.IScrollable p0, int p1, int p2, int p3, int p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Com.Mob.Tools.Gui.IScrollable p0;
		public global::Com.Mob.Tools.Gui.IScrollable P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}

		int p4;
		public int P4 {
			get { return p4; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mob/tools/gui/Scrollable_OnScrollListenerImplementor")]
	internal sealed partial class IScrollableOnScrollListenerImplementor : global::Java.Lang.Object, IScrollableOnScrollListener {

		object sender;

		public IScrollableOnScrollListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/tools/gui/Scrollable_OnScrollListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ScrollableOnScrollEventArgs> Handler;
#pragma warning restore 0649

		public void OnScrollChanged (global::Com.Mob.Tools.Gui.IScrollable p0, int p1, int p2, int p3, int p4)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ScrollableOnScrollEventArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IScrollableOnScrollListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='Scrollable']"
	[Register ("com/mob/tools/gui/Scrollable", "", "Com.Mob.Tools.Gui.IScrollableInvoker")]
	public partial interface IScrollable : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/mob/tools/gui/Scrollable", DoNotGenerateAcw=true)]
	internal partial class IScrollableInvoker : global::Java.Lang.Object, IScrollable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/Scrollable", typeof (IScrollableInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IScrollable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScrollable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.gui.Scrollable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScrollableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
