﻿using CodeBlogFitness.BL.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        /// Пользователт приложения 
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера пользователя
        /// </summary>
        /// <param name="user"></param>
        public UserController(string  userName, string genderName, DateTime birthday, double weight, double height) {
            //TODO проверка

            var gender = new Gender(userName);
            User  = new User(genderName, gender, birthday, weight, height);
        }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save() {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate)) {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Загрузить данные пользователя
        /// </summary>
        /// <returns>Пользователь приложения</returns>
        public UserController () {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)

                {
                    User = user;
                }
                  
                //TODO: Что делать, если пользователя не прочитали
            }

        }
    }
}