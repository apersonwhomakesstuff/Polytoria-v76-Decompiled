using System;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public class ScriptRuntimeException : InterpreterException
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x0000CE0C File Offset: 0x0000B00C
		public ScriptRuntimeException(Exception ex) : base(null, null)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000CE16 File Offset: 0x0000B016
		public ScriptRuntimeException(ScriptRuntimeException ex) : base(null, null)
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000CE20 File Offset: 0x0000B020
		public ScriptRuntimeException(string message) : base(null, null)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000CE2A File Offset: 0x0000B02A
		public ScriptRuntimeException(string format, object[] args) : base(null, null)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000CE34 File Offset: 0x0000B034
		public static ScriptRuntimeException ArithmeticOnNonNumber(DynValue l, DynValue r = null)
		{
			return null;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000CE37 File Offset: 0x0000B037
		public static ScriptRuntimeException ConcatOnNonString(DynValue l, DynValue r)
		{
			return null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000CE3A File Offset: 0x0000B03A
		public static ScriptRuntimeException LenOnInvalidType(DynValue r)
		{
			return null;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000CE3D File Offset: 0x0000B03D
		public static ScriptRuntimeException CompareInvalidType(DynValue l, DynValue r)
		{
			return null;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000CE40 File Offset: 0x0000B040
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, string message)
		{
			return null;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000CE43 File Offset: 0x0000B043
		public static ScriptRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, object got, bool allowNil)
		{
			return null;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000CE46 File Offset: 0x0000B046
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil)
		{
			return null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000CE49 File Offset: 0x0000B049
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil)
		{
			return null;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000CE4C File Offset: 0x0000B04C
		public static ScriptRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected)
		{
			return null;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000CE4F File Offset: 0x0000B04F
		public static ScriptRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum)
		{
			return null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000CE52 File Offset: 0x0000B052
		public static ScriptRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName)
		{
			return null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000CE55 File Offset: 0x0000B055
		public static ScriptRuntimeException BadArgumentValueExpected(int argNum, string funcName)
		{
			return null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000CE58 File Offset: 0x0000B058
		public static ScriptRuntimeException IndexType(DynValue obj)
		{
			return null;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0000CE5B File Offset: 0x0000B05B
		public static ScriptRuntimeException LoopInIndex()
		{
			return null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000CE5E File Offset: 0x0000B05E
		public static ScriptRuntimeException LoopInNewIndex()
		{
			return null;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000CE61 File Offset: 0x0000B061
		public static ScriptRuntimeException LoopInCall()
		{
			return null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000CE64 File Offset: 0x0000B064
		public static ScriptRuntimeException TableIndexIsNil()
		{
			return null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000CE67 File Offset: 0x0000B067
		public static ScriptRuntimeException TableIndexIsNaN()
		{
			return null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000CE6A File Offset: 0x0000B06A
		public static ScriptRuntimeException ConvertToNumberFailed(int stage)
		{
			return null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000CE6D File Offset: 0x0000B06D
		public static ScriptRuntimeException ConvertObjectFailed(object obj)
		{
			return null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000CE70 File Offset: 0x0000B070
		public static ScriptRuntimeException ConvertObjectFailed(DataType t)
		{
			return null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000CE73 File Offset: 0x0000B073
		public static ScriptRuntimeException ConvertObjectFailed(DataType t, Type t2)
		{
			return null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000CE76 File Offset: 0x0000B076
		public static ScriptRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType)
		{
			return null;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000CE79 File Offset: 0x0000B079
		public static ScriptRuntimeException UserDataMissingField(string typename, string fieldname)
		{
			return null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public static ScriptRuntimeException CannotResumeNotSuspended(CoroutineState state)
		{
			return null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000CE7F File Offset: 0x0000B07F
		public static ScriptRuntimeException CannotYield()
		{
			return null;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000CE82 File Offset: 0x0000B082
		public static ScriptRuntimeException CannotYieldMain()
		{
			return null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000CE85 File Offset: 0x0000B085
		public static ScriptRuntimeException AttemptToCallNonFunc(DataType type, string debugText = null)
		{
			return null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000CE88 File Offset: 0x0000B088
		public static ScriptRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc)
		{
			return null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000CE8B File Offset: 0x0000B08B
		public static ScriptRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc)
		{
			return null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000CE8E File Offset: 0x0000B08E
		public override void Rethrow()
		{
		}
	}
}
