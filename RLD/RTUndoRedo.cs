using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x020001FE RID: 510
	public class RTUndoRedo : MonoSingleton<RTUndoRedo>
	{
		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06001769 RID: 5993 RVA: 0x00019D79 File Offset: 0x00017F79
		// (remove) Token: 0x0600176A RID: 5994 RVA: 0x00019D7B File Offset: 0x00017F7B
		public event UndoStartHandler UndoStart
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x0600176B RID: 5995 RVA: 0x00019D7D File Offset: 0x00017F7D
		// (remove) Token: 0x0600176C RID: 5996 RVA: 0x00019D7F File Offset: 0x00017F7F
		public event UndoEndHandler UndoEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x0600176D RID: 5997 RVA: 0x00019D81 File Offset: 0x00017F81
		// (remove) Token: 0x0600176E RID: 5998 RVA: 0x00019D83 File Offset: 0x00017F83
		public event RedoStartHandler RedoStart
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600176F RID: 5999 RVA: 0x00019D85 File Offset: 0x00017F85
		// (remove) Token: 0x06001770 RID: 6000 RVA: 0x00019D87 File Offset: 0x00017F87
		public event RedoEndHandler RedoEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06001771 RID: 6001 RVA: 0x00019D89 File Offset: 0x00017F89
		// (remove) Token: 0x06001772 RID: 6002 RVA: 0x00019D8B File Offset: 0x00017F8B
		public event CanUndoRedoHandler CanUndoRedo
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x00019D8D File Offset: 0x00017F8D
		public bool IsEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00019D90 File Offset: 0x00017F90
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00019D93 File Offset: 0x00017F93
		public int ActionLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00019D95 File Offset: 0x00017F95
		public void SetEnabled(bool isEnabled)
		{
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00019D97 File Offset: 0x00017F97
		public void ClearActions()
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00019D99 File Offset: 0x00017F99
		public void RecordAction(IUndoRedoAction action)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00019D9B File Offset: 0x00017F9B
		public void Update_SystemCall()
		{
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00019D9D File Offset: 0x00017F9D
		public void Undo()
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00019D9F File Offset: 0x00017F9F
		public void Redo()
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00019DA1 File Offset: 0x00017FA1
		private void RemoveGroups(int startIndex, int count)
		{
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00019DA3 File Offset: 0x00017FA3
		private void OnValidate()
		{
		}

		// Token: 0x04000830 RID: 2096
		private bool _isEnabled;

		// Token: 0x04000831 RID: 2097
		private int _actionLimit;

		// Token: 0x04000832 RID: 2098
		private List<RTUndoRedo.ActionGroup> _actionGroupStack;

		// Token: 0x04000833 RID: 2099
		private int _stackPointer;

		// Token: 0x020003BA RID: 954
		private class ActionGroup
		{
			// Token: 0x06002B1B RID: 11035 RVA: 0x0001D44A File Offset: 0x0001B64A
			public ActionGroup(IUndoRedoAction action)
			{
			}

			// Token: 0x04000FE8 RID: 4072
			public List<IUndoRedoAction> Actions;
		}
	}
}
