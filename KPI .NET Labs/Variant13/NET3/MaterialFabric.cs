using KPI.NET_Labs.Variant13.NET3.Materials;

namespace KPI.NET_Labs.Variant13.NET3
{
    class MaterialFabric : IMaterialFabric
    {
        public Material CreateBrick(BrickType type, int count)
        {
            return new Brick(type, count);
        }

        public Material CreateConcrete(int count)
        {
            return new Concrete(count);
        }

        public Material CreateReinforcedConcreteSlabs(int lenght, int width, int count)
        {
            return new ReinforcedConcreteSlabs(lenght, width, count);
        }
    }
}
