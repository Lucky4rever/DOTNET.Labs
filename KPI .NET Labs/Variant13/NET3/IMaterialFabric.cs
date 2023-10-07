using KPI.NET_Labs.Variant13.NET3.Materials;

namespace KPI.NET_Labs.Variant13.NET3
{
    interface IMaterialFabric
    {
        Material CreateBrick(BrickType type, int count);
        Material CreateConcrete(int count);
        Material CreateReinforcedConcreteSlabs(int lenght, int width, int count);
    }
}
