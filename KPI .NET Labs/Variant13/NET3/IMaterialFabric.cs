using DOTNET_Labs.Variant13.NET3.Materials;

namespace DOTNET_Labs.Variant13.NET3
{
    interface IMaterialFabric
    {
        Material CreateBrick(BrickType type, int count);
        Material CreateConcrete(int count);
        Material CreateReinforcedConcreteSlabs(int lenght, int width, int count);
    }
}
