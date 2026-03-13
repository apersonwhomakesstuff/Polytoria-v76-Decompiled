using System;

namespace UnityEngine.UI.ProceduralImage
{
	// Token: 0x02000343 RID: 835
	public class ProceduralImage : Image
	{
		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x0001D02B File Offset: 0x0001B22B
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x0001D02E File Offset: 0x0001B22E
		private static Material DefaultProceduralImageMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x0001D030 File Offset: 0x0001B230
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x0001D037 File Offset: 0x0001B237
		public float BorderWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x0001D039 File Offset: 0x0001B239
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x0001D040 File Offset: 0x0001B240
		public float FalloffDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0001D042 File Offset: 0x0001B242
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x0001D045 File Offset: 0x0001B245
		protected ProceduralImageModifier Modifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x0001D047 File Offset: 0x0001B247
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x0001D04A File Offset: 0x0001B24A
		public System.Type ModifierType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x0001D04C File Offset: 0x0001B24C
		protected override void OnEnable()
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0001D04E File Offset: 0x0001B24E
		protected override void OnDisable()
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x0001D050 File Offset: 0x0001B250
		private void Init()
		{
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0001D052 File Offset: 0x0001B252
		protected void OnVerticesDirty()
		{
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0001D054 File Offset: 0x0001B254
		protected void FixTexCoordsInCanvas()
		{
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0001D056 File Offset: 0x0001B256
		protected void FixTexCoordsInCanvas(Canvas c)
		{
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000262D8 File Offset: 0x000244D8
		private Vector4 FixRadius(Vector4 vec)
		{
			return default(Vector4);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0001D058 File Offset: 0x0001B258
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x0001D05A File Offset: 0x0001B25A
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000262F0 File Offset: 0x000244F0
		private ProceduralImageInfo CalculateInfo()
		{
			return default(ProceduralImageInfo);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x0001D05C File Offset: 0x0001B25C
		private void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info)
		{
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x0001D05E File Offset: 0x0001B25E
		private float EncodeFloats_0_1_16_16(float a, float b)
		{
			return 0f;
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x0001D065 File Offset: 0x0001B265
		// (set) Token: 0x060029B9 RID: 10681 RVA: 0x0001D068 File Offset: 0x0001B268
		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x04000E62 RID: 3682
		private float borderWidth;

		// Token: 0x04000E63 RID: 3683
		private ProceduralImageModifier modifier;

		// Token: 0x04000E64 RID: 3684
		private static Material materialInstance;

		// Token: 0x04000E65 RID: 3685
		private float falloffDistance;
	}
}
