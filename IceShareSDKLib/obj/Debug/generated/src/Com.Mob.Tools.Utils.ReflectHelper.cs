using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/ReflectHelper", DoNotGenerateAcw=true)]
	public partial class ReflectHelper : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ReflectHelper.ReflectRunnable']"
		[Register ("com/mob/tools/utils/ReflectHelper$ReflectRunnable", "", "Com.Mob.Tools.Utils.ReflectHelper/IReflectRunnableInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ArgType", "RetType"})]
		public partial interface IReflectRunnable : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/interface[@name='ReflectHelper.ReflectRunnable']/method[@name='run' and count(parameter)=1 and parameter[1][@type='ArgType']]"
			[Register ("run", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetRun_Ljava_lang_Object_Handler:Com.Mob.Tools.Utils.ReflectHelper/IReflectRunnableInvoker, IceShareSDKLib")]
			global::Java.Lang.Object Run (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/mob/tools/utils/ReflectHelper$ReflectRunnable", DoNotGenerateAcw=true)]
		internal class IReflectRunnableInvoker : global::Java.Lang.Object, IReflectRunnable {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/utils/ReflectHelper$ReflectRunnable", typeof (IReflectRunnableInvoker));

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

			public static IReflectRunnable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IReflectRunnable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.utils.ReflectHelper.ReflectRunnable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IReflectRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_run_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetRun_Ljava_lang_Object_Handler ()
			{
				if (cb_run_Ljava_lang_Object_ == null)
					cb_run_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Run_Ljava_lang_Object_);
				return cb_run_Ljava_lang_Object_;
			}

			static IntPtr n_Run_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Run (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_run_Ljava_lang_Object_;
			public unsafe global::Java.Lang.Object Run (global::Java.Lang.Object p0)
			{
				if (id_run_Ljava_lang_Object_ == IntPtr.Zero)
					id_run_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "run", "(Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_run_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/utils/ReflectHelper", typeof (ReflectHelper));
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

		protected ReflectHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/constructor[@name='ReflectHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReflectHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='createProxy' and count(parameter)=2 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, com.mob.tools.utils.ReflectHelper.ReflectRunnable&lt;java.lang.Object, java.lang.Object[]&gt;&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;...']]"
		[Register ("createProxy", "(Ljava/util/HashMap;[Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CreateProxy (global::System.Collections.Generic.IDictionary<string, global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable> proxyHandler, params global::Java.Lang.Class[] proxyInterfaces)
		{
			const string __id = "createProxy.(Ljava/util/HashMap;[Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_proxyHandler = global::Android.Runtime.JavaDictionary<string, global::Com.Mob.Tools.Utils.ReflectHelper.IReflectRunnable>.ToLocalJniHandle (proxyHandler);
			IntPtr native_proxyInterfaces = JNIEnv.NewArray (proxyInterfaces);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_proxyHandler);
				__args [1] = new JniArgumentValue (native_proxyInterfaces);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_proxyHandler);
				if (proxyInterfaces != null) {
					JNIEnv.CopyArray (native_proxyInterfaces, proxyInterfaces);
					JNIEnv.DeleteLocalRef (native_proxyInterfaces);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='getClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClass", "(Ljava/lang/String;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (string name)
		{
			const string __id = "getClass.(Ljava/lang/String;)Ljava/lang/Class;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='getInstanceField' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstanceField", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetInstanceField (global::Java.Lang.Object receiver, string fieldName)
		{
			const string __id = "getInstanceField.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string GetName (global::Java.Lang.Class clz)
		{
			const string __id = "getName.(Ljava/lang/Class;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='getStaticField' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticField", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetStaticField (string className, string fieldName)
		{
			const string __id = "getStaticField.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue (native_fieldName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='importClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importClass", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ImportClass (string className)
		{
			const string __id = "importClass.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_className);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='importClass' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("importClass", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ImportClass (string name, string className)
		{
			const string __id = "importClass.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_className);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='invokeInstanceMethod' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("invokeInstanceMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeInstanceMethod (global::Java.Lang.Object receiver, string methodName, params global::Java.Lang.Object[] args)
		{
			const string __id = "invokeInstanceMethod.(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='invokeStaticMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("invokeStaticMethod", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeStaticMethod (string className, string methodName, params global::Java.Lang.Object[] args)
		{
			const string __id = "invokeStaticMethod.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				JNIEnv.DeleteLocalRef (native_methodName);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("newInstance", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object NewInstance (string className, params global::Java.Lang.Object[] args)
		{
			const string __id = "newInstance.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='setInstanceField' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setInstanceField", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void SetInstanceField (global::Java.Lang.Object receiver, string fieldName, global::Java.Lang.Object value)
		{
			const string __id = "setInstanceField.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='ReflectHelper']/method[@name='setStaticField' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setStaticField", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void SetStaticField (string className, string fieldName, global::Java.Lang.Object value)
		{
			const string __id = "setStaticField.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

	}
}
