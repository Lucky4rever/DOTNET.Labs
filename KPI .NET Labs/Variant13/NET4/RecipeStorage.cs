using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.NET_Labs.Variant13.NET4
{
    class RecipeStorage
    {
        private readonly List<Recipe> _recipes;

        public RecipeStorage()
        {
            this._recipes = new List<Recipe>();
        }

        public void Add(Recipe recipe)
        {
            this._recipes.Add(recipe);
        }

        public void Remove(Recipe recipe)
        {
            this._recipes.Remove(recipe);
        }

        public List<Recipe> Get()
        {
            return this._recipes;
        }
    }
}
