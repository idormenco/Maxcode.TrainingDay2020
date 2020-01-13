// ReSharper disable All
namespace TrainingDay.MutationTesting
{
    public class Donatello
    {
        private const decimal DamageRezist = 0.1m;
        public decimal HealthPoints { get; private set; } = 100;
        
        public void IaBataie(decimal damage)
        {
            decimal damageToTake = damage;

            if(damage >= 50)
            {
                damageToTake = damage - (damage * DamageRezist);
            }

            HealthPoints = HealthPoints - damageToTake;
        }
    }
}
