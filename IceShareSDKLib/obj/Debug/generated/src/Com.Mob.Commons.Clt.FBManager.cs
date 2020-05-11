using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Clt {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.clt']/class[@name='FBManager']"
	[global::Android.Runtime.Register ("com/mob/commons/clt/FBManager", DoNotGenerateAcw=true)]
	public partial class FBManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.commons.clt']/interface[@name='FBManager.FBListener']"
		[Register ("com/mob/commons/clt/FBManager$FBListener", "", "Com.Mob.Commons.Clt.FBManager/IFBListenerInvoker")]
		public partial interface IFBListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.clt']/interface[@name='FBManager.FBListener']/method[@name='onFBChanged' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='long']]"
			[Register ("onFBChanged", "(ZZJ)V", "GetOnFBChanged_ZZJHandler:Com.Mob.Commons.Clt.FBManager/IFBListenerInvoker, IceShareSDKLib")]
			void OnFBChanged (bool p0, bool p1, long p2);

		}

		[global::Android.Runtime.Register ("com/mob/commons/clt/FBManager$FBListener", DoNotGenerateAcw=true)]
		internal partial class IFBListenerInvoker : global::Java.Lang.Object, IFBListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/clt/FBManager$FBListener", typeof (IFBListenerInvoker));

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

			public static IFBListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFBListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.commons.clt.FBManager.FBListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFBListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFBChanged_ZZJ;
#pragma warning disable 0169
			static Delegate GetOnFBChanged_ZZJHandler ()
			{
				if (cb_onFBChanged_ZZJ == null)
					cb_onFBChanged_ZZJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, long>) n_OnFBChanged_ZZJ);
				return cb_onFBChanged_ZZJ;
			}

			static void n_OnFBChanged_ZZJ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, long p2)
			{
				global::Com.Mob.Commons.Clt.FBManager.IFBListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Clt.FBManager.IFBListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFBChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onFBChanged_ZZJ;
			public unsafe void OnFBChanged (bool p0, bool p1, long p2)
			{
				if (id_onFBChanged_ZZJ == IntPtr.Zero)
					id_onFBChanged_ZZJ = JNIEnv.GetMethodID (class_ref, "onFBChanged", "(ZZJ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFBChanged_ZZJ, __args);
			}

		}

		// event args for com.mob.commons.clt.FBManager.FBListener.onFBChanged
		public partial class FBEventArgs : global::System.EventArgs {

			public FBEventArgs (bool p0, bool p1, long p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}

			long p2;
			public long P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mob/commons/clt/FBManager_FBListenerImplementor")]
		internal sealed partial class IFBListenerImplementor : global::Java.Lang.Object, IFBListener {

			object sender;

			public IFBListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/commons/clt/FBManager_FBListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FBEventArgs> Handler;
#pragma warning restore 0649

			public void OnFBChanged (bool p0, bool p1, long p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FBEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IFBListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/clt/FBManager", typeof (FBManager));
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

		protected FBManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.clt']/class[@name='FBManager']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/mob/commons/clt/FBManager;", "")]
		public static unsafe global::Com.Mob.Commons.Clt.FBManager A ()
		{
			const string __id = "a.()Lcom/mob/commons/clt/FBManager;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Clt.FBManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_mob_commons_clt_FBManager_FBListener_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_mob_commons_clt_FBManager_FBListener_Handler ()
		{
			if (cb_a_Lcom_mob_commons_clt_FBManager_FBListener_ == null)
				cb_a_Lcom_mob_commons_clt_FBManager_FBListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_mob_commons_clt_FBManager_FBListener_);
			return cb_a_Lcom_mob_commons_clt_FBManager_FBListener_;
		}

		static void n_A_Lcom_mob_commons_clt_FBManager_FBListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Commons.Clt.FBManager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Clt.FBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Commons.Clt.FBManager.IFBListener p0 = (global::Com.Mob.Commons.Clt.FBManager.IFBListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Clt.FBManager.IFBListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.clt']/class[@name='FBManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.mob.commons.clt.FBManager.FBListener']]"
		[Register ("a", "(Lcom/mob/commons/clt/FBManager$FBListener;)V", "GetA_Lcom_mob_commons_clt_FBManager_FBListener_Handler")]
		public virtual unsafe void A (global::Com.Mob.Commons.Clt.FBManager.IFBListener p0)
		{
			const string __id = "a.(Lcom/mob/commons/clt/FBManager$FBListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_b_Lcom_mob_commons_clt_FBManager_FBListener_;
#pragma warning disable 0169
		static Delegate GetB_Lcom_mob_commons_clt_FBManager_FBListener_Handler ()
		{
			if (cb_b_Lcom_mob_commons_clt_FBManager_FBListener_ == null)
				cb_b_Lcom_mob_commons_clt_FBManager_FBListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Lcom_mob_commons_clt_FBManager_FBListener_);
			return cb_b_Lcom_mob_commons_clt_FBManager_FBListener_;
		}

		static void n_B_Lcom_mob_commons_clt_FBManager_FBListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mob.Commons.Clt.FBManager __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Clt.FBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Commons.Clt.FBManager.IFBListener p0 = (global::Com.Mob.Commons.Clt.FBManager.IFBListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Clt.FBManager.IFBListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.clt']/class[@name='FBManager']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.mob.commons.clt.FBManager.FBListener']]"
		[Register ("b", "(Lcom/mob/commons/clt/FBManager$FBListener;)V", "GetB_Lcom_mob_commons_clt_FBManager_FBListener_Handler")]
		public virtual unsafe void B (global::Com.Mob.Commons.Clt.FBManager.IFBListener p0)
		{
			const string __id = "b.(Lcom/mob/commons/clt/FBManager$FBListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
