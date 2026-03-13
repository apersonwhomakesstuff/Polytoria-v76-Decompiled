using System;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

// Token: 0x02000005 RID: 5
public class OnlyOneEdgeModifier : ProceduralImageModifier
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000B RID: 11 RVA: 0x00015DC1 File Offset: 0x00013FC1
	// (set) Token: 0x0600000C RID: 12 RVA: 0x00015DC8 File Offset: 0x00013FC8
	public float Radius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000D RID: 13 RVA: 0x0001DDB4 File Offset: 0x0001BFB4
	// (set) Token: 0x0600000E RID: 14 RVA: 0x00015DCA File Offset: 0x00013FCA
	public OnlyOneEdgeModifier.ProceduralImageEdge Side
	{
		get
		{
			return OnlyOneEdgeModifier.ProceduralImageEdge.Top;
		}
		set
		{
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0001DDCC File Offset: 0x0001BFCC
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	// Token: 0x04000005 RID: 5
	private float radius;

	// Token: 0x04000006 RID: 6
	private OnlyOneEdgeModifier.ProceduralImageEdge side;

	// Token: 0x02000348 RID: 840
	public enum ProceduralImageEdge
	{
		// Token: 0x04000E7B RID: 3707
		Top,
		// Token: 0x04000E7C RID: 3708
		Bottom,
		// Token: 0x04000E7D RID: 3709
		Left,
		// Token: 0x04000E7E RID: 3710
		Right
	}
}
