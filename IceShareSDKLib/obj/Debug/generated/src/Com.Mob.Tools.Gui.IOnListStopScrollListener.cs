using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Gui {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='OnListStopScrollListener']"
	[Register ("com/mob/tools/gui/OnListStopScrollListener", "", "Com.Mob.Tools.Gui.IOnListStopScrollListenerInvoker")]
	public partial interface IOnListStopScrollListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.gui']/interface[@name='OnListStopScrollListener']/method[@name='onListStopScrolling' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onListStopScrolling", "(II)V", "GetOnListStopScrolling_IIHandler:Com.Mob.Tools.Gui.IOnListStopScrollListenerInvoker, IceShareSDKLib")]
		void OnListStopScrolling (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/mob/tools/gui/OnListStopScrollListener", DoNotGenerateAcw=true)]
	internal partial class IOnListStopScrollListenerInvoker : global::Java.Lang.Object, IOnListStopScrollListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/gui/OnListStopScrollListener", typeof (IOnListStopScrollListenerInvoker));

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

		public static IOnListStopScrollListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnListStopScrollListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.gui.OnListStopScrollListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnListStopScrollListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onListStopScrolling_II;
#pragma warning disable 0169
		static Delegate GetOnListStopScrolling_IIHandler ()
		{
			if (cb_onListStopScrolling_II == null)
				cb_onListStopScrolling_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnListStopScrolling_II);
			return cb_onListStopScrolling_II;
		}

		static void n_OnListStopScrolling_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mob.Tools.Gui.IOnListStopScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Gui.IOnListStopScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnListStopScrolling (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onListStopScrolling_II;
		public unsafe void OnListStopScrolling (int p0, int p1)
		{
			if (id_onListStopScrolling_II == IntPtr.Zero)
				id_onListStopScrolling_II = JNIEnv.GetMethodID (class_ref, "onListStopScrolling", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onListStopScrolling_II, __args);
		}

	}

	// event args for com.mob.tools.gui.OnListStopScrollListener.onListStopScrolling
	public partial class ListStopScrollEventArgs : global::System.EventArgs {

		public ListStopScrollEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mob/tools/gui/OnListStopScrollListenerImplementor")]
	internal sealed partial class IOnListStopScrollListenerImplementor : global::Java.Lang.Object, IOnListStopScrollListener {

		object sender;

		public IOnListStopScrollListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/tools/gui/OnListStopScrollListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ListStopScrollEventArgs> Handler;
#pragma warning restore 0649

		public void OnListStopScrolling (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ListStopScrollEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnListStopScrollListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
