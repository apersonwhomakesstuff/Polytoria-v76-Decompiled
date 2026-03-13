using System;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B9 RID: 185
	public class StandardEnumUserDataDescriptor : DispatchingUserDataDescriptor
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		public Type UnderlyingType
		{
			get
			{
				return this.<UnderlyingType>k__BackingField;
			}
			private set
			{
				this.<UnderlyingType>k__BackingField = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0000DDE1 File Offset: 0x0000BFE1
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x0000DDE9 File Offset: 0x0000BFE9
		public bool IsUnsigned
		{
			get
			{
				return this.<IsUnsigned>k__BackingField;
			}
			private set
			{
				this.<IsUnsigned>k__BackingField = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0000DDF2 File Offset: 0x0000BFF2
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0000DDFA File Offset: 0x0000BFFA
		public bool IsFlags
		{
			get
			{
				return this.<IsFlags>k__BackingField;
			}
			private set
			{
				this.<IsFlags>k__BackingField = value;
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0000DE03 File Offset: 0x0000C003
		public StandardEnumUserDataDescriptor(Type enumType, string friendlyName = null, string[] names = null, object[] values = null, Type underlyingType = null) : base(null, null)
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0000DE0D File Offset: 0x0000C00D
		private void FillMemberList(string[] names, object[] values)
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0000DE0F File Offset: 0x0000C00F
		private void AddEnumMethod(string name, DynValue dynValue)
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0000DE11 File Offset: 0x0000C011
		private long GetValueSigned(DynValue dv)
		{
			return 0L;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0000DE15 File Offset: 0x0000C015
		private ulong GetValueUnsigned(DynValue dv)
		{
			return (ulong)0;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0000DE19 File Offset: 0x0000C019
		private DynValue CreateValueSigned(long value)
		{
			return null;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0000DE1C File Offset: 0x0000C01C
		private DynValue CreateValueUnsigned(ulong value)
		{
			return null;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0000DE1F File Offset: 0x0000C01F
		private void CreateSignedConversionFunctions()
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0000DE21 File Offset: 0x0000C021
		private void CreateUnsignedConversionFunctions()
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0000DE23 File Offset: 0x0000C023
		private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, DynValue> operation)
		{
			return null;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0000DE26 File Offset: 0x0000C026
		private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, DynValue> operation)
		{
			return null;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0000DE29 File Offset: 0x0000C029
		private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, long> operation)
		{
			return null;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0000DE2C File Offset: 0x0000C02C
		private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, ulong> operation)
		{
			return null;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0000DE2F File Offset: 0x0000C02F
		private DynValue PerformUnaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long> operation)
		{
			return null;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0000DE32 File Offset: 0x0000C032
		private DynValue PerformUnaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong> operation)
		{
			return null;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0000DE35 File Offset: 0x0000C035
		internal DynValue Callback_Or(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0000DE38 File Offset: 0x0000C038
		internal DynValue Callback_And(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0000DE3B File Offset: 0x0000C03B
		internal DynValue Callback_Xor(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0000DE3E File Offset: 0x0000C03E
		internal DynValue Callback_BwNot(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0000DE41 File Offset: 0x0000C041
		internal DynValue Callback_HasAll(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0000DE44 File Offset: 0x0000C044
		internal DynValue Callback_HasAny(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0000DE47 File Offset: 0x0000C047
		public override bool IsTypeCompatible(Type type, object obj)
		{
			return false;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0000DE4A File Offset: 0x0000C04A
		public override DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		// Token: 0x04000357 RID: 855
		private Type <UnderlyingType>k__BackingField;

		// Token: 0x04000358 RID: 856
		private bool <IsUnsigned>k__BackingField;

		// Token: 0x04000359 RID: 857
		private bool <IsFlags>k__BackingField;

		// Token: 0x0400035A RID: 858
		private Func<object, ulong> m_EnumToULong;

		// Token: 0x0400035B RID: 859
		private Func<ulong, object> m_ULongToEnum;

		// Token: 0x0400035C RID: 860
		private Func<object, long> m_EnumToLong;

		// Token: 0x0400035D RID: 861
		private Func<long, object> m_LongToEnum;

		// Token: 0x020001B6 RID: 438
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000FD3 RID: 4051 RVA: 0x0000F566 File Offset: 0x0000D766
			internal long <CreateSignedConversionFunctions>b__23_0(object o)
			{
				return 0L;
			}

			// Token: 0x06000FD4 RID: 4052 RVA: 0x0000F56A File Offset: 0x0000D76A
			internal object <CreateSignedConversionFunctions>b__23_1(long o)
			{
				return null;
			}

			// Token: 0x06000FD5 RID: 4053 RVA: 0x0000F56D File Offset: 0x0000D76D
			internal long <CreateSignedConversionFunctions>b__23_2(object o)
			{
				return 0L;
			}

			// Token: 0x06000FD6 RID: 4054 RVA: 0x0000F571 File Offset: 0x0000D771
			internal object <CreateSignedConversionFunctions>b__23_3(long o)
			{
				return null;
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x0000F574 File Offset: 0x0000D774
			internal long <CreateSignedConversionFunctions>b__23_4(object o)
			{
				return 0L;
			}

			// Token: 0x06000FD8 RID: 4056 RVA: 0x0000F578 File Offset: 0x0000D778
			internal object <CreateSignedConversionFunctions>b__23_5(long o)
			{
				return null;
			}

			// Token: 0x06000FD9 RID: 4057 RVA: 0x0000F57B File Offset: 0x0000D77B
			internal long <CreateSignedConversionFunctions>b__23_6(object o)
			{
				return 0L;
			}

			// Token: 0x06000FDA RID: 4058 RVA: 0x0000F57F File Offset: 0x0000D77F
			internal object <CreateSignedConversionFunctions>b__23_7(long o)
			{
				return null;
			}

			// Token: 0x06000FDB RID: 4059 RVA: 0x0000F582 File Offset: 0x0000D782
			internal ulong <CreateUnsignedConversionFunctions>b__24_0(object o)
			{
				return (ulong)0;
			}

			// Token: 0x06000FDC RID: 4060 RVA: 0x0000F586 File Offset: 0x0000D786
			internal object <CreateUnsignedConversionFunctions>b__24_1(ulong o)
			{
				return null;
			}

			// Token: 0x06000FDD RID: 4061 RVA: 0x0000F589 File Offset: 0x0000D789
			internal ulong <CreateUnsignedConversionFunctions>b__24_2(object o)
			{
				return (ulong)0;
			}

			// Token: 0x06000FDE RID: 4062 RVA: 0x0000F58D File Offset: 0x0000D78D
			internal object <CreateUnsignedConversionFunctions>b__24_3(ulong o)
			{
				return null;
			}

			// Token: 0x06000FDF RID: 4063 RVA: 0x0000F590 File Offset: 0x0000D790
			internal ulong <CreateUnsignedConversionFunctions>b__24_4(object o)
			{
				return (ulong)0;
			}

			// Token: 0x06000FE0 RID: 4064 RVA: 0x0000F594 File Offset: 0x0000D794
			internal object <CreateUnsignedConversionFunctions>b__24_5(ulong o)
			{
				return null;
			}

			// Token: 0x06000FE1 RID: 4065 RVA: 0x0000F597 File Offset: 0x0000D797
			internal ulong <CreateUnsignedConversionFunctions>b__24_6(object o)
			{
				return (ulong)0;
			}

			// Token: 0x06000FE2 RID: 4066 RVA: 0x0000F59B File Offset: 0x0000D79B
			internal object <CreateUnsignedConversionFunctions>b__24_7(ulong o)
			{
				return null;
			}

			// Token: 0x06000FE3 RID: 4067 RVA: 0x0000F59E File Offset: 0x0000D79E
			internal ulong <Callback_Or>b__31_0(ulong v1, ulong v2)
			{
				return (ulong)0;
			}

			// Token: 0x06000FE4 RID: 4068 RVA: 0x0000F5A2 File Offset: 0x0000D7A2
			internal long <Callback_Or>b__31_1(long v1, long v2)
			{
				return 0L;
			}

			// Token: 0x06000FE5 RID: 4069 RVA: 0x0000F5A6 File Offset: 0x0000D7A6
			internal ulong <Callback_And>b__32_0(ulong v1, ulong v2)
			{
				return (ulong)0;
			}

			// Token: 0x06000FE6 RID: 4070 RVA: 0x0000F5AA File Offset: 0x0000D7AA
			internal long <Callback_And>b__32_1(long v1, long v2)
			{
				return 0L;
			}

			// Token: 0x06000FE7 RID: 4071 RVA: 0x0000F5AE File Offset: 0x0000D7AE
			internal ulong <Callback_Xor>b__33_0(ulong v1, ulong v2)
			{
				return (ulong)0;
			}

			// Token: 0x06000FE8 RID: 4072 RVA: 0x0000F5B2 File Offset: 0x0000D7B2
			internal long <Callback_Xor>b__33_1(long v1, long v2)
			{
				return 0L;
			}

			// Token: 0x06000FE9 RID: 4073 RVA: 0x0000F5B6 File Offset: 0x0000D7B6
			internal ulong <Callback_BwNot>b__34_0(ulong v1)
			{
				return (ulong)0;
			}

			// Token: 0x06000FEA RID: 4074 RVA: 0x0000F5BA File Offset: 0x0000D7BA
			internal long <Callback_BwNot>b__34_1(long v1)
			{
				return 0L;
			}

			// Token: 0x06000FEB RID: 4075 RVA: 0x0000F5BE File Offset: 0x0000D7BE
			internal DynValue <Callback_HasAll>b__35_0(ulong v1, ulong v2)
			{
				return null;
			}

			// Token: 0x06000FEC RID: 4076 RVA: 0x0000F5C1 File Offset: 0x0000D7C1
			internal DynValue <Callback_HasAll>b__35_1(long v1, long v2)
			{
				return null;
			}

			// Token: 0x06000FED RID: 4077 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
			internal DynValue <Callback_HasAny>b__36_0(ulong v1, ulong v2)
			{
				return null;
			}

			// Token: 0x06000FEE RID: 4078 RVA: 0x0000F5C7 File Offset: 0x0000D7C7
			internal DynValue <Callback_HasAny>b__36_1(long v1, long v2)
			{
				return null;
			}

			// Token: 0x040006B5 RID: 1717
			public static readonly StandardEnumUserDataDescriptor.<>c <>9;

			// Token: 0x040006B6 RID: 1718
			public static Func<object, long> <>9__23_0;

			// Token: 0x040006B7 RID: 1719
			public static Func<long, object> <>9__23_1;

			// Token: 0x040006B8 RID: 1720
			public static Func<object, long> <>9__23_2;

			// Token: 0x040006B9 RID: 1721
			public static Func<long, object> <>9__23_3;

			// Token: 0x040006BA RID: 1722
			public static Func<object, long> <>9__23_4;

			// Token: 0x040006BB RID: 1723
			public static Func<long, object> <>9__23_5;

			// Token: 0x040006BC RID: 1724
			public static Func<object, long> <>9__23_6;

			// Token: 0x040006BD RID: 1725
			public static Func<long, object> <>9__23_7;

			// Token: 0x040006BE RID: 1726
			public static Func<object, ulong> <>9__24_0;

			// Token: 0x040006BF RID: 1727
			public static Func<ulong, object> <>9__24_1;

			// Token: 0x040006C0 RID: 1728
			public static Func<object, ulong> <>9__24_2;

			// Token: 0x040006C1 RID: 1729
			public static Func<ulong, object> <>9__24_3;

			// Token: 0x040006C2 RID: 1730
			public static Func<object, ulong> <>9__24_4;

			// Token: 0x040006C3 RID: 1731
			public static Func<ulong, object> <>9__24_5;

			// Token: 0x040006C4 RID: 1732
			public static Func<object, ulong> <>9__24_6;

			// Token: 0x040006C5 RID: 1733
			public static Func<ulong, object> <>9__24_7;

			// Token: 0x040006C6 RID: 1734
			public static Func<ulong, ulong, ulong> <>9__31_0;

			// Token: 0x040006C7 RID: 1735
			public static Func<long, long, long> <>9__31_1;

			// Token: 0x040006C8 RID: 1736
			public static Func<ulong, ulong, ulong> <>9__32_0;

			// Token: 0x040006C9 RID: 1737
			public static Func<long, long, long> <>9__32_1;

			// Token: 0x040006CA RID: 1738
			public static Func<ulong, ulong, ulong> <>9__33_0;

			// Token: 0x040006CB RID: 1739
			public static Func<long, long, long> <>9__33_1;

			// Token: 0x040006CC RID: 1740
			public static Func<ulong, ulong> <>9__34_0;

			// Token: 0x040006CD RID: 1741
			public static Func<long, long> <>9__34_1;

			// Token: 0x040006CE RID: 1742
			public static Func<ulong, ulong, DynValue> <>9__35_0;

			// Token: 0x040006CF RID: 1743
			public static Func<long, long, DynValue> <>9__35_1;

			// Token: 0x040006D0 RID: 1744
			public static Func<ulong, ulong, DynValue> <>9__36_0;

			// Token: 0x040006D1 RID: 1745
			public static Func<long, long, DynValue> <>9__36_1;
		}

		// Token: 0x020001B7 RID: 439
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06000FF0 RID: 4080 RVA: 0x0000F5D2 File Offset: 0x0000D7D2
			internal DynValue <PerformBinaryOperationS>b__0(long v1, long v2)
			{
				return null;
			}

			// Token: 0x040006D2 RID: 1746
			public StandardEnumUserDataDescriptor <>4__this;

			// Token: 0x040006D3 RID: 1747
			public Func<long, long, long> operation;
		}

		// Token: 0x020001B8 RID: 440
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06000FF2 RID: 4082 RVA: 0x0000F5DD File Offset: 0x0000D7DD
			internal DynValue <PerformBinaryOperationU>b__0(ulong v1, ulong v2)
			{
				return null;
			}

			// Token: 0x040006D4 RID: 1748
			public StandardEnumUserDataDescriptor <>4__this;

			// Token: 0x040006D5 RID: 1749
			public Func<ulong, ulong, ulong> operation;
		}
	}
}
