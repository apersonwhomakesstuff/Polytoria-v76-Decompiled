namespace Polytoria.Datamodel;

public interface IToolHolder
{

	public Transform ToolAttachmentPoint
	{
		 get { } //Length: 0
	}

	public Transform get_ToolAttachmentPoint() { }

	public void PlayAnim(string animationName) { }

	public void PlayAnimTargetRpc(string animationName) { }

}

