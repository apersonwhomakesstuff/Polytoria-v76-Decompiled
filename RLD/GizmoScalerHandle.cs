namespace RLD;

public class GizmoScalerHandle
{
	private int _handleId; //Field offset: 0x10
	private List<Int32> _scaleDragAxisIndices; //Field offset: 0x18

	public int HandleId
	{
		 get { } //Length: 4
	}

	public List<Int32> ScaleDragAxisIndices
	{
		 get { } //Length: 104
	}

	public GizmoScalerHandle(int handleId, IEnumerable<Int32> scaleDragAxisIndices) { }

	public bool ContainsScaleDragAxisIndex(int scaleDragAxisIndex) { }

	public int get_HandleId() { }

	public List<Int32> get_ScaleDragAxisIndices() { }

}

