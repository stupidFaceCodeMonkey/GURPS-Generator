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
           
            cb_Foot_R.Checked = Feet.Checked;
            cb_Hand_R.Checked = Hands.Checked;
            
        }

        private void CB_Doubles_right_check_changed(object sender, EventArgs e)
        {
            
            Feet.Checked = cb_Foot_R.Checked;
            Hands.Checked = cb_Hand_R.Checked;
           
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
                + Convert.ToDouble(Groin.Tag) * Convert.ToDouble(Groin.Checked) + Convert.ToDouble(Shoulders.Tag) * Convert.ToDouble(Shoulders.Checked) +
                Convert.ToDouble(Upper_Arms.Tag) * Convert.ToDouble(Upper_Arms.Checked) + Convert.ToDouble(Elbows.Tag) * Convert.ToDouble(Elbows.Checked) +
                Convert.ToDouble(Forearms.Tag) * Convert.ToDouble(Forearms.Checked) +
                Convert.ToDouble(Hands.Tag) * Convert.ToDouble(Hands.Checked) + Convert.ToDouble(Thighs.Tag) * Convert.ToDouble(Thighs.Checked)+
                Convert.ToDouble(Knees.Tag) * Convert.ToDouble(Knees.Checked) + Convert.ToDouble(Shins.Tag) * Convert.ToDouble(Shins.Checked) +
                Convert.ToDouble(Feet.Tag) * Convert.ToDouble(Feet.Checked);//вычисляет сколько квадратных футов тела покрыты

            


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
            Skull.Checked = Face.Checked = Neck.Checked = Torso.Checked = Vitals.Checked = Abdomen.Checked = Groin.Checked = Arms.Checked = Hands.Checked = Legs.Checked = Feet.Checked = false;
            Leg_Click(null, null);
            Arm_Check_Changed(null, null);
            
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            Skull.Checked = Face.Checked = Neck.Checked = Torso.Checked = Vitals.Checked = Abdomen.Checked = Groin.Checked = Arms.Checked = Hands.Checked = Legs.Checked = Feet.Checked = true;
            Leg_Click(null,null);
            Arm_Check_Changed(null, null);
        }

        public string[] methodWhatHitZoneChecked()
        {
            CheckBox[] zones = {Skull, Face, Neck, Torso, Vitals, Abdomen, Groin, Arms, Shoulders, Upper_Arms, Elbows, Forearms, Hands, Legs, Thighs, Knees, Shins, Feet};
            string[] zoneName = new string [zones.Length+1];
            int loop = 0;
            
            while(loop < zones.Length)
            {
                
                if (zones[loop].Checked)
                {
                    zoneName[loop] = zones[loop].AccessibleName;
                }
                loop++;
            }
            if (zoneName.Contains("arms"))//удаляет упоминания сублокаций если выбрана целая локация
            {
                int i = Array.IndexOf(zoneName, "arms");
                zoneName[i + 1] = zoneName[i + 2] = zoneName[i + 3] = zoneName[i + 4] = null;
            }
            if (zoneName.Contains("legs"))
            {
                int i = Array.IndexOf(zoneName, "legs");
                zoneName[i + 1] = zoneName[i + 2] = zoneName[i + 3] = null;
            }
            if (zoneName.Contains("torso"))
            {
                int i = Array.IndexOf(zoneName, "torso");
                zoneName[i + 1] = null;
            }
            
            zoneName =zoneName.Where(c => c != null).ToArray(); //должно удалять пустые места
            
            return zoneName;
        }

        private void Arm_Check_Changed(object sender, EventArgs e)
        {
            if (Arms.Checked)
            {
                Upper_Arms.Checked = Shoulders.Checked = Elbows.Checked = Forearms.Checked = true;
            }
            else
            {
                Upper_Arms.Checked = Shoulders.Checked = Elbows.Checked = Forearms.Checked = false;

            }

        }
        private void SubArm_Check_Changed(object sender, EventArgs e)
        {
            if (Upper_Arms.Checked && Shoulders.Checked && Elbows.Checked && Forearms.Checked)
            {
                Arms.Checked = true;
            }
            else
            {
                Arms.Checked = false;
            }
        }

        private void Vitals_CheckedChanged(object sender, EventArgs e)
        {
            if (Vitals.Checked == false)
            {
                Torso.Checked = false;
            }
        }

        private void SubLegs_Checked_Changed(object sender, EventArgs e)
        {
            if(Thighs.Checked && Knees.Checked && Shins.Checked)
            {
                Legs.Checked = true;
            }
            else
            {
                Legs.Checked = false;
            }
        }

        private void Leg_Click(object sender, EventArgs e)
        {
            if (Legs.Checked)
            {
                 Thighs.Checked = Knees.Checked = Shins.Checked = true;
            }
            else
            {
                Thighs.Checked = Knees.Checked = Shins.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(null,null);
            
            Skull.Checked = Face.Checked = Neck.Checked = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(null, null);
            Torso.Checked = Abdomen.Checked = Arms.Checked = true;
            Groin.Checked = false;
            Arm_Check_Changed(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
            Legs.Checked = Groin.Checked = true;
            Leg_Click(null, null);
        }
    }
}
