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
using System.Text.RegularExpressions;

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
            tbDisplayArea.Text = ("Results");
            tbNumDays.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, Foo));
        }

        private void Foo(object sender, ExecutedRoutedEventArgs e)
        {
            e.Handled = true;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void BtnCalculateOnclick(object sender, EventArgs e)
        {
            ResetClassFields();
            int temp = int.Parse(tbNumDays.Text);
            calculate.SetNumDays(temp);
            calculate.DoublePenny();
            tbNumDays.Text = String.Empty;
            PrintData();
        }

        public void PrintData()
        {
            tbDisplayArea.AppendText(calculate.GetNumDays() + " Days");
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText(calculate.GetPennyTotal() + " Cents/Pennys");
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText("$" + calculate.GetDollarValue());
            tbDisplayArea.AppendText(Environment.NewLine);
            tbDisplayArea.AppendText(Environment.NewLine);
        }

        public void ResetClassFields()
        {
            calculate.SetNumDays(0);
            calculate.SetPennyTotal(1);
        }
    }
}