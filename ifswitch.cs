/*1)Для введенного двузначного целого четного числа выведите соответствующий ему символ, для нечетного – символ,
 соответствующий сумме его цифр.
 2)По введенному целочисленному значению определите, является ли соответствующий ему символ строчной или 
 прописной буквой русского алфавита. Вывести число, букву и комментарий.
 3)Введите целое число. Если оно больше 255, вычислите корень квадратный из него, если меньше и соответствует
 символьным знакам кодовой таблицы, выведите символ и его код, и комментарий для любого случая.
 4)Определить какому алфавиту (латинскому или русскому) принадлежит введенный с клавиатуры символ.
 На экран вывести символ, его код и комментарий для любого случая.
 5)Введите символ. Если он не является буквой латинского алфавита, замените его на знак ‘?’, иначе если 
 прописная буква, то замените ее на строчную букву. Вывести введенный и преобразованный символы, комментарий.
 6)Введите целое число. Если оно является кодом русской буквы, выведите символ и код, иначе выведите число и комментарий.
 7)Введите 2 символа. Если символы – цифры, найдите и выведите их сумму и цифры, иначе выведите коды символов.
 8)Введите символ. Если символ – цифра, выведите ее значение, увеличенное на единицу, если буква латинского алфавита,
 выведите следующий за ней символ, иначе код введенного символа. Выведите соответствующий комментарий.
 9)Определите номер строки и столбца основной кодовой таблицы ASCII для введенного символа. Если символ не принадлежит
 указанной части таблицы, то вывести соответствующий комментарий.
 10)Введите символьное название времени суток (a – до полудня, p – после полудня) и время в часах и минутах.
 Выведите время в 24-часовом формате: ЧЧ.ММ.
 11)Ввести два символа, сравнить их коды. Для большего вывести следующий символ, для меньшего – предыдущий.
 Для неотображаемых символов выдать соответствующий комментарий.
 12)Для введенного символа вычислить его порядковый номер в английском алфавите. Вывести символ и его номер.
 Если символ не принадлежит этому алфавиту, выдать комментарий.
 13)Для двух введенных символов найти разность кодов и соответствующий этой разности символ. Если полученный символ
 отображаемый, вывести его и значение кода на экран, иначе соответствующий комментарий.
 14)Введите целое число. Если соответствующий символ является разделителем, выведите следующий символ, его код и 
 категорию, если буква, увеличьте значение числа в 10 раз и выведите число, символ, если он отображаемый и его категорию,
 и комментарий в противном случае.
 15)Для двух введенных символов определить являются они цифрами. Если да, то сформируйте из них целое число, иначе 
 найдите символ, соответствующий сумме их кодов.


 1)	Вводится два целых числа: одно типа ushort и другое типа int. Найдите сумму этих чисел, предварительно преобразовав
 тип ushort в int. Определите, является ли результат цифрой и какой: нулем, четной или нечетной
 2) Дано натуральное число N (< 20), определяющее сумму денег в рублях и целое k, определяющее начисленный процент 
 (например, 5%). Измените N c учетом начисленных процентов. Вывести N и для этого числа наименование: "рубль", "рубля", "рублей".
 3)	Дано натуральное число G, определяющее год рождения человека, и целое число – текущий год. Определите возраст человека в годах,
 описав его типом uint. Вывести для этого числа наименование: "год", "года", "лет". 
 4)	Вводится два числа: а типа ushort и b типа uint (b<=9). Переменной а присвоить остаток от деления а на b. Вывести название этого
 числа (0 – ноль, 1 – один, ..., 8 – восемь).
 5)	Вводится числа а типа ushort и b типа int. Уменьшить а на b. Если а лежит в диапазоне от 20 до 30, вывести название этого числа 
 (21 – двадцать один, 22 – двадцать два, ...), иначе выдать сообщение, что число вне диапазона.
 6)	Вводится натуральное число в диапазоне от 2 до 101 и целое в диапазоне от -100 до -1. Найти сумму этих чисел и написать эффективный
 алгоритм вывода абсолютного значения полученного числа и его название (1 – один, 2 – два, ..., 100 – сто). 
 7)	Вводится сумма в рублях (вещественное число < 1). Перевести его в копейки – целочисленный тип. Вывести полученное значение числа (1 – 99)
  дописав слово "копейка" в правильной форме (например, 12 копеек, 1 копейка). 
 8)	Вводятся с клавиатуры вещественное число X типа long, и Y типа float и символ К$. В зависимости от значения К$ (+, - , * , / 
  или % - остаток от целочисленного деления) вычислить и вывести результат (Х оп Y) и комментарий. 
 9) Вводятся два числа: одно типа int, второе типа double, которые соответствуют сторонам прямоугольника, либо высоте и основанию
  треугольника, либо диагоналям ромба. Найти остаток от деления второго числа на 3, и в зависимости от полученного значения произвести
  расчет площади одной из названных фигур. 
 10) Вводится числа а типа long и b типа int (|b|<10). Вывести название этого числа |b| (0 – ноль, 1 – один, 2 – два, ..., 9 – девять)
  и частное от деления а на b с тремя знаками после запятой. 
 11) Вводится числа а и с типа short и b типа int, являющиеся коэффициентами квадратного уравнения. В зависимости от знака
  дискриминанта вывести сообщение о наличии и количестве корней, и значения корней, если они есть.
 12) Определить для прописной буквы английского алфавита, является ли она гласной. Если буква гласная, определить букву алфавита,
  код которой на 1 больше кода для A, на 2 – для E  и т.д. Выведите введенный символ и его код, результат и комментарий.
 13) Вводятся символ и два целых числа. Если символ является знаком отношения, то выполнить соответствующее сравнение двух
 введенных чисел. Вывести сообщение, содержащее первое число, знак отношения, второе число и результат выполненного сравнения.
 14) Выполните перевод из сантиметров, заданных натуральным число в футы и дюймы (1 фут = 12 дюймов, 1 дюйм = 2.54 см) 
 и наоборот. При вводе величин укажите единицу измерения – ‘i’ для дюймов, ‘с’ для см, ‘f’ – для футов. 
 15) Водится с клавиатуры число S типа ushort и число X типа int, имеющие смысл числителя и знаменателя дроби. Вывести 
 результат деления S/X и выдать сообщение, является ли результат положительным, отрицательным или нулем.
 */
