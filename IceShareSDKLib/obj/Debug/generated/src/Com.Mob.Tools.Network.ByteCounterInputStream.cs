using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteCounterInputStream']"
	[global::Android.Runtime.Register ("com/mob/tools/network/ByteCounterInputStream", DoNotGenerateAcw=true)]
	public partial class ByteCounterInputStream : global::Java.IO.InputStream {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/network/ByteCounterInputStream", typeof (ByteCounterInputStream));
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

		protected ByteCounterInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteCounterInputStream']/constructor[@name='ByteCounterInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe ByteCounterInputStream (global::System.IO.Stream @is)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__is);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Network.ByteCounterInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.ByteCounterInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteCounterInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			const string __id = "read.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_Handler ()
		{
			if (cb_setOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_ == null)
				cb_setOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_);
			return cb_setOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_;
		}

		static void n_SetOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::Com.Mob.Tools.Network.ByteCounterInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.ByteCounterInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Network.IOnReadListener l = (global::Com.Mob.Tools.Network.IOnReadListener)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.IOnReadListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInputStreamReadListener (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='ByteCounterInputStream']/method[@name='setOnInputStreamReadListener' and count(parameter)=1 and parameter[1][@type='com.mob.tools.network.OnReadListener']]"
		[Register ("setOnInputStreamReadListener", "(Lcom/mob/tools/network/OnReadListener;)V", "GetSetOnInputStreamReadListener_Lcom_mob_tools_network_OnReadListener_Handler")]
		public virtual unsafe void SetOnInputStreamReadListener (global::Com.Mob.Tools.Network.IOnReadListener l)
		{
			const string __id = "setOnInputStreamReadListener.(Lcom/mob/tools/network/OnReadListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mob.Tools.Network.IOnReadListener"
		public event EventHandler<global::Com.Mob.Tools.Network.ReadEventArgs> InputStreamRead {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mob.Tools.Network.IOnReadListener, global::Com.Mob.Tools.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnInputStreamReadListener,
						__CreateIOnReadListenerImplementor,
						SetOnInputStreamReadListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mob.Tools.Network.IOnReadListener, global::Com.Mob.Tools.Network.IOnReadListenerImplementor>(
						ref weak_implementor_SetOnInputStreamReadListener,
						global::Com.Mob.Tools.Network.IOnReadListenerImplementor.__IsEmpty,
						__v => SetOnInputStreamReadListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInputStreamReadListener;

		global::Com.Mob.Tools.Network.IOnReadListenerImplementor __CreateIOnReadListenerImplementor ()
		{
			return new global::Com.Mob.Tools.Network.IOnReadListenerImplementor (this);
		}
#endregion
	}
}
