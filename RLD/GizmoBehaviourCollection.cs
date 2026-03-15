namespace RLD;

public class GizmoBehaviourCollection : IEnumerable
{
	private List<IGizmoBehaviour> _behaviours; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 60
	}

	public GizmoBehaviourCollection() { }

	public bool Add(IGizmoBehaviour behaviour) { }

	public bool Contains(IGizmoBehaviour behaviour) { }

	public int get_Count() { }

	public List<Type> GetBehavioursOfType() { }

	public List<IGizmoBehaviour> GetBehavioursOfType(Type behaviourType) { }

	public IEnumerator<IGizmoBehaviour> GetEnumerator() { }

	public Type GetFirstBehaviourOfType() { }

	public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType) { }

	public bool Remove(IGizmoBehaviour behaviour) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

