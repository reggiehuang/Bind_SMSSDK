using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Mscript {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.mscript']/class[@name='MScript']"
	[global::Android.Runtime.Register ("com/mob/tools/mscript/MScript", DoNotGenerateAcw=true)]
	public partial class MScript : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/mscript/MScript", typeof (MScript));
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

		protected MScript (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
