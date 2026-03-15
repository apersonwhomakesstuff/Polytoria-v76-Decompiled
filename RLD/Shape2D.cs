namespace RLD;

public abstract class Shape2D
{

	protected Shape2D() { }

	public abstract bool ContainsPoint(Vector2 point) { }

	public abstract Rect GetEncapsulatingRect() { }

	public abstract void RenderArea(Camera camera) { }

	public abstract void RenderBorder(Camera camera) { }

}

