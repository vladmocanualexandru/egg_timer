using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EggTimer
{
    public partial class Form1 : Form
    {
        private Decimal seconds = 0;
        private Decimal initialSeconds = 0;
        private Decimal delta = -1;
        private SoundPlayer player;
        private Boolean timerOn = false;
        private Boolean pauseOn = false;
        private BarIconHandler barIconHandler;

        public Form1()
        {
            InitializeComponent();

            barIconHandler = new BarIconHandler(this, alertAnimationTimer);
        }

       

        private void goResetButton_Click(object sender, EventArgs e)
        {

            delta = -1;
            GoReset();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!pauseOn)
            {
                seconds += delta;

                displayTB.Text = GenerateStringRepresentation(seconds);

                if (delta < 0)
                {
                    progressBar.Value = (int)Math.Round(100 * (double)(initialSeconds - seconds) / (double)initialSeconds);
                }

                if (seconds == 0)
                {
                    TimerReached0();
                }

                barIconHandler.ShowPlayIcon();
            }
            else
            {
                displayTB.Text = "I I";
                barIconHandler.ShowPauseIcon();
            }
           
        }

        private void GoReset()
        {
            if (player != null)
            {
                player.Stop();
            }

            if (timerOn)
            {
                seconds = 0;
                progressBar.Value = 0;
                goResetButton.Text = "Go!";
                barIconHandler.ReturnToNormal();
            }
            else
            {
                CalculateSeconds();
                goResetButton.Text = "Reset";
            }

            timerButton.Enabled = secondsTB.Enabled = minutesTB.Enabled = hoursTB.Enabled = timerOn;

            displayTB.Text = GenerateStringRepresentation(seconds);
            timerOn = timer.Enabled = !timerOn;
            
        }

        private void CalculateSeconds()
        {
            initialSeconds = seconds = Math.Max(1, secondsTB.Value + minutesTB.Value * 60 + hoursTB.Value * 3600);
        }

        private void TimerReached0()
        {
            displayTB.Text = "DING!";

            barIconHandler.StartAlertAnimation();

            player = new System.Media.SoundPlayer(@".\alert.wav");
            player.PlayLooping();
            timer.Enabled = false;

        }

        private String GenerateStringRepresentation(decimal seconds)
        {
            Decimal h = Math.Floor(seconds / 3600);
            Decimal m = Math.Floor(seconds % 3600 / 60);
            Decimal s = seconds % 60;

            String result = "";

            if (s > 0) result = s + "s " + result;
            if (m > 0) result = m + "m " + result;
            if (h > 0) result = h + "h " + result;

            return result.Trim();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                progressBar.Style = ProgressBarStyle.Blocks;
                delta = -1;
                barIconHandler.ReturnToNormal();
            }
            else
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                delta = 1;

            }

            secondsTB.Enabled = minutesTB.Enabled = hoursTB.Enabled = goResetButton.Enabled = timer.Enabled;
            timer.Enabled = !timer.Enabled;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            pauseOn = !pauseOn;
        }

        private class BarIconHandler
        {
            private Boolean rocker = false;
            private Form form;
            private Timer timer;

            private Icon eggIcon = new Icon("egg.ico");
            private Icon eggAlertIcon = new Icon("egg_alert.ico");
            private Icon eggPauseIcon = new Icon("egg_pause.ico");
            private Icon eggPlayIcon = new Icon("egg_play.ico");

            public BarIconHandler(Form form, Timer timer)
            {
                this.form = form;
                this.timer = timer;

                timer.Tick += new EventHandler(this.Tick);
            }

            public void StartAlertAnimation()
            {
                this.timer.Start();
            }

            public void ReturnToNormal()
            {
                this.timer.Stop();
                this.form.Icon = eggIcon;
            }

            public void ShowPlayIcon()
            {
                this.form.Icon = eggPlayIcon;
            }

            public void ShowPauseIcon()
            {
                this.form.Icon = eggPauseIcon;
            }

            private void Tick(object sender, EventArgs e)
            {
                rocker = !rocker;

                this.form.Icon = rocker ? eggIcon : eggAlertIcon;
            }
        }
       
    }
}
