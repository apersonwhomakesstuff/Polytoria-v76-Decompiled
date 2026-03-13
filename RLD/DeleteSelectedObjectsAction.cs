using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000219 RID: 537
	public class DeleteSelectedObjectsAction : IUndoRedoAction
	{
		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00019ED6 File Offset: 0x000180D6
		public ObjectSelectionSnapshot PreDeleteSnapshot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00019ED9 File Offset: 0x000180D9
		public ObjectSelectionSnapshot PostDeleteSnapshot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00019EDC File Offset: 0x000180DC
		public DeleteSelectedObjectsAction(List<GameObject> selectedObjects, ObjectSelectionSnapshot preDeleteSnapshot)
		{
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00019EE4 File Offset: 0x000180E4
		public void Execute()
		{
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00019EE6 File Offset: 0x000180E6
		public void Undo()
		{
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00019EE8 File Offset: 0x000180E8
		public void Redo()
		{
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00019EEA File Offset: 0x000180EA
		public void OnRemovedFromUndoRedoStack()
		{
		}

		// Token: 0x04000863 RID: 2147
		private List<GameObject> _selectedObjects;

		// Token: 0x04000864 RID: 2148
		private List<GameObject> _deletedObjects;

		// Token: 0x04000865 RID: 2149
		private ObjectSelectionSnapshot _preDeleteSnapshot;

		// Token: 0x04000866 RID: 2150
		private ObjectSelectionSnapshot _postDeleteSnapshot;

		// Token: 0x04000867 RID: 2151
		private bool _canDestroyObjects;
	}
}
