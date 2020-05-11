using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='LocationHelper']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/LocationHelper", DoNotGenerateAcw=true)]
	public partial class LocationHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/LocationHelper", typeof (LocationHelper));
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

		protected LocationHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='LocationHelper']/constructor[@name='LocationHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationHelper ()
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

		static Delegate cb_getLocation_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetLocation_Landroid_content_Context_Handler ()
		{
			if (cb_getLocation_Landroid_content_Context_ == null)
				cb_getLocation_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocation_Landroid_content_Context_);
			return cb_getLocation_Landroid_content_Context_;
		}

		static IntPtr n_GetLocation_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Mob.Tools.Utils.LocationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.LocationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocation (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='LocationHelper']/method[@name='getLocation' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLocation", "(Landroid/content/Context;)Landroid/location/Location;", "GetGetLocation_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Locations.Location GetLocation (global::Android.Content.Context context)
		{
			const string __id = "getLocation.(Landroid/content/Context;)Landroid/location/Location;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLocation_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetGetLocation_Landroid_content_Context_IHandler ()
		{
			if (cb_getLocation_Landroid_content_Context_I == null)
				cb_getLocation_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetLocation_Landroid_content_Context_I);
			return cb_getLocation_Landroid_content_Context_I;
		}

		static IntPtr n_GetLocation_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int GPSTimeoutSec)
		{
			global::Com.Mob.Tools.Utils.LocationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.LocationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocation (context, GPSTimeoutSec));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='LocationHelper']/method[@name='getLocation' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getLocation", "(Landroid/content/Context;I)Landroid/location/Location;", "GetGetLocation_Landroid_content_Context_IHandler")]
		public virtual unsafe global::Android.Locations.Location GetLocation (global::Android.Content.Context context, int GPSTimeoutSec)
		{
			const string __id = "getLocation.(Landroid/content/Context;I)Landroid/location/Location;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (GPSTimeoutSec);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLocation_Landroid_content_Context_II;
#pragma warning disable 0169
		static Delegate GetGetLocation_Landroid_content_Context_IIHandler ()
		{
			if (cb_getLocation_Landroid_content_Context_II == null)
				cb_getLocation_Landroid_content_Context_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetLocation_Landroid_content_Context_II);
			return cb_getLocation_Landroid_content_Context_II;
		}

		static IntPtr n_GetLocation_Landroid_content_Context_II (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int GPSTimeoutSec, int networkTimeoutSec)
		{
			global::Com.Mob.Tools.Utils.LocationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.LocationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocation (context, GPSTimeoutSec, networkTimeoutSec));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='LocationHelper']/method[@name='getLocation' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getLocation", "(Landroid/content/Context;II)Landroid/location/Location;", "GetGetLocation_Landroid_content_Context_IIHandler")]
		public virtual unsafe global::Android.Locations.Location GetLocation (global::Android.Content.Context context, int GPSTimeoutSec, int networkTimeoutSec)
		{
			const string __id = "getLocation.(Landroid/content/Context;II)Landroid/location/Location;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (GPSTimeoutSec);
				__args [2] = new JniArgumentValue (networkTimeoutSec);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLocation_Landroid_content_Context_IIZ;
#pragma warning disable 0169
		static Delegate GetGetLocation_Landroid_content_Context_IIZHandler ()
		{
			if (cb_getLocation_Landroid_content_Context_IIZ == null)
				cb_getLocation_Landroid_content_Context_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, IntPtr>) n_GetLocation_Landroid_content_Context_IIZ);
			return cb_getLocation_Landroid_content_Context_IIZ;
		}

		static IntPtr n_GetLocation_Landroid_content_Context_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int GPSTimeoutSec, int networkTimeoutSec, bool useLastKnown)
		{
			global::Com.Mob.Tools.Utils.LocationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.LocationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocation (context, GPSTimeoutSec, networkTimeoutSec, useLastKnown));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='LocationHelper']/method[@name='getLocation' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("getLocation", "(Landroid/content/Context;IIZ)Landroid/location/Location;", "GetGetLocation_Landroid_content_Context_IIZHandler")]
		public virtual unsafe global::Android.Locations.Location GetLocation (global::Android.Content.Context context, int GPSTimeoutSec, int networkTimeoutSec, bool useLastKnown)
		{
			const string __id = "getLocation.(Landroid/content/Context;IIZ)Landroid/location/Location;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (GPSTimeoutSec);
				__args [2] = new JniArgumentValue (networkTimeoutSec);
				__args [3] = new JniArgumentValue (useLastKnown);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
