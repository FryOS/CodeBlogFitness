﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBlogFitness.BL.Models
{
    /// <summary>
    /// Прием пищи
    /// </summary>
    public class Eating
    {
        public DateTime Monent { get; set; }

        public Dictionary<Food, double> Foods { get; }

        public User User { get; }

        public Eating(User user) {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым", nameof(user));
            Monent = DateTime.UtcNow;
            Foods = new Dictionary<Food, double>();
        }

        public void Add(Food food, double weight)
        {
           var product =  Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name));
            if (product == null)
            {
                Foods.Add(food, weight);
            }
            else
            {
                Foods[product] += weight;
            }
        }

    }
}
