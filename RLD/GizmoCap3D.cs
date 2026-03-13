using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000017 RID: 23
	public class GizmoCap3D : GizmoCap
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0001DEEC File Offset: 0x0001C0EC
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00015FA7 File Offset: 0x000141A7
		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0001DF04 File Offset: 0x0001C104
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00015FA9 File Offset: 0x000141A9
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00015FAB File Offset: 0x000141AB
		public GizmoOverrideColor OverrideColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00015FAE File Offset: 0x000141AE
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00015FB1 File Offset: 0x000141B1
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00015FB3 File Offset: 0x000141B3
		public GizmoCap3DLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00015FB6 File Offset: 0x000141B6
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00015FB9 File Offset: 0x000141B9
		public GizmoCap3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00015FBB File Offset: 0x000141BB
		public GizmoCap3D(Gizmo gizmo, int handleId) : base(null, 0)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00015FC5 File Offset: 0x000141C5
		public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00015FC7 File Offset: 0x000141C7
		public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00015FC9 File Offset: 0x000141C9
		public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector3 axis)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00015FCB File Offset: 0x000141CB
		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00015FCD File Offset: 0x000141CD
		public void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00015FCF File Offset: 0x000141CF
		public void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00015FD1 File Offset: 0x000141D1
		public float GetSliderAlignedRealLength(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00015FD8 File Offset: 0x000141D8
		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00015FDF File Offset: 0x000141DF
		public float GetRealConeHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00015FE6 File Offset: 0x000141E6
		public float GetRealConeRadius(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00015FED File Offset: 0x000141ED
		public float GetRealPyramidWidth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00015FF4 File Offset: 0x000141F4
		public float GetRealPyramidDepth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00015FFB File Offset: 0x000141FB
		public float GetRealPyramidHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00016002 File Offset: 0x00014202
		public float GetRealBoxWidth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00016009 File Offset: 0x00014209
		public float GetRealBoxHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00016010 File Offset: 0x00014210
		public float GetRealBoxDepth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001DF1C File Offset: 0x0001C11C
		public Vector3 GetRealBoxSize(float zoomFactor)
		{
			return default(Vector3);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00016017 File Offset: 0x00014217
		public float GetRealSphereRadius(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0001601E File Offset: 0x0001421E
		public float GetRealTriPrismWidth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00016025 File Offset: 0x00014225
		public float GetRealTriPrismHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0001602C File Offset: 0x0001422C
		public float GetRealTriPrismDepth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00016033 File Offset: 0x00014233
		public void ApplyZoomFactor(Camera camera)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00016035 File Offset: 0x00014235
		public override void Render(Camera camera)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00016037 File Offset: 0x00014237
		public void Refresh()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00016039 File Offset: 0x00014239
		protected override void OnVisibilityStateChanged()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001603B File Offset: 0x0001423B
		protected override void OnHoverableStateChanged()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001603D File Offset: 0x0001423D
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001603F File Offset: 0x0001423F
		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00016041 File Offset: 0x00014241
		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00016043 File Offset: 0x00014243
		private void OnGizmoPostDisabled(Gizmo gizmo)
		{
		}

		// Token: 0x0400003F RID: 63
		private int _coneIndex;

		// Token: 0x04000040 RID: 64
		private ConeShape3D _cone;

		// Token: 0x04000041 RID: 65
		private int _pyramidIndex;

		// Token: 0x04000042 RID: 66
		private PyramidShape3D _pyramid;

		// Token: 0x04000043 RID: 67
		private int _boxIndex;

		// Token: 0x04000044 RID: 68
		private BoxShape3D _box;

		// Token: 0x04000045 RID: 69
		private int _sphereIndex;

		// Token: 0x04000046 RID: 70
		private SphereShape3D _sphere;

		// Token: 0x04000047 RID: 71
		private int _trPrismIndex;

		// Token: 0x04000048 RID: 72
		private TriangPrismShape3D _trPrism;

		// Token: 0x04000049 RID: 73
		private GizmoCap3DControllerData _controllerData;

		// Token: 0x0400004A RID: 74
		private IGizmoCap3DController[] _controllers;

		// Token: 0x0400004B RID: 75
		private GizmoTransform _transform;

		// Token: 0x0400004C RID: 76
		private GizmoOverrideColor _overrideColor;

		// Token: 0x0400004D RID: 77
		private GizmoCap3DLookAndFeel _lookAndFeel;

		// Token: 0x0400004E RID: 78
		private GizmoCap3DLookAndFeel _sharedLookAndFeel;
	}
}
