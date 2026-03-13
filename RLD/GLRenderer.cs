using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A4 RID: 420
	public static class GLRenderer
	{
		// Token: 0x06001290 RID: 4752 RVA: 0x00019148 File Offset: 0x00017348
		public static void DrawQuads2D(List<Vector2> quadPoints, Camera camera)
		{
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0001914A File Offset: 0x0001734A
		public static void DrawLineLoop2D(List<Vector2> linePoints, Camera camera)
		{
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0001914C File Offset: 0x0001734C
		public static void DrawLineLoop2D(List<Vector2> linePoints, Vector2 translation, Vector2 scale, Camera camera)
		{
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0001914E File Offset: 0x0001734E
		public static void DrawLines2D(List<Vector2> linePoints, Camera camera)
		{
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00019150 File Offset: 0x00017350
		public static void DrawLines2D(List<Vector2> linePoints, Vector2 translation, Vector2 scale, Camera camera)
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00019152 File Offset: 0x00017352
		public static void DrawLine2D(Vector2 startPoint, Vector2 endPoint, Camera camera)
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00019154 File Offset: 0x00017354
		public static void DrawLine3D(Vector3 startPoint, Vector3 endPoint)
		{
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00019156 File Offset: 0x00017356
		public static void DrawLines3D(List<Vector3> linePoints)
		{
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00019158 File Offset: 0x00017358
		public static void DrawLineLoop3D(List<Vector3> linePoints)
		{
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0001915A File Offset: 0x0001735A
		public static void DrawLineStrip3D(List<Vector3> linePoints)
		{
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0001915C File Offset: 0x0001735C
		public static void DrawLineLoop3D(List<Vector3> linePoints, Vector3 pointOffset)
		{
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0001915E File Offset: 0x0001735E
		public static void DrawLinePairs3D(List<Vector3> pairPoints)
		{
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00019160 File Offset: 0x00017360
		public static void DrawRectBorder2D(Rect rect, Camera camera)
		{
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00019162 File Offset: 0x00017362
		public static void DrawRect2D(Rect rect, Camera camera)
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00019164 File Offset: 0x00017364
		public static void DrawCircleBorder2D(Vector2 circleCenter, float circleRadius, int numPoints, Camera camera)
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00019166 File Offset: 0x00017366
		public static void DrawCircle2D(Vector2 circleCenter, float circleRadius, int numPoints, Camera camera)
		{
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00019168 File Offset: 0x00017368
		public static void DrawCircleBorder3D(Vector3 circleCenter, float circleRadius, Vector3 circleRight, Vector3 circleUp, int numPoints)
		{
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0001916A File Offset: 0x0001736A
		public static void DrawCircle3D(Vector2 circleCenter, float circleRadius, Vector3 circleRight, Vector3 circleUp, int numPoints)
		{
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0001916C File Offset: 0x0001736C
		public static void DrawSphereBorder(Camera camera, Vector3 sphereCenter, float sphereRadius, int numPoints)
		{
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0001916E File Offset: 0x0001736E
		public static void DrawTriangleFan2D(Vector2 origin, List<Vector2> points, Vector2 translation, Vector2 scale, Camera camera)
		{
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00019170 File Offset: 0x00017370
		public static void DrawTriangleFan2D(Vector2 origin, List<Vector2> points, Camera camera)
		{
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00019172 File Offset: 0x00017372
		public static void DrawTriangleFan3D(Vector3 origin, List<Vector3> points, Vector3 translation, Vector3 scale)
		{
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00019174 File Offset: 0x00017374
		public static void DrawTriangleFan3D(Vector3 origin, List<Vector3> points)
		{
		}
	}
}
