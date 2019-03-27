using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob']"
	[global::Android.Runtime.Register ("com/mob/tools/RxMob", DoNotGenerateAcw=true)]
	public partial class RxMob : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools']/interface[@name='RxMob.OnSubscribe']"
		[Register ("com/mob/tools/RxMob$OnSubscribe", "", "Com.Mob.Tools.RxMob/IOnSubscribeInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IOnSubscribe : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/interface[@name='RxMob.OnSubscribe']/method[@name='call' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Subscriber&lt;T&gt;']]"
			[Register ("call", "(Lcom/mob/tools/RxMob$Subscriber;)V", "GetCall_Lcom_mob_tools_RxMob_Subscriber_Handler:Com.Mob.Tools.RxMob/IOnSubscribeInvoker, IceShareSDKLib")]
			void Call (global::Com.Mob.Tools.RxMob.Subscriber p0);

		}

		[global::Android.Runtime.Register ("com/mob/tools/RxMob$OnSubscribe", DoNotGenerateAcw=true)]
		internal class IOnSubscribeInvoker : global::Java.Lang.Object, IOnSubscribe {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/RxMob$OnSubscribe", typeof (IOnSubscribeInvoker));

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

			public static IOnSubscribe GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSubscribe> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mob.tools.RxMob.OnSubscribe"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSubscribeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call_Lcom_mob_tools_RxMob_Subscriber_;
#pragma warning disable 0169
			static Delegate GetCall_Lcom_mob_tools_RxMob_Subscriber_Handler ()
			{
				if (cb_call_Lcom_mob_tools_RxMob_Subscriber_ == null)
					cb_call_Lcom_mob_tools_RxMob_Subscriber_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Call_Lcom_mob_tools_RxMob_Subscriber_);
				return cb_call_Lcom_mob_tools_RxMob_Subscriber_;
			}

			static void n_Call_Lcom_mob_tools_RxMob_Subscriber_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.RxMob.IOnSubscribe __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.IOnSubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mob.Tools.RxMob.Subscriber p0 = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscriber> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0);
			}
