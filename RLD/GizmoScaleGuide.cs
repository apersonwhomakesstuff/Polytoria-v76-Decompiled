using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000072 RID: 114
	public class GizmoScaleGuide
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0001697B File Offset: 0x00014B7B
		public GizmoScaleGuideLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0001697E File Offset: 0x00014B7E
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00016981 File Offset: 0x00014B81
		public GizmoScaleGuideLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00016983 File Offset: 0x00014B83
		public void Render(IEnumerable<GameObject> gameObjects, Camera camera)
		{
		}

		// Token: 0x04000195 RID: 405
		private GizmoScaleGuideLookAndFeel _lookAndFeel;

		// Token: 0x04000196 RID: 406
		private GizmoScaleGuideLookAndFeel _sharedLookAndFeel;
	}
}
