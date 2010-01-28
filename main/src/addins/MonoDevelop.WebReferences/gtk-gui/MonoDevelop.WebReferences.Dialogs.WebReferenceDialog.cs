
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.WebReferences.Dialogs
{
	internal partial class WebReferenceDialog
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action btnBack;

		private global::Gtk.Action btnNext;

		private global::Gtk.Action btnRefresh;

		private global::Gtk.Action btnStop;

		private global::Gtk.Action btnHome;

		private global::Gtk.VBox vbxContainer;

		private global::Gtk.Toolbar tlbNavigate;

		private global::Gtk.Table tblWebReferenceUrl;

		private global::Gtk.Button btnGO;

		private global::Gtk.Label lblWebServiceUrl;

		private global::Gtk.Entry tbxReferenceURL;

		private global::Gtk.Frame frmBrowser;

		private global::Gtk.Table tblReferenceName;

		private global::Gtk.Label lblNamespace;

		private global::Gtk.Label lblReference;

		private global::Gtk.Entry tbxNamespace;

		private global::Gtk.Entry tbxReferenceName;

		private global::Gtk.Button btnCancel;

		private global::Gtk.Button btnOK;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.WebReferences.Dialogs.WebReferenceDialog
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.btnBack = new global::Gtk.Action ("btnBack", null, global::Mono.Unix.Catalog.GetString ("Go back one page"), "gtk-go-back");
			w1.Add (this.btnBack, null);
			this.btnNext = new global::Gtk.Action ("btnNext", null, global::Mono.Unix.Catalog.GetString ("Go forward one page"), "gtk-go-forward");
			w1.Add (this.btnNext, null);
			this.btnRefresh = new global::Gtk.Action ("btnRefresh", null, global::Mono.Unix.Catalog.GetString ("Reload current page"), "gtk-refresh");
			w1.Add (this.btnRefresh, null);
			this.btnStop = new global::Gtk.Action ("btnStop", null, global::Mono.Unix.Catalog.GetString ("Stop loading this page"), "gtk-stop");
			w1.Add (this.btnStop, null);
			this.btnHome = new global::Gtk.Action ("btnHome", null, global::Mono.Unix.Catalog.GetString ("Go back to the home page"), "gtk-home");
			w1.Add (this.btnHome, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "MonoDevelop.WebReferences.Dialogs.WebReferenceDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Add Web Reference");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("WebReference.Service.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.WebReferences.Dialogs.WebReferenceDialog.VBox
			global::Gtk.VBox w2 = this.VBox;
			w2.Events = ((global::Gdk.EventMask)(256));
			w2.Name = "dlgWindow";
			w2.BorderWidth = ((uint)(2));
			// Container child dlgWindow.Gtk.Box+BoxChild
			this.vbxContainer = new global::Gtk.VBox ();
			this.vbxContainer.Name = "vbxContainer";
			// Container child vbxContainer.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='tlbNavigate'><toolitem name='btnBack' action='btnBack'/><toolitem name='btnNext' action='btnNext'/><toolitem name='btnRefresh' action='btnRefresh'/><toolitem name='btnStop' action='btnStop'/><toolitem name='btnHome' action='btnHome'/></toolbar></ui>");
			this.tlbNavigate = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/tlbNavigate")));
			this.tlbNavigate.Name = "tlbNavigate";
			this.tlbNavigate.ShowArrow = false;
			this.tlbNavigate.ToolbarStyle = ((global::Gtk.ToolbarStyle)(0));
			this.tlbNavigate.IconSize = ((global::Gtk.IconSize)(2));
			this.vbxContainer.Add (this.tlbNavigate);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbxContainer[this.tlbNavigate]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbxContainer.Gtk.Box+BoxChild
			this.tblWebReferenceUrl = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.tblWebReferenceUrl.Name = "tblWebReferenceUrl";
			this.tblWebReferenceUrl.RowSpacing = ((uint)(6));
			this.tblWebReferenceUrl.ColumnSpacing = ((uint)(6));
			// Container child tblWebReferenceUrl.Gtk.Table+TableChild
			this.btnGO = new global::Gtk.Button ();
			this.btnGO.CanFocus = true;
			this.btnGO.Name = "btnGO";
			this.btnGO.UseStock = true;
			this.btnGO.UseUnderline = true;
			this.btnGO.Label = "gtk-jump-to";
			this.tblWebReferenceUrl.Add (this.btnGO);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tblWebReferenceUrl[this.btnGO]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XPadding = ((uint)(4));
			w4.YPadding = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(0));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblWebReferenceUrl.Gtk.Table+TableChild
			this.lblWebServiceUrl = new global::Gtk.Label ();
			this.lblWebServiceUrl.Name = "lblWebServiceUrl";
			this.lblWebServiceUrl.Xalign = 0f;
			this.lblWebServiceUrl.LabelProp = global::Mono.Unix.Catalog.GetString ("Web Service Url: ");
			this.tblWebReferenceUrl.Add (this.lblWebServiceUrl);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tblWebReferenceUrl[this.lblWebServiceUrl]));
			w5.XPadding = ((uint)(4));
			w5.YPadding = ((uint)(4));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblWebReferenceUrl.Gtk.Table+TableChild
			this.tbxReferenceURL = new global::Gtk.Entry ();
			this.tbxReferenceURL.CanFocus = true;
			this.tbxReferenceURL.Name = "tbxReferenceURL";
			this.tbxReferenceURL.IsEditable = true;
			this.tbxReferenceURL.InvisibleChar = '●';
			this.tblWebReferenceUrl.Add (this.tbxReferenceURL);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tblWebReferenceUrl[this.tbxReferenceURL]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbxContainer.Add (this.tblWebReferenceUrl);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbxContainer[this.tblWebReferenceUrl]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbxContainer.Gtk.Box+BoxChild
			this.frmBrowser = new global::Gtk.Frame ();
			this.frmBrowser.Name = "frmBrowser";
			this.frmBrowser.ShadowType = ((global::Gtk.ShadowType)(0));
			this.frmBrowser.LabelYalign = 0f;
			this.vbxContainer.Add (this.frmBrowser);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbxContainer[this.frmBrowser]));
			w8.Position = 2;
			// Container child vbxContainer.Gtk.Box+BoxChild
			this.tblReferenceName = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.tblReferenceName.Name = "tblReferenceName";
			this.tblReferenceName.RowSpacing = ((uint)(4));
			this.tblReferenceName.ColumnSpacing = ((uint)(4));
			this.tblReferenceName.BorderWidth = ((uint)(9));
			// Container child tblReferenceName.Gtk.Table+TableChild
			this.lblNamespace = new global::Gtk.Label ();
			this.lblNamespace.Name = "lblNamespace";
			this.lblNamespace.Xalign = 0f;
			this.lblNamespace.LabelProp = global::Mono.Unix.Catalog.GetString ("Namespace: ");
			this.tblReferenceName.Add (this.lblNamespace);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tblReferenceName[this.lblNamespace]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblReferenceName.Gtk.Table+TableChild
			this.lblReference = new global::Gtk.Label ();
			this.lblReference.Name = "lblReference";
			this.lblReference.Xalign = 0f;
			this.lblReference.LabelProp = global::Mono.Unix.Catalog.GetString ("Reference: ");
			this.tblReferenceName.Add (this.lblReference);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tblReferenceName[this.lblReference]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblReferenceName.Gtk.Table+TableChild
			this.tbxNamespace = new global::Gtk.Entry ();
			this.tbxNamespace.Sensitive = false;
			this.tbxNamespace.CanFocus = true;
			this.tbxNamespace.Name = "tbxNamespace";
			this.tbxNamespace.IsEditable = true;
			this.tbxNamespace.InvisibleChar = '●';
			this.tblReferenceName.Add (this.tbxNamespace);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tblReferenceName[this.tbxNamespace]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblReferenceName.Gtk.Table+TableChild
			this.tbxReferenceName = new global::Gtk.Entry ();
			this.tbxReferenceName.CanFocus = true;
			this.tbxReferenceName.Name = "tbxReferenceName";
			this.tbxReferenceName.IsEditable = true;
			this.tbxReferenceName.InvisibleChar = '●';
			this.tblReferenceName.Add (this.tbxReferenceName);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tblReferenceName[this.tbxReferenceName]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbxContainer.Add (this.tblReferenceName);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbxContainer[this.tblReferenceName]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			w2.Add (this.vbxContainer);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(w2[this.vbxContainer]));
			w14.Position = 0;
			// Internal child MonoDevelop.WebReferences.Dialogs.WebReferenceDialog.ActionArea
			global::Gtk.HButtonBox w15 = this.ActionArea;
			w15.Events = ((global::Gdk.EventMask)(256));
			w15.Name = "pnlActionArea";
			w15.Spacing = 6;
			w15.BorderWidth = ((uint)(5));
			w15.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child pnlActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnCancel = new global::Gtk.Button ();
			this.btnCancel.CanDefault = true;
			this.btnCancel.CanFocus = true;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseStock = true;
			this.btnCancel.UseUnderline = true;
			this.btnCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.btnCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15[this.btnCancel]));
			w16.Expand = false;
			w16.Fill = false;
			// Container child pnlActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnOK = new global::Gtk.Button ();
			this.btnOK.CanDefault = true;
			this.btnOK.CanFocus = true;
			this.btnOK.Name = "btnOK";
			this.btnOK.UseStock = true;
			this.btnOK.UseUnderline = true;
			this.btnOK.Label = "gtk-ok";
			this.AddActionWidget (this.btnOK, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15[this.btnOK]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 639;
			this.DefaultHeight = 472;
			this.Show ();
			this.btnBack.Activated += new global::System.EventHandler (this.Browser_BackButtonClicked);
			this.btnNext.Activated += new global::System.EventHandler (this.Browser_NextButtonClicked);
			this.btnRefresh.Activated += new global::System.EventHandler (this.Browser_RefreshButtonClicked);
			this.btnStop.Activated += new global::System.EventHandler (this.Browser_StopButtonClicked);
			this.btnHome.Activated += new global::System.EventHandler (this.Browser_HomeButtonClicked);
			this.tbxReferenceURL.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.Browser_URLKeyReleased);
			this.btnGO.Clicked += new global::System.EventHandler (this.Browser_GoButtonClicked);
		}
	}
}
