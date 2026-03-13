using System;
using System.Collections;
using System.Collections.Generic;
using Polytoria.Datamodel;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x0200033B RID: 827
	public class ToolboxController : MonoBehaviour
	{
		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x0001CD44 File Offset: 0x0001AF44
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x0001CD47 File Offset: 0x0001AF47
		public int Page
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x000262A8 File Offset: 0x000244A8
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x0001CD49 File Offset: 0x0001AF49
		public ToolboxController.ToolboxCategory Category
		{
			get
			{
				return ToolboxController.ToolboxCategory.RecentlyUpdated;
			}
			set
			{
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x0001CD4B File Offset: 0x0001AF4B
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x0001CD4E File Offset: 0x0001AF4E
		public string SearchQuery
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0001CD50 File Offset: 0x0001AF50
		private void Start()
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0001CD52 File Offset: 0x0001AF52
		public void SetSearchQuery(string q)
		{
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0001CD54 File Offset: 0x0001AF54
		public void ReloadToolbox()
		{
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0001CD56 File Offset: 0x0001AF56
		public void PageUp()
		{
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0001CD58 File Offset: 0x0001AF58
		public void PageDown()
		{
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0001CD5A File Offset: 0x0001AF5A
		private IEnumerator DoReloadToolbox()
		{
			return null;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0001CD5D File Offset: 0x0001AF5D
		private IEnumerator LoadThumbnail(JSONNode entry, RawImage image)
		{
			return null;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0001CD60 File Offset: 0x0001AF60
		public void InsertModel(int id)
		{
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0001CD62 File Offset: 0x0001AF62
		public void SetCategory(int c)
		{
		}

		// Token: 0x04000DFA RID: 3578
		private TMP_Dropdown categorySelector;

		// Token: 0x04000DFB RID: 3579
		private RectTransform toolboxContainer;

		// Token: 0x04000DFC RID: 3580
		private RectTransform entryPrefab;

		// Token: 0x04000DFD RID: 3581
		private TMP_Text pageLabel;

		// Token: 0x04000DFE RID: 3582
		private int page;

		// Token: 0x04000DFF RID: 3583
		private int pageLimit;

		// Token: 0x04000E00 RID: 3584
		private ToolboxController.ToolboxCategory cat;

		// Token: 0x04000E01 RID: 3585
		private string searchQuery;

		// Token: 0x0200042D RID: 1069
		public enum ToolboxCategory
		{
			// Token: 0x040011F5 RID: 4597
			RecentlyUpdated,
			// Token: 0x040011F6 RID: 4598
			UploadedModels
		}

		// Token: 0x0200042E RID: 1070
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002D0C RID: 11532 RVA: 0x0001DB39 File Offset: 0x0001BD39
			internal void <InsertModel>b__24_0(Instance i)
			{
			}

			// Token: 0x040011F7 RID: 4599
			public static readonly ToolboxController.<>c <>9;

			// Token: 0x040011F8 RID: 4600
			public static Action<Instance> <>9__24_0;
		}

		// Token: 0x0200042F RID: 1071
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06002D0E RID: 11534 RVA: 0x0001DB43 File Offset: 0x0001BD43
			internal void <DoReloadToolbox>b__0()
			{
			}

			// Token: 0x06002D0F RID: 11535 RVA: 0x0001DB45 File Offset: 0x0001BD45
			internal void <DoReloadToolbox>b__1()
			{
			}

			// Token: 0x06002D10 RID: 11536 RVA: 0x0001DB47 File Offset: 0x0001BD47
			internal void <DoReloadToolbox>b__2()
			{
			}

			// Token: 0x040011F9 RID: 4601
			public JSONNode entry;

			// Token: 0x040011FA RID: 4602
			public ToolboxController <>4__this;
		}

		// Token: 0x02000430 RID: 1072
		private sealed class <DoReloadToolbox>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D11 RID: 11537 RVA: 0x0001DB49 File Offset: 0x0001BD49
			public <DoReloadToolbox>d__22(int <>1__state)
			{
			}

			// Token: 0x06002D12 RID: 11538 RVA: 0x0001DB51 File Offset: 0x0001BD51
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D13 RID: 11539 RVA: 0x0001DB53 File Offset: 0x0001BD53
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D14 RID: 11540 RVA: 0x0001DB56 File Offset: 0x0001BD56
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x06002D15 RID: 11541 RVA: 0x0001DB58 File Offset: 0x0001BD58
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D16 RID: 11542 RVA: 0x0001DB5B File Offset: 0x0001BD5B
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D11 RID: 3345
			// (get) Token: 0x06002D17 RID: 11543 RVA: 0x0001DB5D File Offset: 0x0001BD5D
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011FB RID: 4603
			private int <>1__state;

			// Token: 0x040011FC RID: 4604
			private object <>2__current;

			// Token: 0x040011FD RID: 4605
			public ToolboxController <>4__this;

			// Token: 0x040011FE RID: 4606
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x02000431 RID: 1073
		private sealed class <LoadThumbnail>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D18 RID: 11544 RVA: 0x0001DB60 File Offset: 0x0001BD60
			public <LoadThumbnail>d__23(int <>1__state)
			{
			}

			// Token: 0x06002D19 RID: 11545 RVA: 0x0001DB68 File Offset: 0x0001BD68
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D1A RID: 11546 RVA: 0x0001DB6A File Offset: 0x0001BD6A
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D1B RID: 11547 RVA: 0x0001DB6D File Offset: 0x0001BD6D
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D12 RID: 3346
			// (get) Token: 0x06002D1C RID: 11548 RVA: 0x0001DB6F File Offset: 0x0001BD6F
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D1D RID: 11549 RVA: 0x0001DB72 File Offset: 0x0001BD72
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D13 RID: 3347
			// (get) Token: 0x06002D1E RID: 11550 RVA: 0x0001DB74 File Offset: 0x0001BD74
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011FF RID: 4607
			private int <>1__state;

			// Token: 0x04001200 RID: 4608
			private object <>2__current;

			// Token: 0x04001201 RID: 4609
			public JSONNode entry;

			// Token: 0x04001202 RID: 4610
			public RawImage image;

			// Token: 0x04001203 RID: 4611
			private UnityWebRequest <twr>5__2;
		}
	}
}
