using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob']/class[@name='MobUser']"
	[global::Android.Runtime.Register ("com/mob/MobUser", DoNotGenerateAcw=true)]
	public sealed partial class MobUser : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob']/interface[@name='MobUser.OnUserGotListener']"
		[Register ("com/mob/MobUser$OnUserGotListener", "", "Com.Mob.MobUser/IOnUserGotListenerInvoker")]
		public partial interface IOnUserGotListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/interface[@name='MobUser.OnUserGotListener']/method[@name='onUserGot' and count(parameter)=1 and parameter[1][@type='com.mob.MobUser']]"
			[Register ("onUserGot", "(Lcom/mob/MobUser;)V", "GetOnUserGot_Lcom_mob_MobUser_Handler:Com.Mob.MobUser/IOnUserGotListenerInvoker, IceShareSDKLib")]
			void OnUserGot (global::Com.Mob.MobUser p0);

		}

		[global::Android.Runtime.Register ("com/mob/MobUser$OnUserGotListener", DoNotGenerateAcw=true)]
		internal partial class IOnUserGotListenerInvoker : global::Java.Lang.Object, IOnUserGotListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/MobUser$OnUserGotListener", typeof (IOnUserGotListenerInvoker));

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

			public static IOnUserGotListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnUserGotListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.MobUser.OnUserGotListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnUserGotListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onUserGot_Lcom_mob_MobUser_;
#pragma warning disable 0169
			static Delegate GetOnUserGot_Lcom_mob_MobUser_Handler ()
			{
				if (cb_onUserGot_Lcom_mob_MobUser_ == null)
					cb_onUserGot_Lcom_mob_MobUser_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUserGot_Lcom_mob_MobUser_);
				return cb_onUserGot_Lcom_mob_MobUser_;
			}

			static void n_OnUserGot_Lcom_mob_MobUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.MobUser.IOnUserGotListener __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobUser.IOnUserGotListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mob.MobUser p0 = global::Java.Lang.Object.GetObject<global::Com.Mob.MobUser> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUserGot (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUserGot_Lcom_mob_MobUser_;
			public unsafe void OnUserGot (global::Com.Mob.MobUser p0)
			{
				if (id_onUserGot_Lcom_mob_MobUser_ == IntPtr.Zero)
					id_onUserGot_Lcom_mob_MobUser_ = JNIEnv.GetMethodID (class_ref, "onUserGot", "(Lcom/mob/MobUser;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserGot_Lcom_mob_MobUser_, __args);
			}

		}

		// event args for com.mob.MobUser.OnUserGotListener.onUserGot
		public partial class UserGotEventArgs : global::System.EventArgs {

			public UserGotEventArgs (global::Com.Mob.MobUser p0)
			{
				this.p0 = p0;
			}

			global::Com.Mob.MobUser p0;
			public global::Com.Mob.MobUser P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mob/MobUser_OnUserGotListenerImplementor")]
		internal sealed partial class IOnUserGotListenerImplementor : global::Java.Lang.Object, IOnUserGotListener {

			object sender;

			public IOnUserGotListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mob/MobUser_OnUserGotListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<UserGotEventArgs> Handler;
#pragma warning restore 0649

			public void OnUserGot (global::Com.Mob.MobUser p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new UserGotEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnUserGotListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob']/interface[@name='MobUser.UserWatcher']"
		[Register ("com/mob/MobUser$UserWatcher", "", "Com.Mob.MobUser/IUserWatcherInvoker")]
		public partial interface IUserWatcher : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/interface[@name='MobUser.UserWatcher']/method[@name='onUserStateChange' and count(parameter)=1 and parameter[1][@type='com.mob.MobUser']]"
			[Register ("onUserStateChange", "(Lcom/mob/MobUser;)V", "GetOnUserStateChange_Lcom_mob_MobUser_Handler:Com.Mob.MobUser/IUserWatcherInvoker, IceShareSDKLib")]
			void OnUserStateChange (global::Com.Mob.MobUser p0);

		}

		[global::Android.Runtime.Register ("com/mob/MobUser$UserWatcher", DoNotGenerateAcw=true)]
		internal partial class IUserWatcherInvoker : global::Java.Lang.Object, IUserWatcher {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/MobUser$UserWatcher", typeof (IUserWatcherInvoker));

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

			public static IUserWatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUserWatcher> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.MobUser.UserWatcher"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUserWatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onUserStateChange_Lcom_mob_MobUser_;
#pragma warning disable 0169
			static Delegate GetOnUserStateChange_Lcom_mob_MobUser_Handler ()
			{
				if (cb_onUserStateChange_Lcom_mob_MobUser_ == null)
					cb_onUserStateChange_Lcom_mob_MobUser_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUserStateChange_Lcom_mob_MobUser_);
				return cb_onUserStateChange_Lcom_mob_MobUser_;
			}

			static void n_OnUserStateChange_Lcom_mob_MobUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.MobUser.IUserWatcher __this = global::Java.Lang.Object.GetObject<global::Com.Mob.MobUser.IUserWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mob.MobUser p0 = global::Java.Lang.Object.GetObject<global::Com.Mob.MobUser> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUserStateChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUserStateChange_Lcom_mob_MobUser_;
			public unsafe void OnUserStateChange (global::Com.Mob.MobUser p0)
			{
				if (id_onUserStateChange_Lcom_mob_MobUser_ == IntPtr.Zero)
					id_onUserStateChange_Lcom_mob_MobUser_ = JNIEnv.GetMethodID (class_ref, "onUserStateChange", "(Lcom/mob/MobUser;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserStateChange_Lcom_mob_MobUser_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/MobUser", typeof (MobUser));
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

		internal MobUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Avatar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobUser']/method[@name='getAvatar' and count(parameter)=0]"
			[Register ("getAvatar", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAvatar.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobUser']/method[@name='getExtraInfo' and count(parameter)=0]"
			[Register ("getExtraInfo", "()Ljava/util/HashMap;", "")]
			get {
				const string __id = "getExtraInfo.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobUser']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsAnonymous {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobUser']/method[@name='isAnonymous' and count(parameter)=0]"
			[Register ("isAnonymous", "()Z", "")]
			get {
				const string __id = "isAnonymous.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string MobUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobUser']/method[@name='getMobUserId' and count(parameter)=0]"
			[Register ("getMobUserId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMobUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string NickName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob']/class[@name='MobUser']/method[@name='getNickName' and count(parameter)=0]"
			[Register ("getNickName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getNickName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
