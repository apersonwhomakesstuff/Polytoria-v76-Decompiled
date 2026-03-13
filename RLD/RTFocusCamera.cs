using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000114 RID: 276
	public class RTFocusCamera : MonoSingleton<RTFocusCamera>
	{
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000E8D RID: 3725 RVA: 0x000185D5 File Offset: 0x000167D5
		// (remove) Token: 0x06000E8E RID: 3726 RVA: 0x000185D7 File Offset: 0x000167D7
		public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000E8F RID: 3727 RVA: 0x000185D9 File Offset: 0x000167D9
		// (remove) Token: 0x06000E90 RID: 3728 RVA: 0x000185DB File Offset: 0x000167DB
		public event CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000E91 RID: 3729 RVA: 0x000185DD File Offset: 0x000167DD
		// (remove) Token: 0x06000E92 RID: 3730 RVA: 0x000185DF File Offset: 0x000167DF
		public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000E93 RID: 3731 RVA: 0x000185E1 File Offset: 0x000167E1
		// (remove) Token: 0x06000E94 RID: 3732 RVA: 0x000185E3 File Offset: 0x000167E3
		public event CameraCanProcessInputHandler CanProcessInput
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000E95 RID: 3733 RVA: 0x000185E5 File Offset: 0x000167E5
		// (remove) Token: 0x06000E96 RID: 3734 RVA: 0x000185E7 File Offset: 0x000167E7
		public event CameraCanUseScrollWheelHandler CanUseScrollWheel
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000185E9 File Offset: 0x000167E9
		public Camera TargetCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x000185EC File Offset: 0x000167EC
		public bool IsDoingProjectionSwitch
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000206C4 File Offset: 0x0001E8C4
		public CameraPrjSwitchTransition.Type PrjSwitchTransitionType
		{
			get
			{
				return CameraPrjSwitchTransition.Type.None;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x000185EF File Offset: 0x000167EF
		public bool IsDoingRotationSwitch
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000185F2 File Offset: 0x000167F2
		public float PrjSwitchProgress
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x000185F9 File Offset: 0x000167F9
		public float PrjSwitchDurationInSeconds
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00018600 File Offset: 0x00016800
		public bool IsDoingFocus
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x000206DC File Offset: 0x0001E8DC
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00018603 File Offset: 0x00016803
		public Vector3 WorldPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000206F4 File Offset: 0x0001E8F4
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00018605 File Offset: 0x00016805
		public Quaternion WorldRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0002070C File Offset: 0x0001E90C
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00020724 File Offset: 0x0001E924
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0002073C File Offset: 0x0001E93C
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00018607 File Offset: 0x00016807
		public bool IsMovingForward
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0001860A File Offset: 0x0001680A
		public bool IsMovingBackwards
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0001860D File Offset: 0x0001680D
		public bool IsMovingLeft
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00018610 File Offset: 0x00016810
		public bool IsMovingRight
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00018613 File Offset: 0x00016813
		public bool IsMovingUp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00018616 File Offset: 0x00016816
		public bool IsMovingDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00018619 File Offset: 0x00016819
		public CameraSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0001861C File Offset: 0x0001681C
		public CameraMoveSettings MoveSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0001861F File Offset: 0x0001681F
		public CameraPanSettings PanSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00018622 File Offset: 0x00016822
		public CameraLookAroundSettings LookAroundSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00018625 File Offset: 0x00016825
		public CameraOrbitSettings OrbitSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00018628 File Offset: 0x00016828
		public CameraZoomSettings ZoomSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0001862B File Offset: 0x0001682B
		public CameraFocusSettings FocusSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0001862E File Offset: 0x0001682E
		public CameraRotationSwitchSettings RotationSwitchSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00018631 File Offset: 0x00016831
		public CameraProjectionSwitchSettings ProjectionSwitchSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00018634 File Offset: 0x00016834
		public CameraHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00018637 File Offset: 0x00016837
		public bool IsViewportHoveredByDevice()
		{
			return false;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0001863A File Offset: 0x0001683A
		public void SetTargetCamera(Camera camera)
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0001863C File Offset: 0x0001683C
		public void SetFieldOfView(float fov)
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0001863E File Offset: 0x0001683E
		public void SetObjectVisibilityDirty()
		{
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00018640 File Offset: 0x00016840
		public void GetVisibleObjects(List<GameObject> visibleObjects)
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00018642 File Offset: 0x00016842
		public void PerformRotationSwitch(Quaternion targetRotation)
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00018644 File Offset: 0x00016844
		public void PerformProjectionSwitch()
		{
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00018646 File Offset: 0x00016846
		public void Focus(AABB focusAABB)
		{
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00018648 File Offset: 0x00016848
		public void Update_SystemCall()
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0001864A File Offset: 0x0001684A
		private void Awake()
		{
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0001864C File Offset: 0x0001684C
		private void Start()
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0001864E File Offset: 0x0001684E
		private void HandleMouseAndKeyboardInput()
		{
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00018650 File Offset: 0x00016850
		private bool CanUseMouseScrollWheel()
		{
			return false;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00018653 File Offset: 0x00016853
		private bool CanCameraProcessInput()
		{
			return false;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00018656 File Offset: 0x00016856
		private void Zoom(float zoomAmount)
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00020754 File Offset: 0x0001E954
		private Vector3 GetFocusPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00018658 File Offset: 0x00016858
		private float CalculateScrollZoomAmount(float deviceScroll)
		{
			return 0f;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0001865F File Offset: 0x0001685F
		private void Pan(Vector2 panAmount)
		{
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00018661 File Offset: 0x00016861
		public void LookAround(float degreesLocalX, float degreesWorldY)
		{
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00018663 File Offset: 0x00016863
		private void Orbit(float degreesLocalX, float degreesWorldY)
		{
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00018665 File Offset: 0x00016865
		private void PerformInstantFocus(CameraFocus.Data focusData)
		{
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00018667 File Offset: 0x00016867
		private void PerformInstantProjectionSwitch()
		{
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0002076C File Offset: 0x0001E96C
		private Vector2 CalculateLookAroundRotation(float deviceAxisX, float deviceAxisY)
		{
			return default(Vector2);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00020784 File Offset: 0x0001E984
		private Vector2 CalculateOrbitRotation(float deviceAxisX, float deviceAxisY)
		{
			return default(Vector2);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0002079C File Offset: 0x0001E99C
		private Vector2 CalculatePanAmount(float deviceAxisX, float deviceAxisY)
		{
			return default(Vector2);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00018669 File Offset: 0x00016869
		private void StopCamTransform()
		{
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0001866B File Offset: 0x0001686B
		private void StopFocus()
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0001866D File Offset: 0x0001686D
		private void SetFocusPoint(Vector3 focusPoint)
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0001866F File Offset: 0x0001686F
		private void AdjustOrthoSizeForFocusPt()
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00018671 File Offset: 0x00016871
		private IEnumerator DoSmoothPan(float deviceAxisX, float deviceAxisY)
		{
			return null;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00018674 File Offset: 0x00016874
		private IEnumerator DoSmoothLookAround(float deviceAxisX, float deviceAxisY)
		{
			return null;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00018677 File Offset: 0x00016877
		private IEnumerator DoSmoothOrbit(float deviceAxisX, float deviceAxisY)
		{
			return null;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0001867A File Offset: 0x0001687A
		private IEnumerator DoSmoothZoom(float deviceScroll)
		{
			return null;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0001867D File Offset: 0x0001687D
		private IEnumerator DoConstantRotationSwitch(Quaternion targetRotation)
		{
			return null;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00018680 File Offset: 0x00016880
		private IEnumerator DoSmoothRotationSwitch(Quaternion targetRotation)
		{
			return null;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00018683 File Offset: 0x00016883
		private IEnumerator DoConstantFocus(CameraFocus.Data focusData)
		{
			return null;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00018686 File Offset: 0x00016886
		private IEnumerator DoSmoothFocus(CameraFocus.Data focusData)
		{
			return null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00018689 File Offset: 0x00016889
		private void OnPrjSwitchTransitionBegin(CameraPrjSwitchTransition.Type transitionType)
		{
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0001868B File Offset: 0x0001688B
		private void OnPrjSwitchTransitionUpate(CameraPrjSwitchTransition.Type transitionType)
		{
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0001868D File Offset: 0x0001688D
		private void OnPrjSwitchTransitionEnd(CameraPrjSwitchTransition.Type transitionType)
		{
		}

		// Token: 0x0400052A RID: 1322
		private Camera _targetCamera;

		// Token: 0x0400052B RID: 1323
		private Transform _targetTransform;

		// Token: 0x0400052C RID: 1324
		private float _fieldOfView;

		// Token: 0x0400052D RID: 1325
		private WorldTransformSnapshot _worldTransformSnapshot;

		// Token: 0x0400052E RID: 1326
		private CameraPrjSwitchTransition _prjSwitchTranstion;

		// Token: 0x0400052F RID: 1327
		private bool _isDoingFocus;

		// Token: 0x04000530 RID: 1328
		private IEnumerator _focusCrtn;

		// Token: 0x04000531 RID: 1329
		private bool _isDoingRotationSwitch;

		// Token: 0x04000532 RID: 1330
		private IEnumerator _genricCamTransformCrtn;

		// Token: 0x04000533 RID: 1331
		private bool _isObjectVisibilityDirty;

		// Token: 0x04000534 RID: 1332
		private List<GameObject> _visibleObjects;

		// Token: 0x04000535 RID: 1333
		private float _focusPointOffset;

		// Token: 0x04000536 RID: 1334
		private Vector3 _lastFocusPoint;

		// Token: 0x04000537 RID: 1335
		private bool[] _moveDirFlags;

		// Token: 0x04000538 RID: 1336
		private float _currentAcceleration;

		// Token: 0x04000539 RID: 1337
		private CameraSettings _settings;

		// Token: 0x0400053A RID: 1338
		private CameraMoveSettings _moveSettings;

		// Token: 0x0400053B RID: 1339
		private CameraPanSettings _panSettings;

		// Token: 0x0400053C RID: 1340
		private CameraLookAroundSettings _lookAroundSettings;

		// Token: 0x0400053D RID: 1341
		private CameraOrbitSettings _orbitSettings;

		// Token: 0x0400053E RID: 1342
		private CameraZoomSettings _zoomSettings;

		// Token: 0x0400053F RID: 1343
		private CameraFocusSettings _focusSettings;

		// Token: 0x04000540 RID: 1344
		private CameraRotationSwitchSettings _rotationSwitchSettings;

		// Token: 0x04000541 RID: 1345
		private CameraProjectionSwitchSettings _projectionSwitchSettings;

		// Token: 0x04000542 RID: 1346
		private CameraHotkeys _hotkeys;

		// Token: 0x0200037C RID: 892
		private enum MoveDirection
		{
			// Token: 0x04000F21 RID: 3873
			Left,
			// Token: 0x04000F22 RID: 3874
			Right,
			// Token: 0x04000F23 RID: 3875
			Up,
			// Token: 0x04000F24 RID: 3876
			Down,
			// Token: 0x04000F25 RID: 3877
			Forward,
			// Token: 0x04000F26 RID: 3878
			Backwards
		}

		// Token: 0x0200037D RID: 893
		private sealed class <DoConstantFocus>d__134 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A73 RID: 10867 RVA: 0x0001D234 File Offset: 0x0001B434
			public <DoConstantFocus>d__134(int <>1__state)
			{
			}

			// Token: 0x06002A74 RID: 10868 RVA: 0x0001D23C File Offset: 0x0001B43C
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A75 RID: 10869 RVA: 0x0001D23E File Offset: 0x0001B43E
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C83 RID: 3203
			// (get) Token: 0x06002A76 RID: 10870 RVA: 0x0001D241 File Offset: 0x0001B441
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A77 RID: 10871 RVA: 0x0001D244 File Offset: 0x0001B444
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C84 RID: 3204
			// (get) Token: 0x06002A78 RID: 10872 RVA: 0x0001D246 File Offset: 0x0001B446
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F27 RID: 3879
			private int <>1__state;

			// Token: 0x04000F28 RID: 3880
			private object <>2__current;

			// Token: 0x04000F29 RID: 3881
			public RTFocusCamera <>4__this;

			// Token: 0x04000F2A RID: 3882
			public CameraFocus.Data focusData;

			// Token: 0x04000F2B RID: 3883
			private float <targetOrthoSize>5__2;

			// Token: 0x04000F2C RID: 3884
			private Vector3 <camMoveDir>5__3;

			// Token: 0x04000F2D RID: 3885
			private float <distanceToTravel>5__4;

			// Token: 0x04000F2E RID: 3886
			private float <initialCamOrthoSize>5__5;
		}

		// Token: 0x0200037E RID: 894
		private sealed class <DoConstantRotationSwitch>d__132 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A79 RID: 10873 RVA: 0x0001D249 File Offset: 0x0001B449
			public <DoConstantRotationSwitch>d__132(int <>1__state)
			{
			}

			// Token: 0x06002A7A RID: 10874 RVA: 0x0001D251 File Offset: 0x0001B451
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A7B RID: 10875 RVA: 0x0001D253 File Offset: 0x0001B453
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C85 RID: 3205
			// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0001D256 File Offset: 0x0001B456
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A7D RID: 10877 RVA: 0x0001D259 File Offset: 0x0001B459
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C86 RID: 3206
			// (get) Token: 0x06002A7E RID: 10878 RVA: 0x0001D25B File Offset: 0x0001B45B
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F2F RID: 3887
			private int <>1__state;

			// Token: 0x04000F30 RID: 3888
			private object <>2__current;

			// Token: 0x04000F31 RID: 3889
			public RTFocusCamera <>4__this;

			// Token: 0x04000F32 RID: 3890
			public Quaternion targetRotation;

			// Token: 0x04000F33 RID: 3891
			private Quaternion <sourceRotation>5__2;

			// Token: 0x04000F34 RID: 3892
			private float <elapsedTime>5__3;
		}

		// Token: 0x0200037F RID: 895
		private sealed class <DoSmoothFocus>d__135 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A7F RID: 10879 RVA: 0x0001D25E File Offset: 0x0001B45E
			public <DoSmoothFocus>d__135(int <>1__state)
			{
			}

			// Token: 0x06002A80 RID: 10880 RVA: 0x0001D266 File Offset: 0x0001B466
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A81 RID: 10881 RVA: 0x0001D268 File Offset: 0x0001B468
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C87 RID: 3207
			// (get) Token: 0x06002A82 RID: 10882 RVA: 0x0001D26B File Offset: 0x0001B46B
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A83 RID: 10883 RVA: 0x0001D26E File Offset: 0x0001B46E
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C88 RID: 3208
			// (get) Token: 0x06002A84 RID: 10884 RVA: 0x0001D270 File Offset: 0x0001B470
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F35 RID: 3893
			private int <>1__state;

			// Token: 0x04000F36 RID: 3894
			private object <>2__current;

			// Token: 0x04000F37 RID: 3895
			public RTFocusCamera <>4__this;

			// Token: 0x04000F38 RID: 3896
			public CameraFocus.Data focusData;

			// Token: 0x04000F39 RID: 3897
			private float <targetOrthoSize>5__2;

			// Token: 0x04000F3A RID: 3898
			private Vector3 <camMoveDir>5__3;

			// Token: 0x04000F3B RID: 3899
			private float <elapsedTime>5__4;
		}

		// Token: 0x02000380 RID: 896
		private sealed class <DoSmoothLookAround>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A85 RID: 10885 RVA: 0x0001D273 File Offset: 0x0001B473
			public <DoSmoothLookAround>d__129(int <>1__state)
			{
			}

			// Token: 0x06002A86 RID: 10886 RVA: 0x0001D27B File Offset: 0x0001B47B
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A87 RID: 10887 RVA: 0x0001D27D File Offset: 0x0001B47D
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C89 RID: 3209
			// (get) Token: 0x06002A88 RID: 10888 RVA: 0x0001D280 File Offset: 0x0001B480
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A89 RID: 10889 RVA: 0x0001D283 File Offset: 0x0001B483
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x06002A8A RID: 10890 RVA: 0x0001D285 File Offset: 0x0001B485
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F3C RID: 3900
			private int <>1__state;

			// Token: 0x04000F3D RID: 3901
			private object <>2__current;

			// Token: 0x04000F3E RID: 3902
			public RTFocusCamera <>4__this;

			// Token: 0x04000F3F RID: 3903
			public float deviceAxisX;

			// Token: 0x04000F40 RID: 3904
			public float deviceAxisY;

			// Token: 0x04000F41 RID: 3905
			private Vector2 <rotationAmount>5__2;
		}

		// Token: 0x02000381 RID: 897
		private sealed class <DoSmoothOrbit>d__130 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A8B RID: 10891 RVA: 0x0001D288 File Offset: 0x0001B488
			public <DoSmoothOrbit>d__130(int <>1__state)
			{
			}

			// Token: 0x06002A8C RID: 10892 RVA: 0x0001D290 File Offset: 0x0001B490
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A8D RID: 10893 RVA: 0x0001D292 File Offset: 0x0001B492
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x06002A8E RID: 10894 RVA: 0x0001D295 File Offset: 0x0001B495
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A8F RID: 10895 RVA: 0x0001D298 File Offset: 0x0001B498
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x06002A90 RID: 10896 RVA: 0x0001D29A File Offset: 0x0001B49A
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F42 RID: 3906
			private int <>1__state;

			// Token: 0x04000F43 RID: 3907
			private object <>2__current;

			// Token: 0x04000F44 RID: 3908
			public RTFocusCamera <>4__this;

			// Token: 0x04000F45 RID: 3909
			public float deviceAxisX;

			// Token: 0x04000F46 RID: 3910
			public float deviceAxisY;

			// Token: 0x04000F47 RID: 3911
			private Vector2 <rotationAmount>5__2;
		}

		// Token: 0x02000382 RID: 898
		private sealed class <DoSmoothPan>d__128 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A91 RID: 10897 RVA: 0x0001D29D File Offset: 0x0001B49D
			public <DoSmoothPan>d__128(int <>1__state)
			{
			}

			// Token: 0x06002A92 RID: 10898 RVA: 0x0001D2A5 File Offset: 0x0001B4A5
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A93 RID: 10899 RVA: 0x0001D2A7 File Offset: 0x0001B4A7
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x06002A94 RID: 10900 RVA: 0x0001D2AA File Offset: 0x0001B4AA
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A95 RID: 10901 RVA: 0x0001D2AD File Offset: 0x0001B4AD
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C8E RID: 3214
			// (get) Token: 0x06002A96 RID: 10902 RVA: 0x0001D2AF File Offset: 0x0001B4AF
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F48 RID: 3912
			private int <>1__state;

			// Token: 0x04000F49 RID: 3913
			private object <>2__current;

			// Token: 0x04000F4A RID: 3914
			public RTFocusCamera <>4__this;

			// Token: 0x04000F4B RID: 3915
			public float deviceAxisX;

			// Token: 0x04000F4C RID: 3916
			public float deviceAxisY;

			// Token: 0x04000F4D RID: 3917
			private Vector2 <panAmount>5__2;
		}

		// Token: 0x02000383 RID: 899
		private sealed class <DoSmoothRotationSwitch>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A97 RID: 10903 RVA: 0x0001D2B2 File Offset: 0x0001B4B2
			public <DoSmoothRotationSwitch>d__133(int <>1__state)
			{
			}

			// Token: 0x06002A98 RID: 10904 RVA: 0x0001D2BA File Offset: 0x0001B4BA
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A99 RID: 10905 RVA: 0x0001D2BC File Offset: 0x0001B4BC
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x06002A9A RID: 10906 RVA: 0x0001D2BF File Offset: 0x0001B4BF
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002A9B RID: 10907 RVA: 0x0001D2C2 File Offset: 0x0001B4C2
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x06002A9C RID: 10908 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F4E RID: 3918
			private int <>1__state;

			// Token: 0x04000F4F RID: 3919
			private object <>2__current;

			// Token: 0x04000F50 RID: 3920
			public RTFocusCamera <>4__this;

			// Token: 0x04000F51 RID: 3921
			public Quaternion targetRotation;
		}

		// Token: 0x02000384 RID: 900
		private sealed class <DoSmoothZoom>d__131 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002A9D RID: 10909 RVA: 0x0001D2C7 File Offset: 0x0001B4C7
			public <DoSmoothZoom>d__131(int <>1__state)
			{
			}

			// Token: 0x06002A9E RID: 10910 RVA: 0x0001D2CF File Offset: 0x0001B4CF
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002A9F RID: 10911 RVA: 0x0001D2D1 File Offset: 0x0001B4D1
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x0001D2D4 File Offset: 0x0001B4D4
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002AA1 RID: 10913 RVA: 0x0001D2D7 File Offset: 0x0001B4D7
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x0001D2D9 File Offset: 0x0001B4D9
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000F52 RID: 3922
			private int <>1__state;

			// Token: 0x04000F53 RID: 3923
			private object <>2__current;

			// Token: 0x04000F54 RID: 3924
			public RTFocusCamera <>4__this;

			// Token: 0x04000F55 RID: 3925
			public float deviceScroll;

			// Token: 0x04000F56 RID: 3926
			private float <zoomAmount>5__2;
		}
	}
}
