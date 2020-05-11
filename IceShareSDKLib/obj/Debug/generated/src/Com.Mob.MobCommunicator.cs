using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator']"
	[global::Android.Runtime.Register ("com/mob/MobCommunicator", DoNotGenerateAcw=true)]
	public sealed partial class MobCommunicator : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator.Callback']"
		[global::Android.Runtime.Register ("com/mob/MobCommunicator$Callback", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class Callback : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/MobCommunicator$Callback", typeof (Callback));
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

			protected Callback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator.Callback']/constructor[@name='MobCommunicator.Callback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Callback ()
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

			static Delegate cb_onResultError_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnResultError_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onResultError_Ljava_lang_Throwable_ == null)
					cb_onResultError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResultError_Ljava_lang_Throwable_);
				return cb_onResultError_Ljava_lang_Throwable_;
			}

			static void n_OnResultError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.MobCommunicator.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobCommunicator.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResultError (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator.Callback']/method[@name='onResultError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onResultError", "(Ljava/lang/Throwable;)V", "GetOnResultError_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void OnResultError (global::Java.Lang.Throwable p0)
			{
				const string __id = "onResultError.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onResultOk_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnResultOk_Ljava_lang_Object_Handler ()
			{
				if (cb_onResultOk_Ljava_lang_Object_ == null)
					cb_onResultOk_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResultOk_Ljava_lang_Object_);
				return cb_onResultOk_Ljava_lang_Object_;
			}

			static void n_OnResultOk_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.MobCommunicator.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobCommunicator.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResultOk (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator.Callback']/method[@name='onResultOk' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("onResultOk", "(Ljava/lang/Object;)V", "GetOnResultOk_Ljava_lang_Object_Handler")]
			public virtual unsafe void OnResultOk (global::Java.Lang.Object p0)
			{
				const string __id = "onResultOk.(Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator.NetworkError']"
		[global::Android.Runtime.Register ("com/mob/MobCommunicator$NetworkError", DoNotGenerateAcw=true)]
		public partial class NetworkError : global::Java.Lang.Exception, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/MobCommunicator$NetworkError", typeof (NetworkError));
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

			protected NetworkError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator.NetworkError']/constructor[@name='MobCommunicator.NetworkError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe NetworkError (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/MobCommunicator", typeof (MobCommunicator));
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

		internal MobCommunicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator']/constructor[@name='MobCommunicator' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MobCommunicator (int p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator']/method[@name='request' and count(parameter)=4 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='com.mob.MobCommunicator.Callback&lt;T&gt;']]"
		[Register ("request", "(Ljava/util/HashMap;Ljava/lang/String;ZLcom/mob/MobCommunicator$Callback;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe void Request (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, string p1, bool p2, global::Com.Mob.MobCommunicator.Callback p3)
		{
			const string __id = "request.(Ljava/util/HashMap;Ljava/lang/String;ZLcom/mob/MobCommunicator$Callback;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator']/method[@name='requestSynchronized' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("requestSynchronized", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object RequestSynchronized (string p0, string p1, bool p2)
		{
			const string __id = "requestSynchronized.(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobCommunicator']/method[@name='requestSynchronized' and count(parameter)=3 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("requestSynchronized", "(Ljava/util/HashMap;Ljava/lang/String;Z)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object RequestSynchronized (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, string p1, bool p2)
		{
			const string __id = "requestSynchronized.(Ljava/util/HashMap;Ljava/lang/String;Z)Ljava/lang/Object;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
