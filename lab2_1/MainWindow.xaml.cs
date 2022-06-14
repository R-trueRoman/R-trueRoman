using System;
using System.Windows;
using System.Windows.Controls;


namespace lab2_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double numberDouble;
            if (!double.TryParse(inputTextBox.Text, out numberDouble))
            {
                MessageBox.Show("Please enter a double");
                return;
            }

            if (numberDouble <= 0)
            {
                MessageBox.Show("Please enter a positive number");
                return;
            }

            double squareRoot = Math.Sqrt(numberDouble);

            frameworkLabel.Content = string.Format("{0} (Using .NET Framework)", squareRoot);


            decimal numberDecimal;
            if (!decimal.TryParse(inputTextBox.Text, out numberDecimal))
            {
                MessageBox.Show("Please enter a decimal");
                return;
            }


            decimal delta = Convert.ToDecimal(Math.Pow(10, -28));

            decimal guess = numberDecimal / 2;

            decimal result = ((numberDecimal / guess) + guess) / 2;

            while (Math.Abs(result - guess) > delta)
            {
                guess = result;
                result = ((numberDecimal / guess) + guess) / 2;
            }

            newtonLabel.Content = string.Format("{0} (Using Newton)", result);
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
