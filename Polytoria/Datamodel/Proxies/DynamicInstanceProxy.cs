using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D6 RID: 726
	public class DynamicInstanceProxy : InstanceProxy
	{
		// Token: 0x06002490 RID: 9360 RVA: 0x0001C0A6 File Offset: 0x0001A2A6
		public DynamicInstanceProxy(DynamicInstance target) : base(null)
		{
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000255D0 File Offset: 0x000237D0
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0001C0AF File Offset: 0x0001A2AF
		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x000255E8 File Offset: 0x000237E8
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0001C0B1 File Offset: 0x0001A2B1
		public Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x00025600 File Offset: 0x00023800
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0001C0B3 File Offset: 0x0001A2B3
		public Vector3 LocalPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x00025618 File Offset: 0x00023818
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0001C0B5 File Offset: 0x0001A2B5
		public Vector3 LocalRotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x00025630 File Offset: 0x00023830
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0001C0B7 File Offset: 0x0001A2B7
		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x00025648 File Offset: 0x00023848
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0001C0B9 File Offset: 0x0001A2B9
		public Vector3 LocalSize
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x00025660 File Offset: 0x00023860
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0001C0BB File Offset: 0x0001A2BB
		public Quaternion Quaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x00025678 File Offset: 0x00023878
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x0001C0BD File Offset: 0x0001A2BD
		public Quaternion LocalQuaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x00025690 File Offset: 0x00023890
		public Vector3 Forward
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000256A8 File Offset: 0x000238A8
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000256C0 File Offset: 0x000238C0
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0001C0BF File Offset: 0x0001A2BF
		public void LookAt(Vector3 lookTarget, Vector3 worldUp)
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0001C0C1 File Offset: 0x0001A2C1
		public void LookAt(Vector3 lookTarget)
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0001C0C3 File Offset: 0x0001A2C3
		public void LookAt(DynamicInstance dynamicInstance)
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0001C0C5 File Offset: 0x0001A2C5
		public void Translate(Vector3 translation)
		{
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0001C0C7 File Offset: 0x0001A2C7
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0001C0C9 File Offset: 0x0001A2C9
		public void Rotate(Vector3 eulerAngles)
		{
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000256D8 File Offset: 0x000238D8
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000256F0 File Offset: 0x000238F0
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00025708 File Offset: 0x00023908
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00025720 File Offset: 0x00023920
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00025738 File Offset: 0x00023938
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00025750 File Offset: 0x00023950
		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x04000D02 RID: 3330
		private readonly DynamicInstance dynamicInstance;
	}
}
