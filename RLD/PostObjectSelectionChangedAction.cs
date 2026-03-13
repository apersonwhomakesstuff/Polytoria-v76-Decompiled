using System;

namespace RLD
{
	// Token: 0x0200021A RID: 538
	public class PostObjectSelectionChangedAction : IUndoRedoAction
	{
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x00019EEC File Offset: 0x000180EC
		public ObjectSelectionSnapshot PreChangeSnapshot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00019EEF File Offset: 0x000180EF
		public ObjectSelectionSnapshot PostChangeSnapshot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00019EF2 File Offset: 0x000180F2
		public PostObjectSelectionChangedAction(ObjectSelectionSnapshot preChangeSnapshot, ObjectSelectionSnapshot postChangeSnapshot)
		{
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00019EFA File Offset: 0x000180FA
		public void Execute()
		{
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00019EFC File Offset: 0x000180FC
		public void Undo()
		{
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00019EFE File Offset: 0x000180FE
		public void Redo()
		{
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00019F00 File Offset: 0x00018100
		public void OnRemovedFromUndoRedoStack()
		{
		}

		// Token: 0x04000868 RID: 2152
		private ObjectSelectionSnapshot _preChangeSnapshot;

		// Token: 0x04000869 RID: 2153
		private ObjectSelectionSnapshot _postChangeSnapshot;
	}
}
