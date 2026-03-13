using System;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Serializable]
public class LTSpline
{
	// Token: 0x06000107 RID: 263 RVA: 0x0000C021 File Offset: 0x0000A221
	public LTSpline(Vector3[] pts)
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000C029 File Offset: 0x0000A229
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x0000C031 File Offset: 0x0000A231
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0000FA10 File Offset: 0x0000DC10
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0000FA28 File Offset: 0x0000DC28
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000C033 File Offset: 0x0000A233
	public float ratioAtPoint(Vector3 pt)
	{
		return 0f;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000FA40 File Offset: 0x0000DC40
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0000C03A File Offset: 0x0000A23A
	public void place2d(Transform transform, float ratio)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0000C03C File Offset: 0x0000A23C
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000C03E File Offset: 0x0000A23E
	public void place(Transform transform, float ratio)
	{
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0000C040 File Offset: 0x0000A240
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000C042 File Offset: 0x0000A242
	public void placeLocal(Transform transform, float ratio)
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000C044 File Offset: 0x0000A244
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000C046 File Offset: 0x0000A246
	public void gizmoDraw(float t = -1f)
	{
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000C048 File Offset: 0x0000A248
	public void drawGizmo(Color color)
	{
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000C04A File Offset: 0x0000A24A
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000C04C File Offset: 0x0000A24C
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000C04E File Offset: 0x0000A24E
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0000C050 File Offset: 0x0000A250
	public Vector3[] generateVectors()
	{
		return null;
	}

	// Token: 0x040000B1 RID: 177
	public static int DISTANCE_COUNT;

	// Token: 0x040000B2 RID: 178
	public static int SUBLINE_COUNT;

	// Token: 0x040000B3 RID: 179
	public float distance;

	// Token: 0x040000B4 RID: 180
	public bool constantSpeed;

	// Token: 0x040000B5 RID: 181
	public Vector3[] pts;

	// Token: 0x040000B6 RID: 182
	[NonSerialized]
	public Vector3[] ptsAdj;

	// Token: 0x040000B7 RID: 183
	public int ptsAdjLength;

	// Token: 0x040000B8 RID: 184
	public bool orientToPath;

	// Token: 0x040000B9 RID: 185
	public bool orientToPath2d;

	// Token: 0x040000BA RID: 186
	private int numSections;

	// Token: 0x040000BB RID: 187
	private int currPt;
}
