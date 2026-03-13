using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000065 RID: 101
	public interface IGizmoHandle
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003EA RID: 1002
		int Id { get; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003EB RID: 1003
		Gizmo Gizmo { get; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003EC RID: 1004
		// (set) Token: 0x060003ED RID: 1005
		IGizmoDragSession DragSession { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003EE RID: 1006
		Priority GenericHoverPriority { get; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003EF RID: 1007
		Priority HoverPriority2D { get; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003F0 RID: 1008
		Priority HoverPriority3D { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003F1 RID: 1009
		int Num3DShapes { get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003F2 RID: 1010
		int Num2DShapes { get; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003F3 RID: 1011
		bool Has3DShapes { get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003F4 RID: 1012
		bool Has2DShapes { get; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003F5 RID: 1013
		// (set) Token: 0x060003F6 RID: 1014
		bool Is2DHoverable { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003F7 RID: 1015
		// (set) Token: 0x060003F8 RID: 1016
		bool Is3DHoverable { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003F9 RID: 1017
		// (set) Token: 0x060003FA RID: 1018
		bool Is2DVisible { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003FB RID: 1019
		// (set) Token: 0x060003FC RID: 1020
		bool Is3DVisible { get; set; }

		// Token: 0x060003FD RID: 1021
		float GetZoomFactor(Camera camera);

		// Token: 0x060003FE RID: 1022
		void SetZoomFactorTransform(GizmoTransform transform);

		// Token: 0x060003FF RID: 1023
		void SetHoverable(bool isHoverable);

		// Token: 0x06000400 RID: 1024
		void SetVisible(bool isVisible);

		// Token: 0x06000401 RID: 1025
		Shape3D Get3DShape(int shapeIndex);

		// Token: 0x06000402 RID: 1026
		Shape2D Get2DShape(int shapeIndex);

		// Token: 0x06000403 RID: 1027
		void SetAll3DShapesVisible(bool visible);

		// Token: 0x06000404 RID: 1028
		void Set3DShapeVisible(int shapeIndex, bool isVisible);

		// Token: 0x06000405 RID: 1029
		void Set3DShapeHoverable(int shapeIndex, bool isHoverable);

		// Token: 0x06000406 RID: 1030
		void SetAll2DShapesVisible(bool visible);

		// Token: 0x06000407 RID: 1031
		void Set2DShapeVisible(int shapeIndex, bool isVisible);

		// Token: 0x06000408 RID: 1032
		void Set2DShapeHoverable(int shapeIndex, bool isHoverable);

		// Token: 0x06000409 RID: 1033
		bool Is3DShapeVisible(int shapeIndex);

		// Token: 0x0600040A RID: 1034
		bool Is2DShapeVisible(int shapeIndex);

		// Token: 0x0600040B RID: 1035
		bool Contains3DShape(Shape3D shape);

		// Token: 0x0600040C RID: 1036
		bool Contains2DShape(Shape2D shape);

		// Token: 0x0600040D RID: 1037
		int Add3DShape(Shape3D shape);

		// Token: 0x0600040E RID: 1038
		int Add2DShape(Shape2D shape);

		// Token: 0x0600040F RID: 1039
		void Remove3DShape(Shape3D shape);

		// Token: 0x06000410 RID: 1040
		void Remove2DShape(Shape2D shape);

		// Token: 0x06000411 RID: 1041
		void Render3DSolid();

		// Token: 0x06000412 RID: 1042
		void Render3DWire();

		// Token: 0x06000413 RID: 1043
		void Render3DSolid(int shapeIndex);

		// Token: 0x06000414 RID: 1044
		void Render3DWire(int shapeIndex);

		// Token: 0x06000415 RID: 1045
		void Render2DSolid(Camera camera);

		// Token: 0x06000416 RID: 1046
		void Render2DWire(Camera camera);

		// Token: 0x06000417 RID: 1047
		void Render2DSolid(Camera camera, int shapeIndex);

		// Token: 0x06000418 RID: 1048
		void Render2DWire(Camera camera, int shapeIndex);

		// Token: 0x06000419 RID: 1049
		GizmoHandleHoverData GetHoverData(Ray hoverRay);
	}
}
