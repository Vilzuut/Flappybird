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


using System.Windows.Threading;

namespace FlappyBirb_Peli
{
   
    public partial class MainWindow : Window
    {

        DispatcherTimer peliAika = new DispatcherTimer();
        double Pisteet;
        int painovoima = 8;
        bool PeliPaattyi;
        Rect FlappyBirdHitBox;

        public MainWindow()
        {
            InitializeComponent();
            // Kun sovellus käynnistyy, Kirjautumis form näytetään ensin
            System.Windows.Forms.Application.Run(new Kirjautuminen());

            peliAika.Tick += MainEventTimer;
            peliAika.Interval = TimeSpan.FromMilliseconds(20);
            AloitaPeli();

        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            txtPisteet.Content = "Pisteet: " + Pisteet;
            // Tekee linnun hitboxista pienemmän
            FlappyBirdHitBox = new Rect(Canvas.GetLeft(Lintu), Canvas.GetTop(Lintu), Lintu.Width - 8, Lintu.Height -3);

            Canvas.SetTop(Lintu, Canvas.GetTop(Lintu) + painovoima);

            if (Canvas.GetTop(Lintu) < -10 || Canvas.GetTop(Lintu) > 458)
            {
                LopetaPeli();
            }

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "obs1" || (string)x.Tag == "obs2" || (string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < -100)
                    {
                        Canvas.SetLeft(x, 800);

                        Pisteet += .5;
                    }

                    Rect putkiHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);
                    // Jos Flappy Bird osuu putkiin, peli loppuu
                    if (FlappyBirdHitBox.IntersectsWith(putkiHitBox))
                    {
                        LopetaPeli();
                    }

                }
            }
        }


        
        private void Alas(object sender, KeyEventArgs e)
        {
            // Jos Space nappia painetaa, lintu menee ylöspäin
            if (e.Key == Key.Space)
            {
                painovoima = -8;
            }
            // Jos nappia R painetaan, peli päättyy ja voit aloittaa uudelleen
            if (e.Key == Key.R && PeliPaattyi == true)
            {
                AloitaPeli();
            }
            
            
        }
        // Jos space bar nappia ei paineta, lintu menee alas
        private void Ylos(object sender, KeyEventArgs e)
        {
            painovoima = 8;
        }


        private void AloitaPeli()
        {

            MyCanvas.Focus();
            Pisteet = 0;
            PeliPaattyi = false;
            Canvas.SetTop(Lintu, 190);

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "obs1")
                {
                    Canvas.SetLeft(x, 500);
                }
                if ((string)x.Tag == "obs2")
                {
                    Canvas.SetLeft(x, 800);
                }
                if ((string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, 1100);
                }
            }
            peliAika.Start();

        }

        private void LopetaPeli()
        {
            peliAika.Stop();
            PeliPaattyi = true;
            txtPisteet.Content += " Peli Päättyi, Paina R aloittaaksesi uudelleen";
        }
    }
}
