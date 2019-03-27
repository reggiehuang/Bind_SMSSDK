using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Smssdk.Contact {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.smssdk.contact']/interface[@name='OnContactChangeListener']"
	[Register ("cn/smssdk/contact/OnContactChangeListener", "", "CN.Smssdk.Contact.IOnContactChangeListenerInvoker")]
	public partial interface IOnContactChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.smssdk.contact']/interface[@name='OnContactChangeListener']/method[@name='onContactChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onContactChange", "(Z)V", "GetOnContactChange_ZHandler:CN.Smssdk.Contact.IOnContactChangeListenerInvoker, IceShareSDKLib")]
		void OnContactChange (bool p0);

	}

	[global::Android.Runtime.Register ("cn/smssdk/contact/OnContactChangeListener", DoNotGenerateAcw=true)]
	internal class IOnContactChangeListenerInvoker : global::Java.Lang.Object, IOnContactChangeListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/smssdk/contact/OnContactChangeListener", typeof (IOnContactChangeListenerInvoker));

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

		public static IOnContactChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnContactChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.smssdk.contact.OnContactChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnContactChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onContactChange_Z;
#pragma warning disable 0169
		static Delegate GetOnContactChange_ZHandler ()
		{
			if (cb_onContactChange_Z == null)
				cb_onContactChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnContactChange_Z);
			return cb_onContactChange_Z;
		}

		static void n_OnContactChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Smssdk.Contact.IOnContactChangeListener __this = global::Java.Lang.Object.GetObject<global::CN.Smssdk.Contact.IOnContactChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnContactChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onContactChange_Z;
		public unsafe void OnContactChange (bool p0)
		{
			if (id_onContactChange_Z == IntPtr.Zero)
				id_onContactChange_Z = JNIEnv.GetMethodID (class_ref, "onContactChange", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContactChange_Z, __args);
		}

	}

	// event args for cn.smssdk.contact.OnContactChangeListener.onContactChange
	public partial class ContactChangeEventArgs : global::System.EventArgs {

		public ContactChangeEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/cn/smssdk/contact/OnContactChangeListenerImplementor")]
	internal sealed partial class IOnContactChangeListenerImplementor : global::Java.Lang.Object, IOnContactChangeListener {

		object sender;

		public IOnContactChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/smssdk/contact/OnContactChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ContactChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnContactChange (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ContactChangeEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnContactChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
