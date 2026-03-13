using System;

namespace RLD
{
	// Token: 0x020000BC RID: 188
	public abstract class GizmoQuad2DBorderController : IGizmoQuad2DBorderController
	{
		// Token: 0x06000867 RID: 2151 RVA: 0x000173C8 File Offset: 0x000155C8
		public GizmoQuad2DBorderController(GizmoQuad2DBorderControllerData data)
		{
		}

		// Token: 0x06000868 RID: 2152
		public abstract void UpdateHandles();

		// Token: 0x06000869 RID: 2153
		public abstract void UpdateEpsilons();

		// Token: 0x0600086A RID: 2154
		public abstract void UpdateTransforms();

		// Token: 0x04000337 RID: 823
		protected GizmoQuad2DBorderControllerData _data;
	}
}
