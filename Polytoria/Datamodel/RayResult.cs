using System;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027B RID: 635
	public struct RayResult
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0001A9AB File Offset: 0x00018BAB
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0001A9B3 File Offset: 0x00018BB3
		public Vector3 Origin
		{
			get
			{
				return this.<Origin>k__BackingField;
			}
			set
			{
				this.<Origin>k__BackingField = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0001A9BC File Offset: 0x00018BBC
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		public Vector3 Direction
		{
			get
			{
				return this.<Direction>k__BackingField;
			}
			set
			{
				this.<Direction>k__BackingField = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0001A9CD File Offset: 0x00018BCD
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0001A9D5 File Offset: 0x00018BD5
		public Vector3 Position
		{
			get
			{
				return this.<Position>k__BackingField;
			}
			set
			{
				this.<Position>k__BackingField = value;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x0001A9DE File Offset: 0x00018BDE
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0001A9E6 File Offset: 0x00018BE6
		public Vector3 Normal
		{
			get
			{
				return this.<Normal>k__BackingField;
			}
			set
			{
				this.<Normal>k__BackingField = value;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x0001A9EF File Offset: 0x00018BEF
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0001A9F7 File Offset: 0x00018BF7
		public float Distance
		{
			get
			{
				return this.<Distance>k__BackingField;
			}
			set
			{
				this.<Distance>k__BackingField = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0001AA00 File Offset: 0x00018C00
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x0001AA08 File Offset: 0x00018C08
		public Instance Instance
		{
			get
			{
				return this.<Instance>k__BackingField;
			}
			set
			{
				this.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x04000A45 RID: 2629
		private Vector3 <Origin>k__BackingField;

		// Token: 0x04000A46 RID: 2630
		private Vector3 <Direction>k__BackingField;

		// Token: 0x04000A47 RID: 2631
		private Vector3 <Position>k__BackingField;

		// Token: 0x04000A48 RID: 2632
		private Vector3 <Normal>k__BackingField;

		// Token: 0x04000A49 RID: 2633
		private float <Distance>k__BackingField;

		// Token: 0x04000A4A RID: 2634
		private Instance <Instance>k__BackingField;
	}
}
