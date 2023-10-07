using DOTNET_Lab3_V13.Source.Materials;

namespace DOTNET_Lab3_V13.Source
{
    interface IMaterialFabric
    {
        Material CreateBrick(BrickType type, int count);
        Material CreateConcrete(int count);
        Material CreateReinforcedConcreteSlabs(int lenght, int width, int count);
    }
}
