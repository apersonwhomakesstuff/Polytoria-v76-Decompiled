using System;
using System.Collections.Generic;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000293 RID: 659
	public class NetMessage
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x0001ADED File Offset: 0x00018FED
		public NetMessage()
		{
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0001ADF5 File Offset: 0x00018FF5
		public void AddString(string key, string value)
		{
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0001ADF7 File Offset: 0x00018FF7
		public void AddInt(string key, int value)
		{
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0001ADF9 File Offset: 0x00018FF9
		public void AddBool(string key, bool value)
		{
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x0001ADFB File Offset: 0x00018FFB
		public void AddNumber(string key, float value)
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0001ADFD File Offset: 0x00018FFD
		public void AddVector2(string key, Vector2 value)
		{
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0001ADFF File Offset: 0x00018FFF
		public void AddVector3(string key, Vector3 value)
		{
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0001AE01 File Offset: 0x00019001
		public void AddColor(string key, Color value)
		{
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0001AE03 File Offset: 0x00019003
		public void AddInstance(string key, Instance value)
		{
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0001AE05 File Offset: 0x00019005
		public string GetString(string key)
		{
			return null;
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0001AE08 File Offset: 0x00019008
		public int GetInt(string key)
		{
			return 0;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0001AE0B File Offset: 0x0001900B
		public float GetNumber(string key)
		{
			return 0f;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0001AE12 File Offset: 0x00019012
		public bool GetBool(string key)
		{
			return false;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000247A8 File Offset: 0x000229A8
		public Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000247C0 File Offset: 0x000229C0
		public Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000247D8 File Offset: 0x000229D8
		public Color GetColor(string key)
		{
			return default(Color);
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0001AE15 File Offset: 0x00019015
		public Instance GetInstance(string key)
		{
			return null;
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0001AE18 File Offset: 0x00019018
		public static NetMessage New()
		{
			return null;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0001AE1B File Offset: 0x0001901B
		public NetMessage(Dictionary<string, string> strings, Dictionary<string, int> ints, Dictionary<string, float> numbers, Dictionary<string, bool> bools, Dictionary<string, Vector2> vec2s, Dictionary<string, Vector3> vec3s, Dictionary<string, Color> colors, Dictionary<string, Instance> instances)
		{
		}

		// Token: 0x04000AB4 RID: 2740
		public readonly Dictionary<string, string> strings;

		// Token: 0x04000AB5 RID: 2741
		public readonly Dictionary<string, int> ints;

		// Token: 0x04000AB6 RID: 2742
		public readonly Dictionary<string, float> numbers;

		// Token: 0x04000AB7 RID: 2743
		public readonly Dictionary<string, bool> bools;

		// Token: 0x04000AB8 RID: 2744
		public readonly Dictionary<string, Vector2> vec2s;

		// Token: 0x04000AB9 RID: 2745
		public readonly Dictionary<string, Vector3> vec3s;

		// Token: 0x04000ABA RID: 2746
		public readonly Dictionary<string, Color> colors;

		// Token: 0x04000ABB RID: 2747
		public readonly Dictionary<string, Instance> instances;
	}
}
