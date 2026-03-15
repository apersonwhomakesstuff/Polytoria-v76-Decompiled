namespace Polytoria.Datamodel;

public class SkyBase : Instance
{
	protected Material skyboxMaterial; //Field offset: 0xF8

	public SkyBase() { }

	protected override void Apply() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected virtual void Start() { }

	public virtual bool Weaved() { }

}

