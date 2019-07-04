using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Models
{
    public class Food
    {
        public string Name { get; }
        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; }
        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }
        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get;  }

        /// <summary>
        /// Калории за что грамм продукта
        /// </summary>
        public double Calories { get; set; }

        private double CalloriesOneGramm { get { return Calories / 100.0; } }

        private double ProteinsOneGramm { get { return Calories / 100.0; } }

        private double FatsOneGramm { get { return Calories / 100.0; } }
        private double CarbohydratesOneGramm { get { return Calories / 100.0; } }

        public Food(string name) : this(name, 0, 0, 0, 0) { }
        
        public Food(string name, double сalories, double proteins, double fats, double carbohydrates )
        {
            // TODO: проверка
            Name = name;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
            Calories = сalories / 100.0;  
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
