namespace GURPS_GEN
{
    partial class Form3
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
            this.Combox_Material = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboxCrossection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUDDrawWeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numUDThiccness = new System.Windows.Forms.NumericUpDown();
            this.numUDWorkingLenght = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numUDn_Crossection = new System.Windows.Forms.NumericUpDown();
            this.numUDDrawLenght = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Go_Button = new System.Windows.Forms.Button();
            this.CBisCinematic = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.numUDArrowWeight = new System.Windows.Forms.NumericUpDown();
            this.numUDloops = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CBArrowMaterial = new System.Windows.Forms.ComboBox();
            this.CBArrowHeads = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBMinThicness = new System.Windows.Forms.TextBox();
            this.TBMaxDraw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDrawWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThiccness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkingLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDn_Crossection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDrawLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDArrowWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDloops)).BeginInit();
            this.SuspendLayout();
            // 
            // Combox_Material
            // 
            this.Combox_Material.FormattingEnabled = true;
            this.Combox_Material.Location = new System.Drawing.Point(16, 33);
            this.Combox_Material.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Combox_Material.Name = "Combox_Material";
            this.Combox_Material.Size = new System.Drawing.Size(824, 25);
            this.Combox_Material.TabIndex = 0;
            this.Combox_Material.SelectedIndexChanged += new System.EventHandler(this.MaterialChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Материал плеч";
            // 
            // ComboxCrossection
            // 
            this.ComboxCrossection.FormattingEnabled = true;
            this.ComboxCrossection.Items.AddRange(new object[] {
            "Прямые плечи",
            "Рекурсивные плечи",
            "Рефлекс плечи",
            "Композитные плечи"});
            this.ComboxCrossection.Location = new System.Drawing.Point(16, 85);
            this.ComboxCrossection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboxCrossection.Name = "ComboxCrossection";
            this.ComboxCrossection.Size = new System.Drawing.Size(331, 25);
            this.ComboxCrossection.TabIndex = 2;
            this.ComboxCrossection.SelectedIndexChanged += new System.EventHandler(this.ComboxCrossection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Плечи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Толщина лука";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(871, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Минимум подъемной силы";
            // 
            // numUDDrawWeight
            // 
            this.numUDDrawWeight.Location = new System.Drawing.Point(875, 33);
            this.numUDDrawWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDDrawWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDDrawWeight.Name = "numUDDrawWeight";
            this.numUDDrawWeight.Size = new System.Drawing.Size(160, 25);
            this.numUDDrawWeight.TabIndex = 7;
            this.numUDDrawWeight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUDDrawWeight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numUDDrawWeight.Click += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numUDDrawWeight.Enter += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numUDDrawWeight.Leave += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(871, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Натяжение лука";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(875, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(875, 139);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(160, 25);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(871, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Подъемная сила персонажа";
            // 
            // numUDThiccness
            // 
            this.numUDThiccness.DecimalPlaces = 2;
            this.numUDThiccness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUDThiccness.Location = new System.Drawing.Point(16, 139);
            this.numUDThiccness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDThiccness.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numUDThiccness.Name = "numUDThiccness";
            this.numUDThiccness.Size = new System.Drawing.Size(160, 25);
            this.numUDThiccness.TabIndex = 12;
            this.numUDThiccness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDThiccness.ValueChanged += new System.EventHandler(this.numUDThiccness_ValueChanged);
            // 
            // numUDWorkingLenght
            // 
            this.numUDWorkingLenght.Location = new System.Drawing.Point(75, 246);
            this.numUDWorkingLenght.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDWorkingLenght.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDWorkingLenght.Name = "numUDWorkingLenght";
            this.numUDWorkingLenght.Size = new System.Drawing.Size(160, 25);
            this.numUDWorkingLenght.TabIndex = 13;
            this.numUDWorkingLenght.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numUDWorkingLenght.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Высота плечей";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Соотношение сторон среза";
            // 
            // numUDn_Crossection
            // 
            this.numUDn_Crossection.DecimalPlaces = 2;
            this.numUDn_Crossection.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numUDn_Crossection.Location = new System.Drawing.Point(75, 192);
            this.numUDn_Crossection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDn_Crossection.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUDn_Crossection.Name = "numUDn_Crossection";
            this.numUDn_Crossection.Size = new System.Drawing.Size(160, 25);
            this.numUDn_Crossection.TabIndex = 16;
            this.numUDn_Crossection.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUDn_Crossection.ValueChanged += new System.EventHandler(this.numUDn_Crossection_ValueChanged);
            // 
            // numUDDrawLenght
            // 
            this.numUDDrawLenght.Location = new System.Drawing.Point(16, 298);
            this.numUDDrawLenght.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDDrawLenght.Name = "numUDDrawLenght";
            this.numUDDrawLenght.Size = new System.Drawing.Size(160, 25);
            this.numUDDrawLenght.TabIndex = 17;
            this.numUDDrawLenght.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUDDrawLenght.ValueChanged += new System.EventHandler(this.numUDDrawLenght_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Длинна оттягивания";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 384);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Высота негнущейся части";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(75, 407);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 25);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged_2);
            // 
            // Go_Button
            // 
            this.Go_Button.Location = new System.Drawing.Point(860, 501);
            this.Go_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Go_Button.Name = "Go_Button";
            this.Go_Button.Size = new System.Drawing.Size(216, 72);
            this.Go_Button.TabIndex = 21;
            this.Go_Button.Text = "Lets crash this app";
            this.Go_Button.UseVisualStyleBackColor = true;
            this.Go_Button.Click += new System.EventHandler(this.Go_Button_Click);
            // 
            // CBisCinematic
            // 
            this.CBisCinematic.AutoSize = true;
            this.CBisCinematic.Location = new System.Drawing.Point(875, 178);
            this.CBisCinematic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBisCinematic.Name = "CBisCinematic";
            this.CBisCinematic.Size = new System.Drawing.Size(172, 21);
            this.CBisCinematic.TabIndex = 22;
            this.CBisCinematic.Text = "Кинематографичность";
            this.CBisCinematic.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Максимум оттягивания";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 118);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Минимальная толщина лука";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(16, 501);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(581, 162);
            this.OutputTextBox.TabIndex = 27;
            // 
            // numUDArrowWeight
            // 
            this.numUDArrowWeight.DecimalPlaces = 4;
            this.numUDArrowWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numUDArrowWeight.Location = new System.Drawing.Point(393, 352);
            this.numUDArrowWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDArrowWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numUDArrowWeight.Name = "numUDArrowWeight";
            this.numUDArrowWeight.ReadOnly = true;
            this.numUDArrowWeight.Size = new System.Drawing.Size(160, 25);
            this.numUDArrowWeight.TabIndex = 28;
            this.numUDArrowWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDArrowWeight.ValueChanged += new System.EventHandler(this.numUDArrowWeight_ValueChanged);
            // 
            // numUDloops
            // 
            this.numUDloops.Location = new System.Drawing.Point(75, 352);
            this.numUDloops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDloops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDloops.Name = "numUDloops";
            this.numUDloops.Size = new System.Drawing.Size(160, 25);
            this.numUDloops.TabIndex = 29;
            this.numUDloops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 331);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Обороты тетивы";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(389, 224);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Материал стрелы";
            // 
            // CBArrowMaterial
            // 
            this.CBArrowMaterial.FormattingEnabled = true;
            this.CBArrowMaterial.Location = new System.Drawing.Point(393, 245);
            this.CBArrowMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBArrowMaterial.Name = "CBArrowMaterial";
            this.CBArrowMaterial.Size = new System.Drawing.Size(640, 25);
            this.CBArrowMaterial.TabIndex = 31;
            this.CBArrowMaterial.SelectedIndexChanged += new System.EventHandler(this.CBArrowMaterial_SelectedIndexChanged);
            // 
            // CBArrowHeads
            // 
            this.CBArrowHeads.FormattingEnabled = true;
            this.CBArrowHeads.Location = new System.Drawing.Point(393, 299);
            this.CBArrowHeads.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBArrowHeads.Name = "CBArrowHeads";
            this.CBArrowHeads.Size = new System.Drawing.Size(640, 25);
            this.CBArrowHeads.TabIndex = 33;
            this.CBArrowHeads.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(389, 331);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Масса стрелы";
            // 
            // TBMinThicness
            // 
            this.TBMinThicness.Location = new System.Drawing.Point(184, 137);
            this.TBMinThicness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBMinThicness.Name = "TBMinThicness";
            this.TBMinThicness.ReadOnly = true;
            this.TBMinThicness.Size = new System.Drawing.Size(132, 25);
            this.TBMinThicness.TabIndex = 35;
            // 
            // TBMaxDraw
            // 
            this.TBMaxDraw.Location = new System.Drawing.Point(184, 297);
            this.TBMaxDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBMaxDraw.Name = "TBMaxDraw";
            this.TBMaxDraw.ReadOnly = true;
            this.TBMaxDraw.Size = new System.Drawing.Size(132, 25);
            this.TBMaxDraw.TabIndex = 36;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 690);
            this.Controls.Add(this.TBMaxDraw);
            this.Controls.Add(this.TBMinThicness);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CBArrowHeads);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CBArrowMaterial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numUDloops);
            this.Controls.Add(this.numUDArrowWeight);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CBisCinematic);
            this.Controls.Add(this.Go_Button);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numUDDrawLenght);
            this.Controls.Add(this.numUDn_Crossection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numUDWorkingLenght);
            this.Controls.Add(this.numUDThiccness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUDDrawWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboxCrossection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combox_Material);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Создание луков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDDrawWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThiccness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkingLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDn_Crossection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDrawLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDArrowWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDloops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combox_Material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboxCrossection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUDDrawWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUDThiccness;
        private System.Windows.Forms.NumericUpDown numUDWorkingLenght;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numUDn_Crossection;
        private System.Windows.Forms.NumericUpDown numUDDrawLenght;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button Go_Button;
        private System.Windows.Forms.CheckBox CBisCinematic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.NumericUpDown numUDArrowWeight;
        private System.Windows.Forms.NumericUpDown numUDloops;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CBArrowMaterial;
        private System.Windows.Forms.ComboBox CBArrowHeads;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBMinThicness;
        private System.Windows.Forms.TextBox TBMaxDraw;
    }
}