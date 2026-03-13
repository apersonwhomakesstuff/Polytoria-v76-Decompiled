using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x02000318 RID: 792
	public class PropertyGridItemColorRange : PropertyGridItem
	{
		// Token: 0x060027A1 RID: 10145 RVA: 0x0001C9C1 File Offset: 0x0001ABC1
		private void Awake()
		{
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0001C9C3 File Offset: 0x0001ABC3
		public override void SetProperty(PropertyInfo property)
		{
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0001C9C5 File Offset: 0x0001ABC5
		private void OnColorDisplayerBtnClickMin()
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x0001C9C7 File Offset: 0x0001ABC7
		private void OnColorDisplayerBtnClickMax()
		{
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x0001C9C9 File Offset: 0x0001ABC9
		private void OnValueChangeMin(Color color)
		{
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x0001C9CB File Offset: 0x0001ABCB
		private void OnValueChangeMax(Color color)
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0001C9CD File Offset: 0x0001ABCD
		private void OnDestroy()
		{
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x0001C9CF File Offset: 0x0001ABCF
		public override void SetValue(object value)
		{
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x0001C9D1 File Offset: 0x0001ABD1
		private void OnValueChanged(bool value)
		{
		}

		// Token: 0x04000D4D RID: 3405
		private ProceduralImage colorDisplayerMin;

		// Token: 0x04000D4E RID: 3406
		private ProceduralImage colorDisplayerMax;

		// Token: 0x04000D4F RID: 3407
		private Button colorDisplayerBtnMin;

		// Token: 0x04000D50 RID: 3408
		private Button colorDisplayerBtnMax;
	}
}
