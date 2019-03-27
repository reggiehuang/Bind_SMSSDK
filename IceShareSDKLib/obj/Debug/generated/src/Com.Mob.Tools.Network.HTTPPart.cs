using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']"
	[global::Android.Runtime.Register ("com/mob/tools/network/HTTPPart", DoNotGenerateAcw=true)]
	public abstract partial class HTTPPart : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/HTTPPart", typeof (HTTPPart));
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

		protected HTTPPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/constructor[@name='HTTPPart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HTTPPart ()
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
			global::Com.Mob.Tools.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		protected abstract global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")] get;
		}

		static Delegate cb_getInputStreamEntity;
#pragma warning disable 0169
		static Delegate GetGetInputStreamEntityHandler ()
		{
			if (cb_getInputStreamEntity == null)
				cb_getInputStreamEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStreamEntity);
			return cb_getInputStreamEntity;
		}

		static IntPtr n_GetInputStreamEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputStreamEntity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object InputStreamEntity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='getInputStreamEntity' and count(parameter)=0]"
			[Register ("getInputStreamEntity", "()Ljava/lang/Object;", "GetGetInputStreamEntityHandler")]
			get {
				const string __id = "getInputStreamEntity.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Mob.Tools.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		protected abstract long Length ();

		static Delegate cb_setOffset_J;
#pragma warning disable 0169
		static Delegate GetSetOffset_JHandler ()
		{
			if (cb_setOffset_J == null)
				cb_setOffset_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetOffset_J);
			return cb_setOffset_J;
		}

		static void n_SetOffset_J (IntPtr jnienv, IntPtr native__this, long offset)
		{
			global::Com.Mob.Tools.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffset (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setOffset", "(J)V", "GetSetOffset_JHandler")]
		public virtual unsafe void SetOffset (long offset)
		{
			const string __id = "setOffset.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnReadListener_Lcom_mob_tools_network_OnReadListener_;
#pragma warning disable 0169
		static Delegate GetSetOnReadListener_Lcom_mob_tools_network_OnReadListener_Handler ()
		{
			if (cb_setOnReadListener_Lcom_mob_tools_network_OnReadListener_ == null)
				cb_setOnReadListener_Lcom_mob_tools_network_OnReadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnReadListener_Lcom_mob_tools_network_OnReadListener_);
			return cb_setOnReadListener_Lcom_mob_tools_network_OnReadListener_;
		}

		static void n_SetOnReadListener_Lcom_mob_tools_network_OnReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::Com.Mob.Tools.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IOnReadListener l = (global::Com.Mob.Tools.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IOnReadListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.SetOnReadListener (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='setOnReadListener' and count(parameter)=1 and parameter[1][@type='com.mob.tools.network.OnReadListener']]"
		[Register ("setOnReadListener", "(Lcom/mob/tools/network/OnReadListener;)V", "GetSetOnReadListener_Lcom_mob_tools_network_OnReadListener_Handler")]
		public virtual unsafe void SetOnReadListener (global::Com.Mob.Tools.Network.IOnReadListener l)
		{
			const string __id = "setOnReadListener.(Lcom/mob/tools/network/OnReadListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_toInputStream;
#pragma warning disable 0169
		static Delegate GetToInputStreamHandler ()
		{
			if (cb_toInputStream == null)
				cb_toInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToInputStream);
			return cb_toInputStream;
		}

		static IntPtr n_ToInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.HTTPPart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.HTTPPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ToInputStream ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='toInputStream' and count(parameter)=0]"
		[Register ("toInputStream", "()Ljava/io/InputStream;", "GetToInputStreamHandler")]
		public virtual unsafe global::System.IO.Stream ToInputStream ()
		{
			const string __id = "toInputStream.()Ljava/io/InputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

#region "Event implementation for Com.Mob.Tools.Network.IOnReadListener"
		public event EventHandler<global::Com.Mob.Tools.Network.ReadEventArgs> Read {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mob.Tools.Network.IOnReadListener, global::Com.Mob.Tools.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnReadListener,
						__CreateIOnReadListenerImplementor,
						SetOnReadListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mob.Tools.Network.IOnReadListener, global::Com.Mob.Tools.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnReadListener,
						global::Com.Mob.Tools.Network.IOnReadListenerImplementor.__IsEmpty,
						__v => SetOnReadListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnReadListener;

		global::Com.Mob.Tools.Network.IOnReadListenerImplementor __CreateIOnReadListenerImplementor ()
		{
			return new global::Com.Mob.Tools.Network.IOnReadListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/mob/tools/network/HTTPPart", DoNotGenerateAcw=true)]
	internal partial class HTTPPartInvoker : HTTPPart {

		public HTTPPartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/network/HTTPPart", typeof (HTTPPartInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='HTTPPart']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		protected override unsafe long Length ()
		{
			const string __id = "length.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

}
