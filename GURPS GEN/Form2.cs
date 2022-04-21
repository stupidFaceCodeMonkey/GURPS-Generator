using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GURPS_GEN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      

        

       
        private void CB_doubles_left_check_changed(object sender, EventArgs e)
        {
            cb_Arm_R.Checked = cb_Arm_L.Checked;
            cb_Foot_R.Checked = cb_Foot_L.Checked;
            cb_Hand_R.Checked = cb_Hand_L.Checked;
            cb_Leg_R.Checked = cb_Leg_L.Checked;
        }

        private void CB_Doubles_right_check_changed(object sender, EventArgs e)
        {
            cb_Arm_L.Checked = cb_Arm_R.Checked;
            cb_Foot_L.Checked = cb_Foot_R.Checked;
            cb_Hand_L.Checked = cb_Hand_R.Checked;
            cb_Leg_L.Checked = cb_Leg_R.Checked;
        }

        private void Abdomen_CheckedChanged(object sender, EventArgs e)
        {
            Groin.Checked = Abdomen.Checked;
        }

        private void Torso_CheckedChanged(object sender, EventArgs e)
        {
            Vitals.Checked = Torso.Checked;
        }

        public Double Get_Coverage_Info(object sender, EventArgs e)
        {

          Double coverageInfo =Convert.ToDouble(Skull.Tag) * Convert.ToDouble(Skull.Checked) + Convert.ToDouble(Face.Tag) * Convert.ToDouble(Face.Checked) +
                Convert.ToDouble(Neck.Tag) * Convert.ToDouble(Neck.Checked) + Convert.ToDouble(Torso.Tag) * Convert.ToDouble(Torso.Checked) +
                Convert.ToDouble(Vitals.Tag) * Convert.ToDouble(Vitals.Checked) + Convert.ToDouble(Abdomen.Tag) * Convert.ToDouble(Abdomen.Checked)
                + Convert.ToDouble(Groin.Tag) * Convert.ToDouble(Groin.Checked) + Convert.ToDouble(cb_Arm_L.Tag) * Convert.ToDouble(cb_Arm_L.Checked) +
                Convert.ToDouble(cb_Hand_L.Tag) * Convert.ToDouble(cb_Hand_L.Checked) + Convert.ToDouble(cb_Leg_L.Tag) * Convert.ToDouble(cb_Leg_L.Checked)+
                Convert.ToDouble(cb_Foot_L.Tag) * Convert.ToDouble(cb_Foot_L.Checked);

            


            return coverageInfo;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                e.Cancel = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skull.Checked = Face.Checked = Neck.Checked = Torso.Checked = Vitals.Checked = Abdomen.Checked = Groin.Checked = cb_Arm_L.Checked = cb_Hand_L.Checked = cb_Leg_L.Checked = cb_Foot_L.Checked = false;
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            Skull.Checked = Face.Checked = Neck.Checked = Torso.Checked = Vitals.Checked = Abdomen.Checked = Groin.Checked = cb_Arm_L.Checked = cb_Hand_L.Checked = cb_Leg_L.Checked = cb_Foot_L.Checked = true;

        }
    }
}
