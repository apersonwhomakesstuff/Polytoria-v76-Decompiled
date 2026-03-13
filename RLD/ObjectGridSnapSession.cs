using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D3 RID: 467
	public class ObjectGridSnapSession
	{
		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600144D RID: 5197 RVA: 0x0001960C File Offset: 0x0001780C
		// (remove) Token: 0x0600144E RID: 5198 RVA: 0x0001960E File Offset: 0x0001780E
		public event ObjectGridSnapSessionBeginHandler SessionBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x0600144F RID: 5199 RVA: 0x00019610 File Offset: 0x00017810
		// (remove) Token: 0x06001450 RID: 5200 RVA: 0x00019612 File Offset: 0x00017812
		public event ObjectGridSnapSessionEndHandler SessionEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00019614 File Offset: 0x00017814
		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00019617 File Offset: 0x00017817
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x0001961A File Offset: 0x0001781A
		public ObjectGridSnapLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0001961C File Offset: 0x0001781C
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x0001961F File Offset: 0x0001781F
		public ObjectGridSnapHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00019621 File Offset: 0x00017821
		public void Render(Camera renderCamera)
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00019623 File Offset: 0x00017823
		public void Update(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00019625 File Offset: 0x00017825
		public void End()
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00019627 File Offset: 0x00017827
		private bool Begin(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0001962A File Offset: 0x0001782A
		private bool IdentifyTargetParents(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0001962D File Offset: 0x0001782D
		private bool IdentifyTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00019630 File Offset: 0x00017830
		private void SelectPivot()
		{
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00021E24 File Offset: 0x00020024
		private ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			return default(ObjectBounds.QueryConfig);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00019632 File Offset: 0x00017832
		private void Snap()
		{
		}

		// Token: 0x0400076A RID: 1898
		private List<GameObject> _targetParents;

		// Token: 0x0400076B RID: 1899
		private List<GameObject> _targetObjects;

		// Token: 0x0400076C RID: 1900
		private List<LocalTransformSnapshot> _preTargetTransformSnapshots;

		// Token: 0x0400076D RID: 1901
		private Vector3 _snapPivotPoint;

		// Token: 0x0400076E RID: 1902
		private ObjectGridSnapSession.State _state;

		// Token: 0x0400076F RID: 1903
		private ObjectGridSnapHotkeys _sharedHotkeys;

		// Token: 0x04000770 RID: 1904
		private ObjectGridSnapLookAndFeel _sharedLookAndFeel;

		// Token: 0x020003A9 RID: 937
		private enum State
		{
			// Token: 0x04000FB0 RID: 4016
			Inactive,
			// Token: 0x04000FB1 RID: 4017
			SelectPivot,
			// Token: 0x04000FB2 RID: 4018
			Snap
		}
	}
}
