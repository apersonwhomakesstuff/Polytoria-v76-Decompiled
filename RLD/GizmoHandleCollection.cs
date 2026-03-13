using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000060 RID: 96
	public class GizmoHandleCollection
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0001663E File Offset: 0x0001483E
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00016641 File Offset: 0x00014841
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00016644 File Offset: 0x00014844
		public IGizmoHandle Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00016647 File Offset: 0x00014847
		public GizmoHandleCollection(Gizmo gizmo)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0001664F File Offset: 0x0001484F
		public void Clear()
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00016651 File Offset: 0x00014851
		public IGizmoHandle GetHandleById(int handleId)
		{
			return null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00016654 File Offset: 0x00014854
		public bool Contains(IGizmoHandle handle)
		{
			return false;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00016657 File Offset: 0x00014857
		public bool Contains(int handleId)
		{
			return false;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001665A File Offset: 0x0001485A
		public void Add(IGizmoHandle handle)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001665C File Offset: 0x0001485C
		public void Remove(IGizmoHandle handle)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001665E File Offset: 0x0001485E
		public List<IGizmoHandle> GetAll()
		{
			return null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00016661 File Offset: 0x00014861
		public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay)
		{
			return null;
		}

		// Token: 0x04000152 RID: 338
		private Gizmo _gizmo;

		// Token: 0x04000153 RID: 339
		private List<IGizmoHandle> _handles;

		// Token: 0x04000154 RID: 340
		private Dictionary<int, IGizmoHandle> _idToHandle;
	}
}
