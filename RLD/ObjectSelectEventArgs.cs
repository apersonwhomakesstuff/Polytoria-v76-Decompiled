namespace RLD;

public class ObjectSelectEventArgs
{
	private ObjectSelectReason _selectReason; //Field offset: 0x10

	public ObjectSelectReason SelectReason
	{
		 get { } //Length: 4
	}

	public ObjectSelectEventArgs(ObjectSelectReason selectReason) { }

	public ObjectSelectReason get_SelectReason() { }

}

