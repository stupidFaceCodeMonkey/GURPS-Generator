using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPS_GEN
{
    public class Bowstuff
    {
        /// <summary>
        /// Сила натяжения лука в фунтах. по умолчанию = 60
        /// </summary>
        public int DrawWeightLbs { get; set; } = 60;
        /// <summary>
        /// дальность на которую натягивается лук. по умолчанию 30 дюймов
        /// </summary>
        public int DrawLenghtInches { get; set; } = 30;
        /// <summary>
        /// Высота плечей лука без учета негнущейся части
        /// </summary>
        public int BowWorkLenghtInches { get; set; } = 60;
        public int BowUselessLenghtInches { get; set; } = 3;
        public double Thickness { get; set; } = 20;
        public double CrossSection { get; set; } = 0.5;
        public double Deflection { get; set; }
        public double DrawLenghtMax { get; set; }
        public double Theta { get; set; }
        public double BowWeight { get; set; }
        public double StoredEnergy { get; set; }
        public double BowEfficency { get; set; }
        public double ArrowEnergy { get; set; }
        public double ArrowVelocity { get; set; }
        public dice Damage { get; set; }
        public int Range { get; set; }
        public int RangeHalf { get; set; }
        public int Bulk { get; set; }
        public int Acc { get; set; }
        public double Cost { get; set; }
        public class CrossectionsNStuff
        {
            public double potentialEnergyMod { get; set; } = 1;
            public double costMod { get; set; } = 1;
            public double breakingStrenghtDivider { get; set; } = 1;

        }
        public CrossectionsNStuff Limbstuff = new CrossectionsNStuff();





    }
    public class Material
    {
        public string Name { get; set; }
        public double Dencity { get; set; }
        public double Breaking { get; set; }
        public double Elastic { get; set; }
        public double Buckling { get; set; }
        public double BowCost { get; set; }
        public double ArrowCost { get; set; }
    }
    public class Arrowstuff
    {
        public int lenght { get; set; } = 30;
        public double outerDiameter { get; set; } = 0.4d;
        public double innerDiameter { get; set; } = 0;
        public double weight { get; set; }
        public int bowDrawWeight { get; set; }
    }
    public static class BowCalculator
    {
        /// <summary>
        /// Расчитывает необходимую силу или базовый груз носителя лука с заданной силой натяжения
        /// </summary>
        /// 
        /// <param name="draw">Сила натяжения лука</param> 
        /// 
        /// <param name="St">True для обычной силы, False для базовой нагрузки</param> 
        /// 
        /// <returns></returns>
        public static int Met_DrawWeightToSt(int draw, bool St)
        {
            if(St == true)
            {
                int strenght = Convert.ToInt32(Math.Sqrt(draw * 2));
                return strenght;
            }
            else
            {
                int basicLift = Convert.ToInt32(Convert.ToDouble(draw) / 2.5);
                return basicLift;
            }            
        }

        public static int Met_DrawTime(int draw, int basicLift)
        {
            int DrawTime = 1;                   
            DrawTime = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(draw) / (2 * basicLift)));
            return DrawTime;            
        }
        public static int Met_MaxDraw(int basicLift, bool crossbow)
        {
            if (crossbow == true)
            { return basicLift * 8; }
            else
            {
                return Convert.ToInt32(basicLift * 2.5);
            }
        }

        public static Material Met_Composite(Material alpha, Material beta)
        {
            Material composite = alpha;
            composite.ArrowCost = (composite.ArrowCost + beta.ArrowCost) / 2;
            composite.BowCost = (composite.BowCost + beta.BowCost) / 2;
            composite.Buckling = (composite.Buckling + beta.Buckling) / 2;
            composite.Elastic = (composite.Elastic + beta.Elastic) / 2;
            composite.Breaking = (composite.Breaking + beta.Breaking) / 2;
            composite.Dencity = (composite.Dencity + beta.Dencity) / 2;
            return composite;
        }
        /// <summary>
        /// For a circular bow, k is exactly 64/π, or approximately 20; for a rectangular section, k = 12/n, where n is the width-tothickness ratio of the working limbs.F equals the draw weight, in pounds.L equals the total length of the working limbs, in inches.B equals the breaking strength of the working limbs, in lbs./in.2
        /// </summary>
        /// <param name="k"></param>
        /// <param name="F"></param>
        /// <param name="L"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static double Met_MinThicness(double k, double F, double L, double B)
        {
            double x = (k * F * L) / (8 * B);
            return Math.Sign(x) * Math.Pow(Math.Abs(x), 1 / 3.0);
        }
        public static double Met_Deflection(double k, double F, double L, double E, double t)
        {
            
            return (k * F * L * L * L) / (32 * E * t * t * t * t);
        }
        /// <summary>
        /// calculate maximum possible draw lenght for a bow
        /// </summary>
        /// <param name="p">number of string loops</param>
        /// <param name="R"></param>
        /// <param name="L"></param>
        /// <param name="Theta"></param>
        /// <param name="Deflection"></param>
        /// <returns></returns>
        public static double Met_MaxDrawLenght(double p, double R, double L, double Theta, double Deflection)
        {
            double S = p * (R + L) - (p - 1) * Math.Floor(R + Math.Floor(2 * L * Math.Sin(Theta / 2)) / Theta);//working string lenght
            Console.WriteLine(S);
            double stupidSS = (S * S / 4);
            Console.WriteLine(stupidSS);

            double stupidMath = Math.Floor(Math.Pow((R / 2) + ((L * Math.Sin(Theta / 2)) / Theta), 2));
            Console.WriteLine(stupidMath);
            double stepOne = stupidSS  - stupidMath;
            Console.WriteLine(stepOne);
            double stepTwo = Math.Sqrt(stepOne);
            Console.WriteLine(stepTwo);
            double DMax = Deflection + stepTwo ;
            Console.WriteLine(DMax);
            Console.Write("==========");
            return DMax;
        }
        public static double Met_ThetaCalculation(double Deflection, double Lenght)
        {
            double[] deflectionLenghtArray =
            {
                0.01,0.02,0.03,0.04,0.05,0.06,0.07,0.08,0.09,0.1,0.11,0.12,0.13,0.14,0.15,0.16,0.17,0.18,0.19,0.2,0.21,
                0.22,0.23,0.24,0.25,0.26,0.27,0.28,0.29,0.3,0.31,0.318
            };
            double[] thetaArray =
            {
                0.08,0.16,0.24,0.32,0.4,0.48,0.56,0.64,0.72,0.81,0.89,0.97,1.06,1.15,1.24,1.33,1.42,1.5,1.6,1.7,1.8,
                1.9,2,2.1,2.22,2.33,2.45,2.58,2.71,2.85,2.99,3.14
            };
            int loop = 0;
            while(loop< deflectionLenghtArray.Length)
            {
                if (loop > 0)
                {
                    if (deflectionLenghtArray[loop] > (Deflection / Lenght))
                    {
                        return thetaArray[loop - 1];

                    }
                }
                else if(deflectionLenghtArray[loop] > (Deflection / Lenght))
                {
                    return 8 * (Deflection / Lenght);
                }
                
                loop++;
            }
            return 3.14;
        }
        public static double Met_BowWeight(double density, double L, double t, double c, double riserWeight, double stockWeight)
        {
            return (density * L * t * t * c) + riserWeight + stockWeight;
        }
        public static double Met_RiserStockWeight(double F, double R, double E, double w, double deflection, double density)
        {
            double thiccnes = Math.Floor((Math.Floor(F * R * R)) / (Math.Floor(4 * E * w * (deflection / R))));
            return (density * w * thiccnes * R);
        }
        public static double Met_StoredEnergy(double drawForce, double drawLenght, double ZCrossectionMod) { return (drawForce * drawLenght * ZCrossectionMod); }//ZCrossectionMod для ; Z = 0.057 for a straight bow; 0.065 for a recurve bow; 0.073 for a reflex bow, and 0.090 for a compound bow.
        public static double Met_EfficensyOfBow(double dencity, double thiccness,double L, double arrowMass, double widhToThicnessRatio)
        {
            double effectiveMass = 37 * dencity * thiccness * thiccness * Math.Sqrt(widhToThicnessRatio / L);
            double efficency = 1 / (1 + effectiveMass / arrowMass);
            return efficency;
        }
        public static double Met_ArrowEnergy(double bowEfficency, double storedEnergy) { return bowEfficency * storedEnergy; }
        public static double Met_ArrowVelocity(double arrowEnergy, double arrowMass)
        {
            return Math.Sqrt(5.28 * (arrowEnergy / arrowMass));
        }

        public static dice Met_BowDamage(double arrowEnergy, bool isCinimatic)
        {
            dice ret = new dice();
            if (isCinimatic == true)
            {                
                ret.rawNumbers = Convert.ToInt32( Math.Sqrt(arrowEnergy / 1.5));
                return ret;
            }
            else
            {
                ret.rawNumbers = Convert.ToInt32(Math.Sqrt(arrowEnergy / 2.5));
                return ret;
            }
        }
        public static int Met_Range(double arrowEnergy, double arrowMass)
        {
            return Convert.ToInt32( 0.34 * arrowEnergy / arrowMass);
        }
        public static int Met_Bulk(double L, double R, double stockLenght)
        {
            return Convert.ToInt32(9 - 9 * Math.Log10(L + R + stockLenght));
        }
        /// <summary>
        /// Вычисляет точность лука
        /// </summary>
        /// <param name="bulk"></param>
        /// <param name="V"></param>
        /// <param name="C">r. C is -1 for a foot bow, 0 for hand bows and pistol crossbows, and 1 for a two-handed crossbow</param>
        /// <returns></returns>
        public static int Met_Accuracy(int bulk, double V, double C)
        {
            return Convert.ToInt32((3 * Math.Log10(V)) - (bulk / 2) - 7.5 + C);
        }
        public static int Met_HalfRange(double arrowMass, double arrowDiameter)
        {
            return Convert.ToInt32(750 * arrowMass / (arrowDiameter * arrowDiameter));
        }
        //public static double Met_CostBow()
        

    }
    public static class ArrowCalculator
    {
        public static double Met_DiameterNMass(int DrawForce, int ShaftLenght, double Elastic, double Dencity, bool IsHollow, double Dinner)//будет много багов с матаном
        {
            double A = 1.25 * Math.Exp(-5.4 * (Elastic / Dencity) * Math.Pow(10, -9));
            Console.WriteLine(A);
            double firstStep = (DrawForce * ShaftLenght * ShaftLenght) / (A * Elastic);
            double Dzero = Math.Pow(Math.Abs(firstStep), 1.0 / 4.0);
            double mass = 3.14/4 * Dencity * ShaftLenght * Dzero*Dzero;
            Console.WriteLine(mass);
            if(IsHollow == true)
            {                
                double Douter =Math.Pow(Math.Abs(Math.Pow(Dzero,4) + Math.Pow(Dinner, 4)), 1.0/4.0);
                double hollowMass = 3.14 / 4 * Dencity * ShaftLenght * (Douter*Douter - Dinner*Dinner);
                //"d1^4-d2^4=(DrawForce * ShaftLenght * ShaftLenght) / (A * Elastic)"
                return hollowMass;
            }
            else
            {
                return mass;
            }            
        }
        public static ArrowHead Met_arrowTip_stringToData(string ArrowTipData)
        {
            ArrowHead arrowHead = new ArrowHead();
            arrowHead.TL =Convert.ToInt32(ArrowTipData.Substring(ArrowTipData.IndexOf("TL:") + 3, ArrowTipData.IndexOf('|', ArrowTipData.IndexOf("TL:")) - 3));
            arrowHead.Name =(ArrowTipData.Substring(ArrowTipData.IndexOf("Name:") + 5, ArrowTipData.IndexOf('|', ArrowTipData.IndexOf("Name:")) - ArrowTipData.IndexOf("Name:")- 5));
            arrowHead.damageType =ArrowTipData.Substring(ArrowTipData.IndexOf("Damage Type:") + 12, ArrowTipData.IndexOf('(', ArrowTipData.IndexOf("Damage Type:"))- ArrowTipData.IndexOf("Damage Type:") - 12);
            arrowHead.armorDevisor =Convert.ToDouble(ArrowTipData.Substring(ArrowTipData.IndexOf('(') + 1, ArrowTipData.IndexOf(')', ArrowTipData.IndexOf('(')) - ArrowTipData.IndexOf(')') +1 ));
            arrowHead.arrowHeadWeight =Convert.ToDouble(ArrowTipData.Substring(ArrowTipData.IndexOf("Weight:") + 7, ArrowTipData.IndexOf('|', ArrowTipData.IndexOf("Weight:")) - ArrowTipData.IndexOf("Weight:") - 7));
            arrowHead.arrowHeadCost = Convert.ToDouble(ArrowTipData.Substring(ArrowTipData.IndexOf("Cost:$") + 6, ArrowTipData.IndexOf('|', ArrowTipData.IndexOf("Cost:$")) - ArrowTipData.IndexOf("Cost:$") - 6));
            arrowHead.notes =ArrowTipData.Substring(ArrowTipData.IndexOf("Notes:") + 6, ArrowTipData.IndexOf('|', ArrowTipData.IndexOf("Notes:")) - ArrowTipData.IndexOf("Notes:") - 6);

            //ааааблять
            //оно
            //находит индекс нужных символов
            //добавляет число дабы избавится от переда
            //теперь у нас строчка без переда
            //находит индекс в полной строчке индекс символа начиная с индекса переда
            //вычитает из него число переда и индекс переда, находя таким образом длинну нужной подстроки
            //вычленяет подстроку


            return arrowHead;
        }
    }

    public class dice
    {
        public int rawNumbers { get; set; }
        public int dices { get { return Convert.ToInt32(Math.Floor(rawNumbers / 3.5)); } }
        public int addToDices { get { return Convert.ToInt32(rawNumbers-(dices*3.5)); } }
        public string Text
        {
            get
            { return dices + "d6+" + addToDices; }
        }

    }
    public class ArrowHead
    {
        public int TL { get; set; } = 0;
        public string Name { get; set; } = "arrowhead Name";
        public string damageType{ get; set; } = "imp" ;
        public double armorDevisor { get; set; } = 1;
        public double arrowHeadWeight { get; set; } = 0.015;
        public double arrowHeadCost { get; set; } = 0.5;
        public string notes { get; set; } = "";


    }
    
        
}
