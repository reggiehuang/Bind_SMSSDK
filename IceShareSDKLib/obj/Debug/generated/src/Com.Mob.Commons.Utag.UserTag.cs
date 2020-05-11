using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Utag {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTag']"
	[global::Android.Runtime.Register ("com/mob/commons/utag/UserTag", DoNotGenerateAcw=true)]
	public partial class UserTag : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/utag/UserTag", typeof (UserTag));
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

		protected UserTag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Mob.Commons.Utag.TagRequester UserTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTag']/method[@name='getUserTags' and count(parameter)=0]"
			[Register ("getUserTags", "()Lcom/mob/commons/utag/TagRequester;", "")]
			get {
				const string __id = "getUserTags.()Lcom/mob/commons/utag/TagRequester;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.TagRequester> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='UserTag']/method[@name='tagUser' and count(parameter)=0]"
		[Register ("tagUser", "()Lcom/mob/commons/utag/UserTager;", "")]
		public static unsafe global::Com.Mob.Commons.Utag.UserTager TagUser ()
		{
			const string __id = "tagUser.()Lcom/mob/commons/utag/UserTager;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.UserTager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
