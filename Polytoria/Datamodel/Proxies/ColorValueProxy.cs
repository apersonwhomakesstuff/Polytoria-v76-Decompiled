using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D4 RID: 724
	public class ColorValueProxy : ValueBaseProxy
	{
		// Token: 0x06002480 RID: 9344 RVA: 0x0001C080 File Offset: 0x0001A280
		public ColorValueProxy(ColorValue target) : base(null)
		{
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x00025558 File Offset: 0x00023758
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0001C089 File Offset: 0x0001A289
		public Color Value
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x04000D00 RID: 3328
		private readonly ColorValue colorValue;
	}
}
