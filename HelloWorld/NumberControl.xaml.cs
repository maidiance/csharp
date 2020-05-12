using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for NumberControl.xaml
    /// </summary>
    
    public partial class NumberControl : UserControl
    {
        public NumberControl()
        {
            InitializeComponent();
        }

        public int Value
        {
            get;
            private set;
        }

        private void xNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsValidNumber(e.Text);
        }

        private bool IsValidNumber(string text)
        {
            Regex numerics = new Regex("[^0-9.-]+");
            Boolean isAllowed = numerics.IsMatch(text);
            return isAllowed;
        }
    }
}
