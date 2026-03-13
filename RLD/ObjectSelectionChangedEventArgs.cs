using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000226 RID: 550
	public class ObjectSelectionChangedEventArgs
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00023B1C File Offset: 0x00021D1C
		public ObjectSelectReason SelectReason
		{
			get
			{
				return ObjectSelectReason.None;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00019FE7 File Offset: 0x000181E7
		public int NumObjectsSelected
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00019FEA File Offset: 0x000181EA
		public List<GameObject> ObjectsWhichWereSelected
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00023B34 File Offset: 0x00021D34
		public ObjectDeselectReason DeselectReason
		{
			get
			{
				return ObjectDeselectReason.None;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00019FED File Offset: 0x000181ED
		public int NumObjectsDeselected
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00019FF0 File Offset: 0x000181F0
		public List<GameObject> ObjectsWhichWereDeselected
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00019FF3 File Offset: 0x000181F3
		public ObjectSelectionSnapshot UndoRedoSnapshot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00019FF6 File Offset: 0x000181F6
		public ObjectSelectionChangedEventArgs(ObjectSelectReason selectReason, List<GameObject> objectsWhichWereSelected, ObjectDeselectReason deselectReason, List<GameObject> objectsWhichWereDeselected, ObjectSelectionSnapshot undoRedoSnapshot = null)
		{
		}

		// Token: 0x040008AE RID: 2222
		private ObjectSelectReason _selectReason;

		// Token: 0x040008AF RID: 2223
		private List<GameObject> _objectsWhichWereSelected;

		// Token: 0x040008B0 RID: 2224
		private ObjectDeselectReason _deselectReason;

		// Token: 0x040008B1 RID: 2225
		private List<GameObject> _objectsWhichWereDeselected;

		// Token: 0x040008B2 RID: 2226
		private ObjectSelectionSnapshot _undoRedoSnapshot;
	}
}
