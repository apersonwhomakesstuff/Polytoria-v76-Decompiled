using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class LeanAudioStream
{
	// Token: 0x0600000D RID: 13 RVA: 0x0000BC9A File Offset: 0x00009E9A
	public LeanAudioStream(float[] audioArr)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000BCA2 File Offset: 0x00009EA2
	public void OnAudioRead(float[] data)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000BCA4 File Offset: 0x00009EA4
	public void OnAudioSetPosition(int newPosition)
	{
	}

	// Token: 0x04000005 RID: 5
	public int position;

	// Token: 0x04000006 RID: 6
	public AudioClip audioClip;

	// Token: 0x04000007 RID: 7
	public float[] audioArr;
}
