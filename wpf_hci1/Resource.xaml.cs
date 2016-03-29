using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;
using System.ComponentModel;

namespace wpf_hci1
{
    /// <summary>
    /// Interaction logic for Resourse.xaml
    /// </summary>
    public partial class Resource : Window, INotifyPropertyChanged
    {
        public Resource()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void WhenChanging() {
                
        }

    }

    public class Validation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                double d;
                if(double.TryParse(s,out d))
                {
                    return new ValidationResult(true,null);
                }
                else
                {
                    return new ValidationResult(false, "Incorrect value!");
                }
            }
            catch
            {
                return new ValidationResult(false,"Unknown exception.");
            }
        }
    }

}
