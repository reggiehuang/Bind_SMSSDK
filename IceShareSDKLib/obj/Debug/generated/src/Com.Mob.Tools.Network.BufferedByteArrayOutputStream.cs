using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']"
	[global::Android.Runtime.Register ("com/mob/tools/network/BufferedByteArrayOutputStream", DoNotGenerateAcw=true)]
	public partial class BufferedByteArrayOutputStream : global::Java.IO.ByteArrayOutputStream {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/network/BufferedByteArrayOutputStream", typeof (BufferedByteArrayOutputStream));
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

		protected BufferedByteArrayOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']/constructor[@name='BufferedByteArrayOutputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BufferedByteArrayOutputStream ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']/constructor[@name='BufferedByteArrayOutputStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BufferedByteArrayOutputStream (int size)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBufferSize;
#pragma warning disable 0169
		static Delegate GetGetBufferSizeHandler ()
		{
			if (cb_getBufferSize == null)
				cb_getBufferSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufferSize);
			return cb_getBufferSize;
		}

		static int n_GetBufferSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferSize;
		}
#pragma warning restore 0169

		public virtual unsafe int BufferSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='getBufferSize' and count(parameter)=0]"
			[Register ("getBufferSize", "()I", "GetGetBufferSizeHandler")]
			get {
				const string __id = "getBufferSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='getBuffer' and count(parameter)=0]"
		[Register ("getBuffer", "()[B", "GetGetBufferHandler")]
		public virtual unsafe byte[] GetBuffer ()
		{
			const string __id = "getBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_switchBuffer_arrayB;
#pragma warning disable 0169
		static Delegate GetSwitchBuffer_arrayBHandler ()
		{
			if (cb_switchBuffer_arrayB == null)
				cb_switchBuffer_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SwitchBuffer_arrayB);
			return cb_switchBuffer_arrayB;
		}

		static bool n_SwitchBuffer_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_newBuf)
		{
			global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] newBuf = (byte[]) JNIEnv.GetArray (native_newBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SwitchBuffer (newBuf);
			if (newBuf != null)
				JNIEnv.CopyArray (newBuf, native_newBuf);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='switchBuffer' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("switchBuffer", "([B)Z", "GetSwitchBuffer_arrayBHandler")]
		public virtual unsafe bool SwitchBuffer (byte[] newBuf)
		{
			const string __id = "switchBuffer.([B)Z";
			IntPtr native_newBuf = JNIEnv.NewArray (newBuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newBuf);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (newBuf != null) {
					JNIEnv.CopyArray (native_newBuf, newBuf);
					JNIEnv.DeleteLocalRef (native_newBuf);
				}
			}
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static void n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.Write (buffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer buffer)
		{
			const string __id = "write.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_I;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_IHandler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_I == null)
				cb_write_Ljava_nio_ByteBuffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_nio_ByteBuffer_I);
			return cb_write_Ljava_nio_ByteBuffer_I;
		}

		static void n_Write_Ljava_nio_ByteBuffer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int size)
		{
			global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.BufferedByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.Write (buffer, size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='BufferedByteArrayOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;I)V", "GetWrite_Ljava_nio_ByteBuffer_IHandler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer buffer, int size)
		{
			const string __id = "write.(Ljava/nio/ByteBuffer;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
