using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D0 RID: 720
	public class BodyPositionProxy : InstanceProxy
	{
		// Token: 0x06002449 RID: 9289 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		public BodyPositionProxy(BodyPosition target) : base(null)
		{
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000254F8 File Offset: 0x000236F8
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0001BFB1 File Offset: 0x0001A1B1
		public Vector3 TargetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x0001BFB3 File Offset: 0x0001A1B3
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x0001BFBA File Offset: 0x0001A1BA
		public float Force
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x0001BFBC File Offset: 0x0001A1BC
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x0001BFC3 File Offset: 0x0001A1C3
		public float AcceptanceDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000CFC RID: 3324
		private readonly BodyPosition bodyPosition;
	}
}
