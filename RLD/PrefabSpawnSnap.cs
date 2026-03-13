using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000196 RID: 406
	public class PrefabSpawnSnap : MonoBehaviour
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x00018FDC File Offset: 0x000171DC
		private void Awake()
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00018FDE File Offset: 0x000171DE
		private void Update()
		{
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00018FE0 File Offset: 0x000171E0
		private bool EvaluateSessionEndCondition()
		{
			return false;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00018FE3 File Offset: 0x000171E3
		private void OnInputDeviceMoved(IInputDevice inputDevice)
		{
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00018FE5 File Offset: 0x000171E5
		private void BeginSnapSession(GameObject targetHierarchy)
		{
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00018FE7 File Offset: 0x000171E7
		private void EndSnapSession()
		{
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00018FE9 File Offset: 0x000171E9
		private void OnAppInitialized()
		{
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00018FEB File Offset: 0x000171EB
		private void OnPrefabSpawned(RTPrefab prefab, GameObject spawnedObject)
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00018FED File Offset: 0x000171ED
		private void OnCanChangeObjectSelection(YesNoAnswer answer)
		{
		}

		// Token: 0x04000665 RID: 1637
		private bool _isSnapSessionActive;

		// Token: 0x04000666 RID: 1638
		private GameObject _targetHierarchy;

		// Token: 0x04000667 RID: 1639
		private ObjectSurfaceSnap.SnapConfig _snapConfig;

		// Token: 0x04000668 RID: 1640
		private int _objectSurfaceLayers;
	}
}
