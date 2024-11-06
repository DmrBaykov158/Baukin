using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Пример_таблицы_WPF;

namespace prac3
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var s = sender as MenuItem;//берет представление сендера как эллемент менюайтем и использует свойсва менюайтема в дальнейшем
            switch (s.Header)
            {
                case "Выход":this.Close();break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(M.Text, out int m);
            int.TryParse(N.Text, out int n);
            int.TryParse(K.Text, out int k);
            if (m != 0 & n != 0)
            {
                int summ = 0;
                int proiz = 1;

                int[,] Matr = new int[m,n];
                Random rnd = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++ )
                    {
                        Matr[i, j] = rnd.Next(-5, 5);   
                    }
                }
                Date.ItemsSource= VisualArray.ToDataTable(Matr).DefaultView;
                for (int i = 0; i < m; i++)
                {
                    summ += Matr[i, k];
                    proiz *= Matr[i, k];
                }
                Rez.Text = $"Сумма:{summ}" + $"   Произведение:{proiz}";
            }
        }
    }
}