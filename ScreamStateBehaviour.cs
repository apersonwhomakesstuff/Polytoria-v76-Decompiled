using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class ScreamStateBehaviour : StateMachineBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00015DA3 File Offset: 0x00013FA3
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00015DA5 File Offset: 0x00013FA5
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x04000001 RID: 1
	public Texture2D face;

	// Token: 0x04000002 RID: 2
	private Texture2D oldFace;
}
