using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C8 RID: 712
	public class FilterService : MonoBehaviour
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x0001BE55 File Offset: 0x0001A055
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x0001BE5C File Offset: 0x0001A05C
		public static bool FailedToLoad
		{
			get
			{
				return FilterService.<FailedToLoad>k__BackingField;
			}
			private set
			{
				FilterService.<FailedToLoad>k__BackingField = value;
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0001BE64 File Offset: 0x0001A064
		private void Start()
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0001BE66 File Offset: 0x0001A066
		private IEnumerator LoadFilter()
		{
			return null;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0001BE69 File Offset: 0x0001A069
		private static void ParseFilters(string json)
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0001BE6B File Offset: 0x0001A06B
		private static Regex GetCompiledRegex(ProfanityFilterData filter)
		{
			return null;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0001BE6E File Offset: 0x0001A06E
		private static void RebuildHelpers()
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0001BE70 File Offset: 0x0001A070
		public static string Filter(string input)
		{
			return null;
		}

		// Token: 0x04000CE4 RID: 3300
		private static bool <FailedToLoad>k__BackingField;

		// Token: 0x04000CE5 RID: 3301
		private static List<ProfanityFilterData> filtersCache;

		// Token: 0x04000CE6 RID: 3302
		private static Dictionary<string, Regex> regexCache;

		// Token: 0x04000CE7 RID: 3303
		private static HashSet<string> literals;

		// Token: 0x04000CE8 RID: 3304
		private static Regex combinedRegex;

		// Token: 0x02000404 RID: 1028
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002C12 RID: 11282 RVA: 0x0001D7E2 File Offset: 0x0001B9E2
			internal string <Filter>b__13_0(Match match)
			{
				return null;
			}

			// Token: 0x06002C13 RID: 11283 RVA: 0x0001D7E5 File Offset: 0x0001B9E5
			internal string <Filter>b__13_1(Match match)
			{
				return null;
			}

			// Token: 0x040010FA RID: 4346
			public static readonly FilterService.<>c <>9;

			// Token: 0x040010FB RID: 4347
			public static MatchEvaluator <>9__13_0;

			// Token: 0x040010FC RID: 4348
			public static MatchEvaluator <>9__13_1;
		}

		// Token: 0x02000405 RID: 1029
		private sealed class <LoadFilter>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C14 RID: 11284 RVA: 0x0001D7E8 File Offset: 0x0001B9E8
			public <LoadFilter>d__9(int <>1__state)
			{
			}

			// Token: 0x06002C15 RID: 11285 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C16 RID: 11286 RVA: 0x0001D7F2 File Offset: 0x0001B9F2
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002C17 RID: 11287 RVA: 0x0001D7F5 File Offset: 0x0001B9F5
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CEC RID: 3308
			// (get) Token: 0x06002C18 RID: 11288 RVA: 0x0001D7F7 File Offset: 0x0001B9F7
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002C19 RID: 11289 RVA: 0x0001D7FA File Offset: 0x0001B9FA
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CED RID: 3309
			// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0001D7FC File Offset: 0x0001B9FC
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010FD RID: 4349
			private int <>1__state;

			// Token: 0x040010FE RID: 4350
			private object <>2__current;

			// Token: 0x040010FF RID: 4351
			private UnityWebRequest <uwr>5__2;
		}
	}
}
