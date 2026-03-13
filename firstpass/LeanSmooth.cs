using System;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class LeanSmooth
{
	// Token: 0x06000029 RID: 41 RVA: 0x0000BCF8 File Offset: 0x00009EF8
	public static float damp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		return 0f;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
	public static Vector3 damp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		return default(Vector3);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
	public static Color damp(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		return default(Color);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000BCFF File Offset: 0x00009EFF
	public static float spring(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return 0f;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000F908 File Offset: 0x0000DB08
	public static Vector3 spring(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return default(Vector3);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000F920 File Offset: 0x0000DB20
	public static Color spring(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return default(Color);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000BD06 File Offset: 0x00009F06
	public static float linear(float current, float target, float moveSpeed, float deltaTime = -1f)
	{
		return 0f;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x0000F938 File Offset: 0x0000DB38
	public static Vector3 linear(Vector3 current, Vector3 target, float moveSpeed, float deltaTime = -1f)
	{
		return default(Vector3);
	}

	// Token: 0x06000031 RID: 49 RVA: 0x0000F950 File Offset: 0x0000DB50
	public static Color linear(Color current, Color target, float moveSpeed)
	{
		return default(Color);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0000BD0D File Offset: 0x00009F0D
	public static float bounceOut(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return 0f;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0000F968 File Offset: 0x0000DB68
	public static Vector3 bounceOut(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return default(Vector3);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0000F980 File Offset: 0x0000DB80
	public static Color bounceOut(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return default(Color);
	}
}
