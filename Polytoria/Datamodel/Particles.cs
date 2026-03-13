using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Controllers;
using Polytoria.Types;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200029A RID: 666
	public class Particles : DynamicInstance
	{
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0001B0A2 File Offset: 0x000192A2
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0001B0A5 File Offset: 0x000192A5
		public string ImageID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000249D0 File Offset: 0x00022BD0
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0001B0A7 File Offset: 0x000192A7
		public ImageType ImageType
		{
			get
			{
				return ImageType.Asset;
			}
			set
			{
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000249E8 File Offset: 0x00022BE8
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0001B0A9 File Offset: 0x000192A9
		public ColorRange Color
		{
			get
			{
				return default(ColorRange);
			}
			set
			{
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00024A00 File Offset: 0x00022C00
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0001B0AB File Offset: 0x000192AB
		public ParticleColorMode ColorMode
		{
			get
			{
				return ParticleColorMode.Multiply;
			}
			set
			{
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00024A18 File Offset: 0x00022C18
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0001B0AD File Offset: 0x000192AD
		public NumberRange Lifetime
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00024A30 File Offset: 0x00022C30
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0001B0AF File Offset: 0x000192AF
		public NumberRange SizeOverLifetime
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00024A48 File Offset: 0x00022C48
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0001B0B1 File Offset: 0x000192B1
		public NumberRange Speed
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0001B0B3 File Offset: 0x000192B3
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0001B0B6 File Offset: 0x000192B6
		public int EmissionRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0001B0B8 File Offset: 0x000192B8
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0001B0BB File Offset: 0x000192BB
		public int MaxParticles
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x0001B0BD File Offset: 0x000192BD
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0001B0C4 File Offset: 0x000192C4
		public float Gravity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00024A60 File Offset: 0x00022C60
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0001B0C6 File Offset: 0x000192C6
		public ParticleSimulationSpace SimulationSpace
		{
			get
			{
				return ParticleSimulationSpace.Local;
			}
			set
			{
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x00024A78 File Offset: 0x00022C78
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0001B0C8 File Offset: 0x000192C8
		public NumberRange StartRotation
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00024A90 File Offset: 0x00022C90
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x0001B0CA File Offset: 0x000192CA
		public NumberRange AngularVelocity
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x0001B0CC File Offset: 0x000192CC
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0001B0CF File Offset: 0x000192CF
		public bool Autoplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x0001B0D1 File Offset: 0x000192D1
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x0001B0D4 File Offset: 0x000192D4
		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x0001B0D6 File Offset: 0x000192D6
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x0001B0DD File Offset: 0x000192DD
		public float Duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00024AA8 File Offset: 0x00022CA8
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x0001B0DF File Offset: 0x000192DF
		public ParticleShape Shape
		{
			get
			{
				return ParticleShape.Sphere;
			}
			set
			{
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x0001B0E1 File Offset: 0x000192E1
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x0001B0E8 File Offset: 0x000192E8
		public float ShapeRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x0001B0EA File Offset: 0x000192EA
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x0001B0F1 File Offset: 0x000192F1
		public float ShapeAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00024AC0 File Offset: 0x00022CC0
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0001B0F3 File Offset: 0x000192F3
		public Vector3 ShapeScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x0001B0F5 File Offset: 0x000192F5
		public bool IsPlaying
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x0001B0F8 File Offset: 0x000192F8
		public bool IsPaused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0001B0FB File Offset: 0x000192FB
		public bool IsStopped
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x0001B0FE File Offset: 0x000192FE
		public int ParticleCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0001B101 File Offset: 0x00019301
		public float Time
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x0001B108 File Offset: 0x00019308
		public float TotalTime
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0001B10F File Offset: 0x0001930F
		protected override void Awake()
		{
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0001B111 File Offset: 0x00019311
		protected override void OnHide()
		{
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0001B113 File Offset: 0x00019313
		protected override void OnShow()
		{
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0001B115 File Offset: 0x00019315
		private void GetImage()
		{
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0001B117 File Offset: 0x00019317
		public void Play()
		{
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0001B119 File Offset: 0x00019319
		public void Pause()
		{
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0001B11B File Offset: 0x0001931B
		public void Stop()
		{
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0001B11D File Offset: 0x0001931D
		public void Clear()
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0001B11F File Offset: 0x0001931F
		public void Emit(int count)
		{
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0001B121 File Offset: 0x00019321
		public void Simulate(float time)
		{
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0001B123 File Offset: 0x00019323
		private void RpcPlay()
		{
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0001B125 File Offset: 0x00019325
		private void RpcPause()
		{
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0001B127 File Offset: 0x00019327
		private void RpcStop()
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0001B129 File Offset: 0x00019329
		private void RpcClear()
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0001B12B File Offset: 0x0001932B
		private void RpcEmit(int count)
		{
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0001B12D File Offset: 0x0001932D
		private void RpcSimulate(float time)
		{
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0001B12F File Offset: 0x0001932F
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0001B131 File Offset: 0x00019331
		private void OnImageIDChanged(string oldID, string newID)
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0001B133 File Offset: 0x00019333
		private void OnImageTypeChanged(ImageType oldType, ImageType newType)
		{
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0001B135 File Offset: 0x00019335
		private void OnColorChanged(ColorRange oldColor, ColorRange newColor)
		{
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0001B137 File Offset: 0x00019337
		private void OnColorModeChanged(ParticleColorMode oldColorMode, ParticleColorMode newColorMode)
		{
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0001B139 File Offset: 0x00019339
		private void OnLifetimeChanged(NumberRange oldLifetime, NumberRange newLifetime)
		{
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0001B13B File Offset: 0x0001933B
		private void OnSizeOverLifetimeChanged(NumberRange oldSizeOverLifetime, NumberRange newSizeOverLifetime)
		{
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0001B13D File Offset: 0x0001933D
		private void OnSpeedChanged(NumberRange oldSpeed, NumberRange newSpeed)
		{
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0001B13F File Offset: 0x0001933F
		private void OnEmissionRateChanged(int oldEmissionRate, int newEmissionRate)
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0001B141 File Offset: 0x00019341
		private void OnMaxParticlesChanged(int oldMaxParticles, int newMaxParticles)
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0001B143 File Offset: 0x00019343
		private void OnGravityChanged(float oldGravity, float newGravity)
		{
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0001B145 File Offset: 0x00019345
		private void OnSimulationSpaceChanged(ParticleSimulationSpace oldSimulationSpace, ParticleSimulationSpace newSimulationSpace)
		{
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0001B147 File Offset: 0x00019347
		private void OnStartRotationChanged(NumberRange oldStartRotation, NumberRange newStartRotation)
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x0001B149 File Offset: 0x00019349
		private void OnAngularVelocityChanged(NumberRange oldAngularVelocity, NumberRange newAngularVelocity)
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0001B14B File Offset: 0x0001934B
		private void OnAutoplayChanged(bool oldVal, bool newVal)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0001B14D File Offset: 0x0001934D
		private void OnLoopChanged(bool oldLoop, bool newLoop)
		{
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0001B14F File Offset: 0x0001934F
		private void OnDurationChanged(float oldDuration, float newDuration)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0001B151 File Offset: 0x00019351
		private void OnShapeChanged(ParticleShape oldShape, ParticleShape newShape)
		{
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0001B153 File Offset: 0x00019353
		private void OnShapeRadiusChanged(float oldRadius, float newRadius)
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0001B155 File Offset: 0x00019355
		private void OnShapeAngleChanged(float oldAngle, float newAngle)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0001B157 File Offset: 0x00019357
		private void OnShapeScaleChanged(Vector3 oldScale, Vector3 newScale)
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0001B161 File Offset: 0x00019361
		private void <GetImage>b__98_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0001B163 File Offset: 0x00019363
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x0001B166 File Offset: 0x00019366
		// (set) Token: 0x06001EDB RID: 7899 RVA: 0x0001B169 File Offset: 0x00019369
		public string NetworkimageID
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00024AD8 File Offset: 0x00022CD8
		// (set) Token: 0x06001EDD RID: 7901 RVA: 0x0001B16B File Offset: 0x0001936B
		public ImageType NetworkimageType
		{
			get
			{
				return ImageType.Asset;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00024AF0 File Offset: 0x00022CF0
		// (set) Token: 0x06001EDF RID: 7903 RVA: 0x0001B16D File Offset: 0x0001936D
		public ColorRange Networkcolor
		{
			get
			{
				return default(ColorRange);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00024B08 File Offset: 0x00022D08
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x0001B16F File Offset: 0x0001936F
		public ParticleColorMode NetworkcolorMode
		{
			get
			{
				return ParticleColorMode.Multiply;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00024B20 File Offset: 0x00022D20
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x0001B171 File Offset: 0x00019371
		public NumberRange Networklifetime
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00024B38 File Offset: 0x00022D38
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x0001B173 File Offset: 0x00019373
		public NumberRange NetworksizeOverLifetime
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x00024B50 File Offset: 0x00022D50
		// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x0001B175 File Offset: 0x00019375
		public NumberRange Networkspeed
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x0001B177 File Offset: 0x00019377
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x0001B17A File Offset: 0x0001937A
		public int NetworkemissionRate
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x0001B17C File Offset: 0x0001937C
		// (set) Token: 0x06001EEB RID: 7915 RVA: 0x0001B17F File Offset: 0x0001937F
		public int NetworkmaxParticles
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x0001B181 File Offset: 0x00019381
		// (set) Token: 0x06001EED RID: 7917 RVA: 0x0001B188 File Offset: 0x00019388
		public float Networkgravity
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

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x00024B68 File Offset: 0x00022D68
		// (set) Token: 0x06001EEF RID: 7919 RVA: 0x0001B18A File Offset: 0x0001938A
		public ParticleSimulationSpace NetworksimulationSpace
		{
			get
			{
				return ParticleSimulationSpace.Local;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00024B80 File Offset: 0x00022D80
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x0001B18C File Offset: 0x0001938C
		public NumberRange NetworkstartRotation
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00024B98 File Offset: 0x00022D98
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x0001B18E File Offset: 0x0001938E
		public NumberRange NetworkangularVelocity
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0001B190 File Offset: 0x00019390
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x0001B193 File Offset: 0x00019393
		public bool Networkautoplay
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x0001B195 File Offset: 0x00019395
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x0001B198 File Offset: 0x00019398
		public bool Networkloop
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0001B19A File Offset: 0x0001939A
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x0001B1A1 File Offset: 0x000193A1
		public float Networkduration
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00024BB0 File Offset: 0x00022DB0
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0001B1A3 File Offset: 0x000193A3
		public ParticleShape Networkshape
		{
			get
			{
				return ParticleShape.Sphere;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0001B1A5 File Offset: 0x000193A5
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0001B1AC File Offset: 0x000193AC
		public float NetworkshapeRadius
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

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x0001B1AE File Offset: 0x000193AE
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0001B1B5 File Offset: 0x000193B5
		public float NetworkshapeAngle
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

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00024BC8 File Offset: 0x00022DC8
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0001B1B7 File Offset: 0x000193B7
		public Vector3 NetworkshapeScale
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

		// Token: 0x06001F02 RID: 7938 RVA: 0x0001B1B9 File Offset: 0x000193B9
		protected void UserCode_RpcPlay()
		{
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x0001B1BB File Offset: 0x000193BB
		protected static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x0001B1BD File Offset: 0x000193BD
		protected void UserCode_RpcPause()
		{
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0001B1BF File Offset: 0x000193BF
		protected static void InvokeUserCode_RpcPause(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0001B1C1 File Offset: 0x000193C1
		protected void UserCode_RpcStop()
		{
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0001B1C3 File Offset: 0x000193C3
		protected static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0001B1C5 File Offset: 0x000193C5
		protected void UserCode_RpcClear()
		{
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x0001B1C7 File Offset: 0x000193C7
		protected static void InvokeUserCode_RpcClear(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x0001B1C9 File Offset: 0x000193C9
		protected void UserCode_RpcEmit__Int32(int count)
		{
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x0001B1CB File Offset: 0x000193CB
		protected static void InvokeUserCode_RpcEmit__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x0001B1CD File Offset: 0x000193CD
		protected void UserCode_RpcSimulate__Single(float time)
		{
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0001B1CF File Offset: 0x000193CF
		protected static void InvokeUserCode_RpcSimulate__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0001B1D3 File Offset: 0x000193D3
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0001B1D5 File Offset: 0x000193D5
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000B29 RID: 2857
		private ParticleSystem particles;

		// Token: 0x04000B2A RID: 2858
		private string imageID;

		// Token: 0x04000B2B RID: 2859
		private ImageType imageType;

		// Token: 0x04000B2C RID: 2860
		private ColorRange color;

		// Token: 0x04000B2D RID: 2861
		private ParticleColorMode colorMode;

		// Token: 0x04000B2E RID: 2862
		private NumberRange lifetime;

		// Token: 0x04000B2F RID: 2863
		private NumberRange sizeOverLifetime;

		// Token: 0x04000B30 RID: 2864
		private NumberRange speed;

		// Token: 0x04000B31 RID: 2865
		private int emissionRate;

		// Token: 0x04000B32 RID: 2866
		private int maxParticles;

		// Token: 0x04000B33 RID: 2867
		private float gravity;

		// Token: 0x04000B34 RID: 2868
		private ParticleSimulationSpace simulationSpace;

		// Token: 0x04000B35 RID: 2869
		private NumberRange startRotation;

		// Token: 0x04000B36 RID: 2870
		private NumberRange angularVelocity;

		// Token: 0x04000B37 RID: 2871
		private bool autoplay;

		// Token: 0x04000B38 RID: 2872
		private bool loop;

		// Token: 0x04000B39 RID: 2873
		private float duration;

		// Token: 0x04000B3A RID: 2874
		private ParticleShape shape;

		// Token: 0x04000B3B RID: 2875
		private float shapeRadius;

		// Token: 0x04000B3C RID: 2876
		private float shapeAngle;

		// Token: 0x04000B3D RID: 2877
		private Vector3 shapeScale;

		// Token: 0x04000B3E RID: 2878
		private ImageCacheKey lastCacheKey;

		// Token: 0x04000B3F RID: 2879
		private ImageCacheEntry currentEntry;

		// Token: 0x04000B40 RID: 2880
		public Action<string, string> _Mirror_SyncVarHookDelegate_imageID;

		// Token: 0x04000B41 RID: 2881
		public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType;

		// Token: 0x04000B42 RID: 2882
		public Action<ColorRange, ColorRange> _Mirror_SyncVarHookDelegate_color;

		// Token: 0x04000B43 RID: 2883
		public Action<ParticleColorMode, ParticleColorMode> _Mirror_SyncVarHookDelegate_colorMode;

		// Token: 0x04000B44 RID: 2884
		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_lifetime;

		// Token: 0x04000B45 RID: 2885
		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_sizeOverLifetime;

		// Token: 0x04000B46 RID: 2886
		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_speed;

		// Token: 0x04000B47 RID: 2887
		public Action<int, int> _Mirror_SyncVarHookDelegate_emissionRate;

		// Token: 0x04000B48 RID: 2888
		public Action<int, int> _Mirror_SyncVarHookDelegate_maxParticles;

		// Token: 0x04000B49 RID: 2889
		public Action<float, float> _Mirror_SyncVarHookDelegate_gravity;

		// Token: 0x04000B4A RID: 2890
		public Action<ParticleSimulationSpace, ParticleSimulationSpace> _Mirror_SyncVarHookDelegate_simulationSpace;

		// Token: 0x04000B4B RID: 2891
		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_startRotation;

		// Token: 0x04000B4C RID: 2892
		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_angularVelocity;

		// Token: 0x04000B4D RID: 2893
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_autoplay;

		// Token: 0x04000B4E RID: 2894
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_loop;

		// Token: 0x04000B4F RID: 2895
		public Action<float, float> _Mirror_SyncVarHookDelegate_duration;

		// Token: 0x04000B50 RID: 2896
		public Action<ParticleShape, ParticleShape> _Mirror_SyncVarHookDelegate_shape;

		// Token: 0x04000B51 RID: 2897
		public Action<float, float> _Mirror_SyncVarHookDelegate_shapeRadius;

		// Token: 0x04000B52 RID: 2898
		public Action<float, float> _Mirror_SyncVarHookDelegate_shapeAngle;

		// Token: 0x04000B53 RID: 2899
		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_shapeScale;
	}
}
