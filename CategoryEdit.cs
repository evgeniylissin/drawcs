// Decompiled with JetBrains decompiler
// Type: Draw.CategoryEdit
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
  public class CategoryEdit : Form
  {
    private IContainer components = (IContainer) null;
    private Button buttonSave;
    private DataGridView dataGridViewParticipants;
    private TextBox textBoxTitle;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn FullName;
    private DataGridViewComboBoxColumn Team;

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
      this.buttonSave = new Button();
      this.dataGridViewParticipants = new DataGridView();
      this.textBoxTitle = new TextBox();
      this.id = new DataGridViewTextBoxColumn();
      this.FullName = new DataGridViewTextBoxColumn();
      this.Team = new DataGridViewComboBoxColumn();
      ((ISupportInitialize) this.dataGridViewParticipants).BeginInit();
      this.SuspendLayout();
      this.buttonSave.DialogResult = DialogResult.OK;
      this.buttonSave.Location = new Point(482, 412);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new Size(75, 23);
      this.buttonSave.TabIndex = 0;
      this.buttonSave.Text = "Зберегти";
      this.buttonSave.UseVisualStyleBackColor = true;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dataGridViewParticipants.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewParticipants.Columns.AddRange((DataGridViewColumn) this.id, (DataGridViewColumn) this.FullName, (DataGridViewColumn) this.Team);
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dataGridViewParticipants.DefaultCellStyle = gridViewCellStyle2;
      this.dataGridViewParticipants.Location = new Point(13, 39);
      this.dataGridViewParticipants.Name = "dataGridViewParticipants";
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Control;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle3.ForeColor = SystemColors.WindowText;
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      this.dataGridViewParticipants.RowHeadersDefaultCellStyle = gridViewCellStyle3;
      this.dataGridViewParticipants.Size = new Size(544, 367);
      this.dataGridViewParticipants.TabIndex = 1;
      this.textBoxTitle.Location = new Point(13, 13);
      this.textBoxTitle.Name = "textBoxTitle";
      this.textBoxTitle.Size = new Size(544, 20);
      this.textBoxTitle.TabIndex = 2;
      this.id.HeaderText = "id";
      this.id.Name = "id";
      this.id.Visible = false;
      this.FullName.HeaderText = "Учасник";
      this.FullName.Name = "FullName";
      this.FullName.Width = 400;
      this.Team.HeaderText = "Команда";
      this.Team.Name = "Team";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(569, 447);
      this.Controls.Add((Control) this.textBoxTitle);
      this.Controls.Add((Control) this.dataGridViewParticipants);
      this.Controls.Add((Control) this.buttonSave);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (CategoryEdit);
      this.Text = nameof (CategoryEdit);
      ((ISupportInitialize) this.dataGridViewParticipants).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public CategoryEdit()
    {
      this.InitializeComponent();
      this.dataGridViewParticipants.DataError += new DataGridViewDataErrorEventHandler(this.dataGridViewParticipants_DataError);
    }

    public CategoryEdit(string categoryTitle)
    {
      this.InitializeComponent();
      this.textBoxTitle.Text = categoryTitle;
      this.dataGridViewParticipants.DataError += new DataGridViewDataErrorEventHandler(this.dataGridViewParticipants_DataError);
    }

    private void dataGridViewParticipants_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    public void initializeParticipantsGrid(List<string> teams, List<Participant> participants)
    {
      foreach (object team in teams)
        this.Team.Items.Add(team);
      foreach (Participant participant in participants)
        this.dataGridViewParticipants.Rows.Add((object) participant.getId(), (object) participant.getName(), (object) participant.getTeam());
    }

    public Category getValuesAsCategory(CategoryFilter cf)
    {
      string text = this.textBoxTitle.Text;
      List<Participant> participants = new List<Participant>();
      foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewParticipants.Rows)
      {
        if (row.Cells["FullName"].Value != null && row.Cells["Team"].Value != null)
        {
          int id = 0;
          if (row.Cells["id"].Value != null)
            id = Convert.ToInt32(row.Cells["id"].Value.ToString());
          string name = row.Cells["FullName"].Value.ToString();
          string team = row.Cells["Team"].Value.ToString();
          Participant participant = new Participant();
          participant.setName(name);
          participant.setTeam(team);
          if (id > 0)
            participant.setId(id);
          participants.Add(participant);
        }
      }
      return new Category(text, participants, cf);
    }
  }
}
