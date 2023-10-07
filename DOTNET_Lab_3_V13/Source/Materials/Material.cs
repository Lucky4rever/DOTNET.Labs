﻿namespace DOTNET_Lab3_V13.Source.Materials
{
    abstract class Material
    {
        protected int Count { get; set; }

        public Material(int count)
        {
            this.Count = count;
        }

        public override string ToString()
        {
            return $"Material ({this.Count})";
        }
    }
}
