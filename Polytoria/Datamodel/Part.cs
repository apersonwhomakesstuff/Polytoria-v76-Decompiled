using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000297 RID: 663
	public class Part : DynamicInstance
	{
		// Token: 0x06001DF9 RID: 7673 RVA: 0x0001AF63 File Offset: 0x00019163
		protected override void OnHide()
		{
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0001AF65 File Offset: 0x00019165
		protected override void OnShow()
		{
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00024898 File Offset: 0x00022A98
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0001AF67 File Offset: 0x00019167
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0001AF69 File Offset: 0x00019169
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0001AF6C File Offset: 0x0001916C
		public bool Anchored
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x0001AF6E File Offset: 0x0001916E
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0001AF71 File Offset: 0x00019171
		public bool CanCollide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0001AF73 File Offset: 0x00019173
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0001AF76 File Offset: 0x00019176
		public bool IsSpawn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x000248B0 File Offset: 0x00022AB0
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0001AF78 File Offset: 0x00019178
		public PartShape Shape
		{
			get
			{
				return PartShape.Brick;
			}
			set
			{
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x000248C8 File Offset: 0x00022AC8
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0001AF7A File Offset: 0x0001917A
		public PartMaterial Material
		{
			get
			{
				return PartMaterial.SmoothPlastic;
			}
			set
			{
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0001AF7C File Offset: 0x0001917C
		private void UpdateMaterial()
		{
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000248E0 File Offset: 0x00022AE0
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x0001AF7E File Offset: 0x0001917E
		public Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x0001AF80 File Offset: 0x00019180
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x0001AF87 File Offset: 0x00019187
		public float Drag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0001AF89 File Offset: 0x00019189
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x0001AF90 File Offset: 0x00019190
		public float AngularDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x0001AF92 File Offset: 0x00019192
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0001AF99 File Offset: 0x00019199
		public float Mass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000248F8 File Offset: 0x00022AF8
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0001AF9B File Offset: 0x0001919B
		public Vector3 AngularVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x0001AF9D File Offset: 0x0001919D
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x0001AFA0 File Offset: 0x000191A0
		public bool UseGravity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x0001AFA2 File Offset: 0x000191A2
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x0001AFA9 File Offset: 0x000191A9
		public float Bounciness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x0001AFAB File Offset: 0x000191AB
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x0001AFB2 File Offset: 0x000191B2
		public float Friction
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00024910 File Offset: 0x00022B10
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x0001AFB4 File Offset: 0x000191B4
		public PhysicsMaterialCombine FrictionCombine
		{
			get
			{
				return PhysicsMaterialCombine.Average;
			}
			set
			{
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00024928 File Offset: 0x00022B28
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x0001AFB6 File Offset: 0x000191B6
		public PhysicsMaterialCombine BounceCombine
		{
			get
			{
				return PhysicsMaterialCombine.Average;
			}
			set
			{
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0001AFB8 File Offset: 0x000191B8
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x0001AFBB File Offset: 0x000191BB
		public bool CastShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0001AFBD File Offset: 0x000191BD
		protected override void Awake()
		{
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0001AFBF File Offset: 0x000191BF
		protected override void Start()
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0001AFC1 File Offset: 0x000191C1
		protected override void OnNetworkStart()
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0001AFC3 File Offset: 0x000191C3
		protected override void Update()
		{
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0001AFC5 File Offset: 0x000191C5
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0001AFC7 File Offset: 0x000191C7
		private void SetMass(float oldMass, float newMass)
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0001AFC9 File Offset: 0x000191C9
		private void SetVelocity(Vector3 oldVelocity, Vector3 newVelocity)
		{
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0001AFCB File Offset: 0x000191CB
		private void OnColorChange(Color oldColor, Color newColor)
		{
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0001AFCD File Offset: 0x000191CD
		protected override void OnDestroy()
		{
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0001AFCF File Offset: 0x000191CF
		public void MovePosition(Vector3 pos)
		{
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0001AFD1 File Offset: 0x000191D1
		public void MoveRotation(Vector3 rot)
		{
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0001AFD3 File Offset: 0x000191D3
		public void AddForce(Vector3 force, ForceMode mode)
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0001AFD5 File Offset: 0x000191D5
		public void AddTorque(Vector3 torque, ForceMode mode)
		{
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0001AFD7 File Offset: 0x000191D7
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
		{
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0001AFD9 File Offset: 0x000191D9
		public void AddRelativeForce(Vector3 force, ForceMode mode)
		{
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0001AFDB File Offset: 0x000191DB
		public void AddRelativeTorque(Vector3 torque, ForceMode mode)
		{
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0001AFDD File Offset: 0x000191DD
		private void RpcSetAnchored(bool anchored)
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0001AFDF File Offset: 0x000191DF
		protected void RpcSetCanCollide(bool canCollide)
		{
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0001AFE1 File Offset: 0x000191E1
		private void RpcSetSpawn(bool spawn)
		{
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0001AFE3 File Offset: 0x000191E3
		private void RpcSetShape(PartShape shape)
		{
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0001AFE5 File Offset: 0x000191E5
		private void RpcSetMaterial(PartMaterial material)
		{
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0001AFE7 File Offset: 0x000191E7
		private void RpcSetDrag(float d)
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0001AFE9 File Offset: 0x000191E9
		private void RpcSetAngularDrag(float d)
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0001AFEB File Offset: 0x000191EB
		private void RpcSetUseGravity(bool g)
		{
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0001AFED File Offset: 0x000191ED
		private void RpcSetBounciness(float b)
		{
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0001AFEF File Offset: 0x000191EF
		private void RpcSetFriction(float f)
		{
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0001AFF1 File Offset: 0x000191F1
		private void RpcSetFrictionCombine(PhysicsMaterialCombine c)
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0001AFF3 File Offset: 0x000191F3
		private void RpcSetBounceCombine(PhysicsMaterialCombine c)
		{
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0001AFF5 File Offset: 0x000191F5
		private void OnCastShadowsChanged(bool old, bool value)
		{
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0001AFF7 File Offset: 0x000191F7
		private void OnIsSpawnChanged(bool old, bool value)
		{
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0001AFF9 File Offset: 0x000191F9
		private void OnAnchoredChanged(bool old, bool value)
		{
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0001AFFB File Offset: 0x000191FB
		private void OnCanCollideChanged(bool old, bool value)
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0001AFFD File Offset: 0x000191FD
		private void OnShapeChange(PartShape old, PartShape value)
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0001AFFF File Offset: 0x000191FF
		private void OnMaterialChange(PartMaterial old, PartMaterial value)
		{
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0001B001 File Offset: 0x00019201
		private void OnDragChanged(float old, float value)
		{
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0001B003 File Offset: 0x00019203
		private void OnAngularDragChanged(float old, float value)
		{
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0001B005 File Offset: 0x00019205
		private void OnUseGravityChanged(bool old, bool value)
		{
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0001B007 File Offset: 0x00019207
		private void OnBouncinessChanged(float old, float value)
		{
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0001B009 File Offset: 0x00019209
		private void OnFrictionChanged(float old, float value)
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0001B00B File Offset: 0x0001920B
		private void OnFrictionCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value)
		{
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0001B00D File Offset: 0x0001920D
		private void OnBounceCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value)
		{
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0001B019 File Offset: 0x00019219
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0001B01C File Offset: 0x0001921C
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0001B01F File Offset: 0x0001921F
		public bool NetworkisSpawn
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0001B021 File Offset: 0x00019221
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0001B024 File Offset: 0x00019224
		public bool Networkanchored
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0001B026 File Offset: 0x00019226
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0001B029 File Offset: 0x00019229
		public bool NetworkcanCollide
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00024940 File Offset: 0x00022B40
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0001B02B File Offset: 0x0001922B
		public Color Networkcolor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00024958 File Offset: 0x00022B58
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0001B02D File Offset: 0x0001922D
		public PartShape Networkshape
		{
			get
			{
				return PartShape.Brick;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00024970 File Offset: 0x00022B70
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x0001B02F File Offset: 0x0001922F
		public PartMaterial Networkmaterial
		{
			get
			{
				return PartMaterial.SmoothPlastic;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00024988 File Offset: 0x00022B88
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x0001B031 File Offset: 0x00019231
		public Vector3 Networkvelocity
		{
			get
			{
				return default(Vector3);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0001B033 File Offset: 0x00019233
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x0001B036 File Offset: 0x00019236
		public bool NetworkcastShadows
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0001B038 File Offset: 0x00019238
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x0001B03F File Offset: 0x0001923F
		public float Networkdrag
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0001B041 File Offset: 0x00019241
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0001B048 File Offset: 0x00019248
		public float NetworkangularDrag
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0001B04A File Offset: 0x0001924A
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0001B04D File Offset: 0x0001924D
		public bool NetworkuseGravity
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0001B04F File Offset: 0x0001924F
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0001B056 File Offset: 0x00019256
		public float Networkbounciness
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0001B058 File Offset: 0x00019258
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0001B05F File Offset: 0x0001925F
		public float Networkfriction
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000249A0 File Offset: 0x00022BA0
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0001B061 File Offset: 0x00019261
		public PhysicsMaterialCombine NetworkfrictionCombine
		{
			get
			{
				return PhysicsMaterialCombine.Average;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000249B8 File Offset: 0x00022BB8
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0001B063 File Offset: 0x00019263
		public PhysicsMaterialCombine NetworkbounceCombine
		{
			get
			{
				return PhysicsMaterialCombine.Average;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0001B065 File Offset: 0x00019265
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0001B06C File Offset: 0x0001926C
		public float Networkmass
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0001B06E File Offset: 0x0001926E
		protected void UserCode_RpcSetAnchored__Boolean(bool anchored)
		{
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0001B070 File Offset: 0x00019270
		protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0001B072 File Offset: 0x00019272
		protected void UserCode_RpcSetCanCollide__Boolean(bool canCollide)
		{
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0001B074 File Offset: 0x00019274
		protected static void InvokeUserCode_RpcSetCanCollide__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0001B076 File Offset: 0x00019276
		protected void UserCode_RpcSetSpawn__Boolean(bool spawn)
		{
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0001B078 File Offset: 0x00019278
		protected static void InvokeUserCode_RpcSetSpawn__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0001B07A File Offset: 0x0001927A
		protected void UserCode_RpcSetShape__PartShape(PartShape shape)
		{
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0001B07C File Offset: 0x0001927C
		protected static void InvokeUserCode_RpcSetShape__PartShape(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0001B07E File Offset: 0x0001927E
		protected void UserCode_RpcSetMaterial__PartMaterial(PartMaterial material)
		{
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0001B080 File Offset: 0x00019280
		protected static void InvokeUserCode_RpcSetMaterial__PartMaterial(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0001B082 File Offset: 0x00019282
		protected void UserCode_RpcSetDrag__Single(float d)
		{
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0001B084 File Offset: 0x00019284
		protected static void InvokeUserCode_RpcSetDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0001B086 File Offset: 0x00019286
		protected void UserCode_RpcSetAngularDrag__Single(float d)
		{
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0001B088 File Offset: 0x00019288
		protected static void InvokeUserCode_RpcSetAngularDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0001B08A File Offset: 0x0001928A
		protected void UserCode_RpcSetUseGravity__Boolean(bool g)
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0001B08C File Offset: 0x0001928C
		protected static void InvokeUserCode_RpcSetUseGravity__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0001B08E File Offset: 0x0001928E
		protected void UserCode_RpcSetBounciness__Single(float b)
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0001B090 File Offset: 0x00019290
		protected static void InvokeUserCode_RpcSetBounciness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0001B092 File Offset: 0x00019292
		protected void UserCode_RpcSetFriction__Single(float f)
		{
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0001B094 File Offset: 0x00019294
		protected static void InvokeUserCode_RpcSetFriction__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0001B096 File Offset: 0x00019296
		protected void UserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c)
		{
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0001B098 File Offset: 0x00019298
		protected static void InvokeUserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0001B09A File Offset: 0x0001929A
		protected void UserCode_RpcSetBounceCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c)
		{
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0001B09C File Offset: 0x0001929C
		protected static void InvokeUserCode_RpcSetBounceCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0001B09E File Offset: 0x0001929E
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0001B0A0 File Offset: 0x000192A0
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000AE1 RID: 2785
		public static float MaterialUVScale;

		// Token: 0x04000AE2 RID: 2786
		protected bool isSpawnCached;

		// Token: 0x04000AE3 RID: 2787
		protected bool isSpawn;

		// Token: 0x04000AE4 RID: 2788
		protected bool anchored;

		// Token: 0x04000AE5 RID: 2789
		protected bool canCollide;

		// Token: 0x04000AE6 RID: 2790
		protected Color color;

		// Token: 0x04000AE7 RID: 2791
		protected PartShape shape;

		// Token: 0x04000AE8 RID: 2792
		protected PartMaterial material;

		// Token: 0x04000AE9 RID: 2793
		private Vector3 velocity;

		// Token: 0x04000AEA RID: 2794
		private bool castShadows;

		// Token: 0x04000AEB RID: 2795
		private float drag;

		// Token: 0x04000AEC RID: 2796
		private float angularDrag;

		// Token: 0x04000AED RID: 2797
		private bool useGravity;

		// Token: 0x04000AEE RID: 2798
		private float bounciness;

		// Token: 0x04000AEF RID: 2799
		private float friction;

		// Token: 0x04000AF0 RID: 2800
		private PhysicsMaterialCombine frictionCombine;

		// Token: 0x04000AF1 RID: 2801
		private PhysicsMaterialCombine bounceCombine;

		// Token: 0x04000AF2 RID: 2802
		private MaterialPropertyBlock materialPropertyBlock;

		// Token: 0x04000AF3 RID: 2803
		private Renderer _renderer;

		// Token: 0x04000AF4 RID: 2804
		private static Dictionary<PartShape, Mesh> shapeMeshes;

		// Token: 0x04000AF5 RID: 2805
		private float mass;

		// Token: 0x04000AF6 RID: 2806
		private Vector3 lastScale;

		// Token: 0x04000AF7 RID: 2807
		private Environment environment;

		// Token: 0x04000AF8 RID: 2808
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_isSpawn;

		// Token: 0x04000AF9 RID: 2809
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_anchored;

		// Token: 0x04000AFA RID: 2810
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_canCollide;

		// Token: 0x04000AFB RID: 2811
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		// Token: 0x04000AFC RID: 2812
		public Action<PartShape, PartShape> _Mirror_SyncVarHookDelegate_shape;

		// Token: 0x04000AFD RID: 2813
		public Action<PartMaterial, PartMaterial> _Mirror_SyncVarHookDelegate_material;

		// Token: 0x04000AFE RID: 2814
		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_velocity;

		// Token: 0x04000AFF RID: 2815
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_castShadows;

		// Token: 0x04000B00 RID: 2816
		public Action<float, float> _Mirror_SyncVarHookDelegate_drag;

		// Token: 0x04000B01 RID: 2817
		public Action<float, float> _Mirror_SyncVarHookDelegate_angularDrag;

		// Token: 0x04000B02 RID: 2818
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_useGravity;

		// Token: 0x04000B03 RID: 2819
		public Action<float, float> _Mirror_SyncVarHookDelegate_bounciness;

		// Token: 0x04000B04 RID: 2820
		public Action<float, float> _Mirror_SyncVarHookDelegate_friction;

		// Token: 0x04000B05 RID: 2821
		public Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_frictionCombine;

		// Token: 0x04000B06 RID: 2822
		public Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_bounceCombine;

		// Token: 0x04000B07 RID: 2823
		public Action<float, float> _Mirror_SyncVarHookDelegate_mass;
	}
}
