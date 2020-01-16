using System.Collections.Generic;

namespace TrainingDay.MutationTesting
{
    public class Leonardo
    {
        public List<Shuriken> Shurikens { get; }

        public Leonardo()
        {
            Shurikens = new List<Shuriken>
            {
                new Shuriken(100)
            };
        }

        public int LoadShurikens(List<Shuriken> shurikens)
        {
            if (shurikens.Count > 0)
            {
                Shurikens.AddRange(shurikens);
            }

            return Shurikens.Count;
        }
    }
}