﻿using CodeBlogFitness.BL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CodeBlogFitness.BL.Controllers
{
    /// <summary>
    /// Контроллер пользователя 
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения 
        /// </summary>
        public List<User> Users { get; }
        /// <summary>
        /// Текущий Пользователь приложения 
        /// </summary>
        public User CurrentUser { get; }

        public bool IsNewUser { get; } = false;


        /// <summary>
        /// Создание нового контроллера пользователя
        /// </summary>
        /// <param name="user"></param>
        public UserController(string  userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));
            }

            Users = GetUsersData();
            CurrentUser = Users.SingleOrDefault(u => u.Name == userName);

            if (CurrentUser == null) {
                CurrentUser = new User(userName);
                Users.Add(CurrentUser);
                IsNewUser = true;
                Save();
            }
          
        }


        /// <summary>
        /// Получить сохраненый список пользователей. 
        /// </summary>
        /// <returns>Пользователь приложения</returns>
        private List<User> GetUsersData()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is List<User> users)

                {
                    return users;
                }
                else {
                    return new List<User>();
                }

                //TODO: Что делать, если пользователя не прочитали?
            }

        }


        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save() {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate)) {
                formatter.Serialize(fs, Users);
            }
        }
      
    }
}
