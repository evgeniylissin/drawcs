// Decompiled with JetBrains decompiler
// Type: Draw.ApplicationFormInfo
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
  public class ApplicationFormInfo : Form
  {
    private bool deleteResult = false;
    private IContainer components = (IContainer) null;
    private DataGridView dataGridViewParticipants;
    private Button buttonSave;
    private TextBox textBoxTitle;
    private Label labelTitle;
    private Button buttonDelete;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn FullName;
    private DataGridViewTextBoxColumn Age;
    private DataGridViewTextBoxColumn Weight;
    private DataGridViewTextBoxColumn Ku;
    private DataGridViewComboBoxColumn Sex;
    private DataGridViewCheckBoxColumn Kata;
    private DataGridViewCheckBoxColumn Kumite;
    private DataGridViewCheckBoxColumn Fukugo;
    private DataGridViewCheckBoxColumn Irigumi;

    public ApplicationFormInfo(bool showDelete)
    {
      this.InitializeComponent();
      this.Sex.DefaultCellStyle.NullValue = (object) "M";
      this.Sex.DefaultCellStyle.DataSourceNullValue = (object) "M";
      if (!showDelete)
        return;
      this.buttonDelete.Show();
    }

    public Team getValuesAsTeam()
    {
      List<Participant> participants = new List<Participant>();
      foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewParticipants.Rows)
      {
        if (row.Cells["FullName"].Value != null)
        {
          int id = 0;
          string name = "";
          int age = 0;
          double weight = 0.0;
          string sex = "";
          int ku = 0;
          List<CategoryType> categories = new List<CategoryType>();
          if (row.Cells["id"].Value != null)
            id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
          if (row.Cells["FullName"].Value != null)
          {
            try
            {
              name = row.Cells["FullName"].Value.ToString();
            }
            catch (Exception ex)
            {
            }
          }
          if (row.Cells["Age"].Value != null)
          {
            try
            {
              age = Convert.ToInt32(row.Cells["Age"].Value.ToString());
            }
            catch (Exception ex)
            {
            }
          }
          if (row.Cells["Weight"].Value != null)
          {
            try
            {
              weight = Convert.ToDouble(row.Cells["Weight"].Value.ToString());
            }
            catch (Exception ex)
            {
            }
          }
          if (row.Cells["Sex"].Value != null)
          {
            try
            {
              sex = row.Cells["Sex"].Value.ToString();
              if (sex.Length == 0)
                sex = "M";
            }
            catch (Exception ex)
            {
            }
          }
          else
            sex = "M";
          if (row.Cells["Ku"].Value != null)
          {
            try
            {
              ku = Convert.ToInt32(row.Cells["Ku"].Value.ToString());
            }
            catch (Exception ex)
            {
            }
          }
          if (row.Cells["Kata"].Value != null && Convert.ToBoolean(row.Cells["Kata"].Value.ToString()))
            categories.Add(CategoryType.Kata);
          if (row.Cells["Kumite"].Value != null && Convert.ToBoolean(row.Cells["Kumite"].Value.ToString()))
            categories.Add(CategoryType.Kumite);
          if (row.Cells["Fukugo"].Value != null && Convert.ToBoolean(row.Cells["Fukugo"].Value.ToString()))
            categories.Add(CategoryType.Fukugo);
          if (row.Cells["Irigumi"].Value != null && Convert.ToBoolean(row.Cells["Irigumi"].Value.ToString()))
            categories.Add(CategoryType.Irigumi);
          Participant participant = new Participant(name, age, weight, sex, ku, categories);
          if (id != 0)
            participant.setId(id);
          participants.Add(participant);
        }
      }
      return new Team(this.textBoxTitle.Text, participants);
    }

    public void setTeam(Team team)
    {
      this.textBoxTitle.Text = team.getName();
      foreach (Participant participant in team.getParticipants())
        this.dataGridViewParticipants.Rows.Add((object) participant.getId(), (object) participant.getName(), (object) participant.getAge(), (object) participant.getWeight(), (object) participant.getKu(), (object) participant.getSex(), (object) participant.getCategories().Contains(CategoryType.Kata), (object) participant.getCategories().Contains(CategoryType.Kumite), (object) participant.getCategories().Contains(CategoryType.Fukugo), (object) participant.getCategories().Contains(CategoryType.Irigumi));
    }

    public bool getDeleteTeam()
    {
      return this.deleteResult;
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Видалити команду?", "Видалення команди", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.deleteResult = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.dataGridViewParticipants = new DataGridView();
      this.buttonSave = new Button();
      this.textBoxTitle = new TextBox();
      this.labelTitle = new Label();
      this.buttonDelete = new Button();
      this.id = new DataGridViewTextBoxColumn();
      this.FullName = new DataGridViewTextBoxColumn();
      this.Age = new DataGridViewTextBoxColumn();
      this.Weight = new DataGridViewTextBoxColumn();
      this.Ku = new DataGridViewTextBoxColumn();
      this.Sex = new DataGridViewComboBoxColumn();
      this.Kata = new DataGridViewCheckBoxColumn();
      this.Kumite = new DataGridViewCheckBoxColumn();
      this.Fukugo = new DataGridViewCheckBoxColumn();
      this.Irigumi = new DataGridViewCheckBoxColumn();
      ((ISupportInitialize) this.dataGridViewParticipants).BeginInit();
      this.SuspendLayout();
      this.dataGridViewParticipants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dataGridViewParticipants.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewParticipants.Columns.AddRange((DataGridViewColumn) this.id, (DataGridViewColumn) this.FullName, (DataGridViewColumn) this.Age, (DataGridViewColumn) this.Weight, (DataGridViewColumn) this.Ku, (DataGridViewColumn) this.Sex, (DataGridViewColumn) this.Kata, (DataGridViewColumn) this.Kumite, (DataGridViewColumn) this.Fukugo, (DataGridViewColumn) this.Irigumi);
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dataGridViewParticipants.DefaultCellStyle = gridViewCellStyle2;
      this.dataGridViewParticipants.Location = new Point(12, 53);
      this.dataGridViewParticipants.Name = "dataGridViewParticipants";
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Control;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle3.ForeColor = SystemColors.WindowText;
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      this.dataGridViewParticipants.RowHeadersDefaultCellStyle = gridViewCellStyle3;
      this.dataGridViewParticipants.Size = new Size(1052, 473);
      this.dataGridViewParticipants.TabIndex = 0;
      this.buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.buttonSave.DialogResult = DialogResult.OK;
      this.buttonSave.Location = new Point(989, 532);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new Size(75, 23);
      this.buttonSave.TabIndex = 1;
      this.buttonSave.Text = "Зберегти";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.textBoxTitle.Location = new Point(121, 16);
      this.textBoxTitle.Name = "textBoxTitle";
      this.textBoxTitle.Size = new Size(370, 20);
      this.textBoxTitle.TabIndex = 2;
      this.labelTitle.AutoSize = true;
      this.labelTitle.Location = new Point(13, 19);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new Size(52, 13);
      this.labelTitle.TabIndex = 3;
      this.labelTitle.Text = "Команда";
      this.buttonDelete.DialogResult = DialogResult.Abort;
      this.buttonDelete.Location = new Point(863, 532);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new Size(120, 23);
      this.buttonDelete.TabIndex = 4;
      this.buttonDelete.Text = "Видалити команду";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Visible = false;
      this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
      this.id.HeaderText = "id";
      this.id.Name = "id";
      this.id.Visible = false;
      this.FullName.HeaderText = "Учасник";
      this.FullName.Name = "FullName";
      this.FullName.Width = 500;
      this.Age.HeaderText = "Вік";
      this.Age.Name = "Age";
      this.Age.Width = 70;
      this.Weight.HeaderText = "Вага";
      this.Weight.Name = "Weight";
      this.Weight.Width = 50;
      this.Ku.HeaderText = "Кю";
      this.Ku.Name = "Ku";
      this.Ku.Width = 50;
      this.Sex.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
      this.Sex.HeaderText = "Стать";
      this.Sex.Items.AddRange((object) "M", (object) "F");
      this.Sex.Name = "Sex";
      this.Sex.Width = 50;
      this.Kata.HeaderText = "Ката";
      this.Kata.Name = "Kata";
      this.Kata.Width = 50;
      this.Kumite.HeaderText = "Куміте";
      this.Kumite.Name = "Kumite";
      this.Kumite.Width = 50;
      this.Fukugo.HeaderText = "Фукуго";
      this.Fukugo.Name = "Fukugo";
      this.Fukugo.Visible = false;
      this.Fukugo.Width = 50;
      this.Irigumi.HeaderText = "Ірігумі";
      this.Irigumi.Name = "Irigumi";
      this.Irigumi.Visible = false;
      this.Irigumi.Width = 50;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1076, 564);
      this.Controls.Add((Control) this.buttonDelete);
      this.Controls.Add((Control) this.labelTitle);
      this.Controls.Add((Control) this.textBoxTitle);
      this.Controls.Add((Control) this.buttonSave);
      this.Controls.Add((Control) this.dataGridViewParticipants);
      this.Name = nameof (ApplicationFormInfo);
      this.Text = nameof (ApplicationFormInfo);
      ((ISupportInitialize) this.dataGridViewParticipants).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
