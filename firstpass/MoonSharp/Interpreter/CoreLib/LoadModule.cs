using System;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000110 RID: 272
	public class LoadModule
	{
		// Token: 0x06000C2C RID: 3116 RVA: 0x0000EBF7 File Offset: 0x0000CDF7
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0000EBF9 File Offset: 0x0000CDF9
		public static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0000EBFC File Offset: 0x0000CDFC
		public static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0000EBFF File Offset: 0x0000CDFF
		public static DynValue load_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0000EC02 File Offset: 0x0000CE02
		public static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0000EC05 File Offset: 0x0000CE05
		public static DynValue loadfilesafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0000EC08 File Offset: 0x0000CE08
		private static DynValue loadfile_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0000EC0B File Offset: 0x0000CE0B
		private static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext)
		{
			return null;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0000EC0E File Offset: 0x0000CE0E
		public static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0000EC11 File Offset: 0x0000CE11
		public static DynValue __require_clr_impl(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x040004A1 RID: 1185
		public const string require = "\nfunction(modulename)\n\tif (package == nil) then package = { }; end\n\tif (package.loaded == nil) then package.loaded = { }; end\n\n\tlocal m = package.loaded[modulename];\n\n\tif (m ~= nil) then\n\t\treturn m;\n\tend\n\n\tlocal func = __require_clr_impl(modulename);\n\n\tlocal res = func(modulename);\n\n\tif (res == nil) then\n\t\tres = true;\n\tend\n\n\tpackage.loaded[modulename] = res;\n\n\treturn res;\nend";
	}
}
