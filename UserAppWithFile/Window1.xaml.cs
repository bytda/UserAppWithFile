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
using System.Windows.Shapes;
using System.IO;

namespace UserAppWithFile
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        
        public Window1()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\forda\source\repos\UserAppWithFile\UserAppWithFile\data.txt";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            string loginAth = login.Text.ToLower();
            string passAth = pass.Text.ToLower();
            string dataAth = loginAth + "|" + passAth;

            using (StreamReader read = new StreamReader(path))
            {   //string dataFile = read.ReadToEnd();
                //if (dataFile.Contains(dataAth)) MessageBox.Show("Авторизованы");
                //else MessageBox.Show("Неверно");
                int i = 0;
                string[] dataFile = new string[33];
                
                int match = 0;
                while (!read.EndOfStream)
                {
                    dataFile[i] = read.ReadLine();

                    if (dataFile[i] == dataAth) match++;
                    
                    
                    i++;
                    
                }

                if (match != 0) MessageBox.Show("Авторизованы");
                else MessageBox.Show("Пользователь не найден");


            }
            
            

              
        }
    }
}
