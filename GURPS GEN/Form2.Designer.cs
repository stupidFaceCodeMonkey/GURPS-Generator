namespace GURPS_GEN
{
    partial class Form2
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
            this.Skull = new System.Windows.Forms.CheckBox();
            this.Face = new System.Windows.Forms.CheckBox();
            this.Neck = new System.Windows.Forms.CheckBox();
            this.Torso = new System.Windows.Forms.CheckBox();
            this.Abdomen = new System.Windows.Forms.CheckBox();
            this.Groin = new System.Windows.Forms.CheckBox();
            this.cb_Leg_L = new System.Windows.Forms.CheckBox();
            this.cb_Leg_R = new System.Windows.Forms.CheckBox();
            this.cb_Foot_L = new System.Windows.Forms.CheckBox();
            this.cb_Foot_R = new System.Windows.Forms.CheckBox();
            this.cb_Arm_R = new System.Windows.Forms.CheckBox();
            this.cb_Arm_L = new System.Windows.Forms.CheckBox();
            this.cb_Hand_R = new System.Windows.Forms.CheckBox();
            this.cb_Hand_L = new System.Windows.Forms.CheckBox();
            this.Vitals = new System.Windows.Forms.CheckBox();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonKillAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Skull
            // 
            this.Skull.Appearance = System.Windows.Forms.Appearance.Button;
            this.Skull.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Skull.Location = new System.Drawing.Point(229, 18);
            this.Skull.Name = "Skull";
            this.Skull.Size = new System.Drawing.Size(69, 24);
            this.Skull.TabIndex = 0;
            this.Skull.Tag = "1,4";
            this.Skull.Text = "Череп";
            this.Skull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Skull.UseVisualStyleBackColor = true;
            // 
            // Face
            // 
            this.Face.Appearance = System.Windows.Forms.Appearance.Button;
            this.Face.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Face.Location = new System.Drawing.Point(229, 47);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(69, 41);
            this.Face.TabIndex = 1;
            this.Face.Tag = "0,7";
            this.Face.Text = "Лицо";
            this.Face.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Face.UseVisualStyleBackColor = true;
            // 
            // Neck
            // 
            this.Neck.Appearance = System.Windows.Forms.Appearance.Button;
            this.Neck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Neck.Location = new System.Drawing.Point(241, 94);
            this.Neck.Name = "Neck";
            this.Neck.Size = new System.Drawing.Size(45, 41);
            this.Neck.TabIndex = 2;
            this.Neck.Tag = "0,35";
            this.Neck.Text = "Шея";
            this.Neck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Neck.UseVisualStyleBackColor = true;
            // 
            // Torso
            // 
            this.Torso.Appearance = System.Windows.Forms.Appearance.Button;
            this.Torso.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Torso.Location = new System.Drawing.Point(206, 141);
            this.Torso.Name = "Torso";
            this.Torso.Size = new System.Drawing.Size(114, 54);
            this.Torso.TabIndex = 3;
            this.Torso.Tag = "4,25";
            this.Torso.Text = "Торс";
            this.Torso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Torso.UseVisualStyleBackColor = true;
            this.Torso.CheckedChanged += new System.EventHandler(this.Torso_CheckedChanged);
            // 
            // Abdomen
            // 
            this.Abdomen.Appearance = System.Windows.Forms.Appearance.Button;
            this.Abdomen.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Abdomen.Location = new System.Drawing.Point(206, 237);
            this.Abdomen.Name = "Abdomen";
            this.Abdomen.Size = new System.Drawing.Size(114, 44);
            this.Abdomen.TabIndex = 4;
            this.Abdomen.Tag = "1,4";
            this.Abdomen.Text = "Живот";
            this.Abdomen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Abdomen.UseVisualStyleBackColor = true;
            this.Abdomen.CheckedChanged += new System.EventHandler(this.Abdomen_CheckedChanged);
            // 
            // Groin
            // 
            this.Groin.Appearance = System.Windows.Forms.Appearance.Button;
            this.Groin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Groin.Location = new System.Drawing.Point(241, 287);
            this.Groin.Name = "Groin";
            this.Groin.Size = new System.Drawing.Size(45, 41);
            this.Groin.TabIndex = 5;
            this.Groin.Tag = "0,35";
            this.Groin.Text = "Пах";
            this.Groin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Groin.UseVisualStyleBackColor = true;
            // 
            // cb_Leg_L
            // 
            this.cb_Leg_L.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Leg_L.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Leg_L.Location = new System.Drawing.Point(194, 287);
            this.cb_Leg_L.Name = "cb_Leg_L";
            this.cb_Leg_L.Size = new System.Drawing.Size(41, 135);
            this.cb_Leg_L.TabIndex = 6;
            this.cb_Leg_L.Tag = "7";
            this.cb_Leg_L.Text = "Ноги";
            this.cb_Leg_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Leg_L.UseVisualStyleBackColor = true;
            this.cb_Leg_L.CheckedChanged += new System.EventHandler(this.CB_doubles_left_check_changed);
            // 
            // cb_Leg_R
            // 
            this.cb_Leg_R.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Leg_R.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Leg_R.Location = new System.Drawing.Point(292, 287);
            this.cb_Leg_R.Name = "cb_Leg_R";
            this.cb_Leg_R.Size = new System.Drawing.Size(40, 135);
            this.cb_Leg_R.TabIndex = 7;
            this.cb_Leg_R.Tag = "TAG_doubles";
            this.cb_Leg_R.Text = "Нога";
            this.cb_Leg_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Leg_R.UseVisualStyleBackColor = true;
            this.cb_Leg_R.CheckedChanged += new System.EventHandler(this.CB_Doubles_right_check_changed);
            // 
            // cb_Foot_L
            // 
            this.cb_Foot_L.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Foot_L.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Foot_L.Location = new System.Drawing.Point(166, 428);
            this.cb_Foot_L.Name = "cb_Foot_L";
            this.cb_Foot_L.Size = new System.Drawing.Size(69, 34);
            this.cb_Foot_L.TabIndex = 8;
            this.cb_Foot_L.Tag = "0,7";
            this.cb_Foot_L.Text = "Ступни";
            this.cb_Foot_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Foot_L.UseVisualStyleBackColor = true;
            this.cb_Foot_L.CheckedChanged += new System.EventHandler(this.CB_doubles_left_check_changed);
            // 
            // cb_Foot_R
            // 
            this.cb_Foot_R.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Foot_R.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Foot_R.Location = new System.Drawing.Point(292, 428);
            this.cb_Foot_R.Name = "cb_Foot_R";
            this.cb_Foot_R.Size = new System.Drawing.Size(69, 34);
            this.cb_Foot_R.TabIndex = 9;
            this.cb_Foot_R.Tag = "TAG_doubles";
            this.cb_Foot_R.Text = "Ступни";
            this.cb_Foot_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Foot_R.UseVisualStyleBackColor = true;
            this.cb_Foot_R.CheckedChanged += new System.EventHandler(this.CB_Doubles_right_check_changed);
            // 
            // cb_Arm_R
            // 
            this.cb_Arm_R.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Arm_R.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Arm_R.Location = new System.Drawing.Point(326, 141);
            this.cb_Arm_R.Name = "cb_Arm_R";
            this.cb_Arm_R.Size = new System.Drawing.Size(130, 26);
            this.cb_Arm_R.TabIndex = 10;
            this.cb_Arm_R.Tag = "TAG_doubles";
            this.cb_Arm_R.Text = "Рука";
            this.cb_Arm_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Arm_R.UseVisualStyleBackColor = true;
            this.cb_Arm_R.CheckedChanged += new System.EventHandler(this.CB_Doubles_right_check_changed);
            // 
            // cb_Arm_L
            // 
            this.cb_Arm_L.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Arm_L.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Arm_L.Location = new System.Drawing.Point(71, 141);
            this.cb_Arm_L.Name = "cb_Arm_L";
            this.cb_Arm_L.Size = new System.Drawing.Size(129, 26);
            this.cb_Arm_L.TabIndex = 11;
            this.cb_Arm_L.Tag = "3,5";
            this.cb_Arm_L.Text = "Руки";
            this.cb_Arm_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Arm_L.UseVisualStyleBackColor = true;
            this.cb_Arm_L.CheckedChanged += new System.EventHandler(this.CB_doubles_left_check_changed);
            // 
            // cb_Hand_R
            // 
            this.cb_Hand_R.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Hand_R.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Hand_R.Location = new System.Drawing.Point(462, 141);
            this.cb_Hand_R.Name = "cb_Hand_R";
            this.cb_Hand_R.Size = new System.Drawing.Size(48, 41);
            this.cb_Hand_R.TabIndex = 12;
            this.cb_Hand_R.Tag = "TAG_doubles";
            this.cb_Hand_R.Text = "Кисти";
            this.cb_Hand_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Hand_R.UseVisualStyleBackColor = true;
            this.cb_Hand_R.CheckedChanged += new System.EventHandler(this.CB_Doubles_right_check_changed);
            // 
            // cb_Hand_L
            // 
            this.cb_Hand_L.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Hand_L.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Hand_L.Location = new System.Drawing.Point(17, 141);
            this.cb_Hand_L.Name = "cb_Hand_L";
            this.cb_Hand_L.Size = new System.Drawing.Size(48, 41);
            this.cb_Hand_L.TabIndex = 13;
            this.cb_Hand_L.Tag = "0,7";
            this.cb_Hand_L.Text = "Кисти";
            this.cb_Hand_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Hand_L.UseVisualStyleBackColor = true;
            this.cb_Hand_L.CheckedChanged += new System.EventHandler(this.CB_doubles_left_check_changed);
            // 
            // Vitals
            // 
            this.Vitals.Appearance = System.Windows.Forms.Appearance.Button;
            this.Vitals.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Vitals.Location = new System.Drawing.Point(206, 201);
            this.Vitals.Name = "Vitals";
            this.Vitals.Size = new System.Drawing.Size(114, 30);
            this.Vitals.TabIndex = 14;
            this.Vitals.Tag = "1";
            this.Vitals.Text = "ЖВО";
            this.Vitals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Vitals.UseVisualStyleBackColor = true;
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonCheckAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckAll.Location = new System.Drawing.Point(326, 25);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(184, 85);
            this.buttonCheckAll.TabIndex = 15;
            this.buttonCheckAll.Text = "Выбрать все";
            this.buttonCheckAll.UseVisualStyleBackColor = false;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonKillAll
            // 
            this.buttonKillAll.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonKillAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKillAll.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonKillAll.Location = new System.Drawing.Point(17, 25);
            this.buttonKillAll.Name = "buttonKillAll";
            this.buttonKillAll.Size = new System.Drawing.Size(183, 85);
            this.buttonKillAll.TabIndex = 16;
            this.buttonKillAll.Text = "Убрать все";
            this.buttonKillAll.UseVisualStyleBackColor = false;
            this.buttonKillAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 489);
            this.Controls.Add(this.buttonKillAll);
            this.Controls.Add(this.buttonCheckAll);
            this.Controls.Add(this.Vitals);
            this.Controls.Add(this.cb_Hand_L);
            this.Controls.Add(this.cb_Hand_R);
            this.Controls.Add(this.cb_Arm_L);
            this.Controls.Add(this.cb_Arm_R);
            this.Controls.Add(this.cb_Foot_R);
            this.Controls.Add(this.cb_Foot_L);
            this.Controls.Add(this.cb_Leg_R);
            this.Controls.Add(this.cb_Leg_L);
            this.Controls.Add(this.Groin);
            this.Controls.Add(this.Abdomen);
            this.Controls.Add(this.Torso);
            this.Controls.Add(this.Neck);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.Skull);
            this.Name = "Form2";
            this.Text = "Зоны попадания";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox Skull;
        public System.Windows.Forms.CheckBox Face;
        public System.Windows.Forms.CheckBox Neck;
        public System.Windows.Forms.CheckBox Torso;
        public System.Windows.Forms.CheckBox Abdomen;
        public System.Windows.Forms.CheckBox Groin;
        public System.Windows.Forms.CheckBox cb_Leg_L;
        public System.Windows.Forms.CheckBox cb_Leg_R;
        public System.Windows.Forms.CheckBox cb_Foot_L;
        public System.Windows.Forms.CheckBox cb_Foot_R;
        public System.Windows.Forms.CheckBox cb_Arm_R;
        public System.Windows.Forms.CheckBox cb_Arm_L;
        public System.Windows.Forms.CheckBox cb_Hand_R;
        public System.Windows.Forms.CheckBox cb_Hand_L;
        public System.Windows.Forms.CheckBox Vitals;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.Button buttonKillAll;
    }
}