using System;
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
using System.Collections;

namespace DoubledPennyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculate calculate;

        public MainWindow()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        public void BtnCalculateOnclick(object sender, EventArgs e)
        {
            ClearClassFields();
            calculate.SetNumDays(Convert.ToInt64(tbNumDays.Text));
            calculate.DoublePenny();
            tbNumDays.Text = String.Empty;
            PrintData();
        }

        public void PrintData()
        {
            tbDisplayArea.Text= (calculate.GetNumDays() + " Days");
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText(calculate.GetPennyTotal() + " Cents/Pennys");
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText("$" + calculate.GetDollarValue());
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText(Environment.NewLine);
        }

        public void ClearClassFields()
        {
            calculate.SetNumDays(0);
            calculate.SetPennyTotal(0);
        }
    }
 /*
 * get numDays
 */
}