//задание 1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
Console.WriteLine("задание 1");
Console.WriteLine(Math.Round(Math.E, 1));
Console.WriteLine("");
//задание 2. Вывести на экран числа 50 и 10 одно под другим.
Console.WriteLine("задание 2");
Console.WriteLine(50);
Console.WriteLine(10);
Console.WriteLine("");
//задание 3. Составить программу вывода на экран «столбиком» четырех любых чисел.
Console.WriteLine("задание 3");
Console.WriteLine(8);
Console.WriteLine(6);
Console.WriteLine(4);
Console.WriteLine(2);
Console.WriteLine("");
//задание 4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
Console.WriteLine("задание 4");
Console.WriteLine("Введите число");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x1+10);
Console.WriteLine("");
//задание 5. Дана сторона квадрата. Найти его периметр.
Console.WriteLine("задание 5");
int x2 = 2;
Console.WriteLine(x2*4);
Console.WriteLine("");
//задание 6. Дан радиус окружности. Найти длину окружности и площадь круга.
Console.WriteLine("задание 6");
int x3 = 2;
Console.WriteLine("Длина окружности: "+2*x3*Math.PI);
Console.WriteLine("Площадь круга:"+x3*x3*Math.PI);
Console.WriteLine("");
//задание 7. Найти значение y=cos(x)
Console.WriteLine("задание 7");
Console.WriteLine(Math.Cos(Math.PI));
Console.WriteLine("");
//задание 8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
Console.WriteLine("задание 8");
int verh = 2;
int niz = 8;
int vys = 4;
int chast = (niz-verh)/2;
double bok = Math.Sqrt(Math.Pow(vys, 2)+Math.Pow(chast,2));
Console.WriteLine("Периметр: " + (verh+niz+bok*2));
Console.WriteLine("");
//задание 9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
// если купили x кг конфет, у кг печенья и z кг яблок.
Console.WriteLine("задание 9");
int applePrice = 52, cookiePrice = 78, sweetPrice = 90;
double appleAmount = 2, cookieAmount = 0.2, sweetAmount = 0.3;
Console.WriteLine(applePrice*appleAmount+cookiePrice*cookieAmount+sweetPrice*sweetAmount);
Console.WriteLine("");
//задание 10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
// (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
// Мир Труд Май
// Затем так:
// Мир
//      Труд
//              Май
Console.WriteLine("задание 10");
Console.WriteLine("Мир Труд Май");
Console.WriteLine("Мир");
Console.WriteLine("\tТруд");
Console.WriteLine("\t\tМай");
Console.WriteLine("");
//задание 11. Программа просит пользователя ввести 2 числовые переменные. А после она
// меняет их местами и выводит результат на экран. Но, так как пользователь может
// ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
// например, букву или строку, а так же учесть, что число может быть дробным, и для
// выделения её дробной части одни используют точку, другие – запятую.
Console.WriteLine("задание 11");
Console.WriteLine("Введите первое число");
if (!double.TryParse(Console.ReadLine().Replace(".", ","), out double firstNumber))
    Console.WriteLine("Ошибка ввода");
