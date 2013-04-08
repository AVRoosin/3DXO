using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Menu
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public Game XOGame;
       // private double Xpos=0.15;
        private System.Windows.Media.Media3D.Point3D pos1 = new Point3D(0, 22, 45);
        private System.Windows.Media.Media3D.Vector3D dir1 = new Vector3D(0, -10, -30);
        private System.Windows.Media.Media3D.GeometryModel3D thorus = new GeometryModel3D();
        private System.Windows.Media.Media3D.ModelVisual3D tor=new ModelVisual3D();
        private SolidColorBrush RBrush= new SolidColorBrush(Colors.Red);
        private SolidColorBrush BBrush = new SolidColorBrush(Colors.Blue);
        private SolidColorBrush OBrush = new SolidColorBrush(Colors.Orange);
        //private SolidColorBrush light = new SolidColorBrush(0.566038, 0.566038, 0.566038);
        
        public GameWindow()
        {
            InitializeComponent();
        }

        private void SetX(double X)
        {
            pos1.X = X;
            dir1.X = 0-X;
            if(X>20)
            {
                pos1.Z = 45 - X + 20;
            }
            if(X<-20)
            {
                pos1.Z = 45 + X + 20;
            }
            newcam.Position = pos1;
            newcam.LookDirection = dir1;
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetX(Slider1.Value);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XOGame=new Game();
            this.textBlock1.Text = "Ходит Игрок 1:";
            for (int i=0;i<4;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button Btn = new Button();
                    Btn.Height = 40;
                    Btn.Width = 40;
                    Btn.Click += new RoutedEventHandler(Btn_Click);
                    Btn.Template = button5.Template;
                    wrapPanel1.Children.Add(Btn);
                    Btn.Name = string.Concat("Btn", Convert.ToString(i+1), Convert.ToString(j+1));
                }
            }
        }

        private void wrapPanel1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

       private void Btn_Click(object sender, RoutedEventArgs e)
        {
            int x, z, y;
            string str = (sender as Button).Name;
            x = Convert.ToInt32(str.Substring(3, 1))-1;
            z = Convert.ToInt32(str.Substring(4, 1))-1;
           int result = XOGame.DoTurn(Convert.ToInt32(x), Convert.ToInt32(z));
           if (result != -1)
           {
               y = XOGame.YPos;
               TorusSet(x, y, z, XOGame.CurrCol);
               switch (result)
               {
                   case 0:
                       {
                           if (this.textBlock1.Text == "Ходит Игрок 1:")
                           {
                               this.textBlock1.Text = "Ходит Игрок 2:";
                           }
                           else
                           {
                               this.textBlock1.Text = "Ходит Игрок 1:";
                           }
                           break;
                       }
                   case 1:
                       {
                           DrawAttentionToWinningRow(XOGame.GetWinningRowNumber());
                           this.textBlock1.Text = "Игрок 1 ПОБЕДИЛ!!!";
                           break;
                       }
                   case 2:
                       {
                           DrawAttentionToWinningRow(XOGame.GetWinningRowNumber());
                           this.textBlock1.Text = "Игрок 2 ПОБЕДИЛ!!!";
                           break;
                       }
               }
           }
        }

       private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
       {
       //    MainWindow Main = new MainWindow();
       //    Main.Show();
       }
       private void DrawAttentionToWinningRow(UInt64 number)
       {
           while(number>0)
           {
               UInt64 xx = 0;
               UInt64 yy = 0;
               UInt64 zz = 0;
           zz=number%10;
           number=number/10;
           yy=number%10;
           number=number/10;
           xx=number%10;
           number=number/10;
           ShowWinningRow(xx, yy, zz);
           }
       }
       private void ShowWinningRow(UInt64 x, UInt64 y, UInt64 z)
       {
           //switch (x)
           //{
           //    case 0:
           //        {
           //            switch (z)
           //            {
           //                case 0:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_049;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_050;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_051;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_052;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 1:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_053;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_054;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_055;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_056;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 2:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_057;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_058;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_059;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_060;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 3:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_061;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_062;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_063;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_064;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //            }
           //            break;
           //        }
           //    case 1:
           //        {
           //            switch (z)
           //            {
           //                case 0:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_033;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_034;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_035;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_036;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 1:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_037;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_038;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_039;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_040;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 2:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_041;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_042;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_043;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_044;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 3:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_045;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_046;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_047;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_048;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //            }
           //            break;
           //        }
           //    case 2:
           //        {
           //            switch (z)
           //            {
           //                case 0:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_017;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_018;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_019;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_020;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 1:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_021;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_022;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_023;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_024;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 2:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_025;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_026;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_027;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_028;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 3:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_029;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_030;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_031;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_032;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //            }
           //            break;
           //        }
           //    case 3:
           //        {
           //            switch (z)
           //            {
           //                case 0:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_001;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_002;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_003;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_004;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 1:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_005;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_006;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_007;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_008;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 2:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_009;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_010;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_011;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_012;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //                case 3:
           //                    {
           //                        switch (y)
           //                        {
           //                            case 0:
           //                                {
           //                                    thorus = Torus_013;

           //                                    break;
           //                                }
           //                            case 1:
           //                                {
           //                                    thorus = Torus_014;

           //                                    break;
           //                                }
           //                            case 2:
           //                                {
           //                                    thorus = Torus_015;

           //                                    break;
           //                                }
           //                            case 3:
           //                                {
           //                                    thorus = Torus_016;

           //                                    break;
           //                                }
           //                        }
           //                        break;
           //                    }
           //            }
           //            break;
           //        }
           //}
           //DiffuseMaterial DifMatB3 = new DiffuseMaterial(OBrush);
           //thorus.Material = DifMatB3;
       }

        private void TorusSet(int x, int y, int z, int currcol)
        {
            switch (x)
            {
                case 0:
                    {
                        switch (z)
                        {
                            case 0:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_049;
                                                tor = Torus_049Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_050;
                                                tor = Torus_050Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_051;
                                                tor = Torus_051Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_052;
                                                tor = Torus_052Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_053;
                                                tor = Torus_053Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_054;
                                                tor = Torus_054Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_055;
                                                tor = Torus_055Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_056;
                                                tor = Torus_056Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_057;
                                                tor = Torus_057Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_058;
                                                tor = Torus_058Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_059;
                                                tor = Torus_059Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_060;
                                                tor = Torus_060Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_061;
                                                tor = Torus_061Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_062;
                                                tor = Torus_062Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_063;
                                                tor = Torus_063Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_064;
                                                tor = Torus_064Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 1:
                    {
                        switch (z)
                        {
                            case 0:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_033;
                                                tor = Torus_033Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_034;
                                                tor = Torus_034Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_035;
                                                tor = Torus_035Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_036;
                                                tor = Torus_036Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_037;
                                                tor = Torus_037Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_038;
                                                tor = Torus_038Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_039;
                                                tor = Torus_039Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_040;
                                                tor = Torus_040Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_041;
                                                tor = Torus_041Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_042;
                                                tor = Torus_042Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_043;
                                                tor = Torus_043Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_044;
                                                tor = Torus_044Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_045;
                                                tor = Torus_045Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_046;
                                                tor = Torus_046Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_047;
                                                tor = Torus_047Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_048;
                                                tor = Torus_048Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        switch (z)
                        {
                            case 0:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_017;
                                                tor = Torus_017Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_018;
                                                tor = Torus_018Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_019;
                                                tor = Torus_019Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_020;
                                                tor = Torus_020Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_021;
                                                tor = Torus_021Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_022;
                                                tor = Torus_022Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_023;
                                                tor = Torus_023Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_024;
                                                tor = Torus_024Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_025;
                                                tor = Torus_025Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_026;
                                                tor = Torus_026Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_027;
                                                tor = Torus_027Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_028;
                                                tor = Torus_028Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_029;
                                                tor = Torus_029Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_030;
                                                tor = Torus_030Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_031;
                                                tor = Torus_031Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_032;
                                                tor = Torus_032Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        switch (z)
                        {
                            case 0:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_001;
                                                tor = Torus_001Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_002;
                                                tor = Torus_002Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_003;
                                                tor = Torus_003Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_004;
                                                tor = Torus_004Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_005;
                                                tor = Torus_005Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_006;
                                                tor = Torus_006Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_007;
                                                tor = Torus_007Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_008;
                                                tor = Torus_008Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_009;
                                                tor = Torus_009Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_010;
                                                tor = Torus_010Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_011;
                                                tor = Torus_011Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_012;
                                                tor = Torus_012Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    switch (y)
                                    {
                                        case 0:
                                            {
                                                thorus = Torus_013;
                                                tor = Torus_013Container;
                                                break;
                                            }
                                        case 1:
                                            {
                                                thorus = Torus_014;
                                                tor = Torus_014Container;
                                                break;
                                            }
                                        case 2:
                                            {
                                                thorus = Torus_015;
                                                tor = Torus_015Container;
                                                break;
                                            }
                                        case 3:
                                            {
                                                thorus = Torus_016;
                                                tor = Torus_016Container;
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
            }
            DiffuseMaterial DifMatBl = new DiffuseMaterial(RBrush);
            DiffuseMaterial DifMatB2 = new DiffuseMaterial(BBrush);
            System.Windows.Media.Media3D.TranslateTransform3D trtr3d =new TranslateTransform3D(0.0,20.0,0.0);
            System.Windows.Media.Media3D.Transform3DGroup trgroup =new Transform3DGroup();
            System.Windows.Media.Animation.DoubleAnimation dbAnim = new DoubleAnimation(0, TimeSpan.FromMilliseconds(1000), FillBehavior.HoldEnd);
            trtr3d.BeginAnimation(TranslateTransform3D.OffsetYProperty, dbAnim);
            trgroup.Children.Add(trtr3d);
            tor.Transform = trgroup;
            if (currcol == 1)
            {
                thorus.Material = DifMatBl;
            }
            else
            {
                thorus.Material = DifMatB2;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dir1.X = 0;
            dir1.Y = -10;
            dir1.Z = -30;
            pos1.X = 0;
            pos1.Y = 22;
            pos1.Z = 45;
            newcam.Position = pos1;
            newcam.LookDirection = dir1;
            Slider1.Value = 0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            GameWindow GW = new GameWindow();
            GW.Show();
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow M =new MainWindow();
            M.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow Help =new HelpWindow();
            Help.ShowDialog();
        }
        private void RectMouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (button5.IsMouseDirectlyOver == false && button4.IsMouseDirectlyOver == false && button2.IsMouseDirectlyOver == false && button3.IsMouseDirectlyOver == false && groupBox1.IsMouseDirectlyOver == false && e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void TBMouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
