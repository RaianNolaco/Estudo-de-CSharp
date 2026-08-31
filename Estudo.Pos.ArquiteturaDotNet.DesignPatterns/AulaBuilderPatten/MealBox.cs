using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPatten
{
    internal class MealBox : IMealComposite
    {
        private readonly List<IMealComposite> _mealComposite = new();
        public decimal GetPrice()
        {
            return this._mealComposite.Sum(meal => meal.GetPrice());
        }

        public void addMeals(params IMealComposite[] meals)
        {
            if(meals == null || meals.Length == 0 ) return;
            _mealComposite.AddRange(meals);
            
        }
        public void addMeal(IMealComposite meal)
        {
            _mealComposite.Add(meal);
        }
    }
}