else {
    Console.WriteLine("Введите второе число");
    if (!double.TryParse(Console.ReadLine().Replace(".", ","), out double secondNumber))
        Console.WriteLine("Ошибка ввода");
    else
        Console.WriteLine(secondNumber + " " + firstNumber);
}
Console.WriteLine("");
//задание 12. Программа для подсчета периметра и площади фигур (треугольник,
// четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
// будет считать – площадь или периметр. Задаётся все необходимые значения, а на
// основе полученных результатов, программа должна подсчитать, какими могли бы
// быть периметры или площади остальных фигур.
Console.WriteLine("задание 12");
Console.WriteLine("Выберите фигуру: треугольник, четырехугольник, круг");
string figure = Console.ReadLine();
switch (figure)
{
    case "треугольник":
        Console.WriteLine("Выберите, что Вы хотите найти: площадь, периметр");
        string sol1 = Console.ReadLine();
        switch (sol1)
        {
            case "площадь":
                Console.WriteLine("Введите длину основания");
                int osn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину высоты");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((osn * h) / 2);
                break;
            case "периметр":
                Console.WriteLine("Введите первую сторону");
                int s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону");
                int s2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третью сторону");
                int s3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s1+s2+s3);
                break;
        }
        break;
    case "четырехугольник":
        Console.WriteLine("Выберите, что Вы хотите найти: площадь, периметр");
        string sol2 = Console.ReadLine();
        switch (sol2)
        {
            case "площадь":
                Console.WriteLine("Введите длину основания");
                int osn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину высоты");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(osn * h);
                break;
            case "периметр":
                Console.WriteLine("Введите первую сторону");
                int s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону");
                int s2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((s1 + s2)*2);
                break;
        }
        break;
    case "круг":
        Console.WriteLine("Выберите, что Вы хотите найти: площадь, периметр");
        string sol3 = Console.ReadLine();
        switch (sol3)
        {
            case "площадь":
                Console.WriteLine("Введите радиус");
                int rad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(rad*rad*Math.PI);
                break;
            case "периметр":
                Console.WriteLine("Введите радиус");
                int rad1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(2*rad1*Math.PI);
                break;
        }
        break;
}
Console.WriteLine("");
//задание 13. Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
// числу должно предшествовать сообщение «Вы ввели число».
Console.WriteLine("задание 13");
Console.WriteLine("Введите число");
int x12 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число: {x12}");
Console.WriteLine("");
//заданиe 14. Составить программу вывода на экран следующей информации:
// 2 кг
// 13 17
Console.WriteLine("заданиe 14");
Console.WriteLine("2 кг");
Console.WriteLine("13 17");
Console.WriteLine("");
//задание 15. Составить программу вывода на экран «столбиком» четырех случайных чисел.
Console.WriteLine("заданиe 15");
Random rand = new Random();
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(rand.Next(101));
}
Console.WriteLine("");
//задание 16. Найти корни квадратного уравнения(коэффициента задаются пользователем с
// клавиатуры)
Console.WriteLine("задание 16");
Console.WriteLine("Введите старший коэффициент:");
double starsh = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второй коэффициент:");
double vtoroi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент:");
double svobodn = Convert.ToDouble(Console.ReadLine());
double d = Math.Pow(vtoroi, 2) - 4 * starsh * svobodn;
if (d > 0)
{
    double kor1 = (-vtoroi + Math.Sqrt(d))/2*starsh;
    double kor2 = (-vtoroi - Math.Sqrt(d))/2*starsh;
    Console.WriteLine(kor1 + " " + kor2);
}
else if (d == 0)
{
    double kor3 = (-vtoroi + Math.Sqrt(d))/2*starsh;
    Console.WriteLine(kor3);
}
else
{
    Console.WriteLine("Действительных корней нет");
}
Console.WriteLine("");
//задание 17. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
// геометрическое.
Console.WriteLine("заданиe 17");
int frst = 2;
int scnd = 4;
Console.WriteLine((frst + scnd)/2);
Console.WriteLine(Math.Sqrt(frst*scnd));
Console.WriteLine("");
//задание 18. Известны координаты на плоскости двух точек. Составить программу вычисления
// расстояния между ними.
Console.WriteLine("заданиe 18");
int x20 = 1;
int y20 = 5;
int x21 = 4;
int y21 = 2;
Console.WriteLine(Math.Sqrt(Math.Pow((x21 - x20), 2) + Math.Pow((y21 - y20),2)));
Console.WriteLine("");
//задание 19. Составить программу обмена значениями трех переменных величин а, b, c по
// следующим двум схемам:
// а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
// б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
Console.WriteLine("заданиe 19");
int a1 = 1, b1 = 2, c1 = 3;
Console.WriteLine($"Старое значение: a1 = {a1}, b1 = {b1}, c1 = {c1} ");
int flag1 = a1, flag2 = b1, flag3 = c1;
b1 = flag3; a1 = flag2; c1 = flag1;
Console.WriteLine($"Новое значение: a1 = {a1}, b1 = {b1}, c1 = {c1} ");
b1 = flag1; c1 = flag2; a1 = flag3;
Console.WriteLine($"Новое значение: a1 = {a1}, b1 = {b1}, c1 = {c1} ");
Console.WriteLine("");
//задание 20. С начала суток прошло n секунд. Определить:
// а) сколько полных часов прошло с начала суток;
// б) сколько полных минут прошло с начала очередного часа;
// в) сколько полных секунд прошло с начала очередной минуты.
Console.WriteLine("заданиe 20");
Console.WriteLine("Сколько прошло секунд с начала суток?");
int vremya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Полных часов прошло с начала суток:"+(vremya/3600));
Console.WriteLine("Полных минут прошло с начала очередного часа:"+(vremya % 3600)/60);
Console.WriteLine("Полных секунд прошло с начала очередной минуты"+(vremya % 60));
Console.WriteLine("");
//задание 21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
// мм можно отрезать от него?
Console.WriteLine("заданиe 21");
int stor1 = 543, stor2 = 130, storkvadrat = 130;
Console.WriteLine((543/130)*(130/130));
Console.WriteLine("");
//задание 22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
// ее в начале. Найти полученное число.
Console.WriteLine("заданиe 22");
int trehznach = 456;
int posl = trehznach % 10;
int perv = trehznach / 10;
int newDigit = posl * 100 + perv;
Console.WriteLine(newDigit);
Console.WriteLine("");
//задание 23. Дано натуральное число n (n > 999). Найти:
// а) число сотен в нем;
// б) число тысяч в нем.
Console.WriteLine("заданиe 23");
int ch1 = 1234;
Console.WriteLine("Число сотен в нём:"+((ch1/100)%10));
Console.WriteLine("Число тысяч в нём:"+((ch1/1000)%10));
Console.WriteLine("");
//задание 24. Дано четырехзначное число. Найти:
// а) число, полученное при прочтении его цифр справа налево;
// б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
// заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
// в) число, образуемое при перестановке второй и третьей цифр заданного числа.
// Например, из числа 5084 получить 5804;
// г) число, образуемое при перестановке двух первых и двух последних цифр
// заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.
Console.WriteLine("заданиe 24");
int ch2 = 1234;
int chnew = 0;
while (ch2 > 0)
{
    int posl2 = ch2 % 10;      
    chnew = chnew * 10 + posl2; 
    ch2 /= 10;                      
}
Console.WriteLine("а)"+chnew);
int ch3 = 1234;
int firstG = ch3 / 1000;
int secondG = (ch3 / 100) % 10;
int thirdG = (ch3 / 10) % 10;
int fourthG = ch3 % 10;
int newG1 = secondG*1000 + firstG*100 + fourthG*10 + thirdG;
int newG2 = firstG*1000 + thirdG*100 + secondG*10 + fourthG;
int newG3 = thirdG*1000 + fourthG*100 + firstG*10 + secondG;
Console.WriteLine("б)" + newG1);
Console.WriteLine("в)" + newG2);
Console.WriteLine("г)" + newG3);
Console.WriteLine("");
//задание 25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
// на 10, а к частному слева приписали последнюю цифру числа x, то получилось
// число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
// число десятков в n не равно нулю.
Console.WriteLine("задание 25");
Console.WriteLine("Введите трехзначное число, в котором число десятков не равно нулю");
int bb = Convert.ToInt32(Console.ReadLine());
int lastdigit = bb / 100;
bb = (bb - lastdigit*100)*10+lastdigit;
Console.WriteLine(bb);
Console.WriteLine("");
//задание 26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
// времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
// положением часовой стрелки в начале суток и в указанный момент времени.
Console.WriteLine("задание 26");
int h1 = 15, m1 = 30, sec1 = 30;
h1 %= 12;
sec1 += h1 * 60 * 60 + m1 * 60;
double degrees = ((double)sec1 / 60 / 60 / 12)*360;
Console.WriteLine(degrees+"\u00b0");
Console.WriteLine("");
//задание 27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
// соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для
// минутной стрелки, а также количество полных часов и полных минут.
Console.WriteLine("задание 27");
double radians = 1.25 * Math.PI;
double degree = radians * 180 / Math.PI;
int scnds = (int)(degree / 360 * 60 * 60 * 12);
int chasi = scnds / 60 / 60;
int mnts = scnds / 60 - chasi * 60;
double dgr = ((double)mnts / 60 + (double)scnds % 60 / 60 / 60)*360;
Console.WriteLine($"{dgr} {chasi} {mnts}");
Console.WriteLine("");
//задание 28. Создать программу, которая будет выводить на экран меньшее по модулю из трёх
// введённых пользователем вещественных чисел
Console.WriteLine("задание 28");
Console.WriteLine("Введите первое число");
double mdl1 = Math.Abs(double.Parse(Console.ReadLine()));
Console.WriteLine("Введите второе число");
double mdl2 = Math.Abs(double.Parse(Console.ReadLine()));
Console.WriteLine("Введите третье число");
double mdl3 = Math.Abs(double.Parse(Console.ReadLine()));
double minn = Math.Min(Math.Min(mdl1, mdl2), mdl3);
Console.WriteLine(minn);
Console.WriteLine("");
//задание 29. Найти сумму большего и меньшего из трёх заданных чисел
Console.WriteLine("задание 29");
int num1 = -123;
int num2 = 56;
int num3 = 7890;
double minn1 = Math.Min(Math.Min(num1, num2), num3);
double maxx1 = Math.Max(Math.Max(num1, num2), num3);
Console.WriteLine(maxx1+minn1);
Console.WriteLine("");
//задание 30. Подсчитать общее количество делителей натурального числа
Console.WriteLine("задание 30");
int natural = 16;
int count = 2;
for (int i = 2; i <= Math.Sqrt(natural); i++)
{
    if (natural % i == 0)
    {
        count++;
        if (i != natural / i)
        {
            count++;
        }
    }
}
Console.WriteLine(count);
Console.WriteLine("");
//задание 31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
// вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
// уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе
// задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
// забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
// корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
// есть шанс найти их методом перебора, но для этого ему придется затратить уйму
// времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
// значений. Помогите Васе написать программу, которая поможет ему найти корни
// кубических уравнений!
Console.WriteLine("задание 31");
int aa = 1, bbb = -6, cc = 11, dd = -6; 
for (int i = -100; i <= 100; i++)
{
    if (aa * i * i * i + bbb * i * i + cc * i + dd == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("");
//задание 32. Заданы первый и второй элементы арифметической прогрессии. Требуется
// написать программу, которая вычислит элемент прогрессии по ее номеру.
Console.WriteLine("задание 32");
int frs1 = 1, frs2 = 6;
int bro = Convert.ToInt32(Console.ReadLine());
int difference = frs2 - frs1;
Console.WriteLine(frs1+(bro-1)*difference);
Console.WriteLine("");
//задание 33. Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
// трудоустроен не получаю кредит. Ну а если я, и пенсионер и
// студент,(трудоустройство тут не имеет значения) то не должен получить.
// Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
// или кто-то ещё. Вывести информацию: дадут кредит или нет.
Console.WriteLine("задание 33");
bool pensi = true, student = true, trud = true;
if (((pensi || student) && !trud) || (pensi && student))
{
    Console.WriteLine("Дадут кредит");
}
else
{
    Console.WriteLine("Не дадут");
}
Console.WriteLine("");
//задание 34. Составить программу, которая:
// а) запрашивает имя человека и повторяет его на экране;
// б) запрашивает имя человека и повторяет его на экране с приветствием.
Console.WriteLine("задание 34");
Console.WriteLine("Как вас зовут?");
string user = Console.ReadLine();
Console.WriteLine(user);
Console.WriteLine("Здравствуйте, "+user);
Console.WriteLine("");
//задание 35. Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
// консолью. Консоль спрашивает, как зовут пользователя. Пользователь называет
// имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь
// спрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да».
// После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
// «Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
// цвет на любой случайный цвет.
Console.WriteLine("задание 35");
Console.ReadLine();
Console.WriteLine("Как вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Привет, "+name); 
Console.ReadLine();
Console.WriteLine("Да"); 
Console.ReadLine();
Console.WriteLine("Нет"); 
Thread.Sleep(5000);
Console.WriteLine("Но могу показать");
Random rnd = new Random(); 
Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
Console.WriteLine("");
//задание 36. Вычислить контрольную цифру штрихкода(EAN13).
// a. 12 цифр определяются случайным образом.
// b. 12 цифр вводит пользователь
Console.WriteLine("задание 36");
Console.WriteLine("Выберите опцию:");
Console.WriteLine("1 - Случайные 12 цифр для EAN-13");
Console.WriteLine("2 - Ввести свои 12 цифр");
string choice = Console.ReadLine();
string ean12="";
if (choice == "1")
{
    for (int i = 0; i < 12; i++)
    {
        ean12 += rnd.Next(0, 10).ToString();
    }
    Console.WriteLine(ean12);
}
else if (choice == "2")
{
    Console.Write("Введите 12 цифр:");
    ean12 = Console.ReadLine();
}

int totalsum = 0;
for (int i = 0; i < 12; i++)
{
    int digit10 = Convert.ToInt32(ean12[i].ToString());
    if ((i + 1) % 2 == 0)
    {
        totalsum += digit10 * 3;
    }
    else
    {
        totalsum += digit10;
    }
}


int rez = (10 - (totalsum % 10))%10;
Console.WriteLine(rez);





















