using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='OnReadListener']"
	[Register ("com/mob/tools/network/OnReadListener", "", "Com.Mob.Tools.Network.IOnReadListenerInvoker")]
	public partial interface IOnReadListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/interface[@name='OnReadListener']/method[@name='onRead' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onRead", "(J)V", "GetOnRead_JHandler:Com.Mob.Tools.Network.IOnReadListenerInvoker, IceShareSDKLib")]
		void OnRead (long p0);

	}

	[global::Android.Runtime.Register ("com/mob/tools/network/OnReadListener", DoNotGenerateAcw=true)]
	internal class IOnReadListenerInvoker : global::Java.Lang.Object, IOnReadListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/network/OnReadListener", typeof (IOnReadListenerInvoker));

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

		public static IOnReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnReadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.network.OnReadListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRead_J;
#pragma warning disable 0169
		static Delegate GetOnRead_JHandler ()
		{
			if (cb_onRead_J == null)
				cb_onRead_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnRead_J);
			return cb_onRead_J;
		}

		static void n_OnRead_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mob.Tools.Network.IOnReadListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IOnReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRead_J;
		public unsafe void OnRead (long p0)
		{
			if (id_onRead_J == IntPtr.Zero)
				id_onRead_J = JNIEnv.GetMethodID (class_ref, "onRead", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_J, __args);
		}

	}

	// event args for com.mob.tools.network.OnReadListener.onRead
	public partial class ReadEventArgs : global::System.EventArgs {

		public ReadEventArgs (long p0)
		{
			this.p0 = p0;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mob/tools/network/OnReadListenerImplementor")]
	internal sealed partial class IOnReadListenerImplementor : global::Java.Lang.Object, IOnReadListener {

		object sender;

		public IOnReadListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/tools/network/OnReadListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ReadEventArgs> Handler;
#pragma warning restore 0649

		public void OnRead (long p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ReadEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnReadListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
