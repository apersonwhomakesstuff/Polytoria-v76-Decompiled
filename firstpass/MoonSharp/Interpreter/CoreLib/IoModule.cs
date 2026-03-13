using System;
using System.IO;
using System.Text;
using MoonSharp.Interpreter.CoreLib.IO;
using MoonSharp.Interpreter.Platforms;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x0200010E RID: 270
	public class IoModule
	{
		// Token: 0x06000C10 RID: 3088 RVA: 0x0000EB9E File Offset: 0x0000CD9E
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		private static DynValue __index_callback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0000EBA3 File Offset: 0x0000CDA3
		private static DynValue GetStandardFile(Script S, StandardFileType file)
		{
			return null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0000EBA6 File Offset: 0x0000CDA6
		private static void SetStandardFile(Script S, StandardFileType file, Stream optionsStream)
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
		private static FileUserDataBase GetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file)
		{
			return null;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0000EBAB File Offset: 0x0000CDAB
		private static void SetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file, FileUserDataBase fileHandle)
		{
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0000EBAD File Offset: 0x0000CDAD
		internal static void SetDefaultFile(Script script, StandardFileType file, FileUserDataBase fileHandle)
		{
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0000EBAF File Offset: 0x0000CDAF
		public static void SetDefaultFile(Script script, StandardFileType file, Stream stream)
		{
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0000EBB1 File Offset: 0x0000CDB1
		public static DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
		public static DynValue flush(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0000EBB7 File Offset: 0x0000CDB7
		public static DynValue input(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0000EBBA File Offset: 0x0000CDBA
		public static DynValue output(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0000EBBD File Offset: 0x0000CDBD
		private static DynValue HandleDefaultStreamSetter(ScriptExecutionContext executionContext, CallbackArguments args, StandardFileType defaultFiles)
		{
			return null;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		private static Encoding GetUTF8Encoding()
		{
			return null;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0000EBC3 File Offset: 0x0000CDC3
		public static DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0000EBC6 File Offset: 0x0000CDC6
		public static DynValue open(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0000EBC9 File Offset: 0x0000CDC9
		public static string IoExceptionToLuaMessage(Exception ex, string filename)
		{
			return null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		public static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0000EBCF File Offset: 0x0000CDCF
		public static DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
		public static DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0000EBD5 File Offset: 0x0000CDD5
		public static DynValue tmpfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		private static FileUserDataBase Open(ScriptExecutionContext executionContext, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		// Token: 0x020001D1 RID: 465
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600103E RID: 4158 RVA: 0x0000F721 File Offset: 0x0000D921
			internal DynValue <lines>b__14_0(DynValue s)
			{
				return null;
			}

			// Token: 0x0400072E RID: 1838
			public static readonly IoModule.<>c <>9;

			// Token: 0x0400072F RID: 1839
			public static Func<DynValue, DynValue> <>9__14_0;
		}
	}
}
