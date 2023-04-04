using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPClasses //пространство имен проекта
{
    internal class ClsWorker
    {
        //поля
        private string fio;
        private DateTime years;
        private string post;
        // свойства для доступа к полям
        public string FIO
        {
            get { return fio; }//возвращает значение поля
            set { fio = value; } //устанавливает значение поля
        }

        public string Post
        {
            get { return post; } //возвращает значение поля
            set { post = value; } //устанавливает значение поля
        }
        public DateTime Years
        {
            get { return years; }
            set { years = value; }
        }

        //методы 
        //конструктор без параметров задает значения полей по умолчанию
        public ClsWorker()
        {
            fio = "Лебедев М.Д.";
            post = "Ликино-Дулево";
            years = new DateTime(2005, 02, 01);
        }
        //конструктор с параметрами
        public ClsWorker(string f, DateTime y, string p) 
        {
            fio = f;
            years = y;
            post = p;
        }
        //метод вывода на экран
        public string PrintToScreen()
        {
            string line = $"Рабочий {fio}, у него должность {post} поступил на руботу {years}" + "\n";
            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Личные данные рабочего");
            streamWriter.WriteLine($"Должность: {post}");
            streamWriter.WriteLine($"ФИО: {fio}");
            streamWriter.WriteLine($"Дата поступления: {years.ToString()}");
            streamWriter.Close();
        }
    }
}
