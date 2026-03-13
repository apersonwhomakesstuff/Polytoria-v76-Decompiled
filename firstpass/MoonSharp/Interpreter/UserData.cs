using System;
using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using MoonSharp.Interpreter.Interop.RegistrationPolicies;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003A RID: 58
	public class UserData : RefIdObject
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x0000CC51 File Offset: 0x0000AE51
		private UserData()
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0000CC59 File Offset: 0x0000AE59
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x0000CC61 File Offset: 0x0000AE61
		public DynValue UserValue
		{
			get
			{
				return this.<UserValue>k__BackingField;
			}
			set
			{
				this.<UserValue>k__BackingField = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0000CC6A File Offset: 0x0000AE6A
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x0000CC72 File Offset: 0x0000AE72
		public object Object
		{
			get
			{
				return this.<Object>k__BackingField;
			}
			private set
			{
				this.<Object>k__BackingField = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0000CC7B File Offset: 0x0000AE7B
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0000CC83 File Offset: 0x0000AE83
		public IUserDataDescriptor Descriptor
		{
			get
			{
				return this.<Descriptor>k__BackingField;
			}
			private set
			{
				this.<Descriptor>k__BackingField = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0000CC8E File Offset: 0x0000AE8E
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0000CC91 File Offset: 0x0000AE91
		public Table MetaTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000CC93 File Offset: 0x0000AE93
		public static IUserDataDescriptor RegisterType<T>(InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null)
		{
			return null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000CC96 File Offset: 0x0000AE96
		public static IUserDataDescriptor RegisterType(Type type, InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null)
		{
			return null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000CC99 File Offset: 0x0000AE99
		public static IUserDataDescriptor RegisterProxyType(IProxyFactory proxyFactory, InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null)
		{
			return null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000CC9C File Offset: 0x0000AE9C
		public static IUserDataDescriptor RegisterProxyType<TProxy, TTarget>(Func<TTarget, TProxy> wrapDelegate, InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null) where TProxy : class where TTarget : class
		{
			return null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000CC9F File Offset: 0x0000AE9F
		public static IUserDataDescriptor RegisterType<T>(IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000CCA2 File Offset: 0x0000AEA2
		public static IUserDataDescriptor RegisterType(Type type, IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000CCA5 File Offset: 0x0000AEA5
		public static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		public static void RegisterAssembly(Assembly asm = null, bool includeExtensionTypes = false)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000CCAA File Offset: 0x0000AEAA
		public static bool IsTypeRegistered(Type t)
		{
			return false;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000CCAD File Offset: 0x0000AEAD
		public static bool IsTypeRegistered<T>()
		{
			return false;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
		public static void UnregisterType<T>(bool deleteHistory = false)
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000CCB2 File Offset: 0x0000AEB2
		public static void UnregisterType(Type t, bool deleteHistory = false)
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
		public static DynValue Create(object o, IUserDataDescriptor descr)
		{
			return null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000CCB7 File Offset: 0x0000AEB7
		public static DynValue Create(object o)
		{
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000CCBA File Offset: 0x0000AEBA
		public static DynValue CreateStatic(IUserDataDescriptor descr)
		{
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000CCBD File Offset: 0x0000AEBD
		public static DynValue CreateStatic(Type t)
		{
			return null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		public static DynValue CreateStatic<T>()
		{
			return null;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0000CCC3 File Offset: 0x0000AEC3
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x0000CCC6 File Offset: 0x0000AEC6
		public static IRegistrationPolicy RegistrationPolicy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x000102B0 File Offset: 0x0000E4B0
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		public static InteropAccessMode DefaultAccessMode
		{
			get
			{
				return InteropAccessMode.Reflection;
			}
			set
			{
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000CCCA File Offset: 0x0000AECA
		public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000CCCC File Offset: 0x0000AECC
		public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType)
		{
			return null;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000CCCF File Offset: 0x0000AECF
		public static int GetExtensionMethodsChangeVersion()
		{
			return 0;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000CCD2 File Offset: 0x0000AED2
		public static IUserDataDescriptor GetDescriptorForType<T>(bool searchInterfaces)
		{
			return null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000CCD5 File Offset: 0x0000AED5
		public static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces)
		{
			return null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		public static IUserDataDescriptor GetDescriptorForObject(object o)
		{
			return null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000CCDB File Offset: 0x0000AEDB
		public static Table GetDescriptionOfRegisteredTypes(bool useHistoricalData = false)
		{
			return null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000CCDE File Offset: 0x0000AEDE
		public static IEnumerable<Type> GetRegisteredTypes(bool useHistoricalData = false)
		{
			return null;
		}

		// Token: 0x040001A3 RID: 419
		private DynValue <UserValue>k__BackingField;

		// Token: 0x040001A4 RID: 420
		private object <Object>k__BackingField;

		// Token: 0x040001A5 RID: 421
		private IUserDataDescriptor <Descriptor>k__BackingField;

		// Token: 0x040001A6 RID: 422
		private Table m_MetaTable;

		// Token: 0x02000183 RID: 387
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F1E RID: 3870 RVA: 0x0000F398 File Offset: 0x0000D598
			internal Type <GetRegisteredTypes>b__48_0(KeyValuePair<Type, IUserDataDescriptor> p)
			{
				return null;
			}

			// Token: 0x04000652 RID: 1618
			public static readonly UserData.<>c <>9;

			// Token: 0x04000653 RID: 1619
			public static Func<KeyValuePair<Type, IUserDataDescriptor>, Type> <>9__48_0;
		}
	}
}
