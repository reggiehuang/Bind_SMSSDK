using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Mscript.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='InvokeStatic']"
	[global::Android.Runtime.Register ("com/mob/tools/mscript/commands/InvokeStatic", DoNotGenerateAcw=true)]
	public partial class InvokeStatic : global::Com.Mob.Tools.Mscript.MCommand {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/mscript/commands/InvokeStatic", typeof (InvokeStatic));
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

		protected InvokeStatic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='InvokeStatic']/constructor[@name='InvokeStatic' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InvokeStatic ()
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
			global::Com.Mob.Tools.Mscript.Commands.InvokeStatic __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.Commands.InvokeStatic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Execute ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='InvokeStatic']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Ljava/lang/String;", "GetExecuteHandler")]
		public override unsafe string Execute ()
		{
			const string __id = "execute.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
