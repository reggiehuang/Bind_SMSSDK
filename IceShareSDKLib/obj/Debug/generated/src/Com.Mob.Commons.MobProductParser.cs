using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductParser']"
	[global::Android.Runtime.Register ("com/mob/commons/MobProductParser", DoNotGenerateAcw=true)]
	public partial class MobProductParser : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/MobProductParser", typeof (MobProductParser));
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

		protected MobProductParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductParser']/constructor[@name='MobProductParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobProductParser ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductParser']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Mob.Commons.IMobProduct> Parse ()
		{
			const string __id = "parse.()Ljava/util/HashMap;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaDictionary<string, global::Com.Mob.Commons.IMobProduct>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
