using System;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AB RID: 683
	public class SkyBase : Instance
	{
		// Token: 0x06002109 RID: 8457 RVA: 0x0001B73E File Offset: 0x0001993E
		protected override void Start()
		{
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0001B740 File Offset: 0x00019940
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x0001B742 File Offset: 0x00019942
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0001B744 File Offset: 0x00019944
		protected virtual void Apply()
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0001B74E File Offset: 0x0001994E
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000BF1 RID: 3057
		protected Material skyboxMaterial;
	}
}
