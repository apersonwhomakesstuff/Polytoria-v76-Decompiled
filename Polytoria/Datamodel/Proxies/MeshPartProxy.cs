namespace Polytoria.Datamodel.Proxies;

public class MeshPartProxy : PartProxy
{
	private readonly MeshPart meshPart; //Field offset: 0x28

	public int AssetID
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public CollisionType CollisionType
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public string CurrentAnimation
	{
		 get { } //Length: 29
	}

	public bool IsAnimationPlaying
	{
		 get { } //Length: 29
	}

	public bool PlayAnimationOnStart
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public MeshPartProxy(MeshPart target) { }

	public int get_AssetID() { }

	public CollisionType get_CollisionType() { }

	public string get_CurrentAnimation() { }

	public bool get_IsAnimationPlaying() { }

	public bool get_PlayAnimationOnStart() { }

	public AnimationInfo[] GetAnimationInfo() { }

	public String[] GetAnimations() { }

	public String[] GetAnimationSources(string animationName) { }

	public void PlayAnimation(string animationName, string objectPath, float speed = 1, bool loop = true) { }

	public void set_AssetID(int value) { }

	public void set_CollisionType(CollisionType value) { }

	public void set_PlayAnimationOnStart(bool value) { }

	public void StopAnimation(string name = null) { }

}

