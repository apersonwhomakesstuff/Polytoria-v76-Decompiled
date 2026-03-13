using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000B RID: 11
	public class ObjectExtrudeGizmoDragEnd : IUndoRedoAction
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00015E49 File Offset: 0x00014049
		public int NumTargets
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00015E4C File Offset: 0x0001404C
		public void SetTargetParents(IEnumerable<GameObject> targetParents)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00015E4E File Offset: 0x0001404E
		public void TakeUndoTargetSnapshots()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00015E50 File Offset: 0x00014050
		public void TakeRedoTargetSnapshots()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00015E52 File Offset: 0x00014052
		public void AddExtrudeClones(List<GameObject> extrudeClones)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00015E54 File Offset: 0x00014054
		public void AddExtrudeClone(GameObject extrudeClone)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00015E56 File Offset: 0x00014056
		public void Execute()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00015E58 File Offset: 0x00014058
		public void Undo()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00015E5A File Offset: 0x0001405A
		public void Redo()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00015E5C File Offset: 0x0001405C
		public void OnRemovedFromUndoRedoStack()
		{
		}

		// Token: 0x04000010 RID: 16
		private bool _wasExecuted;

		// Token: 0x04000011 RID: 17
		private bool _destroyClones;

		// Token: 0x04000012 RID: 18
		private List<GameObject> _targetParents;

		// Token: 0x04000013 RID: 19
		private List<LocalTransformSnapshot> _undoTargetSnapshots;

		// Token: 0x04000014 RID: 20
		private List<LocalTransformSnapshot> _redoTargetSnapshots;

		// Token: 0x04000015 RID: 21
		private List<GameObject> _extrudeClones;
	}
}
