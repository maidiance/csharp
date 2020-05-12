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

namespace ZipCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxZipcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isValidZipcode(uxZipcode.Text))
                uxSubmit.IsEnabled = true;
            else
                uxSubmit.IsEnabled = false;
        }

        private Boolean isValidZipcode(string zipcode)
        {
            int result;
            // Check US Zipcode format #####
            if (zipcode.Length == 5)
            {
                if (int.TryParse(zipcode, out result))
                    return true;
                else
                    return false;
            }
            // Check US Zipcode format #####-####
            if (zipcode.Length == 10)
            {
                string[] zipcode_split = zipcode.Split("-");
                if (zipcode_split.Length != 2)
                    return false;
                if (int.TryParse(zipcode_split[0], out result) && int.TryParse(zipcode_split[1], out result))
                    return true;
                else
                    return false;
            }
            // Check Candian Postal Code format A#B#C#
            if (zipcode.Length == 6)
            {
                if (Char.IsLetter(zipcode[0]) && Char.IsDigit(zipcode[1]) && Char.IsLetter(zipcode[2]) &&
                    Char.IsDigit(zipcode[3]) && Char.IsLetter(zipcode[4]) && Char.IsDigit(zipcode[5]))
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
