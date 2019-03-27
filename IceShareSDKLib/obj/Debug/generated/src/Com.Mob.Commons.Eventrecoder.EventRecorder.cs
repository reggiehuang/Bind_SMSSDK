using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Commons.Eventrecoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.commons.eventrecoder']/class[@name='EventRecorder']"
	[global::Android.Runtime.Register ("com/mob/commons/eventrecoder/EventRecorder", DoNotGenerateAcw=true)]
	public sealed partial class EventRecorder : global::Java.Lang.Object, global::Com.Mob.Tools.Proguard.IPublicMemberKeeper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/commons/eventrecoder/EventRecorder", typeof (EventRecorder));
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

		internal EventRecorder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.commons.eventrecoder']/class[@name='EventRecorder']/constructor[@name='EventRecorder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventRecorder ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.eventrecoder']/class[@name='EventRecorder']/method[@name='addBegin' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addBegin", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddBegin (string p0, string p1)
		{
			const string __id = "addBegin.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.eventrecoder']/class[@name='EventRecorder']/method[@name='addEnd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addEnd", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddEnd (string p0, string p1)
		{
			const string __id = "addEnd.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.eventrecoder']/class[@name='EventRecorder']/method[@name='checkRecord' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkRecord", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CheckRecord (string p0)
		{
			const string __id = "checkRecord.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.eventrecoder']/class[@name='EventRecorder']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public static unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.commons.eventrecoder']/class[@name='EventRecorder']/method[@name='prepare' and count(parameter)=0]"
		[Register ("prepare", "()V", "")]
		public static unsafe void Prepare ()
		{
			const string __id = "prepare.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