using System;
namespace ifswitch
{
    class Program
    {
        /*static void Main()
        {         
            int a;   
            Console.WriteLine("Введите двухзначное число");                             
            a = Convert.ToInt32(Console.ReadLine());
                                                   
                if ( a % 2 == 0)
                {                    
                    Console.Write(Convert.ToChar(a));
                }
                else if (a % 2 != 0)
                {                                 
                    Console.Write(Convert.ToChar(a % 10 + a / 10));
                }                                          
            Console.ReadKey();
        } */
        /*static void Main()
        {
            int b;
            Console.WriteLine("Введите целочисленное значение");
            b = Convert.ToInt32(Console.ReadLine());
            char a = Convert.ToChar(b);

            if (a >= 'а' && a <= 'я')
            {
                Console.WriteLine("Введеное целочисленное значение является строчной буквой русского алфавита: {0}\nЧисло {1}", a, b);
            }
            else if (a >= 'А' && a <= 'Я')
            {
                Console.WriteLine("Введеное целочисленное значение является прописной буквой русского алфавита: {0}\nЧисло {1}", a, b);
            }
            else
            {
                Console.WriteLine("Введеное целочисленное значение не является буквой русского алфавита.\nЧисло {0}", b);
            }
            Console.ReadKey();
        } */
        /* static void Main()
        {
            int a;
            Console.WriteLine("Введите целое число");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 255)
            {
                Console.WriteLine("Корень из числа равен {0}",Math.Sqrt(a));
            }
            else
                Console.WriteLine("Символ {0} \nКод {1}",Convert.ToChar(a),a);
            Console.ReadKey();
            } */
        /*static void Main()
        {
            Console.WriteLine("Введите символ");
            char a = Convert.ToChar(Console.Read());
            if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z' )
            {
                Console.WriteLine("Введеный символ принадлежит английскому алфaвиту {0} \nКод: {1}",a,Convert.ToInt32(a));
            }
            else if (a >= 'А' && a <= 'я')
            {
                Console.WriteLine("Введенный символ принадлежит русском алфавиту {0} \nКод: {1}",a, Convert.ToInt32(a));
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символ");
            char a = Convert.ToChar(Console.Read());
            if (a >= 'a' && a <= 'z')
            {
                Console.WriteLine("Введенный символ является строчной буквой латинского алфовита {0}",a);
            }
            else if (a >= 'A' && a <= 'Z')
            {
                Console.Write("Введенный символ является прописной буквой латинского алфовита.\nДелаем её строчной: {0}", char.ToLower(a));
            }
            else
                Console.Write('?');
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            char b = Convert.ToChar(a);
           
            if (b >= 'А' && b <= 'я')
            {
                Console.WriteLine("Число является кодом русской буквы {0} \nКод: {1}",b,a);
            }
            else
                Console.WriteLine("Число не является кодом русской буквы {0}",a);
            Console.ReadKey();           
        }*/
        /*static void Main()
        {
            char a, b;
            Console.WriteLine("Введите первый символ");
            a = Convert.ToChar( Console.ReadLine());
            Console.WriteLine("Введите второй символ");
            b = Convert.ToChar(Console.ReadLine());
            if (char.IsDigit(a) && char.IsDigit(b))
            {              
                Console.WriteLine("Введеные символы числа : {0}, {1}\nИх сумма равна {2}",b, a,a+b-96);                         
            }
            else
            {
                Console.WriteLine("Введденые символы являються символами их код : {0} , {1}", Convert.ToInt16(a), Convert.ToInt16(b));
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символ");
            char a = Convert.ToChar(Console.Read());
            if (char.IsDigit(a))
            {
                Console.WriteLine("Символ является числом. Значение увеличенное на единицу {0}", a+1-48);
            }
            else if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
            {
                Console.WriteLine("Символ является буквой латинского алфавита. Следующий за ним сивол {0}",(char)(a+1));
            }
            else
            {
                Console.WriteLine("Код символа {0}",(int)a);
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символ ");
            char a = Convert.ToChar(Console.Read());
            if ((int)a < 128)
            {
                int row = ((byte)a) >> 4;
                int col = ((byte)a) & 0x0F;
                Console.WriteLine("Строка={0:X}, Колонка={1:X}", row, col);
            }
            else
            {
                Console.WriteLine("Символ '{0}' не является ASCII символом", a);
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символьное название времени суток (латинскими) a – до полудня, p – после полудня ");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите время в часах");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите время в минутах");
            int c = Convert.ToInt16(Console.ReadLine());
            if (a == 'a')
            {
                Console.WriteLine("Время : {0}:{1}",b,c);
            }
            else if (a == 'p')
            {
                Console.WriteLine("Время : {0}:{1}", b + 12,c);
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символ");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите символ");
            char b = Convert.ToChar(Console.ReadLine());
            if (Convert.ToInt16(a) > Convert.ToInt16(b))
            {
                Console.WriteLine("Код символа 1 больше кода симвала 2. Следующий символ {0}",(char)(Convert.ToInt16(a) + 1) );
                Console.WriteLine("Код символа 2 меньше кода симвала 1. Предыдущий символ {0}", (char)(Convert.ToInt16(b) - 1));
            }
            else if (Convert.ToInt16(a) < Convert.ToInt16(b))
            {
                Console.WriteLine("Код символа 1 меньше кода симвала 2. Предыдущий символ {0}", (char)(Convert.ToInt16(a) - 1));
                Console.WriteLine("Код символа 2 больше кода симвала 1. Следующий символ {0}", (char)(Convert.ToInt16(b) + 1));
            }
                Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символ");
            char a = Convert.ToChar(Console.Read());
            if (a >= 'a' && a <= 'z')
            {
                Console.WriteLine("Порядковый номер в английском алфавите: {0}",a-96);
            }
            else if (a >= 'A' && a <= 'Z')
            {
                Console.WriteLine("Порядковый номер в английском алфавите: {0}", a - 64);
            }
            else
            {
                Console.WriteLine("Символ не принадлежит английскому алфавиту");
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символ");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите символ");
            char b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Разность кодов {0}", a - b);

            if ((a - b) >= -128 && (a - b) <= 127)
            {
                Console.WriteLine("Полученный символ отображаемый");
                Console.WriteLine((char)(a - b));
            }

            else { Console.WriteLine("Полученный символ не отображаемый"); }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите целое число");
            int b = Convert.ToInt16(Console.ReadLine());
            char a = Convert.ToChar(b);
            if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z' || a >= 'А' && a <= 'я')
            {
               
                Console.WriteLine("Введенно число соответствует коду буквы умноженного на 10 :{0} Символ {1}",b*10, a);
            }
            else if (a >= 33 && a <= 47 || a >= 58 && a <= 63)
            {
                Console.WriteLine("Символ является разделителем следующий символ за ним {0}", (char)(Convert.ToInt16(b) + 1));
            }
            else { Console.WriteLine("Введеное число не соответствует куоду буквы и символу разделителя"); }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите символ");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите символ");
            char b = Convert.ToChar(Console.ReadLine());
            if (char.IsDigit(a) && char.IsDigit(b))
            {               
                Console.WriteLine("Символы являются числами, формируем из них целое число {0}{1}",a,b);
            }
            else
            {
                Console.WriteLine("Символ соответствующий сумме кодов {0}",(char)(a+b));
            }
            Console.ReadKey();
        }*/
        /*****************************************************************************************************************************/
        /*****************************************************************************************************************************/
        /*****************************************************************************************************************************/
        /*****************************************************************************************************************************/
        /*static void Main()
        {
            Console.WriteLine("Введите целое число типа ushort ");
            ushort a = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число типа int");
            int b = int.Parse(Console.ReadLine());
            int c = Convert.ToInt16(a);                  
            switch (c + b)
            {
                case 0:
                    Console.WriteLine("Ноль");
                    break;
                default:
                    switch ((c + b) % 2)
                    {
                        case 0:
                            Console.WriteLine("Сумма четная");
                            break;
                        case 1:
                            Console.WriteLine("Сумма не четная");
                            break;
                    }
                    break;
            }                             
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите число N < 20");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент k");
            int b = int.Parse(Console.ReadLine());
            a = a + (a * b / 100);
            Console.WriteLine(a);
            switch (a % 100 >= 11 && a % 100 <= 14)
            {
                case true:
                    Console.WriteLine("рублей");
                    break;
                case false:
                    switch (a % 10 == 1)
                    {
                        case true:
                            Console.WriteLine("рубль");
                            break;
                        case false:
                            switch ((a % 10 >= 2) && (a % 10 <= 4))
                            {
                                case true:
                                    Console.WriteLine("рубля");
                                    break;
                                case false:
                                    Console.WriteLine("рублей");
                                    break;
                            }
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите год рождения");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите текущий год");
            int b = int.Parse(Console.ReadLine());
            uint d = (uint)(b - a);
            Console.WriteLine(d);
            switch (d % 100 >= 11 && d % 100 <= 14) {                                                   
                case true: 
                    Console.WriteLine("лет");
                break;
                case false: 
                    switch (d % 10 == 1)
                    {
                        case true: Console.WriteLine("год");
                            break;
                        case false:
                            switch ((d % 10 >= 2) && (d % 10 <= 4))
                            {
                                case true:
                                    Console.WriteLine("года");
                                    break;
                                case false: Console.WriteLine("лет");
                                    break;
                            }
                            break;
                    }
                    break;              
            }
            Console.ReadKey();
        
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите число типа ushort");
            ushort a = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Введите число типа uint <= 9");
            uint b = uint.Parse(Console.ReadLine());
            a = (ushort)(a % b);
            Console.WriteLine(a);
            switch (a)
            {
                case 0: Console.WriteLine("ноль");
                    break;
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите число ushort");
            ushort a = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Введите число int");
            int b = int.Parse(Console.ReadLine());
            a = (ushort)(a - b);
            switch(a > 20 && a < 30)
            {
                case true:
                    switch (a)
                    {
                        case 21: Console.WriteLine("двадцать один");
                            break;
                        case 22:
                            Console.WriteLine("двадцать два");
                            break;
                        case 23:
                            Console.WriteLine("двадцать три");
                            break;
                        case 24:
                            Console.WriteLine("двадцать четыре");
                            break;
                        case 25:
                            Console.WriteLine("двадцать пять");
                            break;
                        case 26:
                            Console.WriteLine("двадцать шесть");
                            break;
                        case 27:
                            Console.WriteLine("двадцать семь");
                            break;
                        case 28:
                            Console.WriteLine("двадцать восемь");
                            break;
                        case 29:
                            Console.WriteLine("двадцать девять");
                            break;
                    }
                    break;
                case false: Console.WriteLine("Число не лежит в диапазоне от 20 до 30");
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {         
           //Обьявляем массивы разрядов
            string[] a = new string[3];
            //Наполним значениями до десятка
            a[0] = "один два три четыре пять шесть семь восемь девять";
            //До соток
            a[1] = "десять двадцать тридцать сорок пятьдесят шестьдесят семьдесят восемьдесят девяносто";
            //До тысяч
            a[2] = "сто двести триста четыреста пятьсот шестьсот семьсот восемьсот девятьсот";
            //дальце фтопку. Лень короче
            // Это наше число, которое нужно прописью вывести
            Console.WriteLine("Введите натуральное число в диапазоне от 2 до 101");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число в диапазоне от -100 до -1");
            int b = int.Parse(Console.ReadLine());
            int  n = Math.Abs(d + b);           
            // А это результирующая строка
            string s = "";
            // Если это число попадает в первый десяток то нужно просто 
            //к его имени присоединить окончание НАДЦАТЬ
            if (n > 10 && n < 20)
            {
                // Делим строку, которая вмещает прописи значений до десятка
                //получаем массив (делим по пробелу - это официальный разделитель будет)
                //после вычисляем порядковый номер цифры - она будет указывать на ее имя в массиве
                //прописей, и допишем к ней окончание
                s = a[0].Split(' ')[n % 10 - 1] + "надцать";
            }
            // Если же число больше то:
            else
            {
                //Придется в цикле его препарировать. Каждая препарация выдаст порядковый номер очередного
                //числа, которое является индексом, указывающим на элемент массива имен разрядов а[]
                for (int i = 0, k = 0; n > 0; n /= 10, i++)
                {
                    // получили число
                    k = n % 10;
                    //Если оно не 0 - т.е. это не десяток то возьмем очередной массив имен разрядов
                    //и получим его элемент, указываемый порядковым номером полученной нами цифры
                    //доплюсуем к строке не забыв пробел
                    if (k != 0) s = a[i].Split(' ')[k - 1] + ' ' + s;
                }
            }
            Console.Write(s);
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите сумму в рублях (вещественное число < 1)");
            double a = double.Parse(Console.ReadLine());
            int d = (int)(a * 100);
            Console.WriteLine(d);
            switch (d % 100 >= 11 && d % 100 <= 14)
            {
                case true:
                    Console.WriteLine("копеек");
                    break;
                case false:
                    switch (d % 10 == 1)
                    {
                        case true:
                            Console.WriteLine("копейка");
                            break;
                        case false:
                            switch ((d % 10 >= 2) && (d % 10 <= 4))
                            {
                                case true:
                                    Console.WriteLine("копейки");
                                    break;
                                case false:
                                    Console.WriteLine("копеек");
                                    break;
                            }
                            break;
                    }
                    break;
            }
                    Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите вещественное число X типа long");
            long X = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Y типа float");
            float Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ +, - , * , /  или % ");
            char K = char.Parse(Console.ReadLine());
            switch (K)
            {
                case '+':
                    Console.WriteLine("Сложение равно : {0}", X+Y);
                    break;
                case '-':
                    Console.WriteLine("Вычитание равно : {0}", X-Y);
                    break;
                case '*':
                    Console.WriteLine("Умножение равно : {0}", X * Y);
                    break;
                case '/':
                    Console.WriteLine("Деление равно : {0}", X / Y);
                    break;
                case '%':
                    Console.WriteLine("Остаток от деления равен : {0}", X % Y);
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите число типа int ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число типа double ");
            double b = double.Parse(Console.ReadLine());
            int c = (int)(b % 3);
            double s = 0;
            Console.WriteLine(c);
            switch(c)
            {
                case 0:
                           s = (a * b);
                    break;
                case 1:
                           s = (a * b /2);
                    break;
                case 2:
                           s = (a * b /2);
                    break;
            }
            Console.WriteLine("Площадь равна {0}",s);
            Console.ReadKey();
        }*/
        /*static void Main()
        {            
            Console.WriteLine("Введите число а типа long ");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b типа int (| b |< 10)");
            int b = int.Parse(Console.ReadLine());
            double c = a / (double)b;
            Console.WriteLine("Частное от деления с тремя знаками после запятой {0:#.###}",c);
            switch (b)
            {
                case 0:
                    Console.WriteLine("ноль");
                    break;
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
                case 9:
                    Console.WriteLine("девять");
                    break;
            }
            Console.ReadKey();              
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите a типа short ");
            short a = short.Parse(Console.ReadLine());
            Console.WriteLine("Введите c типа short ");
            short c = short.Parse(Console.ReadLine());
            Console.WriteLine("Введите b типа int ");
            int b = int.Parse(Console.ReadLine());
            int d = b * b - 4 * a * c;
            Console.WriteLine(d);
            switch (d > 0)
            {
                case true:
                    Console.WriteLine("Уравнение имеет два вещественных корня.\nКорень1: {0} Корень2: {1} ", ((-b + Math.Sqrt(d))/2*a), ((-b - Math.Sqrt(d)) / 2 * a));
                    break;
                case false:
                    switch (d == 0)
                    {
                        case true: Console.WriteLine("Уравнение иммеет 1 корень.\nКорень : {0}",-b/2*a);
                            break;
                        case false: Console.WriteLine("Вещественных корней нет");
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите прописную букву английского алфавита");
            char a = char.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели букву : {0}\nКод :{1}",a,(int)a);
            switch (a)
            {
                case 'A':
                    Console.WriteLine("Буква алфавита код которой больше на 1 : {0}" ,(char)(a + 1) );
                    break;
                case 'E':
                    Console.WriteLine("Буква алфавита код которой больше на 2 : {0}", (char)(a + 2));
                    break;
                case 'I':
                    Console.WriteLine("Буква алфавита код которой больше на 3 : {0}", (char)(a + 3));
                    break;
                case 'O':
                    Console.WriteLine("Буква алфавита код которой больше на 4 : {0}", (char)(a + 4));
                    break;
                case 'U':
                    Console.WriteLine("Буква алфавита код которой больше на 5 : {0}", (char)(a + 5));
                    break;
                case 'Y':
                    Console.WriteLine("Символ код которого больше на 6 : {0}", (char)(a + 6));
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите целое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак отношения");
            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '>':
                    if (a > b) { Console.WriteLine("{0} > {1} Первое число больше второго",a,b); }
                    else { Console.WriteLine("{0} < {1} Второе число больше первого", a, b); }                  
                    break;
                case '<':
                    if (a < b) { Console.WriteLine("{0} < {1} Первое число меньше второго", a, b); }
                    else { Console.WriteLine("{0} > {1} Второе число меньше первого", a, b); }
                    break;
                case '=':
                    if (a == b) { Console.WriteLine("{0} = {1} Числа равны", a, b); }
                    else { Console.WriteLine("{0} = {1} Числа не равны", a, b); }
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите единицу измерения ‘i’ для дюймов, ‘с’ для см, ‘f’ – для футов");
            char b = char.Parse(Console.ReadLine());
            switch (b)
            {
                case 'i':
                    Console.WriteLine("Вы ввели величину в дюймах.\nЭта величина в см: {0} и футах {1}", a*2.54, (double)a/12);
                    break;
                case 'c':
                    Console.WriteLine("Вы ввели величину в см.\nЭта величина в дюймах: {0} и футах {1}", a / 2.54, a / 2.54 / 12);
                    break;
                case 'f':
                    Console.WriteLine("Вы ввели величину в футах.\nЭта величина в дюймах: {0} и см {1}", a * 12, a * 12 * 2.54);
                    break;
            }
            Console.ReadKey();
        }*/
        /*static void Main()
        {
            Console.WriteLine("Введите число S типа ushort");
            ushort S = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Введите число X типа int");
            int X = int.Parse(Console.ReadLine());
            double c = (double) S / X;
            Console.WriteLine(c);
            switch(c > 0)
            {
                case true:
                    Console.WriteLine("Результат положительный");
                    break;
                case false:
                    switch (c < 0)
                    { case true: Console.WriteLine("Результат отрицательный");
                            break;
                        case false: Console.WriteLine("Результат равен нулю");
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }*/
    }   
}

