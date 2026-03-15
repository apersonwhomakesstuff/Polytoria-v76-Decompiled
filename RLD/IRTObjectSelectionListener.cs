namespace RLD;

public interface IRTObjectSelectionListener
{

	public bool OnCanBeSelected(ObjectSelectEventArgs selectArgs) { }

	public void OnDeselected(ObjectDeselectEventArgs deselectArgs) { }

	public void OnSelected(ObjectSelectEventArgs selectArgs) { }

}

