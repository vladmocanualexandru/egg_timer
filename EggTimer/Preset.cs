using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggTimer
{
    class Preset
    {
        private int currentStep = 0;

        public Preset(List<decimal> steps){
            this.Steps = new List<decimal>();
            Steps.AddRange(steps);

            long secondsSince1970 = (long)Math.Round(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds);
            this.Name = "NewPreset_" + Convert.ToString(secondsSince1970, 16);
        }

        public Preset(string name)
        {
            this.Name = name;
            this.Steps = new List<decimal>();
        }

        public List<Decimal> Steps { get; set; }
        public String Name { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1} steps)", Name, Steps.Count);
        }

        public decimal GetNextStep()
        {
            if (Steps.Count > 0)
            {
                if (currentStep == Steps.Count) currentStep = 0;

                return Steps[currentStep++];
            }
            throw new IndexOutOfRangeException("Preset doesn't have any steps");
        }
    }
}
