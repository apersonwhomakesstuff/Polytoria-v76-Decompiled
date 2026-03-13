using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000203 RID: 515
	[Serializable]
	public class DynamicConvertSettings : Settings
	{
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x000236E4 File Offset: 0x000218E4
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x00019DF0 File Offset: 0x00017FF0
		public GameObjectType ConvertableObjectTypes
		{
			get
			{
				return (GameObjectType)0;
			}
			set
			{
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00019DF2 File Offset: 0x00017FF2
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x00019DF5 File Offset: 0x00017FF5
		public string PrefabFolder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00019DF7 File Offset: 0x00017FF7
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x00019DFA File Offset: 0x00017FFA
		public bool ProcessPrefabSubfolders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x000236FC File Offset: 0x000218FC
		public Rect PrefabFolderDropRect
		{
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x0400083D RID: 2109
		private Rect _prefabFolderDropRect;

		// Token: 0x0400083E RID: 2110
		private GameObjectType _convertableObjectTypes;

		// Token: 0x0400083F RID: 2111
		private string _prefabFolder;

		// Token: 0x04000840 RID: 2112
		private bool _processPrefabSubfolders;
	}
}
