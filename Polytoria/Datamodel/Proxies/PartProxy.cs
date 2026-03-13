using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EA RID: 746
	public class PartProxy : DynamicInstanceProxy
	{
		// Token: 0x060025A4 RID: 9636 RVA: 0x0001C3AE File Offset: 0x0001A5AE
		public PartProxy(Part target) : base(null)
		{
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x00025A80 File Offset: 0x00023C80
		// (set) Token: 0x060025A6 RID: 9638 RVA: 0x0001C3B7 File Offset: 0x0001A5B7
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x0001C3B9 File Offset: 0x0001A5B9
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x0001C3BC File Offset: 0x0001A5BC
		public bool Anchored
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x0001C3BE File Offset: 0x0001A5BE
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x0001C3C1 File Offset: 0x0001A5C1
		public bool CanCollide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x0001C3C3 File Offset: 0x0001A5C3
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x0001C3C6 File Offset: 0x0001A5C6
		public bool IsSpawn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x00025A98 File Offset: 0x00023C98
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
		public PartShape Shape
		{
			get
			{
				return PartShape.Brick;
			}
			set
			{
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x00025AB0 File Offset: 0x00023CB0
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x0001C3CA File Offset: 0x0001A5CA
		public PartMaterial Material
		{
			get
			{
				return PartMaterial.SmoothPlastic;
			}
			set
			{
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x00025AC8 File Offset: 0x00023CC8
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x0001C3CC File Offset: 0x0001A5CC
		public Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x0001C3CE File Offset: 0x0001A5CE
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x0001C3D5 File Offset: 0x0001A5D5
		public float Drag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0001C3D7 File Offset: 0x0001A5D7
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x0001C3DE File Offset: 0x0001A5DE
		public float AngularDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x0001C3E7 File Offset: 0x0001A5E7
		public float Mass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x00025AE0 File Offset: 0x00023CE0
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x0001C3E9 File Offset: 0x0001A5E9
		public Vector3 AngularVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0001C3EB File Offset: 0x0001A5EB
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x0001C3EE File Offset: 0x0001A5EE
		public bool UseGravity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x0001C3F0 File Offset: 0x0001A5F0
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x0001C3F7 File Offset: 0x0001A5F7
		public float Bounciness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x0001C3F9 File Offset: 0x0001A5F9
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x0001C400 File Offset: 0x0001A600
		public float Friction
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x0001C402 File Offset: 0x0001A602
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x0001C405 File Offset: 0x0001A605
		public bool CastShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0001C407 File Offset: 0x0001A607
		public void MovePosition(Vector3 pos)
		{
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0001C409 File Offset: 0x0001A609
		public void MoveRotation(Vector3 rot)
		{
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0001C40B File Offset: 0x0001A60B
		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0001C40D File Offset: 0x0001A60D
		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0001C40F File Offset: 0x0001A60F
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0001C411 File Offset: 0x0001A611
		public void AddRelativeForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x0001C413 File Offset: 0x0001A613
		public void AddRelativeTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}

		// Token: 0x04000D16 RID: 3350
		private readonly Part part;
	}
}
