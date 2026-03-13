using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class GizmoCap2DLookAndFeel
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0001DE5C File Offset: 0x0001C05C
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00015F15 File Offset: 0x00014115
		public GizmoFillMode2D FillMode
		{
			get
			{
				return GizmoFillMode2D.Filled;
			}
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0001DE74 File Offset: 0x0001C074
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00015F17 File Offset: 0x00014117
		public GizmoCap2DType CapType
		{
			get
			{
				return GizmoCap2DType.Quad;
			}
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00015F19 File Offset: 0x00014119
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00015F20 File Offset: 0x00014120
		public float Scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00015F22 File Offset: 0x00014122
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00015F29 File Offset: 0x00014129
		public float CircleRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00015F2B File Offset: 0x0001412B
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00015F32 File Offset: 0x00014132
		public float QuadWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00015F34 File Offset: 0x00014134
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00015F3B File Offset: 0x0001413B
		public float QuadHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00015F3D File Offset: 0x0001413D
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00015F44 File Offset: 0x00014144
		public float ArrowBaseRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00015F46 File Offset: 0x00014146
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00015F4D File Offset: 0x0001414D
		public float ArrowHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0001DE8C File Offset: 0x0001C08C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00015F4F File Offset: 0x0001414F
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0001DEA4 File Offset: 0x0001C0A4
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00015F51 File Offset: 0x00014151
		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00015F53 File Offset: 0x00014153
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0001DED4 File Offset: 0x0001C0D4
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00015F55 File Offset: 0x00014155
		public Color HoveredBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x0400002F RID: 47
		private GizmoFillMode2D _fillMode;

		// Token: 0x04000030 RID: 48
		private GizmoCap2DType _capType;

		// Token: 0x04000031 RID: 49
		private float _scale;

		// Token: 0x04000032 RID: 50
		private float _circleRadius;

		// Token: 0x04000033 RID: 51
		private float _quadWidth;

		// Token: 0x04000034 RID: 52
		private float _quadHeight;

		// Token: 0x04000035 RID: 53
		private float _arrowBaseRadius;

		// Token: 0x04000036 RID: 54
		private float _arrowHeight;

		// Token: 0x04000037 RID: 55
		private Color _color;

		// Token: 0x04000038 RID: 56
		private Color _hoveredColor;

		// Token: 0x04000039 RID: 57
		private Color _borderColor;

		// Token: 0x0400003A RID: 58
		private Color _hoveredBorderColor;
	}
}
