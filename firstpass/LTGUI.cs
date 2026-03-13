using System;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class LTGUI
{
	// Token: 0x06000139 RID: 313 RVA: 0x0000C0D2 File Offset: 0x0000A2D2
	public static void init()
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
	public static void initRectCheck()
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0000C0D6 File Offset: 0x0000A2D6
	public static void reset()
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
	public static void update(int updateLevel)
	{
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0000C0DA File Offset: 0x0000A2DA
	public static bool checkOnScreen(Rect rect)
	{
		return false;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0000C0DD File Offset: 0x0000A2DD
	public static void destroy(int id)
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x0000C0DF File Offset: 0x0000A2DF
	public static void destroyAll(int depth)
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0000C0E7 File Offset: 0x0000A2E7
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0000C0EA File Offset: 0x0000A2EA
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0000C0ED File Offset: 0x0000A2ED
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return false;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0000C0F3 File Offset: 0x0000A2F3
	public static bool pressedWithinRect(Rect rect)
	{
		return false;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0000C0F6 File Offset: 0x0000A2F6
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return false;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000FA70 File Offset: 0x0000DC70
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	// Token: 0x040000D3 RID: 211
	public static int RECT_LEVELS;

	// Token: 0x040000D4 RID: 212
	public static int RECTS_PER_LEVEL;

	// Token: 0x040000D5 RID: 213
	public static int BUTTONS_MAX;

	// Token: 0x040000D6 RID: 214
	private static LTRect[] levels;

	// Token: 0x040000D7 RID: 215
	private static int[] levelDepths;

	// Token: 0x040000D8 RID: 216
	private static Rect[] buttons;

	// Token: 0x040000D9 RID: 217
	private static int[] buttonLevels;

	// Token: 0x040000DA RID: 218
	private static int[] buttonLastFrame;

	// Token: 0x040000DB RID: 219
	private static LTRect r;

	// Token: 0x040000DC RID: 220
	private static Color color;

	// Token: 0x040000DD RID: 221
	private static bool isGUIEnabled;

	// Token: 0x040000DE RID: 222
	private static int global_counter;

	// Token: 0x0200016D RID: 365
	public enum Element_Type
	{
		// Token: 0x04000608 RID: 1544
		Texture,
		// Token: 0x04000609 RID: 1545
		Label
	}
}
