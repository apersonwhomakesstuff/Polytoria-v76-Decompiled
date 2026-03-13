using System;
using System.Collections.Generic;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000271 RID: 625
	public class Camera : DynamicInstance
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0001A67B File Offset: 0x0001887B
		private bool DoLerp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0001A67E File Offset: 0x0001887E
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x0001A686 File Offset: 0x00018886
		public CameraMode Mode
		{
			get
			{
				return this.<Mode>k__BackingField;
			}
			set
			{
				this.<Mode>k__BackingField = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0001A68F File Offset: 0x0001888F
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0001A696 File Offset: 0x00018896
		public float FOV
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0001A698 File Offset: 0x00018898
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0001A69B File Offset: 0x0001889B
		public bool Orthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0001A69D File Offset: 0x0001889D
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0001A6A4 File Offset: 0x000188A4
		public float OrthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0001A6A6 File Offset: 0x000188A6
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0001A6AD File Offset: 0x000188AD
		public float Distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0001A6AF File Offset: 0x000188AF
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0001A6B6 File Offset: 0x000188B6
		public float MinDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0001A6B8 File Offset: 0x000188B8
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0001A6BF File Offset: 0x000188BF
		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0001A6C1 File Offset: 0x000188C1
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x0001A6C8 File Offset: 0x000188C8
		public float HorizontalSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0001A6CA File Offset: 0x000188CA
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x0001A6D1 File Offset: 0x000188D1
		public float VerticalSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0001A6D3 File Offset: 0x000188D3
		// (set) Token: 0x06001AEE RID: 6894 RVA: 0x0001A6DA File Offset: 0x000188DA
		public float ScrollSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0001A6DC File Offset: 0x000188DC
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0001A6DF File Offset: 0x000188DF
		public bool ClipThroughWalls
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0001A6E1 File Offset: 0x000188E1
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x0001A6E8 File Offset: 0x000188E8
		public float FlySpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0001A6EA File Offset: 0x000188EA
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0001A6F1 File Offset: 0x000188F1
		public float FastFlySpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0001A6F3 File Offset: 0x000188F3
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0001A6FA File Offset: 0x000188FA
		public float FreeLookSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0001A6FC File Offset: 0x000188FC
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0001A704 File Offset: 0x00018904
		public float LerpSpeed
		{
			get
			{
				return this.<LerpSpeed>k__BackingField;
			}
			set
			{
				this.<LerpSpeed>k__BackingField = value;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0001A70D File Offset: 0x0001890D
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0001A715 File Offset: 0x00018915
		public bool FollowLerp
		{
			get
			{
				return this.<FollowLerp>k__BackingField;
			}
			set
			{
				this.<FollowLerp>k__BackingField = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0001A71E File Offset: 0x0001891E
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0001A726 File Offset: 0x00018926
		public bool CanLock
		{
			get
			{
				return this.<CanLock>k__BackingField;
			}
			set
			{
				this.<CanLock>k__BackingField = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x0001A72F File Offset: 0x0001892F
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0001A737 File Offset: 0x00018937
		public bool CtrlLocked
		{
			get
			{
				return this.<CtrlLocked>k__BackingField;
			}
			set
			{
				this.<CtrlLocked>k__BackingField = value;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0001A740 File Offset: 0x00018940
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0001A748 File Offset: 0x00018948
		public float SensitivityMultiplier
		{
			get
			{
				return this.<SensitivityMultiplier>k__BackingField;
			}
			set
			{
				this.<SensitivityMultiplier>k__BackingField = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0001A751 File Offset: 0x00018951
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0001A759 File Offset: 0x00018959
		public Vector3 PositionOffset
		{
			get
			{
				return this.<PositionOffset>k__BackingField;
			}
			set
			{
				this.<PositionOffset>k__BackingField = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0001A762 File Offset: 0x00018962
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0001A76A File Offset: 0x0001896A
		public Vector3 RotationOffset
		{
			get
			{
				return this.<RotationOffset>k__BackingField;
			}
			set
			{
				this.<RotationOffset>k__BackingField = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0001A773 File Offset: 0x00018973
		public bool IsFirstPerson
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0001A776 File Offset: 0x00018976
		protected override bool DoTransformSync
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0001A779 File Offset: 0x00018979
		protected override void Awake()
		{
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0001A77B File Offset: 0x0001897B
		protected override void Start()
		{
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0001A77D File Offset: 0x0001897D
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0001A780 File Offset: 0x00018980
		public DynamicInstance FollowTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0001A782 File Offset: 0x00018982
		private void SetFollowTarget(DynamicInstance instance)
		{
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0001A784 File Offset: 0x00018984
		private void LateUpdate()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0001A786 File Offset: 0x00018986
		private void UpdateFollow()
		{
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0001A788 File Offset: 0x00018988
		private void UpdateFollowTarget()
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0001A78A File Offset: 0x0001898A
		private void UpdateFollowMode(Transform followTarget)
		{
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0001A78C File Offset: 0x0001898C
		private void HandleLockInput()
		{
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0001A78E File Offset: 0x0001898E
		private float HandleScrollInput()
		{
			return 0f;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0001A795 File Offset: 0x00018995
		private void HandleFirstPersonRendering()
		{
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0001A797 File Offset: 0x00018997
		private bool ShouldProcessCameraInput()
		{
			return false;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0001A79A File Offset: 0x0001899A
		private void HandleCursorLocking()
		{
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0001A79C File Offset: 0x0001899C
		private void HandleCameraRotation()
		{
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0001A79E File Offset: 0x0001899E
		private void HandleScrollZoom(float scroll)
		{
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0001A7A0 File Offset: 0x000189A0
		private void ApplyCameraTransform(Transform followTarget)
		{
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0001A7A2 File Offset: 0x000189A2
		private void ClampDistance()
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0001A7A4 File Offset: 0x000189A4
		private void CalculateWallClipping(Transform followTarget)
		{
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0001A7A6 File Offset: 0x000189A6
		private void UpdateFree()
		{
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0001A7A8 File Offset: 0x000189A8
		private void HandleFreeMovement()
		{
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0001A7AA File Offset: 0x000189AA
		private void HandleFreeLook()
		{
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0001A7AC File Offset: 0x000189AC
		private void HandleFreeZoom()
		{
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0001A7AE File Offset: 0x000189AE
		private void HandleFreeLookToggle()
		{
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0001A7B0 File Offset: 0x000189B0
		private void StartLooking()
		{
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0001A7B2 File Offset: 0x000189B2
		private void StopLooking()
		{
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0001A7B4 File Offset: 0x000189B4
		private void OnDisable()
		{
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0001A7B6 File Offset: 0x000189B6
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0001A7BD File Offset: 0x000189BD
		public void SetTarget(Transform target)
		{
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0001A7C9 File Offset: 0x000189C9
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x040009B5 RID: 2485
		public static float sensitivityModifier;

		// Token: 0x040009B6 RID: 2486
		public static Camera Instance;

		// Token: 0x040009B7 RID: 2487
		public static LayerMask clipIgnoreLayers;

		// Token: 0x040009B8 RID: 2488
		public static List<MeshRenderer> disableOnFirstPerson;

		// Token: 0x040009B9 RID: 2489
		private Camera cam;

		// Token: 0x040009BA RID: 2490
		private Transform target;

		// Token: 0x040009BB RID: 2491
		private float distance;

		// Token: 0x040009BC RID: 2492
		private float distanceLerp;

		// Token: 0x040009BD RID: 2493
		private float xSpeed;

		// Token: 0x040009BE RID: 2494
		private float ySpeed;

		// Token: 0x040009BF RID: 2495
		private float yMinLimit;

		// Token: 0x040009C0 RID: 2496
		private float yMaxLimit;

		// Token: 0x040009C1 RID: 2497
		private float distanceMax;

		// Token: 0x040009C2 RID: 2498
		private float minDist;

		// Token: 0x040009C3 RID: 2499
		private float maxDist;

		// Token: 0x040009C4 RID: 2500
		private bool clipThroughWalls;

		// Token: 0x040009C5 RID: 2501
		private float scrollSensitivity;

		// Token: 0x040009C6 RID: 2502
		private float flySpeed;

		// Token: 0x040009C7 RID: 2503
		private float fastFlySpeed;

		// Token: 0x040009C8 RID: 2504
		private float freeLookSensitivity;

		// Token: 0x040009C9 RID: 2505
		private float x;

		// Token: 0x040009CA RID: 2506
		private float y;

		// Token: 0x040009CB RID: 2507
		private bool init;

		// Token: 0x040009CC RID: 2508
		private bool wasLocked;

		// Token: 0x040009CD RID: 2509
		private bool looking;

		// Token: 0x040009CE RID: 2510
		private bool locked;

		// Token: 0x040009CF RID: 2511
		private bool wasFirstPerson;

		// Token: 0x040009D0 RID: 2512
		private CameraMode <Mode>k__BackingField;

		// Token: 0x040009D1 RID: 2513
		private float <LerpSpeed>k__BackingField;

		// Token: 0x040009D2 RID: 2514
		private bool <FollowLerp>k__BackingField;

		// Token: 0x040009D3 RID: 2515
		private bool <CanLock>k__BackingField;

		// Token: 0x040009D4 RID: 2516
		private bool <CtrlLocked>k__BackingField;

		// Token: 0x040009D5 RID: 2517
		private float <SensitivityMultiplier>k__BackingField;

		// Token: 0x040009D6 RID: 2518
		private Vector3 <PositionOffset>k__BackingField;

		// Token: 0x040009D7 RID: 2519
		private Vector3 <RotationOffset>k__BackingField;

		// Token: 0x040009D8 RID: 2520
		private int lastDisableFPCount;

		// Token: 0x040009D9 RID: 2521
		private DynamicInstance followTargetInstance;

		// Token: 0x040009DA RID: 2522
		private Transform followTargetTransform;
	}
}
