namespace Polytoria.Controllers;

public class NPCAppearance : AppearanceLoaderBase
{
	private NPC npc; //Field offset: 0x158

	public NPCAppearance() { }

	protected virtual void Awake() { }

	public virtual void ClearAppearance() { }

	protected virtual void UpdateClothing() { }

	protected virtual void UpdateColors() { }

	public virtual bool Weaved() { }

}

