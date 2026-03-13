using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000321 RID: 801
	public class AbuseReportController : MonoBehaviour
	{
		// Token: 0x060027CA RID: 10186 RVA: 0x0001CA49 File Offset: 0x0001AC49
		public void Submit()
		{
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x0001CA4B File Offset: 0x0001AC4B
		public void Return()
		{
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0001CA4D File Offset: 0x0001AC4D
		public void Cancel()
		{
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0001CA4F File Offset: 0x0001AC4F
		private IEnumerator SubmitAbuseReport(string message)
		{
			return null;
		}

		// Token: 0x04000D5C RID: 3420
		private TMP_InputField input;

		// Token: 0x04000D5D RID: 3421
		private RectTransform defaultPanel;

		// Token: 0x04000D5E RID: 3422
		private RectTransform finishedPanel;

		// Token: 0x02000414 RID: 1044
		private sealed class <SubmitAbuseReport>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C91 RID: 11409 RVA: 0x0001D98F File Offset: 0x0001BB8F
			public <SubmitAbuseReport>d__6(int <>1__state)
			{
			}

			// Token: 0x06002C92 RID: 11410 RVA: 0x0001D997 File Offset: 0x0001BB97
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C93 RID: 11411 RVA: 0x0001D999 File Offset: 0x0001BB99
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002C94 RID: 11412 RVA: 0x0001D99C File Offset: 0x0001BB9C
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CF4 RID: 3316
			// (get) Token: 0x06002C95 RID: 11413 RVA: 0x0001D99E File Offset: 0x0001BB9E
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002C96 RID: 11414 RVA: 0x0001D9A1 File Offset: 0x0001BBA1
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CF5 RID: 3317
			// (get) Token: 0x06002C97 RID: 11415 RVA: 0x0001D9A3 File Offset: 0x0001BBA3
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001179 RID: 4473
			private int <>1__state;

			// Token: 0x0400117A RID: 4474
			private object <>2__current;

			// Token: 0x0400117B RID: 4475
			public string message;

			// Token: 0x0400117C RID: 4476
			private UnityWebRequest <uwr>5__2;
		}
	}
}
