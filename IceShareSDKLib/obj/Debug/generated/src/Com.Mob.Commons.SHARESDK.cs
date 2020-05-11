using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons']/class[@name='SHARESDK']"
	[global::Android.Runtime.Register ("com/mob/commons/SHARESDK", DoNotGenerateAcw=true)]
	public partial class SHARESDK : global::Java.Lang.Object, global::Com.Mob.Commons.IMobProduct {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/SHARESDK", typeof (SHARESDK));
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

		protected SHARESDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons']/class[@name='SHARESDK']/constructor[@name='SHARESDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SHARESDK ()
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

		static Delegate cb_getProductTag;
#pragma warning disable 0169
		static Delegate GetGetProductTagHandler ()
		{
			if (cb_getProductTag == null)
				cb_getProductTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductTag);
			return cb_getProductTag;
		}

		static IntPtr n_GetProductTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Commons.SHARESDK __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.SHARESDK> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductTag);
		}
#pragma warning restore 0169

		public virtual unsafe string ProductTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='SHARESDK']/method[@name='getProductTag' and count(parameter)=0]"
			[Register ("getProductTag", "()Ljava/lang/String;", "GetGetProductTagHandler")]
			get {
				const string __id = "getProductTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSdkver;
#pragma warning disable 0169
		static Delegate GetGetSdkverHandler ()
		{
			if (cb_getSdkver == null)
				cb_getSdkver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSdkver);
			return cb_getSdkver;
		}

		static int n_GetSdkver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Commons.SHARESDK __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.SHARESDK> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sdkver;
		}
#pragma warning restore 0169

		public virtual unsafe int Sdkver {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='SHARESDK']/method[@name='getSdkver' and count(parameter)=0]"
			[Register ("getSdkver", "()I", "GetGetSdkverHandler")]
			get {
				const string __id = "getSdkver.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
