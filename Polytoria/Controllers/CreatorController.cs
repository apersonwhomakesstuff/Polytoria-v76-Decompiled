using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Battlehub.UIControls;
using HSVPicker;
using Mirror;
using Polytoria.Creator.PropertyGrid;
using Polytoria.Datamodel;
using RLD;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x0200033E RID: 830
	public class CreatorController : NetworkBehaviour
	{
		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x0001CEEE File Offset: 0x0001B0EE
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x0001CEF6 File Offset: 0x0001B0F6
		public string CreatorToken
		{
			get
			{
				return this.<CreatorToken>k__BackingField;
			}
			private set
			{
				this.<CreatorToken>k__BackingField = value;
			}
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x0001CEFF File Offset: 0x0001B0FF
		private static bool WantsToQuit()
		{
			return false;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0001CF02 File Offset: 0x0001B102
		public void PromptExit()
		{
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x0001CF04 File Offset: 0x0001B104
		public void DoExit()
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x0001CF06 File Offset: 0x0001B106
		private void Awake()
		{
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x0001CF08 File Offset: 0x0001B108
		private void OnPostDragEnd(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0001CF0A File Offset: 0x0001B10A
		private void PropertyGrid_ValueChanged(object obj, PropertyInfo propertyInfo)
		{
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0001CF0C File Offset: 0x0001B10C
		private void GameLoaded()
		{
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0001CF0E File Offset: 0x0001B10E
		private void OnAppInitialized()
		{
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x0001CF10 File Offset: 0x0001B110
		private void Start()
		{
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x0001CF12 File Offset: 0x0001B112
		public void DeleteSelection()
		{
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x0001CF14 File Offset: 0x0001B114
		public void DuplicateSelection()
		{
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x0001CF16 File Offset: 0x0001B116
		public void SetStatusBarMessage(string message)
		{
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x0001CF18 File Offset: 0x0001B118
		private IEnumerator CheckToken()
		{
			return null;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x0001CF1B File Offset: 0x0001B11B
		private Dictionary<string, string> GetCommandLineArgs()
		{
			return null;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x0001CF1E File Offset: 0x0001B11E
		private void RelaunchCreator()
		{
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x0001CF20 File Offset: 0x0001B120
		public void GroupSelection()
		{
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x0001CF22 File Offset: 0x0001B122
		public void UngroupSelection()
		{
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x0001CF24 File Offset: 0x0001B124
		public void ExportModel()
		{
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x0001CF26 File Offset: 0x0001B126
		private IEnumerator ShowExportModelDialog()
		{
			return null;
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x0001CF29 File Offset: 0x0001B129
		private static void DoExportModel(string path)
		{
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x0001CF2B File Offset: 0x0001B12B
		public void ExportGLTF()
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x0001CF2D File Offset: 0x0001B12D
		private IEnumerator ShowExportGLTFDialog()
		{
			return null;
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x0001CF30 File Offset: 0x0001B130
		private static void DoExportGLTF(string path)
		{
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0001CF32 File Offset: 0x0001B132
		public void PublishModel()
		{
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x0001CF34 File Offset: 0x0001B134
		private IEnumerator DoPublishModel()
		{
			return null;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0001CF37 File Offset: 0x0001B137
		public void ImportModel()
		{
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0001CF39 File Offset: 0x0001B139
		private IEnumerator ShowImportModelDialog()
		{
			return null;
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0001CF3C File Offset: 0x0001B13C
		private static void DoImportModel(string[] paths)
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0001CF3E File Offset: 0x0001B13E
		public void ToolboxModelAdded(Model i)
		{
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x0001CF40 File Offset: 0x0001B140
		public static List<Instance> GetSelectedInstances()
		{
			return null;
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0001CF43 File Offset: 0x0001B143
		private IEnumerator LoadStarterPlaces()
		{
			return null;
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0001CF46 File Offset: 0x0001B146
		public void ClearWorkspace()
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x0001CF48 File Offset: 0x0001B148
		public void CloseStartScreen()
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x0001CF4A File Offset: 0x0001B14A
		private void ScriptEditedExternally(object sender, FileSystemEventArgs e)
		{
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x0001CF4C File Offset: 0x0001B14C
		private void EditScript(BaseScript script)
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x0001CF4E File Offset: 0x0001B14E
		public void PublishGame()
		{
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0001CF50 File Offset: 0x0001B150
		private IEnumerator DoPublish()
		{
			return null;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0001CF53 File Offset: 0x0001B153
		private IEnumerator LoadThumbnailImages(List<CreatorController.ThumbnailImageTarget> thumbnails)
		{
			return null;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x0001CF56 File Offset: 0x0001B156
		public void SetPublishModalSelectedGame(JSONNode game)
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x0001CF58 File Offset: 0x0001B158
		private IEnumerator LoadThumbnailImage(string src, Image target)
		{
			return null;
		}

		// Token: 0x06002956 RID: 10582
		[PreserveSig]
		private static extern int chmod(string path, int mode);

		// Token: 0x06002957 RID: 10583 RVA: 0x0001CF5B File Offset: 0x0001B15B
		public void TestGame()
		{
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0001CF5D File Offset: 0x0001B15D
		public void PublishGameOverwrite(int id)
		{
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x0001CF5F File Offset: 0x0001B15F
		private IEnumerator PublishLevelToID(int id)
		{
			return null;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0001CF62 File Offset: 0x0001B162
		public static string RandomString(int length)
		{
			return null;
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0001CF65 File Offset: 0x0001B165
		public void FileOpen()
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x0001CF67 File Offset: 0x0001B167
		private IEnumerator ShowOpenDialog()
		{
			return null;
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x0001CF6A File Offset: 0x0001B16A
		private IEnumerator AutoSaveLoop()
		{
			return null;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x0001CF6D File Offset: 0x0001B16D
		private static void DoLoadMap(string[] paths)
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x0001CF6F File Offset: 0x0001B16F
		private IEnumerator LoadMapFromFile(string path)
		{
			return null;
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0001CF72 File Offset: 0x0001B172
		public void FileSave(bool saveAs)
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0001CF74 File Offset: 0x0001B174
		private IEnumerator ShowSaveDialog()
		{
			return null;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x0001CF77 File Offset: 0x0001B177
		private static void DoSaveFile(string path)
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0001CF79 File Offset: 0x0001B179
		public void SetMoveSnapEnabled(bool enabled)
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x0001CF7B File Offset: 0x0001B17B
		public void SetMoveSnapSize(string snapString)
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0001CF7D File Offset: 0x0001B17D
		public void SetRotateSnapEnabled(bool enabled)
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x0001CF7F File Offset: 0x0001B17F
		public void SetRotateSnapSize(string snapString)
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x0001CF81 File Offset: 0x0001B181
		public void SetActiveGizmo(string name)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x0001CF83 File Offset: 0x0001B183
		private void Update()
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0001CF85 File Offset: 0x0001B185
		private bool IsEditingTextField()
		{
			return false;
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x0001CF88 File Offset: 0x0001B188
		public List<Instance> GetSelectedInstancesTreeView()
		{
			return null;
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x0001CF8B File Offset: 0x0001B18B
		public void CopySelectionToClipboard()
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0001CF8D File Offset: 0x0001B18D
		public void CutSelectionToClipboard()
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0001CF8F File Offset: 0x0001B18F
		public void PasteFromClipboard()
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0001CF91 File Offset: 0x0001B191
		private void ShowContextMenu()
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0001CF93 File Offset: 0x0001B193
		public void SetPaintColor(Color c)
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0001CF95 File Offset: 0x0001B195
		public void ToggleColorPicker()
		{
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0001CF97 File Offset: 0x0001B197
		public void ToggleMaterialPicker()
		{
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x0001CF99 File Offset: 0x0001B199
		private void OnItemDataBinding(object sender, VirtualizingTreeViewItemDataBindingArgs e)
		{
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x0001CF9B File Offset: 0x0001B19B
		private void OnItemBeginDrop(object sender, ItemDropCancelArgs e)
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0001CF9D File Offset: 0x0001B19D
		private void OnItemBeginDrag(object sender, ItemArgs e)
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x0001CF9F File Offset: 0x0001B19F
		private void OnItemEndDrag(object sender, ItemArgs e)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x0001CFA1 File Offset: 0x0001B1A1
		private void OnItemExpanding(object sender, VirtualizingItemExpandingArgs e)
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x0001CFA3 File Offset: 0x0001B1A3
		private void OnTreeSelectionChanged(object sender, SelectionChangedArgs e)
		{
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x0001CFA5 File Offset: 0x0001B1A5
		private List<Instance> ChildrenOf(Instance parent)
		{
			return null;
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		private void OnItemDrop(object sender, ItemDropArgs e)
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0001CFAA File Offset: 0x0001B1AA
		private void OnItemDoubleClick(object sender, ItemArgs e)
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0001CFAC File Offset: 0x0001B1AC
		private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x0001CFAE File Offset: 0x0001B1AE
		public void CloseContextMenu()
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		public void AddPart(string shape)
		{
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x0001CFB2 File Offset: 0x0001B1B2
		public void SelectChildren()
		{
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
		public void Undo()
		{
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0001CFB6 File Offset: 0x0001B1B6
		public void Redo()
		{
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		public void AddTruss()
		{
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0001CFBA File Offset: 0x0001B1BA
		public Instance AddInstance(string className, Instance parent = null, bool ignorePlacement = false)
		{
			return null;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0001CFBD File Offset: 0x0001B1BD
		public void AddPart(PartShape shape = PartShape.Brick, string name = "Brick")
		{
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x0001CFBF File Offset: 0x0001B1BF
		public void AddScript()
		{
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x0001CFC1 File Offset: 0x0001B1C1
		public void AddSound()
		{
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0001CFC3 File Offset: 0x0001B1C3
		public void AddLocalScript()
		{
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x0001CFC5 File Offset: 0x0001B1C5
		public void AddModuleScript()
		{
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0001CFC7 File Offset: 0x0001B1C7
		public void AddRemoteEvent()
		{
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x0001CFC9 File Offset: 0x0001B1C9
		public Instance Add(string instanceClass, string parentClass)
		{
			return null;
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0001CFCC File Offset: 0x0001B1CC
		public void AddUI(string instanceClass)
		{
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0001CFCE File Offset: 0x0001B1CE
		public void AddSeat(string name = "Seat")
		{
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
		public static bool IsPointerOverUIObject()
		{
			return false;
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0001CFDD File Offset: 0x0001B1DD
		private void <CheckToken>b__50_0(bool result)
		{
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x0001CFDF File Offset: 0x0001B1DF
		private void <LoadMapFromFile>b__87_0(bool r)
		{
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0001CFE1 File Offset: 0x0001B1E1
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000E38 RID: 3640
		private string testCreatorToken;

		// Token: 0x04000E39 RID: 3641
		public static CreatorController singleton;

		// Token: 0x04000E3A RID: 3642
		public static bool IsCreator;

		// Token: 0x04000E3B RID: 3643
		public static string externalScriptFolder;

		// Token: 0x04000E3C RID: 3644
		private static System.Random random;

		// Token: 0x04000E3D RID: 3645
		public VirtualizingTreeView TreeView;

		// Token: 0x04000E3E RID: 3646
		public CreatorPropertyGrid PropertyGrid;

		// Token: 0x04000E3F RID: 3647
		public Image[] activateButtons;

		// Token: 0x04000E40 RID: 3648
		public ColorPicker colorPicker;

		// Token: 0x04000E41 RID: 3649
		public Image[] colorDisplay;

		// Token: 0x04000E42 RID: 3650
		public Canvas canvas;

		// Token: 0x04000E43 RID: 3651
		public RectTransform landing;

		// Token: 0x04000E44 RID: 3652
		public RectTransform materialSelector;

		// Token: 0x04000E45 RID: 3653
		public RectTransform publishModal;

		// Token: 0x04000E46 RID: 3654
		public RectTransform contextMenu;

		// Token: 0x04000E47 RID: 3655
		public ColorPicker propertyColorPicker;

		// Token: 0x04000E48 RID: 3656
		public TMP_Text statusBar;

		// Token: 0x04000E49 RID: 3657
		public GameObject confirmExit;

		// Token: 0x04000E4A RID: 3658
		private float moveSnap;

		// Token: 0x04000E4B RID: 3659
		private float rotateSnap;

		// Token: 0x04000E4C RID: 3660
		private bool moveSnapEnabled;

		// Token: 0x04000E4D RID: 3661
		private bool rotateSnapEnabled;

		// Token: 0x04000E4E RID: 3662
		public float autoSaveInterval;

		// Token: 0x04000E4F RID: 3663
		private CreatorController.PaintType paintType;

		// Token: 0x04000E50 RID: 3664
		private Color defaultButtonClr;

		// Token: 0x04000E51 RID: 3665
		private Dictionary<string, BaseScript> externalScriptFiles;

		// Token: 0x04000E52 RID: 3666
		private FileSystemWatcher watcher;

		// Token: 0x04000E53 RID: 3667
		private Color paintColor;

		// Token: 0x04000E54 RID: 3668
		private PartMaterial paintMaterial;

		// Token: 0x04000E55 RID: 3669
		private int userID;

		// Token: 0x04000E56 RID: 3670
		private int gameID;

		// Token: 0x04000E57 RID: 3671
		private static string saveLocation;

		// Token: 0x04000E58 RID: 3672
		private Vector3 mouseDownPosition;

		// Token: 0x04000E59 RID: 3673
		private string <CreatorToken>k__BackingField;

		// Token: 0x04000E5A RID: 3674
		private List<Instance> selectionQueue;

		// Token: 0x02000437 RID: 1079
		public enum PaintType
		{
			// Token: 0x0400121D RID: 4637
			None,
			// Token: 0x0400121E RID: 4638
			Color,
			// Token: 0x0400121F RID: 4639
			Material
		}

		// Token: 0x02000438 RID: 1080
		private struct ThumbnailImageTarget
		{
			// Token: 0x17000D18 RID: 3352
			// (get) Token: 0x06002D39 RID: 11577 RVA: 0x0001DBC9 File Offset: 0x0001BDC9
			// (set) Token: 0x06002D3A RID: 11578 RVA: 0x0001DBD1 File Offset: 0x0001BDD1
			public string Url
			{
				get
				{
					return this.<Url>k__BackingField;
				}
				set
				{
					this.<Url>k__BackingField = value;
				}
			}

			// Token: 0x17000D19 RID: 3353
			// (get) Token: 0x06002D3B RID: 11579 RVA: 0x0001DBDA File Offset: 0x0001BDDA
			// (set) Token: 0x06002D3C RID: 11580 RVA: 0x0001DBE2 File Offset: 0x0001BDE2
			public Image Target
			{
				get
				{
					return this.<Target>k__BackingField;
				}
				set
				{
					this.<Target>k__BackingField = value;
				}
			}

			// Token: 0x04001220 RID: 4640
			private string <Url>k__BackingField;

			// Token: 0x04001221 RID: 4641
			private Image <Target>k__BackingField;
		}

		// Token: 0x02000439 RID: 1081
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002D3F RID: 11583 RVA: 0x0001DBF5 File Offset: 0x0001BDF5
			internal bool <DoExportModel>b__57_0(Instance i)
			{
				return false;
			}

			// Token: 0x06002D40 RID: 11584 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
			internal char <TestGame>b__79_0(string s)
			{
				return '\0';
			}

			// Token: 0x06002D41 RID: 11585 RVA: 0x0001DBFB File Offset: 0x0001BDFB
			internal char <RandomString>b__82_0(string s)
			{
				return '\0';
			}

			// Token: 0x06002D42 RID: 11586 RVA: 0x0001DBFE File Offset: 0x0001BDFE
			internal GameObject <Update>b__96_0(Instance i)
			{
				return null;
			}

			// Token: 0x04001222 RID: 4642
			public static readonly CreatorController.<>c <>9;

			// Token: 0x04001223 RID: 4643
			public static Func<Instance, bool> <>9__57_0;

			// Token: 0x04001224 RID: 4644
			public static Func<string, char> <>9__79_0;

			// Token: 0x04001225 RID: 4645
			public static Func<string, char> <>9__82_0;

			// Token: 0x04001226 RID: 4646
			public static Func<Instance, GameObject> <>9__96_0;
		}

		// Token: 0x0200043A RID: 1082
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x06002D44 RID: 11588 RVA: 0x0001DC09 File Offset: 0x0001BE09
			internal void <Start>b__0()
			{
			}

			// Token: 0x04001227 RID: 4647
			public string mat;

			// Token: 0x04001228 RID: 4648
			public CreatorController <>4__this;
		}

		// Token: 0x0200043B RID: 1083
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06002D46 RID: 11590 RVA: 0x0001DC13 File Offset: 0x0001BE13
			internal bool <GroupSelection>b__0(Instance i)
			{
				return false;
			}

			// Token: 0x04001229 RID: 4649
			public int lowestLevel;
		}

		// Token: 0x0200043C RID: 1084
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x06002D48 RID: 11592 RVA: 0x0001DC1E File Offset: 0x0001BE1E
			internal bool <UngroupSelection>b__0(Instance i)
			{
				return false;
			}

			// Token: 0x0400122A RID: 4650
			public int lowestLevel;
		}

		// Token: 0x0200043D RID: 1085
		private sealed class <>c__DisplayClass68_0
		{
			// Token: 0x06002D4A RID: 11594 RVA: 0x0001DC29 File Offset: 0x0001BE29
			internal void <LoadStarterPlaces>b__0()
			{
			}

			// Token: 0x0400122B RID: 4651
			public JSONNode node;

			// Token: 0x0400122C RID: 4652
			public CreatorController <>4__this;
		}

		// Token: 0x0200043E RID: 1086
		private sealed class <>c__DisplayClass68_1
		{
			// Token: 0x06002D4C RID: 11596 RVA: 0x0001DC33 File Offset: 0x0001BE33
			internal void <LoadStarterPlaces>b__1()
			{
			}

			// Token: 0x0400122D RID: 4653
			public JSONNode node;

			// Token: 0x0400122E RID: 4654
			public CreatorController <>4__this;
		}

		// Token: 0x0200043F RID: 1087
		private sealed class <>c__DisplayClass74_0
		{
			// Token: 0x06002D4E RID: 11598 RVA: 0x0001DC3D File Offset: 0x0001BE3D
			internal void <DoPublish>b__0()
			{
			}

			// Token: 0x0400122F RID: 4655
			public JSONNode game;

			// Token: 0x04001230 RID: 4656
			public CreatorController <>4__this;
		}

		// Token: 0x02000440 RID: 1088
		private sealed class <>c__DisplayClass76_0
		{
			// Token: 0x06002D50 RID: 11600 RVA: 0x0001DC47 File Offset: 0x0001BE47
			internal void <SetPublishModalSelectedGame>b__0()
			{
			}

			// Token: 0x04001231 RID: 4657
			public CreatorController <>4__this;

			// Token: 0x04001232 RID: 4658
			public JSONNode game;
		}

		// Token: 0x02000441 RID: 1089
		private sealed class <AutoSaveLoop>d__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D51 RID: 11601 RVA: 0x0001DC49 File Offset: 0x0001BE49
			public <AutoSaveLoop>d__85(int <>1__state)
			{
			}

			// Token: 0x06002D52 RID: 11602 RVA: 0x0001DC51 File Offset: 0x0001BE51
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D53 RID: 11603 RVA: 0x0001DC53 File Offset: 0x0001BE53
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D1A RID: 3354
			// (get) Token: 0x06002D54 RID: 11604 RVA: 0x0001DC56 File Offset: 0x0001BE56
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D55 RID: 11605 RVA: 0x0001DC59 File Offset: 0x0001BE59
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D1B RID: 3355
			// (get) Token: 0x06002D56 RID: 11606 RVA: 0x0001DC5B File Offset: 0x0001BE5B
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001233 RID: 4659
			private int <>1__state;

			// Token: 0x04001234 RID: 4660
			private object <>2__current;

			// Token: 0x04001235 RID: 4661
			public CreatorController <>4__this;
		}

		// Token: 0x02000442 RID: 1090
		private sealed class <CheckToken>d__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D57 RID: 11607 RVA: 0x0001DC5E File Offset: 0x0001BE5E
			public <CheckToken>d__50(int <>1__state)
			{
			}

			// Token: 0x06002D58 RID: 11608 RVA: 0x0001DC66 File Offset: 0x0001BE66
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D59 RID: 11609 RVA: 0x0001DC68 File Offset: 0x0001BE68
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D5A RID: 11610 RVA: 0x0001DC6B File Offset: 0x0001BE6B
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D1C RID: 3356
			// (get) Token: 0x06002D5B RID: 11611 RVA: 0x0001DC6D File Offset: 0x0001BE6D
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D5C RID: 11612 RVA: 0x0001DC70 File Offset: 0x0001BE70
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D1D RID: 3357
			// (get) Token: 0x06002D5D RID: 11613 RVA: 0x0001DC72 File Offset: 0x0001BE72
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001236 RID: 4662
			private int <>1__state;

			// Token: 0x04001237 RID: 4663
			private object <>2__current;

			// Token: 0x04001238 RID: 4664
			public CreatorController <>4__this;

			// Token: 0x04001239 RID: 4665
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x02000443 RID: 1091
		private sealed class <DoPublish>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D5E RID: 11614 RVA: 0x0001DC75 File Offset: 0x0001BE75
			public <DoPublish>d__74(int <>1__state)
			{
			}

			// Token: 0x06002D5F RID: 11615 RVA: 0x0001DC7D File Offset: 0x0001BE7D
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D60 RID: 11616 RVA: 0x0001DC7F File Offset: 0x0001BE7F
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D61 RID: 11617 RVA: 0x0001DC82 File Offset: 0x0001BE82
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D1E RID: 3358
			// (get) Token: 0x06002D62 RID: 11618 RVA: 0x0001DC84 File Offset: 0x0001BE84
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D63 RID: 11619 RVA: 0x0001DC87 File Offset: 0x0001BE87
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D1F RID: 3359
			// (get) Token: 0x06002D64 RID: 11620 RVA: 0x0001DC89 File Offset: 0x0001BE89
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400123A RID: 4666
			private int <>1__state;

			// Token: 0x0400123B RID: 4667
			private object <>2__current;

			// Token: 0x0400123C RID: 4668
			public CreatorController <>4__this;

			// Token: 0x0400123D RID: 4669
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x02000444 RID: 1092
		private sealed class <DoPublishModel>d__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D65 RID: 11621 RVA: 0x0001DC8C File Offset: 0x0001BE8C
			public <DoPublishModel>d__62(int <>1__state)
			{
			}

			// Token: 0x06002D66 RID: 11622 RVA: 0x0001DC94 File Offset: 0x0001BE94
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D67 RID: 11623 RVA: 0x0001DC96 File Offset: 0x0001BE96
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D68 RID: 11624 RVA: 0x0001DC99 File Offset: 0x0001BE99
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002D69 RID: 11625 RVA: 0x0001DC9B File Offset: 0x0001BE9B
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000D20 RID: 3360
			// (get) Token: 0x06002D6A RID: 11626 RVA: 0x0001DC9D File Offset: 0x0001BE9D
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D6B RID: 11627 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x06002D6C RID: 11628 RVA: 0x0001DCA2 File Offset: 0x0001BEA2
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400123E RID: 4670
			private int <>1__state;

			// Token: 0x0400123F RID: 4671
			private object <>2__current;

			// Token: 0x04001240 RID: 4672
			public CreatorController <>4__this;

			// Token: 0x04001241 RID: 4673
			private List<Instance>.Enumerator <>7__wrap1;

			// Token: 0x04001242 RID: 4674
			private UnityWebRequest <uwr>5__3;
		}

		// Token: 0x02000445 RID: 1093
		private sealed class <LoadMapFromFile>d__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D6D RID: 11629 RVA: 0x0001DCA5 File Offset: 0x0001BEA5
			public <LoadMapFromFile>d__87(int <>1__state)
			{
			}

			// Token: 0x06002D6E RID: 11630 RVA: 0x0001DCAD File Offset: 0x0001BEAD
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D6F RID: 11631 RVA: 0x0001DCAF File Offset: 0x0001BEAF
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D22 RID: 3362
			// (get) Token: 0x06002D70 RID: 11632 RVA: 0x0001DCB2 File Offset: 0x0001BEB2
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D71 RID: 11633 RVA: 0x0001DCB5 File Offset: 0x0001BEB5
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x06002D72 RID: 11634 RVA: 0x0001DCB7 File Offset: 0x0001BEB7
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001243 RID: 4675
			private int <>1__state;

			// Token: 0x04001244 RID: 4676
			private object <>2__current;

			// Token: 0x04001245 RID: 4677
			public CreatorController <>4__this;

			// Token: 0x04001246 RID: 4678
			public string path;
		}

		// Token: 0x02000446 RID: 1094
		private sealed class <LoadStarterPlaces>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D73 RID: 11635 RVA: 0x0001DCBA File Offset: 0x0001BEBA
			public <LoadStarterPlaces>d__68(int <>1__state)
			{
			}

			// Token: 0x06002D74 RID: 11636 RVA: 0x0001DCC2 File Offset: 0x0001BEC2
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D75 RID: 11637 RVA: 0x0001DCC4 File Offset: 0x0001BEC4
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D76 RID: 11638 RVA: 0x0001DCC7 File Offset: 0x0001BEC7
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002D77 RID: 11639 RVA: 0x0001DCC9 File Offset: 0x0001BEC9
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000D24 RID: 3364
			// (get) Token: 0x06002D78 RID: 11640 RVA: 0x0001DCCB File Offset: 0x0001BECB
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D79 RID: 11641 RVA: 0x0001DCCE File Offset: 0x0001BECE
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D25 RID: 3365
			// (get) Token: 0x06002D7A RID: 11642 RVA: 0x0001DCD0 File Offset: 0x0001BED0
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001247 RID: 4679
			private int <>1__state;

			// Token: 0x04001248 RID: 4680
			private object <>2__current;

			// Token: 0x04001249 RID: 4681
			public CreatorController <>4__this;

			// Token: 0x0400124A RID: 4682
			private List<CreatorController.ThumbnailImageTarget> <images>5__2;

			// Token: 0x0400124B RID: 4683
			private RectTransform <template>5__3;

			// Token: 0x0400124C RID: 4684
			private UnityWebRequest <uwr>5__4;
		}

		// Token: 0x02000447 RID: 1095
		private sealed class <LoadThumbnailImage>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D7B RID: 11643 RVA: 0x0001DCD3 File Offset: 0x0001BED3
			public <LoadThumbnailImage>d__77(int <>1__state)
			{
			}

			// Token: 0x06002D7C RID: 11644 RVA: 0x0001DCDB File Offset: 0x0001BEDB
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D7D RID: 11645 RVA: 0x0001DCDD File Offset: 0x0001BEDD
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D7E RID: 11646 RVA: 0x0001DCE0 File Offset: 0x0001BEE0
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D26 RID: 3366
			// (get) Token: 0x06002D7F RID: 11647 RVA: 0x0001DCE2 File Offset: 0x0001BEE2
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D80 RID: 11648 RVA: 0x0001DCE5 File Offset: 0x0001BEE5
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D27 RID: 3367
			// (get) Token: 0x06002D81 RID: 11649 RVA: 0x0001DCE7 File Offset: 0x0001BEE7
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400124D RID: 4685
			private int <>1__state;

			// Token: 0x0400124E RID: 4686
			private object <>2__current;

			// Token: 0x0400124F RID: 4687
			public string src;

			// Token: 0x04001250 RID: 4688
			public Image target;

			// Token: 0x04001251 RID: 4689
			private UnityWebRequest <twr>5__2;
		}

		// Token: 0x02000448 RID: 1096
		private sealed class <LoadThumbnailImages>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D82 RID: 11650 RVA: 0x0001DCEA File Offset: 0x0001BEEA
			public <LoadThumbnailImages>d__75(int <>1__state)
			{
			}

			// Token: 0x06002D83 RID: 11651 RVA: 0x0001DCF2 File Offset: 0x0001BEF2
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D84 RID: 11652 RVA: 0x0001DCF4 File Offset: 0x0001BEF4
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D85 RID: 11653 RVA: 0x0001DCF7 File Offset: 0x0001BEF7
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002D86 RID: 11654 RVA: 0x0001DCF9 File Offset: 0x0001BEF9
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000D28 RID: 3368
			// (get) Token: 0x06002D87 RID: 11655 RVA: 0x0001DCFB File Offset: 0x0001BEFB
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D88 RID: 11656 RVA: 0x0001DCFE File Offset: 0x0001BEFE
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D29 RID: 3369
			// (get) Token: 0x06002D89 RID: 11657 RVA: 0x0001DD00 File Offset: 0x0001BF00
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001252 RID: 4690
			private int <>1__state;

			// Token: 0x04001253 RID: 4691
			private object <>2__current;

			// Token: 0x04001254 RID: 4692
			public List<CreatorController.ThumbnailImageTarget> thumbnails;

			// Token: 0x04001255 RID: 4693
			private List<CreatorController.ThumbnailImageTarget>.Enumerator <>7__wrap1;

			// Token: 0x04001256 RID: 4694
			private Image <target>5__3;

			// Token: 0x04001257 RID: 4695
			private UnityWebRequest <twr>5__4;
		}

		// Token: 0x02000449 RID: 1097
		private sealed class <PublishLevelToID>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D8A RID: 11658 RVA: 0x0001DD03 File Offset: 0x0001BF03
			public <PublishLevelToID>d__81(int <>1__state)
			{
			}

			// Token: 0x06002D8B RID: 11659 RVA: 0x0001DD0B File Offset: 0x0001BF0B
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D8C RID: 11660 RVA: 0x0001DD0D File Offset: 0x0001BF0D
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D8D RID: 11661 RVA: 0x0001DD10 File Offset: 0x0001BF10
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D2A RID: 3370
			// (get) Token: 0x06002D8E RID: 11662 RVA: 0x0001DD12 File Offset: 0x0001BF12
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D8F RID: 11663 RVA: 0x0001DD15 File Offset: 0x0001BF15
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D2B RID: 3371
			// (get) Token: 0x06002D90 RID: 11664 RVA: 0x0001DD17 File Offset: 0x0001BF17
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001258 RID: 4696
			private int <>1__state;

			// Token: 0x04001259 RID: 4697
			private object <>2__current;

			// Token: 0x0400125A RID: 4698
			public CreatorController <>4__this;

			// Token: 0x0400125B RID: 4699
			public int id;

			// Token: 0x0400125C RID: 4700
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x0200044A RID: 1098
		private sealed class <ShowExportGLTFDialog>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D91 RID: 11665 RVA: 0x0001DD1A File Offset: 0x0001BF1A
			public <ShowExportGLTFDialog>d__59(int <>1__state)
			{
			}

			// Token: 0x06002D92 RID: 11666 RVA: 0x0001DD22 File Offset: 0x0001BF22
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D93 RID: 11667 RVA: 0x0001DD24 File Offset: 0x0001BF24
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D2C RID: 3372
			// (get) Token: 0x06002D94 RID: 11668 RVA: 0x0001DD27 File Offset: 0x0001BF27
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D95 RID: 11669 RVA: 0x0001DD2A File Offset: 0x0001BF2A
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D2D RID: 3373
			// (get) Token: 0x06002D96 RID: 11670 RVA: 0x0001DD2C File Offset: 0x0001BF2C
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400125D RID: 4701
			private int <>1__state;

			// Token: 0x0400125E RID: 4702
			private object <>2__current;
		}

		// Token: 0x0200044B RID: 1099
		private sealed class <ShowExportModelDialog>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D97 RID: 11671 RVA: 0x0001DD2F File Offset: 0x0001BF2F
			public <ShowExportModelDialog>d__56(int <>1__state)
			{
			}

			// Token: 0x06002D98 RID: 11672 RVA: 0x0001DD37 File Offset: 0x0001BF37
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D99 RID: 11673 RVA: 0x0001DD39 File Offset: 0x0001BF39
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D2E RID: 3374
			// (get) Token: 0x06002D9A RID: 11674 RVA: 0x0001DD3C File Offset: 0x0001BF3C
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D9B RID: 11675 RVA: 0x0001DD3F File Offset: 0x0001BF3F
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D2F RID: 3375
			// (get) Token: 0x06002D9C RID: 11676 RVA: 0x0001DD41 File Offset: 0x0001BF41
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400125F RID: 4703
			private int <>1__state;

			// Token: 0x04001260 RID: 4704
			private object <>2__current;
		}

		// Token: 0x0200044C RID: 1100
		private sealed class <ShowImportModelDialog>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D9D RID: 11677 RVA: 0x0001DD44 File Offset: 0x0001BF44
			public <ShowImportModelDialog>d__64(int <>1__state)
			{
			}

			// Token: 0x06002D9E RID: 11678 RVA: 0x0001DD4C File Offset: 0x0001BF4C
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D9F RID: 11679 RVA: 0x0001DD4E File Offset: 0x0001BF4E
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D30 RID: 3376
			// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x0001DD51 File Offset: 0x0001BF51
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002DA1 RID: 11681 RVA: 0x0001DD54 File Offset: 0x0001BF54
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D31 RID: 3377
			// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x0001DD56 File Offset: 0x0001BF56
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001261 RID: 4705
			private int <>1__state;

			// Token: 0x04001262 RID: 4706
			private object <>2__current;
		}

		// Token: 0x0200044D RID: 1101
		private sealed class <ShowOpenDialog>d__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002DA3 RID: 11683 RVA: 0x0001DD59 File Offset: 0x0001BF59
			public <ShowOpenDialog>d__84(int <>1__state)
			{
			}

			// Token: 0x06002DA4 RID: 11684 RVA: 0x0001DD61 File Offset: 0x0001BF61
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002DA5 RID: 11685 RVA: 0x0001DD63 File Offset: 0x0001BF63
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D32 RID: 3378
			// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x0001DD66 File Offset: 0x0001BF66
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002DA7 RID: 11687 RVA: 0x0001DD69 File Offset: 0x0001BF69
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D33 RID: 3379
			// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x0001DD6B File Offset: 0x0001BF6B
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001263 RID: 4707
			private int <>1__state;

			// Token: 0x04001264 RID: 4708
			private object <>2__current;
		}

		// Token: 0x0200044E RID: 1102
		private sealed class <ShowSaveDialog>d__89 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002DA9 RID: 11689 RVA: 0x0001DD6E File Offset: 0x0001BF6E
			public <ShowSaveDialog>d__89(int <>1__state)
			{
			}

			// Token: 0x06002DAA RID: 11690 RVA: 0x0001DD76 File Offset: 0x0001BF76
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002DAB RID: 11691 RVA: 0x0001DD78 File Offset: 0x0001BF78
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D34 RID: 3380
			// (get) Token: 0x06002DAC RID: 11692 RVA: 0x0001DD7B File Offset: 0x0001BF7B
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002DAD RID: 11693 RVA: 0x0001DD7E File Offset: 0x0001BF7E
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D35 RID: 3381
			// (get) Token: 0x06002DAE RID: 11694 RVA: 0x0001DD80 File Offset: 0x0001BF80
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001265 RID: 4709
			private int <>1__state;

			// Token: 0x04001266 RID: 4710
			private object <>2__current;
		}
	}
}
