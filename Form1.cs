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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
       
        public Form1()
        {
            InitializeComponent();
            
            ComboBoxMaterial.Items.AddRange(File.ReadAllLines(@"Resources\Armor table.txt"));
            
        }

       /* private Double[] methodOfCalculatingBaseArmorStats(int armorDR, Double materialWeightMultiplier, Double materialCostMultiplier)
        {
            Double[] calculationResult = new Double[2];
            calculationResult[0] = armorDR * materialWeightMultiplier;
            calculationResult[1] = calculationResult[0] * materialCostMultiplier;
            return calculationResult;
        }
        // метод подсчитывает базовый вес[0] и цену[1] из заданных параметров*/

        private Double[] methodCompleArmorCalculation(int armorDR, Double materialWeightMultiplier, Double materialCostMultiplier, Double armorTypeWeightMultiplier, Double armorTypeCostMultiplier, Double qualityWeightMultiplier, Double qualityCostFactor, Double coverageFactor)
        {
            Double basicArmorWeight = armorDR * materialWeightMultiplier * armorTypeWeightMultiplier * coverageFactor;
            Double basicArmorCost = basicArmorWeight * materialCostMultiplier * armorTypeCostMultiplier;
            Double advancedArmorWeight = basicArmorWeight * qualityWeightMultiplier;
            Double advancedArmorCost = basicArmorCost * (1 + qualityCostFactor);
            Double[] ret = new Double[2] { advancedArmorWeight, advancedArmorCost };
            return ret;
            //метод для расчета финальной цены и стоимости за 1 квадратный фут покрытия
        }

        private int methodDRAdded(string lineOfMaterial)
        {
            int ret=0;
            if (lineOfMaterial.Contains('&'))
            {
                ret = Convert.ToInt16(lineOfMaterial.Substring(lineOfMaterial.IndexOf('&') + 1, lineOfMaterial.IndexOf(' ', lineOfMaterial.IndexOf('&')) - lineOfMaterial.IndexOf('&') - 1));

            }
            
            
            return ret;
        }

        private string[] methodMaterialLinesToData(string lineOfMaterial)
        {
            lineOfMaterial.Trim();

            string[] ret = new string[5] { "[]", "$", "Name", ""/*++Доп цена*/, ""/*Игровой текст*/ };

            if (lineOfMaterial.Contains('[') && lineOfMaterial.Contains(']') && lineOfMaterial.Contains('$')) //дописать условия в подобном ключе для всех остальных параметров
            {
                ret[0] = lineOfMaterial.Substring(lineOfMaterial.IndexOf('[') + 1, lineOfMaterial.IndexOf(']', lineOfMaterial.IndexOf('[') ) - lineOfMaterial.IndexOf('[') -1);
                ret[1] = lineOfMaterial.Substring(lineOfMaterial.IndexOf('$') + 1, lineOfMaterial.IndexOf(' ', lineOfMaterial.IndexOf('$') ) - lineOfMaterial.IndexOf('$') -1);
                ret[2] = lineOfMaterial.Substring(0, lineOfMaterial.IndexOf('['));
                if (lineOfMaterial.Contains("++"))
                {
                    ret[3] = lineOfMaterial.Substring(lineOfMaterial.IndexOf("++")+2, lineOfMaterial.IndexOf(' ', lineOfMaterial.IndexOf("++")) - lineOfMaterial.IndexOf("++") - 2 );
                }
                if (lineOfMaterial.Contains('<'))
                {
                    ret[4] = lineOfMaterial.Substring(lineOfMaterial.IndexOf("<") + 1, lineOfMaterial.IndexOf('>', lineOfMaterial.IndexOf("<")) - lineOfMaterial.IndexOf("<") - 1);

                }
            }
            else
            {
                ret[0] = "Wrong line";
            }
            
            return ret ; //тут я пытаюсь научить прогу делать из строки с параметрами съедобные для проги цифери. В целом матан.
        }
       
        private string[] methodQuality(string qualityIndex)
        {
            string[] ret = { "1", "0" };
            if (qualityIndex == "")
            {
                comboBox1.Text = "Обычный";
                return ret ;
            }
            else
            {
                if(qualityIndex == "Дешевый")
                {
                    ret = new string[] {"1,3", "-0,4"};
                    return ret;
                }
                if (qualityIndex == "Обычный")
                {
                    return ret;
                }
                if (qualityIndex == "Отличный")
                {
                    ret = new string[] { "0,8", "3" };

                    return ret;
                }
                if (qualityIndex == "Превосходный")
                {
                    ret = new string[] { "0,7", "19" };

                    return ret;
                }
                return ret;
            }
        }// хрень для указания качества. 
        public void GoButtonName_Click(object sender, EventArgs e)
        {

            textBoxOutput.Text = methodFinal()[0];




        }//финальная фигня с заделом под всякие штуки. подсчет говна и прочее. так же выводит зонып попаданий если они не выбраны (по идее)

        private string[] methodFinal()
        {
            if (form2.Get_Coverage_Info(null, null) == 0)
            {
                form2.Show();
            }
            else
            {
                if(ComboBoxMaterial.Text == "")
                {
                    ComboBoxMaterial.DroppedDown=true;
                }
                else if(cb_ArmorType.Text == "")
                {
                    cb_ArmorType.DroppedDown = true;
                }
                Double coverage = form2.Get_Coverage_Info(null, null);
                int dr = ((int)numericUpDownDR.Value);
                if ((methodMaterialLinesToData(ComboBoxMaterial.Text)[0] == "Wrong line") || (methodMaterialLinesToData(cb_ArmorType.Text)[0] == "Wrong line"))
                {

                }
                else
                {
                    Double[] finalOtherStuff = { 1, 0, 0, 0 };
                    ComboBox[] otherStuff = { comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10, comboBox11, comboBox12 };
                    string finalStringStuff = "";
                    int loop = 0;
                    while (loop < 11)
                    {
                        if (otherStuff[loop].Text == "")
                        {

                        }
                        else
                        {
                            finalOtherStuff[0] *= Convert.ToDouble(methodMaterialLinesToData(otherStuff[loop].Text)[0]);
                            finalOtherStuff[1] += Convert.ToDouble(methodMaterialLinesToData(otherStuff[loop].Text)[1]);
                            finalOtherStuff[2] += Convert.ToDouble(methodMaterialLinesToData(otherStuff[loop].Text)[3]);
                            finalOtherStuff[3] += methodDRAdded(otherStuff[loop].Text);
                            if (methodMaterialLinesToData(otherStuff[loop].Text)[4] != "")
                            {
                                finalStringStuff += " " + methodMaterialLinesToData(otherStuff[loop].Text)[4] + ",";

                            }

                        }
                        loop++;
                    }
                    if (finalStringStuff != "")
                    {
                        finalStringStuff = ". Броня имеет следующие свойства: " + finalStringStuff;
                    }
                    Double weightNumber = Convert.ToDouble(methodMaterialLinesToData(ComboBoxMaterial.Text)[0]);
                    Double costPerWeight = Convert.ToDouble(methodMaterialLinesToData(ComboBoxMaterial.Text)[1]);
                    Double weightTypeNumber = Convert.ToDouble(methodMaterialLinesToData(cb_ArmorType.Text)[0]); //множитель веса от типа брони (латы, чешуя итп)
                    Double costTypeNumber = Convert.ToDouble(methodMaterialLinesToData(cb_ArmorType.Text)[1]); //множитель цены от типа брони
                    Double weightQualityNumber = Convert.ToDouble(methodQuality(comboBox1.Text)[0]) * finalOtherStuff[0]; //множитель веса от качества брони
                    Double costQualityFactor = Convert.ToDouble(methodQuality(comboBox1.Text)[1]) + finalOtherStuff[1]; // дополнительная цена от качества брони
                    Double[] outputText = methodCompleArmorCalculation(dr, weightNumber, costPerWeight, weightTypeNumber, costTypeNumber, weightQualityNumber, costQualityFactor, coverage);
                    string[] text = { "", ""}; 

                    text [0] =  comboBox1.Text.Replace("ое", "ая") + " броня из " + methodMaterialLinesToData(ComboBoxMaterial.Text)[2] + " "+ methodMaterialLinesToData(cb_ArmorType.Text)[2] + " с ДР " + Convert.ToString(dr + finalOtherStuff[3]) + " весит " + Convert.ToString(outputText[0]) + " фунтов и стоит " + Convert.ToString(outputText[1] + finalOtherStuff[2] + "$") + finalStringStuff.TrimEnd(',') + ".";
                    string[] loopingHitZones = form2.methodWhatHitZoneChecked();
                    loop = 0;
                    string processedText = "";
                    while (loop < loopingHitZones.Length)
                    {
                        processedText += "<dr_bonus>\r\n" + "<location>" + loopingHitZones[loop] + "</location>\r\n" + "<amount>" + Convert.ToString(dr + finalOtherStuff[3]) + "</amount>\r\n" + "</dr_bonus>\r\n";
                        loop++;
                    }
                    text[1] = "<equipment version=\"3\">\r\n" +
                                "<description>" + comboBox1.Text.Replace("ое", "ая") + " броня из " + methodMaterialLinesToData(ComboBoxMaterial.Text)[2] + " " + methodMaterialLinesToData(cb_ArmorType.Text)[2] + "</description>\r\n" +
                                "<value>" + Convert.ToString(outputText[1] + finalOtherStuff[2]) + "</value>\r\n" +
                                "<weight>" + Convert.ToString(outputText[0]) + "</weight>\r\n" +
                                "<quantity>1</quantity>\r\n" + processedText + "<description-loc>\r\n" + text[0]+ "\r\n</description-loc>";
                    
                    return text;
                }
                
            }
            string[] lol = { null, null };//хрень чтоб компилятор не ругался
            return lol;
            
            
        }
        private void button_ToMentor_Click(object sender, EventArgs e)
        {


            
           
            

            textBoxOutput.Text = methodFinal()[1];
            
        }
        private void ComboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] infoShowing = methodMaterialLinesToData(ComboBoxMaterial.Text);
            if (infoShowing[0] == "Wrong line")
            { }
            else
            {
                textBox1.Text = infoShowing[0];
                textBox2.Text = infoShowing[1];
                textBox3.Text = infoShowing[2];
            }
        }
        //Выводит статки материала для более удобного чтения

        private void ButtonHitZone_Click(object sender, EventArgs e)
        {
            
            form2.Show();// показывает окно с зонами попадания
        }

       

        private string RigidOrFlexible(string inputString)
        {
            
            if (inputString.Contains("F/O"))
            {
                return ("Flexible");
            }
            else if (inputString.Contains("Solid"))
            {
                return ("Solid");
            }
            else if (inputString.Contains("R/S"))
            {
                return ("Rigid");
            }
            else
            {
                return ("Wrong line");
            }
            
        } // определяет есть ли в строке указатели гибкости материала и выводит их
        private void comboBox2_Click(object sender, EventArgs e)
        {
            cb_ArmorType.Items.Clear();
            if (RigidOrFlexible(ComboBoxMaterial.Text) == "Wrong line")
            {
                cb_ArmorType.Text = "Укажите материал"; // тут все просто. просто проверяет выбран ли материал

            }
            else
            {
                cb_ArmorType.Items.AddRange(File.ReadAllLines(@"Resources\Armor type.txt"));
                int ind = 0;
                //185-233 делает строки не соответствующие выборке пустыми
                if (RigidOrFlexible(ComboBoxMaterial.Text) == "Flexible")//удаляет все строки которые не флексибл. внизу её клоны на другие типы
                {
                    while (ind < cb_ArmorType.Items.Count)
                    {
                        if (RigidOrFlexible(Convert.ToString( cb_ArmorType.Items[ind] )) == "Flexible")
                        {

                        }
                        else
                        {
                            cb_ArmorType.Items[ind] = "";
                        }
                        ind++;
                    }
                    
                }
                else if (RigidOrFlexible(ComboBoxMaterial.Text) == "Solid")
                {
                    while (ind < cb_ArmorType.Items.Count)
                    {
                        if (RigidOrFlexible(Convert.ToString(cb_ArmorType.Items[ind])) == "Solid")
                        {

                        }
                        else
                        {
                            cb_ArmorType.Items[ind] = "";
                        }
                        ind++;
                    }

                }
                if (RigidOrFlexible(ComboBoxMaterial.Text) == "Rigid")
                {
                    while (ind < cb_ArmorType.Items.Count)
                    {
                        if (RigidOrFlexible(Convert.ToString(cb_ArmorType.Items[ind])) == "Rigid")
                        {

                        }
                        else
                        {
                            cb_ArmorType.Items[ind] = "";
                        }
                        ind++;
                    }

                }
                int i = 0;
                while (i < cb_ArmorType.Items.Count)
                {
                    if (Convert.ToString(cb_ArmorType.Items[i]) == "")
                    {
                        cb_ArmorType.Items.RemoveAt(i);
                        i--;// уничтожает пустые строки для более удобного и компактного просмотра вариантов
                    }
                    i++;
                }
            }
            
            //надо как-то убирать не подходящие для материала варианты из загруженных
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();
            comboBox10.Items.Clear();
            comboBox11.Items.Clear();
            comboBox12.Items.Clear();
            
            if (RigidOrFlexible(cb_ArmorType.Text) == "Wrong line")
            {
                
            }
            else
            {
                bool rigFlexTrueFalse;
                if (RigidOrFlexible(cb_ArmorType.Text) == "Flexible")
                {
                    rigFlexTrueFalse = false;
                }
                else { rigFlexTrueFalse = true; }
                comboBox2.Items.AddRange(File.ReadAllLines(@"Resources\Other stuff.txt"));
                int loop = 0;
                while(loop < comboBox2.Items.Count)
                {
                    if (Convert.ToString(comboBox2.Items[loop]) == "")
                    {
                        comboBox2.Items.RemoveAt(loop);
                        loop--;
                    }
                    else if ((rigFlexTrueFalse == false) && ((Convert.ToString(comboBox2.Items[loop]).Contains("!Rigid!") == true) ))
                    {
                        comboBox2.Items.RemoveAt(loop);
                        loop--;
                    }
                    else if ((rigFlexTrueFalse == true) && ((Convert.ToString(comboBox2.Items[loop]).Contains("!Flexible!") == true)))
                    {
                        comboBox2.Items.RemoveAt(loop);
                        loop--;
                    }
                    loop++;
                }
                comboBox3.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox4.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox5.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox6.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox7.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox8.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox9.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox10.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox11.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
                comboBox12.Items.AddRange(comboBox2.Items.Cast<object>().ToArray());
            }

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3.Show();
        }
    }
}
