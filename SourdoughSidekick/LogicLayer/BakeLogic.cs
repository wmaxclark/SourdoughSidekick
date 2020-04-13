using System;
using DataObjects;

namespace LogicLayer
{
    public class BakeLogic
    {
        public static Bake Recalculate(Bake previousBake, Bake bakeIn, int choice)
        {
            double bakeOutFlour = bakeIn.Flour;
            double bakeOutSalt = bakeIn.Salt;
            double bakeOutYeast = bakeIn.Yeast;
            double bakeOutWater = bakeIn.Water;

            switch (choice)
            {
                case 1:
                    bakeOutSalt = bakeIn.Flour * (bakeIn.Salt / previousBake.Flour);
                    bakeOutYeast = bakeIn.Flour * (bakeIn.Yeast / previousBake.Flour);
                    bakeOutWater = bakeIn.Flour * (bakeIn.Water / previousBake.Flour);
                    break;
                    
                case 2:
                    bakeOutFlour = bakeIn.Salt * (bakeIn.Flour / previousBake.Salt);
                    bakeOutYeast = bakeIn.Salt * (bakeIn.Yeast / previousBake.Salt);
                    bakeOutWater = bakeIn.Salt * (bakeIn.Water / previousBake.Salt);
                    break;

                case 3:
                    bakeOutFlour = bakeIn.Yeast * (bakeIn.Flour / previousBake.Yeast);
                    bakeOutSalt = bakeIn.Yeast * (bakeIn.Salt / previousBake.Yeast);
                    bakeOutWater = bakeIn.Yeast * (bakeIn.Water / previousBake.Yeast);
                    break;

                case 4:
                    bakeOutFlour = bakeIn.Water * (bakeIn.Flour / previousBake.Water);
                    bakeOutSalt = bakeIn.Water * (bakeIn.Salt / previousBake.Water);
                    bakeOutYeast = bakeIn.Water * (bakeIn.Yeast / previousBake.Water);
                    break;

                default:
                    System.Console.WriteLine("You can't create a bake without first entering at least one ingredient.");
                    break;

            }
            return new Bake(bakeOutFlour, bakeOutSalt, bakeOutYeast, bakeOutWater);
        }
    }
}
