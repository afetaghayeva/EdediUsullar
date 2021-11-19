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
            double fA = 0, fB = 0;
            for (int i = 0; i < Convert.ToInt32(this.txtIteration.Text); i++)
            {
                fA = this.CalculateFunctionValue(a);
                fB= this.CalculateFunctionValue(b);
                string interval = $"[{a};{b}]";
                string temp = String.Empty;
                var row = result.NewRow();
                row["№"] = i + 1;
                row["Baxdığımız aralıq"]=interval;
                if (fA * fB > 0)
                {
                    row["Əməliyyat"] = $"f({a})={fA} ; f({b})={fB} ; f({a})*f({b})>0 olduğu üçün əməliyat sonlandı";
                    result.Rows.Add(row);
                    break;
                }
                double ksi = (a + b) / 2;
                double fKsi = this.CalculateFunctionValue(ksi);
                if (fKsi == 0)
                {
                    this.lblFinalResultX.Text = "Son Nəticə - x=" + ksi;
                    this.lblFinalResultFX.Text = "Son Nəticə- f(x)=" + fKsi;
                    row["Əməliyyat"] = $"f({a})={fA} ; f({b})={fB} ; f({ksi})=0 ; kök tapıldı";
                    result.Rows.Add(row);
                    break;
                }
                else if(i== Convert.ToInt32(this.txtIteration.Text) - 1)
                {
                    this.lblFinalResultX.Text = "Son Nəticə - x=" + ksi;
                    this.lblFinalResultFX.Text = "Son Nəticə- f(x)=" + fKsi;
                    row["Əməliyyat"] = $"f({a})={fA} ; f({b})={fB} ; f({ksi})={fKsi} ; Son iterasiya olduğu üçün əməliyat sonlandı";
                }
                else
                {
                    if (fA * fKsi < 0)
                    {
                        row["Əməliyyat"] = $"f({a})={fA} ; f({b})={fB} ; f({ksi})={fKsi} ; f({a})*f({ksi})<0 olduğu üçün [{a};{ksi}] aralığına baxırıq";
                        b = ksi;
                    }
                    else if (fB * fKsi < 0)
                    {
                        row["Əməliyyat"] = $"f({a})={fA} ; f({b})={fB} ; f({ksi})={fKsi} ; f({ksi})*f({b})<0 olduğu üçün [{ksi};{b}] aralığına baxırıq";
                        a = ksi;
                    }

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
        private double CalculateFunctionValue(double x)
        {
            var function = this.txtFunction.Text;
            double result=0,ratio=1,power = 1;
            int index = -1;
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
                    index = function.IndexOf(functionElements[i]);
                    if (function.Remove(index).EndsWith("-") || (i == 0 && isFirstElementNegative))
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
                    if (function.Replace(functionElements[i], "").EndsWith("-"))
                        result -= Convert.ToDouble(functionElements[i]);
                    else
                        result += Convert.ToDouble(functionElements[i]);
                }
            }
            return Math.Round(result,6);
        }
    }
}
