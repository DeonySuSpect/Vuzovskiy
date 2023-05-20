using System;

namespace ConsoleApp5
{
    /// <summary>
    /// <brief>Базовый класс "Город"</brif>
    /// ![Image](D:/Учеба/Учеба/Тестирование/Lab2/gorod.jpg)
    /// <details>Данный класс нужен для хранения и обработки информации о городе</details>
    /// </summary>

    class City
    {
        public int citizens = 0; //жители
        public double ploshad = 0; //площадь
        /// <summary>
        /// Функция возвращающая жителей
        /// </summary>
        public int GetCitizens()
        {
            return citizens;
        }
        /// <summary>
        /// Функция возвращающая площадь
        /// </summary>
        public double GetPloshad()
        {
            return ploshad;
        }
        /// <summary>
        /// Конструктор класса City, инициализирующий переменные
        /// </summary>
        /// <param name="citizens">Жители</param>
        /// <param name="ploshad">площадь</param>
        /// </summary>
        public void Init(int citizens, double ploshad)
        {
            this.citizens = citizens;
            this.ploshad = ploshad;
        }
        /// <summary>
        /// Отображает данные о городе на экран
        /// </summary>

        public void Display()
        {
            Console.WriteLine("Количество жителей: " + citizens);
            Console.WriteLine("Количество площади: " + ploshad);
        }
        /// <summary>
        /// Получает данные из консоли
        /// </summary>
        public void Read()
        {
            int cit;
            double pl;

            Console.WriteLine("Введите количество жителей");
            cit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер площади");
            pl = Convert.ToDouble(Console.ReadLine());
            Init(cit, pl);
        }
        /// <summary>
        /// Высчитывает и возвращает плотность населения
        /// </summary>
        public double Density()
        {
            double dens = citizens / ploshad;
            return dens;
        }
    }
    /// <summary>
    /// <brief>Производный класс "Курортный город"</brief>
    /// <author>Bigeev D.L.</author> 
    /// <version>1.9</version> 
    /// <date>May 2023</date>
    /// <warning>Данный класс создан в учебных целях</warning> 
    /// Дочерний класс, который отнаследован от ранее созданного класса City
    /// </summary>

    class CurortCity : City
    {
        private int tourists; // туристы
        /// <summary>
        /// Конструктор класса CurortCity, инициализирующий переменные
        /// </summary>
        /// <param name="citizens">обычные жители</param>
        /// <param name="ploshad">площадь</param>
        /// <param name="ad">кол-во взрослых</param>
        /// <param name="ch">кол-во детей</param>
        public void Init(int citizens, double ploshad, int tourists)
        {
            this.citizens = citizens;
            this.ploshad = ploshad;
        }
        /// <summary>
        /// Отображает данные о курортном городе на экран
        /// </summary>
        new public void Display()
        {
            Console.WriteLine("Количество жителей: " + citizens + tourists);
            Console.WriteLine("Количество площади: " + ploshad);
        }
        /// <summary>
        /// Высчитывает и возвращает плотность населения
        /// </summary>
        new public double Density()
        {
            double dens = (citizens + tourists) / ploshad;
            return dens;
        }
    }
    /// <summary>
    /// <brief>Класс "Страна"</brief>
    /// ![Image](D:/Учеба/Учеба/Тестирование/Lab2/world_map_with_countries.jpg)
    /// <details>Содержит информацию о городах и жителях и площади вне городов.</details>
    /// </summary>

