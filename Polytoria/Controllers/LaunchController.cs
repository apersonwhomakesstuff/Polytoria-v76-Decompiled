using System;
using System.Collections.Generic;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x0200032E RID: 814
	public class LaunchController : MonoBehaviour
	{
		// Token: 0x06002869 RID: 10345 RVA: 0x0001CBD5 File Offset: 0x0001ADD5
		private void Start()
		{
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0001CBD7 File Offset: 0x0001ADD7
		public void LaunchAs(NetworkType netType, string token)
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0001CBD9 File Offset: 0x0001ADD9
		private Dictionary<string, string> GetCommandLineArgs()
		{
			return null;
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		private void OnDeepLinkActivated(string uri)
		{
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0001CBDE File Offset: 0x0001ADDE
		public static string GetActiveToken()
		{
			return null;
		}

		// Token: 0x04000DAC RID: 3500
		public static LaunchController singleton;

		// Token: 0x04000DAD RID: 3501
		public static NetworkType launchType;

		// Token: 0x04000DAE RID: 3502
		public static string clientToken;

		// Token: 0x04000DAF RID: 3503
		public static string serverToken;

		// Token: 0x04000DB0 RID: 3504
		public static bool isSolo;

		// Token: 0x04000DB1 RID: 3505
		public static string soloMapPath;

		// Token: 0x04000DB2 RID: 3506
		public static string soloUserName;

		// Token: 0x04000DB3 RID: 3507
		public static int soloUserID;

		// Token: 0x04000DB4 RID: 3508
		public static int soloID;

		// Token: 0x04000DB5 RID: 3509
		public static bool isLocal;

		// Token: 0x04000DB6 RID: 3510
		public static int localGameId;

		// Token: 0x04000DB7 RID: 3511
		public static int localUserId;

		// Token: 0x04000DB8 RID: 3512
		public static string localMapPath;

		// Token: 0x04000DB9 RID: 3513
		private NetworkType editorLaunchType;

		// Token: 0x04000DBA RID: 3514
		private string testToken;

		// Token: 0x04000DBB RID: 3515
		private bool doPlaySolo;

		// Token: 0x04000DBC RID: 3516
		private string playSoloTestMap;

		// Token: 0x04000DBD RID: 3517
		private string playSoloTestUserName;

		// Token: 0x04000DBE RID: 3518
		private int playSoloTestUserID;

		// Token: 0x04000DBF RID: 3519
		private bool doLocal;

		// Token: 0x04000DC0 RID: 3520
		private int testLocalUserId;

		// Token: 0x04000DC1 RID: 3521
		private int testLocalGameId;

		// Token: 0x04000DC2 RID: 3522
		private string testLocalMapPath;

		// Token: 0x04000DC3 RID: 3523
		private string testMobileLaunchURI;
	}
}
