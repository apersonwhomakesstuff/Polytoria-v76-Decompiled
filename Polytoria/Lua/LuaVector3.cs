using System;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000269 RID: 617
	public class LuaVector3
	{
		// Token: 0x06001A77 RID: 6775 RVA: 0x00023FB0 File Offset: 0x000221B0
		public static Vector3 New()
		{
			return default(Vector3);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00023FC8 File Offset: 0x000221C8
		public static Vector3 New(float d)
		{
			return default(Vector3);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00023FE0 File Offset: 0x000221E0
		public static Vector3 New(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00023FF8 File Offset: 0x000221F8
		public static Vector3 New(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00024010 File Offset: 0x00022210
		public static Vector3 New(Vector2 v)
		{
			return default(Vector3);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0001A58A File Offset: 0x0001878A
		public static float Angle(Vector3 from, Vector3 to)
		{
			return 0f;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00024028 File Offset: 0x00022228
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			return default(Vector3);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00024040 File Offset: 0x00022240
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0001A591 File Offset: 0x00018791
		public static float Distance(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0001A598 File Offset: 0x00018798
		public static float Dot(Vector3 lhs, Vector3 rhs)
		{
			return 0f;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00024058 File Offset: 0x00022258
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00024070 File Offset: 0x00022270
		public static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00024088 File Offset: 0x00022288
		public static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000240A0 File Offset: 0x000222A0
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			return default(Vector3);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000240B8 File Offset: 0x000222B8
		public static Vector3 Normalize(Vector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x000240D0 File Offset: 0x000222D0
		public static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			return default(Vector3);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000240E8 File Offset: 0x000222E8
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00024100 File Offset: 0x00022300
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			return default(Vector3);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00024118 File Offset: 0x00022318
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			return default(Vector3);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00024130 File Offset: 0x00022330
		public static Vector3 Scale(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0001A59F File Offset: 0x0001879F
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			return 0f;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00024148 File Offset: 0x00022348
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00024160 File Offset: 0x00022360
		public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00024178 File Offset: 0x00022378
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			return default(Vector3);
		}
	}
}
