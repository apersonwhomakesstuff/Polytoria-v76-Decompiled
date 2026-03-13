using System;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

// Token: 0x02000007 RID: 7
public class UniformModifier : ProceduralImageModifier
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00015DDC File Offset: 0x00013FDC
	// (set) Token: 0x06000014 RID: 20 RVA: 0x00015DE3 File Offset: 0x00013FE3
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

	// Token: 0x06000015 RID: 21 RVA: 0x0001DDFC File Offset: 0x0001BFFC
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	// Token: 0x04000007 RID: 7
	private float radius;
}
