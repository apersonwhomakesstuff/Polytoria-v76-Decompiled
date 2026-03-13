using System;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

namespace Polytoria.Creator.PropertyGrid.Items
{
	// Token: 0x02000317 RID: 791
	public class PropertyGridItemColor : PropertyGridItem
	{
		// Token: 0x06002798 RID: 10136 RVA: 0x0001C9A9 File Offset: 0x0001ABA9
		private void Awake()
		{
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x0001C9AB File Offset: 0x0001ABAB
		public override void SetProperty(PropertyInfo property)
		{
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x0001C9AD File Offset: 0x0001ABAD
		private void OnColorDisplayerBtnClick()
		{
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0001C9AF File Offset: 0x0001ABAF
		private void OnValueChange(Color color)
		{
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x0001C9B1 File Offset: 0x0001ABB1
		private void OnHexInputValueChanged(string value)
		{
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x0001C9B3 File Offset: 0x0001ABB3
		private void OnDestroy()
		{
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x0001C9B5 File Offset: 0x0001ABB5
		public override void SetValue(object value)
		{
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x0001C9B7 File Offset: 0x0001ABB7
		private void OnValueChanged(bool value)
		{
		}

		// Token: 0x04000D4A RID: 3402
		private ProceduralImage colorDisplayer;

		// Token: 0x04000D4B RID: 3403
		private Button colorDisplayerBtn;

		// Token: 0x04000D4C RID: 3404
		private TMP_InputField hexInput;
	}
}
