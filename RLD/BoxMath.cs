using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200014F RID: 335
	public static class BoxMath
	{
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00018AF9 File Offset: 0x00016CF9
		public static List<BoxFace> AllBoxFaces
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00018AFC File Offset: 0x00016CFC
		public static int GetFaceAxisIndex(BoxFace face)
		{
			return 0;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0002156C File Offset: 0x0001F76C
		public static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			return default(BoxFaceDesc);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00021584 File Offset: 0x0001F784
		public static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 viewVector)
		{
			return default(BoxFaceDesc);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0002159C File Offset: 0x0001F79C
		public static BoxFace GetMostAlignedFace(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 direction)
		{
			return BoxFace.Front;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x000215B4 File Offset: 0x0001F7B4
		public static Vector3 CalcBoxFaceSize(Vector3 boxSize, BoxFace boxFace)
		{
			return default(Vector3);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000215CC File Offset: 0x0001F7CC
		public static BoxFaceAreaDesc GetBoxFaceAreaDesc(Vector3 boxSize, BoxFace boxFace)
		{
			return default(BoxFaceAreaDesc);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000215E4 File Offset: 0x0001F7E4
		public static Plane CalcBoxFacePlane(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			return default(Plane);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000215FC File Offset: 0x0001F7FC
		public static Vector3 CalcBoxFaceNormal(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			return default(Vector3);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00021614 File Offset: 0x0001F814
		public static Vector3 CalcBoxFaceCenter(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			return default(Vector3);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00018AFF File Offset: 0x00016CFF
		public static List<Vector3> CalcBoxCornerPoints(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			return null;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00018B02 File Offset: 0x00016D02
		public static void TransformBox(Vector3 boxCenter, Vector3 boxSize, Matrix4x4 transformMatrix, out Vector3 newBoxCenter, out Vector3 newBoxSize)
		{
			newBoxCenter = default(Vector3);
			newBoxSize = default(Vector3);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00018B13 File Offset: 0x00016D13
		public static bool BoxIntersectsBox(Vector3 center0, Vector3 size0, Quaternion rotation0, Vector3 center1, Vector3 size1, Quaternion rotation1)
		{
			return false;
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0002162C File Offset: 0x0001F82C
		public static Vector3 CalcBoxPtClosestToPt(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			return default(Vector3);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00018B16 File Offset: 0x00016D16
		public static bool Raycast(Ray ray, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			return false;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00018B19 File Offset: 0x00016D19
		public static bool Raycast(Ray ray, out float t, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00018B23 File Offset: 0x00016D23
		public static bool ContainsPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			return false;
		}

		// Token: 0x040005CC RID: 1484
		private static List<BoxFace> _allBoxFaces;

		// Token: 0x040005CD RID: 1485
		private static Vector3[] A;

		// Token: 0x040005CE RID: 1486
		private static Vector3[] B;

		// Token: 0x040005CF RID: 1487
		private static float[,] R;

		// Token: 0x040005D0 RID: 1488
		private static float[,] absR;
	}
}
