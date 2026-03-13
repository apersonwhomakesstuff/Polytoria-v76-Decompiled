using System;
using UnityEngine;
using UnityEngine.UI;

namespace namudev
{
	// Token: 0x02000242 RID: 578
	public class PropertyGridColor : PropertyGridItem<Color>
	{
		// Token: 0x06001976 RID: 6518 RVA: 0x0001A260 File Offset: 0x00018460
		protected override void Awake()
		{
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0001A262 File Offset: 0x00018462
		private void OnDestroy()
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0001A264 File Offset: 0x00018464
		private void Start()
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0001A266 File Offset: 0x00018466
		private void OnColorBtnClick()
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0001A268 File Offset: 0x00018468
		private void OnValueChange(Color color)
		{
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0001A26A File Offset: 0x0001846A
		private void OnValueChangeHex(string hexColor)
		{
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0001A26C File Offset: 0x0001846C
		private void OnEndEditHex(string str)
		{
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0001A26E File Offset: 0x0001846E
		private void OnValueChangeR(string str)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0001A270 File Offset: 0x00018470
		private void OnEndEditR(string str)
		{
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0001A272 File Offset: 0x00018472
		private void OnValueChangeG(string str)
		{
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0001A274 File Offset: 0x00018474
		private void OnEndEditG(string str)
		{
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0001A276 File Offset: 0x00018476
		private void OnValueChangeB(string str)
		{
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0001A278 File Offset: 0x00018478
		private void OnEndEditB(string str)
		{
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0001A27A File Offset: 0x0001847A
		private void OnValueChangeA(string str)
		{
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0001A27C File Offset: 0x0001847C
		private void OnEndEditA(string str)
		{
		}

		// Token: 0x04000925 RID: 2341
		private GameObject caption;

		// Token: 0x04000926 RID: 2342
		private GameObject inputFieldR;

		// Token: 0x04000927 RID: 2343
		private GameObject inputFieldG;

		// Token: 0x04000928 RID: 2344
		private GameObject inputFieldB;

		// Token: 0x04000929 RID: 2345
		private GameObject inputFieldA;

		// Token: 0x0400092A RID: 2346
		private GameObject inputFieldHex;

		// Token: 0x0400092B RID: 2347
		private Image colorDisplayer;

		// Token: 0x0400092C RID: 2348
		private Button colorDisplayerBtn;
	}
}
