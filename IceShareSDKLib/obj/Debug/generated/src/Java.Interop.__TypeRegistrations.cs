using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/mob/tools/java8",
						"com/mob/tools/mscript/commands",
						"com/sina/sso",
					},
					new Converter<string, Type>[]{
						lookup_com_mob_tools_java8_package,
						lookup_com_mob_tools_mscript_commands_package,
						lookup_com_sina_sso_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_mob_tools_java8_mappings;
		static Type lookup_com_mob_tools_java8_package (string klass)
		{
			if (package_com_mob_tools_java8_mappings == null) {
				package_com_mob_tools_java8_mappings = new string[]{
					"com/mob/tools/java8/FlowIterator$ArrayIterator:Com.Mob.Tools.Java8.FlowIteratorArrayIterator",
					"com/mob/tools/java8/FlowIterator$BufferedReaderIterator:Com.Mob.Tools.Java8.FlowIteratorBufferedReaderIterator",
					"com/mob/tools/java8/FlowIterator$EnumerationIterator:Com.Mob.Tools.Java8.FlowIteratorEnumerationIterator",
					"com/mob/tools/java8/FlowIterator$FileReaderIterator:Com.Mob.Tools.Java8.FlowIteratorFileReaderIterator",
					"com/mob/tools/java8/FlowIterator$IterableIterator:Com.Mob.Tools.Java8.FlowIteratorIterableIterator",
					"com/mob/tools/java8/FlowIterator$MapIterator:Com.Mob.Tools.Java8.FlowIteratorMapIterator",
					"com/mob/tools/java8/FlowIterator$PrimitiveArrayIterator:Com.Mob.Tools.Java8.FlowIteratorPrimitiveArrayIterator",
					"com/mob/tools/java8/FlowIterator$RangeIterator:Com.Mob.Tools.Java8.FlowIteratorRangeIterator",
				};
			}

			return Lookup (package_com_mob_tools_java8_mappings, klass);
		}

		static string[] package_com_mob_tools_mscript_commands_mappings;
		static Type lookup_com_mob_tools_mscript_commands_package (string klass)
		{
			if (package_com_mob_tools_mscript_commands_mappings == null) {
				package_com_mob_tools_mscript_commands_mappings = new string[]{
					"com/mob/tools/mscript/commands/If:Com.Mob.Tools.Mscript.Commands.If",
					"com/mob/tools/mscript/commands/Symbol$BinarySymbol:Com.Mob.Tools.Mscript.Commands.SymbolBinarySymbol",
					"com/mob/tools/mscript/commands/Symbol$UnarySymbol:Com.Mob.Tools.Mscript.Commands.SymbolUnarySymbol",
				};
			}

			return Lookup (package_com_mob_tools_mscript_commands_mappings, klass);
		}

		static string[] package_com_sina_sso_mappings;
		static Type lookup_com_sina_sso_package (string klass)
		{
			if (package_com_sina_sso_mappings == null) {
				package_com_sina_sso_mappings = new string[]{
					"com/sina/sso/RemoteSSO$Stub:Com.Sina.Sso.RemoteSSOStub",
				};
			}

			return Lookup (package_com_sina_sso_mappings, klass);
		}
	}
}
