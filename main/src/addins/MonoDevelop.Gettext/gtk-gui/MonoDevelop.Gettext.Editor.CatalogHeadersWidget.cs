
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Gettext.Editor
{
	internal partial class CatalogHeadersWidget
	{
		private global::Gtk.Notebook notebook1;

		private global::Gtk.Table table1;

		private global::Gtk.Entry entryBugzilla;

		private global::Gtk.Entry entryProjectName;

		private global::Gtk.Entry entryProjectVersion;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::Gtk.Label labelPoLastModification;

		private global::Gtk.Label labelPotCreation;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TextView textviewComments;

		private global::Gtk.Label label3;

		private global::Gtk.Table table2;

		private global::Gtk.ComboBoxEntry comboboxentryCharset;

		private global::Gtk.Entry entryLanguageGroupEmail;

		private global::Gtk.Entry entryLanguageGroupName;

		private global::Gtk.Entry entryTranslatorEmail;

		private global::Gtk.Entry entryTranslatorName;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Entry entryPluralsForms;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label14;

		private global::Gtk.Label label15;

		private global::Gtk.Label label2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Gettext.Editor.CatalogHeadersWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Gettext.Editor.CatalogHeadersWidget";
			// Container child MonoDevelop.Gettext.Editor.CatalogHeadersWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			this.notebook1.TabPos = ((global::Gtk.PositionType)(0));
			this.notebook1.BorderWidth = ((uint)(8));
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table1 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(8));
			// Container child table1.Gtk.Table+TableChild
			this.entryBugzilla = new global::Gtk.Entry ();
			this.entryBugzilla.CanFocus = true;
			this.entryBugzilla.Name = "entryBugzilla";
			this.entryBugzilla.IsEditable = true;
			this.entryBugzilla.InvisibleChar = '●';
			this.table1.Add (this.entryBugzilla);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.entryBugzilla]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryProjectName = new global::Gtk.Entry ();
			this.entryProjectName.CanFocus = true;
			this.entryProjectName.Name = "entryProjectName";
			this.entryProjectName.IsEditable = true;
			this.entryProjectName.InvisibleChar = '●';
			this.table1.Add (this.entryProjectName);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.entryProjectName]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryProjectVersion = new global::Gtk.Entry ();
			this.entryProjectVersion.CanFocus = true;
			this.entryProjectVersion.Name = "entryProjectVersion";
			this.entryProjectVersion.IsEditable = true;
			this.entryProjectVersion.InvisibleChar = '●';
			this.table1.Add (this.entryProjectVersion);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.entryProjectVersion]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0f;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Last modification:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0f;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("_Comments:");
			this.label5.UseUnderline = true;
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0f;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("_Project name:");
			this.label6.UseUnderline = true;
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("P_roject version:");
			this.label7.UseUnderline = true;
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0f;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("_Bugzilla URL:");
			this.label8.UseUnderline = true;
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label8]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0f;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Creation date:");
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.label9]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPoLastModification = new global::Gtk.Label ();
			this.labelPoLastModification.Name = "labelPoLastModification";
			this.labelPoLastModification.Xalign = 0f;
			this.labelPoLastModification.UseMarkup = true;
			this.table1.Add (this.labelPoLastModification);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.labelPoLastModification]));
			w10.TopAttach = ((uint)(5));
			w10.BottomAttach = ((uint)(6));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPotCreation = new global::Gtk.Label ();
			this.labelPotCreation.Name = "labelPotCreation";
			this.labelPotCreation.Xalign = 0f;
			this.labelPotCreation.UseMarkup = true;
			this.table1.Add (this.labelPotCreation);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.labelPotCreation]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.textviewComments = new global::Gtk.TextView ();
			this.textviewComments.HeightRequest = 180;
			this.textviewComments.CanFocus = true;
			this.textviewComments.Name = "textviewComments";
			this.scrolledwindow1.Add (this.textviewComments);
			this.table1.Add (this.scrolledwindow1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.scrolledwindow1]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.table1);
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Project settings");
			this.notebook1.SetTabLabel (this.table1, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table2 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			this.table2.BorderWidth = ((uint)(8));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxentryCharset = new global::Gtk.ComboBoxEntry ();
			this.comboboxentryCharset.Name = "comboboxentryCharset";
			this.table2.Add (this.comboboxentryCharset);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2[this.comboboxentryCharset]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryLanguageGroupEmail = new global::Gtk.Entry ();
			this.entryLanguageGroupEmail.CanFocus = true;
			this.entryLanguageGroupEmail.Name = "entryLanguageGroupEmail";
			this.entryLanguageGroupEmail.IsEditable = true;
			this.entryLanguageGroupEmail.InvisibleChar = '●';
			this.table2.Add (this.entryLanguageGroupEmail);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.entryLanguageGroupEmail]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryLanguageGroupName = new global::Gtk.Entry ();
			this.entryLanguageGroupName.CanFocus = true;
			this.entryLanguageGroupName.Name = "entryLanguageGroupName";
			this.entryLanguageGroupName.IsEditable = true;
			this.entryLanguageGroupName.InvisibleChar = '●';
			this.table2.Add (this.entryLanguageGroupName);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.entryLanguageGroupName]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryTranslatorEmail = new global::Gtk.Entry ();
			this.entryTranslatorEmail.CanFocus = true;
			this.entryTranslatorEmail.Name = "entryTranslatorEmail";
			this.entryTranslatorEmail.IsEditable = true;
			this.entryTranslatorEmail.InvisibleChar = '●';
			this.table2.Add (this.entryTranslatorEmail);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2[this.entryTranslatorEmail]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryTranslatorName = new global::Gtk.Entry ();
			this.entryTranslatorName.CanFocus = true;
			this.entryTranslatorName.Name = "entryTranslatorName";
			this.entryTranslatorName.IsEditable = true;
			this.entryTranslatorName.InvisibleChar = '●';
			this.table2.Add (this.entryTranslatorName);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.entryTranslatorName]));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 4;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryPluralsForms = new global::Gtk.Entry ();
			this.entryPluralsForms.CanFocus = true;
			this.entryPluralsForms.Name = "entryPluralsForms";
			this.entryPluralsForms.IsEditable = true;
			this.entryPluralsForms.InvisibleChar = '●';
			this.hbox2.Add (this.entryPluralsForms);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryPluralsForms]));
			w20.Position = 0;
			this.table2.Add (this.hbox2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2[this.hbox2]));
			w21.TopAttach = ((uint)(5));
			w21.BottomAttach = ((uint)(6));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 0f;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("_Translator name:");
			this.label10.UseUnderline = true;
			this.table2.Add (this.label10);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.label10]));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 0f;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("T_ranslator e-mail:");
			this.label11.UseUnderline = true;
			this.table2.Add (this.label11);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2[this.label11]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 0f;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("_Language group:");
			this.label12.UseUnderline = true;
			this.table2.Add (this.label12);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2[this.label12]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0f;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("L_anguage group e-mail:");
			this.label13.UseUnderline = true;
			this.table2.Add (this.label13);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2[this.label13]));
			w25.TopAttach = ((uint)(3));
			w25.BottomAttach = ((uint)(4));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.Xalign = 0f;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("_Charset:");
			this.label14.UseUnderline = true;
			this.table2.Add (this.label14);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2[this.label14]));
			w26.TopAttach = ((uint)(4));
			w26.BottomAttach = ((uint)(5));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 0f;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("_Plural forms:");
			this.label15.UseUnderline = true;
			this.table2.Add (this.label15);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2[this.label15]));
			w27.TopAttach = ((uint)(5));
			w27.BottomAttach = ((uint)(6));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.table2);
			global::Gtk.Notebook.NotebookChild w28 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.table2]));
			w28.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Language settings");
			this.notebook1.SetTabLabel (this.table2, this.label2);
			this.label2.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.label5.MnemonicWidget = this.textviewComments;
			this.label6.MnemonicWidget = this.entryProjectName;
			this.label7.MnemonicWidget = this.entryProjectVersion;
			this.label8.MnemonicWidget = this.entryBugzilla;
			this.label10.MnemonicWidget = this.entryTranslatorName;
			this.label11.MnemonicWidget = this.entryTranslatorEmail;
			this.label12.MnemonicWidget = this.entryLanguageGroupName;
			this.label13.MnemonicWidget = this.entryLanguageGroupEmail;
			this.label15.MnemonicWidget = this.entryPluralsForms;
			this.Show ();
			this.entryProjectVersion.Changed += new global::System.EventHandler (this.OnHeaderChanged);
			this.entryProjectName.Changed += new global::System.EventHandler (this.OnHeaderChanged);
			this.entryBugzilla.Changed += new global::System.EventHandler (this.OnHeaderChanged);
			this.entryPluralsForms.Changed += new global::System.EventHandler (this.OnHeaderChanged);
			this.entryTranslatorName.Changed += new global::System.EventHandler (this.OnHeaderChanged);
			this.entryTranslatorEmail.Changed += new global::System.EventHandler (this.OnHeaderChanged);
			this.entryLanguageGroupName.Changed += new global::System.EventHandler (this.OnHeaderChanged);
			this.entryLanguageGroupEmail.Changed += new global::System.EventHandler (this.OnHeaderChanged);
		}
	}
}
