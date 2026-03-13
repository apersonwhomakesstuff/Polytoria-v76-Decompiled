using System;
using System.Collections;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A3 RID: 163
	internal class EnumerableWrapper : IUserDataType
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x0000D957 File Offset: 0x0000BB57
		private EnumerableWrapper(Script script, IEnumerator enumerator)
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0000D95F File Offset: 0x0000BB5F
		public void Reset()
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0000D961 File Offset: 0x0000BB61
		private DynValue GetNext(DynValue prev)
		{
			return null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000D964 File Offset: 0x0000BB64
		private DynValue LuaIteratorCallback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0000D967 File Offset: 0x0000BB67
		internal static DynValue ConvertIterator(Script script, IEnumerator enumerator)
		{
			return null;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0000D96A File Offset: 0x0000BB6A
		internal static DynValue ConvertTable(Table table)
		{
			return null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0000D96D File Offset: 0x0000BB6D
		public DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0000D970 File Offset: 0x0000BB70
		public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return false;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0000D973 File Offset: 0x0000BB73
		public DynValue MetaIndex(Script script, string metaname)
		{
			return null;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0000D976 File Offset: 0x0000BB76
		private DynValue <Index>b__10_0(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0000D979 File Offset: 0x0000BB79
		private DynValue <Index>b__10_1(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x040002EB RID: 747
		private IEnumerator m_Enumerator;

		// Token: 0x040002EC RID: 748
		private Script m_Script;

		// Token: 0x040002ED RID: 749
		private DynValue m_Prev;

		// Token: 0x040002EE RID: 750
		private bool m_HasTurnOnce;
	}
}
