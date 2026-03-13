using System;

namespace RLD
{
	// Token: 0x020001D4 RID: 468
	[Serializable]
	public class ObjectLayerGrabSettings
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0001963C File Offset: 0x0001783C
		public int Layer
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0001963F File Offset: 0x0001783F
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00019642 File Offset: 0x00017842
		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x00019644 File Offset: 0x00017844
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x00019647 File Offset: 0x00017847
		public bool AlignAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x00021E3C File Offset: 0x0002003C
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x00019649 File Offset: 0x00017849
		public TransformAxis AlignmentAxis
		{
			get
			{
				return TransformAxis.PositiveX;
			}
			set
			{
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0001964B File Offset: 0x0001784B
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x00019652 File Offset: 0x00017852
		public float DefaultOffsetFromSurface
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00019654 File Offset: 0x00017854
		public ObjectLayerGrabSettings(int layer)
		{
		}

		// Token: 0x04000771 RID: 1905
		private int _layer;

		// Token: 0x04000772 RID: 1906
		private bool _isActive;

		// Token: 0x04000773 RID: 1907
		private bool _alignAxis;

		// Token: 0x04000774 RID: 1908
		private TransformAxis _alignmentAxis;

		// Token: 0x04000775 RID: 1909
		private float _defaultOffsetFromSurface;
	}
}
