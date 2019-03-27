using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPartInputStream']"
	[global::Android.Runtime.Register ("com/mob/tools/network/MultiPartInputStream", DoNotGenerateAcw=true)]
	public partial class MultiPartInputStream : global::Java.IO.InputStream {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/network/MultiPartInputStream", typeof (MultiPartInputStream));
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

		protected MultiPartInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addInputStream_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetAddInputStream_Ljava_io_InputStream_Handler ()
		{
			if (cb_addInputStream_Ljava_io_InputStream_ == null)
				cb_addInputStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddInputStream_Ljava_io_InputStream_);
			return cb_addInputStream_Ljava_io_InputStream_;
		}

		static void n_AddInputStream_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			global::Com.Mob.Tools.Network.MultiPartInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.MultiPartInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			__this.AddInputStream (@is);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPartInputStream']/method[@name='addInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("addInputStream", "(Ljava/io/InputStream;)V", "GetAddInputStream_Ljava_io_InputStream_Handler")]
		public virtual unsafe void AddInputStream (global::System.IO.Stream @is)
		{
			const string __id = "addInputStream.(Ljava/io/InputStream;)V";
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__is);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Mob.Tools.Network.MultiPartInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.MultiPartInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='MultiPartInputStream']/method[@name='read' and count(parameter)=0]"
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

	}
}
