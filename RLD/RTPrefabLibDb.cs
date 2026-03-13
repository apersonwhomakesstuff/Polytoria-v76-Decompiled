using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200019F RID: 415
	[Serializable]
	public class RTPrefabLibDb : MonoSingleton<RTPrefabLibDb>
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06001241 RID: 4673 RVA: 0x00019073 File Offset: 0x00017273
		// (remove) Token: 0x06001242 RID: 4674 RVA: 0x00019075 File Offset: 0x00017275
		public event PrefabLibDbPrefabSpawnedHander PrefabSpawned
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00019077 File Offset: 0x00017277
		public int NumLibs
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0001907A File Offset: 0x0001727A
		public int ActiveLibIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x0001907D File Offset: 0x0001727D
		public RTPrefabLib ActiveLib
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00019080 File Offset: 0x00017280
		public PrefabPreviewLookAndFeel PrefabPreviewLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00019083 File Offset: 0x00017283
		public RTPrefabLibDbUI RuntimeUI
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00019086 File Offset: 0x00017286
		public bool HasRuntimeUI
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00019089 File Offset: 0x00017289
		public PrefabLibDbSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x0001908C File Offset: 0x0001728C
		public EditorPrefabPreviewGen EditorPrefabPreviewGen
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0001908F File Offset: 0x0001728F
		public RTPrefabLib CreateLib(string libName)
		{
			return null;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00019092 File Offset: 0x00017292
		public void SortLibsByName()
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00019094 File Offset: 0x00017294
		public bool SetLibName(RTPrefabLib lib, string newLibName)
		{
			return false;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00019097 File Offset: 0x00017297
		public void SetActiveLib(int libIndex)
		{
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00019099 File Offset: 0x00017299
		public void SetActiveLib(RTPrefabLib lib)
		{
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0001909B File Offset: 0x0001729B
		public void SetActiveLib(string libName)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0001909D File Offset: 0x0001729D
		public void Clear()
		{
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0001909F File Offset: 0x0001729F
		public void Remove(int libIndex)
		{
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000190A1 File Offset: 0x000172A1
		public void Remove(string libName)
		{
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000190A3 File Offset: 0x000172A3
		public void Remove(RTPrefabLib lib)
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000190A5 File Offset: 0x000172A5
		public void Remove(List<RTPrefabLib> libs)
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000190A7 File Offset: 0x000172A7
		public List<RTPrefabLib> GetEmptyLibs()
		{
			return null;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000190AA File Offset: 0x000172AA
		public void RemoveEmptyLibs()
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000190AC File Offset: 0x000172AC
		public bool Contains(string libName)
		{
			return false;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000190AF File Offset: 0x000172AF
		public bool Contains(RTPrefabLib lib)
		{
			return false;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000190B2 File Offset: 0x000172B2
		public List<string> GetAllLibNames()
		{
			return null;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000190B5 File Offset: 0x000172B5
		public int GetLibIndex(string libName)
		{
			return 0;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000190B8 File Offset: 0x000172B8
		public int GetLibIndex(RTPrefabLib lib)
		{
			return 0;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000190BB File Offset: 0x000172BB
		public RTPrefabLib GetLib(int libIndex)
		{
			return null;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000190BE File Offset: 0x000172BE
		public RTPrefabLib GetLib(string libName)
		{
			return null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000190C1 File Offset: 0x000172C1
		private void Start()
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000190C3 File Offset: 0x000172C3
		private void OnActiveLibDropDownChanged()
		{
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000190C5 File Offset: 0x000172C5
		private void OnPrefabCreatedInLib(RTPrefabLib prefabLib, RTPrefab prefab)
		{
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000190C7 File Offset: 0x000172C7
		private void OnPrefabRemovedFromLib(RTPrefabLib prefabLib, RTPrefab prefab)
		{
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000190C9 File Offset: 0x000172C9
		private void OnPrefabLibCleared(RTPrefabLib prefabLib)
		{
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000190CB File Offset: 0x000172CB
		private void OnPrefabPreviewButtonClicked(RTPrefab prefab)
		{
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000190D5 File Offset: 0x000172D5
		private void <Start>b__48_0(int <p0>)
		{
		}

		// Token: 0x04000674 RID: 1652
		private string _newLibName;

		// Token: 0x04000675 RID: 1653
		private Vector2 _prefabScrollPos;

		// Token: 0x04000676 RID: 1654
		private int _numPrefabsPerRow;

		// Token: 0x04000678 RID: 1656
		[NonSerialized]
		private EditorPrefabPreviewGen _editorPrefabPreviewGen;

		// Token: 0x04000679 RID: 1657
		private PrefabLibDbSettings _settings;

		// Token: 0x0400067A RID: 1658
		private RTPrefabLibDbUI _runtimeUI;

		// Token: 0x0400067B RID: 1659
		private PrefabPreviewLookAndFeel _prefabPreviewLookAndFeel;

		// Token: 0x0400067C RID: 1660
		private int _activeLibIndex;

		// Token: 0x0400067D RID: 1661
		private List<RTPrefabLib> _libs;

		// Token: 0x02000396 RID: 918
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002AC6 RID: 10950 RVA: 0x0001D36F File Offset: 0x0001B56F
			internal int <SortLibsByName>b__29_0(RTPrefabLib l0, RTPrefabLib l1)
			{
				return 0;
			}

			// Token: 0x04000F79 RID: 3961
			public static readonly RTPrefabLibDb.<>c <>9;

			// Token: 0x04000F7A RID: 3962
			public static Comparison<RTPrefabLib> <>9__29_0;
		}

		// Token: 0x02000397 RID: 919
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06002AC8 RID: 10952 RVA: 0x0001D37A File Offset: 0x0001B57A
			internal bool <GetLibIndex>b__0(RTPrefabLib item)
			{
				return false;
			}

			// Token: 0x04000F7B RID: 3963
			public string libName;
		}

		// Token: 0x02000398 RID: 920
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x06002ACA RID: 10954 RVA: 0x0001D385 File Offset: 0x0001B585
			internal bool <GetLib>b__0(RTPrefabLib item)
			{
				return false;
			}

			// Token: 0x04000F7C RID: 3964
			public string libName;
		}
	}
}
