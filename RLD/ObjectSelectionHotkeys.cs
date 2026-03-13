using System;

namespace RLD
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class ObjectSelectionHotkeys : Settings
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00019F37 File Offset: 0x00018137
		public Hotkeys AppendToSelection
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00019F3A File Offset: 0x0001813A
		public Hotkeys MultiDeselect
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00019F3D File Offset: 0x0001813D
		public Hotkeys DeleteSelected
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00019F40 File Offset: 0x00018140
		public Hotkeys FocusCameraOnSelection
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00019F43 File Offset: 0x00018143
		public Hotkeys DuplicateSelection
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000871 RID: 2161
		private Hotkeys _appendToSelection;

		// Token: 0x04000872 RID: 2162
		private Hotkeys _multiDeselect;

		// Token: 0x04000873 RID: 2163
		private Hotkeys _deleteSelected;

		// Token: 0x04000874 RID: 2164
		private Hotkeys _focusCameraOnSelection;

		// Token: 0x04000875 RID: 2165
		private Hotkeys _duplicateSelection;
	}
}
