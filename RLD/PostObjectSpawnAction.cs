using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001FF RID: 511
	public class PostObjectSpawnAction : IUndoRedoAction
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x00019DAD File Offset: 0x00017FAD
		public PostObjectSpawnAction(List<GameObject> spawnedParents)
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00019DB5 File Offset: 0x00017FB5
		public void Execute()
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00019DB7 File Offset: 0x00017FB7
		public void Undo()
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00019DB9 File Offset: 0x00017FB9
		public void Redo()
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00019DBB File Offset: 0x00017FBB
		public void OnRemovedFromUndoRedoStack()
		{
		}

		// Token: 0x04000834 RID: 2100
		private bool _cleanupOnRemovedFromStack;

		// Token: 0x04000835 RID: 2101
		private List<GameObject> _spawnedParents;
	}
}
