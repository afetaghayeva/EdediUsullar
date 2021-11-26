using System;
using System.Data;
using System.Windows.Forms;

namespace EdediUsullar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.lblFinalResultFX.Text = this.lblFinalResultX.Text = "";
            var resultData = this.GetResultDataTable();
            this.dgwResult.DataSource = resultData;
        }
        private DataTable GetResultDataTable()
        {
            var result = GetEmptyDataTable();
            double a = Convert.ToDouble(this.txtA.Text);
            double b = Convert.ToDouble(this.txtB.Text);
            double fA = this.CalculateFunctionValue(a), fB = this.CalculateFunctionValue(b),
                fSecondDerivateA = this.CalclulateFunctionSecondDerivate(this.txtFunction.Text, a),
                fSecondDerivateB = this.CalclulateFunctionSecondDerivate(this.txtFunction.Text, b), ksi = 0, fKsi = 0;
            bool isAConstant = false;
            bool isBConstant = false;

            if ((fA < 0 && fSecondDerivateA < 0) || (fA > 0 && fSecondDerivateA > 0))
                isAConstant = true;
            else if ((fB < 0 && fSecondDerivateB < 0) || (fB > 0 && fSecondDerivateB > 0))
                isBConstant = true;
            for (int i = 0; i < Convert.ToInt32(this.txtIteration.Text); i++)
            {
                fA = this.CalculateFunctionValue(a);
                fB = this.CalculateFunctionValue(b);
                string interval = $"[{a};{b}]";
                string temp = String.Empty;
                var row = result.NewRow();
                row["№"] = i + 1;
                row["Baxdığımız aralıq"] = interval;
                if (isAConstant)
                {
                    ksi = b - ((fB) / (fB - fA)) * (b - a);
                    fKsi = this.CalculateFunctionValue(ksi);
                    if (fKsi == 0)
                    {
                        row["Əməliyyat"] = $"f({ksi})=0 olduğu üçün kök tapıldı";
                        result.Rows.Add(row);
                        this.lblFinalResultX.Text = "Son Nəticə - x=" + ksi;
                        this.lblFinalResultFX.Text = "Son Nəticə- f(x)=" + fKsi;
                        break;
                    }
                    else
                    {
                        if (i == Convert.ToInt32(this.txtIteration.Text) - 1)
                        {
                            this.lblFinalResultX.Text = "Son Nəticə - x=" + ksi;
                            this.lblFinalResultFX.Text = "Son Nəticə- f(x)=" + fKsi;
                            row["Əməliyyat"] = $"{i + 1} dəfə əməliyat təkrarlandı. Dövr bitdi";
                        }
                        else if (i == 0)
                            row["Əməliyyat"] = $"f({a})={fA} ilə f''({a})={fSecondDerivateA} işarələri üst-üstə düşdüyü üçün {a} tərpənməz qalırFun. Funksiyanın ikinci-tərtib törəməsi : {this.GetFunctionSecondDerivate(this.txtFunction.Text)}";
                        else
                            row["Əməliyyat"] = $"f({ksi})={fKsi} . Yeni aralığımız [{a};{ksi}]";
                    }
                    b = ksi;
                }
                else if (isBConstant)
                {
                    ksi = a - ((fA) / (fB - fA)) * (b - a);
                    fKsi = this.CalculateFunctionValue(ksi);
                    if (fKsi == 0)
                    {
                        row["Əməliyyat"] = $"f({ksi})=0 olduğu üçün kök tapıldı";
                        result.Rows.Add(row);
                        this.lblFinalResultX.Text = "Son Nəticə - x=" + ksi;
                        this.lblFinalResultFX.Text = "Son Nəticə- f(x)=" + fKsi;
                        break;
                    }
                    else
                    {
                        if (i == Convert.ToInt32(this.txtIteration.Text) - 1)
                        {
                            this.lblFinalResultX.Text = "Son Nəticə - x=" + ksi;
                            this.lblFinalResultFX.Text = "Son Nəticə- f(x)=" + fKsi;
                            row["Əməliyyat"] = $"{i+1} dəfə əməliyat təkrarlandı. Dövr bitdi";
                        }
                        else if (i == 0)
                            row["Əməliyyat"] = $"f({b})={fB} ilə f''({b})={fSecondDerivateB} işarələri üst-üstə düşdüyü üçün {b} tərpənməz qalır. Funksiyanın ikinci-tərtib törəməsi : {this.GetFunctionSecondDerivate(this.txtFunction.Text)}";
                        else
                            row["Əməliyyat"] = $"f({ksi})={fKsi} . Yeni aralığımız [{ksi};{b}]";
                    }
                    a = ksi;
                }
                else
                {
                    row["Əməliyyat"] = $"{a} və {b} uclarının heç biri tərpənməz olmadığı üçün həlli yoxdur";
                    result.Rows.Add(row);
                    break;
                }
                result.Rows.Add(row);
            }

            return result;
        }
        private static DataTable GetEmptyDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("№");
            dataTable.Columns.Add("Baxdığımız aralıq");
            dataTable.Columns.Add("Əməliyyat");
            return dataTable;
        }
        private double CalculateFunctionValue(double x, string function)
        {
            if (string.IsNullOrEmpty(function))
                function = this.txtFunction.Text;

            double result = 0, ratio = 1, power = 1;
            bool isFirstElementNegative = function.StartsWith("-");
            if (isFirstElementNegative)
                function = function[1..];
            //x^3-2x^2+3x-1
            var functionElements = function.Split('+', '-');
            for (int i = 0; i < functionElements.Length; i++)
            {
                if (functionElements[i].Contains("x"))
                {
                    ratio = 1;
                    power = 1;
                    if (functionElements[i].Contains("^"))
                        power = Convert.ToInt32(functionElements[i].Split('^')[1]);
                    if (!functionElements[i].StartsWith("x"))
                        ratio = Convert.ToDouble(functionElements[i].Split('x')[0]);
                    //
                    if (this.FindOperationOfElement(function, i) == "-" || (i == 0 && isFirstElementNegative))
                    {
                        if (power == 1)
                            result -= x * ratio;
                        else
                            result -= Math.Pow(x, power) * ratio;
                    }
                    else
                    {
                        if (power == 1)
                            result += x * ratio;
                        else
                            result += Math.Pow(x, power) * ratio;
                    }
                }
                else
                {
                    if (this.FindOperationOfElement(function,i)=="-")
                        result -= Convert.ToDouble(functionElements[i]);
                    else
                        result += Convert.ToDouble(functionElements[i]);
                }
            }
            return Math.Round(result, 8);
        }
        private double CalculateFunctionValue(double x)
        {
            return this.CalculateFunctionValue(x, "");
        }
        public string CalculateElementDerivate(string element)
        {
            if (!element.Contains('x'))
                return "0";
            double ratio = 1;
            int power = 1;
            if (!element.StartsWith('x'))
                ratio = Convert.ToDouble(element.Split('x')[0]);
            if (element.Contains('^'))
                power = Convert.ToInt32(element.Split('^')[1]);

            if (power == 1)
                return ratio.ToString();
            else if (power == 2)
                return (ratio * power).ToString() + "x";

            return (ratio * power).ToString() + "x^" + (power - 1).ToString();
        }
        public double CalclulateFunctionSecondDerivate(string function, double x)
        {
            var finalFunction = this.GetFunctionSecondDerivate(function);

            if (finalFunction == "0" ||String.IsNullOrEmpty(finalFunction))
                return 0;

            return this.CalculateFunctionValue(x, finalFunction);
        }

        public string GetFunctionSecondDerivate(string function)
        {
            bool isStartNegative = function.StartsWith('-');
            if (isStartNegative) function = function[1..];

            var elements = function.Split('-', '+');
            string finalFunction = "";

            if (isStartNegative)
                finalFunction = "-";

            for (int i = 0; i < elements.Length; i++)
            {
                string secondDerivate = this.CalculateElementDerivate(this.CalculateElementDerivate(elements[i]));
                if (secondDerivate == "0")
                    continue;
                if (i == 0)
                    finalFunction += secondDerivate;
                else
                {
                    if (this.FindOperationOfElement(function,i)=="-")
                        finalFunction += "-" + secondDerivate;
                    else
                        finalFunction += "+" + secondDerivate;
                }

            }
            if (finalFunction == "-" || String.IsNullOrEmpty(finalFunction))
                return "0";
            return finalFunction;
        }
        public string FindOperationOfElement(string function,int index)
        {
            int count = 0;
            for (int i = 0; i < function.Length; i++)
            {
                if (function[i] == '-')
                {
                    count++;
                    if (count == index)
                    {
                        return "-";
                    }
                }
                else if (function[i] == '+')
                {
                    count++;
                    if (count == index)
                    {
                        return "+";
                    }
                }

            }
            return "";
        }
    }
}
