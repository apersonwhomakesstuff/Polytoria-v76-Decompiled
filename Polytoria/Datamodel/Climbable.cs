using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000273 RID: 627
	public class Climbable : Part
	{
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0001A7CC File Offset: 0x000189CC
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0001A7D3 File Offset: 0x000189D3
		public float ClimbSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0001A7D5 File Offset: 0x000189D5
		protected override void Start()
		{
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0001A7D7 File Offset: 0x000189D7
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0001A7E1 File Offset: 0x000189E1
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0001A7E4 File Offset: 0x000189E4
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0001A7EB File Offset: 0x000189EB
		public float NetworkclimbSpeed
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

		// Token: 0x06001B2F RID: 6959 RVA: 0x0001A7ED File Offset: 0x000189ED
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0001A7EF File Offset: 0x000189EF
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x040009E0 RID: 2528
		private float climbSpeed;
	}
}
