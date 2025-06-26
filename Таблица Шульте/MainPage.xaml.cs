using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Таблица_Шульте
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public byte[] Randomim()
        {
            byte[] mas;
            Random random = new Random();
            mas = new byte[25];
            for (byte i = 0; i < mas.Length; i++)
            {
                if (i != 0)
                {
                    bool Tru = false;
                    while (Tru == false)
                    {
                        mas[i] = (byte)random.Next(1, 26);
                        Tru = true;
                        for (byte j = 0; j < i; j++)
                        {
                            if (mas[j] == mas[i])
                            {
                                Tru = false;
                            }
                        }
                    }
                }
                else
                {
                    mas[i] = (byte)random.Next(1, 26);
                }
            }
            return mas;
        }
        byte[] list;
        public void Zapolnenie(byte[] mas)
        {
            But00.Text = mas[0].ToString();
            But01.Text = mas[1].ToString();
            But02.Text = mas[2].ToString();
            But03.Text = mas[3].ToString();
            But04.Text = mas[4].ToString();
            But10.Text = mas[5].ToString(); 
            But11.Text = mas[6].ToString();
            But12.Text = mas[7].ToString();
            But13.Text = mas[8].ToString();
            But14.Text = mas[9].ToString();
            But20.Text = mas[10].ToString();
            But21.Text = mas[11].ToString();
            But22.Text = mas[12].ToString();
            But23.Text = mas[13].ToString();
            But24.Text = mas[14].ToString();
            But30.Text = mas[15].ToString();
            But31.Text = mas[16].ToString();
            But32.Text = mas[17].ToString();
            But33.Text = mas[18].ToString();
            But34.Text = mas[19].ToString();
            But40.Text = mas[20].ToString();
            But41.Text = mas[21].ToString();
            But42.Text = mas[22].ToString();
            But43.Text = mas[23].ToString();
            But44.Text = mas[24].ToString();
            But00.BackgroundColor = Color.White;
            But01.BackgroundColor = Color.White;
            But02.BackgroundColor = Color.White;
            But03.BackgroundColor = Color.White;
            But04.BackgroundColor = Color.White;
            But10.BackgroundColor = Color.White;
            But11.BackgroundColor = Color.White;
            But12.BackgroundColor = Color.White;
            But13.BackgroundColor = Color.White;
            But14.BackgroundColor = Color.White;
            But20.BackgroundColor = Color.White;
            But21.BackgroundColor = Color.White;
            But22.BackgroundColor = Color.White;
            But23.BackgroundColor = Color.White;
            But24.BackgroundColor = Color.White;
            But30.BackgroundColor = Color.White;
            But31.BackgroundColor = Color.White;
            But32.BackgroundColor = Color.White;
            But33.BackgroundColor = Color.White;
            But34.BackgroundColor = Color.White;
            But40.BackgroundColor = Color.White;
            But41.BackgroundColor = Color.White;
            But42.BackgroundColor = Color.White;
            But43.BackgroundColor = Color.White;
            But44.BackgroundColor = Color.White;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if ((sender as Xamarin.Forms.Button).Text == Score.ToString())
            {
                if ((sender as Xamarin.Forms.Button).Text == "25")
                {
                    alive = false;
                    LastRecord.Text = $"Последний результат:{time}";
                }
                (sender as Xamarin.Forms.Button).BackgroundColor = Color.Gray;
                Score++;
            }
        }
        byte Score = 1;
        void OnButtonG(object sender, EventArgs e)
        {
            list = Randomim();
            Zapolnenie(list);
            Score = 1;
            time = 0;
            if (!alive)
            {
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
                alive = true;
            }
            Timing.Text = "Время: 0";
        }
        int time = 0;
        bool alive = false;
        private bool OnTimerTick()
        {
            time++;
            Timing.Text = "Время: "+time.ToString();
            return alive;
        }
    }
}
