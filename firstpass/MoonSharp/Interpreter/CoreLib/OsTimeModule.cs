using System;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000114 RID: 276
	public class OsTimeModule
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x0000ECBF File Offset: 0x0000CEBF
		private static DynValue GetUnixTime(DateTime dateTime, DateTime? epoch = null)
		{
			return null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000105F8 File Offset: 0x0000E7F8
		private static DateTime FromUnixTime(double unixtime)
		{
			return default(DateTime);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0000ECC2 File Offset: 0x0000CEC2
		public static DynValue clock(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0000ECC5 File Offset: 0x0000CEC5
		public static DynValue difftime(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		public static DynValue time(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00010610 File Offset: 0x0000E810
		private static DateTime ParseTimeTable(Table t)
		{
			return default(DateTime);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00010628 File Offset: 0x0000E828
		private static int? GetTimeTableField(Table t, string key)
		{
			return null;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0000ECCB File Offset: 0x0000CECB
		public static DynValue date(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0000ECCE File Offset: 0x0000CECE
		private static string StrFTime(string format, DateTime d)
		{
			return null;
		}

		// Token: 0x040004A4 RID: 1188
		private static DateTime Time0;

		// Token: 0x040004A5 RID: 1189
		private static DateTime Epoch;
	}
}
