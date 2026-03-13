using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000067 RID: 103
	public class GizmoCircularMaterial : Singleton<GizmoCircularMaterial>
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00016765 File Offset: 0x00014965
		public Material CircleMaterial
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00016768 File Offset: 0x00014968
		public Material TorusMaterial
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001676B File Offset: 0x0001496B
		public Material CylindricalTorusMaterial
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0001676E File Offset: 0x0001496E
		public Material Material
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001E7EC File Offset: 0x0001C9EC
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00016771 File Offset: 0x00014971
		public GizmoCircularMaterial.Type CircularType
		{
			get
			{
				return GizmoCircularMaterial.Type.Circle;
			}
			set
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00016773 File Offset: 0x00014973
		public bool IsLit
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00016776 File Offset: 0x00014976
		public float LightIntensity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00016785 File Offset: 0x00014985
		public void ResetValuesToSensibleDefaults()
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00016787 File Offset: 0x00014987
		public void SetCullAlphaScale(float scale)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00016789 File Offset: 0x00014989
		public void SetShapeCenter(Vector3 center)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001678B File Offset: 0x0001498B
		public void SetTorusCoreRadius(float radius)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001678D File Offset: 0x0001498D
		public void SetTorusTubeRadius(float radius)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001678F File Offset: 0x0001498F
		public void SetCylindricalTorusRadii(float hrzRadius, float vertRadius)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00016791 File Offset: 0x00014991
		public void SetCamera(Camera camera)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00016793 File Offset: 0x00014993
		public void SetLit(bool isLit)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00016795 File Offset: 0x00014995
		public void SetLightDirection(Vector3 lightDir)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00016797 File Offset: 0x00014997
		public void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00016799 File Offset: 0x00014999
		public void SetColor(Color color)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001679B File Offset: 0x0001499B
		public void SetZWriteEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001679D File Offset: 0x0001499D
		public void SetZTestEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0001679F File Offset: 0x0001499F
		public void SetZTestAlways()
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000167A1 File Offset: 0x000149A1
		public void SetZTestLess()
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000167A3 File Offset: 0x000149A3
		public void SetCullModeBack()
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000167A5 File Offset: 0x000149A5
		public void SetCullModeFront()
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000167A7 File Offset: 0x000149A7
		public void SetCullModeOff()
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000167A9 File Offset: 0x000149A9
		public void SetPass(int passIndex)
		{
		}

		// Token: 0x04000161 RID: 353
		private GizmoCircularMaterial.Type _circularType;

		// Token: 0x04000162 RID: 354
		private Material _circleMaterial;

		// Token: 0x04000163 RID: 355
		private Material _torusMaterial;

		// Token: 0x04000164 RID: 356
		private Material _cylindricalTorusMaterial;

		// Token: 0x0200035E RID: 862
		public enum Type
		{
			// Token: 0x04000ECF RID: 3791
			Circle,
			// Token: 0x04000ED0 RID: 3792
			Torus,
			// Token: 0x04000ED1 RID: 3793
			CylindricalTorus
		}
	}
}
