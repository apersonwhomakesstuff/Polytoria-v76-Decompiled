using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000126 RID: 294
	public static class Matrix4x4Ex
	{
		// Token: 0x06000F74 RID: 3956 RVA: 0x0002091C File Offset: 0x0001EB1C
		public static Matrix4x4 GetInverse(Matrix4x4 mtx)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00020934 File Offset: 0x0001EB34
		public static Matrix4x4 GetRelativeTransform(Matrix4x4 matrix, Matrix4x4 referenceTransform)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0002094C File Offset: 0x0001EB4C
		public static Matrix4x4 Translation(Vector3 translation)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00020964 File Offset: 0x0001EB64
		public static Matrix4x4 RotationMatrixFromRightUp(Vector3 right, Vector3 up)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0002097C File Offset: 0x0001EB7C
		public static Vector3 GetTranslation(Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00020994 File Offset: 0x0001EB94
		public static Vector3 GetScale(Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000209AC File Offset: 0x0001EBAC
		public static Vector3 GetNormalizedAxis(Matrix4x4 matrix, int axisIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00018869 File Offset: 0x00016A69
		public static Vector3[] GetNormalizedAxes(Matrix4x4 matrix)
		{
			return null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0001886C File Offset: 0x00016A6C
		public static List<Vector3> TransformPoints(Matrix4x4 matrix, List<Vector3> points)
		{
			return null;
		}
	}
}
