using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Proguard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.proguard']/interface[@name='ProtectedMemberKeeper']"
	[Register ("com/mob/tools/proguard/ProtectedMemberKeeper", "", "Com.Mob.Tools.Proguard.IProtectedMemberKeeperInvoker")]
	public partial interface IProtectedMemberKeeper : global::Com.Mob.Tools.Proguard.IClassKeeper {

	}

	[global::Android.Runtime.Register ("com/mob/tools/proguard/ProtectedMemberKeeper", DoNotGenerateAcw=true)]
	internal class IProtectedMemberKeeperInvoker : global::Java.Lang.Object, IProtectedMemberKeeper {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/proguard/ProtectedMemberKeeper", typeof (IProtectedMemberKeeperInvoker));

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

		public static IProtectedMemberKeeper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProtectedMemberKeeper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.proguard.ProtectedMemberKeeper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProtectedMemberKeeperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
