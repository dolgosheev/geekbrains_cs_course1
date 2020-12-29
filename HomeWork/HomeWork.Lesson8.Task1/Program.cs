﻿/*
 * Person   :   Dolgosheev Alexander
 * Date     :   29.12.2020
 *
 * Task     :   1.
 *                 а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок
 *                    (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
 *                 б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
 *                 в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия,авторские права и др.).
 *                 г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
 *                 д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
*/

using System;
using System.Windows.Forms;

namespace HomeWork.Lesson8.Task1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
