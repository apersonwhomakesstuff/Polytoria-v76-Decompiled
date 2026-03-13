using System;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000288 RID: 648
	public interface IToolHolder
	{
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001D00 RID: 7424
		Transform ToolAttachmentPoint { get; }

		// Token: 0x06001D01 RID: 7425
		void PlayAnim(string animationName);

		// Token: 0x06001D02 RID: 7426
		void PlayAnimTargetRpc(string animationName);
	}
}
