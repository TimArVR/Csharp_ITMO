using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Corner
    {
        int gradus;
        int minutes;
        int seconds;

        public Corner(int gradus, int minutes, int seconds)
        {
            this.Gradus = gradus;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public int Gradus
        {
            set
            {
                if (value < 0)
                {
                    
                    gradus = 0;
                }
                else if (value > 360)
                {
                    gradus = 360;
                }
                else
                {                    
                    gradus = value;
                    //Console.WriteLine("Градусы введены: {0}",this.gradus);
                }

            }
            get
            {
                return gradus;
            }
        }

        public int Minutes
        {
            set
            {
                if (value < 0)
                {
                    minutes = 0;
                }
                else if (value > 60)
                {
                    minutes = 60;
                }
                else
                {
                    minutes = value;
                    //Console.WriteLine("Минуты введены: {0}",this.minutes);
                }
            }
            get
            {
                return minutes;
            }
        }

        public int Seconds
        {
            set
            {
                if (value < 0)
                {
                    seconds = 0;
                }
                else if (value > 60)
                {
                    seconds = 60;
                }
                else
                {
                    seconds = value;
                    //Console.WriteLine("Секунды введены: {0}", this.seconds);
                }
            }
            get
            {
                return seconds;
            }
        }

        public double ToRadians()
        {
            return //gradus*Math.PI/180+minutes*Math.PI/(180*60)+seconds*Math.PI/(180*60*60);
                (gradus + ((double)minutes + (double)seconds / 60) / 60) * Math.PI / 180;
        }

    }
}
