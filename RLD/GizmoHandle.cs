using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200005F RID: 95
	public class GizmoHandle : IGizmoHandle
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0001657E File Offset: 0x0001477E
		public int Id
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00016581 File Offset: 0x00014781
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00016584 File Offset: 0x00014784
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0001658C File Offset: 0x0001478C
		public IGizmoDragSession DragSession
		{
			get
			{
				return this.<DragSession>k__BackingField;
			}
			set
			{
				this.<DragSession>k__BackingField = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00016595 File Offset: 0x00014795
		public Priority GenericHoverPriority
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00016598 File Offset: 0x00014798
		public Priority HoverPriority2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0001659B File Offset: 0x0001479B
		public Priority HoverPriority3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0001659E File Offset: 0x0001479E
		public int Num3DShapes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000165A1 File Offset: 0x000147A1
		public int Num2DShapes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000165A4 File Offset: 0x000147A4
		public bool Has3DShapes
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000165A7 File Offset: 0x000147A7
		public bool Has2DShapes
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000165AA File Offset: 0x000147AA
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000165B2 File Offset: 0x000147B2
		public bool Is2DHoverable
		{
			get
			{
				return this.<Is2DHoverable>k__BackingField;
			}
			set
			{
				this.<Is2DHoverable>k__BackingField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000165BB File Offset: 0x000147BB
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000165C3 File Offset: 0x000147C3
		public bool Is3DHoverable
		{
			get
			{
				return this.<Is3DHoverable>k__BackingField;
			}
			set
			{
				this.<Is3DHoverable>k__BackingField = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000165CC File Offset: 0x000147CC
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000165D4 File Offset: 0x000147D4
		public bool Is2DVisible
		{
			get
			{
				return this.<Is2DVisible>k__BackingField;
			}
			set
			{
				this.<Is2DVisible>k__BackingField = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000165DD File Offset: 0x000147DD
		// (set) Token: 0x0600036D RID: 877 RVA: 0x000165E5 File Offset: 0x000147E5
		public bool Is3DVisible
		{
			get
			{
				return this.<Is3DVisible>k__BackingField;
			}
			set
			{
				this.<Is3DVisible>k__BackingField = value;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000165EE File Offset: 0x000147EE
		public GizmoHandle(Gizmo gizmo, int id)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000165F6 File Offset: 0x000147F6
		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000165FD File Offset: 0x000147FD
		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000165FF File Offset: 0x000147FF
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00016601 File Offset: 0x00014801
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00016603 File Offset: 0x00014803
		public Shape3D Get3DShape(int shapeIndex)
		{
			return null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00016606 File Offset: 0x00014806
		public Shape2D Get2DShape(int shapeIndex)
		{
			return null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00016609 File Offset: 0x00014809
		public void SetAll3DShapesVisible(bool visible)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001660B File Offset: 0x0001480B
		public void Set3DShapeVisible(int shapeIndex, bool isVisible)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0001660D File Offset: 0x0001480D
		public bool Is3DShapeVisible(int shapeIndex)
		{
			return false;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00016610 File Offset: 0x00014810
		public void Set3DShapeHoverable(int shapeIndex, bool isHoverable)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00016612 File Offset: 0x00014812
		public void SetAll2DShapesVisible(bool visible)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00016614 File Offset: 0x00014814
		public void Set2DShapeVisible(int shapeIndex, bool isVisible)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00016616 File Offset: 0x00014816
		public bool Is2DShapeVisible(int shapeIndex)
		{
			return false;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00016619 File Offset: 0x00014819
		public void Set2DShapeHoverable(int shapeIndex, bool isHoverable)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001661B File Offset: 0x0001481B
		public bool Contains3DShape(Shape3D shape)
		{
			return false;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0001661E File Offset: 0x0001481E
		public bool Contains2DShape(Shape2D shape)
		{
			return false;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00016621 File Offset: 0x00014821
		public int Add3DShape(Shape3D shape)
		{
			return 0;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00016624 File Offset: 0x00014824
		public int Add2DShape(Shape2D shape)
		{
			return 0;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00016627 File Offset: 0x00014827
		public void Remove3DShape(Shape3D shape)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00016629 File Offset: 0x00014829
		public void Remove2DShape(Shape2D shape)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0001662B File Offset: 0x0001482B
		public void Render3DSolid()
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001662D File Offset: 0x0001482D
		public void Render3DWire()
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0001662F File Offset: 0x0001482F
		public void Render3DSolid(int shapeIndex)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00016631 File Offset: 0x00014831
		public void Render3DWire(int shapeIndex)
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00016633 File Offset: 0x00014833
		public void Render2DSolid(Camera camera)
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00016635 File Offset: 0x00014835
		public void Render2DWire(Camera camera)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00016637 File Offset: 0x00014837
		public void Render2DSolid(Camera camera, int shapeIndex)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00016639 File Offset: 0x00014839
		public void Render2DWire(Camera camera, int shapeIndex)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0001663B File Offset: 0x0001483B
		public GizmoHandleHoverData GetHoverData(Ray hoverRay)
		{
			return null;
		}

		// Token: 0x04000144 RID: 324
		public GizmoHandleCanHoverHandler CanHover;

		// Token: 0x04000145 RID: 325
		private int _id;

		// Token: 0x04000146 RID: 326
		private Gizmo _gizmo;

		// Token: 0x04000147 RID: 327
		private GizmoTransform _zoomFactorTransform;

		// Token: 0x04000148 RID: 328
		private Priority _genericHoverPriority;

		// Token: 0x04000149 RID: 329
		private Priority _hoverPriority2D;

		// Token: 0x0400014A RID: 330
		private Priority _hoverPriority3D;

		// Token: 0x0400014B RID: 331
		private List<GizmoHandleShape3D> _3DShapes;

		// Token: 0x0400014C RID: 332
		private List<GizmoHandleShape2D> _2DShapes;

		// Token: 0x0400014D RID: 333
		private IGizmoDragSession <DragSession>k__BackingField;

		// Token: 0x0400014E RID: 334
		private bool <Is2DHoverable>k__BackingField;

		// Token: 0x0400014F RID: 335
		private bool <Is3DHoverable>k__BackingField;

		// Token: 0x04000150 RID: 336
		private bool <Is2DVisible>k__BackingField;

		// Token: 0x04000151 RID: 337
		private bool <Is3DVisible>k__BackingField;

		// Token: 0x0200035A RID: 858
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x06002A30 RID: 10800 RVA: 0x0001D13E File Offset: 0x0001B33E
			internal bool <Contains3DShape>b__0(GizmoHandleShape3D item)
			{
				return false;
			}

			// Token: 0x04000ECA RID: 3786
			public Shape3D shape;
		}

		// Token: 0x0200035B RID: 859
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x06002A32 RID: 10802 RVA: 0x0001D149 File Offset: 0x0001B349
			internal bool <Contains2DShape>b__0(GizmoHandleShape2D item)
			{
				return false;
			}

			// Token: 0x04000ECB RID: 3787
			public Shape2D shape;
		}

		// Token: 0x0200035C RID: 860
		private sealed class <>c__DisplayClass66_0
		{
			// Token: 0x06002A34 RID: 10804 RVA: 0x0001D154 File Offset: 0x0001B354
			internal bool <Remove3DShape>b__0(GizmoHandleShape3D item)
			{
				return false;
			}

			// Token: 0x04000ECC RID: 3788
			public Shape3D shape;
		}

		// Token: 0x0200035D RID: 861
		private sealed class <>c__DisplayClass67_0
		{
			// Token: 0x06002A36 RID: 10806 RVA: 0x0001D15F File Offset: 0x0001B35F
			internal bool <Remove2DShape>b__0(GizmoHandleShape2D item)
			{
				return false;
			}

			// Token: 0x04000ECD RID: 3789
			public Shape2D shape;
		}
	}
}
