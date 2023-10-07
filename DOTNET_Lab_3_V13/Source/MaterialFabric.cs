using DOTNET_Lab3_V13.Source.Materials;

namespace DOTNET_Lab3_V13.Source
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
