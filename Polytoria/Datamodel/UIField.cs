using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using SoftMasking;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B4 RID: 692
	public class UIField : Instance, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00025000 File Offset: 0x00023200
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x0001BA32 File Offset: 0x00019C32
		public Vector2 PositionOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x00025018 File Offset: 0x00023218
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x0001BA34 File Offset: 0x00019C34
		public Vector2 PositionRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0001BA36 File Offset: 0x00019C36
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x0001BA3D File Offset: 0x00019C3D
		public float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x00025030 File Offset: 0x00023230
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0001BA3F File Offset: 0x00019C3F
		public Vector2 SizeOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00025048 File Offset: 0x00023248
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x0001BA41 File Offset: 0x00019C41
		public Vector2 SizeRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00025060 File Offset: 0x00023260
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x0001BA43 File Offset: 0x00019C43
		public Vector2 PivotPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0001BA45 File Offset: 0x00019C45
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x0001BA48 File Offset: 0x00019C48
		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0001BA4A File Offset: 0x00019C4A
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x0001BA4D File Offset: 0x00019C4D
		public bool ClipDescendants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0001BA4F File Offset: 0x00019C4F
		private void SyncSetPositionOffset(Vector2 oldValue, Vector2 newValue)
		{
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0001BA51 File Offset: 0x00019C51
		private void SyncSetSizeOffset(Vector2 oldValue, Vector2 newValue)
		{
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0001BA53 File Offset: 0x00019C53
		private void SyncSetPositionRelative(Vector2 oldValue, Vector2 newValue)
		{
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0001BA55 File Offset: 0x00019C55
		private void SyncSetSizeRelative(Vector2 oldValue, Vector2 newValue)
		{
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0001BA57 File Offset: 0x00019C57
		private void SyncSetRotation(float oldValue, float newValue)
		{
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0001BA59 File Offset: 0x00019C59
		private void SyncSetPivotPoint(Vector2 oldValue, Vector2 newValue)
		{
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0001BA5B File Offset: 0x00019C5B
		private void SyncSetVisible(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0001BA5D File Offset: 0x00019C5D
		private void SyncSetClipDescendants(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0001BA5F File Offset: 0x00019C5F
		protected override void Awake()
		{
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0001BA61 File Offset: 0x00019C61
		private void UpdateVisibility()
		{
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x0001BA63 File Offset: 0x00019C63
		protected override void Start()
		{
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x0001BA65 File Offset: 0x00019C65
		private void Update()
		{
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0001BA67 File Offset: 0x00019C67
		protected override void OnHide()
		{
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0001BA69 File Offset: 0x00019C69
		protected override void OnShow()
		{
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0001BA6B File Offset: 0x00019C6B
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0001BA6D File Offset: 0x00019C6D
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x0001BA6F File Offset: 0x00019C6F
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0001BA71 File Offset: 0x00019C71
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0001BA73 File Offset: 0x00019C73
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0001BA7D File Offset: 0x00019C7D
		private void <Awake>b__46_0()
		{
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0001BA7F File Offset: 0x00019C7F
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x00025078 File Offset: 0x00023278
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0001BA82 File Offset: 0x00019C82
		public Vector2 NetworkpositionOffset
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00025090 File Offset: 0x00023290
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x0001BA84 File Offset: 0x00019C84
		public Vector2 NetworksizeOffset
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x000250A8 File Offset: 0x000232A8
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x0001BA86 File Offset: 0x00019C86
		public Vector2 NetworkpositionRelative
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x000250C0 File Offset: 0x000232C0
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x0001BA88 File Offset: 0x00019C88
		public Vector2 NetworksizeRelative
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0001BA8A File Offset: 0x00019C8A
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x0001BA91 File Offset: 0x00019C91
		public float Networkrotation
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

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x000250D8 File Offset: 0x000232D8
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x0001BA93 File Offset: 0x00019C93
		public Vector2 NetworkpivotPoint
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0001BA95 File Offset: 0x00019C95
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0001BA98 File Offset: 0x00019C98
		public bool Networkvisible
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0001BA9A File Offset: 0x00019C9A
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x0001BA9D File Offset: 0x00019C9D
		public bool NetworkclipDescendants
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0001BA9F File Offset: 0x00019C9F
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0001BAA1 File Offset: 0x00019CA1
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C29 RID: 3113
		public LuaEvent MouseUp;

		// Token: 0x04000C2A RID: 3114
		public LuaEvent MouseDown;

		// Token: 0x04000C2B RID: 3115
		private Vector2 positionOffset;

		// Token: 0x04000C2C RID: 3116
		private Vector2 sizeOffset;

		// Token: 0x04000C2D RID: 3117
		private Vector2 positionRelative;

		// Token: 0x04000C2E RID: 3118
		private Vector2 sizeRelative;

		// Token: 0x04000C2F RID: 3119
		private float rotation;

		// Token: 0x04000C30 RID: 3120
		private Vector2 pivotPoint;

		// Token: 0x04000C31 RID: 3121
		private bool visible;

		// Token: 0x04000C32 RID: 3122
		private bool clipDescendants;

		// Token: 0x04000C33 RID: 3123
		private RectTransform parentRect;

		// Token: 0x04000C34 RID: 3124
		private RectTransform recttransform;

		// Token: 0x04000C35 RID: 3125
		private SoftMask mask;

		// Token: 0x04000C36 RID: 3126
		private bool hasHVLayoutParent;

		// Token: 0x04000C37 RID: 3127
		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionOffset;

		// Token: 0x04000C38 RID: 3128
		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeOffset;

		// Token: 0x04000C39 RID: 3129
		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionRelative;

		// Token: 0x04000C3A RID: 3130
		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeRelative;

		// Token: 0x04000C3B RID: 3131
		public Action<float, float> _Mirror_SyncVarHookDelegate_rotation;

		// Token: 0x04000C3C RID: 3132
		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_pivotPoint;

		// Token: 0x04000C3D RID: 3133
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_visible;

		// Token: 0x04000C3E RID: 3134
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_clipDescendants;
	}
}
