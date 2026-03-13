using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class LTBezier
{
	// Token: 0x060000F6 RID: 246 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000BFEC File Offset: 0x0000A1EC
	private float map(float u)
	{
		return 0f;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
	public Vector3 point(float t)
	{
		return default(Vector3);
	}

	// Token: 0x040000A2 RID: 162
	public float length;

	// Token: 0x040000A3 RID: 163
	private Vector3 a;

	// Token: 0x040000A4 RID: 164
	private Vector3 aa;

	// Token: 0x040000A5 RID: 165
	private Vector3 bb;

	// Token: 0x040000A6 RID: 166
	private Vector3 cc;

	// Token: 0x040000A7 RID: 167
	private float len;

	// Token: 0x040000A8 RID: 168
	private float[] arcLengths;
}
