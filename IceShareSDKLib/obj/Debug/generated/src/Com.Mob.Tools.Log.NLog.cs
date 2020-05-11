using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']"
	[global::Android.Runtime.Register ("com/mob/tools/log/NLog", DoNotGenerateAcw=true)]
	public abstract partial class NLog : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/log/NLog", typeof (NLog));
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

		protected NLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/constructor[@name='NLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NLog ()
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

		static Delegate cb_getSDKTag;
#pragma warning disable 0169
		static Delegate GetGetSDKTagHandler ()
		{
			if (cb_getSDKTag == null)
				cb_getSDKTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSDKTag);
			return cb_getSDKTag;
		}

		static IntPtr n_GetSDKTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Log.NLog __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKTag);
		}
#pragma warning restore 0169

		protected abstract string SDKTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='getSDKTag' and count(parameter)=0]"
			[Register ("getSDKTag", "()Ljava/lang/String;", "GetGetSDKTagHandler")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='crash' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("crash", "(Ljava/lang/Throwable;)I", "")]
		public unsafe int Crash (global::Java.Lang.Throwable t)
		{
			const string __id = "crash.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int D (global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "d.(Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/Throwable;)I", "")]
		public unsafe int D (global::Java.Lang.Throwable t)
		{
			const string __id = "d.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int D (global::Java.Lang.Throwable throwable, global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "d.(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "")]
		public static unsafe void Disable ()
		{
			const string __id = "disable.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int E (global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "e.(Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/Throwable;)I", "")]
		public unsafe int E (global::Java.Lang.Throwable t)
		{
			const string __id = "e.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int E (global::Java.Lang.Throwable throwable, global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "e.(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;)Lcom/mob/tools/log/NLog;", "")]
		public static unsafe global::Com.Mob.Tools.Log.NLog GetInstance (string sdkTag)
		{
			const string __id = "getInstance.(Ljava/lang/String;)Lcom/mob/tools/log/NLog;";
			IntPtr native_sdkTag = JNIEnv.NewString (sdkTag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sdkTag);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sdkTag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='getInstanceForSDK' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("getInstanceForSDK", "(Ljava/lang/String;Z)Lcom/mob/tools/log/NLog;", "")]
		protected static unsafe global::Com.Mob.Tools.Log.NLog GetInstanceForSDK (string sdkTag, bool createNew)
		{
			const string __id = "getInstanceForSDK.(Ljava/lang/String;Z)Lcom/mob/tools/log/NLog;";
			IntPtr native_sdkTag = JNIEnv.NewString (sdkTag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sdkTag);
				__args [1] = new JniArgumentValue (createNew);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sdkTag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int I (global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "i.(Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/Throwable;)I", "")]
		public unsafe int I (global::Java.Lang.Throwable t)
		{
			const string __id = "i.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int I (global::Java.Lang.Throwable throwable, global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "i.(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static Delegate cb_setCollector_Lcom_mob_tools_log_LogCollector_;
#pragma warning disable 0169
		static Delegate GetSetCollector_Lcom_mob_tools_log_LogCollector_Handler ()
		{
			if (cb_setCollector_Lcom_mob_tools_log_LogCollector_ == null)
				cb_setCollector_Lcom_mob_tools_log_LogCollector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCollector_Lcom_mob_tools_log_LogCollector_);
			return cb_setCollector_Lcom_mob_tools_log_LogCollector_;
		}

		static IntPtr n_SetCollector_Lcom_mob_tools_log_LogCollector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collector)
		{
			global::Com.Mob.Tools.Log.NLog __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Log.ILogCollector collector = (global::Com.Mob.Tools.Log.ILogCollector)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.ILogCollector> (native_collector, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCollector (collector));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='setCollector' and count(parameter)=1 and parameter[1][@type='com.mob.tools.log.LogCollector']]"
		[Register ("setCollector", "(Lcom/mob/tools/log/LogCollector;)Lcom/mob/tools/log/NLog;", "GetSetCollector_Lcom_mob_tools_log_LogCollector_Handler")]
		public virtual unsafe global::Com.Mob.Tools.Log.NLog SetCollector (global::Com.Mob.Tools.Log.ILogCollector collector)
		{
			const string __id = "setCollector.(Lcom/mob/tools/log/LogCollector;)Lcom/mob/tools/log/NLog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((collector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collector).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='setCollector' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mob.tools.log.LogCollector']]"
		[Obsolete (@"deprecated")]
		[Register ("setCollector", "(Ljava/lang/String;Lcom/mob/tools/log/LogCollector;)V", "")]
		public static unsafe void SetCollector (string sdkTag, global::Com.Mob.Tools.Log.ILogCollector collector)
		{
			const string __id = "setCollector.(Ljava/lang/String;Lcom/mob/tools/log/LogCollector;)V";
			IntPtr native_sdkTag = JNIEnv.NewString (sdkTag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sdkTag);
				__args [1] = new JniArgumentValue ((collector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collector).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sdkTag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("setContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetContext (global::Android.Content.Context context)
		{
			const string __id = "setContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='setDefaultCollector' and count(parameter)=1 and parameter[1][@type='Collector']]"
		[Register ("setDefaultCollector", "(Lcom/mob/tools/log/LogCollector;)Lcom/mob/tools/log/LogCollector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Collector extends com.mob.tools.log.LogCollector"})]
		public static unsafe global::Java.Lang.Object SetDefaultCollector (global::Java.Lang.Object collector)
		{
			const string __id = "setDefaultCollector.(Lcom/mob/tools/log/LogCollector;)Lcom/mob/tools/log/LogCollector;";
			IntPtr native_collector = JNIEnv.ToLocalJniHandle (collector);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_collector);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_collector);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int V (global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "v.(Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/Throwable;)I", "")]
		public unsafe int V (global::Java.Lang.Throwable t)
		{
			const string __id = "v.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int V (global::Java.Lang.Throwable throwable, global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "v.(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int W (global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "w.(Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)I", "")]
		public unsafe int W (string m)
		{
			const string __id = "w.(Ljava/lang/String;)I";
			IntPtr native_m = JNIEnv.NewString (m);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_m);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_m);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/Throwable;)I", "")]
		public unsafe int W (global::Java.Lang.Throwable t)
		{
			const string __id = "w.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I", "")]
		public unsafe int W (global::Java.Lang.Throwable throwable, global::Java.Lang.Object format, params global::Java.Lang.Object[] args)
		{
			const string __id = "w.(Ljava/lang/Throwable;Ljava/lang/Object;[Ljava/lang/Object;)I";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static Delegate cb_wtf_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetWtf_Ljava_lang_Throwable_Handler ()
		{
			if (cb_wtf_Ljava_lang_Throwable_ == null)
				cb_wtf_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Wtf_Ljava_lang_Throwable_);
			return cb_wtf_Ljava_lang_Throwable_;
		}

		static int n_Wtf_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			global::Com.Mob.Tools.Log.NLog __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Wtf (t);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='wtf' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("wtf", "(Ljava/lang/Throwable;)I", "GetWtf_Ljava_lang_Throwable_Handler")]
		public virtual unsafe int Wtf (global::Java.Lang.Throwable t)
		{
			const string __id = "wtf.(Ljava/lang/Throwable;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/log/NLog", DoNotGenerateAcw=true)]
	internal partial class NLogInvoker : NLog {

		public NLogInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/log/NLog", typeof (NLogInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe string SDKTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.log']/class[@name='NLog']/method[@name='getSDKTag' and count(parameter)=0]"
			[Register ("getSDKTag", "()Ljava/lang/String;", "GetGetSDKTagHandler")]
			get {
				const string __id = "getSDKTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
