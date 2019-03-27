using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sina.Sso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']"
	[global::Android.Runtime.Register ("com/sina/sso/RemoteSSO$Stub", DoNotGenerateAcw=true)]
	public abstract partial class RemoteSSOStub : global::Android.OS.Binder, global::Com.Sina.Sso.IRemoteSSO {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/sina/sso/RemoteSSO$Stub", typeof (RemoteSSOStub));
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

		protected RemoteSSOStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/constructor[@name='RemoteSSO.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RemoteSSOStub ()
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Sso.RemoteSSOStub __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.RemoteSSOStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/sina/sso/RemoteSSO;", "")]
		public static unsafe global::Com.Sina.Sso.IRemoteSSO AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/sina/sso/RemoteSSO;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.IRemoteSSO> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Com.Sina.Sso.RemoteSSOStub __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.RemoteSSOStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getActivityName;
#pragma warning disable 0169
		static Delegate GetGetActivityNameHandler ()
		{
			if (cb_getActivityName == null)
				cb_getActivityName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivityName);
			return cb_getActivityName;
		}

		static IntPtr n_GetActivityName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Sso.RemoteSSOStub __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.RemoteSSOStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActivityName);
		}
#pragma warning restore 0169

		public abstract string ActivityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/method[@name='getActivityName' and count(parameter)=0]"
			[Register ("getActivityName", "()Ljava/lang/String;", "GetGetActivityNameHandler")] get;
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Sso.RemoteSSOStub __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.RemoteSSOStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public abstract string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/sina/sso/RemoteSSO$Stub", DoNotGenerateAcw=true)]
	internal partial class RemoteSSOStubInvoker : RemoteSSOStub {

		public RemoteSSOStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/sina/sso/RemoteSSO$Stub", typeof (RemoteSSOStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string ActivityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/method[@name='getActivityName' and count(parameter)=0]"
			[Register ("getActivityName", "()Ljava/lang/String;", "GetGetActivityNameHandler")]
			get {
				const string __id = "getActivityName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/class[@name='RemoteSSO.Stub']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sina.sso']/interface[@name='RemoteSSO']"
	[Register ("com/sina/sso/RemoteSSO", "", "Com.Sina.Sso.IRemoteSSOInvoker")]
	public partial interface IRemoteSSO : global::Android.OS.IInterface {

		string ActivityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/interface[@name='RemoteSSO']/method[@name='getActivityName' and count(parameter)=0]"
			[Register ("getActivityName", "()Ljava/lang/String;", "GetGetActivityNameHandler:Com.Sina.Sso.IRemoteSSOInvoker, IceShareSDKLib")] get;
		}

		string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.sso']/interface[@name='RemoteSSO']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler:Com.Sina.Sso.IRemoteSSOInvoker, IceShareSDKLib")] get;
		}

	}

	[global::Android.Runtime.Register ("com/sina/sso/RemoteSSO", DoNotGenerateAcw=true)]
	internal class IRemoteSSOInvoker : global::Java.Lang.Object, IRemoteSSO {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/sina/sso/RemoteSSO", typeof (IRemoteSSOInvoker));

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

		public static IRemoteSSO GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteSSO> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.sina.sso.RemoteSSO"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteSSOInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getActivityName;
#pragma warning disable 0169
		static Delegate GetGetActivityNameHandler ()
		{
			if (cb_getActivityName == null)
				cb_getActivityName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivityName);
			return cb_getActivityName;
		}

		static IntPtr n_GetActivityName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Sso.IRemoteSSO __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.IRemoteSSO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActivityName);
		}
#pragma warning restore 0169

		IntPtr id_getActivityName;
		public unsafe string ActivityName {
			get {
				if (id_getActivityName == IntPtr.Zero)
					id_getActivityName = JNIEnv.GetMethodID (class_ref, "getActivityName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivityName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Sso.IRemoteSSO __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.IRemoteSSO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		IntPtr id_getPackageName;
		public unsafe string PackageName {
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Sso.IRemoteSSO __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Sso.IRemoteSSO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
