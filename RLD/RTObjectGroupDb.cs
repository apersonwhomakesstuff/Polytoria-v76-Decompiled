using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000194 RID: 404
	public class RTObjectGroupDb : MonoSingleton<RTObjectGroupDb>
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00018FAE File Offset: 0x000171AE
		public int NumGroups
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00018FB1 File Offset: 0x000171B1
		public void Add(GameObject gameObject)
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00018FB3 File Offset: 0x000171B3
		public void Remove(GameObject gameObject)
		{
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00018FB5 File Offset: 0x000171B5
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00018FB7 File Offset: 0x000171B7
		public void Clear()
		{
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00018FB9 File Offset: 0x000171B9
		public bool IsGroup(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00018FBC File Offset: 0x000171BC
		public GameObject GetGroupByIndex(int index)
		{
			return null;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00018FBF File Offset: 0x000171BF
		public GameObject GetGroupByName(string name)
		{
			return null;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00018FC2 File Offset: 0x000171C2
		public List<GameObject> GetAll()
		{
			return null;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00018FC5 File Offset: 0x000171C5
		public void RemoveNullRefs()
		{
		}

		// Token: 0x04000663 RID: 1635
		private List<GameObject> _objectGroups;

		// Token: 0x02000392 RID: 914
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002ABD RID: 10941 RVA: 0x0001D341 File Offset: 0x0001B541
			internal bool <RemoveNullRefs>b__11_0(GameObject item)
			{
				return false;
			}

			// Token: 0x04000F74 RID: 3956
			public static readonly RTObjectGroupDb.<>c <>9;

			// Token: 0x04000F75 RID: 3957
			public static Predicate<GameObject> <>9__11_0;
		}

		// Token: 0x02000393 RID: 915
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06002ABF RID: 10943 RVA: 0x0001D34C File Offset: 0x0001B54C
			internal bool <GetGroupByName>b__0(GameObject item)
			{
				return false;
			}

			// Token: 0x04000F76 RID: 3958
			public string name;
		}
	}
}
