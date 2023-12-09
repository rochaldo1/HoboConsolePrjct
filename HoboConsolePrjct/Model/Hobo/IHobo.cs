using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Hobo
{
    public interface IHobo : IEntety
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Hunger { get; set; }
        public decimal EmotionalState { get; set; }
    }
}
