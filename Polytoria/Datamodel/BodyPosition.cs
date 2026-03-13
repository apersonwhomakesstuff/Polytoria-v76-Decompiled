using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200026F RID: 623
	public class BodyPosition : Instance
	{
		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x00024208 File Offset: 0x00022408
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0001A621 File Offset: 0x00018821
		public Vector3 TargetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0001A623 File Offset: 0x00018823
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0001A62A File Offset: 0x0001882A
		public float Force
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0001A62C File Offset: 0x0001882C
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0001A633 File Offset: 0x00018833
		public float AcceptanceDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0001A635 File Offset: 0x00018835
		protected override void Start()
		{
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0001A637 File Offset: 0x00018837
		private void FixedUpdate()
		{
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0001A639 File Offset: 0x00018839
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0001A643 File Offset: 0x00018843
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x00024220 File Offset: 0x00022420
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0001A646 File Offset: 0x00018846
		public Vector3 NetworktPos
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

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0001A648 File Offset: 0x00018848
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0001A64F File Offset: 0x0001884F
		public float Networkforce
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

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0001A651 File Offset: 0x00018851
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x0001A658 File Offset: 0x00018858
		public float NetworkaccDist
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

		// Token: 0x06001ACE RID: 6862 RVA: 0x0001A65A File Offset: 0x0001885A
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0001A65C File Offset: 0x0001885C
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x040009B0 RID: 2480
		private Vector3 tPos;

		// Token: 0x040009B1 RID: 2481
		private float force;

		// Token: 0x040009B2 RID: 2482
		private float accDist;
	}
}
