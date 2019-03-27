using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Mob.Tools.Java8
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']"
    [global::Android.Runtime.Register("com/mob/tools/java8/MapFlow", DoNotGenerateAcw = true)]
    [global::Java.Interop.JavaTypeParameters(new string[] { "K", "V" })]
    public partial class MapFlow : global::Java.Lang.Object
    {

        // Metadata.xml XPath class reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow.MapItem']"
        [global::Android.Runtime.Register("com/mob/tools/java8/MapFlow$MapItem", DoNotGenerateAcw = true)]
        [global::Java.Interop.JavaTypeParameters(new string[] { "K", "V" })]
        public partial class MapItem : global::Java.Lang.Object, global::Java.Lang.IComparable
        {



            // Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow.MapItem']/field[@name='key']"
            [Register("key")]
            public global::Java.Lang.Object Key
            {
                get
                {
                    const string __id = "key.Ljava/lang/Object;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "key.Ljava/lang/Object;";

                    IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow.MapItem']/field[@name='value']"
            [Register("value")]
            public global::Java.Lang.Object Value
            {
                get
                {
                    const string __id = "value.Ljava/lang/Object;";

                    var __v = _members.InstanceFields.GetObjectValue(__id, this);
                    return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__v.Handle, JniHandleOwnership.TransferLocalRef);
                }
                set
                {
                    const string __id = "value.Ljava/lang/Object;";

                    IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                    }
                    finally
                    {
                        global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                    }
                }
            }
            internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/MapFlow$MapItem", typeof(MapItem));
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

            protected MapItem(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            public int CompareTo(Java.Lang.Object o)
            {
                return Convert.ToInt32(0);
            }
        }

        internal new static readonly JniPeerMembers _members = new XAPeerMembers("com/mob/tools/java8/MapFlow", typeof(MapFlow));
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

        protected MapFlow(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_any;
#pragma warning disable 0169
        static Delegate GetAnyHandler()
        {
            if (cb_any == null)
                cb_any = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_Any);
            return cb_any;
        }

        static bool n_Any(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Any();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='any' and count(parameter)=0]"
        [Register("any", "()Z", "GetAnyHandler")]
        public virtual unsafe bool Any()
        {
            const string __id = "any.()Z";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_collect_Lcom_mob_tools_java8_Collect_MapCollect_;
#pragma warning disable 0169
        static Delegate GetCollect_Lcom_mob_tools_java8_Collect_MapCollect_Handler()
        {
            if (cb_collect_Lcom_mob_tools_java8_Collect_MapCollect_ == null)
                cb_collect_Lcom_mob_tools_java8_Collect_MapCollect_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Collect_Lcom_mob_tools_java8_Collect_MapCollect_);
            return cb_collect_Lcom_mob_tools_java8_Collect_MapCollect_;
        }

        static IntPtr n_Collect_Lcom_mob_tools_java8_Collect_MapCollect_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.ICollectMapCollect fun = (global::Com.Mob.Tools.Java8.ICollectMapCollect)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectMapCollect>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Collect(fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='collect' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Collect.MapCollect&lt;K, V, U, R&gt;']]"
        [Register("collect", "(Lcom/mob/tools/java8/Collect$MapCollect;)Lcom/mob/tools/java8/MapFlow;", "GetCollect_Lcom_mob_tools_java8_Collect_MapCollect_Handler")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "U", "R" })]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Collect(global::Com.Mob.Tools.Java8.ICollectMapCollect fun)
        {
            const string __id = "collect.(Lcom/mob/tools/java8/Collect$MapCollect;)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_count;
#pragma warning disable 0169
        static Delegate GetCountHandler()
        {
            if (cb_count == null)
                cb_count = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_Count);
            return cb_count;
        }

        static int n_Count(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Count();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='count' and count(parameter)=0]"
        [Register("count", "()I", "GetCountHandler")]
        public virtual unsafe int Count()
        {
            const string __id = "count.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_distinct;
#pragma warning disable 0169
        static Delegate GetDistinctHandler()
        {
            if (cb_distinct == null)
                cb_distinct = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_Distinct);
            return cb_distinct;
        }

        static IntPtr n_Distinct(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Distinct());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='distinct' and count(parameter)=0]"
        [Register("distinct", "()Lcom/mob/tools/java8/MapFlow;", "GetDistinctHandler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Distinct()
        {
            const string __id = "distinct.()Lcom/mob/tools/java8/MapFlow;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_each_Lcom_mob_tools_java8_Each_MapEach_;
#pragma warning disable 0169
        static Delegate GetEach_Lcom_mob_tools_java8_Each_MapEach_Handler()
        {
            if (cb_each_Lcom_mob_tools_java8_Each_MapEach_ == null)
                cb_each_Lcom_mob_tools_java8_Each_MapEach_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_Each_Lcom_mob_tools_java8_Each_MapEach_);
            return cb_each_Lcom_mob_tools_java8_Each_MapEach_;
        }

        static void n_Each_Lcom_mob_tools_java8_Each_MapEach_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.IEachMapEach fun = (global::Com.Mob.Tools.Java8.IEachMapEach)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IEachMapEach>(native_fun, JniHandleOwnership.DoNotTransfer);
            __this.Each(fun);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='each' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Each.MapEach&lt;K, V&gt;']]"
        [Register("each", "(Lcom/mob/tools/java8/Each$MapEach;)V", "GetEach_Lcom_mob_tools_java8_Each_MapEach_Handler")]
        public virtual unsafe void Each(global::Com.Mob.Tools.Java8.IEachMapEach fun)
        {
            const string __id = "each.(Lcom/mob/tools/java8/Each$MapEach;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_filter_Lcom_mob_tools_java8_Filter_MapFilter_;
#pragma warning disable 0169
        static Delegate GetFilter_Lcom_mob_tools_java8_Filter_MapFilter_Handler()
        {
            if (cb_filter_Lcom_mob_tools_java8_Filter_MapFilter_ == null)
                cb_filter_Lcom_mob_tools_java8_Filter_MapFilter_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Filter_Lcom_mob_tools_java8_Filter_MapFilter_);
            return cb_filter_Lcom_mob_tools_java8_Filter_MapFilter_;
        }

        static IntPtr n_Filter_Lcom_mob_tools_java8_Filter_MapFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.IFilterMapFilter fun = (global::Com.Mob.Tools.Java8.IFilterMapFilter)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IFilterMapFilter>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Filter(fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Filter.MapFilter&lt;K, V&gt;']]"
        [Register("filter", "(Lcom/mob/tools/java8/Filter$MapFilter;)Lcom/mob/tools/java8/MapFlow;", "GetFilter_Lcom_mob_tools_java8_Filter_MapFilter_Handler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Filter(global::Com.Mob.Tools.Java8.IFilterMapFilter fun)
        {
            const string __id = "filter.(Lcom/mob/tools/java8/Filter$MapFilter;)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_first;
#pragma warning disable 0169
        static Delegate GetFirstHandler()
        {
            if (cb_first == null)
                cb_first = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_First);
            return cb_first;
        }

        static IntPtr n_First(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.First());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='first' and count(parameter)=0]"
        [Register("first", "()Lcom/mob/tools/java8/Optional;", "GetFirstHandler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.Optional First()
        {
            const string __id = "first.()Lcom/mob/tools/java8/Optional;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Optional>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_inject_Lcom_mob_tools_java8_Inject_MapInject_;
#pragma warning disable 0169
        static Delegate GetInject_Lcom_mob_tools_java8_Inject_MapInject_Handler()
        {
            if (cb_inject_Lcom_mob_tools_java8_Inject_MapInject_ == null)
                cb_inject_Lcom_mob_tools_java8_Inject_MapInject_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Inject_Lcom_mob_tools_java8_Inject_MapInject_);
            return cb_inject_Lcom_mob_tools_java8_Inject_MapInject_;
        }

        static IntPtr n_Inject_Lcom_mob_tools_java8_Inject_MapInject_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.IInjectMapInject fun = (global::Com.Mob.Tools.Java8.IInjectMapInject)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IInjectMapInject>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Inject(fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='inject' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Inject.MapInject&lt;K, V, R&gt;']]"
        [Register("inject", "(Lcom/mob/tools/java8/Inject$MapInject;)Ljava/lang/Object;", "GetInject_Lcom_mob_tools_java8_Inject_MapInject_Handler")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "R" })]
        public virtual unsafe global::Java.Lang.Object Inject(global::Com.Mob.Tools.Java8.IInjectMapInject fun)
        {
            const string __id = "inject.(Lcom/mob/tools/java8/Inject$MapInject;)Ljava/lang/Object;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_;
#pragma warning disable 0169
        static Delegate GetInject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_Handler()
        {
            if (cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_ == null)
                cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_);
            return cb_inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_;
        }

        static IntPtr n_Inject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_(IntPtr jnienv, IntPtr native__this, IntPtr native_identity, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Object identity = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_identity, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.IInjectMapInject fun = (global::Com.Mob.Tools.Java8.IInjectMapInject)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IInjectMapInject>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Inject(identity, fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='inject' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.mob.tools.java8.Inject.MapInject&lt;K, V, R&gt;']]"
        [Register("inject", "(Ljava/lang/Object;Lcom/mob/tools/java8/Inject$MapInject;)Ljava/lang/Object;", "GetInject_Ljava_lang_Object_Lcom_mob_tools_java8_Inject_MapInject_Handler")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "R" })]
        public virtual unsafe global::Java.Lang.Object Inject(global::Java.Lang.Object identity, global::Com.Mob.Tools.Java8.IInjectMapInject fun)
        {
            const string __id = "inject.(Ljava/lang/Object;Lcom/mob/tools/java8/Inject$MapInject;)Ljava/lang/Object;";
            IntPtr native_identity = JNIEnv.ToLocalJniHandle(identity);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_identity);
                __args[1] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_identity);
            }
        }

        static Delegate cb_last;
#pragma warning disable 0169
        static Delegate GetLastHandler()
        {
            if (cb_last == null)
                cb_last = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_Last);
            return cb_last;
        }

        static IntPtr n_Last(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Last());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='last' and count(parameter)=0]"
        [Register("last", "()Lcom/mob/tools/java8/Optional;", "GetLastHandler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.Optional Last()
        {
            const string __id = "last.()Lcom/mob/tools/java8/Optional;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.Optional>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_limit_I;
#pragma warning disable 0169
        static Delegate GetLimit_IHandler()
        {
            if (cb_limit_I == null)
                cb_limit_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Limit_I);
            return cb_limit_I;
        }

        static IntPtr n_Limit_I(IntPtr jnienv, IntPtr native__this, int limit)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Limit(limit));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("limit", "(I)Lcom/mob/tools/java8/MapFlow;", "GetLimit_IHandler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Limit(int limit)
        {
            const string __id = "limit.(I)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(limit);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_map_Lcom_mob_tools_java8_Map_MapMap_;
#pragma warning disable 0169
        static Delegate GetMap_Lcom_mob_tools_java8_Map_MapMap_Handler()
        {
            if (cb_map_Lcom_mob_tools_java8_Map_MapMap_ == null)
                cb_map_Lcom_mob_tools_java8_Map_MapMap_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Map_Lcom_mob_tools_java8_Map_MapMap_);
            return cb_map_Lcom_mob_tools_java8_Map_MapMap_;
        }

        static IntPtr n_Map_Lcom_mob_tools_java8_Map_MapMap_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.IMapMapMap fun = (global::Com.Mob.Tools.Java8.IMapMapMap)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapMap>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Map(fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Map.MapMap&lt;K, V, R&gt;']]"
        [Register("map", "(Lcom/mob/tools/java8/Map$MapMap;)Lcom/mob/tools/java8/MapFlow;", "GetMap_Lcom_mob_tools_java8_Map_MapMap_Handler")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "R" })]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Map(global::Com.Mob.Tools.Java8.IMapMapMap fun)
        {
            const string __id = "map.(Lcom/mob/tools/java8/Map$MapMap;)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_mapKey_Lcom_mob_tools_java8_Map_MapMap_;
#pragma warning disable 0169
        static Delegate GetMapKey_Lcom_mob_tools_java8_Map_MapMap_Handler()
        {
            if (cb_mapKey_Lcom_mob_tools_java8_Map_MapMap_ == null)
                cb_mapKey_Lcom_mob_tools_java8_Map_MapMap_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_MapKey_Lcom_mob_tools_java8_Map_MapMap_);
            return cb_mapKey_Lcom_mob_tools_java8_Map_MapMap_;
        }

        static IntPtr n_MapKey_Lcom_mob_tools_java8_Map_MapMap_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.IMapMapMap fun = (global::Com.Mob.Tools.Java8.IMapMapMap)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IMapMapMap>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.MapKey(fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='mapKey' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Map.MapMap&lt;K, V, U&gt;']]"
        [Register("mapKey", "(Lcom/mob/tools/java8/Map$MapMap;)Lcom/mob/tools/java8/MapFlow;", "GetMapKey_Lcom_mob_tools_java8_Map_MapMap_Handler")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "U" })]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow MapKey(global::Com.Mob.Tools.Java8.IMapMapMap fun)
        {
            const string __id = "mapKey.(Lcom/mob/tools/java8/Map$MapMap;)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_peek_Lcom_mob_tools_java8_Peek_MapPeek_;
#pragma warning disable 0169
        static Delegate GetPeek_Lcom_mob_tools_java8_Peek_MapPeek_Handler()
        {
            if (cb_peek_Lcom_mob_tools_java8_Peek_MapPeek_ == null)
                cb_peek_Lcom_mob_tools_java8_Peek_MapPeek_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Peek_Lcom_mob_tools_java8_Peek_MapPeek_);
            return cb_peek_Lcom_mob_tools_java8_Peek_MapPeek_;
        }

        static IntPtr n_Peek_Lcom_mob_tools_java8_Peek_MapPeek_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mob.Tools.Java8.IPeekMapPeek fun = (global::Com.Mob.Tools.Java8.IPeekMapPeek)global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.IPeekMapPeek>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Peek(fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='com.mob.tools.java8.Peek.MapPeek&lt;K, V&gt;']]"
        [Register("peek", "(Lcom/mob/tools/java8/Peek$MapPeek;)Lcom/mob/tools/java8/MapFlow;", "GetPeek_Lcom_mob_tools_java8_Peek_MapPeek_Handler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Peek(global::Com.Mob.Tools.Java8.IPeekMapPeek fun)
        {
            const string __id = "peek.(Lcom/mob/tools/java8/Peek$MapPeek;)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_skip_I;
#pragma warning disable 0169
        static Delegate GetSkip_IHandler()
        {
            if (cb_skip_I == null)
                cb_skip_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)n_Skip_I);
            return cb_skip_I;
        }

        static IntPtr n_Skip_I(IntPtr jnienv, IntPtr native__this, int skip)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Skip(skip));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("skip", "(I)Lcom/mob/tools/java8/MapFlow;", "GetSkip_IHandler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Skip(int skip)
        {
            const string __id = "skip.(I)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(skip);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_sort;
#pragma warning disable 0169
        static Delegate GetSortHandler()
        {
            if (cb_sort == null)
                cb_sort = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_Sort);
            return cb_sort;
        }

        static IntPtr n_Sort(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.Sort());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='sort' and count(parameter)=0]"
        [Register("sort", "()Lcom/mob/tools/java8/MapFlow;", "GetSortHandler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Sort()
        {
            const string __id = "sort.()Lcom/mob/tools/java8/MapFlow;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_sort_Ljava_util_Comparator_;
#pragma warning disable 0169
        static Delegate GetSort_Ljava_util_Comparator_Handler()
        {
            if (cb_sort_Ljava_util_Comparator_ == null)
                cb_sort_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Sort_Ljava_util_Comparator_);
            return cb_sort_Ljava_util_Comparator_;
        }

        static IntPtr n_Sort_Ljava_util_Comparator_(IntPtr jnienv, IntPtr native__this, IntPtr native_fun)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Util.IComparator fun = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator>(native_fun, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Sort(fun));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='sort' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;K&gt;']]"
        [Register("sort", "(Ljava/util/Comparator;)Lcom/mob/tools/java8/MapFlow;", "GetSort_Ljava_util_Comparator_Handler")]
        public virtual unsafe global::Com.Mob.Tools.Java8.MapFlow Sort(global::Java.Util.IComparator fun)
        {
            const string __id = "sort.(Ljava/util/Comparator;)Lcom/mob/tools/java8/MapFlow;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((fun == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fun).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_toMap;
#pragma warning disable 0169
        static Delegate GetToMapHandler()
        {
            if (cb_toMap == null)
                cb_toMap = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_ToMap);
            return cb_toMap;
        }

        static IntPtr n_ToMap(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Mob.Tools.Java8.MapFlow __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaDictionary.ToLocalJniHandle(__this.ToMap());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/class[@name='MapFlow']/method[@name='toMap' and count(parameter)=0]"
        [Register("toMap", "()Ljava/util/Map;", "GetToMapHandler")]
        public virtual unsafe global::System.Collections.IDictionary ToMap()
        {
            const string __id = "toMap.()Ljava/util/Map;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Android.Runtime.JavaDictionary.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

    }

    // Metadata.xml XPath interface reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.MapCollect']"
    [Register("com/mob/tools/java8/Collect$MapCollect", "", "Com.Mob.Tools.Java8.ICollectMapCollectInvoker")]
    [global::Java.Interop.JavaTypeParameters(new string[] { "K", "V", "U", "R" })]
    public partial interface ICollectMapCollect : IJavaObject
    {

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mob.tools.java8']/interface[@name='Collect.MapCollect']/method[@name='collect' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
        [Register("collect", "(Ljava/lang/Object;Ljava/lang/Object;)Lcom/mob/tools/java8/MapFlow;", "GetCollect_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Mob.Tools.Java8.ICollectMapCollectInvoker, SMSSDK_Bind")]
        global::Com.Mob.Tools.Java8.MapFlow Collect(global::Java.Lang.Object p0, global::Java.Lang.Object p1);

    }

    [global::Android.Runtime.Register("com/mob/tools/java8/Collect$MapCollect", DoNotGenerateAcw = true)]
    internal class ICollectMapCollectInvoker : global::Java.Lang.Object, ICollectMapCollect
    {

        internal new static readonly JniPeerMembers _members = new JniPeerMembers("com/mob/tools/java8/Collect$MapCollect", typeof(ICollectMapCollectInvoker));

        static IntPtr java_class_ref
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        IntPtr class_ref;

        public static ICollectMapCollect GetObject(IntPtr handle, JniHandleOwnership transfer)
        {
            return global::Java.Lang.Object.GetObject<ICollectMapCollect>(handle, transfer);
        }

        static IntPtr Validate(IntPtr handle)
        {
            if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                            JNIEnv.GetClassNameFromInstance(handle), "com.mob.tools.java8.Collect.MapCollect"));
            return handle;
        }

        protected override void Dispose(bool disposing)
        {
            if (this.class_ref != IntPtr.Zero)
                JNIEnv.DeleteGlobalRef(this.class_ref);
            this.class_ref = IntPtr.Zero;
            base.Dispose(disposing);
        }

        public ICollectMapCollectInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
        {
            IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
            this.class_ref = JNIEnv.NewGlobalRef(local_ref);
            JNIEnv.DeleteLocalRef(local_ref);
        }

        static Delegate cb_collect_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetCollect_Ljava_lang_Object_Ljava_lang_Object_Handler()
        {
            if (cb_collect_Ljava_lang_Object_Ljava_lang_Object_ == null)
                cb_collect_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Collect_Ljava_lang_Object_Ljava_lang_Object_);
            return cb_collect_Ljava_lang_Object_Ljava_lang_Object_;
        }

        static IntPtr n_Collect_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
        {
            global::Com.Mob.Tools.Java8.ICollectMapCollect __this = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.ICollectMapCollect>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Collect(p0, p1));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_collect_Ljava_lang_Object_Ljava_lang_Object_;
        public unsafe global::Com.Mob.Tools.Java8.MapFlow Collect(global::Java.Lang.Object p0, global::Java.Lang.Object p1)
        {
            if (id_collect_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
                id_collect_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "collect", "(Ljava/lang/Object;Ljava/lang/Object;)Lcom/mob/tools/java8/MapFlow;");
            IntPtr native_p0 = JNIEnv.ToLocalJniHandle(p0);
            IntPtr native_p1 = JNIEnv.ToLocalJniHandle(p1);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(native_p1);
            global::Com.Mob.Tools.Java8.MapFlow __ret = global::Java.Lang.Object.GetObject<global::Com.Mob.Tools.Java8.MapFlow>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_collect_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_p0);
            JNIEnv.DeleteLocalRef(native_p1);
            return __ret;
        }

    }

}
