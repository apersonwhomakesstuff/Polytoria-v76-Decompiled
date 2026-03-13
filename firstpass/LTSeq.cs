using System;
using UnityEngine;

// Token: 0x02000018 RID: 24
public class LTSeq
{
	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000312 RID: 786 RVA: 0x0000C675 File Offset: 0x0000A875
	public int id
	{
		get
		{
			return 0;
		}
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0000C678 File Offset: 0x0000A878
	public void reset()
	{
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0000C67A File Offset: 0x0000A87A
	public void init(uint id, uint global_counter)
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000C67C File Offset: 0x0000A87C
	private LTSeq addOn()
	{
		return null;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0000C67F File Offset: 0x0000A87F
	private float addPreviousDelays()
	{
		return 0f;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0000C686 File Offset: 0x0000A886
	public LTSeq append(float delay)
	{
		return null;
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0000C689 File Offset: 0x0000A889
	public LTSeq append(Action callback)
	{
		return null;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0000C68C File Offset: 0x0000A88C
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0000C68F File Offset: 0x0000A88F
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0000C692 File Offset: 0x0000A892
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0000C695 File Offset: 0x0000A895
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0000C698 File Offset: 0x0000A898
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0000C69B File Offset: 0x0000A89B
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0000C69E File Offset: 0x0000A89E
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
	public LTSeq reverse()
	{
		return null;
	}

	// Token: 0x04000127 RID: 295
	public LTSeq previous;

	// Token: 0x04000128 RID: 296
	public LTSeq current;

	// Token: 0x04000129 RID: 297
	public LTDescr tween;

	// Token: 0x0400012A RID: 298
	public float totalDelay;

	// Token: 0x0400012B RID: 299
	public float timeScale;

	// Token: 0x0400012C RID: 300
	private int debugIter;

	// Token: 0x0400012D RID: 301
	public uint counter;

	// Token: 0x0400012E RID: 302
	public bool toggle;

	// Token: 0x0400012F RID: 303
	private uint _id;
}
