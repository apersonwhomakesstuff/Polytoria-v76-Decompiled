using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002C0 RID: 704
	public class Vector3Value : ValueBase
	{
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000253C0 File Offset: 0x000235C0
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x0001BD4B File Offset: 0x00019F4B
		public Vector3 Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x0001BD4D File Offset: 0x00019F4D
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0001BD4F File Offset: 0x00019F4F
		private void OnValueChanged(Vector3 oldValue, Vector3 newValue)
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0001BD59 File Offset: 0x00019F59
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000253D8 File Offset: 0x000235D8
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x0001BD5C File Offset: 0x00019F5C
		public Vector3 Networkval
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

		// Token: 0x0600238F RID: 9103 RVA: 0x0001BD5E File Offset: 0x00019F5E
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0001BD60 File Offset: 0x00019F60
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000CBB RID: 3259
		private Vector3 val;

		// Token: 0x04000CBC RID: 3260
		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_val;
	}
}
