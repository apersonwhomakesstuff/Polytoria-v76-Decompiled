using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002D RID: 45
	public static class LuaTypeExtensions
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x0000CA10 File Offset: 0x0000AC10
		public static bool CanHaveTypeMetatables(DataType type)
		{
			return false;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000CA13 File Offset: 0x0000AC13
		public static string ToErrorTypeString(DataType type)
		{
			return null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000CA16 File Offset: 0x0000AC16
		public static string ToLuaDebuggerString(DataType type)
		{
			return null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000CA19 File Offset: 0x0000AC19
		public static string ToLuaTypeString(DataType type)
		{
			return null;
		}

		// Token: 0x04000174 RID: 372
		internal const DataType MaxMetaTypes = DataType.Table;

		// Token: 0x04000175 RID: 373
		internal const DataType MaxConvertibleTypes = DataType.ClrFunction;
	}
}
