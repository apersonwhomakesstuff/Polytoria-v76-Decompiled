using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000223 RID: 547
	[Serializable]
	public class ObjectSelectionSettings : Settings
	{
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00023B04 File Offset: 0x00021D04
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x00019F98 File Offset: 0x00018198
		public MultiSelectOverlapMode MultiSelectOverlapMode
		{
			get
			{
				return MultiSelectOverlapMode.Partial;
			}
			set
			{
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00019F9A File Offset: 0x0001819A
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x00019F9D File Offset: 0x0001819D
		public bool CanClickSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00019F9F File Offset: 0x0001819F
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00019FA2 File Offset: 0x000181A2
		public bool EnableCyclicalClickSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00019FA4 File Offset: 0x000181A4
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x00019FA7 File Offset: 0x000181A7
		public bool CanMultiSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x00019FA9 File Offset: 0x000181A9
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x00019FAC File Offset: 0x000181AC
		public int SelectableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00019FAE File Offset: 0x000181AE
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x00019FB1 File Offset: 0x000181B1
		public int DuplicatableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00019FB3 File Offset: 0x000181B3
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x00019FB6 File Offset: 0x000181B6
		public int DeletableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00019FB8 File Offset: 0x000181B8
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00019FBB File Offset: 0x000181BB
		public int MinMultiSelectSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00019FBD File Offset: 0x000181BD
		public bool IsCameraSelectable(Camera camera)
		{
			return false;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00019FC0 File Offset: 0x000181C0
		public void SetCameraSelectable(Camera camera, bool isSelectable)
		{
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00019FC2 File Offset: 0x000181C2
		public void SetCameraCollectionSelectable(List<Camera> cameraCollection, bool areSelectable)
		{
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00019FC4 File Offset: 0x000181C4
		public bool IsObjectTypeSelectable(GameObjectType gameObjectType)
		{
			return false;
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00019FC7 File Offset: 0x000181C7
		public void SetObjectTypeSelectable(GameObjectType gameObjectType, bool isSelectable)
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00019FC9 File Offset: 0x000181C9
		public bool IsObjectLayerSelectable(int objectLayer)
		{
			return false;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00019FCC File Offset: 0x000181CC
		public void SetObjectLayerSelectable(int objectLayer, bool isSelectable)
		{
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00019FCE File Offset: 0x000181CE
		public bool IsObjectSelectable(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00019FD1 File Offset: 0x000181D1
		public void SetObjectSelectable(GameObject gameObject, bool isSelectable)
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00019FD3 File Offset: 0x000181D3
		public void SetObjectCollectionSelectable(List<GameObject> gameObjectCollection, bool areSelectable)
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00019FD5 File Offset: 0x000181D5
		public void RemoveNullObjectRefs()
		{
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00019FD7 File Offset: 0x000181D7
		public bool IsObjectLayerDuplicatable(int objectLayer)
		{
			return false;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00019FDA File Offset: 0x000181DA
		public void SetObjectLayerDuplicatable(int objectLayer, bool isDuplicatable)
		{
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00019FDC File Offset: 0x000181DC
		public bool IsObjectLayerDeletable(int objectLayer)
		{
			return false;
		}

		// Token: 0x0400088B RID: 2187
		private MultiSelectOverlapMode _multiSelectOverlapMode;

		// Token: 0x0400088C RID: 2188
		private GameObjectType _selectableObjectTypes;

		// Token: 0x0400088D RID: 2189
		private int _selectableLayers;

		// Token: 0x0400088E RID: 2190
		private int _duplicatableLayers;

		// Token: 0x0400088F RID: 2191
		private int _deletableLayers;

		// Token: 0x04000890 RID: 2192
		private HashSet<GameObject> _nonSelectableObjects;

		// Token: 0x04000891 RID: 2193
		private HashSet<Camera> _nonSelectableCameras;

		// Token: 0x04000892 RID: 2194
		private bool _canClickSelect;

		// Token: 0x04000893 RID: 2195
		private bool _enableCyclicalClickSelect;

		// Token: 0x04000894 RID: 2196
		private bool _canMultiSelect;

		// Token: 0x04000895 RID: 2197
		private int _minMultiSelectSize;

		// Token: 0x020003CE RID: 974
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002B33 RID: 11059 RVA: 0x0001D49A File Offset: 0x0001B69A
			internal bool <RemoveNullObjectRefs>b__45_0(GameObject item)
			{
				return false;
			}

			// Token: 0x04001036 RID: 4150
			public static readonly ObjectSelectionSettings.<>c <>9;

			// Token: 0x04001037 RID: 4151
			public static Predicate<GameObject> <>9__45_0;
		}
	}
}
