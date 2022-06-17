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
        public Uri Source { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Web1.Navigate("https://www.wtv676.siemens-info.com/ev00000003/login.php");
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Web2.Navigate("https://www.wtv676.siemens-info.com/ev16444187/login.php");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Web3.Navigate("https://www.wtv676.siemens-info.com/ev16444144/login.php");
     
        }

        /*object var1 = GetValue("https://www.wtv676.siemens-info.com/ev16444144/api/.well-known/knx/");

        object var2 = var1;*/

   
    }
}
