using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='MobRSA']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/MobRSA", DoNotGenerateAcw=true)]
	public partial class MobRSA : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/MobRSA", typeof (MobRSA));
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

		protected MobRSA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='MobRSA']/constructor[@name='MobRSA' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MobRSA (int keySize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (keySize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_decode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetDecode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_Handler ()
		{
			if (cb_decode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_ == null)
				cb_decode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_);
			return cb_decode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_;
		}

		static IntPtr n_Decode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_key, IntPtr native_modulus)
		{
			global::Com.Mob.Tools.Utils.MobRSA __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.MobRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] source = (byte[]) JNIEnv.GetArray (native_source, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Math.BigInteger key = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger modulus = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_modulus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (source, key, modulus));
			if (source != null)
				JNIEnv.CopyArray (source, native_source);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='MobRSA']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.math.BigInteger'] and parameter[3][@type='java.math.BigInteger']]"
		[Register ("decode", "([BLjava/math/BigInteger;Ljava/math/BigInteger;)[B", "GetDecode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_Handler")]
		public virtual unsafe byte[] Decode (byte[] source, global::Java.Math.BigInteger key, global::Java.Math.BigInteger modulus)
		{
			const string __id = "decode.([BLjava/math/BigInteger;Ljava/math/BigInteger;)[B";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [2] = new JniArgumentValue ((modulus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) modulus).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		static Delegate cb_encode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetEncode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_Handler ()
		{
			if (cb_encode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_ == null)
				cb_encode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_);
			return cb_encode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_;
		}

		static IntPtr n_Encode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_key, IntPtr native_modulus)
		{
			global::Com.Mob.Tools.Utils.MobRSA __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.MobRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] source = (byte[]) JNIEnv.GetArray (native_source, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Math.BigInteger key = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger modulus = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_modulus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (source, key, modulus));
			if (source != null)
				JNIEnv.CopyArray (source, native_source);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='MobRSA']/method[@name='encode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.math.BigInteger'] and parameter[3][@type='java.math.BigInteger']]"
		[Register ("encode", "([BLjava/math/BigInteger;Ljava/math/BigInteger;)[B", "GetEncode_arrayBLjava_math_BigInteger_Ljava_math_BigInteger_Handler")]
		public virtual unsafe byte[] Encode (byte[] source, global::Java.Math.BigInteger key, global::Java.Math.BigInteger modulus)
		{
			const string __id = "encode.([BLjava/math/BigInteger;Ljava/math/BigInteger;)[B";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [2] = new JniArgumentValue ((modulus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) modulus).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		static Delegate cb_genKeys;
#pragma warning disable 0169
		static Delegate GetGenKeysHandler ()
		{
			if (cb_genKeys == null)
				cb_genKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenKeys);
			return cb_genKeys;
		}

		static IntPtr n_GenKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Utils.MobRSA __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.MobRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GenKeys ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='MobRSA']/method[@name='genKeys' and count(parameter)=0]"
		[Register ("genKeys", "()[Ljava/math/BigInteger;", "GetGenKeysHandler")]
		public virtual unsafe global::Java.Math.BigInteger[] GenKeys ()
		{
			const string __id = "genKeys.()[Ljava/math/BigInteger;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Math.BigInteger[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Math.BigInteger));
			} finally {
			}
		}

		static Delegate cb_genKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetGenKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_Handler ()
		{
			if (cb_genKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_ == null)
				cb_genKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_);
			return cb_genKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_;
		}

		static IntPtr n_GenKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p, IntPtr native_q, IntPtr native_e)
		{
			global::Com.Mob.Tools.Utils.MobRSA __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Utils.MobRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger p = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_p, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger q = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_q, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger e = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GenKeys (p, q, e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='MobRSA']/method[@name='genKeys' and count(parameter)=3 and parameter[1][@type='java.math.BigInteger'] and parameter[2][@type='java.math.BigInteger'] and parameter[3][@type='java.math.BigInteger']]"
		[Register ("genKeys", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)[Ljava/math/BigInteger;", "GetGenKeys_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_Handler")]
		public virtual unsafe global::Java.Math.BigInteger[] GenKeys (global::Java.Math.BigInteger p, global::Java.Math.BigInteger q, global::Java.Math.BigInteger e)
		{
			const string __id = "genKeys.(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)[Ljava/math/BigInteger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue ((q == null) ? IntPtr.Zero : ((global::Java.Lang.Object) q).Handle);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Math.BigInteger[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Math.BigInteger));
			} finally {
			}
		}

	}
}
