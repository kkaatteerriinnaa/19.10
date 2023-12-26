using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
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

namespace _19._10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChangeLanguage.Click += ChangeLanguage_Click;
        }

        private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }
            UpdateUI();
        }

        private void UpdateUI()
        {
            Name.Text = Properties.Resources.Name;
            Surname.Text = Properties.Resources.Surname;
            Phone.Text = Properties.Resources.Phone;
            OK.Content = Properties.Resources.OK;
            Cancel.Content = Properties.Resources.Cancel;
            ChangeLanguage.Content = Properties.Resources.ChangeLanguage;
        }
    }
}