namespace RLD;

public class ObjectDeselectEventArgs
{
	private ObjectDeselectReason _deselectReason; //Field offset: 0x10

	public ObjectDeselectReason DeselectReason
	{
		 get { } //Length: 4
	}

	public ObjectDeselectEventArgs(ObjectDeselectReason deselectReason) { }

	public ObjectDeselectReason get_DeselectReason() { }

}

