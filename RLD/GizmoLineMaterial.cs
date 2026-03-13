using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000069 RID: 105
	public class GizmoLineMaterial : Singleton<GizmoLineMaterial>
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000167C6 File Offset: 0x000149C6
		public Material Material
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000167C9 File Offset: 0x000149C9
		public void ResetValuesToSensibleDefaults()
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000167CB File Offset: 0x000149CB
		public void SetColor(Color color)
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000167CD File Offset: 0x000149CD
		public void SetPass(int passIndex)
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000167CF File Offset: 0x000149CF
		public void SetZWriteEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000167D1 File Offset: 0x000149D1
		public void SetZTestLessEqual()
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000167D3 File Offset: 0x000149D3
		public void SetZTestAlways()
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000167D5 File Offset: 0x000149D5
		public void SetZTestLess()
		{
		}

		// Token: 0x04000166 RID: 358
		private Material _material;
	}
}
