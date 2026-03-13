using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000075 RID: 117
	public interface ISceneGizmo
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000500 RID: 1280
		Gizmo OwnerGizmo { get; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000501 RID: 1281
		Camera SceneCamera { get; }
	}
}
