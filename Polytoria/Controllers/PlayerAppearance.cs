namespace Polytoria.Controllers;

public class PlayerAppearance : AppearanceLoaderBase
{
	private Player player; //Field offset: 0x158

	public PlayerAppearance() { }

	protected virtual void Awake() { }

	public virtual void ClearAppearance() { }

	protected virtual void HatLoaded(GameObject hat) { }

	protected virtual void UpdateClothing() { }

	protected virtual void UpdateColors() { }

	public virtual bool Weaved() { }

}

