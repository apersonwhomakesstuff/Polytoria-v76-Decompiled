using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000071 RID: 113
	public class RTGizmosEngine : MonoSingleton<RTGizmosEngine>, IHoverableSceneEntityContainer
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060004C2 RID: 1218 RVA: 0x00016908 File Offset: 0x00014B08
		// (remove) Token: 0x060004C3 RID: 1219 RVA: 0x0001690A File Offset: 0x00014B0A
		public event GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001690C File Offset: 0x00014B0C
		public GizmoEngineSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0001E984 File Offset: 0x0001CB84
		public GizmosEnginePipelineStage PipelineStage
		{
			get
			{
				return GizmosEnginePipelineStage.Update;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001690F File Offset: 0x00014B0F
		public Camera RenderStageCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00016912 File Offset: 0x00014B12
		public bool HasHoveredSceneEntity
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00016915 File Offset: 0x00014B15
		public bool IsAnyGizmoHovered
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00016918 File Offset: 0x00014B18
		public Gizmo HoveredGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0001691B File Offset: 0x00014B1B
		public Gizmo DraggedGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001691E File Offset: 0x00014B1E
		public bool JustReleasedDrag
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00016921 File Offset: 0x00014B21
		public int NumRenderCameras
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00016924 File Offset: 0x00014B24
		public SceneGizmoLookAndFeel SharedSceneGizmoLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00016927 File Offset: 0x00014B27
		public void AddRenderCamera(Camera camera)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00016929 File Offset: 0x00014B29
		public bool IsRenderCamera(Camera camera)
		{
			return false;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001692C File Offset: 0x00014B2C
		public void RemoveRenderCamera(Camera camera)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0001692E File Offset: 0x00014B2E
		public RTSceneGizmoCamera CreateSceneGizmoCamera(Camera sceneCamera, ISceneGizmoCamViewportUpdater viewportUpdater)
		{
			return null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00016931 File Offset: 0x00014B31
		public bool IsSceneGizmoCamera(Camera camera)
		{
			return false;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00016934 File Offset: 0x00014B34
		public ISceneGizmo GetSceneGizmoByCamera(Camera sceneCamera)
		{
			return null;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00016937 File Offset: 0x00014B37
		public Gizmo CreateGizmo()
		{
			return null;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0001693A File Offset: 0x00014B3A
		public void RemoveGizmo(Gizmo gizmo)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0001693C File Offset: 0x00014B3C
		public SceneGizmo CreateSceneGizmo(Camera sceneCamera)
		{
			return null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0001693F File Offset: 0x00014B3F
		public MoveGizmo CreateMoveGizmo()
		{
			return null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00016942 File Offset: 0x00014B42
		public ObjectTransformGizmo CreateObjectMoveGizmo()
		{
			return null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00016945 File Offset: 0x00014B45
		public RotationGizmo CreateRotationGizmo()
		{
			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00016948 File Offset: 0x00014B48
		public ObjectTransformGizmo CreateObjectRotationGizmo()
		{
			return null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0001694B File Offset: 0x00014B4B
		public ScaleGizmo CreateScaleGizmo()
		{
			return null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0001694E File Offset: 0x00014B4E
		public ObjectTransformGizmo CreateObjectScaleGizmo()
		{
			return null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00016951 File Offset: 0x00014B51
		public UniversalGizmo CreateUniversalGizmo()
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00016954 File Offset: 0x00014B54
		public ObjectTransformGizmo CreateObjectUniversalGizmo()
		{
			return null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00016957 File Offset: 0x00014B57
		public BoxGizmo CreateBoxGizmo()
		{
			return null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001695A File Offset: 0x00014B5A
		public BoxGizmo CreateObjectBoxScaleGizmo()
		{
			return null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001695D File Offset: 0x00014B5D
		public ObjectExtrudeGizmo CreateObjectExtrudeGizmo()
		{
			return null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00016960 File Offset: 0x00014B60
		public void Update_SystemCall()
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00016962 File Offset: 0x00014B62
		public GizmoHandleHoverData GetGizmoHandleHoverData(Gizmo gizmo)
		{
			return null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00016965 File Offset: 0x00014B65
		public void Render_SystemCall(Camera renderCamera)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00016967 File Offset: 0x00014B67
		private void SortHandleHoverDataCollection(List<GizmoHandleHoverData> hoverDataCollection, Vector3 inputDevicePos)
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00016969 File Offset: 0x00014B69
		private void RegisterGizmo(Gizmo gizmo)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001696B File Offset: 0x00014B6B
		private void UnregisterGizmo(Gizmo gizmo)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001696D File Offset: 0x00014B6D
		private void OnGUI()
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001696F File Offset: 0x00014B6F
		private void OnGizmoDragBegin(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00016971 File Offset: 0x00014B71
		private void OnGizmoDragEnd(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x04000189 RID: 393
		private EditorToolbar _mainToolbar;

		// Token: 0x0400018A RID: 394
		private GizmoEngineSettings _settings;

		// Token: 0x0400018B RID: 395
		private GizmosEnginePipelineStage _pipelineStage;

		// Token: 0x0400018C RID: 396
		private Gizmo _draggedGizmo;

		// Token: 0x0400018D RID: 397
		private bool _justReleasedDrag;

		// Token: 0x0400018E RID: 398
		private Gizmo _hoveredGizmo;

		// Token: 0x0400018F RID: 399
		private GizmoHoverInfo _gizmoHoverInfo;

		// Token: 0x04000190 RID: 400
		private List<Gizmo> _gizmos;

		// Token: 0x04000191 RID: 401
		private List<ISceneGizmo> _sceneGizmos;

		// Token: 0x04000192 RID: 402
		private List<RTSceneGizmoCamera> _sceneGizmoCameras;

		// Token: 0x04000193 RID: 403
		private List<Camera> _renderCameras;

		// Token: 0x04000194 RID: 404
		private SceneGizmoLookAndFeel _sharedSceneGizmoLookAndFeel;

		// Token: 0x02000361 RID: 865
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x06002A3B RID: 10811 RVA: 0x0001D177 File Offset: 0x0001B377
			internal int <GetGizmoHandleHoverData>b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1)
			{
				return 0;
			}

			// Token: 0x04000ED7 RID: 3799
			public Gizmo gizmo;

			// Token: 0x04000ED8 RID: 3800
			public Vector3 screenRayOrigin;
		}

		// Token: 0x02000362 RID: 866
		private sealed class <>c__DisplayClass57_0
		{
			// Token: 0x06002A3D RID: 10813 RVA: 0x0001D182 File Offset: 0x0001B382
			internal int <Render_SystemCall>b__0(Gizmo g0, Gizmo g1)
			{
				return 0;
			}

			// Token: 0x04000ED9 RID: 3801
			public Vector3 camPos;
		}

		// Token: 0x02000363 RID: 867
		private sealed class <>c__DisplayClass58_0
		{
			// Token: 0x06002A3F RID: 10815 RVA: 0x0001D18D File Offset: 0x0001B38D
			internal int <SortHandleHoverDataCollection>b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1)
			{
				return 0;
			}

			// Token: 0x04000EDA RID: 3802
			public Vector3 inputDevicePos;

			// Token: 0x04000EDB RID: 3803
			public Ray hoverRay;
		}
	}
}
