using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class types
    {
        // Определение структуры titleAuthor
        public struct titleAuthor
        {
            public string au_id;  // ID автора (формат ###-##-####)
            public string title_id;  // ID заголовка (формат AA####)
            public short? au_ord;  // Номер автора, может быть null
            public int? royaltyper;  // Процент роялти, может быть null
        }
        static void Main(string[] args)
        {

            Console.WriteLine(" - - - Типы данных - - - \n");

            bool check = true;

            byte bit1 = 1; //хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte

            short n1 = 1; //short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16

            ushort un1 = 1; //ushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16

            int a = 10; //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32.
                        //Все целочисленные литералы по умолчанию представляют значения типа int:

            uint u = 10; //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32

            long l = -10; //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64

            ulong a1 = 10; //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. Представлен системным типом System.UInt64

            float f = 1.999F; //float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single

            double d = 1.23; //double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. Представлен системным типом System.Double

            decimal dec = 1.23M; //decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal

            char ch = 'A'; //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. Этому типу соответствуют символьные литералы:

            string hello = "Hello"; //string: хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют строковые литералы.

            object ob = 22; //object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET.


            // Ввод значений с консоли
            //  Console.Write("Введите значение для bool (true/false): ");
            //  check = Convert.ToBoolean(Console.ReadLine());
            //
            //  Console.Write("Введите значение для byte: ");
            //  bit1 = Convert.ToByte(Console.ReadLine());
            //
            //  Console.Write("Введите значение для short: ");
            //  n1 = Convert.ToInt16(Console.ReadLine());
            //
            //  Console.Write("Введите значение для ushort: ");
            //  un1 = Convert.ToUInt16(Console.ReadLine());
            //
            //  Console.Write("Введите значение для int: ");
            //  a = Convert.ToInt32(Console.ReadLine());
            //
            //  Console.Write("Введите значение для uint: ");
            //  u = Convert.ToUInt32(Console.ReadLine());
            //
            //  Console.Write("Введите значение для long: ");
            //  l = Convert.ToInt64(Console.ReadLine());
            //
            //  Console.Write("Введите значение для ulong: ");
            //  a1 = Convert.ToUInt64(Console.ReadLine());
            //
            //  Console.Write("Введите значение для float: ");
            //  f = Convert.ToSingle(Console.ReadLine());
            //
            //  Console.Write("Введите значение для double: ");
            //  d = Convert.ToDouble(Console.ReadLine());
            //
            //  Console.Write("Введите значение для decimal: ");
            //  dec = Convert.ToDecimal(Console.ReadLine());
            //
            //  Console.Write("Введите символ для char: ");
            //  ch = Console.ReadKey().KeyChar; // Чтение одного символа
            //  Console.WriteLine(); // Переход на новую строку
            //
            //  Console.Write("Введите строку для string: ");
            //  hello = Console.ReadLine();
            //
            //  Console.Write("Введите значение для object: ");
            //  ob = Console.ReadLine(); // Считывание строки как объект


            // Вывод значений в консоль
            Console.WriteLine("Bool: " + check);
            Console.WriteLine("Byte: " + bit1);
            Console.WriteLine("Short: " + n1);
            Console.WriteLine("UShort: " + un1);
            Console.WriteLine("Int: " + a);
            Console.WriteLine("UInt: " + u);
            Console.WriteLine("Long: " + l);
            Console.WriteLine("ULong: " + a1);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Double: " + d);
            Console.WriteLine("Decimal: " + dec);
            Console.WriteLine("Char: " + ch);
            Console.WriteLine("String: " + hello);
            Console.WriteLine("Object: " + ob);

            Console.WriteLine(check);







            // 1. Явное приведение от double к int (потеря данных)
            double dd = 9.78;
            int i = (int)d; // Явное приведение
            Console.WriteLine(i); // Результат: 9 (десятичная часть отбрасывается)

            // 2. Явное приведение от long к int (возможна потеря данных)
            long ll = 10000000000;
            int i2 = (int)l; // Явное приведение
            Console.WriteLine(i2); // Потеря данных, так как значение long может быть больше диапазона int

            // 3. Явное приведение от float к int (потеря данных)
            float ff = 5.99f;
            int i3 = (int)f; // Явное приведение
            Console.WriteLine(i3); // Результат: 5

            // 4. Явное приведение от объекта к строке (используя приведение)
            object obj = "Hello";
            string str = (string)obj; // Явное приведение
            Console.WriteLine(str); // Результат: Hello

            // 5. Приведение от char к int (преобразование символа в код символа ASCII)
            char c = 'A';
            int asciiCode = (int)c; // Явное приведение
            Console.WriteLine(asciiCode); // Результат: 65 (ASCII код 'A')






            // 1. Преобразование строки в число
            string strr = "12345";
            int num;

            // Безопасное преобразование строки в число
            if (int.TryParse(strr, out num))
            {
                Console.WriteLine(num); // Результат: 12345
            }
            else
            {
                Console.WriteLine("Ошибка: Строка не является допустимым числом.");
            }

            // 2. Преобразование числа в строку
            double ddd = 123.456;
            string str2 = Convert.ToString(d); // Преобразование числа в строку
            Console.WriteLine(str2); // Результат: "123.456"

            // 3. Преобразование bool в int
            bool flag = true;
            int boolToInt = Convert.ToInt32(flag); // Преобразование true в 1
            Console.WriteLine(boolToInt); // Результат: 1

            // 4. Преобразование из float в byte (с учетом возможного переполнения)
            float fff = 123.45f;
            byte b = Convert.ToByte(f); // Преобразование float в byte
            Console.WriteLine(b); // Результат: 123 (дробная часть отбрасывается)

            // 5. Преобразование из строки в DateTime
            string dateStr = "2024-09-07";
            DateTime date = Convert.ToDateTime(dateStr); // Преобразование строки в DateTime
            Console.WriteLine(date); // Результат: 07.09.2024 00:00:00


            //   Возможности класса Convert:
            //   Преобразование между различными типами данных, такими как int, float, double, bool, string, char, и DateTime.
            //   Обрабатывает возможные исключения, такие как FormatException, OverflowException.
            //   Имеет методы ToInt32, ToDouble, ToBoolean, ToString и многие другие для приведения данных.







            // Упаковка (boxing)
            int value = 123;          // Значимый тип (int)
            object objj = value;       // Упаковка: значимый тип становится ссылочным (object)
            Console.WriteLine("Упакованный объект: " + objj);

            // Распаковка (unboxing)
            int unboxedValue = (int)objj;  // Распаковка: преобразуем обратно в значимый тип (int)
            Console.WriteLine("Распакованное значение: " + unboxedValue);

            // Упаковка структуры
            DateTime datet = DateTime.Now; // Значимый тип (DateTime)
            object boxedDate = date;      // Упаковка структуры DateTime
            Console.WriteLine("Упакованная дата: " + boxedDate);

            // Распаковка структуры
            DateTime unboxedDate = (DateTime)boxedDate; // Распаковка обратно в DateTime
            Console.WriteLine("Распакованная дата: " + unboxedDate);







            // Неявно типизированная переменная (компилятор сам определяет тип)
            var number = 42; // Компилятор понимает, что это int
            var text = "Hello, world!"; // Компилятор понимает, что это string
            var pi = 3.14159; // Компилятор определяет как double
            var isActive = true; // Компилятор определяет как bool

            // Вывод значений и типов переменных
            Console.WriteLine("Значение number: " + number + " (Тип: " + number.GetType() + ")");
            Console.WriteLine("Значение text: " + text + " (Тип: " + text.GetType() + ")");
            Console.WriteLine("Значение pi: " + pi + " (Тип: " + pi.GetType() + ")");
            Console.WriteLine("Значение isActive: " + isActive + " (Тип: " + isActive.GetType() + ")");

            // Работа с коллекциями и анонимными типами
            var person = new { Name = "Алексей", Age = 30 }; // Анонимный тип
            Console.WriteLine("Анонимный тип - Имя: " + person.Name + ", Возраст: " + person.Age);




            // Пример использования структуры titleAuthor
            titleAuthor[] ta = new titleAuthor[3];
            ta[0].au_id = "712-32-1176";
            ta[0].title_id = "PS3333";
            ta[0].au_ord = 1;
            ta[0].royaltyper = 100;

            ta[1].au_id = "213-46-8915";
            ta[1].title_id = "BU1032";
            ta[1].au_ord = null;
            ta[1].royaltyper = null;

            ta[2].au_id = "672-71-3249";
            ta[2].title_id = "TC7777";
            ta[2].au_ord = null;
            ta[2].royaltyper = 40;

            // Вывод значений структуры titleAuthor
            Display("Title Authors Table", ta);

            Console.WriteLine("Legend:");
            Console.WriteLine("An Author ORD of -1 means no value is defined.");
            Console.WriteLine("A Royalty % of 0 means no value is defined.");



            // Создание экземпляров классов cort и arrs
            cort ca= new cort();
            arrs aa = new arrs();
            other ooo = new other();
            strings strrr = new strings();

            // Вызов методов


            // strrr.str();
            //ca.corts();
             //aa.arr();
            ooo.oth();


            Console.WriteLine("\n");
            Console.ReadKey();
        }
        // Метод для отображения структуры titleAuthor
        public static void Display(string dspTitle, titleAuthor[] dspAllTitleAuthors)
        {
            Console.WriteLine("*** {0} ***", dspTitle);
            foreach (titleAuthor dspTA in dspAllTitleAuthors)
            {
                Console.WriteLine("Author ID ... {0}", dspTA.au_id);
                Console.WriteLine("Title ID .... {0}", dspTA.title_id);
                Console.WriteLine("Author ORD .. {0}", dspTA.au_ord ?? -1);
                Console.WriteLine("Royalty % ... {0}", dspTA.royaltyper ?? 0);
                Console.WriteLine();
            }
        }

    }
}
