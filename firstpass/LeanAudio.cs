using System;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class LeanAudio
{
	// Token: 0x06000010 RID: 16 RVA: 0x0000BCA6 File Offset: 0x00009EA6
	public static LeanAudioOptions options()
	{
		return null;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000BCA9 File Offset: 0x00009EA9
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		return null;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000BCAC File Offset: 0x00009EAC
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		return null;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000BCAF File Offset: 0x00009EAF
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return 0;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000BCB2 File Offset: 0x00009EB2
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000BCB5 File Offset: 0x00009EB5
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000BCB7 File Offset: 0x00009EB7
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000BCBA File Offset: 0x00009EBA
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000BCBD File Offset: 0x00009EBD
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000BCC0 File Offset: 0x00009EC0
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000BCC3 File Offset: 0x00009EC3
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000BCC6 File Offset: 0x00009EC6
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000BCC9 File Offset: 0x00009EC9
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	// Token: 0x04000008 RID: 8
	public static float MIN_FREQEUNCY_PERIOD;

	// Token: 0x04000009 RID: 9
	public static int PROCESSING_ITERATIONS_MAX;

	// Token: 0x0400000A RID: 10
	public static float[] generatedWaveDistances;

	// Token: 0x0400000B RID: 11
	public static int generatedWaveDistancesCount;

	// Token: 0x0400000C RID: 12
	private static float[] longList;
}
