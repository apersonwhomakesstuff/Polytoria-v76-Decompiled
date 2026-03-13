using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DA RID: 474
	public class ConeShape2D : Shape2D
	{
		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0002237C File Offset: 0x0002057C
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x00019820 File Offset: 0x00017A20
		public Vector2 BaseCenter
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00022394 File Offset: 0x00020594
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x00019822 File Offset: 0x00017A22
		public Vector2 BaseLeft
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x000223AC File Offset: 0x000205AC
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x00019824 File Offset: 0x00017A24
		public Vector2 BaseRight
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x000223C4 File Offset: 0x000205C4
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x00019826 File Offset: 0x00017A26
		public Vector2 Tip
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x00019828 File Offset: 0x00017A28
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x0001982F File Offset: 0x00017A2F
		public float BaseRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x00019831 File Offset: 0x00017A31
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x00019838 File Offset: 0x00017A38
		public float Height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0001983A File Offset: 0x00017A3A
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x00019841 File Offset: 0x00017A41
		public float RotationDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x000223DC File Offset: 0x000205DC
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x000223F4 File Offset: 0x000205F4
		public Vector2 CentralAxis
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0002240C File Offset: 0x0002060C
		public Vector2 Right
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x00022424 File Offset: 0x00020624
		public Vector2 Up
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0002243C File Offset: 0x0002063C
		public static Vector2 ModelRight
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x00022454 File Offset: 0x00020654
		public static Vector2 ModelUp
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0002246C File Offset: 0x0002066C
		public static Vector2 ModelBaseCenter
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00019843 File Offset: 0x00017A43
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00019845 File Offset: 0x00017A45
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00019847 File Offset: 0x00017A47
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00022484 File Offset: 0x00020684
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x040007A2 RID: 1954
		private Vector2 _baseCenter;

		// Token: 0x040007A3 RID: 1955
		private float _rotationDegrees;

		// Token: 0x040007A4 RID: 1956
		private float _baseRadius;

		// Token: 0x040007A5 RID: 1957
		private float _height;
	}
}
