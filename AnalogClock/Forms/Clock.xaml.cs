using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AnalogClock.Forms
{
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : Window
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);


        public Clock()
        {
            InitializeComponent();

            DateTime date = DateTime.Now;
            TimeZone time = TimeZone.CurrentTimeZone;
            TimeSpan difference = time.GetUtcOffset(date);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
            {
                secondHand.Angle = DateTime.Now.Second * 6;
                minuteHand.Angle = DateTime.Now.Minute * 6;
                hourHand.Angle = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5);
            }));
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void RestartMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnalogClock.Forms.About about = new About();
            about.ShowDialog();
        }

        private void HBlack_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.Black;
        }

        private void HWhie_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.White;
        }

        private void HRed_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.Crimson;
        }

        private void HBlue_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.DodgerBlue;
        }

        private void HGreen_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.Green;

        }

        private void HOrange_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.Tomato;
        }

        private void HGold_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.Gold;

        }

        private void HMagenta_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleHour.Stroke = Brushes.SlateBlue;
        }

        private void MBlack_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.Black;
        }

        private void MWhite_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.White;
        }

        private void MRed_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.Crimson;
        }

        private void MBlue_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.DodgerBlue;
        }

        private void MGreen_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.Green;
        }

        private void MOrange_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.Orange;
        }

        private void MGold_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.Gold;
        }

        private void MMagenta_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleMinute.Stroke = Brushes.SlateBlue;
        }

        private void SBlack_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.Black;
        }

        private void SWhite_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.White;
        }

        private void SRed_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.Crimson;
        }

        private void SBlue_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.DodgerBlue;
        }

        private void SGreen_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.Green;
        }

        private void SOrange_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.Tomato;
        }

        private void SGold_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.Gold;
        }

        private void SMagenta_Click(object sender, RoutedEventArgs e)
        {
            this.rectangleSecond.Stroke = Brushes.SlateBlue;
        }
    }
}
