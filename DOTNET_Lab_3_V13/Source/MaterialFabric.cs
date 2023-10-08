using DOTNET_Lab3_V13.Source.Interfaces;
using DOTNET_Lab3_V13.Source.Materials;
using DOTNET_Lab3_V13.Source.Resources;

namespace DOTNET_Lab3_V13.Source
{
    class MaterialFabric : IMaterialFabric
    {
        public IMaterial CreateBrick(BrickType type, int count)
        {
            return new Brick(type, count);
        }

        public IMaterial CreateConcrete(int count)
        {
            return new Concrete(count);
        }

        public IMaterial CreateReinforcedConcreteSlabs(int lenght, int width, int count)
        {
            return new ReinforcedConcreteSlabs(lenght, width, count);
        }
    }
}
