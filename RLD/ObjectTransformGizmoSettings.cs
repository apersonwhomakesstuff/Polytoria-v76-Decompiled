using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E1 RID: 225
	[Serializable]
	public class ObjectTransformGizmoSettings : Settings
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00017941 File Offset: 0x00015B41
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00017944 File Offset: 0x00015B44
		public int TransformableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00017946 File Offset: 0x00015B46
		public bool IsLayerTransformable(int objectLayer)
		{
			return false;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00017949 File Offset: 0x00015B49
		public void SetLayerTransformable(int objectLayer, bool isTransformable)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001794B File Offset: 0x00015B4B
		public bool IsObjectTransformable(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001794E File Offset: 0x00015B4E
		public void SetObjectTransformable(GameObject gameObject, bool isTransformable)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00017950 File Offset: 0x00015B50
		public void SetObjectCollectionTransformable(List<GameObject> gameObjectCollection, bool areTransformable)
		{
		}

		// Token: 0x04000403 RID: 1027
		private int _transformableLayers;

		// Token: 0x04000404 RID: 1028
		private HashSet<GameObject> _nonTransformableObjects;
	}
}
