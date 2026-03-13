using System;
using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.Interop.RegistrationPolicies;

namespace MoonSharp.Interpreter.Interop.UserDataRegistries
{
	// Token: 0x020000BF RID: 191
	internal static class TypeDescriptorRegistry
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x0000DED9 File Offset: 0x0000C0D9
		internal static void RegisterAssembly(Assembly asm = null, bool includeExtensionTypes = false)
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0000DEDB File Offset: 0x0000C0DB
		internal static bool IsTypeRegistered(Type type)
		{
			return false;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0000DEDE File Offset: 0x0000C0DE
		internal static void UnregisterType(Type t, bool deleteHistory = false)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00010478 File Offset: 0x0000E678
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		internal static InteropAccessMode DefaultAccessMode
		{
			get
			{
				return InteropAccessMode.Reflection;
			}
			set
			{
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0000DEE2 File Offset: 0x0000C0E2
		internal static IUserDataDescriptor RegisterProxyType_Impl(IProxyFactory proxyFactory, InteropAccessMode accessMode, string friendlyName)
		{
			return null;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0000DEE5 File Offset: 0x0000C0E5
		internal static IUserDataDescriptor RegisterType_Impl(Type type, InteropAccessMode accessMode, string friendlyName, IUserDataDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		private static IUserDataDescriptor PerformRegistration(Type type, IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor, bool deleteHistory = false)
		{
			return null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00010490 File Offset: 0x0000E690
		internal static InteropAccessMode ResolveDefaultAccessModeForType(InteropAccessMode accessMode, Type type)
		{
			return InteropAccessMode.Reflection;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0000DEEB File Offset: 0x0000C0EB
		internal static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces)
		{
			return null;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0000DEEE File Offset: 0x0000C0EE
		private static bool FrameworkIsAssignableFrom(Type type)
		{
			return false;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0000DEF1 File Offset: 0x0000C0F1
		public static bool IsTypeBlacklisted(Type t)
		{
			return false;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0000DEF7 File Offset: 0x0000C0F7
		public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypesHistory
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0000DEFA File Offset: 0x0000C0FA
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x0000DF01 File Offset: 0x0000C101
		internal static IRegistrationPolicy RegistrationPolicy
		{
			get
			{
				return TypeDescriptorRegistry.<RegistrationPolicy>k__BackingField;
			}
			set
			{
				TypeDescriptorRegistry.<RegistrationPolicy>k__BackingField = value;
			}
		}

		// Token: 0x0400036C RID: 876
		private static object s_Lock;

		// Token: 0x0400036D RID: 877
		private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistry;

		// Token: 0x0400036E RID: 878
		private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistryHistory;

		// Token: 0x0400036F RID: 879
		private static InteropAccessMode s_DefaultAccessMode;

		// Token: 0x04000370 RID: 880
		private static IRegistrationPolicy <RegistrationPolicy>k__BackingField;

		// Token: 0x020001BD RID: 445
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000FFE RID: 4094 RVA: 0x0000F617 File Offset: 0x0000D817
			internal <>f__AnonymousType0<Type, Attribute[]> <RegisterAssembly>b__4_3(Type t)
			{
				return null;
			}

			// Token: 0x06000FFF RID: 4095 RVA: 0x0000F61A File Offset: 0x0000D81A
			internal bool <RegisterAssembly>b__4_4(<>f__AnonymousType0<Type, Attribute[]> <>h__TransparentIdentifier0)
			{
				return false;
			}

			// Token: 0x06001000 RID: 4096 RVA: 0x0000F61D File Offset: 0x0000D81D
			internal <>f__AnonymousType1<Attribute[], Type> <RegisterAssembly>b__4_5(<>f__AnonymousType0<Type, Attribute[]> <>h__TransparentIdentifier0)
			{
				return null;
			}

			// Token: 0x06001001 RID: 4097 RVA: 0x0000F620 File Offset: 0x0000D820
			internal <>f__AnonymousType0<Type, Attribute[]> <RegisterAssembly>b__4_0(Type t)
			{
				return null;
			}

			// Token: 0x06001002 RID: 4098 RVA: 0x0000F623 File Offset: 0x0000D823
			internal bool <RegisterAssembly>b__4_1(<>f__AnonymousType0<Type, Attribute[]> <>h__TransparentIdentifier0)
			{
				return false;
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x0000F626 File Offset: 0x0000D826
			internal <>f__AnonymousType1<Attribute[], Type> <RegisterAssembly>b__4_2(<>f__AnonymousType0<Type, Attribute[]> <>h__TransparentIdentifier0)
			{
				return null;
			}

			// Token: 0x06001004 RID: 4100 RVA: 0x0000F629 File Offset: 0x0000D829
			internal bool <RegisterType_Impl>b__11_0(Type ii)
			{
				return false;
			}

			// Token: 0x040006DE RID: 1758
			public static readonly TypeDescriptorRegistry.<>c <>9;

			// Token: 0x040006DF RID: 1759
			public static Func<Type, <>f__AnonymousType0<Type, Attribute[]>> <>9__4_3;

			// Token: 0x040006E0 RID: 1760
			public static Func<<>f__AnonymousType0<Type, Attribute[]>, bool> <>9__4_4;

			// Token: 0x040006E1 RID: 1761
			public static Func<<>f__AnonymousType0<Type, Attribute[]>, <>f__AnonymousType1<Attribute[], Type>> <>9__4_5;

			// Token: 0x040006E2 RID: 1762
			public static Func<Type, <>f__AnonymousType0<Type, Attribute[]>> <>9__4_0;

			// Token: 0x040006E3 RID: 1763
			public static Func<<>f__AnonymousType0<Type, Attribute[]>, bool> <>9__4_1;

			// Token: 0x040006E4 RID: 1764
			public static Func<<>f__AnonymousType0<Type, Attribute[]>, <>f__AnonymousType1<Attribute[], Type>> <>9__4_2;

			// Token: 0x040006E5 RID: 1765
			public static Func<Type, bool> <>9__11_0;
		}

		// Token: 0x020001BE RID: 446
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06001006 RID: 4102 RVA: 0x0000F634 File Offset: 0x0000D834
			internal void <RegisterType_Impl>b__1(object o)
			{
			}

			// Token: 0x040006E6 RID: 1766
			public StandardUserDataDescriptor udd;
		}
	}
}
