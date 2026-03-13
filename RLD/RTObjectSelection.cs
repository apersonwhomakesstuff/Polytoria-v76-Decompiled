using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200023B RID: 571
	[Serializable]
	public class RTObjectSelection : MonoSingleton<RTObjectSelection>
	{
		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060018B4 RID: 6324 RVA: 0x0001A04F File Offset: 0x0001824F
		// (remove) Token: 0x060018B5 RID: 6325 RVA: 0x0001A051 File Offset: 0x00018251
		public event ObjectSelectionManipSessionBeginHandler ManipSessionBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060018B6 RID: 6326 RVA: 0x0001A053 File Offset: 0x00018253
		// (remove) Token: 0x060018B7 RID: 6327 RVA: 0x0001A055 File Offset: 0x00018255
		public event ObjectSelectionManipSessionEndHandler ManipSessionEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x060018B8 RID: 6328 RVA: 0x0001A057 File Offset: 0x00018257
		// (remove) Token: 0x060018B9 RID: 6329 RVA: 0x0001A059 File Offset: 0x00018259
		public event ObjectSelectionCanClickSelectDeselectHandler CanClickSelectDeselect
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060018BA RID: 6330 RVA: 0x0001A05B File Offset: 0x0001825B
		// (remove) Token: 0x060018BB RID: 6331 RVA: 0x0001A05D File Offset: 0x0001825D
		public event ObjectSelectionCanMultiSelectDeselectHandler CanMultiSelectDeselect
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060018BC RID: 6332 RVA: 0x0001A05F File Offset: 0x0001825F
		// (remove) Token: 0x060018BD RID: 6333 RVA: 0x0001A061 File Offset: 0x00018261
		public event ObjectSelectionChangedHandler Changed
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060018BE RID: 6334 RVA: 0x0001A063 File Offset: 0x00018263
		// (remove) Token: 0x060018BF RID: 6335 RVA: 0x0001A065 File Offset: 0x00018265
		public event ObjectSelectionWillBeDeletedHandler WillBeDeleted
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x060018C0 RID: 6336 RVA: 0x0001A067 File Offset: 0x00018267
		// (remove) Token: 0x060018C1 RID: 6337 RVA: 0x0001A069 File Offset: 0x00018269
		public event ObjectSelectionDeletedHandler Deleted
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060018C2 RID: 6338 RVA: 0x0001A06B File Offset: 0x0001826B
		// (remove) Token: 0x060018C3 RID: 6339 RVA: 0x0001A06D File Offset: 0x0001826D
		public event ObjectSelectionWillBeDuplicatedHandler WillBeDuplicated
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060018C4 RID: 6340 RVA: 0x0001A06F File Offset: 0x0001826F
		// (remove) Token: 0x060018C5 RID: 6341 RVA: 0x0001A071 File Offset: 0x00018271
		public event ObjectSelectionDuplicatedHandler Duplicated
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x060018C6 RID: 6342 RVA: 0x0001A073 File Offset: 0x00018273
		// (remove) Token: 0x060018C7 RID: 6343 RVA: 0x0001A075 File Offset: 0x00018275
		public event ObjectSelectionRotatedHandler Rotated
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060018C8 RID: 6344 RVA: 0x0001A077 File Offset: 0x00018277
		// (remove) Token: 0x060018C9 RID: 6345 RVA: 0x0001A079 File Offset: 0x00018279
		public event ObjectSelectionPreSelectCustomizeHandler PreSelectCustomize
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060018CA RID: 6346 RVA: 0x0001A07B File Offset: 0x0001827B
		// (remove) Token: 0x060018CB RID: 6347 RVA: 0x0001A07D File Offset: 0x0001827D
		public event ObjectSelectionPreDeselectCustomizeHandler PreDeselectCustomize
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060018CC RID: 6348 RVA: 0x0001A07F File Offset: 0x0001827F
		// (remove) Token: 0x060018CD RID: 6349 RVA: 0x0001A081 File Offset: 0x00018281
		public event ObjectSelectionEnabled Enabled
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060018CE RID: 6350 RVA: 0x0001A083 File Offset: 0x00018283
		// (remove) Token: 0x060018CF RID: 6351 RVA: 0x0001A085 File Offset: 0x00018285
		public event ObjectSelectionDisabled Disabled
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0001A087 File Offset: 0x00018287
		public bool IsEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0001A08A File Offset: 0x0001828A
		public bool IsMultiSelectShapeVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0001A08D File Offset: 0x0001828D
		public int NumSelectedObjects
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x0001A090 File Offset: 0x00018290
		public ObjectSelectionHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0001A093 File Offset: 0x00018293
		public ObjectSelectionSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0001A096 File Offset: 0x00018296
		public ObjectSelectionLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0001A099 File Offset: 0x00018299
		public ObjectSelectionRotationSettings RotationSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0001A09C File Offset: 0x0001829C
		public ObjectSelectionRotationHotkeys RotationHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0001A09F File Offset: 0x0001829F
		public ObjectGrabSettings GrabSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0001A0A2 File Offset: 0x000182A2
		public ObjectGrabHotkeys GrabHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0001A0A5 File Offset: 0x000182A5
		public ObjectGrabLookAndFeel GrabLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0001A0A8 File Offset: 0x000182A8
		public ObjectGridSnapLookAndFeel GridSnapLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x0001A0AB File Offset: 0x000182AB
		public ObjectGridSnapHotkeys GridSnapHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0001A0AE File Offset: 0x000182AE
		public Object2ObjectSnapSettings Object2ObjectSnapSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x0001A0B1 File Offset: 0x000182B1
		public Object2ObjectSnapHotkeys Object2ObjectSnapHotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x0001A0B4 File Offset: 0x000182B4
		public bool IsManipSessionActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00023B7C File Offset: 0x00021D7C
		public ObjectSelectionManipSession ActiveManipSession
		{
			get
			{
				return ObjectSelectionManipSession.None;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0001A0B7 File Offset: 0x000182B7
		public bool IsGrabSessionActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x0001A0BA File Offset: 0x000182BA
		public bool IsGridSnapSessionActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0001A0BD File Offset: 0x000182BD
		public bool IsObject2ObjectSnapSessionActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x0001A0C0 File Offset: 0x000182C0
		public List<GameObject> SelectedObjects
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0001A0C3 File Offset: 0x000182C3
		public void Initialize_SystemCall()
		{
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0001A0C5 File Offset: 0x000182C5
		public void AttachGizmoController(IObjectCollectionGizmoController gizmoController)
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0001A0C7 File Offset: 0x000182C7
		public bool IsRenderIgnoreCamera(Camera camera)
		{
			return false;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0001A0CA File Offset: 0x000182CA
		public void AddRenderIgnoreCamera(Camera camera)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0001A0CC File Offset: 0x000182CC
		public void RemoveRenderIgnoreCamera(Camera camera)
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0001A0CE File Offset: 0x000182CE
		public void SetEnabled(bool isEnabled)
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0001A0D0 File Offset: 0x000182D0
		public void SetRotation(Quaternion rotation)
		{
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0001A0D2 File Offset: 0x000182D2
		public void Rotate(Axis axis, float rotationAngle, ObjectRotationPivot rotationPivot)
		{
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0001A0D4 File Offset: 0x000182D4
		public void AppendObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0001A0D6 File Offset: 0x000182D6
		public void RemoveObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0001A0D8 File Offset: 0x000182D8
		public void SetSelectedObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0001A0DA File Offset: 0x000182DA
		public void ClearSelection(bool allowUndoRedo)
		{
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0001A0DC File Offset: 0x000182DC
		public void Delete()
		{
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0001A0DE File Offset: 0x000182DE
		public void ForceDelete()
		{
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0001A0E0 File Offset: 0x000182E0
		public bool CanBeDeleted()
		{
			return false;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0001A0E3 File Offset: 0x000182E3
		public bool CanBeDuplicated()
		{
			return false;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0001A0E6 File Offset: 0x000182E6
		public bool CanBeModifiedByAPI()
		{
			return false;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0001A0E9 File Offset: 0x000182E9
		public ObjectSelectionDuplicationResult Duplicate()
		{
			return null;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0001A0EC File Offset: 0x000182EC
		public bool IsSelectionExactMatch(List<GameObject> gameObjectsToMatch)
		{
			return false;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0001A0EF File Offset: 0x000182EF
		public bool IsObjectSelected(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00023B94 File Offset: 0x00021D94
		public AABB GetWorldAABB()
		{
			return default(AABB);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0001A0F2 File Offset: 0x000182F2
		public void Update_SystemCall()
		{
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0001A0F4 File Offset: 0x000182F4
		public void Render_SystemCall(Camera renderCamera)
		{
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0001A0F6 File Offset: 0x000182F6
		private void OnInputDevicePickButtonDown()
		{
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0001A0F8 File Offset: 0x000182F8
		private void OnInputDevicePickButtonUp()
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0001A0FA File Offset: 0x000182FA
		private void OnInputDeviceWasMoved()
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0001A0FC File Offset: 0x000182FC
		private void PerformMultiSelect()
		{
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0001A0FE File Offset: 0x000182FE
		private void PerformClickSelect()
		{
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0001A100 File Offset: 0x00018300
		private ObjectPreSelectCustomizeInfo DoPreSelectCustomize(List<GameObject> toBeSelected, ObjectSelectReason selectReason)
		{
			return null;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0001A103 File Offset: 0x00018303
		private List<GameObject> DoPreDeselectCustomize(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason)
		{
			return null;
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0001A106 File Offset: 0x00018306
		private List<GameObject> FilterByRestrictions(IEnumerable<GameObject> gameObjects, RTObjectSelection.SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason)
		{
			return null;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0001A109 File Offset: 0x00018309
		private List<GameObjectRayHit> FilterByRestrictions(List<GameObjectRayHit> objectHits, RTObjectSelection.SelectRestrictFlags restrictFlags)
		{
			return null;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0001A10C File Offset: 0x0001830C
		private bool CanSelectObject(GameObject gameObject, RTObjectSelection.SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason)
		{
			return false;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0001A10F File Offset: 0x0001830F
		private void SelectObject(GameObject gameObject, ObjectSelectReason selectReason)
		{
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0001A111 File Offset: 0x00018311
		private void DeselectObject(GameObject gameObject, ObjectDeselectReason deselectReason)
		{
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0001A113 File Offset: 0x00018313
		private void ClearSelection(ObjectDeselectReason deselectReason)
		{
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0001A115 File Offset: 0x00018315
		private void OnSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0001A117 File Offset: 0x00018317
		private void RemoveNullAndInactiveObjectRefs()
		{
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0001A119 File Offset: 0x00018319
		private void OnUndoEnd(IUndoRedoAction action)
		{
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0001A11B File Offset: 0x0001831B
		private void OnRedoEnd(IUndoRedoAction action)
		{
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0001A11D File Offset: 0x0001831D
		private void HandleUndoRedo(ObjectSelectionSnapshot undoRedoSnapshot, bool isUndo)
		{
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0001A11F File Offset: 0x0001831F
		private void OnGrabSessionBegin()
		{
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0001A121 File Offset: 0x00018321
		private void OnGrabSessionEnd()
		{
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0001A123 File Offset: 0x00018323
		private void OnGridSnapSessionBegin()
		{
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0001A125 File Offset: 0x00018325
		private void OnGridSnapSessionEnd()
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0001A127 File Offset: 0x00018327
		private void OnObject2ObjectSnapSessionBegin()
		{
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0001A129 File Offset: 0x00018329
		private void OnObject2ObjectSnapSessionEnd()
		{
		}

		// Token: 0x040008BE RID: 2238
		private static readonly int _objectPickDeviceBtnIndex;

		// Token: 0x040008CD RID: 2253
		private List<GameObject> _visibleObjectBuffer;

		// Token: 0x040008CE RID: 2254
		private List<GameObject> _overlappedObjectBuffer;

		// Token: 0x040008CF RID: 2255
		private List<GameObjectRayHit> _objectHitBuffer;

		// Token: 0x040008D0 RID: 2256
		private bool _isEnabled;

		// Token: 0x040008D1 RID: 2257
		private List<Camera> _renderIgnoreCameras;

		// Token: 0x040008D2 RID: 2258
		private List<GameObject> _selectedObjects;

		// Token: 0x040008D3 RID: 2259
		private MultiSelectShape _multiSelectShape;

		// Token: 0x040008D4 RID: 2260
		private ObjectSelectionSnapshot _multiSelectPreChangeSnapshot;

		// Token: 0x040008D5 RID: 2261
		private bool _wasSelectionChangedViaMultiSelectShape;

		// Token: 0x040008D6 RID: 2262
		private bool _willBeDeleted;

		// Token: 0x040008D7 RID: 2263
		private bool _doingPreSelectCustomize;

		// Token: 0x040008D8 RID: 2264
		private bool _doingPreDeselectCustomize;

		// Token: 0x040008D9 RID: 2265
		private bool _firingSelectionChanged;

		// Token: 0x040008DA RID: 2266
		private ObjectSelectionManipSession _activeManipSession;

		// Token: 0x040008DB RID: 2267
		private RTObjectSelection.CyclicalClickSelectInfo _cyclicalClickSelectInfo;

		// Token: 0x040008DC RID: 2268
		private ObjectSelectionHotkeys _hotkeys;

		// Token: 0x040008DD RID: 2269
		private ObjectSelectionSettings _settings;

		// Token: 0x040008DE RID: 2270
		private ObjectSelectionLookAndFeel _lookAndFeel;

		// Token: 0x040008DF RID: 2271
		private ObjectSelectionRotationSettings _rotationSettings;

		// Token: 0x040008E0 RID: 2272
		private ObjectSelectionRotationHotkeys _rotationHotkeys;

		// Token: 0x040008E1 RID: 2273
		private DeviceObjectGrabSession _grabSession;

		// Token: 0x040008E2 RID: 2274
		private ObjectGrabSettings _grabSettings;

		// Token: 0x040008E3 RID: 2275
		private ObjectGrabLookAndFeel _grabLookAndFeel;

		// Token: 0x040008E4 RID: 2276
		private ObjectGrabHotkeys _grabHotkeys;

		// Token: 0x040008E5 RID: 2277
		private ObjectGridSnapSession _gridSnapSession;

		// Token: 0x040008E6 RID: 2278
		private ObjectGridSnapLookAndFeel _gridSnapLookAndFeel;

		// Token: 0x040008E7 RID: 2279
		private ObjectGridSnapHotkeys _gridSnapHotkeys;

		// Token: 0x040008E8 RID: 2280
		private Object2ObjectSnapSession _object2ObjectSnapSession;

		// Token: 0x040008E9 RID: 2281
		private Object2ObjectSnapSettings _object2ObjectSnapSettings;

		// Token: 0x040008EA RID: 2282
		private Object2ObjectSnapHotkeys _object2ObjectSnapHotkeys;

		// Token: 0x040008EB RID: 2283
		private EditorToolbar _settingsToolbar;

		// Token: 0x020003CF RID: 975
		private enum SelectRestrictFlags
		{
			// Token: 0x04001039 RID: 4153
			None,
			// Token: 0x0400103A RID: 4154
			ObjectLayer,
			// Token: 0x0400103B RID: 4155
			ObjectType,
			// Token: 0x0400103C RID: 4156
			Object = 4,
			// Token: 0x0400103D RID: 4157
			SelectionListener = 8,
			// Token: 0x0400103E RID: 4158
			All = 15
		}

		// Token: 0x020003D0 RID: 976
		private struct CyclicalClickSelectInfo
		{
			// Token: 0x0400103F RID: 4159
			public int LastSelectedIndex;

			// Token: 0x04001040 RID: 4160
			public GameObject LastPickedObject;
		}

		// Token: 0x020003D1 RID: 977
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002B36 RID: 11062 RVA: 0x0001D4A7 File Offset: 0x0001B6A7
			internal bool <RemoveNullAndInactiveObjectRefs>b__155_0(GameObject item)
			{
				return false;
			}

			// Token: 0x06002B37 RID: 11063 RVA: 0x0001D4AA File Offset: 0x0001B6AA
			internal bool <RemoveNullAndInactiveObjectRefs>b__155_1(GameObject item)
			{
				return false;
			}

			// Token: 0x04001041 RID: 4161
			public static readonly RTObjectSelection.<>c <>9;

			// Token: 0x04001042 RID: 4162
			public static Predicate<GameObject> <>9__155_0;

			// Token: 0x04001043 RID: 4163
			public static Predicate<GameObject> <>9__155_1;
		}

		// Token: 0x020003D2 RID: 978
		private sealed class <>c__DisplayClass144_0
		{
			// Token: 0x06002B39 RID: 11065 RVA: 0x0001D4B5 File Offset: 0x0001B6B5
			internal bool <PerformMultiSelect>b__0(GameObject item)
			{
				return false;
			}

			// Token: 0x04001044 RID: 4164
			public RTObjectSelection <>4__this;

			// Token: 0x04001045 RID: 4165
			public ObjectBounds.QueryConfig boundsQConfig;
		}
	}
}
