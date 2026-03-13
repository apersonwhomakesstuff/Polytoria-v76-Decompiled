using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x02000197 RID: 407
	public class RTActiveLibDropDown : MonoBehaviour
	{
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00018FF7 File Offset: 0x000171F7
		public int ActiveLibIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00018FFA File Offset: 0x000171FA
		public void AddValueChangedListener(UnityAction<int> listener)
		{
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00018FFC File Offset: 0x000171FC
		public void SetActiveLibIndex(int activeLibIndex)
		{
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00018FFE File Offset: 0x000171FE
		public void ClearLibs()
		{
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00019000 File Offset: 0x00017200
		public void SyncWithLibDb()
		{
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00019002 File Offset: 0x00017202
		private void Awake()
		{
		}

		// Token: 0x04000669 RID: 1641
		private Dropdown _dropDown;

		// Token: 0x0400066A RID: 1642
		private List<UnityAction<int>> _valueChangedListeners;
	}
}
