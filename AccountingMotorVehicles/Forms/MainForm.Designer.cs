namespace AccountingMotorVehicles
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.typeVehicleLabel = new System.Windows.Forms.Label();
            this.vehcileTypeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.fuelTankVolumeTextBox = new System.Windows.Forms.TextBox();
            this.driveTypeTextBox = new System.Windows.Forms.TextBox();
            this.weightVehicleTextBox = new System.Windows.Forms.TextBox();
            this.fuelTankVolumeLabel = new System.Windows.Forms.Label();
            this.driveTypeLabel = new System.Windows.Forms.Label();
            this.weightVehicleLabel = new System.Windows.Forms.Label();
            this.transmissionTextBox = new System.Windows.Forms.TextBox();
            this.transmissionLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.engineBrandTextBox = new System.Windows.Forms.TextBox();
            this.modelEngineLabel = new System.Windows.Forms.Label();
            this.engineWeightLabel = new System.Windows.Forms.Label();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.moreAboutEngineBtn = new System.Windows.Forms.Button();
            this.modelEngineTextBox = new System.Windows.Forms.TextBox();
            this.engineWeightTextBox = new System.Windows.Forms.TextBox();
            this.torqueTextBox = new System.Windows.Forms.TextBox();
            this.engineTypeLabel = new System.Windows.Forms.Label();
            this.engineBrandLabel = new System.Windows.Forms.Label();
            this.engineTypeTextBox = new System.Windows.Forms.TextBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addVehicleBtn.Location = new System.Drawing.Point(912, 559);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(160, 40);
            this.addVehicleBtn.TabIndex = 4;
            this.addVehicleBtn.Text = "Додати ТЗ";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            this.addVehicleBtn.Click += new System.EventHandler(this.add_vehicle_Click);
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehiclesListBox.BackColor = System.Drawing.SystemColors.Control;
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.HorizontalScrollbar = true;
            this.vehiclesListBox.Location = new System.Drawing.Point(354, 14);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(729, 537);
            this.vehiclesListBox.TabIndex = 2;
            this.vehiclesListBox.SelectedIndexChanged += new System.EventHandler(this.vehiclesListBox_SelectedIndexChanged);
            // 
            // typeVehicleLabel
            // 
            this.typeVehicleLabel.AutoSize = true;
            this.typeVehicleLabel.Location = new System.Drawing.Point(6, 25);
            this.typeVehicleLabel.Name = "typeVehicleLabel";
            this.typeVehicleLabel.Size = new System.Drawing.Size(43, 13);
            this.typeVehicleLabel.TabIndex = 0;
            this.typeVehicleLabel.Text = "Тип ТЗ";
            // 
            // vehcileTypeTextBox
            // 
            this.vehcileTypeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.vehcileTypeTextBox.Location = new System.Drawing.Point(6, 42);
            this.vehcileTypeTextBox.Name = "vehcileTypeTextBox";
            this.vehcileTypeTextBox.ReadOnly = true;
            this.vehcileTypeTextBox.Size = new System.Drawing.Size(147, 20);
            this.vehcileTypeTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(this.modelLabel);
            this.groupBox1.Controls.Add(this.seatsTextBox);
            this.groupBox1.Controls.Add(this.seatsLabel);
            this.groupBox1.Controls.Add(this.fuelTankVolumeTextBox);
            this.groupBox1.Controls.Add(this.driveTypeTextBox);
            this.groupBox1.Controls.Add(this.weightVehicleTextBox);
            this.groupBox1.Controls.Add(this.fuelTankVolumeLabel);
            this.groupBox1.Controls.Add(this.driveTypeLabel);
            this.groupBox1.Controls.Add(this.weightVehicleLabel);
            this.groupBox1.Controls.Add(this.transmissionTextBox);
            this.groupBox1.Controls.Add(this.transmissionLabel);
            this.groupBox1.Controls.Add(this.brandTextBox);
            this.groupBox1.Controls.Add(this.brandLabel);
            this.groupBox1.Controls.Add(this.vehcileTypeTextBox);
            this.groupBox1.Controls.Add(this.typeVehicleLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ТЗ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lengthTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.widthTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.heightTextBox);
            this.groupBox3.Controls.Add(this.heightLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 83);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Габаритні розміри";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.lengthTextBox.Location = new System.Drawing.Point(215, 40);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.ReadOnly = true;
            this.lengthTextBox.Size = new System.Drawing.Size(97, 20);
            this.lengthTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Довжина (мм)";
            // 
            // widthTextBox
            // 
            this.widthTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.widthTextBox.Location = new System.Drawing.Point(111, 40);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.ReadOnly = true;
            this.widthTextBox.Size = new System.Drawing.Size(97, 20);
            this.widthTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина (мм)";
            // 
            // heightTextBox
            // 
            this.heightTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.heightTextBox.Location = new System.Drawing.Point(6, 40);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(97, 20);
            this.heightTextBox.TabIndex = 1;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 23);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(68, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Висота (мм)";
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.modelTextBox.Location = new System.Drawing.Point(6, 89);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(147, 20);
            this.modelTextBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(6, 72);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 13);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Модель";
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.seatsTextBox.Location = new System.Drawing.Point(166, 135);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.ReadOnly = true;
            this.seatsTextBox.Size = new System.Drawing.Size(160, 20);
            this.seatsTextBox.TabIndex = 11;
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Location = new System.Drawing.Point(166, 118);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(36, 13);
            this.seatsLabel.TabIndex = 10;
            this.seatsLabel.Text = "Місць";
            // 
            // fuelTankVolumeTextBox
            // 
            this.fuelTankVolumeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.fuelTankVolumeTextBox.Location = new System.Drawing.Point(166, 182);
            this.fuelTankVolumeTextBox.Name = "fuelTankVolumeTextBox";
            this.fuelTankVolumeTextBox.ReadOnly = true;
            this.fuelTankVolumeTextBox.Size = new System.Drawing.Size(160, 20);
            this.fuelTankVolumeTextBox.TabIndex = 15;
            // 
            // driveTypeTextBox
            // 
            this.driveTypeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.driveTypeTextBox.Location = new System.Drawing.Point(166, 89);
            this.driveTypeTextBox.Name = "driveTypeTextBox";
            this.driveTypeTextBox.ReadOnly = true;
            this.driveTypeTextBox.Size = new System.Drawing.Size(160, 20);
            this.driveTypeTextBox.TabIndex = 7;
            // 
            // weightVehicleTextBox
            // 
            this.weightVehicleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.weightVehicleTextBox.Location = new System.Drawing.Point(7, 182);
            this.weightVehicleTextBox.Name = "weightVehicleTextBox";
            this.weightVehicleTextBox.ReadOnly = true;
            this.weightVehicleTextBox.Size = new System.Drawing.Size(146, 20);
            this.weightVehicleTextBox.TabIndex = 13;
            // 
            // fuelTankVolumeLabel
            // 
            this.fuelTankVolumeLabel.AutoSize = true;
            this.fuelTankVolumeLabel.Location = new System.Drawing.Point(166, 165);
            this.fuelTankVolumeLabel.Name = "fuelTankVolumeLabel";
            this.fuelTankVolumeLabel.Size = new System.Drawing.Size(79, 13);
            this.fuelTankVolumeLabel.TabIndex = 14;
            this.fuelTankVolumeLabel.Text = "Об\'єм бака (л)";
            // 
            // driveTypeLabel
            // 
            this.driveTypeLabel.AutoSize = true;
            this.driveTypeLabel.Location = new System.Drawing.Point(166, 72);
            this.driveTypeLabel.Name = "driveTypeLabel";
            this.driveTypeLabel.Size = new System.Drawing.Size(41, 13);
            this.driveTypeLabel.TabIndex = 6;
            this.driveTypeLabel.Text = "Привід";
            // 
            // weightVehicleLabel
            // 
            this.weightVehicleLabel.AutoSize = true;
            this.weightVehicleLabel.Location = new System.Drawing.Point(7, 165);
            this.weightVehicleLabel.Name = "weightVehicleLabel";
            this.weightVehicleLabel.Size = new System.Drawing.Size(51, 13);
            this.weightVehicleLabel.TabIndex = 12;
            this.weightVehicleLabel.Text = "Вага (кг)";
            // 
            // transmissionTextBox
            // 
            this.transmissionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.transmissionTextBox.Location = new System.Drawing.Point(7, 135);
            this.transmissionTextBox.Name = "transmissionTextBox";
            this.transmissionTextBox.ReadOnly = true;
            this.transmissionTextBox.Size = new System.Drawing.Size(146, 20);
            this.transmissionTextBox.TabIndex = 9;
            // 
            // transmissionLabel
            // 
            this.transmissionLabel.AutoSize = true;
            this.transmissionLabel.Location = new System.Drawing.Point(7, 118);
            this.transmissionLabel.Name = "transmissionLabel";
            this.transmissionLabel.Size = new System.Drawing.Size(62, 13);
            this.transmissionLabel.TabIndex = 8;
            this.transmissionLabel.Text = "Трансмісія";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.brandTextBox.Location = new System.Drawing.Point(166, 42);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(160, 20);
            this.brandTextBox.TabIndex = 3;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(166, 25);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(40, 13);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Марка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.engineBrandTextBox);
            this.groupBox2.Controls.Add(this.modelEngineLabel);
            this.groupBox2.Controls.Add(this.engineWeightLabel);
            this.groupBox2.Controls.Add(this.powerTextBox);
            this.groupBox2.Controls.Add(this.modelEngineTextBox);
            this.groupBox2.Controls.Add(this.engineWeightTextBox);
            this.groupBox2.Controls.Add(this.torqueTextBox);
            this.groupBox2.Controls.Add(this.engineTypeLabel);
            this.groupBox2.Controls.Add(this.engineBrandLabel);
            this.groupBox2.Controls.Add(this.engineTypeTextBox);
            this.groupBox2.Controls.Add(this.powerLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Двигун";
            // 
            // engineBrandTextBox
            // 
            this.engineBrandTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.engineBrandTextBox.Location = new System.Drawing.Point(166, 43);
            this.engineBrandTextBox.Name = "engineBrandTextBox";
            this.engineBrandTextBox.ReadOnly = true;
            this.engineBrandTextBox.Size = new System.Drawing.Size(158, 20);
            this.engineBrandTextBox.TabIndex = 3;
            // 
            // modelEngineLabel
            // 
            this.modelEngineLabel.AutoSize = true;
            this.modelEngineLabel.Location = new System.Drawing.Point(6, 72);
            this.modelEngineLabel.Name = "modelEngineLabel";
            this.modelEngineLabel.Size = new System.Drawing.Size(46, 13);
            this.modelEngineLabel.TabIndex = 8;
            this.modelEngineLabel.Text = "Модель";
            // 
            // engineWeightLabel
            // 
            this.engineWeightLabel.AutoSize = true;
            this.engineWeightLabel.Location = new System.Drawing.Point(6, 118);
            this.engineWeightLabel.Name = "engineWeightLabel";
            this.engineWeightLabel.Size = new System.Drawing.Size(51, 13);
            this.engineWeightLabel.TabIndex = 8;
            this.engineWeightLabel.Text = "Вага (кг)";
            // 
            // powerTextBox
            // 
            this.powerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.powerTextBox.Location = new System.Drawing.Point(166, 89);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.ReadOnly = true;
            this.powerTextBox.Size = new System.Drawing.Size(158, 20);
            this.powerTextBox.TabIndex = 7;
            // 
            // moreAboutEngineBtn
            // 
            this.moreAboutEngineBtn.Location = new System.Drawing.Point(12, 510);
            this.moreAboutEngineBtn.Name = "moreAboutEngineBtn";
            this.moreAboutEngineBtn.Size = new System.Drawing.Size(336, 40);
            this.moreAboutEngineBtn.TabIndex = 10;
            this.moreAboutEngineBtn.Text = "Детальніше";
            this.moreAboutEngineBtn.UseVisualStyleBackColor = true;
            this.moreAboutEngineBtn.Click += new System.EventHandler(this.moreAboutEngineBtn_Click);
            // 
            // modelEngineTextBox
            // 
            this.modelEngineTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.modelEngineTextBox.Location = new System.Drawing.Point(6, 89);
            this.modelEngineTextBox.Name = "modelEngineTextBox";
            this.modelEngineTextBox.ReadOnly = true;
            this.modelEngineTextBox.Size = new System.Drawing.Size(146, 20);
            this.modelEngineTextBox.TabIndex = 9;
            // 
            // engineWeightTextBox
            // 
            this.engineWeightTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.engineWeightTextBox.Location = new System.Drawing.Point(6, 135);
            this.engineWeightTextBox.Name = "engineWeightTextBox";
            this.engineWeightTextBox.ReadOnly = true;
            this.engineWeightTextBox.Size = new System.Drawing.Size(146, 20);
            this.engineWeightTextBox.TabIndex = 9;
            // 
            // torqueTextBox
            // 
            this.torqueTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.torqueTextBox.Location = new System.Drawing.Point(166, 135);
            this.torqueTextBox.Name = "torqueTextBox";
            this.torqueTextBox.ReadOnly = true;
            this.torqueTextBox.Size = new System.Drawing.Size(158, 20);
            this.torqueTextBox.TabIndex = 5;
            // 
            // engineTypeLabel
            // 
            this.engineTypeLabel.AutoSize = true;
            this.engineTypeLabel.Location = new System.Drawing.Point(6, 26);
            this.engineTypeLabel.Name = "engineTypeLabel";
            this.engineTypeLabel.Size = new System.Drawing.Size(69, 13);
            this.engineTypeLabel.TabIndex = 0;
            this.engineTypeLabel.Text = "Тип двигуна";
            // 
            // engineBrandLabel
            // 
            this.engineBrandLabel.AutoSize = true;
            this.engineBrandLabel.Location = new System.Drawing.Point(166, 26);
            this.engineBrandLabel.Name = "engineBrandLabel";
            this.engineBrandLabel.Size = new System.Drawing.Size(40, 13);
            this.engineBrandLabel.TabIndex = 2;
            this.engineBrandLabel.Text = "Марка";
            // 
            // engineTypeTextBox
            // 
            this.engineTypeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.engineTypeTextBox.Location = new System.Drawing.Point(6, 43);
            this.engineTypeTextBox.Name = "engineTypeTextBox";
            this.engineTypeTextBox.ReadOnly = true;
            this.engineTypeTextBox.Size = new System.Drawing.Size(146, 20);
            this.engineTypeTextBox.TabIndex = 1;
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(166, 72);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(103, 13);
            this.powerLabel.TabIndex = 6;
            this.powerLabel.Text = "Потужність (к. сил)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vehiclesListBox);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.moreAboutEngineBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система обліку авт. ТЗ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Label typeVehicleLabel;
        private System.Windows.Forms.TextBox vehcileTypeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox transmissionTextBox;
        private System.Windows.Forms.Label transmissionLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.TextBox driveTypeTextBox;
        private System.Windows.Forms.TextBox weightVehicleTextBox;
        private System.Windows.Forms.Label driveTypeLabel;
        private System.Windows.Forms.Label weightVehicleLabel;
        private System.Windows.Forms.TextBox fuelTankVolumeTextBox;
        private System.Windows.Forms.Label fuelTankVolumeLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox engineBrandTextBox;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Button moreAboutEngineBtn;
        private System.Windows.Forms.TextBox torqueTextBox;
        private System.Windows.Forms.Label engineTypeLabel;
        private System.Windows.Forms.Label engineBrandLabel;
        private System.Windows.Forms.TextBox engineTypeTextBox;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label engineWeightLabel;
        private System.Windows.Forms.TextBox engineWeightTextBox;
        private System.Windows.Forms.Label modelEngineLabel;
        private System.Windows.Forms.TextBox modelEngineTextBox;
    }
}

