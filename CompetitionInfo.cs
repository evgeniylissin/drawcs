// Decompiled with JetBrains decompiler
// Type: Draw.CompetitionInfo
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
  public class CompetitionInfo : Form
  {
    private IContainer components = (IContainer) null;
    private Button buttonSave;
    private Label labelTitle;
    private TextBox textBoxTitle;
    private Label labelDate;
    private Label labelReferee;
    private TextBox textBoxMainReferee;
    private DateTimePicker dateTimePickerDate;
    private Label labelPlace;
    private TextBox textBoxPlace;
    private TextBox textBoxMainSecretary;
    private Label labelSecretary;

    public CompetitionInfo()
    {
      this.InitializeComponent();
    }

    public CompetitionInfo(string title, DateTime date, string place, string referee, string secretary)
    {
      this.InitializeComponent();
      this.textBoxTitle.Text = title;
      this.dateTimePickerDate.Value = date;
      this.textBoxPlace.Text = place;
      this.textBoxMainReferee.Text = referee;
      this.textBoxMainSecretary.Text = secretary;
    }

    public string getTitleValue()
    {
      return this.textBoxTitle.Text;
    }

    public DateTime getDateValue()
    {
      return this.dateTimePickerDate.Value;
    }

    public string getRefereeValue()
    {
      return this.textBoxMainReferee.Text;
    }

    public string getPlaceValue()
    {
      return this.textBoxPlace.Text;
    }

    public string getSecretaryValue()
    {
      return this.textBoxMainSecretary.Text;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.buttonSave = new Button();
      this.labelTitle = new Label();
      this.textBoxTitle = new TextBox();
      this.labelDate = new Label();
      this.labelReferee = new Label();
      this.textBoxMainReferee = new TextBox();
      this.dateTimePickerDate = new DateTimePicker();
      this.labelPlace = new Label();
      this.textBoxPlace = new TextBox();
      this.textBoxMainSecretary = new TextBox();
      this.labelSecretary = new Label();
      this.SuspendLayout();
      this.buttonSave.DialogResult = DialogResult.OK;
      this.buttonSave.Location = new Point(326, 167);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new Size(75, 23);
      this.buttonSave.TabIndex = 6;
      this.buttonSave.Text = "Зберегти";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.labelTitle.AutoSize = true;
      this.labelTitle.Location = new Point(47, 25);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new Size(39, 13);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "Назва";
      this.textBoxTitle.Location = new Point(95, 22);
      this.textBoxTitle.Name = "textBoxTitle";
      this.textBoxTitle.Size = new Size(306, 20);
      this.textBoxTitle.TabIndex = 1;
      this.labelDate.AutoSize = true;
      this.labelDate.Location = new Point(53, 54);
      this.labelDate.Name = "labelDate";
      this.labelDate.Size = new Size(33, 13);
      this.labelDate.TabIndex = 3;
      this.labelDate.Text = "Дата";
      this.labelReferee.AutoSize = true;
      this.labelReferee.Location = new Point(26, 108);
      this.labelReferee.Name = "labelReferee";
      this.labelReferee.Size = new Size(60, 13);
      this.labelReferee.TabIndex = 4;
      this.labelReferee.Text = "Гол. суддя";
      this.textBoxMainReferee.Location = new Point(95, 105);
      this.textBoxMainReferee.Name = "textBoxMainReferee";
      this.textBoxMainReferee.Size = new Size(306, 20);
      this.textBoxMainReferee.TabIndex = 4;
      this.dateTimePickerDate.Location = new Point(95, 48);
      this.dateTimePickerDate.Name = "dateTimePickerDate";
      this.dateTimePickerDate.Size = new Size(200, 20);
      this.dateTimePickerDate.TabIndex = 2;
      this.labelPlace.AutoSize = true;
      this.labelPlace.Location = new Point(50, 79);
      this.labelPlace.Name = "labelPlace";
      this.labelPlace.Size = new Size(36, 13);
      this.labelPlace.TabIndex = 7;
      this.labelPlace.Text = "Місце";
      this.textBoxPlace.Location = new Point(95, 79);
      this.textBoxPlace.Name = "textBoxPlace";
      this.textBoxPlace.Size = new Size(306, 20);
      this.textBoxPlace.TabIndex = 3;
      this.textBoxMainSecretary.Location = new Point(95, 131);
      this.textBoxMainSecretary.Name = "textBoxMainSecretary";
      this.textBoxMainSecretary.Size = new Size(306, 20);
      this.textBoxMainSecretary.TabIndex = 5;
      this.labelSecretary.AutoSize = true;
      this.labelSecretary.Location = new Point(8, 134);
      this.labelSecretary.Name = "labelSecretary";
      this.labelSecretary.Size = new Size(78, 13);
      this.labelSecretary.TabIndex = 8;
      this.labelSecretary.Text = "Гол. секретар";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(413, 202);
      this.Controls.Add((Control) this.textBoxMainSecretary);
      this.Controls.Add((Control) this.labelSecretary);
      this.Controls.Add((Control) this.textBoxPlace);
      this.Controls.Add((Control) this.labelPlace);
      this.Controls.Add((Control) this.dateTimePickerDate);
      this.Controls.Add((Control) this.textBoxMainReferee);
      this.Controls.Add((Control) this.labelReferee);
      this.Controls.Add((Control) this.labelDate);
      this.Controls.Add((Control) this.textBoxTitle);
      this.Controls.Add((Control) this.labelTitle);
      this.Controls.Add((Control) this.buttonSave);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (CompetitionInfo);
      this.Text = nameof (CompetitionInfo);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
