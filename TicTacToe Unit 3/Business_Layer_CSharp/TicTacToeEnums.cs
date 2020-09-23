using System;

namespace Business_Layer_CSharp
{
    /// <summary>
    /// CellOwners is the set of possible cell states
    /// </summary>
    public enum CellOwners
    {
        Error, // this is the default state - never used
        Open,
        Human,
        Computer
    }
}
