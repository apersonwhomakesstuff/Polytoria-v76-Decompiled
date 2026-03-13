using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200007F RID: 127
	[Serializable]
	public class SceneGizmoLookAndFeel : Settings
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00016A4B File Offset: 0x00014C4B
		private GizmoCap3DLookAndFeel AxisCapLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0001EA8C File Offset: 0x0001CC8C
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00016A4E File Offset: 0x00014C4E
		public SceneGizmoScreenCorner ScreenCorner
		{
			get
			{
				return SceneGizmoScreenCorner.TopLeft;
			}
			set
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001EAA4 File Offset: 0x0001CCA4
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00016A50 File Offset: 0x00014C50
		public Vector2 ScreenOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00016A52 File Offset: 0x00014C52
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00016A59 File Offset: 0x00014C59
		public float ScreenSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0001EABC File Offset: 0x0001CCBC
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00016A5B File Offset: 0x00014C5B
		public Color AxesLabelTint
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001EAD4 File Offset: 0x0001CCD4
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00016A5D File Offset: 0x00014C5D
		public Color CamPrjSwitchLabelTint
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00016A5F File Offset: 0x00014C5F
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00016A62 File Offset: 0x00014C62
		public bool IsCamPrjSwitchLabelVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00016A64 File Offset: 0x00014C64
		public Texture2D CamPerspModeLabelTexture
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00016A67 File Offset: 0x00014C67
		public Texture2D CamOrthoModeLabelTexture
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001EAEC File Offset: 0x0001CCEC
		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001EB04 File Offset: 0x0001CD04
		public GizmoCap3DType AxesCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001EB1C File Offset: 0x0001CD1C
		public GizmoCap3DType MidCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00016A6A File Offset: 0x00014C6A
		public float MidCapBoxSize
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00016A71 File Offset: 0x00014C71
		public float MidCapSphereRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00016A78 File Offset: 0x00014C78
		public float AxisConeHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00016A7F File Offset: 0x00014C7F
		public float AxisConeRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00016A86 File Offset: 0x00014C86
		public float AxisPyramidWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00016A8D File Offset: 0x00014C8D
		public float AxisPyramidHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00016A94 File Offset: 0x00014C94
		public float AxisPyramidDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00016A9B File Offset: 0x00014C9B
		public float AxisLabelScreenSize
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00016AA2 File Offset: 0x00014CA2
		public float AxisCamAlignFadeOutThreshold
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00016AA9 File Offset: 0x00014CA9
		public float AxisCamAlignFadeOutDuration
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00016AB0 File Offset: 0x00014CB0
		public float AxisCamAlignFadeOutAlpha
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00016ABF File Offset: 0x00014CBF
		public void SetMidCapColor(Color color)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00016AC1 File Offset: 0x00014CC1
		public void SetAxisCapColor(Color color, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001EB34 File Offset: 0x0001CD34
		public Color GetAxisCapColor(int axisIndex, AxisSign axisSign)
		{
			return default(Color);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00016AC3 File Offset: 0x00014CC3
		public void SetHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00016AC5 File Offset: 0x00014CC5
		public void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00016AC7 File Offset: 0x00014CC7
		public void SetAxisCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00016AC9 File Offset: 0x00014CC9
		public void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00016ACB File Offset: 0x00014CCB
		public void SetAxisCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00016ACD File Offset: 0x00014CCD
		public List<Enum> GetAllowedMidCapTypes()
		{
			return null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00016AD0 File Offset: 0x00014CD0
		public List<Enum> GetAllowedAxesCapTypes()
		{
			return null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00016AD3 File Offset: 0x00014CD3
		public bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00016AD6 File Offset: 0x00014CD6
		public void SetMidCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00016AD8 File Offset: 0x00014CD8
		public bool IsAxisCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00016ADB File Offset: 0x00014CDB
		public void SetAxisCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00016ADD File Offset: 0x00014CDD
		public float GetAxesLabelWorldSize(Camera gizmoCam, Vector3 labelWorldPos)
		{
			return 0f;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001EB4C File Offset: 0x0001CD4C
		public Vector2 CalculateMaxPrjSwitchLabelRectSize()
		{
			return default(Vector2);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00016AE4 File Offset: 0x00014CE4
		public void ConnectMidCapLookAndFeel(GizmoCap3D midCap)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00016AE6 File Offset: 0x00014CE6
		public void ConnectAxisCapLookAndFeel(GizmoCap3D axisCap, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00016AE8 File Offset: 0x00014CE8
		private GizmoCap3DLookAndFeel GetAxisCapLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00016AEB File Offset: 0x00014CEB
		private void OnScreenSizeChanged()
		{
		}

		// Token: 0x040001BE RID: 446
		private static readonly float _baseScreenSize;

		// Token: 0x040001BF RID: 447
		private static readonly float _invBaseScreenSize;

		// Token: 0x040001C0 RID: 448
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		// Token: 0x040001C1 RID: 449
		private GizmoCap3DLookAndFeel[] _axesCapsLookAndFeel;

		// Token: 0x040001C2 RID: 450
		private SceneGizmoScreenCorner _screenCorner;

		// Token: 0x040001C3 RID: 451
		private Vector2 _screenOffset;

		// Token: 0x040001C4 RID: 452
		private float _screenSize;

		// Token: 0x040001C5 RID: 453
		private Color _axesLabelTint;

		// Token: 0x040001C6 RID: 454
		private Color _camPrjSwitchLabelTint;

		// Token: 0x040001C7 RID: 455
		private bool _isCamPrjSwitchLabelVisible;
	}
}