#pragma warning restore 0169

			IntPtr id_call_Lcom_mob_tools_RxMob_Subscriber_;
			public unsafe void Call (global::Com.Mob.Tools.RxMob.Subscriber p0)
			{
				if (id_call_Lcom_mob_tools_RxMob_Subscriber_ == IntPtr.Zero)
					id_call_Lcom_mob_tools_RxMob_Subscriber_ = JNIEnv.GetMethodID (class_ref, "call", "(Lcom/mob/tools/RxMob$Subscriber;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_call_Lcom_mob_tools_RxMob_Subscriber_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.QuickSubscribe']"
		[global::Android.Runtime.Register ("com/mob/tools/RxMob$QuickSubscribe", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public abstract partial class QuickSubscribe : global::Java.Lang.Object, global::Com.Mob.Tools.RxMob.IOnSubscribe {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/RxMob$QuickSubscribe", typeof (QuickSubscribe));
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

			protected QuickSubscribe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.QuickSubscribe']/constructor[@name='RxMob.QuickSubscribe' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe QuickSubscribe ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.QuickSubscribe']/method[@name='call' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Subscriber&lt;T&gt;']]"
			[Register ("call", "(Lcom/mob/tools/RxMob$Subscriber;)V", "")]
			public unsafe void Call (global::Com.Mob.Tools.RxMob.Subscriber subscriber)
			{
				const string __id = "call.(Lcom/mob/tools/RxMob$Subscriber;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_doNext_Lcom_mob_tools_RxMob_Subscriber_;
#pragma warning disable 0169
			static Delegate GetDoNext_Lcom_mob_tools_RxMob_Subscriber_Handler ()
			{
				if (cb_doNext_Lcom_mob_tools_RxMob_Subscriber_ == null)
					cb_doNext_Lcom_mob_tools_RxMob_Subscriber_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoNext_Lcom_mob_tools_RxMob_Subscriber_);
				return cb_doNext_Lcom_mob_tools_RxMob_Subscriber_;
			}

			static void n_DoNext_Lcom_mob_tools_RxMob_Subscriber_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mob.Tools.RxMob.QuickSubscribe __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.QuickSubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mob.Tools.RxMob.Subscriber p0 = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscriber> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.DoNext (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.QuickSubscribe']/method[@name='doNext' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Subscriber&lt;T&gt;']]"
			[Register ("doNext", "(Lcom/mob/tools/RxMob$Subscriber;)V", "GetDoNext_Lcom_mob_tools_RxMob_Subscriber_Handler")]
			protected abstract void DoNext (global::Com.Mob.Tools.RxMob.Subscriber p0);

		}

		[global::Android.Runtime.Register ("com/mob/tools/RxMob$QuickSubscribe", DoNotGenerateAcw=true)]
		internal partial class QuickSubscribeInvoker : QuickSubscribe, global::Com.Mob.Tools.RxMob.IOnSubscribe {

			public QuickSubscribeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/mob/tools/RxMob$QuickSubscribe", typeof (QuickSubscribeInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.QuickSubscribe']/method[@name='doNext' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Subscriber&lt;T&gt;']]"
			[Register ("doNext", "(Lcom/mob/tools/RxMob$Subscriber;)V", "GetDoNext_Lcom_mob_tools_RxMob_Subscriber_Handler")]
			protected override unsafe void DoNext (global::Com.Mob.Tools.RxMob.Subscriber p0)
			{
				const string __id = "doNext.(Lcom/mob/tools/RxMob$Subscriber;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscribable']"
		[global::Android.Runtime.Register ("com/mob/tools/RxMob$Subscribable", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public sealed partial class Subscribable : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/RxMob$Subscribable", typeof (Subscribable));
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

			internal Subscribable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscribable']/method[@name='observeOn' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Thread']]"
			[Register ("observeOn", "(Lcom/mob/tools/RxMob$Thread;)Lcom/mob/tools/RxMob$Subscribable;", "")]
			public unsafe global::Com.Mob.Tools.RxMob.Subscribable ObserveOn (global::Com.Mob.Tools.RxMob.Thread thread)
			{
				const string __id = "observeOn.(Lcom/mob/tools/RxMob$Thread;)Lcom/mob/tools/RxMob$Subscribable;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscribable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscribable']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Subscriber&lt;T&gt;']]"
			[Register ("subscribe", "(Lcom/mob/tools/RxMob$Subscriber;)V", "")]
			public unsafe void Subscribe (global::Com.Mob.Tools.RxMob.Subscriber subscriber)
			{
				const string __id = "subscribe.(Lcom/mob/tools/RxMob$Subscriber;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscribable']/method[@name='subscribeOn' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Thread']]"
			[Register ("subscribeOn", "(Lcom/mob/tools/RxMob$Thread;)Lcom/mob/tools/RxMob$Subscribable;", "")]
			public unsafe global::Com.Mob.Tools.RxMob.Subscribable SubscribeOn (global::Com.Mob.Tools.RxMob.Thread thread)
			{
				const string __id = "subscribeOn.(Lcom/mob/tools/RxMob$Thread;)Lcom/mob/tools/RxMob$Subscribable;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscribable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscribable']/method[@name='subscribeOnNewThreadAndObserveOnUIThread' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.Subscriber&lt;T&gt;']]"
			[Register ("subscribeOnNewThreadAndObserveOnUIThread", "(Lcom/mob/tools/RxMob$Subscriber;)V", "")]
			public unsafe void SubscribeOnNewThreadAndObserveOnUIThread (global::Com.Mob.Tools.RxMob.Subscriber subscriber)
			{
				const string __id = "subscribeOnNewThreadAndObserveOnUIThread.(Lcom/mob/tools/RxMob$Subscriber;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((subscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscriber).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscriber']"
		[global::Android.Runtime.Register ("com/mob/tools/RxMob$Subscriber", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class Subscriber : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/RxMob$Subscriber", typeof (Subscriber));
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

			protected Subscriber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscriber']/constructor[@name='RxMob.Subscriber' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Subscriber ()
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

			static Delegate cb_onCompleted;
#pragma warning disable 0169
			static Delegate GetOnCompletedHandler ()
			{
				if (cb_onCompleted == null)
					cb_onCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompleted);
				return cb_onCompleted;
			}

			static void n_OnCompleted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.RxMob.Subscriber __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscriber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscriber']/method[@name='onCompleted' and count(parameter)=0]"
			[Register ("onCompleted", "()V", "GetOnCompletedHandler")]
			public virtual unsafe void OnCompleted ()
			{
				const string __id = "onCompleted.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onError_Ljava_lang_Throwable_ == null)
					cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
				return cb_onError_Ljava_lang_Throwable_;
			}

			static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
			{
				global::Com.Mob.Tools.RxMob.Subscriber __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscriber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
				__this.OnError (t);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscriber']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void OnError (global::Java.Lang.Throwable t)
			{
				const string __id = "onError.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onNext_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnNext_Ljava_lang_Object_Handler ()
			{
				if (cb_onNext_Ljava_lang_Object_ == null)
					cb_onNext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNext_Ljava_lang_Object_);
				return cb_onNext_Ljava_lang_Object_;
			}

			static void n_OnNext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				global::Com.Mob.Tools.RxMob.Subscriber __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscriber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object data = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_data, JniHandleOwnership.DoNotTransfer);
				__this.OnNext (data);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscriber']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("onNext", "(Ljava/lang/Object;)V", "GetOnNext_Ljava_lang_Object_Handler")]
			public virtual unsafe void OnNext (global::Java.Lang.Object data)
			{
				const string __id = "onNext.(Ljava/lang/Object;)V";
				IntPtr native_data = JNIEnv.ToLocalJniHandle (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_data);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_data);
				}
			}

			static Delegate cb_onStart;
#pragma warning disable 0169
			static Delegate GetOnStartHandler ()
			{
				if (cb_onStart == null)
					cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
				return cb_onStart;
			}

			static void n_OnStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mob.Tools.RxMob.Subscriber __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscriber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStart ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscriber']/method[@name='onStart' and count(parameter)=0]"
			[Register ("onStart", "()V", "GetOnStartHandler")]
			public virtual unsafe void OnStart ()
			{
				const string __id = "onStart.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Subscriber']/method[@name='unsubscribe' and count(parameter)=0]"
			[Register ("unsubscribe", "()V", "")]
			public unsafe void Unsubscribe ()
			{
				const string __id = "unsubscribe.()V";
				try {
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Thread']"
		[global::Android.Runtime.Register ("com/mob/tools/RxMob$Thread", DoNotGenerateAcw=true)]
		public sealed partial class Thread : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Thread']/field[@name='IMMEDIATE']"
			[Register ("IMMEDIATE")]
			public static global::Com.Mob.Tools.RxMob.Thread Immediate {
				get {
					const string __id = "IMMEDIATE.Lcom/mob/tools/RxMob$Thread;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Thread> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Thread']/field[@name='NEW_THREAD']"
			[Register ("NEW_THREAD")]
			public static global::Com.Mob.Tools.RxMob.Thread NewThread {
				get {
					const string __id = "NEW_THREAD.Lcom/mob/tools/RxMob$Thread;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Thread> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Thread']/field[@name='UI_THREAD']"
			[Register ("UI_THREAD")]
			public static global::Com.Mob.Tools.RxMob.Thread UiThread {
				get {
					const string __id = "UI_THREAD.Lcom/mob/tools/RxMob$Thread;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Thread> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/RxMob$Thread", typeof (Thread));
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

			internal Thread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Thread']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mob/tools/RxMob$Thread;", "")]
			public static unsafe global::Com.Mob.Tools.RxMob.Thread ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/mob/tools/RxMob$Thread;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Thread> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob.Thread']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mob/tools/RxMob$Thread;", "")]
			public static unsafe global::Com.Mob.Tools.RxMob.Thread[] Values ()
			{
				const string __id = "values.()[Lcom/mob/tools/RxMob$Thread;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Mob.Tools.RxMob.Thread[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mob.Tools.RxMob.Thread));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/RxMob", typeof (RxMob));
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

		protected RxMob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob']/constructor[@name='RxMob' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RxMob ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.mob.tools.RxMob.OnSubscribe&lt;T&gt;']]"
		[Register ("create", "(Lcom/mob/tools/RxMob$OnSubscribe;)Lcom/mob/tools/RxMob$Subscribable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.RxMob.Subscribable Create (global::Com.Mob.Tools.RxMob.IOnSubscribe onSubscribe)
		{
			const string __id = "create.(Lcom/mob/tools/RxMob$OnSubscribe;)Lcom/mob/tools/RxMob$Subscribable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onSubscribe == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onSubscribe).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscribable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;T&gt;']]"
		[Register ("from", "(Ljava/util/Iterator;)Lcom/mob/tools/RxMob$Subscribable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.RxMob.Subscribable From (global::Java.Util.IIterator datas)
		{
			const string __id = "from.(Ljava/util/Iterator;)Lcom/mob/tools/RxMob$Subscribable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((datas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) datas).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscribable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools']/class[@name='RxMob']/method[@name='just' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("just", "([Ljava/lang/Object;)Lcom/mob/tools/RxMob$Subscribable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Mob.Tools.RxMob.Subscribable Just (params global::Java.Lang.Object[] datas)
		{
			const string __id = "just.([Ljava/lang/Object;)Lcom/mob/tools/RxMob$Subscribable;";
			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_datas);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.RxMob.Subscribable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

	}
}
