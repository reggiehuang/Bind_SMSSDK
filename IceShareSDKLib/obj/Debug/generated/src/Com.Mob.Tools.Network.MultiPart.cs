using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPart']"
	[global::Android.Runtime.Register ("com/mob/tools/network/MultiPart", DoNotGenerateAcw=true)]
	public partial class MultiPart : global::Com.Mob.Tools.Network.HTTPPart {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/network/MultiPart", typeof (MultiPart));
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

		protected MultiPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPart']/constructor[@name='MultiPart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultiPart ()
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
			global::Com.Mob.Tools.Network.MultiPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.MultiPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPart']/method[@name='getInputStream' and count(parameter)=0]"
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

		static Delegate cb_append_Lcom_mob_tools_network_HTTPPart_;
#pragma warning disable 0169
		static Delegate GetAppend_Lcom_mob_tools_network_HTTPPart_Handler ()
		{
			if (cb_append_Lcom_mob_tools_network_HTTPPart_ == null)
				cb_append_Lcom_mob_tools_network_HTTPPart_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_Lcom_mob_tools_network_HTTPPart_);
			return cb_append_Lcom_mob_tools_network_HTTPPart_;
		}

		static IntPtr n_Append_Lcom_mob_tools_network_HTTPPart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_part)
		{
			global::Com.Mob.Tools.Network.MultiPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.MultiPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.HTTPPart part = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (native_part, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (part));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPart']/method[@name='append' and count(parameter)=1 and parameter[1][@type='com.mob.tools.network.HTTPPart']]"
		[Register ("append", "(Lcom/mob/tools/network/HTTPPart;)Lcom/mob/tools/network/MultiPart;", "GetAppend_Lcom_mob_tools_network_HTTPPart_Handler")]
		public virtual unsafe global::Com.Mob.Tools.Network.MultiPart Append (global::Com.Mob.Tools.Network.HTTPPart part)
		{
			const string __id = "append.(Lcom/mob/tools/network/HTTPPart;)Lcom/mob/tools/network/MultiPart;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((part == null) ? IntPtr.Zero : ((global::Java.Lang.Object) part).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.MultiPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Mob.Tools.Network.MultiPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.MultiPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPart']/method[@name='length' and count(parameter)=0]"
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
