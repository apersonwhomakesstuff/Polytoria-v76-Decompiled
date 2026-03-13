using System;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class LeanAudioOptions
{
	// Token: 0x06000020 RID: 32 RVA: 0x0000BCDD File Offset: 0x00009EDD
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000BCE0 File Offset: 0x00009EE0
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000BCE3 File Offset: 0x00009EE3
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000BCE6 File Offset: 0x00009EE6
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0000BCE9 File Offset: 0x00009EE9
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000BCEC File Offset: 0x00009EEC
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0000BCEF File Offset: 0x00009EEF
	public LeanAudioOptions setWaveStyle(LeanAudioOptions.LeanAudioWaveStyle style)
	{
		return null;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000BCF2 File Offset: 0x00009EF2
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000BCF5 File Offset: 0x00009EF5
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}

	// Token: 0x0400000D RID: 13
	public LeanAudioOptions.LeanAudioWaveStyle waveStyle;

	// Token: 0x0400000E RID: 14
	public Vector3[] vibrato;

	// Token: 0x0400000F RID: 15
	public Vector3[] modulation;

	// Token: 0x04000010 RID: 16
	public int frequencyRate;

	// Token: 0x04000011 RID: 17
	public float waveNoiseScale;

	// Token: 0x04000012 RID: 18
	public float waveNoiseInfluence;

	// Token: 0x04000013 RID: 19
	public bool useSetData;

	// Token: 0x04000014 RID: 20
	public LeanAudioStream stream;

	// Token: 0x02000167 RID: 359
	public enum LeanAudioWaveStyle
	{
		// Token: 0x040005EF RID: 1519
		Sine,
		// Token: 0x040005F0 RID: 1520
		Square,
		// Token: 0x040005F1 RID: 1521
		Sawtooth,
		// Token: 0x040005F2 RID: 1522
		Noise
	}
}
