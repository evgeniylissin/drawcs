// Decompiled with JetBrains decompiler
// Type: Draw.MainForm
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Draw
{
	public class MainForm : Form
	{
		private IContainer components = (IContainer)null;
		private Competition competition = new Competition();
		private List<Team> teams = new List<Team>();
		private MenuStrip menuStrip1;
		private ToolStripMenuItem competitionToolStripCompetition;
		private ToolStripMenuItem newToolStripCompetitionNew;
		private ToolStripMenuItem openToolStripCompetitionOpen;
		private ToolStripMenuItem saveToolStripCompetitionSave;
		private Label labelPlaceLabel;
		private Label labelPlaceValue;
		private Label labelDate;
		private Label labelDateValue;
		private Label labelReferee;
		private Label labelRefereeValue;
		private Label labelCompetitionName;
		private SplitContainer splitContainerMain;
		private ToolStripMenuItem toolStripMenuCompetitionEdit;
		private ToolStripMenuItem applicationToolStripApplication;
		private ToolStripMenuItem applicationToolStripApplicationNew;
		private ListBox listBoxTeams;
		private TabControl tabControlCategories;
		private ToolStripMenuItem categoriesToolStripCategories;
		private ToolStripMenuItem categoriesToolStripCategoriesAdd;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.menuStrip1 = new MenuStrip();
			this.competitionToolStripCompetition = new ToolStripMenuItem();
			this.newToolStripCompetitionNew = new ToolStripMenuItem();
			this.openToolStripCompetitionOpen = new ToolStripMenuItem();
			this.toolStripMenuCompetitionEdit = new ToolStripMenuItem();
			this.saveToolStripCompetitionSave = new ToolStripMenuItem();
			this.applicationToolStripApplication = new ToolStripMenuItem();
			this.applicationToolStripApplicationNew = new ToolStripMenuItem();
			this.categoriesToolStripCategories = new ToolStripMenuItem();
			this.categoriesToolStripCategoriesAdd = new ToolStripMenuItem();
			this.labelPlaceLabel = new Label();
			this.labelPlaceValue = new Label();
			this.labelDate = new Label();
			this.labelDateValue = new Label();
			this.labelReferee = new Label();
			this.labelRefereeValue = new Label();
			this.labelCompetitionName = new Label();
			this.splitContainerMain = new SplitContainer();
			this.listBoxTeams = new ListBox();
			this.tabControlCategories = new TabControl();
			this.menuStrip1.SuspendLayout();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.SuspendLayout();
			this.menuStrip1.Items.AddRange(new ToolStripItem[3]
			{
		(ToolStripItem) this.competitionToolStripCompetition,
		(ToolStripItem) this.applicationToolStripApplication,
		(ToolStripItem) this.categoriesToolStripCategories
			});
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(646, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStripMain";
			this.competitionToolStripCompetition.DropDownItems.AddRange(new ToolStripItem[4]
			{
		(ToolStripItem) this.newToolStripCompetitionNew,
		(ToolStripItem) this.openToolStripCompetitionOpen,
		(ToolStripItem) this.toolStripMenuCompetitionEdit,
		(ToolStripItem) this.saveToolStripCompetitionSave
			});
			this.competitionToolStripCompetition.Name = "competitionToolStripCompetition";
			this.competitionToolStripCompetition.Size = new Size(66, 20);
			this.competitionToolStripCompetition.Text = "Змагання";
			this.newToolStripCompetitionNew.Name = "newToolStripCompetitionNew";
			this.newToolStripCompetitionNew.Size = new Size(134, 22);
			this.newToolStripCompetitionNew.Text = "Нове";
			this.newToolStripCompetitionNew.Click += new EventHandler(this.newToolStripCompetitionNew_Click);
			this.openToolStripCompetitionOpen.Name = "openToolStripCompetitionOpen";
			this.openToolStripCompetitionOpen.Size = new Size(134, 22);
			this.openToolStripCompetitionOpen.Text = "Відкрити";
			this.openToolStripCompetitionOpen.Click += new EventHandler(this.openToolStripCompetitionOpen_Click);
			this.toolStripMenuCompetitionEdit.Enabled = false;
			this.toolStripMenuCompetitionEdit.Name = "toolStripMenuCompetitionEdit";
			this.toolStripMenuCompetitionEdit.Size = new Size(134, 22);
			this.toolStripMenuCompetitionEdit.Text = "Редагувати";
			this.toolStripMenuCompetitionEdit.Click += new EventHandler(this.toolStripMenuCompetitionEdit_Click);
			this.saveToolStripCompetitionSave.Enabled = false;
			this.saveToolStripCompetitionSave.Name = "saveToolStripCompetitionSave";
			this.saveToolStripCompetitionSave.Size = new Size(134, 22);
			this.saveToolStripCompetitionSave.Text = "Зберегти";
			this.saveToolStripCompetitionSave.Click += new EventHandler(this.saveToolStripCompetitionSave_Click);
			this.applicationToolStripApplication.DropDownItems.AddRange(new ToolStripItem[1]
			{
		(ToolStripItem) this.applicationToolStripApplicationNew
			});
			this.applicationToolStripApplication.Enabled = false;
			this.applicationToolStripApplication.Name = "applicationToolStripApplication";
			this.applicationToolStripApplication.Size = new Size(55, 20);
			this.applicationToolStripApplication.Text = "Заявки";
			this.applicationToolStripApplicationNew.Name = "applicationToolStripApplicationNew";
			this.applicationToolStripApplicationNew.Size = new Size(152, 22);
			this.applicationToolStripApplicationNew.Text = "Нова";
			this.applicationToolStripApplicationNew.Click += new EventHandler(this.applicationToolStripApplicationNew_Click);
			this.categoriesToolStripCategories.DropDownItems.AddRange(new ToolStripItem[1]
			{
		(ToolStripItem) this.categoriesToolStripCategoriesAdd
			});
			this.categoriesToolStripCategories.Enabled = false;
			this.categoriesToolStripCategories.Name = "categoriesToolStripCategories";
			this.categoriesToolStripCategories.Size = new Size(65, 20);
			this.categoriesToolStripCategories.Text = "Категорії";
			this.categoriesToolStripCategoriesAdd.Name = "categoriesToolStripCategoriesAdd";
			this.categoriesToolStripCategoriesAdd.Size = new Size(99, 22);
			this.categoriesToolStripCategoriesAdd.Text = "Нова";
			this.categoriesToolStripCategoriesAdd.Click += new EventHandler(this.categoriesToolStripCategoriesAdd_Click);
			this.labelPlaceLabel.AutoSize = true;
			this.labelPlaceLabel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.labelPlaceLabel.Location = new Point(20, 64);
			this.labelPlaceLabel.Name = "labelPlaceLabel";
			this.labelPlaceLabel.Size = new Size(117, 15);
			this.labelPlaceLabel.TabIndex = 1;
			this.labelPlaceLabel.Text = "Місце проведення:";
			this.labelPlaceValue.AutoSize = true;
			this.labelPlaceValue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.labelPlaceValue.Location = new Point(138, 63);
			this.labelPlaceValue.Name = "labelPlaceValue";
			this.labelPlaceValue.Size = new Size(0, 16);
			this.labelPlaceValue.TabIndex = 2;
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.labelDate.Location = new Point(97, 95);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new Size(40, 15);
			this.labelDate.TabIndex = 3;
			this.labelDate.Text = "Дата:";
			this.labelDateValue.AutoSize = true;
			this.labelDateValue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.labelDateValue.Location = new Point(138, 94);
			this.labelDateValue.Name = "labelDateValue";
			this.labelDateValue.Size = new Size(0, 16);
			this.labelDateValue.TabIndex = 4;
			this.labelReferee.AutoSize = true;
			this.labelReferee.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.labelReferee.Location = new Point(36, 126);
			this.labelReferee.Name = "labelReferee";
			this.labelReferee.Size = new Size(101, 15);
			this.labelReferee.TabIndex = 5;
			this.labelReferee.Text = "Головний суддя:";
			this.labelRefereeValue.AutoSize = true;
			this.labelRefereeValue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.labelRefereeValue.Location = new Point(138, 125);
			this.labelRefereeValue.Name = "labelRefereeValue";
			this.labelRefereeValue.Size = new Size(0, 16);
			this.labelRefereeValue.TabIndex = 6;
			this.labelCompetitionName.AutoSize = true;
			this.labelCompetitionName.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.labelCompetitionName.Location = new Point(13, 28);
			this.labelCompetitionName.Name = "labelCompetitionName";
			this.labelCompetitionName.Size = new Size(0, 24);
			this.labelCompetitionName.TabIndex = 7;
			this.splitContainerMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.splitContainerMain.Location = new Point(16, 145);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Panel1.Controls.Add((Control)this.listBoxTeams);
			this.splitContainerMain.Panel2.Controls.Add((Control)this.tabControlCategories);
			this.splitContainerMain.Size = new Size(618, 293);
			this.splitContainerMain.SplitterDistance = 206;
			this.splitContainerMain.TabIndex = 8;
			this.listBoxTeams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.listBoxTeams.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.listBoxTeams.FormattingEnabled = true;
			this.listBoxTeams.ItemHeight = 24;
			this.listBoxTeams.Location = new Point(4, 4);
			this.listBoxTeams.Name = "listBoxTeams";
			this.listBoxTeams.Size = new Size(199, 268);
			this.listBoxTeams.TabIndex = 0;
			this.listBoxTeams.MouseDoubleClick += new MouseEventHandler(this.listBoxTeams_MouseDoubleClick);
			this.tabControlCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.tabControlCategories.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
			this.tabControlCategories.Location = new Point(4, 4);
			this.tabControlCategories.Name = "tabControlCategories";
			this.tabControlCategories.SelectedIndex = 0;
			this.tabControlCategories.Size = new Size(401, 286);
			this.tabControlCategories.TabIndex = 0;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(646, 441);
			this.Controls.Add((Control)this.splitContainerMain);
			this.Controls.Add((Control)this.labelCompetitionName);
			this.Controls.Add((Control)this.labelRefereeValue);
			this.Controls.Add((Control)this.labelReferee);
			this.Controls.Add((Control)this.labelDateValue);
			this.Controls.Add((Control)this.labelDate);
			this.Controls.Add((Control)this.labelPlaceValue);
			this.Controls.Add((Control)this.labelPlaceLabel);
			this.Controls.Add((Control)this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = nameof(MainForm);
			this.Text = "Draw";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			this.splitContainerMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			this.WindowState = FormWindowState.Maximized;
		}

		public MainForm()
		{
			this.InitializeComponent();
			this.competition.CompetitionChange += new Competition.CompetitionChangeHandler(this.competitionChanged);
			this.competition.TeamsChange += new Competition.TeamsChangeHandler(this.competitionTeamsChanged);
			this.competition.CategoryAdded += new Competition.CategoryAddedHandler(this.CompetitionCategoryAdded);
			this.competition.CategoriesChange += new Competition.CategoriesChangeHandler(this.competitionCategoriesChanged);
		}

		private void newToolStripCompetitionNew_Click(object sender, EventArgs e)
		{
			CompetitionInfo competitionInfo = new CompetitionInfo();
			if (competitionInfo.ShowDialog((IWin32Window)this) != DialogResult.OK)
				return;
			this.competition.clear();
			this.competition.setTitle(competitionInfo.getTitleValue());
			this.competition.setDate(competitionInfo.getDateValue());
			this.competition.setPlace(competitionInfo.getPlaceValue());
			this.competition.setMainReferee(competitionInfo.getRefereeValue());
			this.competition.setMainSecretary(competitionInfo.getSecretaryValue());
			this.toolStripMenuCompetitionEdit.Enabled = true;
			this.saveToolStripCompetitionSave.Enabled = true;
			this.applicationToolStripApplication.Enabled = true;
			this.categoriesToolStripCategories.Enabled = true;
		}

		public void competitionChanged()
		{
			this.labelCompetitionName.Text = this.competition.getTitle();
			this.labelPlaceValue.Text = this.competition.getPlace();
			this.labelDateValue.Text = this.competition.getDate().ToShortDateString();
			this.labelRefereeValue.Text = this.competition.getReferee();
		}

		public void competitionTeamsChanged()
		{
			this.listBoxTeams.Items.Clear();
			foreach (Team team in this.competition.getTeams())
				this.listBoxTeams.Items.Add((object)team.getName());
		}

		public void competitionCategoriesChanged()
		{
			this.tabControlCategories.TabPages.Clear();
			foreach (Category category in this.competition.getCategories())
				this.addCategoryTab(category);
		}

		public void CompetitionCategoryAdded(Category c)
		{
			this.addCategoryTab(c);
		}

		private void addCategoryTab(Category c)
		{
			Button button1 = new Button();
			Button buttonDraw = new Button();
			Button button2 = new Button();
			button1.Text = "Видалити";
			button1.Top = 0;
			button1.Left = 0;
			button1.Width = 80;
			button1.Height = 30;
			button1.Click += (EventHandler)((sender, e) =>
		   {
			   if (MessageBox.Show("Видалити категорію?", "Видалення категорії", MessageBoxButtons.OKCancel) != DialogResult.OK)
				   return;
			   for (int index = 0; index < this.tabControlCategories.TabPages.Count; ++index)
			   {
				   if (this.tabControlCategories.TabPages[index].Text == c.getName())
				   {
					   this.tabControlCategories.TabPages.RemoveAt(index);
					   this.competition.deleteCategory(c.getName());
					   break;
				   }
			   }
		   });
			buttonDraw.Text = "Жереб";
			buttonDraw.Top = 0;
			buttonDraw.Left = 83;
			buttonDraw.Width = 75;
			buttonDraw.Height = 30;
			buttonDraw.Click += (EventHandler)((sender, e) =>
		   {
			   string text = buttonDraw.Parent.Text;
			   List<ParticipantPair> pairs = this.competition.draw(text);
			   int participantCount = 0;
			   Category category = this.competition.getCategories().First<Category>((Func<Category, bool>)(s => s.getName() == text));
			   if (category != null)
			   {
				   participantCount = category.getParticipants().Count;
			   }
			   int num = (int)new DrawPreview(text, pairs, participantCount).ShowDialog((IWin32Window)this);
		   });
			button2.Text = "Оновити";
			button2.Top = 0;
			button2.Left = 166;
			button2.Width = 80;
			button2.Height = 30;
			button2.Visible = false;
			button2.Click += (EventHandler)((sender, e) =>
		   {
			   string text = buttonDraw.Parent.Text;
			   List<ParticipantPair> pairs = this.competition.draw(text);
			   int participantCount = 0;
			   Category category = this.competition.getCategories().First<Category>((Func<Category, bool>)(s => s.getName() == text));
               if (category != null) {
				   participantCount = category.getParticipants().Count;
               }
			   int num = (int)new DrawPreview(text, pairs, participantCount).ShowDialog((IWin32Window)this);
		   });
			TabPage tabPage = new TabPage(c.getName());
			DataGridView dataGridView = new DataGridView();
			DataGridViewColumn dataGridViewColumn1 = new DataGridViewColumn();
			dataGridViewColumn1.CellTemplate = (DataGridViewCell)new DataGridViewTextBoxCell();
			dataGridViewColumn1.Visible = false;
			dataGridViewColumn1.Name = "id";
			DataGridViewColumn dataGridViewColumn2 = new DataGridViewColumn();
			dataGridViewColumn2.CellTemplate = (DataGridViewCell)new DataGridViewTextBoxCell();
			dataGridViewColumn2.Name = "Name";
			dataGridViewColumn2.HeaderText = "Учасник";
			DataGridViewComboBoxColumn viewComboBoxColumn = new DataGridViewComboBoxColumn();
			viewComboBoxColumn.HeaderText = "Команда";
			viewComboBoxColumn.Name = "Team";
			foreach (Team team in this.competition.getTeams())
				viewComboBoxColumn.Items.Add((object)team.getName());
			Label label1 = new Label();
			Label label2 = label1;
			string str1 = "Вік: ";
			int num1 = c.getFilter().ageMin;
			string str2 = num1.ToString();
			string str3 = " - ";
			num1 = c.getFilter().ageMax;
			string str4 = num1.ToString();
			string str5 = str1 + str2 + str3 + str4;
			label2.Text = str5;
			label1.Location = new Point(4, 34);
			Label label3 = new Label();
			label3.Text = "Вага: " + c.getFilter().weightMin.ToString() + " - " + c.getFilter().weightMax.ToString();
			label3.Location = new Point(4, 54);
			Label label4 = new Label();
			label4.Text = "Стать: " + c.getFilter().sex;
			label4.Location = new Point(4, 74);
			Label label5 = new Label();
			Label label6 = label5;
			string str6 = "Кю: ";
			num1 = c.getFilter().kuMin;
			string str7 = num1.ToString();
			string str8 = " - ";
			num1 = c.getFilter().kuMax;
			string str9 = num1.ToString();
			string str10 = str6 + str7 + str8 + str9;
			label6.Text = str10;
			label5.Location = new Point(100, 34);
			Label label7 = new Label();
			switch (c.getFilter().type)
			{
				case CategoryType.Kata:
					label7.Text = "Ката";
					break;
				case CategoryType.Kumite:
					label7.Text = "Куміте";
					break;
				case CategoryType.Fukugo:
					label7.Text = "Фукуго";
					break;
				case CategoryType.Irigumi:
					label7.Text = "Ірігумі";
					break;
			}
			label7.Location = new Point(100, 54);
			dataGridView.Columns.Add(dataGridViewColumn1);
			dataGridView.Columns.Add(dataGridViewColumn2);
			dataGridView.Columns.Add((DataGridViewColumn)viewComboBoxColumn);
			dataGridView.Location = new Point(4, 100);
			dataGridView.Width = this.tabControlCategories.Width;
			dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView.ReadOnly = true;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.DoubleClick += (EventHandler)((sender, e) =>
		   {
			   CategoryEdit categoryEdit = new CategoryEdit(c.getName());
			   List<string> teams = new List<string>();
			   List<Participant> participants = new List<Participant>();
			   string text = tabPage.Text;
			   foreach (Team team in this.competition.getTeams())
				   teams.Add(team.getName());
			   foreach (Participant participant in c.getParticipants())
				   participants.Add(participant);
			   categoryEdit.initializeParticipantsGrid(teams, participants);
			   if (categoryEdit.ShowDialog((IWin32Window)this) != DialogResult.OK)
				   return;
			   Category valuesAsCategory = categoryEdit.getValuesAsCategory(c.getFilter());
			   dataGridView.Rows.Clear();
			   foreach (Participant participant in valuesAsCategory.getParticipants())
				   dataGridView.Rows.Add((object)participant.getId(), (object)participant.getName(), (object)participant.getTeam());
			   tabPage.Text = valuesAsCategory.getName();
			   this.competition.updateCategory(text, valuesAsCategory);
		   });
			foreach (Participant participant in c.getParticipants())
				dataGridView.Rows.Add((object)participant.getId(), (object)participant.getName(), (object)participant.getTeam());
			tabPage.Controls.Add((Control)button1);
			tabPage.Controls.Add((Control)buttonDraw);
			tabPage.Controls.Add((Control)button2);
			tabPage.Controls.Add((Control)label1);
			tabPage.Controls.Add((Control)label3);
			tabPage.Controls.Add((Control)label4);
			tabPage.Controls.Add((Control)label5);
			tabPage.Controls.Add((Control)label7);
			tabPage.Controls.Add((Control)dataGridView);
			this.tabControlCategories.TabPages.Add(tabPage);
		}

		private void toolStripMenuCompetitionEdit_Click(object sender, EventArgs e)
		{
			CompetitionInfo competitionInfo = new CompetitionInfo(this.competition.getTitle(), this.competition.getDate(), this.competition.getPlace(), this.competition.getReferee(), this.competition.getSecretary());
			if (competitionInfo.ShowDialog((IWin32Window)this) != DialogResult.OK)
				return;
			this.competition.setTitle(competitionInfo.getTitleValue());
			this.competition.setDate(competitionInfo.getDateValue());
			this.competition.setPlace(competitionInfo.getPlaceValue());
			this.competition.setMainReferee(competitionInfo.getRefereeValue());
			this.competition.setMainSecretary(competitionInfo.getSecretaryValue());
		}

		private void applicationToolStripApplicationNew_Click(object sender, EventArgs e)
		{
			ApplicationFormInfo applicationFormInfo = new ApplicationFormInfo(false);
			if (applicationFormInfo.ShowDialog((IWin32Window)this) != DialogResult.OK)
				return;
			this.competition.addTeam(applicationFormInfo.getValuesAsTeam());
		}

		private void listBoxTeams_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.listBoxTeams.SelectedItem == null)
				return;
			string selectedTeamName = this.listBoxTeams.SelectedItem.ToString();
			Team team = this.competition.getTeams().First<Team>((Func<Team, bool>)(s => s.getName() == selectedTeamName));
			if (team == null)
				return;
			ApplicationFormInfo applicationFormInfo = new ApplicationFormInfo(true);
			applicationFormInfo.setTeam(team);
			try
			{
				switch (applicationFormInfo.ShowDialog((IWin32Window)this))
				{
					case DialogResult.OK:
						this.competition.changeTeam(selectedTeamName, applicationFormInfo.getValuesAsTeam());
						break;
					case DialogResult.Abort:
						if (applicationFormInfo.getDeleteTeam())
						{
							this.competition.removeTeam(selectedTeamName);
							break;
						}
						break;
				}
			}
			catch (Exception ex)
			{
			}
		}

		private void categoriesToolStripCategoriesAdd_Click(object sender, EventArgs e)
		{
			CategoryInfo categoryInfo = new CategoryInfo();
			if (categoryInfo.ShowDialog((IWin32Window)this) != DialogResult.OK)
				return;
			this.competition.addCategory(categoryInfo.getName(), categoryInfo.getInfo());
		}

		private void saveToolStripCompetitionSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "XML|*.xml";
			if (saveFileDialog.ShowDialog((IWin32Window)this) != DialogResult.OK)
				return;
			string fileName = saveFileDialog.FileName;
			XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, Encoding.UTF8);
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("competition");
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.Close();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(fileName);
			XmlElement element1 = xmlDocument.CreateElement("name");
			XmlElement element2 = xmlDocument.CreateElement("date");
			XmlElement element3 = xmlDocument.CreateElement("place");
			XmlElement element4 = xmlDocument.CreateElement("referee");
			XmlElement element5 = xmlDocument.CreateElement("secretary");
			XmlElement element6 = xmlDocument.CreateElement("teams");
			XmlElement element7 = xmlDocument.CreateElement("categories");
			xmlDocument.DocumentElement.AppendChild((XmlNode)element1);
			xmlDocument.DocumentElement.AppendChild((XmlNode)element2);
			xmlDocument.DocumentElement.AppendChild((XmlNode)element3);
			xmlDocument.DocumentElement.AppendChild((XmlNode)element4);
			xmlDocument.DocumentElement.AppendChild((XmlNode)element5);
			xmlDocument.DocumentElement.AppendChild((XmlNode)element6);
			xmlDocument.DocumentElement.AppendChild((XmlNode)element7);
			element1.InnerText = this.competition.getTitle();
			element2.InnerText = this.competition.getDate().ToShortDateString();
			element3.InnerText = this.competition.getPlace();
			element4.InnerText = this.competition.getReferee();
			element5.InnerText = this.competition.getSecretary();
			foreach (Team team in this.competition.getTeams())
			{
				XmlNode element8 = (XmlNode)xmlDocument.CreateElement("team");
				XmlNode element9 = (XmlNode)xmlDocument.CreateElement("name");
				XmlNode element10 = (XmlNode)xmlDocument.CreateElement("participants");
				element9.InnerText = team.getName();
				foreach (Participant participant in team.getParticipants())
				{
					XmlNode element11 = (XmlNode)xmlDocument.CreateElement("participant");
					XmlAttribute attribute1 = xmlDocument.CreateAttribute("id");
					XmlAttribute attribute2 = xmlDocument.CreateAttribute("name");
					XmlAttribute attribute3 = xmlDocument.CreateAttribute("age");
					XmlAttribute attribute4 = xmlDocument.CreateAttribute("weight");
					XmlAttribute attribute5 = xmlDocument.CreateAttribute("sex");
					XmlAttribute attribute6 = xmlDocument.CreateAttribute("ku");
					XmlAttribute attribute7 = xmlDocument.CreateAttribute("kata");
					XmlAttribute attribute8 = xmlDocument.CreateAttribute("kumite");
					XmlAttribute attribute9 = xmlDocument.CreateAttribute("fukugo");
					XmlAttribute attribute10 = xmlDocument.CreateAttribute("irigumi");
					attribute1.Value = participant.getId().ToString();
					attribute2.Value = participant.getName();
					XmlAttribute xmlAttribute1 = attribute3;
					int num = participant.getAge();
					string str1 = num.ToString();
					xmlAttribute1.Value = str1;
					attribute4.Value = participant.getWeight().ToString();
					attribute5.Value = participant.getSex();
					XmlAttribute xmlAttribute2 = attribute6;
					num = participant.getKu();
					string str2 = num.ToString();
					xmlAttribute2.Value = str2;
					attribute7.Value = participant.getCategories().Contains(CategoryType.Kata).ToString();
					attribute8.Value = participant.getCategories().Contains(CategoryType.Kumite).ToString();
					attribute9.Value = participant.getCategories().Contains(CategoryType.Fukugo).ToString();
					attribute10.Value = participant.getCategories().Contains(CategoryType.Irigumi).ToString();
					element11.Attributes.Append(attribute1);
					element11.Attributes.Append(attribute2);
					element11.Attributes.Append(attribute3);
					element11.Attributes.Append(attribute4);
					element11.Attributes.Append(attribute5);
					element11.Attributes.Append(attribute6);
					element11.Attributes.Append(attribute7);
					element11.Attributes.Append(attribute8);
					element11.Attributes.Append(attribute9);
					element11.Attributes.Append(attribute10);
					element10.AppendChild(element11);
				}
				element8.AppendChild(element9);
				element8.AppendChild(element10);
				element6.AppendChild(element8);
			}
			foreach (Category category in this.competition.getCategories())
			{
				XmlNode element8 = (XmlNode)xmlDocument.CreateElement("category");
				XmlNode element9 = (XmlNode)xmlDocument.CreateElement("name");
				XmlNode element10 = (XmlNode)xmlDocument.CreateElement("participants");
				XmlNode element11 = (XmlNode)xmlDocument.CreateElement("filter");
				element9.InnerText = category.getName();
				int num;
				foreach (Participant participant in category.getParticipants())
				{
					XmlNode element12 = (XmlNode)xmlDocument.CreateElement("participant");
					XmlAttribute attribute1 = xmlDocument.CreateAttribute("id");
					XmlAttribute attribute2 = xmlDocument.CreateAttribute("name");
					XmlAttribute attribute3 = xmlDocument.CreateAttribute("age");
					XmlAttribute attribute4 = xmlDocument.CreateAttribute("weight");
					XmlAttribute attribute5 = xmlDocument.CreateAttribute("sex");
					XmlAttribute attribute6 = xmlDocument.CreateAttribute("kata");
					XmlAttribute attribute7 = xmlDocument.CreateAttribute("kumite");
					XmlAttribute attribute8 = xmlDocument.CreateAttribute("team");
					XmlAttribute attribute9 = xmlDocument.CreateAttribute("fukugo");
					XmlAttribute attribute10 = xmlDocument.CreateAttribute("irigumi");
					XmlAttribute xmlAttribute1 = attribute1;
					num = participant.getId();
					string str1 = num.ToString();
					xmlAttribute1.Value = str1;
					attribute2.Value = participant.getName();
					XmlAttribute xmlAttribute2 = attribute3;
					num = participant.getAge();
					string str2 = num.ToString();
					xmlAttribute2.Value = str2;
					attribute4.Value = participant.getWeight().ToString();
					attribute5.Value = participant.getSex();
					XmlAttribute xmlAttribute3 = attribute6;
					bool flag = participant.getCategories().Contains(CategoryType.Kata);
					string str3 = flag.ToString();
					xmlAttribute3.Value = str3;
					XmlAttribute xmlAttribute4 = attribute7;
					flag = participant.getCategories().Contains(CategoryType.Kumite);
					string str4 = flag.ToString();
					xmlAttribute4.Value = str4;
					XmlAttribute xmlAttribute5 = attribute9;
					flag = participant.getCategories().Contains(CategoryType.Fukugo);
					string str5 = flag.ToString();
					xmlAttribute5.Value = str5;
					XmlAttribute xmlAttribute6 = attribute10;
					flag = participant.getCategories().Contains(CategoryType.Irigumi);
					string str6 = flag.ToString();
					xmlAttribute6.Value = str6;
					attribute8.Value = participant.getTeam().ToString();
					element12.Attributes.Append(attribute1);
					element12.Attributes.Append(attribute2);
					element12.Attributes.Append(attribute3);
					element12.Attributes.Append(attribute4);
					element12.Attributes.Append(attribute5);
					element12.Attributes.Append(attribute6);
					element12.Attributes.Append(attribute7);
					element12.Attributes.Append(attribute9);
					element12.Attributes.Append(attribute10);
					element12.Attributes.Append(attribute8);
					element10.AppendChild(element12);
				}
				XmlAttribute attribute11 = xmlDocument.CreateAttribute("age");
				XmlAttribute attribute12 = xmlDocument.CreateAttribute("weight");
				XmlAttribute attribute13 = xmlDocument.CreateAttribute("sex");
				XmlAttribute attribute14 = xmlDocument.CreateAttribute("ku");
				XmlAttribute attribute15 = xmlDocument.CreateAttribute("type");
				XmlAttribute xmlAttribute7 = attribute11;
				num = category.getFilter().ageMin;
				string str7 = num.ToString();
				string str8 = "-";
				num = category.getFilter().ageMax;
				string str9 = num.ToString();
				string str10 = str7 + str8 + str9;
				xmlAttribute7.Value = str10;
				attribute12.Value = category.getFilter().weightMin.ToString() + "-" + category.getFilter().weightMax.ToString();
				attribute13.Value = category.getFilter().sex;
				XmlAttribute xmlAttribute8 = attribute14;
				num = category.getFilter().kuMin;
				string str11 = num.ToString() + "-" + (object)category.getFilter().kuMax;
				xmlAttribute8.Value = str11;
				attribute15.Value = category.getFilter().type.ToString();
				element11.Attributes.Append(attribute11);
				element11.Attributes.Append(attribute12);
				element11.Attributes.Append(attribute13);
				element11.Attributes.Append(attribute14);
				element11.Attributes.Append(attribute15);
				element8.AppendChild(element9);
				element8.AppendChild(element11);
				element8.AppendChild(element10);
				element7.AppendChild(element8);
			}
			xmlDocument.Save(fileName);
		}

		private void openToolStripCompetitionOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "XML|*.xml";
			if (openFileDialog.ShowDialog((IWin32Window)this) != DialogResult.OK)
				return;
            this.competition.clear();
			string fileName = openFileDialog.FileName;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(fileName);
			string title = "";
			string place = "";
			DateTime date = new DateTime();
			string referee = "";
			string secretary = "";
			foreach (XmlNode childNode1 in xmlDocument.DocumentElement.ChildNodes)
			{
				switch (childNode1.Name)
				{
					case "name":
						title = childNode1.InnerText;
						break;
					case "place":
						place = childNode1.InnerText;
						break;
					case "date":
						date = DateTime.Parse(childNode1.InnerText);
						break;
					case "referee":
						referee = childNode1.InnerText;
						break;
					case "secretary":
						secretary = childNode1.InnerText;
						break;
					case "teams":
						IEnumerator enumerator1 = childNode1.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator1.MoveNext())
							{
								XmlNode current1 = (XmlNode)enumerator1.Current;
								string name1 = "";
								List<Participant> participants = new List<Participant>();
								foreach (XmlNode childNode2 in current1.ChildNodes)
								{
									switch (childNode2.Name)
									{
										case "name":
											name1 = childNode2.InnerText;
											break;
										case "participants":
											IEnumerator enumerator2 = childNode2.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode current2 = (XmlNode)enumerator2.Current;
													int id = 0;
													string name2 = "";
													int age = 0;
													double weight = 0.0;
													int ku = 0;
													string sex = "";
													List<CategoryType> categories = new List<CategoryType>();
													foreach (XmlAttribute attribute in (XmlNamedNodeMap)current2.Attributes)
													{
														switch (attribute.Name)
														{
															case "id":
																id = Convert.ToInt32(attribute.Value);
																break;
															case "name":
																name2 = attribute.Value;
																break;
															case "age":
																age = Convert.ToInt32(attribute.Value);
																break;
															case "weight":
																weight = Convert.ToDouble(attribute.Value);
																break;
															case "sex":
																sex = attribute.Value;
																break;
															case "ku":
																ku = Convert.ToInt32(attribute.Value);
																break;
															case "kata":
																if (Convert.ToBoolean(attribute.Value))
																{
																	categories.Add(CategoryType.Kata);
																	break;
																}
																break;
															case "kumite":
																if (Convert.ToBoolean(attribute.Value))
																{
																	categories.Add(CategoryType.Kumite);
																	break;
																}
																break;
															case "fukugo":
																if (Convert.ToBoolean(attribute.Value))
																{
																	categories.Add(CategoryType.Fukugo);
																	break;
																}
																break;
															case "irigumi":
																if (Convert.ToBoolean(attribute.Value))
																{
																	categories.Add(CategoryType.Irigumi);
																	break;
																}
																break;
														}
													}
													Participant participant = new Participant(name2, age, weight, sex, ku, categories);
													participant.setId(id);
													participants.Add(participant);
												}
												break;
											}
											finally
											{
												(enumerator2 as IDisposable)?.Dispose();
											}
									}
								}
								this.competition.addTeam(new Team(name1, participants));
							}
							break;
						}
						finally
						{
							(enumerator1 as IDisposable)?.Dispose();
						}
					case "categories":
						IEnumerator enumerator3 = childNode1.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								XmlNode current1 = (XmlNode)enumerator3.Current;
								string name1 = "";
								CategoryFilter filter = new CategoryFilter(0, 0, 0.0, 0.0, "", CategoryType.Kata, 0, 0);
								List<Participant> participants = new List<Participant>();
								foreach (XmlNode childNode2 in current1.ChildNodes)
								{
									switch (childNode2.Name)
									{
										case "name":
											name1 = childNode2.InnerText;
											break;
										case "participants":
											IEnumerator enumerator2 = childNode2.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode current2 = (XmlNode)enumerator2.Current;
													int id = 0;
													string name2 = "";
													int age = 0;
													double weight = 0.0;
													string sex = "";
													bool flag1 = false;
													bool flag2 = false;
													string team = "";
													foreach (XmlAttribute attribute in (XmlNamedNodeMap)current2.Attributes)
													{
														switch (attribute.Name)
														{
															case "id":
																id = Convert.ToInt32(attribute.Value);
																break;
															case "name":
																name2 = attribute.Value;
																break;
															case "age":
																age = Convert.ToInt32(attribute.Value);
																break;
															case "weight":
																weight = Convert.ToDouble(attribute.Value);
																break;
															case "sex":
																sex = attribute.Value;
																break;
															case "kata":
																flag1 = Convert.ToBoolean(attribute.Value);
																break;
															case "kumite":
																flag2 = Convert.ToBoolean(attribute.Value);
																break;
															case "team":
																team = attribute.Value;
																break;
														}
													}
													Participant participant = new Participant(name2, age, weight, sex, 0, new List<CategoryType>());
													participant.setTeam(team);
													participant.setId(id);
													participants.Add(participant);
												}
												break;
											}
											finally
											{
												(enumerator2 as IDisposable)?.Dispose();
											}
										case "filter":
											IEnumerator enumerator4 = childNode2.Attributes.GetEnumerator();
											try
											{
												while (enumerator4.MoveNext())
												{
													XmlAttribute current2 = (XmlAttribute)enumerator4.Current;
													switch (current2.Name)
													{
														case "age":
															string[] strArray1 = current2.Value.Split('-');
															if (strArray1.Length >= 2)
															{
																filter.ageMin = Convert.ToInt32(strArray1[0]);
																filter.ageMax = Convert.ToInt32(strArray1[1]);
																break;
															}
															break;
														case "weight":
															string[] strArray2 = current2.Value.Split('-');
															if (strArray2.Length >= 2)
															{
																filter.weightMin = Convert.ToDouble(strArray2[0]);
																filter.weightMax = Convert.ToDouble(strArray2[1]);
																break;
															}
															break;
														case "sex":
															filter.sex = current2.Value;
															break;
														case "ku":
															string[] strArray3 = current2.Value.Split('-');
															if (strArray3.Length >= 2)
															{
																filter.kuMin = Convert.ToInt32(strArray3[0]);
																filter.kuMax = Convert.ToInt32(strArray3[1]);
																break;
															}
															break;
														case "type":
															switch (current2.Value)
															{
																case "kata":
																case "Kata":
																	filter.type = CategoryType.Kata;
																	break;
																case "kumite":
																case "Kumite":
																	filter.type = CategoryType.Kumite;
																	break;
																case "fukugo":
																case "Fukugo":
																	filter.type = CategoryType.Fukugo;
																	break;
																case "irigumi":
																case "Irigumi":
																	filter.type = CategoryType.Irigumi;
																	break;
															}
															break;
													}
												}
												break;
											}
											finally
											{
												(enumerator4 as IDisposable)?.Dispose();
											}
									}
								}
								this.competition.addCategory(new Category(name1, participants, filter));
							}
							break;
						}
						finally
						{
							(enumerator3 as IDisposable)?.Dispose();
						}
				}
			}
			this.competition.setTitle(title);
			this.competition.setPlace(place);
			this.competition.setDate(date);
			this.competition.setMainReferee(referee);
			this.competition.setMainSecretary(secretary);
			this.toolStripMenuCompetitionEdit.Enabled = true;
			this.saveToolStripCompetitionSave.Enabled = true;
			this.applicationToolStripApplication.Enabled = true;
			this.categoriesToolStripCategories.Enabled = true;
		}
	}
}
