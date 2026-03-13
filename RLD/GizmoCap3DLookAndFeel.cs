using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class GizmoCap3DLookAndFeel
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0001DF34 File Offset: 0x0001C134
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0001607A File Offset: 0x0001427A
		public GizmoCap3DType CapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0001DF4C File Offset: 0x0001C14C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0001607C File Offset: 0x0001427C
		public GizmoFillMode3D FillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0001DF64 File Offset: 0x0001C164
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0001607E File Offset: 0x0001427E
		public GizmoShadeMode ShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00016080 File Offset: 0x00014280
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00016087 File Offset: 0x00014287
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00016089 File Offset: 0x00014289
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0001608C File Offset: 0x0001428C
		public bool UseZoomFactor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0001608E File Offset: 0x0001428E
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00016095 File Offset: 0x00014295
		public float ConeHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00016097 File Offset: 0x00014297
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0001609E File Offset: 0x0001429E
		public float ConeRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000160A0 File Offset: 0x000142A0
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000160A7 File Offset: 0x000142A7
		public float PyramidHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000160A9 File Offset: 0x000142A9
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000160B0 File Offset: 0x000142B0
		public float PyramidWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000160B2 File Offset: 0x000142B2
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000160B9 File Offset: 0x000142B9
		public float PyramidDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000160BB File Offset: 0x000142BB
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000160C2 File Offset: 0x000142C2
		public float BoxWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000160C4 File Offset: 0x000142C4
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000160CB File Offset: 0x000142CB
		public float BoxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000160CD File Offset: 0x000142CD
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000160D4 File Offset: 0x000142D4
		public float BoxDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000160D6 File Offset: 0x000142D6
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000160DD File Offset: 0x000142DD
		public float SphereRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000160DF File Offset: 0x000142DF
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000160E6 File Offset: 0x000142E6
		public float TrPrismWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000160E8 File Offset: 0x000142E8
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000160EF File Offset: 0x000142EF
		public float TrPrismHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000160F1 File Offset: 0x000142F1
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000160F8 File Offset: 0x000142F8
		public float TrPrismDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000160FA File Offset: 0x000142FA
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000160FD File Offset: 0x000142FD
		public bool IsSphereBorderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0001DF7C File Offset: 0x0001C17C
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000160FF File Offset: 0x000142FF
		public Color SphereBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00016101 File Offset: 0x00014301
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00016104 File Offset: 0x00014304
		public int NumSphereBorderPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0001DF94 File Offset: 0x0001C194
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00016106 File Offset: 0x00014306
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0001DFAC File Offset: 0x0001C1AC
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00016108 File Offset: 0x00014308
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0001610A File Offset: 0x0001430A
		public static float DefaultConeHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00016111 File Offset: 0x00014311
		public static float DefaultConeRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00016118 File Offset: 0x00014318
		public static float DefaultPyramidHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0001611F File Offset: 0x0001431F
		public static float DefaultPyramidWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00016126 File Offset: 0x00014326
		public static float DefaultPyramidDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x0400005F RID: 95
		private GizmoCap3DType _capType;

		// Token: 0x04000060 RID: 96
		private GizmoFillMode3D _fillMode;

		// Token: 0x04000061 RID: 97
		private GizmoShadeMode _shadeMode;

		// Token: 0x04000062 RID: 98
		private float _scale;

		// Token: 0x04000063 RID: 99
		private bool _useZoomFactor;

		// Token: 0x04000064 RID: 100
		private float _coneHeight;

		// Token: 0x04000065 RID: 101
		private float _coneRadius;

		// Token: 0x04000066 RID: 102
		private float _pyramidHeight;

		// Token: 0x04000067 RID: 103
		private float _pyramidWidth;

		// Token: 0x04000068 RID: 104
		private float _pyramidDepth;

		// Token: 0x04000069 RID: 105
		private float _boxWidth;

		// Token: 0x0400006A RID: 106
		private float _boxHeight;

		// Token: 0x0400006B RID: 107
		private float _boxDepth;

		// Token: 0x0400006C RID: 108
		private float _sphereRadius;

		// Token: 0x0400006D RID: 109
		private float _trPrismWidth;

		// Token: 0x0400006E RID: 110
		private float _trPrismHeight;

		// Token: 0x0400006F RID: 111
		private float _trPrismDepth;

		// Token: 0x04000070 RID: 112
		private bool _isSphereBorderVisible;

		// Token: 0x04000071 RID: 113
		private Color _sphereBorderColor;

		// Token: 0x04000072 RID: 114
		private int _numSphereBorderPoints;

		// Token: 0x04000073 RID: 115
		private Color _color;

		// Token: 0x04000074 RID: 116
		private Color _hoveredColor;
	}
}
