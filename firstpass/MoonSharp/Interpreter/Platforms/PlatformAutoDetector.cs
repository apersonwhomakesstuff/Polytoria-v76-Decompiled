using System;
using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.Loaders;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008C RID: 140
	public static class PlatformAutoDetector
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0000D734 File Offset: 0x0000B934
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0000D73B File Offset: 0x0000B93B
		public static bool IsRunningOnMono
		{
			get
			{
				return PlatformAutoDetector.<IsRunningOnMono>k__BackingField;
			}
			private set
			{
				PlatformAutoDetector.<IsRunningOnMono>k__BackingField = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0000D743 File Offset: 0x0000B943
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0000D74A File Offset: 0x0000B94A
		public static bool IsRunningOnClr4
		{
			get
			{
				return PlatformAutoDetector.<IsRunningOnClr4>k__BackingField;
			}
			private set
			{
				PlatformAutoDetector.<IsRunningOnClr4>k__BackingField = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0000D752 File Offset: 0x0000B952
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0000D759 File Offset: 0x0000B959
		public static bool IsRunningOnUnity
		{
			get
			{
				return PlatformAutoDetector.<IsRunningOnUnity>k__BackingField;
			}
			private set
			{
				PlatformAutoDetector.<IsRunningOnUnity>k__BackingField = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0000D761 File Offset: 0x0000B961
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0000D768 File Offset: 0x0000B968
		public static bool IsPortableFramework
		{
			get
			{
				return PlatformAutoDetector.<IsPortableFramework>k__BackingField;
			}
			private set
			{
				PlatformAutoDetector.<IsPortableFramework>k__BackingField = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0000D770 File Offset: 0x0000B970
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0000D777 File Offset: 0x0000B977
		public static bool IsUnityNative
		{
			get
			{
				return PlatformAutoDetector.<IsUnityNative>k__BackingField;
			}
			private set
			{
				PlatformAutoDetector.<IsUnityNative>k__BackingField = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0000D77F File Offset: 0x0000B97F
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0000D786 File Offset: 0x0000B986
		public static bool IsUnityIL2CPP
		{
			get
			{
				return PlatformAutoDetector.<IsUnityIL2CPP>k__BackingField;
			}
			private set
			{
				PlatformAutoDetector.<IsUnityIL2CPP>k__BackingField = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0000D78E File Offset: 0x0000B98E
		public static bool IsRunningOnAOT
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0000D791 File Offset: 0x0000B991
		private static void AutoDetectPlatformFlags()
		{
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000D793 File Offset: 0x0000B993
		internal static IPlatformAccessor GetDefaultPlatform()
		{
			return null;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000D796 File Offset: 0x0000B996
		internal static IScriptLoader GetDefaultScriptLoader()
		{
			return null;
		}

		// Token: 0x040002CF RID: 719
		private static bool? m_IsRunningOnAOT;

		// Token: 0x040002D0 RID: 720
		private static bool m_AutoDetectionsDone;

		// Token: 0x040002D1 RID: 721
		private static bool <IsRunningOnMono>k__BackingField;

		// Token: 0x040002D2 RID: 722
		private static bool <IsRunningOnClr4>k__BackingField;

		// Token: 0x040002D3 RID: 723
		private static bool <IsRunningOnUnity>k__BackingField;

		// Token: 0x040002D4 RID: 724
		private static bool <IsPortableFramework>k__BackingField;

		// Token: 0x040002D5 RID: 725
		private static bool <IsUnityNative>k__BackingField;

		// Token: 0x040002D6 RID: 726
		private static bool <IsUnityIL2CPP>k__BackingField;

		// Token: 0x02000193 RID: 403
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F48 RID: 3912 RVA: 0x0000F452 File Offset: 0x0000D652
			internal IEnumerable<Type> <AutoDetectPlatformFlags>b__28_0(Assembly a)
			{
				return null;
			}

			// Token: 0x06000F49 RID: 3913 RVA: 0x0000F455 File Offset: 0x0000D655
			internal bool <AutoDetectPlatformFlags>b__28_1(Type t)
			{
				return false;
			}

			// Token: 0x04000685 RID: 1669
			public static readonly PlatformAutoDetector.<>c <>9;

			// Token: 0x04000686 RID: 1670
			public static Func<Assembly, IEnumerable<Type>> <>9__28_0;

			// Token: 0x04000687 RID: 1671
			public static Func<Type, bool> <>9__28_1;
		}
	}
}
