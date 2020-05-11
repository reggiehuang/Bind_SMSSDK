using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='MobLog']"
	[global::Android.Runtime.Register ("com/mob/tools/MobLog", DoNotGenerateAcw=true)]
	public partial class MobLog : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/MobLog", typeof (MobLog));
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

		protected MobLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='MobLog']/constructor[@name='MobLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobLog ()
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

		public static unsafe global::Com.Mob.Tools.Log.NLog Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='MobLog']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/mob/tools/log/NLog;", "")]
			get {
				const string __id = "getInstance.()Lcom/mob/tools/log/NLog;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Log.NLog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
