using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000131 RID: 305
	public static class Vector3Ex
	{
		// Token: 0x06000FB7 RID: 4023 RVA: 0x000188D8 File Offset: 0x00016AD8
		public static void OffsetPoints(List<Vector3> points, Vector3 offset)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00020C64 File Offset: 0x0001EE64
		public static Vector2 ConvertDirTo2D(Vector3 start, Vector3 end, Camera camera)
		{
			return default(Vector2);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00020C7C File Offset: 0x0001EE7C
		public static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00020C94 File Offset: 0x0001EE94
		public static Vector3 GetSignVector(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000188DA File Offset: 0x00016ADA
		public static float GetMaxAbsComp(Vector3 v)
		{
			return 0f;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000188E1 File Offset: 0x00016AE1
		public static float Dot(Vector3 v1, Vector3 v2)
		{
			return 0f;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000188E8 File Offset: 0x00016AE8
		public static float AbsDot(Vector3 v1, Vector3 v2)
		{
			return 0f;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00020CAC File Offset: 0x0001EEAC
		public static Vector3 FromValue(float value)
		{
			return default(Vector3);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x000188EF File Offset: 0x00016AEF
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			return 0f;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000188F6 File Offset: 0x00016AF6
		public static float GetDistanceToSegment(Vector3 point, Vector3 point0, Vector3 point1)
		{
			return 0f;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00020CC4 File Offset: 0x0001EEC4
		public static Vector3 ProjectOnSegment(Vector3 point, Vector3 point0, Vector3 point1)
		{
			return default(Vector3);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000188FD File Offset: 0x00016AFD
		public static int GetPointClosestToPoint(List<Vector3> points, Vector3 pt)
		{
			return 0;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00020CDC File Offset: 0x0001EEDC
		public static Vector3 GetPointCloudCenter(IEnumerable<Vector3> ptCloud)
		{
			return default(Vector3);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		public static Vector3 GetInverse(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00018900 File Offset: 0x00016B00
		public static bool IsAligned(Vector3 vector, Vector3 other, bool checkSameDirection)
		{
			return false;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00018903 File Offset: 0x00016B03
		public static bool PointsSameDir(Vector3 vector, Vector3 other)
		{
			return false;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00018906 File Offset: 0x00016B06
		public static int GetMostAligned(Vector3[] vectors, Vector3 dir, bool checkSameDirection)
		{
			return 0;
		}
	}
}
