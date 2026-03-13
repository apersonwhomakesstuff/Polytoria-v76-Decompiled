using System;

namespace RLD
{
	// Token: 0x02000066 RID: 102
	public interface IRTTransformGizmoListener
	{
		// Token: 0x0600041A RID: 1050
		bool OnCanBeTransformed(Gizmo transformGizmo);

		// Token: 0x0600041B RID: 1051
		void OnTransformed(Gizmo transformGizmo);
	}
}
