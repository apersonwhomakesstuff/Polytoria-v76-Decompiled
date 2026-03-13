using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200006A RID: 106
	public class GizmoSolidMaterial : Singleton<GizmoSolidMaterial>
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000167DF File Offset: 0x000149DF
		public Material Material
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x000167E2 File Offset: 0x000149E2
		public bool IsLit
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000167E5 File Offset: 0x000149E5
		public float LightIntensity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000167F4 File Offset: 0x000149F4
		public void ResetValuesToSensibleDefaults()
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000167F6 File Offset: 0x000149F6
		public void SetLit(bool isLit)
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000167F8 File Offset: 0x000149F8
		public void SetLightDirection(Vector3 lightDir)
		{
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000167FA File Offset: 0x000149FA
		public void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000167FC File Offset: 0x000149FC
		public void SetColor(Color color)
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000167FE File Offset: 0x000149FE
		public void SetZWriteEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00016800 File Offset: 0x00014A00
		public void SetZTestEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00016802 File Offset: 0x00014A02
		public void SetZTestAlways()
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00016804 File Offset: 0x00014A04
		public void SetZTestLess()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00016806 File Offset: 0x00014A06
		public void SetCullModeBack()
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00016808 File Offset: 0x00014A08
		public void SetCullModeFront()
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001680A File Offset: 0x00014A0A
		public void SetCullModeOff()
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001680C File Offset: 0x00014A0C
		public void SetPass(int passIndex)
		{
		}

		// Token: 0x04000167 RID: 359
		private Material _material;
	}
}
