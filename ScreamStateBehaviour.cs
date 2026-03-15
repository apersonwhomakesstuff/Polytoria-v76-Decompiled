//Type is in global namespace

public class ScreamStateBehaviour : StateMachineBehaviour
{
	public Texture2D face; //Field offset: 0x18
	private Texture2D oldFace; //Field offset: 0x20

	public ScreamStateBehaviour() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

