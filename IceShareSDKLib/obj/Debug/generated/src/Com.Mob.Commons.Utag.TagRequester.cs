using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Utag {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='TagRequester']"
	[global::Android.Runtime.Register ("com/mob/commons/utag/TagRequester", DoNotGenerateAcw=true)]
	public sealed partial class TagRequester : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.commons.utag']/interface[@name='TagRequester.UserTagsResponse']"
		[Register ("com/mob/commons/utag/TagRequester$UserTagsResponse", "", "Com.Mob.Commons.Utag.TagRequester/IUserTagsResponseInvoker")]
		public partial interface IUserTagsResponse : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/interface[@name='TagRequester.UserTagsResponse']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("onResponse", "(Ljava/util/Map;)V", "GetOnResponse_Ljava_util_Map_Handler:Com.Mob.Commons.Utag.TagRequester/IUserTagsResponseInvoker, IceShareSDKLib")]
			void OnResponse (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0);

		}

		[global::Android.Runtime.Register ("com/mob/commons/utag/TagRequester$UserTagsResponse", DoNotGenerateAcw=true)]
		internal partial class IUserTagsResponseInvoker : global::Java.Lang.Object, IUserTagsResponse {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/utag/TagRequester$UserTagsResponse", typeof (IUserTagsResponseInvoker));

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

			public static IUserTagsResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUserTagsResponse> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.commons.utag.TagRequester.UserTagsResponse"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUserTagsResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onResponse_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetOnResponse_Ljava_util_Map_Handler ()
			{
				if (cb_onResponse_Ljava_util_Map_ == null)
					cb_onResponse_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Ljava_util_Map_);
				return cb_onResponse_Ljava_util_Map_;
			}

			static void n_OnResponse_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Commons.Utag.TagRequester.IUserTagsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.TagRequester.IUserTagsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResponse_Ljava_util_Map_;
			public unsafe void OnResponse (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				if (id_onResponse_Ljava_util_Map_ == IntPtr.Zero)
					id_onResponse_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/util/Map;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Ljava_util_Map_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/commons/utag/TagRequester", typeof (TagRequester));
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

		internal TagRequester (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='TagRequester']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()V", "")]
		public unsafe void Request ()
		{
			const string __id = "request.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='TagRequester']/method[@name='whenError' and count(parameter)=1 and parameter[1][@type='com.mob.commons.utag.UserTagError']]"
		[Register ("whenError", "(Lcom/mob/commons/utag/UserTagError;)Lcom/mob/commons/utag/TagRequester;", "")]
		public unsafe global::Com.Mob.Commons.Utag.TagRequester WhenError (global::Com.Mob.Commons.Utag.IUserTagError p0)
		{
			const string __id = "whenError.(Lcom/mob/commons/utag/UserTagError;)Lcom/mob/commons/utag/TagRequester;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.TagRequester> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.utag']/class[@name='TagRequester']/method[@name='whenSuccess' and count(parameter)=1 and parameter[1][@type='com.mob.commons.utag.TagRequester.UserTagsResponse']]"
		[Register ("whenSuccess", "(Lcom/mob/commons/utag/TagRequester$UserTagsResponse;)Lcom/mob/commons/utag/TagRequester;", "")]
		public unsafe global::Com.Mob.Commons.Utag.TagRequester WhenSuccess (global::Com.Mob.Commons.Utag.TagRequester.IUserTagsResponse p0)
		{
			const string __id = "whenSuccess.(Lcom/mob/commons/utag/TagRequester$UserTagsResponse;)Lcom/mob/commons/utag/TagRequester;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Commons.Utag.TagRequester> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
