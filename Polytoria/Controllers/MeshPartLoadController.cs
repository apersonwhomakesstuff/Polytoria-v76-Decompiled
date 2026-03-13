using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GLTFast;
using GLTFast.Logging;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000332 RID: 818
	public class MeshPartLoadController : MonoBehaviour
	{
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x0001CC2C File Offset: 0x0001AE2C
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x0001CC34 File Offset: 0x0001AE34
		public GltfImport Importer
		{
			get
			{
				return this.<Importer>k__BackingField;
			}
			protected set
			{
				this.<Importer>k__BackingField = value;
			}
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0001CC3D File Offset: 0x0001AE3D
		private void Awake()
		{
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0001CC3F File Offset: 0x0001AE3F
		private void Start()
		{
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0001CC41 File Offset: 0x0001AE41
		public void LoadMesh(MeshPartLoadRequest request)
		{
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0001CC43 File Offset: 0x0001AE43
		private void Update()
		{
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0001CC45 File Offset: 0x0001AE45
		private Task LoadMeshAsync(MeshPartLoadRequest request)
		{
			return null;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0001CC48 File Offset: 0x0001AE48
		private GameObject FindInCache(int assetID)
		{
			return null;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0001CC4B File Offset: 0x0001AE4B
		private Task<string> GetMeshUrlAsync(int assetID)
		{
			return null;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0001CC4E File Offset: 0x0001AE4E
		private Task<GameObject> ImportMeshAsync(MeshPartLoadRequest request, string meshUrl)
		{
			return null;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0001CC51 File Offset: 0x0001AE51
		private void CacheLoadedObject(int assetID, GameObject loadedObject)
		{
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0001CC53 File Offset: 0x0001AE53
		private void ProcessLoadedObject(MeshPartLoadRequest request, GameObject loadedObject)
		{
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0001CC55 File Offset: 0x0001AE55
		private void ClearExistingChildren(MeshPart meshPart)
		{
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0001CC57 File Offset: 0x0001AE57
		private void AdjustLoadedObjectBounds(GameObject loadedObject)
		{
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0001CC59 File Offset: 0x0001AE59
		private void AttachLoadedObjectToMeshPart(MeshPartLoadRequest request, GameObject loadedObject)
		{
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0001CC5B File Offset: 0x0001AE5B
		private void EnableRenderers(GameObject obj, bool enabled)
		{
		}

		// Token: 0x04000DD0 RID: 3536
		public static MeshPartLoadController Instance;

		// Token: 0x04000DD1 RID: 3537
		private Queue<MeshPartLoadRequest> loadQueue;

		// Token: 0x04000DD2 RID: 3538
		private GameObject meshStorage;

		// Token: 0x04000DD3 RID: 3539
		private bool loading;

		// Token: 0x04000DD4 RID: 3540
		private ImportSettings importSettings;

		// Token: 0x04000DD5 RID: 3541
		private InstantiationSettings instantiationSettings;

		// Token: 0x04000DD6 RID: 3542
		private GltfImport <Importer>k__BackingField;

		// Token: 0x04000DD7 RID: 3543
		private ConsoleLogger logger;
	}
}
