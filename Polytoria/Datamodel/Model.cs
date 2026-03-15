namespace Polytoria.Datamodel;

[Instantiatable]
public class Model : DynamicInstance
{

	public Model() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public virtual bool Weaved() { }

}

