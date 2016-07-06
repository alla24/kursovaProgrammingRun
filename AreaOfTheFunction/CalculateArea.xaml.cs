using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;

namespace AreaOfTheFunction
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
   public partial class CalculateArea : Window
    {
        public CalculateArea()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String funct = funcBox.Text;
                double left = double.Parse(leftBox.Text, CultureInfo.InvariantCulture);//get value from the textbox, type conversion, empty fields are not excepted
                double right = double.Parse(rightBox.Text, CultureInfo.InvariantCulture);//Global standards, both , and . decimal separators are excepted
                double eps = double.Parse(epsBox.Text, CultureInfo.InvariantCulture);
                Calc newCalc = new Calc();
                double result = newCalc.calc(funct, left, right, eps);//calculate the area
                if ((Double.IsNaN(result)) || Double.IsInfinity(result))
                {
                    output.Text = "Iнтервал включає точки розриву чи безкінечності для функції. Змініть інтервал!";
                    myGraph.DataContext = "";
                }
                else
                {
                    output.Text = result.ToString(); //for debugging +" " + string.Join(", ", newCalc.getCoordinates().ToArray());//output the result
                    myGraph.DataContext = newCalc.getCoordinates();
                }
            }
            catch (Exception exc) {
                output.Text = "Неправильні дані!";
            }

        }

    }
}
