// ReSharper disable All
using System;

namespace TrainingDay.MutationTesting
{
    public class Donatello
    {
        private const decimal DamageRezist = 0.1m;
        public decimal HealthPoints { get; private set; } = 100;

        private bool ApplyDamage(decimal damage)
        {
            if (damage < 0)
                throw new ArgumentException("Invalid something something , bad bad !", nameof(damage));


            decimal damageToTake = damage;

            if (damage >= 50)
            {
                damageToTake = damage - (damage * DamageRezist);
            }

            HealthPoints = HealthPoints - damageToTake;

            return true;
        }

        public string IaBataie(decimal damage)
        {
            try
            {
                if (ApplyDamage(damage)) return "Successfully";
                // do more stuff
            }
            catch (ArgumentException e)
            {
                throw new Exception("Something happened", e);
            }
            return null;
        }
    }
}
