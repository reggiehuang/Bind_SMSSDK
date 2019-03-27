using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mob.Tools.Mscript.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='Operate']"
	[global::Android.Runtime.Register ("com/mob/tools/mscript/commands/Operate", DoNotGenerateAcw=true)]
	public partial class Operate : global::Com.Mob.Tools.Mscript.MCommand {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/mob/tools/mscript/commands/Operate", typeof (Operate));
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

		protected Operate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='Operate']/constructor[@name='Operate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Operate ()
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

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static IntPtr n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mob.Tools.Mscript.Commands.Operate __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.Commands.Operate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Execute ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='Operate']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Ljava/lang/String;", "GetExecuteHandler")]
		public override unsafe string Execute ()
		{
			const string __id = "execute.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_Handler ()
		{
			if (cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_ == null)
				cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_);
			return cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_;
		}

		static IntPtr n_Execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_left, IntPtr native_symbol, IntPtr native_right)
		{
			global::Com.Mob.Tools.Mscript.Commands.Operate __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.Commands.Operate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object left = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_left, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Mscript.Commands.SymbolBinarySymbol symbol = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.Commands.SymbolBinarySymbol> (native_symbol, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object right = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_right, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (left, symbol, right));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='Operate']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.mob.tools.mscript.commands.Symbol.BinarySymbol'] and parameter[3][@type='java.lang.Object']]"
		[Register ("execute", "(Ljava/lang/Object;Lcom/mob/tools/mscript/commands/Symbol$BinarySymbol;Ljava/lang/Object;)Ljava/lang/Object;", "GetExecute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_BinarySymbol_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Execute (global::Java.Lang.Object left, global::Com.Mob.Tools.Mscript.Commands.SymbolBinarySymbol symbol, global::Java.Lang.Object right)
		{
			const string __id = "execute.(Ljava/lang/Object;Lcom/mob/tools/mscript/commands/Symbol$BinarySymbol;Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((left == null) ? IntPtr.Zero : ((global::Java.Lang.Object) left).Handle);
				__args [1] = new JniArgumentValue ((symbol == null) ? IntPtr.Zero : ((global::Java.Lang.Object) symbol).Handle);
				__args [2] = new JniArgumentValue ((right == null) ? IntPtr.Zero : ((global::Java.Lang.Object) right).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_Handler ()
		{
			if (cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_ == null)
				cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_);
			return cb_execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_;
		}

		static IntPtr n_Execute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_ (IntPtr jnienv, IntPtr native__this, IntPtr native_left, IntPtr native_symbol)
		{
			global::Com.Mob.Tools.Mscript.Commands.Operate __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.Commands.Operate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object left = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_left, JniHandleOwnership.DoNotTransfer);
			global::Com.Mob.Tools.Mscript.Commands.SymbolUnarySymbol symbol = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Mscript.Commands.SymbolUnarySymbol> (native_symbol, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (left, symbol));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.mscript.commands']/class[@name='Operate']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.mob.tools.mscript.commands.Symbol.UnarySymbol']]"
		[Register ("execute", "(Ljava/lang/Object;Lcom/mob/tools/mscript/commands/Symbol$UnarySymbol;)Ljava/lang/Object;", "GetExecute_Ljava_lang_Object_Lcom_mob_tools_mscript_commands_Symbol_UnarySymbol_Handler")]
		public virtual unsafe global::Java.Lang.Object Execute (global::Java.Lang.Object left, global::Com.Mob.Tools.Mscript.Commands.SymbolUnarySymbol symbol)
		{
			const string __id = "execute.(Ljava/lang/Object;Lcom/mob/tools/mscript/commands/Symbol$UnarySymbol;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((left == null) ? IntPtr.Zero : ((global::Java.Lang.Object) left).Handle);
				__args [1] = new JniArgumentValue ((symbol == null) ? IntPtr.Zero : ((global::Java.Lang.Object) symbol).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
