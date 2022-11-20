using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Prakt11
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

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Борькин Иван ИСП-31 \nДана строка 'ab abab abab abababab abea'. Напишите регулярное выражение, которое найдет строки 'ab' повторяется 1 или более раз. Дана строка 'a.a aba aea'.Напишите регулярное выражение, которое найдет строку a.a, не захватив остальные.");
        }

        private void FindFirst(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"\w*(ab+)\w*");
            string textcontent = TextContent1.Text;
            MatchCollection matches = regex.Matches(textcontent);
            object[] mas = new object[matches.Count];
            matches.CopyTo(mas, 0);
            FindRes.ItemsSource = mas;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            TextContent1.Clear();
            TextContent2.Clear();
            FindRes.ItemsSource = null;
        }

        private void FindSecond(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"\w*a[.]a\w*");
            string textcontent = TextContent2.Text;
            MatchCollection matches = regex.Matches(textcontent);
            object[] mas = new object[matches.Count];
            matches.CopyTo(mas, 0);
            FindRes.ItemsSource = mas;
        }
    }
}
