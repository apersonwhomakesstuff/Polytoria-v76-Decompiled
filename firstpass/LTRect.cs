using System;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Serializable]
public class LTRect
{
	// Token: 0x0600011B RID: 283 RVA: 0x0000C055 File Offset: 0x0000A255
	public LTRect()
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0000C05D File Offset: 0x0000A25D
	public LTRect(Rect rect)
	{
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0000C065 File Offset: 0x0000A265
	public LTRect(float x, float y, float width, float height)
	{
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0000C06D File Offset: 0x0000A26D
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0000C075 File Offset: 0x0000A275
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000120 RID: 288 RVA: 0x0000C07D File Offset: 0x0000A27D
	public bool hasInitiliazed
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000121 RID: 289 RVA: 0x0000C080 File Offset: 0x0000A280
	public int id
	{
		get
		{
			return 0;
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0000C083 File Offset: 0x0000A283
	public void setId(int id, int counter)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x0000C085 File Offset: 0x0000A285
	public void reset()
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0000C087 File Offset: 0x0000A287
	public void resetForRotation()
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000125 RID: 293 RVA: 0x0000C089 File Offset: 0x0000A289
	// (set) Token: 0x06000126 RID: 294 RVA: 0x0000C090 File Offset: 0x0000A290
	public float x
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000127 RID: 295 RVA: 0x0000C092 File Offset: 0x0000A292
	// (set) Token: 0x06000128 RID: 296 RVA: 0x0000C099 File Offset: 0x0000A299
	public float y
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000129 RID: 297 RVA: 0x0000C09B File Offset: 0x0000A29B
	// (set) Token: 0x0600012A RID: 298 RVA: 0x0000C0A2 File Offset: 0x0000A2A2
	public float width
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600012B RID: 299 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
	// (set) Token: 0x0600012C RID: 300 RVA: 0x0000C0AB File Offset: 0x0000A2AB
	public float height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600012D RID: 301 RVA: 0x0000FA58 File Offset: 0x0000DC58
	// (set) Token: 0x0600012E RID: 302 RVA: 0x0000C0AD File Offset: 0x0000A2AD
	public Rect rect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0000C0AF File Offset: 0x0000A2AF
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000C0B2 File Offset: 0x0000A2B2
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000C0B5 File Offset: 0x0000A2B5
	public LTRect setColor(Color color)
	{
		return null;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0000C0BB File Offset: 0x0000A2BB
	public LTRect setLabel(string str)
	{
		return null;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000C0BE File Offset: 0x0000A2BE
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0000C0C1 File Offset: 0x0000A2C1
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000C0C4 File Offset: 0x0000A2C4
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0000C0C7 File Offset: 0x0000A2C7
	public override string ToString()
	{
		return null;
	}

	// Token: 0x040000BC RID: 188
	public Rect _rect;

	// Token: 0x040000BD RID: 189
	public float alpha;

	// Token: 0x040000BE RID: 190
	public float rotation;

	// Token: 0x040000BF RID: 191
	public Vector2 pivot;

	// Token: 0x040000C0 RID: 192
	public Vector2 margin;

	// Token: 0x040000C1 RID: 193
	public Rect relativeRect;

	// Token: 0x040000C2 RID: 194
	public bool rotateEnabled;

	// Token: 0x040000C3 RID: 195
	public bool rotateFinished;

	// Token: 0x040000C4 RID: 196
	public bool alphaEnabled;

	// Token: 0x040000C5 RID: 197
	public string labelStr;

	// Token: 0x040000C6 RID: 198
	public LTGUI.Element_Type type;

	// Token: 0x040000C7 RID: 199
	public GUIStyle style;

	// Token: 0x040000C8 RID: 200
	public bool useColor;

	// Token: 0x040000C9 RID: 201
	public Color color;

	// Token: 0x040000CA RID: 202
	public bool fontScaleToFit;

	// Token: 0x040000CB RID: 203
	public bool useSimpleScale;

	// Token: 0x040000CC RID: 204
	public bool sizeByHeight;

	// Token: 0x040000CD RID: 205
	public Texture texture;

	// Token: 0x040000CE RID: 206
	private int _id;

	// Token: 0x040000CF RID: 207
	public int counter;

	// Token: 0x040000D0 RID: 208
	public static bool colorTouched;
}
