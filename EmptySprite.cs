using System;
using UnityEngine;

// Token: 0x02000003 RID: 3
public static class EmptySprite
{
	// Token: 0x06000004 RID: 4 RVA: 0x00015DAF File Offset: 0x00013FAF
	public static Sprite Get()
	{
		return null;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00015DB2 File Offset: 0x00013FB2
	public static bool IsEmptySprite(Sprite s)
	{
		return false;
	}

	// Token: 0x04000003 RID: 3
	private static Sprite instance;
}
