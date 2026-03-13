using System;

// Token: 0x02000009 RID: 9
public class LeanTest
{
	// Token: 0x06000039 RID: 57 RVA: 0x0000BD29 File Offset: 0x00009F29
	public static void debug(string name, bool didPass, string failExplaination = null)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000BD2B File Offset: 0x00009F2B
	public static void expect(bool didPass, string definition, string failExplaination = null)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x0000BD2D File Offset: 0x00009F2D
	public static string padRight(int len)
	{
		return null;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000BD30 File Offset: 0x00009F30
	public static float printOutLength(string str)
	{
		return 0f;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x0000BD37 File Offset: 0x00009F37
	public static string formatBC(string str, string color)
	{
		return null;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000BD3A File Offset: 0x00009F3A
	public static string formatB(string str)
	{
		return null;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000BD3D File Offset: 0x00009F3D
	public static string formatC(string str, string color)
	{
		return null;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000BD40 File Offset: 0x00009F40
	public static void overview()
	{
	}

	// Token: 0x04000016 RID: 22
	public static int expected;

	// Token: 0x04000017 RID: 23
	private static int tests;

	// Token: 0x04000018 RID: 24
	private static int passes;

	// Token: 0x04000019 RID: 25
	public static float timeout;

	// Token: 0x0400001A RID: 26
	public static bool timeoutStarted;

	// Token: 0x0400001B RID: 27
	public static bool testsFinished;
}
