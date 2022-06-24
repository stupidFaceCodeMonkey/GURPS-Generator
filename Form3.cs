using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GURPS_GEN
{
    public partial class Form3 : Form
    {
        Material mainMaterial = new Material();
        Material arrowMaterial = new Material();
        Bowstuff bow = new Bowstuff();
        Arrowstuff arrow = new Arrowstuff();
        ArrowHead arrowTip = new ArrowHead();

        
        public Material Met_GetMaterialFromString(string stringDataOfMaterial)
        {
            Material definedMaterial = new Material();
            
            definedMaterial.Name = stringDataOfMaterial.Substring((stringDataOfMaterial.IndexOf("Name:\""))+6, stringDataOfMaterial.IndexOf("\" ", stringDataOfMaterial.IndexOf("Name:\"")) - stringDataOfMaterial.IndexOf("Name:\"") - 6) ;
            Console.WriteLine(definedMaterial.Name);
            


             definedMaterial.Dencity =Convert.ToDouble(stringDataOfMaterial.Substring((stringDataOfMaterial.IndexOf("Density(p):\"")) + 12, stringDataOfMaterial.IndexOf("\" ", stringDataOfMaterial.IndexOf("Density(p):\"")) - stringDataOfMaterial.IndexOf("Density(p):\"") - 12));

             definedMaterial.Breaking = Convert.ToDouble(stringDataOfMaterial.Substring((stringDataOfMaterial.IndexOf("Breaking(B):\"")) + 13, stringDataOfMaterial.IndexOf("\" ", stringDataOfMaterial.IndexOf("Breaking(B):\"")) - stringDataOfMaterial.IndexOf("Breaking(B):\"") - 13));

             definedMaterial.Elastic = Convert.ToDouble(stringDataOfMaterial.Substring((stringDataOfMaterial.IndexOf("Elastic(E):\"")) + 12, stringDataOfMaterial.IndexOf("\" ", stringDataOfMaterial.IndexOf("Elastic(E):\"")) - stringDataOfMaterial.IndexOf("Elastic(E):\"") - 12));

             definedMaterial.Buckling = Convert.ToDouble(stringDataOfMaterial.Substring((stringDataOfMaterial.IndexOf("Buckling(A):\"")) + 13, stringDataOfMaterial.IndexOf("\" ", stringDataOfMaterial.IndexOf("Buckling(A):\"")) - stringDataOfMaterial.IndexOf("Buckling(A):\"") - 13));

             definedMaterial.BowCost = Convert.ToDouble(stringDataOfMaterial.Substring((stringDataOfMaterial.IndexOf("CostPerPound:\"")) + 14, stringDataOfMaterial.IndexOf("\" ", stringDataOfMaterial.IndexOf("CostPerPound:\"")) - stringDataOfMaterial.IndexOf("CostPerPound:\"") - 14));

             definedMaterial.ArrowCost = Convert.ToDouble(stringDataOfMaterial.Substring((stringDataOfMaterial.IndexOf("ArrowCost:\"")) + 11, stringDataOfMaterial.IndexOf("\" ", stringDataOfMaterial.IndexOf("ArrowCost:\"")) - stringDataOfMaterial.IndexOf("ArrowCost:\"") - 11));



            return definedMaterial;
        }//пережевывает строку материала в пожираемые прогой циферы
        public Form3()
        {
            InitializeComponent();
            Combox_Material.Items.AddRange(File.ReadAllLines("Resources/BowMaterials.txt"));//take info from txt file
            CBArrowMaterial.Items.AddRange(Combox_Material.Items.Cast<Object>().ToArray());
            CBArrowHeads.Items.AddRange(File.ReadAllLines("Resources/Arrow head.txt"));
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void MaterialChanged(object sender, EventArgs e)
        {
            if(Combox_Material.SelectedItem != null)
            {
                mainMaterial = Met_GetMaterialFromString(Combox_Material.SelectedItem.ToString());
                //shoud force user to pick material
            }


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (Combox_Material.SelectedItem == null) { Combox_Material.DroppedDown = true; }
            else if (ComboxCrossection.SelectedItem == null) { ComboxCrossection.DroppedDown = true; }
            else if (CBArrowMaterial.SelectedItem == null) { CBArrowMaterial.DroppedDown = true; }
            else if (CBArrowHeads.SelectedItem == null) { CBArrowHeads.DroppedDown = true; }
            else
            {
                bow.Thickness = Convert.ToDouble(numUDThiccness.Value);
                bow.BowWorkLenghtInches = Convert.ToInt32(numUDWorkingLenght.Value);
                bow.BowUselessLenghtInches = Convert.ToInt32(numericUpDown2.Value);

                bow.CrossSection = Convert.ToDouble(numUDn_Crossection.Value);
                bow.DrawWeightLbs = Convert.ToInt32(numUDDrawWeight.Value);
                bow.Deflection = BowCalculator.Met_Deflection(12 / bow.CrossSection, bow.DrawWeightLbs, bow.BowWorkLenghtInches, mainMaterial.Elastic, bow.Thickness);
                bow.Theta = BowCalculator.Met_ThetaCalculation(bow.Deflection, bow.BowWorkLenghtInches);
                bow.DrawLenghtMax =Math.Round(BowCalculator.Met_MaxDrawLenght(Convert.ToInt32(numUDloops.Value), bow.BowUselessLenghtInches, bow.BowWorkLenghtInches, bow.Theta, bow.Deflection));
                TBMaxDraw.Text = Convert.ToString(bow.DrawLenghtMax);
                TBMinThicness.Text = Convert.ToString(Math.Round(BowCalculator.Met_MinThicness(12 / bow.CrossSection, bow.DrawWeightLbs, bow.BowWorkLenghtInches, mainMaterial.Breaking / bow.Limbstuff.breakingStrenghtDivider),2));

            }
        }

        private void numUDThiccness_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2_ValueChanged(Go_Button, null);

        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            numericUpDown2_ValueChanged(Go_Button, null);

        }

        private void numUDn_Crossection_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2_ValueChanged(Go_Button, null);
        }

        private void numUDDrawLenght_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2_ValueChanged(Go_Button, null);
        }

        private void numericUpDown2_ValueChanged_2(object sender, EventArgs e)
        {
            numericUpDown2_ValueChanged(Go_Button, null);
        }

        private void Go_Button_Click(object sender, EventArgs e)//all the stuff calculated
        {
            if (Combox_Material.SelectedItem == null) { Combox_Material.DroppedDown = true; }
            else if (ComboxCrossection.SelectedItem == null) { ComboxCrossection.DroppedDown = true; }
            else if (CBArrowMaterial.SelectedItem == null) { CBArrowMaterial.DroppedDown = true; }
            else if (CBArrowHeads.SelectedItem == null) { CBArrowHeads.DroppedDown = true; }
            else
            {
                
                bow.Thickness = Convert.ToDouble(numUDThiccness.Value);
                bow.BowWorkLenghtInches = Convert.ToInt32(numUDWorkingLenght.Value);
                bow.BowUselessLenghtInches = Convert.ToInt32(numericUpDown2.Value);

                bow.CrossSection = Convert.ToDouble(numUDn_Crossection.Value);
                bow.DrawWeightLbs = Convert.ToInt32(numUDDrawWeight.Value);
                bow.Deflection = BowCalculator.Met_Deflection(12 / bow.CrossSection, bow.DrawWeightLbs, bow.BowWorkLenghtInches, mainMaterial.Elastic, bow.Thickness);
                bow.Theta = BowCalculator.Met_ThetaCalculation(bow.Deflection, bow.BowWorkLenghtInches);
                bow.DrawLenghtMax = Math.Round(BowCalculator.Met_MaxDrawLenght(Convert.ToInt32(numUDloops.Value), bow.BowUselessLenghtInches, bow.BowWorkLenghtInches, bow.Theta, bow.Deflection));
                TBMaxDraw.Text = Convert.ToString(bow.DrawLenghtMax);
                TBMinThicness.Text = Convert.ToString(Math.Round(BowCalculator.Met_MinThicness(12 / bow.CrossSection, bow.DrawWeightLbs, bow.BowWorkLenghtInches, mainMaterial.Breaking / bow.Limbstuff.breakingStrenghtDivider),2));
                bow.DrawLenghtInches = Convert.ToInt32(numUDDrawLenght.Value);
                bow.BowWeight = BowCalculator.Met_BowWeight(mainMaterial.Dencity, bow.BowWorkLenghtInches, bow.Thickness, bow.CrossSection, 0, 0);
                bow.StoredEnergy = BowCalculator.Met_StoredEnergy(bow.DrawWeightLbs, bow.DrawLenghtInches, bow.Limbstuff.potentialEnergyMod);//done
                arrow.bowDrawWeight = bow.DrawWeightLbs;
                arrow.lenght = bow.DrawLenghtInches;
                arrow.weight = ArrowCalculator.Met_DiameterNMass(arrow.bowDrawWeight, arrow.lenght, arrowMaterial.Elastic, arrowMaterial.Dencity, false, 0);
                arrow.weight = arrowTip.arrowHeadWeight+arrow.weight ;
                numUDArrowWeight.Value =Convert.ToDecimal(arrow.weight);
                bow.BowEfficency = BowCalculator.Met_EfficensyOfBow(mainMaterial.Dencity, bow.Thickness, bow.BowWorkLenghtInches,Convert.ToDouble(numUDArrowWeight.Value), bow.CrossSection);
                bow.ArrowEnergy = BowCalculator.Met_ArrowEnergy(bow.BowEfficency, bow.StoredEnergy);
                bow.ArrowVelocity = BowCalculator.Met_ArrowVelocity(bow.ArrowEnergy,Convert.ToDouble(numUDArrowWeight.Value));
                bow.Damage = BowCalculator.Met_BowDamage(bow.ArrowEnergy, CBisCinematic.Checked);
                bow.Range = BowCalculator.Met_Range(bow.ArrowEnergy, Convert.ToDouble(numUDArrowWeight.Value));
                bow.Bulk = BowCalculator.Met_Bulk(bow.BowWorkLenghtInches, bow.BowUselessLenghtInches, 0);
                bow.Acc = BowCalculator.Met_Accuracy(bow.Bulk, bow.ArrowVelocity, 0);
                bow.RangeHalf = BowCalculator.Met_HalfRange(Convert.ToDouble(numUDArrowWeight.Value), 0.5);
                bow.Cost = bow.BowWeight * mainMaterial.BowCost * bow.Limbstuff.costMod;
                if(bow.RangeHalf >= bow.Range) { bow.RangeHalf = bow.Range; }
                OutputTextBox.Text = "Урон: " + bow.Damage.Text + " Дальность: " + bow.RangeHalf + "/" + bow.Range + " Громозкость: " + bow.Bulk + " Точность: " + bow.Acc + " Цена: " + bow.Cost + "$ Вес: " + bow.BowWeight + " lbs";
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)//hiding window when closing
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                e.Cancel= true;
            }
        }

        private void ComboxCrossection_SelectedIndexChanged(object sender, EventArgs e) //choosing limbs for bows
        {
            switch (ComboxCrossection.SelectedItem)
            {
                case "Прямые плечи":
                    bow.Limbstuff.potentialEnergyMod = 0.057;
                    bow.Limbstuff.costMod = 1;
                    bow.Limbstuff.breakingStrenghtDivider = 1;
                    break;
                case "Рекурсивные плечи":
                    bow.Limbstuff.potentialEnergyMod = 0.065;
                    bow.Limbstuff.costMod = 1.25;
                    bow.Limbstuff.breakingStrenghtDivider = 1.3;
                    break;
                case "Рефлекс плечи":
                    bow.Limbstuff.potentialEnergyMod = 0.073;
                    bow.Limbstuff.costMod = 1.5;
                    bow.Limbstuff.breakingStrenghtDivider = 1.6;
                    break;
                case "Композитные плечи":
                    bow.Limbstuff.potentialEnergyMod = 0.09;
                    bow.Limbstuff.costMod = 2;
                    bow.Limbstuff.breakingStrenghtDivider = 1;
                    break;
                case null:
                    ComboxCrossection.DroppedDown = true;
                    break;

            }
            numericUpDown2_ValueChanged(Go_Button, null);
        }

        private void numUDArrowWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CBArrowMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrowMaterial = Met_GetMaterialFromString(CBArrowMaterial.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrowTip = ArrowCalculator.Met_arrowTip_stringToData(CBArrowHeads.SelectedItem.ToString());
        }

        
    }
}
