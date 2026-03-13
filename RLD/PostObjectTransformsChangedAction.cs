using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x02000200 RID: 512
	public class PostObjectTransformsChangedAction : IUndoRedoAction
	{
		// Token: 0x06001784 RID: 6020 RVA: 0x00019DBD File Offset: 0x00017FBD
		public PostObjectTransformsChangedAction(List<LocalTransformSnapshot> preChangeTransformSnapshots, List<LocalTransformSnapshot> postChangeTransformSnapshots)
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00019DC5 File Offset: 0x00017FC5
		public void Execute()
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00019DC7 File Offset: 0x00017FC7
		public void Undo()
		{
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00019DC9 File Offset: 0x00017FC9
		public void Redo()
		{
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00019DCB File Offset: 0x00017FCB
		public void OnRemovedFromUndoRedoStack()
		{
		}

		// Token: 0x04000836 RID: 2102
		private List<LocalTransformSnapshot> _preChangeTransformSnapshots;

		// Token: 0x04000837 RID: 2103
		private List<LocalTransformSnapshot> _postChangeTransformSnapshots;
	}
}
