namespace RLD;

public abstract class Shape3D
{

	protected Shape3D() { }

	public abstract AABB GetAABB() { }

	public bool Raycast(Ray ray) { }

	public abstract bool Raycast(Ray ray, out float t) { }

	public bool RaycastWire(Ray ray) { }

	public override bool RaycastWire(Ray ray, out float t) { }

	public abstract void RenderSolid() { }

	public abstract void RenderWire() { }

}

