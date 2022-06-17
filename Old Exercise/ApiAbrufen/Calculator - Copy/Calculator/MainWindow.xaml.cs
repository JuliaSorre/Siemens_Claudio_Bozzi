using System;
using System.Windows;
using System.Windows.Controls;




namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        //variables
        double num1;
        double num2;
        double result;
        string clipresult;

        //Class for the Clipboard

        //public static void SetText(String textData);

        public MainWindow()
        {
            InitializeComponent();
        }

        //Converts the strings to double variables and summs them
        public void Button_Click(object sender, RoutedEventArgs e)
        {
         
            num1 = Convert.ToDouble(numerA.Text);
            num2 = Convert.ToDouble(numerB.Text);
            result = num1 + num2;
            resultat.Content = result.ToString();
            clipresult = result.ToString();
            Clipboard.SetText(clipresult);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
