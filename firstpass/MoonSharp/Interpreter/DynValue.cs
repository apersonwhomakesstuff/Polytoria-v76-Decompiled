using System;
using System.Text;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002E RID: 46
	public sealed class DynValue
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000CA1C File Offset: 0x0000AC1C
		public int ReferenceID
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x000101F0 File Offset: 0x0000E3F0
		public DataType Type
		{
			get
			{
				return DataType.Nil;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000CA1F File Offset: 0x0000AC1F
		public Closure Function
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000CA22 File Offset: 0x0000AC22
		public double Number
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000CA2D File Offset: 0x0000AC2D
		public DynValue[] Tuple
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000CA30 File Offset: 0x0000AC30
		public Coroutine Coroutine
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0000CA33 File Offset: 0x0000AC33
		public Table Table
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0000CA36 File Offset: 0x0000AC36
		public bool Boolean
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0000CA39 File Offset: 0x0000AC39
		public string String
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000CA3C File Offset: 0x0000AC3C
		public CallbackFunction Callback
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000CA3F File Offset: 0x0000AC3F
		public TailCallData TailCallData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000CA42 File Offset: 0x0000AC42
		public YieldRequest YieldRequest
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0000CA45 File Offset: 0x0000AC45
		public UserData UserData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000CA48 File Offset: 0x0000AC48
		public bool ReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000CA4B File Offset: 0x0000AC4B
		public static DynValue NewNil()
		{
			return null;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000CA4E File Offset: 0x0000AC4E
		public static DynValue NewBoolean(bool v)
		{
			return null;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000CA51 File Offset: 0x0000AC51
		public static DynValue NewNumber(double num)
		{
			return null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000CA54 File Offset: 0x0000AC54
		public static DynValue NewString(string str)
		{
			return null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000CA57 File Offset: 0x0000AC57
		public static DynValue NewString(StringBuilder sb)
		{
			return null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000CA5A File Offset: 0x0000AC5A
		public static DynValue NewString(string format, object[] args)
		{
			return null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000CA5D File Offset: 0x0000AC5D
		public static DynValue NewCoroutine(Coroutine coroutine)
		{
			return null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000CA60 File Offset: 0x0000AC60
		public static DynValue NewClosure(Closure function)
		{
			return null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000CA63 File Offset: 0x0000AC63
		public static DynValue NewCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name = null)
		{
			return null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000CA66 File Offset: 0x0000AC66
		public static DynValue NewCallback(CallbackFunction function)
		{
			return null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000CA69 File Offset: 0x0000AC69
		public static DynValue NewTable(Table table)
		{
			return null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		public static DynValue NewPrimeTable()
		{
			return null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000CA6F File Offset: 0x0000AC6F
		public static DynValue NewTable(Script script)
		{
			return null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000CA72 File Offset: 0x0000AC72
		public static DynValue NewTable(Script script, DynValue[] arrayValues)
		{
			return null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000CA75 File Offset: 0x0000AC75
		public static DynValue NewTailCallReq(DynValue tailFn, DynValue[] args)
		{
			return null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000CA78 File Offset: 0x0000AC78
		public static DynValue NewTailCallReq(TailCallData tailCallData)
		{
			return null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000CA7B File Offset: 0x0000AC7B
		public static DynValue NewYieldReq(DynValue[] args)
		{
			return null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000CA7E File Offset: 0x0000AC7E
		internal static DynValue NewForcedYieldReq()
		{
			return null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000CA81 File Offset: 0x0000AC81
		public static DynValue NewTuple(DynValue[] values)
		{
			return null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000CA84 File Offset: 0x0000AC84
		public static DynValue NewTupleNested(DynValue[] values)
		{
			return null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000CA87 File Offset: 0x0000AC87
		public static DynValue NewUserData(UserData userData)
		{
			return null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000CA8A File Offset: 0x0000AC8A
		public DynValue AsReadOnly()
		{
			return null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000CA8D File Offset: 0x0000AC8D
		public DynValue Clone()
		{
			return null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000CA90 File Offset: 0x0000AC90
		public DynValue Clone(bool readOnly)
		{
			return null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000CA93 File Offset: 0x0000AC93
		public DynValue CloneAsWritable()
		{
			return null;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000CA96 File Offset: 0x0000AC96
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x0000CA9D File Offset: 0x0000AC9D
		public static DynValue Void
		{
			get
			{
				return DynValue.<Void>k__BackingField;
			}
			private set
			{
				DynValue.<Void>k__BackingField = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000CAA5 File Offset: 0x0000ACA5
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		public static DynValue Nil
		{
			get
			{
				return DynValue.<Nil>k__BackingField;
			}
			private set
			{
				DynValue.<Nil>k__BackingField = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0000CABB File Offset: 0x0000ACBB
		public static DynValue True
		{
			get
			{
				return DynValue.<True>k__BackingField;
			}
			private set
			{
				DynValue.<True>k__BackingField = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000CAC3 File Offset: 0x0000ACC3
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x0000CACA File Offset: 0x0000ACCA
		public static DynValue False
		{
			get
			{
				return DynValue.<False>k__BackingField;
			}
			private set
			{
				DynValue.<False>k__BackingField = value;
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		public string ToPrintString()
		{
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000CAD7 File Offset: 0x0000ACD7
		public string ToDebugPrintString()
		{
			return null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000CADA File Offset: 0x0000ACDA
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000CADD File Offset: 0x0000ACDD
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000CAE3 File Offset: 0x0000ACE3
		public string CastToString()
		{
			return null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00010208 File Offset: 0x0000E408
		public double? CastToNumber()
		{
			return null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000CAE6 File Offset: 0x0000ACE6
		public bool CastToBool()
		{
			return false;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000CAE9 File Offset: 0x0000ACE9
		public IScriptPrivateResource GetAsPrivateResource()
		{
			return null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		public DynValue ToScalar()
		{
			return null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000CAEF File Offset: 0x0000ACEF
		public void Assign(DynValue value)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000CAF1 File Offset: 0x0000ACF1
		public DynValue GetLength()
		{
			return null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		public bool IsNil()
		{
			return false;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000CAF7 File Offset: 0x0000ACF7
		public bool IsNotNil()
		{
			return false;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000CAFA File Offset: 0x0000ACFA
		public bool IsVoid()
		{
			return false;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000CAFD File Offset: 0x0000ACFD
		public bool IsNotVoid()
		{
			return false;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000CB00 File Offset: 0x0000AD00
		public bool IsNilOrNan()
		{
			return false;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000CB03 File Offset: 0x0000AD03
		internal void AssignNumber(double num)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000CB05 File Offset: 0x0000AD05
		public static DynValue FromObject(Script script, object obj)
		{
			return null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000CB08 File Offset: 0x0000AD08
		public object ToObject()
		{
			return null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000CB0B File Offset: 0x0000AD0B
		public object ToObject(Type desiredType)
		{
			return null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00010220 File Offset: 0x0000E420
		public T ToObject<T>()
		{
			return default(T);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000CB0E File Offset: 0x0000AD0E
		public DynValue CheckType(string funcName, DataType desiredType, int argNum = -1, TypeValidationFlags flags = TypeValidationFlags.AutoConvert)
		{
			return null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00010238 File Offset: 0x0000E438
		public T CheckUserDataType<T>(string funcName, int argNum = -1, TypeValidationFlags flags = TypeValidationFlags.AutoConvert)
		{
			return default(T);
		}

		// Token: 0x04000176 RID: 374
		private static int s_RefIDCounter;

		// Token: 0x04000177 RID: 375
		private int m_RefID;

		// Token: 0x04000178 RID: 376
		private int m_HashCode;

		// Token: 0x04000179 RID: 377
		private bool m_ReadOnly;

		// Token: 0x0400017A RID: 378
		private double m_Number;

		// Token: 0x0400017B RID: 379
		private object m_Object;

		// Token: 0x0400017C RID: 380
		private DataType m_Type;

		// Token: 0x0400017D RID: 381
		private static DynValue <Void>k__BackingField;

		// Token: 0x0400017E RID: 382
		private static DynValue <Nil>k__BackingField;

		// Token: 0x0400017F RID: 383
		private static DynValue <True>k__BackingField;

		// Token: 0x04000180 RID: 384
		private static DynValue <False>k__BackingField;

		// Token: 0x02000181 RID: 385
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F12 RID: 3858 RVA: 0x0000F36F File Offset: 0x0000D56F
			internal bool <NewTupleNested>b__54_0(DynValue v)
			{
				return false;
			}

			// Token: 0x06000F13 RID: 3859 RVA: 0x0000F372 File Offset: 0x0000D572
			internal string <ToPrintString>b__77_0(DynValue t)
			{
				return null;
			}

			// Token: 0x06000F14 RID: 3860 RVA: 0x0000F375 File Offset: 0x0000D575
			internal string <ToDebugPrintString>b__78_0(DynValue t)
			{
				return null;
			}

			// Token: 0x06000F15 RID: 3861 RVA: 0x0000F378 File Offset: 0x0000D578
			internal string <ToString>b__79_0(DynValue t)
			{
				return null;
			}

			// Token: 0x06000F16 RID: 3862 RVA: 0x0000F37B File Offset: 0x0000D57B
			internal string <ToString>b__79_1(DynValue t)
			{
				return null;
			}

			// Token: 0x04000648 RID: 1608
			public static readonly DynValue.<>c <>9;

			// Token: 0x04000649 RID: 1609
			public static Func<DynValue, bool> <>9__54_0;

			// Token: 0x0400064A RID: 1610
			public static Func<DynValue, string> <>9__77_0;

			// Token: 0x0400064B RID: 1611
			public static Func<DynValue, string> <>9__78_0;

			// Token: 0x0400064C RID: 1612
			public static Func<DynValue, string> <>9__79_0;

			// Token: 0x0400064D RID: 1613
			public static Func<DynValue, string> <>9__79_1;
		}
	}
}
