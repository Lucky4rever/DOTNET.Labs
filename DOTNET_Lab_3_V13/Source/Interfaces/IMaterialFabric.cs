using DOTNET_Lab3_V13.Source.Resources;

namespace DOTNET_Lab3_V13.Source.Interfaces
{
    interface IMaterialFabric
    {
        IMaterial CreateBrick(BrickType type, int count);
        IMaterial CreateConcrete(int count);
        IMaterial CreateReinforcedConcreteSlabs(int lenght, int width, int count);
    }
}
