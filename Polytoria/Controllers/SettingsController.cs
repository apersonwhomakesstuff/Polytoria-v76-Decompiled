using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Polytoria.Controllers
{
	// Token: 0x02000339 RID: 825
	public class SettingsController : MonoBehaviour
	{
		// Token: 0x060028B7 RID: 10423 RVA: 0x0001CD07 File Offset: 0x0001AF07
		private void Awake()
		{
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0001CD09 File Offset: 0x0001AF09
		public void Load()
		{
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x0001CD0B File Offset: 0x0001AF0B
		public void SetSettingsCategory(int index)
		{
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x0001CD0D File Offset: 0x0001AF0D
		public void LoadSettings()
		{
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0001CD0F File Offset: 0x0001AF0F
		private void ReloadControls()
		{
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x0001CD11 File Offset: 0x0001AF11
		private void ReloadInputControls()
		{
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0001CD13 File Offset: 0x0001AF13
		private void ReloadMiscControls()
		{
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0001CD15 File Offset: 0x0001AF15
		private void ReloadAudioControls()
		{
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0001CD17 File Offset: 0x0001AF17
		private void ReloadGraphicsControls()
		{
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0001CD19 File Offset: 0x0001AF19
		public void SetMouseSensitivity(float sensitivity)
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0001CD1B File Offset: 0x0001AF1B
		public void SetDebugLogLength(string slength)
		{
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0001CD1D File Offset: 0x0001AF1D
		public void SetUISize(int sizeLevel)
		{
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0001CD1F File Offset: 0x0001AF1F
		public void SetFullscreen(bool fullscreen)
		{
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0001CD21 File Offset: 0x0001AF21
		public void SetQualityLevel(int qualityLevel)
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x0001CD23 File Offset: 0x0001AF23
		public void SetPixelLightCount(float pixelLightCount)
		{
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x0001CD25 File Offset: 0x0001AF25
		public void SetShadowDistance(float shadowDistance)
		{
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0001CD27 File Offset: 0x0001AF27
		public void SetShadowResolution(int shadowResolution)
		{
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0001CD29 File Offset: 0x0001AF29
		public void SetTextureQuality(int textureQuality)
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0001CD2B File Offset: 0x0001AF2B
		public void SetVSync(int vSync)
		{
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0001CD2D File Offset: 0x0001AF2D
		public void SetAntiAliasing(int antiAliasing)
		{
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0001CD2F File Offset: 0x0001AF2F
		public void SetAnisotropicFiltering(int anisotropicFiltering)
		{
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0001CD31 File Offset: 0x0001AF31
		public void SetPostProcessing(bool postProcessing)
		{
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0001CD33 File Offset: 0x0001AF33
		public void SetMasterVolume(float volume)
		{
		}

		// Token: 0x04000DEE RID: 3566
		public static SettingsController instance;

		// Token: 0x04000DEF RID: 3567
		private RectTransform audioContainer;

		// Token: 0x04000DF0 RID: 3568
		private RectTransform graphicsContainer;

		// Token: 0x04000DF1 RID: 3569
		private RectTransform inputContainer;

		// Token: 0x04000DF2 RID: 3570
		private RectTransform miscContainer;

		// Token: 0x04000DF3 RID: 3571
		private PostProcessLayer postProcessLayer;

		// Token: 0x04000DF4 RID: 3572
		public RectTransform[] containers;

		// Token: 0x04000DF5 RID: 3573
		private const int DefaultQualityLevel = 5;

		// Token: 0x04000DF6 RID: 3574
		private const int DefaultUISize = 2;

		// Token: 0x04000DF7 RID: 3575
		private const float DefaultMouseSensitivity = 1f;

		// Token: 0x04000DF8 RID: 3576
		private const float DefaultMasterVolume = 1f;
	}
}
