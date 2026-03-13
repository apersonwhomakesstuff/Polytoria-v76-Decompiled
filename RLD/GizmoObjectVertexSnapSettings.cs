using System;

namespace RLD
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class GizmoObjectVertexSnapSettings : Settings
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0001637E File Offset: 0x0001457E
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00016381 File Offset: 0x00014581
		public int SnapDestinationLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00016383 File Offset: 0x00014583
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00016386 File Offset: 0x00014586
		public bool CanSnapToGrid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00016388 File Offset: 0x00014588
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0001638B File Offset: 0x0001458B
		public bool CanSnapToObjectVerts
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001638D File Offset: 0x0001458D
		public bool IsLayerSnapDestination(int objectLayer)
		{
			return false;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00016390 File Offset: 0x00014590
		public void SetLayerSnapDestination(int objectLayer, bool isSnapDestination)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00016392 File Offset: 0x00014592
		public void Transfer(GizmoObjectVertexSnapSettings destination)
		{
		}

		// Token: 0x040000FA RID: 250
		private int _snapDestinationLayers;

		// Token: 0x040000FB RID: 251
		private bool _canSnapToGrid;

		// Token: 0x040000FC RID: 252
		private bool _canSnapToObjectVerts;
	}
}
