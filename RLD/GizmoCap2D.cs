using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000D RID: 13
	public class GizmoCap2D : GizmoCap
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0001DE2C File Offset: 0x0001C02C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00015E7E File Offset: 0x0001407E
		public Vector2 Position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0001DE44 File Offset: 0x0001C044
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00015E80 File Offset: 0x00014080
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00015E87 File Offset: 0x00014087
		public float RotationDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00015E89 File Offset: 0x00014089
		public GizmoOverrideColor OverrideFillColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00015E8C File Offset: 0x0001408C
		public GizmoOverrideColor OverrideBorderColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00015E8F File Offset: 0x0001408F
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00015E92 File Offset: 0x00014092
		public IGizmoDragSession DragSession
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00015E94 File Offset: 0x00014094
		public GizmoCap2DLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00015E97 File Offset: 0x00014097
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00015E9A File Offset: 0x0001409A
		public GizmoCap2DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00015E9C File Offset: 0x0001409C
		public GizmoCap2D(Gizmo gizmo, int handleId) : base(null, 0)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00015EA6 File Offset: 0x000140A6
		public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00015EA8 File Offset: 0x000140A8
		public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00015EAA File Offset: 0x000140AA
		public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector2 axis)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00015EAC File Offset: 0x000140AC
		public float GetRealQuadWidth()
		{
			return 0f;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00015EB3 File Offset: 0x000140B3
		public float GetRealQuadHeight()
		{
			return 0f;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00015EBA File Offset: 0x000140BA
		public float GetRealCircleRadius()
		{
			return 0f;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00015EC1 File Offset: 0x000140C1
		public float GetRealArrowHeight()
		{
			return 0f;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00015EC8 File Offset: 0x000140C8
		public float GetRealArrowBaseRadius()
		{
			return 0f;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00015ECF File Offset: 0x000140CF
		public void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00015ED1 File Offset: 0x000140D1
		public void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00015ED3 File Offset: 0x000140D3
		public override void Render(Camera camera)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00015ED5 File Offset: 0x000140D5
		public void Refresh()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00015ED7 File Offset: 0x000140D7
		protected override void OnVisibilityStateChanged()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00015ED9 File Offset: 0x000140D9
		protected override void OnHoverableStateChanged()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00015EDB File Offset: 0x000140DB
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00015EDD File Offset: 0x000140DD
		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00015EDF File Offset: 0x000140DF
		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		// Token: 0x04000016 RID: 22
		private int _quadIndex;

		// Token: 0x04000017 RID: 23
		private QuadShape2D _quad;

		// Token: 0x04000018 RID: 24
		private int _circleIndex;

		// Token: 0x04000019 RID: 25
		private CircleShape2D _circle;

		// Token: 0x0400001A RID: 26
		private int _arrowIndex;

		// Token: 0x0400001B RID: 27
		private ConeShape2D _arrow;

		// Token: 0x0400001C RID: 28
		private GizmoTransform _transform;

		// Token: 0x0400001D RID: 29
		private GizmoOverrideColor _overrideFillColor;

		// Token: 0x0400001E RID: 30
		private GizmoOverrideColor _overrideBorderColor;

		// Token: 0x0400001F RID: 31
		private GizmoCap2DControllerData _controllerData;

		// Token: 0x04000020 RID: 32
		private IGizmoCap2DController[] _controllers;

		// Token: 0x04000021 RID: 33
		private GizmoCap2DLookAndFeel _lookAndFeel;

		// Token: 0x04000022 RID: 34
		private GizmoCap2DLookAndFeel _sharedLookAndFeel;
	}
}
