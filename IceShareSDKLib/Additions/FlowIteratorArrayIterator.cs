using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Mob.Tools.Java8
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.BoolArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$BoolArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorBoolArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$BoolArrayIterator", typeof(FlowIteratorBoolArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorBoolArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorBoolArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorBoolArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.BoolArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Boolean;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Boolean;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorBoolArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorBoolArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.BoolArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

        //protected override Java.Lang.Object Element(int p0)
        //{
        //    throw new NotImplementedException();
        //}
    }

    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ByteArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$ByteArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorByteArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        [Register("element", "(I)Ljava/lang/Object;", "GetElement_IHandler")]

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$ByteArrayIterator", typeof(FlowIteratorByteArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorByteArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorByteArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorByteArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ByteArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Byte;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Byte;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorByteArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorByteArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ByteArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }
    }


    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.CharArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$CharArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorCharArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$CharArrayIterator", typeof(FlowIteratorCharArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorCharArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorCharArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorCharArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.CharArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Character;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Character;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Character>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorCharArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorCharArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.CharArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

    }


    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.DoubleArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$DoubleArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorDoubleArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$DoubleArrayIterator", typeof(FlowIteratorDoubleArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorDoubleArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorDoubleArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorDoubleArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.DoubleArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Double;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Double;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Double>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorDoubleArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorDoubleArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.DoubleArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

    }


    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.DoubleRangeIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$DoubleRangeIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorDoubleRangeIterator : global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$DoubleRangeIterator", typeof(FlowIteratorDoubleRangeIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorDoubleRangeIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_increase_Ljava_lang_Double_Ljava_lang_Double_;
#pragma warning disable 0169
        static Delegate GetIncrease_Ljava_lang_Double_Ljava_lang_Double_Handler()
        {
            if (cb_increase_Ljava_lang_Double_Ljava_lang_Double_ == null)
                cb_increase_Ljava_lang_Double_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Increase_Ljava_lang_Double_Ljava_lang_Double_);
            return cb_increase_Ljava_lang_Double_Ljava_lang_Double_;
        }

        static IntPtr n_Increase_Ljava_lang_Double_Ljava_lang_Double_(IntPtr jnienv, IntPtr native__this, IntPtr native_position, IntPtr native_step)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorDoubleRangeIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorDoubleRangeIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Double position = global::Java.Lang.Object.GetObject<global::Java.Lang.Double>(native_position, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Double step = global::Java.Lang.Object.GetObject<global::Java.Lang.Double>(native_step, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Increase(position, step));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.DoubleRangeIterator']/method[@name='increase' and count(parameter)=2 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='java.lang.Double']]"
        [Register("increase", "(Ljava/lang/Double;Ljava/lang/Double;)Ljava/lang/Double;", "GetIncrease_Ljava_lang_Double_Ljava_lang_Double_Handler")]
        protected override unsafe global::Java.Lang.Object Increase(global::Java.Lang.Object position, global::Java.Lang.Object step)
        {
            const string __id = "increase.(Ljava/lang/Double;Ljava/lang/Double;)Ljava/lang/Double;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((position == null) ? IntPtr.Zero : ((global::Java.Lang.Object)position).Handle);
                __args[1] = new JniArgumentValue((step == null) ? IntPtr.Zero : ((global::Java.Lang.Object)step).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Double>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.FloatArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$FloatArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorFloatArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$FloatArrayIterator", typeof(FlowIteratorFloatArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorFloatArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorFloatArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorFloatArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.FloatArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Float;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Float;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Float>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorFloatArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorFloatArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.FloatArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

    }



    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IntArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$IntArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorIntArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$IntArrayIterator", typeof(FlowIteratorIntArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorIntArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorIntArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorIntArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IntArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Integer;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Integer;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorIntArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorIntArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IntArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

    }



    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IntRangeIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$IntRangeIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorIntRangeIterator : global::Com.Mob.Tools.Java8.FlowIteratorRangeIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$IntRangeIterator", typeof(FlowIteratorIntRangeIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorIntRangeIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_increase_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
        static Delegate GetIncrease_Ljava_lang_Integer_Ljava_lang_Integer_Handler()
        {
            if (cb_increase_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
                cb_increase_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Increase_Ljava_lang_Integer_Ljava_lang_Integer_);
            return cb_increase_Ljava_lang_Integer_Ljava_lang_Integer_;
        }

        static IntPtr n_Increase_Ljava_lang_Integer_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_position, IntPtr native_step)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorIntRangeIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorIntRangeIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Integer position = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer>(native_position, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Integer step = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer>(native_step, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Increase(position, step));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.IntRangeIterator']/method[@name='increase' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer']]"
        [Register("increase", "(Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;", "GetIncrease_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
        protected override unsafe global::Java.Lang.Object Increase(global::Java.Lang.Object position, global::Java.Lang.Object step)
        {
            const string __id = "increase.(Ljava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((position == null) ? IntPtr.Zero : ((global::Java.Lang.Object)position).Handle);
                __args[1] = new JniArgumentValue((step == null) ? IntPtr.Zero : ((global::Java.Lang.Object)step).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }


    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.LongArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$LongArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorLongArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$LongArrayIterator", typeof(FlowIteratorLongArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorLongArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorLongArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorLongArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.LongArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Long;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Long;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Long>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorLongArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorLongArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.LongArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

    }




    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ShortArrayIterator']"
    [global::Android.Runtime.Register("com/mob/tools/java8/FlowIterator$ShortArrayIterator", DoNotGenerateAcw = true)]
    public partial class FlowIteratorShortArrayIterator : global::Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator
    {

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/FlowIterator$ShortArrayIterator", typeof(FlowIteratorShortArrayIterator));
        internal static new IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected FlowIteratorShortArrayIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_element_I;
#pragma warning disable 0169
        static Delegate GetElement_IHandler()
        {
            if (cb_element_I == null)
                cb_element_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Element_I);
            return cb_element_I;
        }

        static IntPtr n_Element_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorShortArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorShortArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Element(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ShortArrayIterator']/method[@name='element' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("element", "(I)Ljava/lang/Short;", "GetElement_IHandler")]
        protected override unsafe global::Java.Lang.Object Element(int index)
        {
            const string __id = "element.(I)Ljava/lang/Short;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Short>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_length;
#pragma warning disable 0169
        static Delegate GetLengthHandler()
        {
            if (cb_length == null)
                cb_length = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Length);
            return cb_length;
        }

        static int n_Length(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.FlowIteratorShortArrayIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.FlowIteratorShortArrayIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Length();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='FlowIterator.ShortArrayIterator']/method[@name='length' and count(parameter)=0]"
        [Register("length", "()I", "GetLengthHandler")]
        protected override unsafe int Length()
        {
            const string __id = "length.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

    }
}