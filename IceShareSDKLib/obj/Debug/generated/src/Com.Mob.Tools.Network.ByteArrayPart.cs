using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteArrayPart']"
	[global::Android.Runtime.Register ("com/mob/tools/network/ByteArrayPart", DoNotGenerateAcw=true)]
	public partial class ByteArrayPart : global::Com.Mob.Tools.Network.HTTPPart {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/network/ByteArrayPart", typeof (ByteArrayPart));
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

		protected ByteArrayPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteArrayPart']/constructor[@name='ByteArrayPart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteArrayPart ()
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

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.ByteArrayPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.ByteArrayPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteArrayPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_append_arrayB;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBHandler ()
		{
			if (cb_append_arrayB == null)
				cb_append_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_arrayB);
			return cb_append_arrayB;
		}

		static IntPtr n_Append_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			global::Com.Mob.Tools.Network.ByteArrayPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.ByteArrayPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteArrayPart']/method[@name='append' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("append", "([B)Lcom/mob/tools/network/ByteArrayPart;", "GetAppend_arrayBHandler")]
		public virtual unsafe global::Com.Mob.Tools.Network.ByteArrayPart Append (byte[] array)
		{
			const string __id = "append.([B)Lcom/mob/tools/network/ByteArrayPart;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.ByteArrayPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Length);
			return cb_length;
		}

		static long n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.ByteArrayPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.ByteArrayPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteArrayPart']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		protected override unsafe long Length ()
		{
			const string __id = "length.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
