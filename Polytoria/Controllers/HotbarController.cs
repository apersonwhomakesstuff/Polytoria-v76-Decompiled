using System;
using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000329 RID: 809
	public class HotbarController : MonoBehaviour
	{
		// Token: 0x06002857 RID: 10327 RVA: 0x0001CB90 File Offset: 0x0001AD90
		private void Awake()
		{
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0001CB92 File Offset: 0x0001AD92
		private void Start()
		{
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0001CB94 File Offset: 0x0001AD94
		public void ToolLinked(Tool tool, Instance parent)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0001CB96 File Offset: 0x0001AD96
		private void Update()
		{
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0001CB98 File Offset: 0x0001AD98
		private void EquipTool(Tool tool)
		{
		}

		// Token: 0x04000D96 RID: 3478
		public static HotbarController singleton;

		// Token: 0x04000D97 RID: 3479
		private RectTransform hotbarItem;

		// Token: 0x04000D98 RID: 3480
		private Dictionary<Tool, RectTransform> tools;

		// Token: 0x04000D99 RID: 3481
		private int toolIndex;
	}
}
