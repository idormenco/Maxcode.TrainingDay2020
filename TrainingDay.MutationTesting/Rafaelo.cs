using System.Collections.Generic;
using System.Linq;

namespace TrainingDay.MutationTesting
{
    public class Rafaelo
    {
        public List<Shuriken> Shurikens { get; }

        public Rafaelo(List<Shuriken> shurikens)
        {
            Shurikens = new List<Shuriken>(shurikens);
        }

        public void ThrowShuriken_v1(Shuriken shuriken)
        {
            if (shuriken == null) return;

            var deleteT = Shurikens.Find(c => c.Damage == shuriken.Damage);
            if (deleteT == null) return;

            Shurikens.Remove(deleteT);
        }

        #region secret mutations
        public  void ThrowShuriken_v2(Shuriken shuriken)
        {
            if (shuriken == null) return;

            var deleteT = Shurikens.FirstOrDefault(c => c.Damage == shuriken.Damage);
            if (deleteT == null) return;

            Shurikens.Remove(deleteT);
        }

        public  void ThrowShuriken_v3(Shuriken shuriken)
        {
            if (shuriken == null) return;

            var deleteT = Shurikens.SingleOrDefault(c => c.Damage == shuriken.Damage);

            if (deleteT == null) return;

            Shurikens.Remove(deleteT);
        }


        #endregion
    }
}