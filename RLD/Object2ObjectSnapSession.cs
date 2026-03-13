using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C6 RID: 454
	public class Object2ObjectSnapSession
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060013BF RID: 5055 RVA: 0x000194A1 File Offset: 0x000176A1
		// (remove) Token: 0x060013C0 RID: 5056 RVA: 0x000194A3 File Offset: 0x000176A3
		public event Object2ObjectSnapSessionBeginHandler SessionBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060013C1 RID: 5057 RVA: 0x000194A5 File Offset: 0x000176A5
		// (remove) Token: 0x060013C2 RID: 5058 RVA: 0x000194A7 File Offset: 0x000176A7
		public event Object2ObjectSnapSessionEndHandler SessionEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x000194A9 File Offset: 0x000176A9
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x000194AC File Offset: 0x000176AC
		public Object2ObjectSnapSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x000194AE File Offset: 0x000176AE
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x000194B1 File Offset: 0x000176B1
		public Object2ObjectSnapHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x000194B3 File Offset: 0x000176B3
		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000194B6 File Offset: 0x000176B6
		public void Update(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x000194B8 File Offset: 0x000176B8
		public void End()
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000194BA File Offset: 0x000176BA
		private bool Begin(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000194BD File Offset: 0x000176BD
		private void SnapTargets()
		{
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000194BF File Offset: 0x000176BF
		private bool CalculateTargetAABB()
		{
			return false;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x000194C2 File Offset: 0x000176C2
		private bool IdentifySitSurface()
		{
			return false;
		}

		// Token: 0x04000725 RID: 1829
		private Object2ObjectSnapSession.State _state;

		// Token: 0x04000726 RID: 1830
		private List<GameObject> _targetObjects;

		// Token: 0x04000727 RID: 1831
		private List<GameObject> _targetParents;

		// Token: 0x04000728 RID: 1832
		private AABB _targetAABB;

		// Token: 0x04000729 RID: 1833
		private Object2ObjectSnapSession.SitSurface _sitSurface;

		// Token: 0x0400072A RID: 1834
		private bool _sitBelowSurface;

		// Token: 0x0400072B RID: 1835
		private Object2ObjectSnapSettings _sharedSettings;

		// Token: 0x0400072C RID: 1836
		private Object2ObjectSnapHotkeys _sharedHotkeys;

		// Token: 0x0400072D RID: 1837
		private List<LocalTransformSnapshot> _preTargetTransformSnapshots;

		// Token: 0x020003A2 RID: 930
		private enum State
		{
			// Token: 0x04000F89 RID: 3977
			Inactive,
			// Token: 0x04000F8A RID: 3978
			Active
		}

		// Token: 0x020003A3 RID: 931
		private enum SitSurfaceType
		{
			// Token: 0x04000F8C RID: 3980
			Invalid,
			// Token: 0x04000F8D RID: 3981
			Grid,
			// Token: 0x04000F8E RID: 3982
			Object
		}

		// Token: 0x020003A4 RID: 932
		private struct SitSurface
		{
			// Token: 0x04000F8F RID: 3983
			public Object2ObjectSnapSession.SitSurfaceType SurfaceType;

			// Token: 0x04000F90 RID: 3984
			public Vector3 SitPoint;

			// Token: 0x04000F91 RID: 3985
			public Plane SitPlane;
		}
	}
}
