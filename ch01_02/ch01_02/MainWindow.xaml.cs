using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ch01_02
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Cust c1;
        public MainWindow()
        {
            InitializeComponent();

            c1 = GetData();
            viewData(c1);

            c1.PropertyChanged += C1_PropertyChanged;

        }

        private void C1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Debug.WriteLine("38: " + e.PropertyName);

            switch(e.PropertyName)
            {
                case "Name":
                    txtName.Text = c1.Name;
                    break;
                case "Age":
                    txtAge.Text = c1.Age.ToString();
                    break;

            }

        }

        private Cust GetData()
        {
            Cust c = new Cust("홍길동", 17);
            return c;
        }

        private void viewData(Cust c1)
        {
            txtName.Text = c1.Name;
            txtAge.Text = c1.Age.ToString();
        }

        private void BtnYear_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            int year = dt.Year - Convert.ToInt32(txtAge.Text) + 1;

            MessageBox.Show("당신의 출생연도는" + year + " 입니다.");

        }

        private void btnAddAge_Click(object sender, RoutedEventArgs e)
        {
            c1.Age++;
            txtAge.Text = c1.Age.ToString(); 
        }
    }
}
