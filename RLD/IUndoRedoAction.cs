using System;

namespace RLD
{
	// Token: 0x020001F7 RID: 503
	public interface IUndoRedoAction
	{
		// Token: 0x06001751 RID: 5969
		void Execute();

		// Token: 0x06001752 RID: 5970
		void Undo();

		// Token: 0x06001753 RID: 5971
		void Redo();

		// Token: 0x06001754 RID: 5972
		void OnRemovedFromUndoRedoStack();
	}
}
