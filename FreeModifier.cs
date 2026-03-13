using System;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

// Token: 0x02000004 RID: 4
public class FreeModifier : ProceduralImageModifier
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x0001DD84 File Offset: 0x0001BF84
	// (set) Token: 0x06000007 RID: 7 RVA: 0x00015DB5 File Offset: 0x00013FB5
	public Vector4 Radius
	{
		get
		{
			return default(Vector4);
		}
		set
		{
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0001DD9C File Offset: 0x0001BF9C
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00015DB7 File Offset: 0x00013FB7
	protected void OnValidate()
	{
	}

	// Token: 0x04000004 RID: 4
	private Vector4 radius;
}
