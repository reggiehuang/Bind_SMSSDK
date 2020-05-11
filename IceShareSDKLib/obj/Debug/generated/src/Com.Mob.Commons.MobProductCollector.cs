using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']"
	[global::Android.Runtime.Register ("com/mob/commons/MobProductCollector", DoNotGenerateAcw=true)]
	public partial class MobProductCollector : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/field[@name='MOB_PRODUCTS']"
		[Register ("MOB_PRODUCTS")]
		public static IList<string> MobProducts {
			get {
				const string __id = "MOB_PRODUCTS.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/MobProductCollector", typeof (MobProductCollector));
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

		protected MobProductCollector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/constructor[@name='MobProductCollector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobProductCollector ()
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

		public static unsafe global::System.Collections.Generic.IList<global::Com.Mob.Commons.IMobProduct> Products {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/method[@name='getProducts' and count(parameter)=0]"
			[Register ("getProducts", "()Ljava/util/ArrayList;", "")]
			get {
				const string __id = "getProducts.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Mob.Commons.IMobProduct>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string UserIdentity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/method[@name='getUserIdentity' and count(parameter)=0]"
			[Register ("getUserIdentity", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getUserIdentity.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/method[@name='collect' and count(parameter)=0]"
		[Register ("collect", "()V", "")]
		public static unsafe void Collect ()
		{
			const string __id = "collect.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/method[@name='getUserIdentity' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.mob.commons.MobProduct&gt;']]"
		[Register ("getUserIdentity", "(Ljava/util/ArrayList;)Ljava/lang/String;", "")]
		public static unsafe string GetUserIdentity (global::System.Collections.Generic.IList<global::Com.Mob.Commons.IMobProduct> p0)
		{
			const string __id = "getUserIdentity.(Ljava/util/ArrayList;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mob.Commons.IMobProduct>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/method[@name='registerProduct' and count(parameter)=1 and parameter[1][@type='com.mob.commons.MobProduct']]"
		[Register ("registerProduct", "(Lcom/mob/commons/MobProduct;)Z", "")]
		public static unsafe bool RegisterProduct (global::Com.Mob.Commons.IMobProduct p0)
		{
			const string __id = "registerProduct.(Lcom/mob/commons/MobProduct;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons']/class[@name='MobProductCollector']/method[@name='syncInit' and count(parameter)=0]"
		[Register ("syncInit", "()V", "")]
		public static unsafe void SyncInit ()
		{
			const string __id = "syncInit.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
