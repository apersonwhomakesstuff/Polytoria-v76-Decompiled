using System;

namespace RLD
{
	// Token: 0x020001BC RID: 444
	public class SceneRaycastHit
	{
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000193EE File Offset: 0x000175EE
		public bool WasAnythingHit
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x000193F1 File Offset: 0x000175F1
		public bool WasAnObjectHit
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x000193F4 File Offset: 0x000175F4
		public bool WasGridHit
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x000193F7 File Offset: 0x000175F7
		public GameObjectRayHit ObjectHit
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x000193FA File Offset: 0x000175FA
		public XZGridRayHit GridHit
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x000193FD File Offset: 0x000175FD
		public SceneRaycastHit(GameObjectRayHit objectRayHit, XZGridRayHit gridRayHit)
		{
		}

		// Token: 0x04000705 RID: 1797
		private GameObjectRayHit _objectHit;

		// Token: 0x04000706 RID: 1798
		private XZGridRayHit _gridHit;
	}
}
