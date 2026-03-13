using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200011D RID: 285
	public class ColorTransition
	{
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000F1B RID: 3867 RVA: 0x00018765 File Offset: 0x00016965
		// (remove) Token: 0x06000F1C RID: 3868 RVA: 0x00018767 File Offset: 0x00016967
		public event ColorTransition.ColorTransitionBeginHandler TransitionBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000F1D RID: 3869 RVA: 0x00018769 File Offset: 0x00016969
		// (remove) Token: 0x06000F1E RID: 3870 RVA: 0x0001876B File Offset: 0x0001696B
		public event ColorTransition.ColorTransitionEndHandler TransitionEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000207FC File Offset: 0x0001E9FC
		public ColorTransition.State TransitionState
		{
			get
			{
				return ColorTransition.State.CompleteFadeIn;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00020814 File Offset: 0x0001EA14
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x0001876D File Offset: 0x0001696D
		public Color FadeInColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0002082C File Offset: 0x0001EA2C
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x0001876F File Offset: 0x0001696F
		public Color FadeOutColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00018771 File Offset: 0x00016971
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x00018778 File Offset: 0x00016978
		public float DurationInSeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0001877A File Offset: 0x0001697A
		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0001877D File Offset: 0x0001697D
		public ColorTransition(ColorRef colorRef)
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00018785 File Offset: 0x00016985
		public void BeginFadeIn(bool startFromCurrentColor)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00018787 File Offset: 0x00016987
		public void BeginFadeOut(bool startFromCurrentColor)
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00018789 File Offset: 0x00016989
		public void Update(float elapsedTime)
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0001878B File Offset: 0x0001698B
		private void End()
		{
		}

		// Token: 0x0400055B RID: 1371
		private ColorRef _colorRef;

		// Token: 0x0400055C RID: 1372
		private Color _fadeInColor;

		// Token: 0x0400055D RID: 1373
		private Color _fadeOutColor;

		// Token: 0x0400055E RID: 1374
		private ColorTransition.State _state;

		// Token: 0x0400055F RID: 1375
		private float _durationInSeconds;

		// Token: 0x04000560 RID: 1376
		private float _elapsedTimeInSeconds;

		// Token: 0x04000561 RID: 1377
		private bool _isActive;

		// Token: 0x02000385 RID: 901
		public enum State
		{
			// Token: 0x04000F58 RID: 3928
			CompleteFadeIn,
			// Token: 0x04000F59 RID: 3929
			CompleteFadeOut,
			// Token: 0x04000F5A RID: 3930
			FadingIn,
			// Token: 0x04000F5B RID: 3931
			FadingOut,
			// Token: 0x04000F5C RID: 3932
			Ready
		}

		// Token: 0x02000386 RID: 902
		// (Invoke) Token: 0x06002AA4 RID: 10916
		public delegate void ColorTransitionBeginHandler(ColorTransition colorTransition);

		// Token: 0x02000387 RID: 903
		// (Invoke) Token: 0x06002AA8 RID: 10920
		public delegate void ColorTransitionEndHandler(ColorTransition colorTransition);
	}
}
