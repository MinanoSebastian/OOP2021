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
using System.Windows.Threading;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();

        Random rand = new Random();
        private static int anserNum = 0;

        //private Random rand= new Random();
        //private int anserNum;
        
        //private const int Rows = 5;     // 行
        //private const int Columns = 5; //　列

        //private SolidColorBrush selectedButtonColor = new SolidColorBrush(Colors.Blue);
        //private SolidColorBrush hitButtonColor = new SolidColorBrush(Colors.Yellow);



        public MainWindow()
        {
            anserNum = rand.Next(1, 26);
            InitializeComponent();

            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dt.Start();
            sw.Start();
            dt.Tick += Dt_Tick;
            this.Title = "NumberGame [00:00:000]";
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            this.Title = "NumberGame [" + sw.Elapsed.ToString(@"mm\:ss\:fff") + "]";
        }

        private  void button_click(object sender, RoutedEventArgs e)
        {
            Button bt = e.Source as Button;
            bt.Background = Brushes.PeachPuff;

            var count = int.Parse(((Button)sender).Content.ToString());

            if (count < anserNum)
            {
                // 大きいとき
                this.comment.Text = "もっとでけーよ";
            }
            else if (count > anserNum)
            {
                // 小さいとき
                this.comment.Text = "もっとちいせーよ";
            }
            else if (count == anserNum)
            {
                // 値が一緒のとき
                this.comment.Text = "せーかい";
            }
        }

        public void random(int min, int max)
        {
            Random rm = new System.Random();
            anserNum = rm.Next(min, max);
        }


        /*private void MainDisp_Loaded(object sender, RoutedEventArgs e)
        {
            // 正解を取得
            anserNum = random.Next(Rows * Columns) + 1;

            // 行
            for(int i = 0; i < Rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            // 列
            for(int i = 0; i < Rows; i++)
            {
                grid.ColumDefinitions.Add(new ColumnDefinition());
            }

            for(int i = 0; i<Rows; i++)
            {
                for(int j = 0; j < Rows; j++)
                {
                    var bt = new Button();
                    bt.Width = MainWindw.Width / Colums;
                    bt.Height = MainWindow.Height / Rows;
                    
                    bt.Content = (j+ 1) + i * Rows;
                    bt.Click += Bt_Click;
                    Grid.SetRow(bt_1);
                    Grid.SetColum(bt, j);
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));
            MainForm.Height += textDisp.Height + 50;
        }*/  
    }
}

