using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000202 RID: 514
	public class DuplicateObjectsAction : IUndoRedoAction
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00019DDD File Offset: 0x00017FDD
		public List<GameObject> DuplicateResult
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00019DE0 File Offset: 0x00017FE0
		public DuplicateObjectsAction(List<GameObject> rootsToDuplicate)
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00019DE8 File Offset: 0x00017FE8
		public void Execute()
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00019DEA File Offset: 0x00017FEA
		public void Undo()
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00019DEC File Offset: 0x00017FEC
		public void Redo()
		{
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00019DEE File Offset: 0x00017FEE
		public void OnRemovedFromUndoRedoStack()
		{
		}

		// Token: 0x0400083A RID: 2106
		private List<GameObject> _rootsToDuplicate;

		// Token: 0x0400083B RID: 2107
		private List<GameObject> _duplicateResult;

		// Token: 0x0400083C RID: 2108
		private bool _cleanupOnRemovedFromStack;
	}
}
