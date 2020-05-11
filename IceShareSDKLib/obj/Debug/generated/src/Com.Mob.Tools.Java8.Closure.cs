using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/Closure", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial class Closure : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Closure.IClosure']"
		[Register ("com/mob/tools/java8/Closure$IClosure", "", "Com.Mob.Tools.Java8.Closure/IClosureInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public partial interface IClosure : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Closure.IClosure']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler:Com.Mob.Tools.Java8.Closure/IClosureInvoker, IceShareSDKLib")]
			global::Java.Lang.Object Call ();

		}

		[global::Android.Runtime.Register ("com/mob/tools/java8/Closure$IClosure", DoNotGenerateAcw=true)]
		internal partial class IClosureInvoker : global::Java.Lang.Object, IClosure {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Closure$IClosure", typeof (IClosureInvoker));

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

			public static IClosure GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IClosure> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Closure.IClosure"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IClosureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.Java8.Closure.IClosure __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Closure.IClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Call ());
			}
#pragma warning restore 0169

			IntPtr id_call;
			public unsafe global::Java.Lang.Object Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Closure.IClosureV']"
		[Register ("com/mob/tools/java8/Closure$IClosureV", "", "Com.Mob.Tools.Java8.Closure/IClosureVInvoker")]
		public partial interface IClosureV : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Closure.IClosureV']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()V", "GetCallHandler:Com.Mob.Tools.Java8.Closure/IClosureVInvoker, IceShareSDKLib")]
			void Call ();

		}

		[global::Android.Runtime.Register ("com/mob/tools/java8/Closure$IClosureV", DoNotGenerateAcw=true)]
		internal partial class IClosureVInvoker : global::Java.Lang.Object, IClosureV {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Closure$IClosureV", typeof (IClosureVInvoker));

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

			public static IClosureV GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IClosureV> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.Closure.IClosureV"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IClosureVInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static void n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.Java8.Closure.IClosureV __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Closure.IClosureV> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Call ();
			}
#pragma warning restore 0169

			IntPtr id_call;
			public unsafe void Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_call);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure.Result']"
		[global::Android.Runtime.Register ("com/mob/tools/java8/Closure$Result", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public partial class Result : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Closure$Result", typeof (Result));
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

			protected Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure.Result']/constructor[@name='Closure.Result' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Result ()
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

			static Delegate cb_error;
#pragma warning disable 0169
			static Delegate GetErrorHandler ()
			{
				if (cb_error == null)
					cb_error = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Error);
				return cb_error;
			}

			static IntPtr n_Error (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.Java8.Closure.Result __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Closure.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Error ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure.Result']/method[@name='error' and count(parameter)=0]"
			[Register ("error", "()Ljava/lang/Throwable;", "GetErrorHandler")]
			public virtual unsafe global::Java.Lang.Throwable Error ()
			{
				const string __id = "error.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_result;
#pragma warning disable 0169
			static Delegate GetInvokeResultHandler ()
			{
				if (cb_result == null)
					cb_result = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeResult);
				return cb_result;
			}

			static IntPtr n_InvokeResult (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.Java8.Closure.Result __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Closure.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InvokeResult ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure.Result']/method[@name='result' and count(parameter)=0]"
			[Register ("result", "()Ljava/lang/Object;", "GetInvokeResultHandler")]
			public virtual unsafe global::Java.Lang.Object InvokeResult ()
			{
				const string __id = "result.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_throwError;
#pragma warning disable 0169
			static Delegate GetThrowErrorHandler ()
			{
				if (cb_throwError == null)
					cb_throwError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ThrowError);
				return cb_throwError;
			}

			static void n_ThrowError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.Java8.Closure.Result __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Closure.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ThrowError ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure.Result']/method[@name='throwError' and count(parameter)=0]"
			[Register ("throwError", "()V", "GetThrowErrorHandler")]
			public virtual unsafe void ThrowError ()
			{
				const string __id = "throwError.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/Closure", typeof (Closure));
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

		protected Closure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure']/constructor[@name='Closure' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Closure ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure']/method[@name='asyncCall' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Closure.IClosureV']]"
		[Register ("asyncCall", "(Lcom/mob/tools/java8/Closure$IClosureV;)V", "")]
		public static unsafe void AsyncCall (global::Com.Mob.Tools.Java8.Closure.IClosureV c)
		{
			const string __id = "asyncCall.(Lcom/mob/tools/java8/Closure$IClosureV;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure']/method[@name='call' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Closure.IClosure&lt;R&gt;']]"
		[Register ("call", "(Lcom/mob/tools/java8/Closure$IClosure;)Lcom/mob/tools/java8/Closure$Result;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Mob.Tools.Java8.Closure.Result Call (global::Com.Mob.Tools.Java8.Closure.IClosure c)
		{
			const string __id = "call.(Lcom/mob/tools/java8/Closure$IClosure;)Lcom/mob/tools/java8/Closure$Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Closure.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure']/method[@name='call' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Closure.IClosureV']]"
		[Register ("call", "(Lcom/mob/tools/java8/Closure$IClosureV;)Lcom/mob/tools/java8/Closure$Result;", "")]
		public static unsafe global::Com.Mob.Tools.Java8.Closure.Result Call (global::Com.Mob.Tools.Java8.Closure.IClosureV c)
		{
			const string __id = "call.(Lcom/mob/tools/java8/Closure$IClosureV;)Lcom/mob/tools/java8/Closure$Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Closure.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure']/method[@name='uncheck' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Closure.IClosure&lt;R&gt;']]"
		[Register ("uncheck", "(Lcom/mob/tools/java8/Closure$IClosure;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Java.Lang.Object Uncheck (global::Com.Mob.Tools.Java8.Closure.IClosure c)
		{
			const string __id = "uncheck.(Lcom/mob/tools/java8/Closure$IClosure;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Closure']/method[@name='uncheck' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Closure.IClosureV']]"
		[Register ("uncheck", "(Lcom/mob/tools/java8/Closure$IClosureV;)V", "")]
		public static unsafe void Uncheck (global::Com.Mob.Tools.Java8.Closure.IClosureV c)
		{
			const string __id = "uncheck.(Lcom/mob/tools/java8/Closure$IClosureV;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
