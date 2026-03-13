using System;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class NetRuntimeException : InterpreterException
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x0000CD88 File Offset: 0x0000AF88
		public NetRuntimeException(Exception ex) : base(null, null)
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000CD92 File Offset: 0x0000AF92
		public NetRuntimeException(NetRuntimeException ex) : base(null, null)
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public NetRuntimeException(string message) : base(null, null)
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000CDA6 File Offset: 0x0000AFA6
		public NetRuntimeException(string format, object[] args) : base(null, null)
		{
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		public static NetRuntimeException ArithmeticOnNonNumber(DynValue l, DynValue r = null)
		{
			return null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0000CDB3 File Offset: 0x0000AFB3
		public static NetRuntimeException ConcatOnNonString(DynValue l, DynValue r)
		{
			return null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000CDB6 File Offset: 0x0000AFB6
		public static NetRuntimeException LenOnInvalidType(DynValue r)
		{
			return null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000CDB9 File Offset: 0x0000AFB9
		public static NetRuntimeException CompareInvalidType(DynValue l, DynValue r)
		{
			return null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		public static NetRuntimeException BadArgument(int argNum, string funcName, string message)
		{
			return null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000CDBF File Offset: 0x0000AFBF
		public static NetRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, object got, bool allowNil)
		{
			return null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000CDC2 File Offset: 0x0000AFC2
		public static NetRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil)
		{
			return null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000CDC5 File Offset: 0x0000AFC5
		public static NetRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil)
		{
			return null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		public static NetRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected)
		{
			return null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000CDCB File Offset: 0x0000AFCB
		public static NetRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum)
		{
			return null;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000CDCE File Offset: 0x0000AFCE
		public static NetRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName)
		{
			return null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000CDD1 File Offset: 0x0000AFD1
		public static NetRuntimeException BadArgumentValueExpected(int argNum, string funcName)
		{
			return null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
		public static NetRuntimeException IndexType(DynValue obj)
		{
			return null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000CDD7 File Offset: 0x0000AFD7
		public static NetRuntimeException LoopInIndex()
		{
			return null;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000CDDA File Offset: 0x0000AFDA
		public static NetRuntimeException LoopInNewIndex()
		{
			return null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000CDDD File Offset: 0x0000AFDD
		public static NetRuntimeException LoopInCall()
		{
			return null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		public static NetRuntimeException TableIndexIsNil()
		{
			return null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000CDE3 File Offset: 0x0000AFE3
		public static NetRuntimeException TableIndexIsNaN()
		{
			return null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0000CDE6 File Offset: 0x0000AFE6
		public static NetRuntimeException ConvertToNumberFailed(int stage)
		{
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000CDE9 File Offset: 0x0000AFE9
		public static NetRuntimeException ConvertObjectFailed(object obj)
		{
			return null;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		public static NetRuntimeException ConvertObjectFailed(DataType t)
		{
			return null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000CDEF File Offset: 0x0000AFEF
		public static NetRuntimeException ConvertObjectFailed(DataType t, Type t2)
		{
			return null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000CDF2 File Offset: 0x0000AFF2
		public static NetRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType)
		{
			return null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000CDF5 File Offset: 0x0000AFF5
		public static NetRuntimeException UserDataMissingField(string typename, string fieldname)
		{
			return null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		public static NetRuntimeException CannotResumeNotSuspended(CoroutineState state)
		{
			return null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000CDFB File Offset: 0x0000AFFB
		public static NetRuntimeException CannotYield()
		{
			return null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000CDFE File Offset: 0x0000AFFE
		public static NetRuntimeException CannotYieldMain()
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000CE01 File Offset: 0x0000B001
		public static NetRuntimeException AttemptToCallNonFunc(DataType type, string debugText = null)
		{
			return null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000CE04 File Offset: 0x0000B004
		public static NetRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc)
		{
			return null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000CE07 File Offset: 0x0000B007
		public static NetRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc)
		{
			return null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000CE0A File Offset: 0x0000B00A
		public override void Rethrow()
		{
		}
	}
}
