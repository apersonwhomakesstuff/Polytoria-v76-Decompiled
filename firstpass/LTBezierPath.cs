using System;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class LTBezierPath
{
	// Token: 0x060000FA RID: 250 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
	public LTBezierPath()
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000BFFB File Offset: 0x0000A1FB
	public LTBezierPath(Vector3[] pts_)
	{
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0000C003 File Offset: 0x0000A203
	public void setPoints(Vector3[] pts_)
	{
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000FD RID: 253 RVA: 0x0000C005 File Offset: 0x0000A205
	public float distance
	{
		get
		{
			return 0f;
		}
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	// Token: 0x060000FF RID: 255 RVA: 0x0000C00C File Offset: 0x0000A20C
	public void place2d(Transform transform, float ratio)
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0000C00E File Offset: 0x0000A20E
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x0000C010 File Offset: 0x0000A210
	public void place(Transform transform, float ratio)
	{
	}

	// Token: 0x06000102 RID: 258 RVA: 0x0000C012 File Offset: 0x0000A212
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0000C014 File Offset: 0x0000A214
	public void placeLocal(Transform transform, float ratio)
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0000C016 File Offset: 0x0000A216
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0000C018 File Offset: 0x0000A218
	public void gizmoDraw(float t = -1f)
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0000C01A File Offset: 0x0000A21A
	public float ratioAtPoint(Vector3 pt, float precision = 0.01f)
	{
		return 0f;
	}

	// Token: 0x040000A9 RID: 169
	public Vector3[] pts;

	// Token: 0x040000AA RID: 170
	public float length;

	// Token: 0x040000AB RID: 171
	public bool orientToPath;

	// Token: 0x040000AC RID: 172
	public bool orientToPath2d;

	// Token: 0x040000AD RID: 173
	private LTBezier[] beziers;

	// Token: 0x040000AE RID: 174
	private float[] lengthRatio;

	// Token: 0x040000AF RID: 175
	private int currentBezier;

	// Token: 0x040000B0 RID: 176
	private int previousBezier;
}
