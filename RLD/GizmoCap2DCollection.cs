using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000E RID: 14
	public class GizmoCap2DCollection
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00015EE1 File Offset: 0x000140E1
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00015EE4 File Offset: 0x000140E4
		public GizmoCap2D Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00015EE7 File Offset: 0x000140E7
		public bool Contains(GizmoCap2D cap)
		{
			return false;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00015EEA File Offset: 0x000140EA
		public bool Contains(int capHandleId)
		{
			return false;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00015EED File Offset: 0x000140ED
		public void Add(GizmoCap2D cap)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00015EEF File Offset: 0x000140EF
		public void Remove(GizmoCap2D cap)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00015EF1 File Offset: 0x000140F1
		public void Make2DHoverPriorityLowerThan(Priority priority)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00015EF3 File Offset: 0x000140F3
		public void Make2DHoverPriorityHigherThan(Priority priority)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00015EF5 File Offset: 0x000140F5
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00015EF7 File Offset: 0x000140F7
		public void SetHoverable(bool hoverable)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00015EF9 File Offset: 0x000140F9
		public void SetDragSession(IGizmoDragSession dragSession)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00015EFB File Offset: 0x000140FB
		public void Render(Camera camera)
		{
		}

		// Token: 0x04000023 RID: 35
		private List<GizmoCap2D> _caps;

		// Token: 0x04000024 RID: 36
		private Dictionary<int, GizmoCap2D> _handleIdToCap;
	}
}
