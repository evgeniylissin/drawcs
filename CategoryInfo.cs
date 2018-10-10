// Decompiled with JetBrains decompiler
// Type: Draw.CategoryInfo
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
  public class CategoryInfo : Form
  {
    private IContainer components = (IContainer) null;
    private Label labelName;
    private TextBox textBoxName;
    private Label labelAgeMin;
    private NumericUpDown numericUpDownAgeMin;
    private NumericUpDown numericUpDownAgeMax;
    private Label labelWeightMin;
    private Label labelAgeMax;
    private NumericUpDown numericUpDownWeightMin;
    private Label labelSex;
    private Label labelWeightMax;
    private NumericUpDown numericUpDownWeightMax;
    private ComboBox comboBoxSex;
    private Button buttonAdd;
    private GroupBox groupBoxCategoryType;
    private RadioButton radioButtonTypeKumite;
    private RadioButton radioButtonTypeKata;
    private RadioButton radioButtonTypeFukugo;
    private RadioButton radioButtonTypeIrigumi;
    private Label label1;
    private NumericUpDown numericUpDownKuMax;
    private Label label2;
    private NumericUpDown numericUpDownKuMin;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.labelName = new Label();
      this.textBoxName = new TextBox();
      this.labelAgeMin = new Label();
      this.numericUpDownAgeMin = new NumericUpDown();
      this.numericUpDownAgeMax = new NumericUpDown();
      this.labelWeightMin = new Label();
      this.labelAgeMax = new Label();
      this.numericUpDownWeightMin = new NumericUpDown();
      this.labelSex = new Label();
      this.labelWeightMax = new Label();
      this.numericUpDownWeightMax = new NumericUpDown();
      this.comboBoxSex = new ComboBox();
      this.buttonAdd = new Button();
      this.groupBoxCategoryType = new GroupBox();
      this.radioButtonTypeIrigumi = new RadioButton();
      this.radioButtonTypeFukugo = new RadioButton();
      this.radioButtonTypeKumite = new RadioButton();
      this.radioButtonTypeKata = new RadioButton();
      this.label1 = new Label();
      this.numericUpDownKuMax = new NumericUpDown();
      this.label2 = new Label();
      this.numericUpDownKuMin = new NumericUpDown();
      this.numericUpDownAgeMin.BeginInit();
      this.numericUpDownAgeMax.BeginInit();
      this.numericUpDownWeightMin.BeginInit();
      this.numericUpDownWeightMax.BeginInit();
      this.groupBoxCategoryType.SuspendLayout();
      this.numericUpDownKuMax.BeginInit();
      this.numericUpDownKuMin.BeginInit();
      this.SuspendLayout();
      this.labelName.AutoSize = true;
      this.labelName.Location = new Point(30, 13);
      this.labelName.Name = "labelName";
      this.labelName.Size = new Size(59, 13);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "Категорія:";
      this.textBoxName.Location = new Point(117, 10);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new Size(163, 20);
      this.textBoxName.TabIndex = 1;
      this.labelAgeMin.AutoSize = true;
      this.labelAgeMin.Location = new Point(64, 34);
      this.labelAgeMin.Name = "labelAgeMin";
      this.labelAgeMin.Size = new Size(25, 13);
      this.labelAgeMin.TabIndex = 2;
      this.labelAgeMin.Text = "Вік:";
      this.numericUpDownAgeMin.Location = new Point(117, 32);
      this.numericUpDownAgeMin.Name = "numericUpDownAgeMin";
      this.numericUpDownAgeMin.Size = new Size(59, 20);
      this.numericUpDownAgeMin.TabIndex = 3;
      this.numericUpDownAgeMax.Location = new Point(198, 32);
      this.numericUpDownAgeMax.Name = "numericUpDownAgeMax";
      this.numericUpDownAgeMax.Size = new Size(59, 20);
      this.numericUpDownAgeMax.TabIndex = 5;
      this.labelWeightMin.AutoSize = true;
      this.labelWeightMin.Location = new Point(55, 60);
      this.labelWeightMin.Name = "labelWeightMin";
      this.labelWeightMin.Size = new Size(34, 13);
      this.labelWeightMin.TabIndex = 6;
      this.labelWeightMin.Text = "Вага:";
      this.labelAgeMax.AutoSize = true;
      this.labelAgeMax.Location = new Point(182, 34);
      this.labelAgeMax.Name = "labelAgeMax";
      this.labelAgeMax.Size = new Size(10, 13);
      this.labelAgeMax.TabIndex = 4;
      this.labelAgeMax.Text = "-";
      this.numericUpDownWeightMin.DecimalPlaces = 1;
      this.numericUpDownWeightMin.Location = new Point(117, 58);
      this.numericUpDownWeightMin.Name = "numericUpDownWeightMin";
      this.numericUpDownWeightMin.Size = new Size(59, 20);
      this.numericUpDownWeightMin.TabIndex = 7;
      this.labelSex.AutoSize = true;
      this.labelSex.Location = new Point(50, 88);
      this.labelSex.Name = "labelSex";
      this.labelSex.Size = new Size(39, 13);
      this.labelSex.TabIndex = 8;
      this.labelSex.Text = "Стать:";
      this.labelWeightMax.AutoSize = true;
      this.labelWeightMax.Location = new Point(182, 60);
      this.labelWeightMax.Name = "labelWeightMax";
      this.labelWeightMax.Size = new Size(10, 13);
      this.labelWeightMax.TabIndex = 9;
      this.labelWeightMax.Text = "-";
      this.numericUpDownWeightMax.DecimalPlaces = 1;
      this.numericUpDownWeightMax.Location = new Point(198, 58);
      this.numericUpDownWeightMax.Name = "numericUpDownWeightMax";
      this.numericUpDownWeightMax.Size = new Size(59, 20);
      this.numericUpDownWeightMax.TabIndex = 10;
      this.comboBoxSex.FormattingEnabled = true;
      this.comboBoxSex.Items.AddRange(new object[2]
      {
        (object) "M",
        (object) "F"
      });
      this.comboBoxSex.Location = new Point(117, 85);
      this.comboBoxSex.Name = "comboBoxSex";
      this.comboBoxSex.Size = new Size(59, 21);
      this.comboBoxSex.TabIndex = 11;
      this.comboBoxSex.Text = "M";
      this.buttonAdd.DialogResult = DialogResult.OK;
      this.buttonAdd.Location = new Point(205, 208);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new Size(75, 23);
      this.buttonAdd.TabIndex = 12;
      this.buttonAdd.Text = "Додати";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.groupBoxCategoryType.Controls.Add((Control) this.radioButtonTypeIrigumi);
      this.groupBoxCategoryType.Controls.Add((Control) this.radioButtonTypeFukugo);
      this.groupBoxCategoryType.Controls.Add((Control) this.radioButtonTypeKumite);
      this.groupBoxCategoryType.Controls.Add((Control) this.radioButtonTypeKata);
      this.groupBoxCategoryType.Location = new Point(17, 147);
      this.groupBoxCategoryType.Name = "groupBoxCategoryType";
      this.groupBoxCategoryType.Size = new Size(263, 58);
      this.groupBoxCategoryType.TabIndex = 13;
      this.groupBoxCategoryType.TabStop = false;
      this.groupBoxCategoryType.Text = "Тип";
      this.radioButtonTypeIrigumi.AutoSize = true;
      this.radioButtonTypeIrigumi.Location = new Point(195, 20);
      this.radioButtonTypeIrigumi.Name = "radioButtonTypeIrigumi";
      this.radioButtonTypeIrigumi.Size = new Size(56, 17);
      this.radioButtonTypeIrigumi.TabIndex = 3;
      this.radioButtonTypeIrigumi.TabStop = true;
      this.radioButtonTypeIrigumi.Text = "Ірігумі";
      this.radioButtonTypeIrigumi.UseVisualStyleBackColor = true;
      this.radioButtonTypeIrigumi.Visible = false;
      this.radioButtonTypeFukugo.AutoSize = true;
      this.radioButtonTypeFukugo.Location = new Point(129, 20);
      this.radioButtonTypeFukugo.Name = "radioButtonTypeFukugo";
      this.radioButtonTypeFukugo.Size = new Size(63, 17);
      this.radioButtonTypeFukugo.TabIndex = 2;
      this.radioButtonTypeFukugo.TabStop = true;
      this.radioButtonTypeFukugo.Text = "Фукуго";
      this.radioButtonTypeFukugo.UseVisualStyleBackColor = true;
      this.radioButtonTypeFukugo.Visible = false;
      this.radioButtonTypeKumite.AutoSize = true;
      this.radioButtonTypeKumite.Location = new Point(61, 20);
      this.radioButtonTypeKumite.Name = "radioButtonTypeKumite";
      this.radioButtonTypeKumite.Size = new Size(58, 17);
      this.radioButtonTypeKumite.TabIndex = 1;
      this.radioButtonTypeKumite.TabStop = true;
      this.radioButtonTypeKumite.Text = "Куміте";
      this.radioButtonTypeKumite.UseVisualStyleBackColor = true;
      this.radioButtonTypeKata.AutoSize = true;
      this.radioButtonTypeKata.Checked = true;
      this.radioButtonTypeKata.Location = new Point(7, 20);
      this.radioButtonTypeKata.Name = "radioButtonTypeKata";
      this.radioButtonTypeKata.Size = new Size(49, 17);
      this.radioButtonTypeKata.TabIndex = 0;
      this.radioButtonTypeKata.TabStop = true;
      this.radioButtonTypeKata.Text = "Ката";
      this.radioButtonTypeKata.UseVisualStyleBackColor = true;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(64, 113);
      this.label1.Name = "label1";
      this.label1.Size = new Size(25, 13);
      this.label1.TabIndex = 14;
      this.label1.Text = "Кю:";
      this.numericUpDownKuMax.Location = new Point(198, 111);
      this.numericUpDownKuMax.Name = "numericUpDownKuMax";
      this.numericUpDownKuMax.Size = new Size(59, 20);
      this.numericUpDownKuMax.TabIndex = 17;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(182, 113);
      this.label2.Name = "label2";
      this.label2.Size = new Size(10, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "-";
      this.numericUpDownKuMin.Location = new Point(117, 111);
      this.numericUpDownKuMin.Name = "numericUpDownKuMin";
      this.numericUpDownKuMin.Size = new Size(59, 20);
      this.numericUpDownKuMin.TabIndex = 15;
      this.numericUpDownKuMin.Value = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(292, 243);
      this.Controls.Add((Control) this.numericUpDownKuMax);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.numericUpDownKuMin);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBoxCategoryType);
      this.Controls.Add((Control) this.buttonAdd);
      this.Controls.Add((Control) this.comboBoxSex);
      this.Controls.Add((Control) this.numericUpDownWeightMax);
      this.Controls.Add((Control) this.labelWeightMax);
      this.Controls.Add((Control) this.labelSex);
      this.Controls.Add((Control) this.numericUpDownWeightMin);
      this.Controls.Add((Control) this.labelWeightMin);
      this.Controls.Add((Control) this.numericUpDownAgeMax);
      this.Controls.Add((Control) this.labelAgeMax);
      this.Controls.Add((Control) this.numericUpDownAgeMin);
      this.Controls.Add((Control) this.labelAgeMin);
      this.Controls.Add((Control) this.textBoxName);
      this.Controls.Add((Control) this.labelName);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (CategoryInfo);
      this.Text = nameof (CategoryInfo);
      this.numericUpDownAgeMin.EndInit();
      this.numericUpDownAgeMax.EndInit();
      this.numericUpDownWeightMin.EndInit();
      this.numericUpDownWeightMax.EndInit();
      this.groupBoxCategoryType.ResumeLayout(false);
      this.groupBoxCategoryType.PerformLayout();
      this.numericUpDownKuMax.EndInit();
      this.numericUpDownKuMin.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public CategoryInfo()
    {
      this.InitializeComponent();
    }

    public string getName()
    {
      return this.textBoxName.Text;
    }

    public CategoryFilter getInfo()
    {
      CategoryFilter categoryFilter = new CategoryFilter();
      categoryFilter.ageMin = Convert.ToInt32(this.numericUpDownAgeMin.Value);
      categoryFilter.ageMax = Convert.ToInt32(this.numericUpDownAgeMax.Value);
      categoryFilter.weightMin = Convert.ToDouble(this.numericUpDownWeightMin.Value);
      categoryFilter.weightMax = Convert.ToDouble(this.numericUpDownWeightMax.Value);
      categoryFilter.kuMin = Convert.ToInt32(this.numericUpDownKuMin.Value);
      categoryFilter.kuMax = Convert.ToInt32(this.numericUpDownKuMax.Value);
      categoryFilter.sex = this.comboBoxSex.SelectedItem == null ? "F" : this.comboBoxSex.SelectedItem.ToString();
      if (this.radioButtonTypeKata.Checked)
        categoryFilter.type = CategoryType.Kata;
      else if (this.radioButtonTypeKumite.Checked)
        categoryFilter.type = CategoryType.Kumite;
      else if (this.radioButtonTypeFukugo.Checked)
        categoryFilter.type = CategoryType.Fukugo;
      else if (this.radioButtonTypeIrigumi.Checked)
        categoryFilter.type = CategoryType.Irigumi;
      return categoryFilter;
    }
  }
}
