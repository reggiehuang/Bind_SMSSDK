using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FilePart']"
	[global::Android.Runtime.Register ("com/mob/tools/network/FilePart", DoNotGenerateAcw=true)]
	public partial class FilePart : global::Com.Mob.Tools.Network.HTTPPart {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/network/FilePart", typeof (FilePart));
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

		protected FilePart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FilePart']/constructor[@name='FilePart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FilePart ()
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
			global::Com.Mob.Tools.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FilePart']/method[@name='getInputStream' and count(parameter)=0]"
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
			global::Com.Mob.Tools.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FilePart']/method[@name='length' and count(parameter)=0]"
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

		static Delegate cb_setFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetFile_Ljava_io_File_Handler ()
		{
			if (cb_setFile_Ljava_io_File_ == null)
				cb_setFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFile_Ljava_io_File_);
			return cb_setFile_Ljava_io_File_;
		}

		static void n_SetFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			global::Com.Mob.Tools.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File file = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_file, JniHandleOwnership.DoNotTransfer);
			__this.SetFile (file);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FilePart']/method[@name='setFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setFile", "(Ljava/io/File;)V", "GetSetFile_Ljava_io_File_Handler")]
		public virtual unsafe void SetFile (global::Java.IO.File file)
		{
			const string __id = "setFile.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFile_Ljava_lang_String_Handler ()
		{
			if (cb_setFile_Ljava_lang_String_ == null)
				cb_setFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFile_Ljava_lang_String_);
			return cb_setFile_Ljava_lang_String_;
		}

		static void n_SetFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Mob.Tools.Network.FilePart __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Network.FilePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.SetFile (path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.network']/class[@name='FilePart']/method[@name='setFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFile", "(Ljava/lang/String;)V", "GetSetFile_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFile (string path)
		{
			const string __id = "setFile.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

	}
}
