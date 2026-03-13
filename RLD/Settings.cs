using System;

namespace RLD
{
	// Token: 0x0200011B RID: 283
	[Serializable]
	public abstract class Settings
	{
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0001872B File Offset: 0x0001692B
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x0001872E File Offset: 0x0001692E
		public bool CanBeDisplayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00018730 File Offset: 0x00016930
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00018738 File Offset: 0x00016938
		public bool UsesFoldout
		{
			get
			{
				return this.<UsesFoldout>k__BackingField;
			}
			set
			{
				this.<UsesFoldout>k__BackingField = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00018741 File Offset: 0x00016941
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00018744 File Offset: 0x00016944
		public string FoldoutLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00018746 File Offset: 0x00016946
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x00018749 File Offset: 0x00016949
		public bool IsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000554 RID: 1364
		private bool _canBeDisplayed;

		// Token: 0x04000555 RID: 1365
		protected bool _isExpanded;

		// Token: 0x04000556 RID: 1366
		private string _foldoutLabel;

		// Token: 0x04000557 RID: 1367
		private bool <UsesFoldout>k__BackingField;
	}
}
