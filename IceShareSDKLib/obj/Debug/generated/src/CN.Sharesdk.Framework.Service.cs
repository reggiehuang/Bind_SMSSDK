using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Sharesdk.Framework {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']"
	[global::Android.Runtime.Register ("cn/sharesdk/framework/Service", DoNotGenerateAcw=true)]
	public abstract partial class Service : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service.ServiceEvent']"
		[global::Android.Runtime.Register ("cn/sharesdk/framework/Service$ServiceEvent", DoNotGenerateAcw=true)]
		public abstract partial class ServiceEvent : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service.ServiceEvent']/field[@name='service']"
			[Register ("service")]
			protected global::CN.Sharesdk.Framework.Service Service {
				get {
					const string __id = "service.Lcn/sharesdk/framework/Service;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "service.Lcn/sharesdk/framework/Service;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/Service$ServiceEvent", typeof (ServiceEvent));
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

			protected ServiceEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service.ServiceEvent']/constructor[@name='Service.ServiceEvent' and count(parameter)=1 and parameter[1][@type='cn.sharesdk.framework.Service']]"
			[Register (".ctor", "(Lcn/sharesdk/framework/Service;)V", "")]
			public unsafe ServiceEvent (global::CN.Sharesdk.Framework.Service service)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcn/sharesdk/framework/Service;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_filterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_;
#pragma warning disable 0169
			static Delegate GetFilterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_Handler ()
			{
				if (cb_filterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_ == null)
					cb_filterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_FilterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_);
				return cb_filterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_;
			}

			static IntPtr n_FilterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, int platformId, IntPtr native__params, IntPtr native_result)
			{
				global::CN.Sharesdk.Framework.Service.ServiceEvent __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service.ServiceEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::CN.Sharesdk.Framework.Platform.ShareParams @params = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Platform.ShareParams> (native__params, JniHandleOwnership.DoNotTransfer);
				var result = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_result, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.FilterShareContent (platformId, @params, result));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service.ServiceEvent']/method[@name='filterShareContent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='cn.sharesdk.framework.Platform.ShareParams'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("filterShareContent", "(ILcn/sharesdk/framework/Platform$ShareParams;Ljava/util/HashMap;)Ljava/util/HashMap;", "GetFilterShareContent_ILcn_sharesdk_framework_Platform_ShareParams_Ljava_util_HashMap_Handler")]
			protected virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> FilterShareContent (int platformId, global::CN.Sharesdk.Framework.Platform.ShareParams @params, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> result)
			{
				const string __id = "filterShareContent.(ILcn/sharesdk/framework/Platform$ShareParams;Ljava/util/HashMap;)Ljava/util/HashMap;";
				IntPtr native_result = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (result);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (platformId);
					__args [1] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
					__args [2] = new JniArgumentValue (native_result);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_result);
				}
			}

			static Delegate cb_toMap;
#pragma warning disable 0169
			static Delegate GetToMapHandler ()
			{
				if (cb_toMap == null)
					cb_toMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToMap);
				return cb_toMap;
			}

			static IntPtr n_ToMap (IntPtr jnienv, IntPtr native__this)
			{
				global::CN.Sharesdk.Framework.Service.ServiceEvent __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service.ServiceEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ToMap ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service.ServiceEvent']/method[@name='toMap' and count(parameter)=0]"
			[Register ("toMap", "()Ljava/util/HashMap;", "GetToMapHandler")]
			protected virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToMap ()
			{
				const string __id = "toMap.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service.ServiceEvent']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed unsafe string ToString ()
			{
				const string __id = "toString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("cn/sharesdk/framework/Service$ServiceEvent", DoNotGenerateAcw=true)]
		internal partial class ServiceEventInvoker : ServiceEvent {

			public ServiceEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/Service$ServiceEvent", typeof (ServiceEventInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/Service", typeof (Service));
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

		protected Service (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/constructor[@name='Service' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Service ()
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

		static Delegate cb_getDeviceKey;
#pragma warning disable 0169
		static Delegate GetGetDeviceKeyHandler ()
		{
			if (cb_getDeviceKey == null)
				cb_getDeviceKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceKey);
			return cb_getDeviceKey;
		}

		static IntPtr n_GetDeviceKey (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Service __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceKey);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/method[@name='getDeviceKey' and count(parameter)=0]"
			[Register ("getDeviceKey", "()Ljava/lang/String;", "GetGetDeviceKeyHandler")]
			get {
				const string __id = "getDeviceKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceVersionInt;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionIntHandler ()
		{
			if (cb_getServiceVersionInt == null)
				cb_getServiceVersionInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetServiceVersionInt);
			return cb_getServiceVersionInt;
		}

		static int n_GetServiceVersionInt (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Service __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServiceVersionInt;
		}
#pragma warning restore 0169

		protected abstract int ServiceVersionInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/method[@name='getServiceVersionInt' and count(parameter)=0]"
			[Register ("getServiceVersionInt", "()I", "GetGetServiceVersionIntHandler")] get;
		}

		static Delegate cb_getServiceVersionName;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionNameHandler ()
		{
			if (cb_getServiceVersionName == null)
				cb_getServiceVersionName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceVersionName);
			return cb_getServiceVersionName;
		}

		static IntPtr n_GetServiceVersionName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Service __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceVersionName);
		}
#pragma warning restore 0169

		public abstract string ServiceVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/method[@name='getServiceVersionName' and count(parameter)=0]"
			[Register ("getServiceVersionName", "()Ljava/lang/String;", "GetGetServiceVersionNameHandler")] get;
		}

		static Delegate cb_onBind;
#pragma warning disable 0169
		static Delegate GetOnBindHandler ()
		{
			if (cb_onBind == null)
				cb_onBind = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBind);
			return cb_onBind;
		}

		static void n_OnBind (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Service __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBind ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/method[@name='onBind' and count(parameter)=0]"
		[Register ("onBind", "()V", "GetOnBindHandler")]
		public virtual unsafe void OnBind ()
		{
			const string __id = "onBind.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onUnbind;
#pragma warning disable 0169
		static Delegate GetOnUnbindHandler ()
		{
			if (cb_onUnbind == null)
				cb_onUnbind = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnbind);
			return cb_onUnbind;
		}

		static void n_OnUnbind (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Sharesdk.Framework.Service __this = global::Java.Lang.Object.GetObject<global::CN.Sharesdk.Framework.Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbind ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/method[@name='onUnbind' and count(parameter)=0]"
		[Register ("onUnbind", "()V", "GetOnUnbindHandler")]
		public virtual unsafe void OnUnbind ()
		{
			const string __id = "onUnbind.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/sharesdk/framework/Service", DoNotGenerateAcw=true)]
	internal partial class ServiceInvoker : Service {

		public ServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("cn/sharesdk/framework/Service", typeof (ServiceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe int ServiceVersionInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/method[@name='getServiceVersionInt' and count(parameter)=0]"
			[Register ("getServiceVersionInt", "()I", "GetGetServiceVersionIntHandler")]
			get {
				const string __id = "getServiceVersionInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string ServiceVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.sharesdk.framework']/class[@name='Service']/method[@name='getServiceVersionName' and count(parameter)=0]"
			[Register ("getServiceVersionName", "()Ljava/lang/String;", "GetGetServiceVersionNameHandler")]
			get {
				const string __id = "getServiceVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
