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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    class HandleAnEvent
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();

            Window win = new Window();
            win.Title = "Handle An Event";
            win.MouseDown += WindowOnMouseDown;

            app.Run(win);
        }
        static void WindowOnMouseDown(object sender, MouseButtonEventArgs args)
        {
            Window win = sender as Window;
            string strMessage = string.Format("Window Clicked with {0} button at point ({1})", args.ChangedButton, args.GetPosition(win));
            MessageBox.Show(strMessage, win.Title);
        }
    }
    }