    class Country
    {
        City City1 = new City(), City2 = new City(), City3 = new City(); //3 города
        double free_ploshad; //свободная площадь вне городов
        int free_citizens; //жители вне городов
        String name; //имя города
        /// <summary>
        /// Первый конструктор Country, принимает 3 города и free_citizens и free_ploshad
        /// </summary>
        /// <param name="n">название города</param>
        /// <param name="City1">первый город</param>
        /// <param name="City2">второй город</param>
        /// <param name="City3">3ий город</param>
        /// <param name="free_citizens">жители вне городов</param>
        /// <param name="free_ploshad">свободная площадь вне городов</param>
        /// </summary>
        public void Init(String n, City City1, City City2, City City3, int free_citizens, double free_ploshad)
        {
            this.name = n;
            this.City1 = City1;
            this.City2 = City2;
            this.City3 = City3;
            this.free_citizens = free_citizens;
            this.free_ploshad = free_ploshad;
        }
        /// <summary>
        /// второ конструктор Country, принимает 3 города (и значения для их заполнения) и free_citizens и free_ploshad
        /// </summary>
        /// <param name="n">название города</param>
        /// <param name="City1">первый город</param>
        /// <param name="City2">второй город</param>
        /// <param name="City3">3ий город</param>
        /// <param name="citizens1">жители 1го города</param>
        /// <param name="citizens2">жители 2го города</param>
        /// <param name="citizens3">жители 3го города</param>
        /// <param name="ploshad1">площадь 1го города</param>
        /// <param name="ploshad2">площадь 2го города</param>
        /// <param name="ploshad3">площадь 3го города</param>
        /// <param name="free_citizens">жители вне городов</param>
        /// <param name="free_ploshad">свободная площадь вне городов</param>
        /// </summary>
        public void Init(String n, City City1, City City2, City City3, int citizens1, double ploshad1, int citizens2, double ploshad2, int citizens3, double ploshad3, int free_citizens, double free_ploshad)
        {
            this.name = n;
            City1.Init(citizens1, ploshad1);
            this.City1 = City1;
            City2.Init(citizens2, ploshad2);
            this.City1 = City2;
            City3.Init(citizens3, ploshad3);
            this.City1 = City3;
            this.free_citizens = free_citizens;
            this.free_ploshad = free_ploshad;
        }
        public void Read()
        {
            Console.WriteLine("введите данные для 1го города:");
            City1.Read();
            Console.WriteLine("введите данные для 2го города:");
            City2.Read();
            Console.WriteLine("введите данные для 3го города:");
            City3.Read();
            Console.WriteLine("введите количество людей не живущих в этих городах:");
            free_citizens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите не занятую городами площадь:");
            free_ploshad = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Вычисление среднего насления по стране
        /// </summary>
        /// <returns>sredn - среднее кол-во жителей на 1ед площади</returns>
        /// Формула для вычисления:
        /// \f$ sredn = summ(citizens)\sum(ploshad) \f$
        /// 

        public double SredniePoStrane()
        {
            double x = (City1.GetCitizens() + City2.GetCitizens() + City3.GetCitizens() + free_citizens) / (City1.GetPloshad() + City2.GetPloshad() + City3.GetPloshad() + free_ploshad);
            return x;
        }
        /// <summary>
        /// находит город с наибольшой плотностью населения
        /// </summary>
        /// <returns>город с наибольшой плотностью населения</returns>

        public City BiggestDensity()
        {
            City[] arr = new City[] { City1, City2, City3 };
            double max = 0;
            City c = new City();
            for (int i = 0; i < 3; i++)
            {
                if (arr[i].Density() > max)
                {
                    max = arr[i].Density();
                    c = arr[i];
                }

            }
            return c; //Возвращать City
        }
        /// <summary>
        /// находит город с наибольшой плотностью населения
        /// </summary>
        /// <returns>индекс города с наибольшой плотностью населения</returns>
        public int BiggestDensityNum(City c)
        {
            City[] arr = new City[] { City1, City2, City3 };
            for (int i = 0; i < 3; i++)
            {
                if (arr[i].Density() == c.Density())
                {
                    return i + 1;
                }
            }
            return 0;
        }
        /// <summary>
        /// Отображает на экране информацию о стране
        /// </summary>

        public void Display()
        {
            Console.WriteLine("Название страны: " + name);
            Console.WriteLine("Кол-во жителей и площади в городе 1 : " + City1.GetCitizens() + " " + City1.GetPloshad());
            Console.WriteLine("Кол-во жителей и площади в городе 2 : " + City2.GetCitizens() + " " + City2.GetPloshad());
            Console.WriteLine("Кол-во жителей и площади в городе 3 : " + City3.GetCitizens() + " " + City3.GetPloshad());
        }
        /// <summary>
        /// получение имени страны
        /// </summary>

        public string Getname()
        {
            return name;
        }
        /// <summary>
        /// задание имени страны
        /// <param name="s">назавание страны</param>
        /// </summary>
        public void Putname(string s)
        {
            name = s;
        }
    }
}
/*class Program
{
    static void Main(string[] args)
    {

        City c1 = new City(), c2 = new City(), c3 = new City();
        c1.Init(100, 50);
        c2.Init(100, 100);
        c3.Init(200, 150);
        string a;
        Country g = new Country();
        Country[] f = new Country[6];
        for(int i = 0; i < 6; i++)
            {
                f[i] = new Country();
            }
        f[0].Init("bolshie goroda serie poezda", c1, c2, c3, 500, 100);
        f[1].Init("mama mila ramu", c1, c2, c3, 500, 100);
        f[2].Init("red yellow green", c1, c2, c3, 500, 100);
        f[3].Init("one three four two", c1, c2, c3, 500, 100);
        f[4].Init("eno ehret rouf owt", c1, c2, c3, 500, 100);
        f[5].Init("123 321 213 231", c1, c2, c3, 500, 100);
            Console.WriteLine("Входные данные");
            for (int i = 0; i < 6; i++)
            {
                f[i].Display();
            }
            char bc;
        for(int i = 0; i < 6; i++)
            {
                string bs = "";
                a = f[i].Getname();
                string[] w = a.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int k = 0; k < w.Length; k++)
                {
                    char[] charStr = w[k].ToCharArray();
                    bc = charStr[0];
                    charStr[0] = charStr[charStr.Length - 1];
                    charStr[charStr.Length - 1] = bc;
                    w[k] = new string(charStr);
                }
                bs = w[0];
                for (int k = 1; k < w.Length; k++)
                {
                    bs = bs + " " + w[k];
                }
                f[i].Putname(bs);
            }
            Console.WriteLine();
            Console.WriteLine("Выходные данные");
            for (int i = 0; i<6; i++)
            {
                f[i].Display();
            }
    }
}*/

