using System;
using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop.UserDataRegistries
{
	// Token: 0x020000BE RID: 190
	internal class ExtensionMethodsRegistry
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x0000DEBB File Offset: 0x0000C0BB
		public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0000DEBD File Offset: 0x0000C0BD
		private static object FrameworkGetMethods()
		{
			return null;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		public static IEnumerable<IOverloadableMemberDescriptor> GetExtensionMethodsByName(string name)
		{
			return null;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0000DEC3 File Offset: 0x0000C0C3
		public static int GetExtensionMethodsChangeVersion()
		{
			return 0;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0000DEC6 File Offset: 0x0000C0C6
		public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType)
		{
			return null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0000DEC9 File Offset: 0x0000C0C9
		private static MethodInfo InstantiateMethodInfo(MethodInfo mi, Type extensionType, Type genericType, Type extendedType)
		{
			return null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0000DECC File Offset: 0x0000C0CC
		private static Type GetGenericMatch(Type extensionType, Type extendedType)
		{
			return null;
		}

		// Token: 0x04000368 RID: 872
		private static object s_Lock;

		// Token: 0x04000369 RID: 873
		private static MultiDictionary<string, IOverloadableMemberDescriptor> s_Registry;

		// Token: 0x0400036A RID: 874
		private static MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod> s_UnresolvedGenericsRegistry;

		// Token: 0x0400036B RID: 875
		private static int s_ExtensionMethodChangeVersion;

		// Token: 0x020001BA RID: 442
		private class UnresolvedGenericMethod
		{
			// Token: 0x06000FF6 RID: 4086 RVA: 0x0000F5ED File Offset: 0x0000D7ED
			public UnresolvedGenericMethod(MethodInfo mi, InteropAccessMode mode)
			{
			}

			// Token: 0x040006D8 RID: 1752
			public readonly MethodInfo Method;

			// Token: 0x040006D9 RID: 1753
			public readonly InteropAccessMode AccessMode;

			// Token: 0x040006DA RID: 1754
			public readonly HashSet<Type> AlreadyAddedTypes;
		}

		// Token: 0x020001BB RID: 443
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000FF9 RID: 4089 RVA: 0x0000F5FF File Offset: 0x0000D7FF
			internal bool <RegisterExtensionType>b__5_0(MethodInfo _mi)
			{
				return false;
			}

			// Token: 0x040006DB RID: 1755
			public static readonly ExtensionMethodsRegistry.<>c <>9;

			// Token: 0x040006DC RID: 1756
			public static Func<MethodInfo, bool> <>9__5_0;
		}

		// Token: 0x020001BC RID: 444
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06000FFB RID: 4091 RVA: 0x0000F60A File Offset: 0x0000D80A
			internal bool <GetExtensionMethodsByNameAndType>b__0(IOverloadableMemberDescriptor d)
			{
				return false;
			}

			// Token: 0x040006DD RID: 1757
			public Type extendedType;
		}
	}
}
