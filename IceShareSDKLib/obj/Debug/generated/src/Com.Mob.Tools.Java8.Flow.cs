using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Java8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']"
	[global::Android.Runtime.Register ("com/mob/tools/java8/Flow", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class Flow : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/field[@name='functions']"
		[Register ("functions")]
		protected global::Java.Util.LinkedList Functions {
			get {
				const string __id = "functions.Ljava/util/LinkedList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "functions.Ljava/util/LinkedList;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/field[@name='iterator']"
		[Register ("iterator")]
		protected global::Com.Mob.Tools.Java8.IFlowIterator Iterator {
			get {
				const string __id = "iterator.Lcom/mob/tools/java8/FlowIterator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFlowIterator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "iterator.Lcom/mob/tools/java8/FlowIterator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/java8/Flow", typeof (Flow));
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

		protected Flow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_any;
#pragma warning disable 0169
		static Delegate GetAnyHandler ()
		{
			if (cb_any == null)
				cb_any = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Any);
			return cb_any;
		}

		static bool n_Any (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Any ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='any' and count(parameter)=0]"
		[Register ("any", "()Z", "GetAnyHandler")]
		public virtual unsafe bool Any ()
		{
			const string __id = "any.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_chunk_I;
#pragma warning disable 0169
		static Delegate GetChunk_IHandler ()
		{
			if (cb_chunk_I == null)
				cb_chunk_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Chunk_I);
			return cb_chunk_I;
		}

		static IntPtr n_Chunk_I (IntPtr jnienv, IntPtr native__this, int chunk)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Chunk (chunk));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='chunk' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("chunk", "(I)Lcom/mob/tools/java8/Flow;", "GetChunk_IHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Chunk (int chunk)
		{
			const string __id = "chunk.(I)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (chunk);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_collect_Lcom_mob_tools_java8_Collect_;
#pragma warning disable 0169
		static Delegate GetCollect_Lcom_mob_tools_java8_Collect_Handler ()
		{
			if (cb_collect_Lcom_mob_tools_java8_Collect_ == null)
				cb_collect_Lcom_mob_tools_java8_Collect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Lcom_mob_tools_java8_Collect_);
			return cb_collect_Lcom_mob_tools_java8_Collect_;
		}

		static IntPtr n_Collect_Lcom_mob_tools_java8_Collect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.ICollect fun = (global::Com.Mob.Tools.Java8.ICollect)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollect> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='collect' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Collect&lt;T, R&gt;']]"
		[Register ("collect", "(Lcom/mob/tools/java8/Collect;)Lcom/mob/tools/java8/Flow;", "GetCollect_Lcom_mob_tools_java8_Collect_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Collect (global::Com.Mob.Tools.Java8.ICollect fun)
		{
			const string __id = "collect.(Lcom/mob/tools/java8/Collect;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='concat' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Flow&lt;? extends T&gt;...']]"
		[Register ("concat", "([Lcom/mob/tools/java8/Flow;)Lcom/mob/tools/java8/Flow;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Concat (params global::Com.Mob.Tools.Java8.Flow[] flows)
		{
			const string __id = "concat.([Lcom/mob/tools/java8/Flow;)Lcom/mob/tools/java8/Flow;";
			IntPtr native_flows = JNIEnv.NewArray (flows);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_flows);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (flows != null) {
					JNIEnv.CopyArray (native_flows, flows);
					JNIEnv.DeleteLocalRef (native_flows);
				}
			}
		}

		static Delegate cb_count;
#pragma warning disable 0169
		static Delegate GetCountHandler ()
		{
			if (cb_count == null)
				cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count);
			return cb_count;
		}

		static int n_Count (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()I", "GetCountHandler")]
		public virtual unsafe int Count ()
		{
			const string __id = "count.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_distinct;
#pragma warning disable 0169
		static Delegate GetDistinctHandler ()
		{
			if (cb_distinct == null)
				cb_distinct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Distinct);
			return cb_distinct;
		}

		static IntPtr n_Distinct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Distinct ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='distinct' and count(parameter)=0]"
		[Register ("distinct", "()Lcom/mob/tools/java8/Flow;", "GetDistinctHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Distinct ()
		{
			const string __id = "distinct.()Lcom/mob/tools/java8/Flow;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_each_Lcom_mob_tools_java8_Each_;
#pragma warning disable 0169
		static Delegate GetEach_Lcom_mob_tools_java8_Each_Handler ()
		{
			if (cb_each_Lcom_mob_tools_java8_Each_ == null)
				cb_each_Lcom_mob_tools_java8_Each_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Each_Lcom_mob_tools_java8_Each_);
			return cb_each_Lcom_mob_tools_java8_Each_;
		}

		static void n_Each_Lcom_mob_tools_java8_Each_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.IEach fun = (global::Com.Mob.Tools.Java8.IEach)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IEach> (native_fun, JniHandleOwnership.DoNotTransfer);
			__this.Each (fun);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='each' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Each&lt;T&gt;']]"
		[Register ("each", "(Lcom/mob/tools/java8/Each;)V", "GetEach_Lcom_mob_tools_java8_Each_Handler")]
		public virtual unsafe void Each (global::Com.Mob.Tools.Java8.IEach fun)
		{
			const string __id = "each.(Lcom/mob/tools/java8/Each;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_evaluate;
#pragma warning disable 0169
		static Delegate GetEvaluateHandler ()
		{
			if (cb_evaluate == null)
				cb_evaluate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Evaluate);
			return cb_evaluate;
		}

		static void n_Evaluate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Evaluate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='evaluate' and count(parameter)=0]"
		[Register ("evaluate", "()V", "GetEvaluateHandler")]
		protected virtual unsafe void Evaluate ()
		{
			const string __id = "evaluate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_filter_Lcom_mob_tools_java8_Filter_;
#pragma warning disable 0169
		static Delegate GetFilter_Lcom_mob_tools_java8_Filter_Handler ()
		{
			if (cb_filter_Lcom_mob_tools_java8_Filter_ == null)
				cb_filter_Lcom_mob_tools_java8_Filter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Filter_Lcom_mob_tools_java8_Filter_);
			return cb_filter_Lcom_mob_tools_java8_Filter_;
		}

		static IntPtr n_Filter_Lcom_mob_tools_java8_Filter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.IFilter fun = (global::Com.Mob.Tools.Java8.IFilter)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFilter> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Filter (fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Filter&lt;T&gt;']]"
		[Register ("filter", "(Lcom/mob/tools/java8/Filter;)Lcom/mob/tools/java8/Flow;", "GetFilter_Lcom_mob_tools_java8_Filter_Handler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Filter (global::Com.Mob.Tools.Java8.IFilter fun)
		{
			const string __id = "filter.(Lcom/mob/tools/java8/Filter;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_first;
#pragma warning disable 0169
		static Delegate GetFirstHandler ()
		{
			if (cb_first == null)
				cb_first = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_First);
			return cb_first;
		}

		static IntPtr n_First (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.First ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='first' and count(parameter)=0]"
		[Register ("first", "()Lcom/mob/tools/java8/Optional;", "GetFirstHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Optional First ()
		{
			const string __id = "first.()Lcom/mob/tools/java8/Optional;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_inject_Lcom_mob_tools_java8_Inject_;
#pragma warning disable 0169
		static Delegate GetInject_Lcom_mob_tools_java8_Inject_Handler ()
		{
			if (cb_inject_Lcom_mob_tools_java8_Inject_ == null)
				cb_inject_Lcom_mob_tools_java8_Inject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Inject_Lcom_mob_tools_java8_Inject_);
			return cb_inject_Lcom_mob_tools_java8_Inject_;
		}

		static IntPtr n_Inject_Lcom_mob_tools_java8_Inject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.IInject fun = (global::Com.Mob.Tools.Java8.IInject)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IInject> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Inject (fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='inject' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Inject&lt;T, R&gt;']]"
		[Register ("inject", "(Lcom/mob/tools/java8/Inject;)Ljava/lang/Object;", "GetInject_Lcom_mob_tools_java8_Inject_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object Inject (global::Com.Mob.Tools.Java8.IInject fun)
		{
			const string __id = "inject.(Lcom/mob/tools/java8/Inject;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_;
#pragma warning disable 0169
		static Delegate GetInject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_Handler ()
		{
			if (cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_ == null)
				cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_);
			return cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_;
		}

		static IntPtr n_Inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identity, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object identity = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_identity, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.IInject fun = (global::Com.Mob.Tools.Java8.IInject)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IInject> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Inject (identity, fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='inject' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.mob.tools.java8.Inject&lt;T, R&gt;']]"
		[Register ("inject", "(Ljava/lang/Object;Lcom/mob/tools/java8/Inject;)Ljava/lang/Object;", "GetInject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object Inject (global::Java.Lang.Object identity, global::Com.Mob.Tools.Java8.IInject fun)
		{
			const string __id = "inject.(Ljava/lang/Object;Lcom/mob/tools/java8/Inject;)Ljava/lang/Object;";
			IntPtr native_identity = JNIEnv.ToLocalJniHandle (identity);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identity);
				__args [1] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identity);
			}
		}

		static Delegate cb_jumble;
#pragma warning disable 0169
		static Delegate GetJumbleHandler ()
		{
			if (cb_jumble == null)
				cb_jumble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Jumble);
			return cb_jumble;
		}

		static IntPtr n_Jumble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Jumble ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='jumble' and count(parameter)=0]"
		[Register ("jumble", "()Lcom/mob/tools/java8/Flow;", "GetJumbleHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Jumble ()
		{
			const string __id = "jumble.()Lcom/mob/tools/java8/Flow;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_last;
#pragma warning disable 0169
		static Delegate GetLastHandler ()
		{
			if (cb_last == null)
				cb_last = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Last);
			return cb_last;
		}

		static IntPtr n_Last (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Last ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='last' and count(parameter)=0]"
		[Register ("last", "()Lcom/mob/tools/java8/Optional;", "GetLastHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Optional Last ()
		{
			const string __id = "last.()Lcom/mob/tools/java8/Optional;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_limit_I;
#pragma warning disable 0169
		static Delegate GetLimit_IHandler ()
		{
			if (cb_limit_I == null)
				cb_limit_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Limit_I);
			return cb_limit_I;
		}

		static IntPtr n_Limit_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Limit (limit));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("limit", "(I)Lcom/mob/tools/java8/Flow;", "GetLimit_IHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Limit (int limit)
		{
			const string __id = "limit.(I)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_map_Lcom_mob_tools_java8_Map_;
#pragma warning disable 0169
		static Delegate GetMap_Lcom_mob_tools_java8_Map_Handler ()
		{
			if (cb_map_Lcom_mob_tools_java8_Map_ == null)
				cb_map_Lcom_mob_tools_java8_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Lcom_mob_tools_java8_Map_);
			return cb_map_Lcom_mob_tools_java8_Map_;
		}

		static IntPtr n_Map_Lcom_mob_tools_java8_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.IMap fun = (global::Com.Mob.Tools.Java8.IMap)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMap> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Map&lt;T, R&gt;']]"
		[Register ("map", "(Lcom/mob/tools/java8/Map;)Lcom/mob/tools/java8/Flow;", "GetMap_Lcom_mob_tools_java8_Map_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Map (global::Com.Mob.Tools.Java8.IMap fun)
		{
			const string __id = "map.(Lcom/mob/tools/java8/Map;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='boolean...']]"
		[Register ("of", "([Z)Lcom/mob/tools/java8/Flow;", "")]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (params bool[] array)
		{
			const string __id = "of.([Z)Lcom/mob/tools/java8/Flow;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='char...']]"
		[Register ("of", "([C)Lcom/mob/tools/java8/Flow;", "")]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (params char[] array)
		{
			const string __id = "of.([C)Lcom/mob/tools/java8/Flow;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.FlowIterator&lt;T&gt;']]"
		[Register ("of", "(Lcom/mob/tools/java8/FlowIterator;)Lcom/mob/tools/java8/Flow;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (global::Com.Mob.Tools.Java8.IFlowIterator iterator)
		{
			const string __id = "of.(Lcom/mob/tools/java8/FlowIterator;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.io.BufferedReader']]"
		[Register ("of", "(Ljava/io/BufferedReader;)Lcom/mob/tools/java8/Flow;", "")]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (global::Java.IO.BufferedReader br)
		{
			const string __id = "of.(Ljava/io/BufferedReader;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((br == null) ? IntPtr.Zero : ((global::Java.Lang.Object) br).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("of", "(Ljava/io/File;)Lcom/mob/tools/java8/Flow;", "")]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (global::Java.IO.File file)
		{
			const string __id = "of.(Ljava/io/File;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("of", "(Ljava/io/File;Ljava/lang/String;)Lcom/mob/tools/java8/Flow;", "")]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (global::Java.IO.File file, string charset)
		{
			const string __id = "of.(Ljava/io/File;Ljava/lang/String;)Lcom/mob/tools/java8/Flow;";
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [1] = new JniArgumentValue (native_charset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("of", "(Ljava/io/File;Ljava/nio/charset/Charset;)Lcom/mob/tools/java8/Flow;", "")]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (global::Java.IO.File file, global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "of.(Ljava/io/File;Ljava/nio/charset/Charset;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [1] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;T&gt;']]"
		[Register ("of", "(Ljava/lang/Iterable;)Lcom/mob/tools/java8/Flow;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (global::Java.Lang.IIterable iterable)
		{
			const string __id = "of.(Ljava/lang/Iterable;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.util.Enumeration&lt;T&gt;']]"
		[Register ("of", "(Ljava/util/Enumeration;)Lcom/mob/tools/java8/Flow;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (global::Java.Util.IEnumeration enumeration)
		{
			const string __id = "of.(Ljava/util/Enumeration;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((enumeration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) enumeration).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='of' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("of", "([Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.Java8.Flow Of (params global::Java.Lang.Object[] array)
		{
			const string __id = "of.([Ljava/lang/Object;)Lcom/mob/tools/java8/Flow;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_peek_Lcom_mob_tools_java8_Peek_;
#pragma warning disable 0169
		static Delegate GetPeek_Lcom_mob_tools_java8_Peek_Handler ()
		{
			if (cb_peek_Lcom_mob_tools_java8_Peek_ == null)
				cb_peek_Lcom_mob_tools_java8_Peek_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Peek_Lcom_mob_tools_java8_Peek_);
			return cb_peek_Lcom_mob_tools_java8_Peek_;
		}

		static IntPtr n_Peek_Lcom_mob_tools_java8_Peek_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.IPeek fun = (global::Com.Mob.Tools.Java8.IPeek)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IPeek> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Peek (fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Peek&lt;T&gt;']]"
		[Register ("peek", "(Lcom/mob/tools/java8/Peek;)Lcom/mob/tools/java8/Flow;", "GetPeek_Lcom_mob_tools_java8_Peek_Handler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Peek (global::Com.Mob.Tools.Java8.IPeek fun)
		{
			const string __id = "peek.(Lcom/mob/tools/java8/Peek;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skip_I;
#pragma warning disable 0169
		static Delegate GetSkip_IHandler ()
		{
			if (cb_skip_I == null)
				cb_skip_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Skip_I);
			return cb_skip_I;
		}

		static IntPtr n_Skip_I (IntPtr jnienv, IntPtr native__this, int skip)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Skip (skip));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)Lcom/mob/tools/java8/Flow;", "GetSkip_IHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Skip (int skip)
		{
			const string __id = "skip.(I)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skip);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sort;
#pragma warning disable 0169
		static Delegate GetSortHandler ()
		{
			if (cb_sort == null)
				cb_sort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sort);
			return cb_sort;
		}

		static IntPtr n_Sort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sort ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='sort' and count(parameter)=0]"
		[Register ("sort", "()Lcom/mob/tools/java8/Flow;", "GetSortHandler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Sort ()
		{
			const string __id = "sort.()Lcom/mob/tools/java8/Flow;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sort_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetSort_Ljava_util_Comparator_Handler ()
		{
			if (cb_sort_Ljava_util_Comparator_ == null)
				cb_sort_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sort_Ljava_util_Comparator_);
			return cb_sort_Ljava_util_Comparator_;
		}

		static IntPtr n_Sort_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IComparator fun = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sort (fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='sort' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;T&gt;']]"
		[Register ("sort", "(Ljava/util/Comparator;)Lcom/mob/tools/java8/Flow;", "GetSort_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::Com.Mob.Tools.Java8.Flow Sort (global::Java.Util.IComparator fun)
		{
			const string __id = "sort.(Ljava/util/Comparator;)Lcom/mob/tools/java8/Flow;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Ljava/lang/Object;", "GetToArrayHandler")]
		public virtual unsafe global::Java.Lang.Object[] ToArray ()
		{
			const string __id = "toArray.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_toArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToArray_arrayLjava_lang_Object_Handler ()
		{
			if (cb_toArray_arrayLjava_lang_Object_ == null)
				cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToArray_arrayLjava_lang_Object_);
			return cb_toArray_arrayLjava_lang_Object_;
		}

		static IntPtr n_ToArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewArray (__this.ToArray (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "GetToArray_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object[] ToArray (global::Java.Lang.Object[] array)
		{
			const string __id = "toArray.([Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_toList;
#pragma warning disable 0169
		static Delegate GetToListHandler ()
		{
			if (cb_toList == null)
				cb_toList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToList);
			return cb_toList;
		}

		static IntPtr n_ToList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ToList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='toList' and count(parameter)=0]"
		[Register ("toList", "()Ljava/util/List;", "GetToListHandler")]
		public virtual unsafe global::System.Collections.IList ToList ()
		{
			const string __id = "toList.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toMap_Lcom_mob_tools_java8_MapMaker_;
#pragma warning disable 0169
		static Delegate GetToMap_Lcom_mob_tools_java8_MapMaker_Handler ()
		{
			if (cb_toMap_Lcom_mob_tools_java8_MapMaker_ == null)
				cb_toMap_Lcom_mob_tools_java8_MapMaker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToMap_Lcom_mob_tools_java8_MapMaker_);
			return cb_toMap_Lcom_mob_tools_java8_MapMaker_;
		}

		static IntPtr n_ToMap_Lcom_mob_tools_java8_MapMaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Java8.IMapMaker fun = (global::Com.Mob.Tools.Java8.IMapMaker)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMaker> (native_fun, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.ToMap (fun));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='toMap' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.MapMaker&lt;T, K, V&gt;']]"
		[Register ("toMap", "(Lcom/mob/tools/java8/MapMaker;)Ljava/util/Map;", "GetToMap_Lcom_mob_tools_java8_MapMaker_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public virtual unsafe global::System.Collections.IDictionary ToMap (global::Com.Mob.Tools.Java8.IMapMaker fun)
		{
			const string __id = "toMap.(Lcom/mob/tools/java8/MapMaker;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fun).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toSet;
#pragma warning disable 0169
		static Delegate GetToSetHandler ()
		{
			if (cb_toSet == null)
				cb_toSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToSet);
			return cb_toSet;
		}

		static IntPtr n_ToSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Java8.Flow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Flow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet.ToLocalJniHandle (__this.ToSet ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='Flow']/method[@name='toSet' and count(parameter)=0]"
		[Register ("toSet", "()Ljava/util/Set;", "GetToSetHandler")]
		public virtual unsafe global::System.Collections.ICollection ToSet ()
		{
			const string __id = "toSet.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
