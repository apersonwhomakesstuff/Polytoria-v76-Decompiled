using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace RLD
{
	// Token: 0x020000F3 RID: 243
	public class RLDApp : MonoSingleton<RLDApp>, IRLDApplication
	{
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000D7F RID: 3455 RVA: 0x000182C3 File Offset: 0x000164C3
		// (remove) Token: 0x06000D80 RID: 3456 RVA: 0x000182C5 File Offset: 0x000164C5
		public event RLDAppInitializedHandler Initialized
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000182C7 File Offset: 0x000164C7
		public DynamicConvertSettings DynamicConvertSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00020394 File Offset: 0x0001E594
		public RenderPipelineId RenderPipelineId
		{
			get
			{
				return RenderPipelineId.Standard;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000182CA File Offset: 0x000164CA
		public Camera RenderCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x000182CD File Offset: 0x000164CD
		private void OnSceneCanRenderCameraIcon(Camera camera, YesNoAnswer answer)
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000182CF File Offset: 0x000164CF
		private void OnCanCameraUseScrollWheel(YesNoAnswer answer)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x000182D1 File Offset: 0x000164D1
		private void OnCanCameraProcessInput(YesNoAnswer answer)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000182D3 File Offset: 0x000164D3
		private void OnCanUndoRedo(UndoRedoOpType undoRedoOpType, YesNoAnswer answer)
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x000182D5 File Offset: 0x000164D5
		private void OnCanDoGizmoHoverUpdate(YesNoAnswer answer)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x000182D7 File Offset: 0x000164D7
		private void OnCanObjectSelectionClickAndMultiSelectDeselect(YesNoAnswer answer)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000182D9 File Offset: 0x000164D9
		private void OnViewportsCameraAdded(Camera camera)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000182DB File Offset: 0x000164DB
		private void OnViewportCameraRemoved(Camera camera)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000182DD File Offset: 0x000164DD
		private void Start()
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000182DF File Offset: 0x000164DF
		private void DetectRenderPipeline()
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000182E1 File Offset: 0x000164E1
		private void OnDisable()
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000182E3 File Offset: 0x000164E3
		private void Update()
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000182E5 File Offset: 0x000164E5
		private void OnRenderObject()
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000182E7 File Offset: 0x000164E7
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000182E9 File Offset: 0x000164E9
		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		// Token: 0x040004AA RID: 1194
		private Camera _renderCamera;

		// Token: 0x040004AB RID: 1195
		private RenderPipelineId _renderPipelineId;

		// Token: 0x040004AC RID: 1196
		private DynamicConvertSettings _dynamicConvertSettings;
	}
}
