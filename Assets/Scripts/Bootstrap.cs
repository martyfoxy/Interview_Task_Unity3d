﻿using Assets.Scripts.Managers;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Класс описывающий точку входа игры
    /// </summary>
    public class Bootstrap : MonoBehaviour
    {
        [Tooltip("Список всех менеджеров, которые нужно использовать")]
        public List<BaseManager> Managers = new List<BaseManager>();

        private void Awake()
        {
            Debug.Log("===Bootstrap запущен===");

            //Добавляем все менеджеры из списка в контейнер
            Managers.ForEach(manager =>
            {
                ManagerContainer.AddManager(manager);
            });
        }
    }
}
