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
using System.IO;


namespace UserAppWithFile
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\forda\source\repos\UserAppWithFile\UserAppWithFile\data.txt";


            //File.Create(path).Close();
            //File.WriteAllText(path, "Calam");
            //using (FileStream file = new FileStream(path, FileMode.Append))
            using (StreamWriter stream = new StreamWriter(path, true)) {
                if (login.Text != "" && pass.Text != "")
                {
                    stream.WriteLine(login.Text.ToLower() + "|" + pass.Text.ToLower());
                    Window1 window1 = new Window1();
                    window1.Show();
                    Close();
                }
                else MessageBox.Show("Заполните поля");
            }
            



        }
        
        
    }
}
