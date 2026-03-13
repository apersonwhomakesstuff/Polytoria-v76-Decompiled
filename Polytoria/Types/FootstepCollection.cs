using System;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Types
{
	// Token: 0x0200025A RID: 602
	public class FootstepCollection : ScriptableObject
	{
		// Token: 0x06001A03 RID: 6659 RVA: 0x0001A402 File Offset: 0x00018602
		public FootstepSounds GetSounds(PartMaterial partMaterial)
		{
			return null;
		}

		// Token: 0x04000995 RID: 2453
		public FootstepSounds fallback;

		// Token: 0x04000996 RID: 2454
		public FootstepMaterial[] sounds;
	}
}
