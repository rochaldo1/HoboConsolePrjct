using HoboConsole.Model.Items;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Effects
{
    public static class ChangeStatic
    {
        public static void EmotionalChange(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
                hobo.EmotionalState += food.Pleasure;
            if (entity is Drugs drugs)
                hobo.EmotionalState += drugs.Pleasure;
            if (entity is Medicine medicine)
                hobo.EmotionalState += medicine.Pleasure;
            if (entity is RealEstate estate)
                hobo.EmotionalState += estate.Pleasure;
            if (entity is Clothes clothes)
                hobo.EmotionalState += clothes.Pleasure;
            if (entity is Garbage garbage)
                hobo.EmotionalState += garbage.Pleasure;
        }
        public static void EnergySatiation(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
                hobo.Energy += food.EnergyBoost;
            if (entity is Drugs drugs)
                hobo.Energy += drugs.EnergyBoost;
            if (entity is Medicine medicine)
                hobo.Energy += medicine.EnergyBoost;
        }

        public static void HealthChange(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
                hobo.Health += food.Healthy;
            if (entity is Drugs drugs)
                hobo.Health += drugs.Healthy;
            if (entity is Medicine medicine)
                hobo.Health += medicine.Healthy;
            if (entity is Garbage garbage)
                hobo.Health += garbage.Healthy;
        }

        public static void SatiationChange(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
            {
                hobo.Satiation += food.Nutrition;
            }
        }
    }
}
