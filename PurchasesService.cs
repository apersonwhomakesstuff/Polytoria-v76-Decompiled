using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

// Token: 0x02000009 RID: 9
public class PurchasesService : NetworkBehaviour
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001A RID: 26 RVA: 0x00015DF9 File Offset: 0x00013FF9
	// (set) Token: 0x0600001B RID: 27 RVA: 0x00015E00 File Offset: 0x00014000
	public static PurchasesService Instance
	{
		get
		{
			return PurchasesService.<Instance>k__BackingField;
		}
		private set
		{
			PurchasesService.<Instance>k__BackingField = value;
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00015E08 File Offset: 0x00014008
	private void Awake()
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00015E0A File Offset: 0x0001400A
	public void Prompt(Player player, int assetID, DynValue callback)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00015E0C File Offset: 0x0001400C
	private void DispatchPurchase(NetworkConnection target, int assetID, string refId)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00015E0E File Offset: 0x0001400E
	private IEnumerator ShowPurchaseModal(int assetID, string refId)
	{
		return null;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00015E11 File Offset: 0x00014011
	public void CancelButton()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00015E13 File Offset: 0x00014013
	public void PurchaseButton()
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00015E15 File Offset: 0x00014015
	private void CmdProcessPurchase(string refId, int expectedPrice)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00015E17 File Offset: 0x00014017
	private void CmdCancelPurchase(string refId)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00015E19 File Offset: 0x00014019
	private IEnumerator DoProcessPurchase(PurchasesService.PurchaseRequest request)
	{
		return null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00015E1C File Offset: 0x0001401C
	private void TargetPurchaseResult(NetworkConnection target, bool success, string message)
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00015E1E File Offset: 0x0001401E
	private void ShowPurchaseResultUI(bool success, string message)
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00015E20 File Offset: 0x00014020
	private void Update()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00015E22 File Offset: 0x00014022
	private void CleanupExpiredPurchases()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00015E2C File Offset: 0x0001402C
	public override bool Weaved()
	{
		return false;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00015E2F File Offset: 0x0001402F
	protected void UserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkConnection target, int assetID, string refId)
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00015E31 File Offset: 0x00014031
	protected static void InvokeUserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00015E33 File Offset: 0x00014033
	protected void UserCode_CmdProcessPurchase__String__Int32(string refId, int expectedPrice)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00015E35 File Offset: 0x00014035
	protected static void InvokeUserCode_CmdProcessPurchase__String__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00015E37 File Offset: 0x00014037
	protected void UserCode_CmdCancelPurchase__String(string refId)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00015E39 File Offset: 0x00014039
	protected static void InvokeUserCode_CmdCancelPurchase__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00015E3B File Offset: 0x0001403B
	protected void UserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkConnection target, bool success, string message)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00015E3D File Offset: 0x0001403D
	protected static void InvokeUserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	// Token: 0x04000009 RID: 9
	private static PurchasesService <Instance>k__BackingField;

	// Token: 0x0400000A RID: 10
	private RectTransform purchaseModalPrefab;

	// Token: 0x0400000B RID: 11
	private RectTransform purchaseResultPrefab;

	// Token: 0x0400000C RID: 12
	private string currentRefId;

	// Token: 0x0400000D RID: 13
	private Dictionary<string, PurchasesService.PurchaseRequest> pendingPurchases;

	// Token: 0x0400000E RID: 14
	private bool readyToPurchase;

	// Token: 0x0400000F RID: 15
	private int currentExpectedPrice;

	// Token: 0x02000349 RID: 841
	public struct PurchaseRequest
	{
		// Token: 0x04000E7F RID: 3711
		public Player player;

		// Token: 0x04000E80 RID: 3712
		public int assetID;

		// Token: 0x04000E81 RID: 3713
		public int expectedPrice;

		// Token: 0x04000E82 RID: 3714
		public DynValue callback;

		// Token: 0x04000E83 RID: 3715
		public DateTime timestamp;
	}

	// Token: 0x0200034A RID: 842
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x06002A18 RID: 10776 RVA: 0x0001D0E3 File Offset: 0x0001B2E3
		internal void <ShowPurchaseModal>b__0()
		{
		}

		// Token: 0x04000E84 RID: 3716
		public int assetID;

		// Token: 0x04000E85 RID: 3717
		public string refId;
	}

	// Token: 0x0200034B RID: 843
	private sealed class <DoProcessPurchase>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x0001D0E5 File Offset: 0x0001B2E5
		public <DoProcessPurchase>d__18(int <>1__state)
		{
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0001D0ED File Offset: 0x0001B2ED
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0001D0EF File Offset: 0x0001B2EF
		bool IEnumerator.MoveNext()
		{
			return false;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x0001D0F2 File Offset: 0x0001B2F2
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
		object IEnumerator<object>.Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x0001D0F7 File Offset: 0x0001B2F7
		void IEnumerator.Reset()
		{
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x0001D0F9 File Offset: 0x0001B2F9
		object IEnumerator.Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000E86 RID: 3718
		private int <>1__state;

		// Token: 0x04000E87 RID: 3719
		private object <>2__current;

		// Token: 0x04000E88 RID: 3720
		public PurchasesService.PurchaseRequest request;

		// Token: 0x04000E89 RID: 3721
		public PurchasesService <>4__this;

		// Token: 0x04000E8A RID: 3722
		private bool <success>5__2;

		// Token: 0x04000E8B RID: 3723
		private string <message>5__3;

		// Token: 0x04000E8C RID: 3724
		private UnityWebRequest <uwr>5__4;
	}

	// Token: 0x0200034C RID: 844
	private sealed class <ShowPurchaseModal>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002A20 RID: 10784 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		public <ShowPurchaseModal>d__13(int <>1__state)
		{
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x0001D104 File Offset: 0x0001B304
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x0001D106 File Offset: 0x0001B306
		bool IEnumerator.MoveNext()
		{
			return false;
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x0001D109 File Offset: 0x0001B309
		private void <>m__Finally1()
		{
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x0001D10B File Offset: 0x0001B30B
		private void <>m__Finally2()
		{
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x0001D10D File Offset: 0x0001B30D
		object IEnumerator<object>.Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x0001D110 File Offset: 0x0001B310
		void IEnumerator.Reset()
		{
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x0001D112 File Offset: 0x0001B312
		object IEnumerator.Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000E8D RID: 3725
		private int <>1__state;

		// Token: 0x04000E8E RID: 3726
		private object <>2__current;

		// Token: 0x04000E8F RID: 3727
		public int assetID;

		// Token: 0x04000E90 RID: 3728
		public string refId;

		// Token: 0x04000E91 RID: 3729
		private PurchasesService.<>c__DisplayClass13_0 <>8__1;

		// Token: 0x04000E92 RID: 3730
		public PurchasesService <>4__this;

		// Token: 0x04000E93 RID: 3731
		private UnityWebRequest <www>5__2;

		// Token: 0x04000E94 RID: 3732
		private string <assetName>5__3;

		// Token: 0x04000E95 RID: 3733
		private int <price>5__4;

		// Token: 0x04000E96 RID: 3734
		private UnityWebRequest <thumbnailRequest>5__5;

		// Token: 0x04000E97 RID: 3735
		private Button <purchaseButton>5__6;
	}
}
