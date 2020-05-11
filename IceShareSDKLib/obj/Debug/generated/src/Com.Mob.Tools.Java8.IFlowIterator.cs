using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ArrayIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$ArrayIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class FlowIteratorArrayIterator : global::Java.Lang.Object, global::Com.Mob.Tools.Java8.IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$ArrayIterator", typeof (FlowIteratorArrayIterator));
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

		protected FlowIteratorArrayIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ArrayIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ArrayIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ArrayIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.BufferedReaderIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$BufferedReaderIterator", DoNotGenerateAcw=true)]
	public partial class FlowIteratorBufferedReaderIterator : global::Java.Lang.Object, global::Com.Mob.Tools.Java8.IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$BufferedReaderIterator", typeof (FlowIteratorBufferedReaderIterator));
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

		protected FlowIteratorBufferedReaderIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorBufferedReaderIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorBufferedReaderIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.BufferedReaderIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorBufferedReaderIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorBufferedReaderIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.BufferedReaderIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorBufferedReaderIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorBufferedReaderIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.BufferedReaderIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/String;", "GetNextHandler")]
		public virtual unsafe string Next ()
		{
			const string __id = "next.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mob.Tools.Java8.IFlowIterator
		global::Java.Lang.Object global::Com.Mob.Tools.Java8.IFlowIterator.Next ()
		{
			return Next ().ToString ();
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.EnumerationIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$EnumerationIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class FlowIteratorEnumerationIterator : global::Java.Lang.Object, global::Com.Mob.Tools.Java8.IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$EnumerationIterator", typeof (FlowIteratorEnumerationIterator));
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

		protected FlowIteratorEnumerationIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorEnumerationIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorEnumerationIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.EnumerationIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorEnumerationIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorEnumerationIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.EnumerationIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorEnumerationIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorEnumerationIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.EnumerationIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.FileReaderIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$FileReaderIterator", DoNotGenerateAcw=true)]
	public partial class FlowIteratorFileReaderIterator : global::Java.Lang.Object, global::Com.Mob.Tools.Java8.IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$FileReaderIterator", typeof (FlowIteratorFileReaderIterator));
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

		protected FlowIteratorFileReaderIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorFileReaderIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorFileReaderIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.FileReaderIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorFileReaderIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorFileReaderIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.FileReaderIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorFileReaderIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorFileReaderIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.FileReaderIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/String;", "GetNextHandler")]
		public virtual unsafe string Next ()
		{
			const string __id = "next.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mob.Tools.Java8.IFlowIterator
		global::Java.Lang.Object global::Com.Mob.Tools.Java8.IFlowIterator.Next ()
		{
			return Next ().ToString ();
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IterableIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$IterableIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class FlowIteratorIterableIterator : global::Java.Lang.Object, global::Com.Mob.Tools.Java8.IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$IterableIterator", typeof (FlowIteratorIterableIterator));
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

		protected FlowIteratorIterableIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorIterableIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorIterableIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IterableIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorIterableIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorIterableIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IterableIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorIterableIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorIterableIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IterableIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.MapIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$MapIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial class FlowIteratorMapIterator : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$MapIterator", typeof (FlowIteratorMapIterator));
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

		protected FlowIteratorMapIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorMapIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorMapIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.MapIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorMapIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorMapIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.MapIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorMapIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorMapIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.MapIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$PrimitiveArrayIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public abstract partial class FlowIteratorPrimitiveArrayIterator : global::Java.Lang.Object, global::Com.Mob.Tools.Java8.IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$PrimitiveArrayIterator", typeof (FlowIteratorPrimitiveArrayIterator));
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

		protected FlowIteratorPrimitiveArrayIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/constructor[@name='FlowIterator.PrimitiveArrayIterator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlowIteratorPrimitiveArrayIterator ()
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

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_element_I;
#pragma warning disable 0169
		static Delegate GetElement_IHandler ()
		{
			if (cb_element_I == null)
				cb_element_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Element_I);
			return cb_element_I;
		}

		static IntPtr n_Element_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Element (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("element", "(I)Ljava/lang/Object;", "GetElement_IHandler")]
		protected abstract global::Java.Lang.Object Element (int p0);

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		protected abstract int Length ();

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$PrimitiveArrayIterator", DoNotGenerateAcw=true)]
	internal partial class FlowIteratorPrimitiveArrayIteratorInvoker : FlowIteratorPrimitiveArrayIterator, global::Com.Mob.Tools.Java8.IFlowIterator {

		public FlowIteratorPrimitiveArrayIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$PrimitiveArrayIterator", typeof (FlowIteratorPrimitiveArrayIteratorInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("element", "(I)Ljava/lang/Object;", "GetElement_IHandler")]
		protected override unsafe global::Java.Lang.Object Element (int p0)
		{
			const string __id = "element.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.PrimitiveArrayIterator']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		protected override unsafe int Length ()
		{
			const string __id = "length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.RangeIterator']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$RangeIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<T>"})]
	public abstract partial class FlowIteratorRangeIterator : global::Java.Lang.Object, global::Com.Mob.Tools.Java8.IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$RangeIterator", typeof (FlowIteratorRangeIterator));
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

		protected FlowIteratorRangeIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.RangeIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.RangeIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_increase_Ljava_lang_Comparable_Ljava_lang_Comparable_;
#pragma warning disable 0169
		static Delegate GetIncrease_Ljava_lang_Comparable_Ljava_lang_Comparable_Handler ()
		{
			if (cb_increase_Ljava_lang_Comparable_Ljava_lang_Comparable_ == null)
				cb_increase_Ljava_lang_Comparable_Ljava_lang_Comparable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Increase_Ljava_lang_Comparable_Ljava_lang_Comparable_);
			return cb_increase_Ljava_lang_Comparable_Ljava_lang_Comparable_;
		}

		static IntPtr n_Increase_Ljava_lang_Comparable_Ljava_lang_Comparable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Increase (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.RangeIterator']/method[@name='increase' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("increase", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "GetIncrease_Ljava_lang_Comparable_Ljava_lang_Comparable_Handler")]
		protected abstract global::Java.Lang.Object Increase (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.RangeIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Comparable;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Comparable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		global::Java.Lang.Object global::Com.Mob.Tools.Java8.IFlowIterator.Next ()
		{
			throw new NotImplementedException ();
		}

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator$RangeIterator", DoNotGenerateAcw=true)]
	internal partial class FlowIteratorRangeIteratorInvoker : FlowIteratorRangeIterator, global::Com.Mob.Tools.Java8.IFlowIterator {

		public FlowIteratorRangeIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator$RangeIterator", typeof (FlowIteratorRangeIteratorInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.RangeIterator']/method[@name='increase' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("increase", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "GetIncrease_Ljava_lang_Comparable_Ljava_lang_Comparable_Handler")]
		protected override unsafe global::Java.Lang.Object Increase (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			const string __id = "increase.(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='FlowIterator']"
	[Register ("com/mob/tools/java8/FlowIterator", "", "Com.Mob.Tools.Java8.IFlowIteratorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IFlowIterator : IJavaObject, IJavaPeerable {

		bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='FlowIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler:Com.Mob.Tools.Java8.IFlowIteratorInvoker, IceShareSDKLib")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='FlowIterator']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler:Com.Mob.Tools.Java8.IFlowIteratorInvoker, IceShareSDKLib")]
		void Finish ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='FlowIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler:Com.Mob.Tools.Java8.IFlowIteratorInvoker, IceShareSDKLib")]
		global::Java.Lang.Object Next ();

	}

	[global::Android.Runtime.Register ("com/mob/tools/java8/FlowIterator", DoNotGenerateAcw=true)]
	internal partial class IFlowIteratorInvoker : global::Java.Lang.Object, IFlowIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/mob/tools/java8/FlowIterator", typeof (IFlowIteratorInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IFlowIterator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFlowIterator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.java8.FlowIterator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFlowIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.IFlowIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFlowIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		IntPtr id_hasNext;
		public unsafe bool HasNext {
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.IFlowIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFlowIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		IntPtr id_finish;
		public unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finish);
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.IFlowIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFlowIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		IntPtr id_next;
		public unsafe global::Java.Lang.Object Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
		}

	}

}
