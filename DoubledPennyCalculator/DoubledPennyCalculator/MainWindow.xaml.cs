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
        private List<Calculate> CalculateList;
        public MainWindow()
        {
            InitializeComponent();
            CalculateList = new List<Calculate>();
        }

        public void BtnCalculateOnclick(object sender, EventArgs e)
        {
            CalculateList.Add(new Calculate(Convert.ToInt64(tbNumDays.Text)));
            CalculateList[0].DoublePenny(CalculateList[0].GetNumDays());
            CalculateList[0].FormeatDollar();
            tbDisplayArea.Text = CalculateList[0].GetNumDays().ToString() + " Days";
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText(CalculateList[0].GetPennyTotal().ToString() + " Cents/Pennys");
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText("$" + CalculateList[0].GetDollarValue().ToString());

            tbNumDays.Text = String.Empty;
        }
    }
}
