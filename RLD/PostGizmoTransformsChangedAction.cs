using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x02000201 RID: 513
	public class PostGizmoTransformsChangedAction : IUndoRedoAction
	{
		// Token: 0x06001789 RID: 6025 RVA: 0x00019DCD File Offset: 0x00017FCD
		public PostGizmoTransformsChangedAction(List<LocalGizmoTransformSnapshot> preChangeTransformSnapshots, List<LocalGizmoTransformSnapshot> postChangeTransformSnapshots)
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00019DD5 File Offset: 0x00017FD5
		public void Execute()
		{
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00019DD7 File Offset: 0x00017FD7
		public void Undo()
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00019DD9 File Offset: 0x00017FD9
		public void Redo()
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00019DDB File Offset: 0x00017FDB
		public void OnRemovedFromUndoRedoStack()
		{
		}

		// Token: 0x04000838 RID: 2104
		private List<LocalGizmoTransformSnapshot> _preChangeTransformSnapshots;

		// Token: 0x04000839 RID: 2105
		private List<LocalGizmoTransformSnapshot> _postChangeTransformSnapshots;
	}
}
