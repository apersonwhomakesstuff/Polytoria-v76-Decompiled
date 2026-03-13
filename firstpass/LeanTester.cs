using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class LeanTester : MonoBehaviour
{
	// Token: 0x06000036 RID: 54 RVA: 0x0000BD1C File Offset: 0x00009F1C
	public void Start()
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0000BD1E File Offset: 0x00009F1E
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	// Token: 0x04000015 RID: 21
	public float timeout;

	// Token: 0x02000168 RID: 360
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E72 RID: 3698 RVA: 0x0000F1C0 File Offset: 0x0000D3C0
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0000F1CA File Offset: 0x0000D3CA
		bool IEnumerator.MoveNext()
		{
			return false;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0000F1CD File Offset: 0x0000D3CD
		object IEnumerator<object>.Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		void IEnumerator.Reset()
		{
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0000F1D2 File Offset: 0x0000D3D2
		object IEnumerator.Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040005F3 RID: 1523
		private int <>1__state;

		// Token: 0x040005F4 RID: 1524
		private object <>2__current;

		// Token: 0x040005F5 RID: 1525
		public LeanTester <>4__this;

		// Token: 0x040005F6 RID: 1526
		private float <pauseEndTime>5__2;
	}
}
