using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000122 RID: 290
	public static class GUIEx
	{
		// Token: 0x06000F5C RID: 3932 RVA: 0x0001881B File Offset: 0x00016A1B
		public static void PushColor(Color color)
		{
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0001881D File Offset: 0x00016A1D
		public static void PopColor()
		{
		}

		// Token: 0x04000564 RID: 1380
		private static Stack<Color> _colorStack;
	}
}
