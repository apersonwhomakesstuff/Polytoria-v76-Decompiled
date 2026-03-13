using System;
using System.Collections;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x02000046 RID: 70
	public class GizmoBehaviourCollection : IEnumerable
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00016486 File Offset: 0x00014686
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00016489 File Offset: 0x00014689
		public bool Add(IGizmoBehaviour behaviour)
		{
			return false;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001648C File Offset: 0x0001468C
		public bool Remove(IGizmoBehaviour behaviour)
		{
			return false;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001E624 File Offset: 0x0001C824
		public Type GetFirstBehaviourOfType<Type>() where Type : class, IGizmoBehaviour
		{
			return default(Type);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001648F File Offset: 0x0001468F
		public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType)
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00016492 File Offset: 0x00014692
		public List<Type> GetBehavioursOfType<Type>() where Type : class, IGizmoBehaviour
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00016495 File Offset: 0x00014695
		public List<IGizmoBehaviour> GetBehavioursOfType(Type behaviourType)
		{
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00016498 File Offset: 0x00014698
		public bool Contains(IGizmoBehaviour behaviour)
		{
			return false;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001649B File Offset: 0x0001469B
		public IEnumerator<IGizmoBehaviour> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001649E File Offset: 0x0001469E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400011B RID: 283
		private List<IGizmoBehaviour> _behaviours;
	}
}
