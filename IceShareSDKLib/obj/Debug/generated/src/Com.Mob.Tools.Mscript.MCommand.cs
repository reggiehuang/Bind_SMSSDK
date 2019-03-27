using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Mscript {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']"
	[global::Android.Runtime.Register ("com/mob/tools/mscript/MCommand", DoNotGenerateAcw=true)]
	public abstract partial class MCommand : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/field[@name='params']"
		[Register ("params")]
		protected IList<string> Params {
			get {
				const string __id = "params.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "params.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/mscript/MCommand", typeof (MCommand));
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

		protected MCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/constructor[@name='MCommand' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MCommand ()
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

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static IntPtr n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Mscript.MCommand __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.MCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Execute ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Ljava/lang/String;", "GetExecuteHandler")]
		public abstract string Execute ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/method[@name='getFromHeap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFromHeap", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		protected unsafe global::Java.Lang.Object GetFromHeap (string name)
		{
			const string __id = "getFromHeap.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/method[@name='getParams' and count(parameter)=0]"
		[Register ("getParams", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetParams ()
		{
			const string __id = "getParams.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/method[@name='setHeap' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setHeap", "(Ljava/util/HashMap;)V", "")]
		public unsafe void SetHeap (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> heap)
		{
			const string __id = "setHeap.(Ljava/util/HashMap;)V";
			IntPtr native_heap = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (heap);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_heap);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_heap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/method[@name='setParams' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setParams", "([Ljava/lang/String;)Lcom/mob/tools/mscript/MCommand;", "")]
		public unsafe global::Com.Mob.Tools.Mscript.MCommand SetParams (params string[] @params)
		{
			const string __id = "setParams.([Ljava/lang/String;)Lcom/mob/tools/mscript/MCommand;";
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__params);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.MCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/method[@name='setToHeap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setToHeap", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		protected unsafe void SetToHeap (string name, global::Java.Lang.Object value)
		{
			const string __id = "setToHeap.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/mscript/MCommand", DoNotGenerateAcw=true)]
	internal partial class MCommandInvoker : MCommand {

		public MCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/mscript/MCommand", typeof (MCommandInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Ljava/lang/String;", "GetExecuteHandler")]
		public override unsafe string Execute ()
		{
			const string __id = "execute.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
