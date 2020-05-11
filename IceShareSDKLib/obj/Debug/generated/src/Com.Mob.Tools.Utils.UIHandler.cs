using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']"
	[global::Android.Runtime.Register ("com/mob/tools/utils/UIHandler", DoNotGenerateAcw=true)]
	public partial class UIHandler : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/utils/UIHandler", typeof (UIHandler));
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

		protected UIHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/constructor[@name='UIHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UIHandler ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/method[@name='sendEmptyMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("sendEmptyMessage", "(ILandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendEmptyMessage (int what, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "sendEmptyMessage.(ILandroid/os/Handler$Callback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/method[@name='sendEmptyMessageAtTime' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendEmptyMessageAtTime", "(IJLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendEmptyMessageAtTime (int what, long uptimeMillis, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "sendEmptyMessageAtTime.(IJLandroid/os/Handler$Callback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue (uptimeMillis);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/method[@name='sendEmptyMessageDelayed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendEmptyMessageDelayed", "(IJLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendEmptyMessageDelayed (int what, long delayMillis, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "sendEmptyMessageDelayed.(IJLandroid/os/Handler$Callback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue (delayMillis);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='android.os.Message'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("sendMessage", "(Landroid/os/Message;Landroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessage (global::Android.OS.Message msg, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "sendMessage.(Landroid/os/Message;Landroid/os/Handler$Callback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/method[@name='sendMessageAtFrontOfQueue' and count(parameter)=2 and parameter[1][@type='android.os.Message'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("sendMessageAtFrontOfQueue", "(Landroid/os/Message;Landroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessageAtFrontOfQueue (global::Android.OS.Message msg, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "sendMessageAtFrontOfQueue.(Landroid/os/Message;Landroid/os/Handler$Callback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/method[@name='sendMessageAtTime' and count(parameter)=3 and parameter[1][@type='android.os.Message'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendMessageAtTime", "(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessageAtTime (global::Android.OS.Message msg, long uptimeMillis, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "sendMessageAtTime.(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				__args [1] = new JniArgumentValue (uptimeMillis);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.utils']/class[@name='UIHandler']/method[@name='sendMessageDelayed' and count(parameter)=3 and parameter[1][@type='android.os.Message'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Handler.Callback']]"
		[Register ("sendMessageDelayed", "(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z", "")]
		public static unsafe bool SendMessageDelayed (global::Android.OS.Message msg, long delayMillis, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "sendMessageDelayed.(Landroid/os/Message;JLandroid/os/Handler$Callback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				__args [1] = new JniArgumentValue (delayMillis);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
