using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000068 RID: 104
	public class GizmoLabelMaterial : Singleton<GizmoLabelMaterial>
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000167AB File Offset: 0x000149AB
		public Material Material
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000167AE File Offset: 0x000149AE
		public void ResetValuesToSensibleDefaults()
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000167B0 File Offset: 0x000149B0
		public void SetTexture(Texture2D texture)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000167B2 File Offset: 0x000149B2
		public void SetColor(Color color)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000167B4 File Offset: 0x000149B4
		public void SetPass(int passIndex)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000167B6 File Offset: 0x000149B6
		public void SetZWriteEnabled(bool isEnabled)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000167B8 File Offset: 0x000149B8
		public void SetZTestLessEqual()
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000167BA File Offset: 0x000149BA
		public void SetZTestAlways()
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000167BC File Offset: 0x000149BC
		public void SetZTestLess()
		{
		}

		// Token: 0x04000165 RID: 357
		private Material _material;
	}
}
