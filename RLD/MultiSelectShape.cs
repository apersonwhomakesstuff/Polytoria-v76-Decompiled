using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000216 RID: 534
	public class MultiSelectShape
	{
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00023A2C File Offset: 0x00021C2C
		public Rect EnclosingRect
		{
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00019E92 File Offset: 0x00018092
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x00019E95 File Offset: 0x00018095
		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00019E97 File Offset: 0x00018097
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x00019E9A File Offset: 0x0001809A
		public int MinSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00019E9C File Offset: 0x0001809C
		public void SetEnclosingRectTopLeftPoint(Vector2 topLeftPoint)
		{
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00019E9E File Offset: 0x0001809E
		public void SetEnclosingRectBottomRightPoint(Vector2 bottomRightPoint)
		{
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00019EA0 File Offset: 0x000180A0
		public void GetOverlappedObjects(List<GameObject> gameObjects, Camera camera, ObjectBounds.QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode, List<GameObject> overlappedObjects)
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00019EA2 File Offset: 0x000180A2
		public bool OverlapsObject(GameObject gameObject, Camera camera, ObjectBounds.QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode)
		{
			return false;
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00019EA5 File Offset: 0x000180A5
		public void Render(Color fillColor, Color borderColor, Camera camera)
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00019EA7 File Offset: 0x000180A7
		private bool IsBigEnoughForOverlap()
		{
			return false;
		}

		// Token: 0x0400085C RID: 2140
		private Rect _enclosingRect;

		// Token: 0x0400085D RID: 2141
		private bool _isVisible;

		// Token: 0x0400085E RID: 2142
		private int _minSize;
	}
}
