using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000107 RID: 263
	public class CameraPrjSwitchTransition
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000E18 RID: 3608 RVA: 0x0001849B File Offset: 0x0001669B
		// (remove) Token: 0x06000E19 RID: 3609 RVA: 0x0001849D File Offset: 0x0001669D
		public event CameraProjectionSwitchBeginHandler TransitionBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000E1A RID: 3610 RVA: 0x0001849F File Offset: 0x0001669F
		// (remove) Token: 0x06000E1B RID: 3611 RVA: 0x000184A1 File Offset: 0x000166A1
		public event CameraProjectionSwitchUpdateHandler TransitionUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000E1C RID: 3612 RVA: 0x000184A3 File Offset: 0x000166A3
		// (remove) Token: 0x06000E1D RID: 3613 RVA: 0x000184A5 File Offset: 0x000166A5
		public event CameraProjectionSwitchBeginHandler TransitionEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x000184A7 File Offset: 0x000166A7
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x000184AA File Offset: 0x000166AA
		public MonoBehaviour TargetMono
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000184AC File Offset: 0x000166AC
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x000184AF File Offset: 0x000166AF
		public Camera TargetCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0002049C File Offset: 0x0001E69C
		public CameraPrjSwitchTransition.Type TransitionType
		{
			get
			{
				return CameraPrjSwitchTransition.Type.None;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x000184B1 File Offset: 0x000166B1
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000184B8 File Offset: 0x000166B8
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000184BA File Offset: 0x000166BA
		public float Progress
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x000184C1 File Offset: 0x000166C1
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x000184C8 File Offset: 0x000166C8
		public float CamFieldOfView
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x000204B4 File Offset: 0x0001E6B4
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x000184CA File Offset: 0x000166CA
		public Vector3 CamFocusPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x000184CC File Offset: 0x000166CC
		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x000184CF File Offset: 0x000166CF
		public void Begin()
		{
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x000184D1 File Offset: 0x000166D1
		private IEnumerator DoTransition()
		{
			return null;
		}

		// Token: 0x040004F3 RID: 1267
		private IEnumerator _transitionCrtn;

		// Token: 0x040004F4 RID: 1268
		private MonoBehaviour _targetMono;

		// Token: 0x040004F5 RID: 1269
		private Camera _targetCamera;

		// Token: 0x040004F6 RID: 1270
		private float _camFieldOfView;

		// Token: 0x040004F7 RID: 1271
		private Vector3 _camFocusPoint;

		// Token: 0x040004F8 RID: 1272
		private Vector3 _camRestorePosition;

		// Token: 0x040004F9 RID: 1273
		private CameraPrjSwitchTransition.Type _transitionType;

		// Token: 0x040004FA RID: 1274
		private float _durationInSeconds;

		// Token: 0x040004FB RID: 1275
		private float _progress;

		// Token: 0x02000375 RID: 885
		public enum Type
		{
			// Token: 0x04000F05 RID: 3845
			None,
			// Token: 0x04000F06 RID: 3846
			ToOrtho,
			// Token: 0x04000F07 RID: 3847
			ToPerspective
		}

		// Token: 0x02000376 RID: 886
		private sealed class <DoTransition>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A61 RID: 10849 RVA: 0x0001D21F File Offset: 0x0001B41F
			public <DoTransition>d__41(int <>1__state)
			{
			}

			// Token: 0x06002A62 RID: 10850 RVA: 0x0001D227 File Offset: 0x0001B427
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A63 RID: 10851 RVA: 0x0001D229 File Offset: 0x0001B429
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C81 RID: 3201
			// (get) Token: 0x06002A64 RID: 10852 RVA: 0x0001D22C File Offset: 0x0001B42C
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A65 RID: 10853 RVA: 0x0001D22F File Offset: 0x0001B42F
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C82 RID: 3202
			// (get) Token: 0x06002A66 RID: 10854 RVA: 0x0001D231 File Offset: 0x0001B431
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F08 RID: 3848
			private int <>1__state;

			// Token: 0x04000F09 RID: 3849
			private object <>2__current;

			// Token: 0x04000F0A RID: 3850
			public CameraPrjSwitchTransition <>4__this;

			// Token: 0x04000F0B RID: 3851
			private float <frustumHeight>5__2;

			// Token: 0x04000F0C RID: 3852
			private float <targetFOV>5__3;

			// Token: 0x04000F0D RID: 3853
			private float <invDuration>5__4;

			// Token: 0x04000F0E RID: 3854
			private float <fovSpeed>5__5;

			// Token: 0x04000F0F RID: 3855
			private Transform <_targetTransform>5__6;
		}
	}
}
