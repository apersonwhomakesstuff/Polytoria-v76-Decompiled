using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BE RID: 702
	public class UIView : UIField
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x00025360 File Offset: 0x00023560
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x0001BCEF File Offset: 0x00019EEF
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

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x00025378 File Offset: 0x00023578
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x0001BCF1 File Offset: 0x00019EF1
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

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x0001BCF3 File Offset: 0x00019EF3
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x0001BCFA File Offset: 0x00019EFA
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

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0001BCFC File Offset: 0x00019EFC
		// (set) Token: 0x0600236D RID: 9069 RVA: 0x0001BD03 File Offset: 0x00019F03
		public float CornerRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0001BD05 File Offset: 0x00019F05
		private void UpdateBorder()
		{
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0001BD07 File Offset: 0x00019F07
		private void SyncSetBorderWidth(float oldValue, float newValue)
		{
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0001BD09 File Offset: 0x00019F09
		private void SyncSetBorderColor(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0001BD0B File Offset: 0x00019F0B
		private void SyncSetCornerRadius(float oldValue, float newValue)
		{
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0001BD0D File Offset: 0x00019F0D
		private void SyncSetColor(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x0001BD0F File Offset: 0x00019F0F
		protected override void Awake()
		{
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x0001BD11 File Offset: 0x00019F11
		protected override void Start()
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0001BD13 File Offset: 0x00019F13
		protected override void OnHide()
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x0001BD15 File Offset: 0x00019F15
		protected override void OnShow()
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0001BD17 File Offset: 0x00019F17
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0001BD21 File Offset: 0x00019F21
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x00025390 File Offset: 0x00023590
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x0001BD24 File Offset: 0x00019F24
		public Color Networkcolor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0001BD26 File Offset: 0x00019F26
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x0001BD2D File Offset: 0x00019F2D
		public float NetworkborderWidth
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000253A8 File Offset: 0x000235A8
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x0001BD2F File Offset: 0x00019F2F
		public Color NetworkborderColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x0001BD31 File Offset: 0x00019F31
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0001BD38 File Offset: 0x00019F38
		public float NetworkcornerRadius
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0001BD3A File Offset: 0x00019F3A
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0001BD3C File Offset: 0x00019F3C
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000CAF RID: 3247
		private Image border;

		// Token: 0x04000CB0 RID: 3248
		private RectTransform borderRect;

		// Token: 0x04000CB1 RID: 3249
		private Image fill;

		// Token: 0x04000CB2 RID: 3250
		private Color color;

		// Token: 0x04000CB3 RID: 3251
		private float borderWidth;

		// Token: 0x04000CB4 RID: 3252
		private Color borderColor;

		// Token: 0x04000CB5 RID: 3253
		private float cornerRadius;

		// Token: 0x04000CB6 RID: 3254
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		// Token: 0x04000CB7 RID: 3255
		public Action<float, float> _Mirror_SyncVarHookDelegate_borderWidth;

		// Token: 0x04000CB8 RID: 3256
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_borderColor;

		// Token: 0x04000CB9 RID: 3257
		public Action<float, float> _Mirror_SyncVarHookDelegate_cornerRadius;
	}
}
