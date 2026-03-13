using System;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x0200011E RID: 286
	internal abstract class FileUserDataBase : RefIdObject
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x0000EE28 File Offset: 0x0000D028
		public DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0000EE2B File Offset: 0x0000D02B
		public DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0000EE2E File Offset: 0x0000D02E
		public DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0000EE31 File Offset: 0x0000D031
		public DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00010658 File Offset: 0x0000E858
		private double? ReadNumber()
		{
			return null;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0000EE34 File Offset: 0x0000D034
		private bool IsNumericChar(char c, string numAsFar)
		{
			return false;
		}

		// Token: 0x06000CD6 RID: 3286
		protected abstract bool Eof();

		// Token: 0x06000CD7 RID: 3287
		protected abstract string ReadLine();

		// Token: 0x06000CD8 RID: 3288
		protected abstract string ReadBuffer(int p);

		// Token: 0x06000CD9 RID: 3289
		protected abstract string ReadToEnd();

		// Token: 0x06000CDA RID: 3290
		protected abstract char Peek();

		// Token: 0x06000CDB RID: 3291
		protected abstract void Write(string value);

		// Token: 0x06000CDC RID: 3292
		protected internal abstract bool isopen();

		// Token: 0x06000CDD RID: 3293
		protected abstract string Close();

		// Token: 0x06000CDE RID: 3294
		public abstract bool flush();

		// Token: 0x06000CDF RID: 3295
		public abstract long seek(string whence, long offset = 0L);

		// Token: 0x06000CE0 RID: 3296
		public abstract bool setvbuf(string mode);

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0000EE37 File Offset: 0x0000D037
		public override string ToString()
		{
			return null;
		}

		// Token: 0x020001D8 RID: 472
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001064 RID: 4196 RVA: 0x0000F86B File Offset: 0x0000DA6B
			internal DynValue <lines>b__0_0(DynValue s)
			{
				return null;
			}

			// Token: 0x04000758 RID: 1880
			public static readonly FileUserDataBase.<>c <>9;

			// Token: 0x04000759 RID: 1881
			public static Func<DynValue, DynValue> <>9__0_0;
		}
	}
}
