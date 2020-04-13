using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects
{
    public class Bake
    {
        public double Flour { set; get; }
        public double Salt { set; get; }
        public double Yeast { set; get; }
        public double Water { set; get; }


        public Bake(double Flour,
                    double Salt,
                    double Yeast,
                    double Water)
        {
            this.Flour = Flour;
            this.Salt = Salt;
            this.Yeast = Yeast;
            this.Water = Water;
        }


    }
}
