using RandomString4Net;
using System;
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        //люблю Оленку #настя
        //рома гандон #настя
        Console.OutputEncoding = Encoding.UTF8;

        var dbService = new DatabaseService(@"C:\Users\roman.seliverstov\Downloads\BudgetBaeDB(оленка).db");
        Random random = new Random();
        // Масив імен
        string[] names = {
    "Марина", "Олександр", "Катерина", "Дмитро", "Анастасiя",
    "Iван", "Ольга", "Сергiй", "Валентина", "Руслан",
    "Тетяна", "Светлана", "Вiктор", "Аліна", "Єгор",
    "Наталiя", "Станіслав", "Ксенія", "Олег", "Свiтлана",
    "Юлiя", "Михайло", "Роман", "Дарина", "Леонiд",
    "Артем", "Тимур", "Iрина", "Наталя", "Данило",
    "Полiна", "Ярослав", "Вадим", "Злата", "Олена"
};

        // Масив прізвищ
        string[] surnames = {
    "Шевченко", "Коваленко", "Таран", "Бондаренко", "Гриценко",
    "Іваненко", "Сидоренко", "Мельник", "Лисенко", "Кравченко",
    "Козак", "Кузьменко", "Семенко", "Руденко", "Петренко",
    "Ковалев", "Тимошенко", "Савченко", "Лебедєв", "Чорненький",
    "Нечитайло", "Степаненко", "Гусєв", "Пономаренко", "Зінченко",
    "Буряк", "Гончар", "Ломов", "Федоренко", "Кочерга"
};

        //for (int i = 0; i < 37; i++)
        //{
        //    string name = $"{names[random.Next(names.Length)]} {surnames[random.Next(surnames.Length)]}";
        //    string email = $"user{i}@gmail.com";
        //    string password = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE_WITH_SYMBOLS, random.Next(8, 15));

        //    dbService.InsertUsersData(name, email, password);
        //}

        //////Таблиця Категорії Витрат
        //dbService.InsertExpensesCategoriesData("Продукти");
        //dbService.InsertExpensesCategoriesData("Комунальні послуги");
        //dbService.InsertExpensesCategoriesData("Оренда/Іпотека");
        //dbService.InsertExpensesCategoriesData("Транспорт");
        //dbService.InsertExpensesCategoriesData("Одяг");
        //dbService.InsertExpensesCategoriesData("Ресторани");
        //dbService.InsertExpensesCategoriesData("Медицина");
        //dbService.InsertExpensesCategoriesData("Косметика");
        //dbService.InsertExpensesCategoriesData("Електроніка");
        //dbService.InsertExpensesCategoriesData("Подарунки");
        //dbService.InsertExpensesCategoriesData("Подорожі");
        //dbService.InsertExpensesCategoriesData("Освіта");
        //dbService.InsertExpensesCategoriesData("Спортзал/Фітнес");
        //dbService.InsertExpensesCategoriesData("Розваги");
        //dbService.InsertExpensesCategoriesData("Інтернет");
        //dbService.InsertExpensesCategoriesData("Телефон");
        //dbService.InsertExpensesCategoriesData("Благодійність");
        //dbService.InsertExpensesCategoriesData("котики", 18);
        //dbService.InsertExpensesCategoriesData("Бензин");
        //dbService.InsertExpensesCategoriesData("Домашні тварини");
        //dbService.InsertExpensesCategoriesData("Вода");
        //dbService.InsertExpensesCategoriesData("екскурсії", 6);
        //dbService.InsertExpensesCategoriesData("Електроенергія");
        //dbService.InsertExpensesCategoriesData("кросворди", 10);
        //dbService.InsertExpensesCategoriesData("Страхування");
        //dbService.InsertExpensesCategoriesData("Абонементи");
        //dbService.InsertExpensesCategoriesData("Дитячі витрати");
        //dbService.InsertExpensesCategoriesData("Книги/Журнали");
        //dbService.InsertExpensesCategoriesData("Фільми/Кіно");
        //dbService.InsertExpensesCategoriesData("Курси/Тренінги");
        //dbService.InsertExpensesCategoriesData("Декор/Інтер'єр");
        //dbService.InsertExpensesCategoriesData("Послуги салонів краси");
        //dbService.InsertExpensesCategoriesData("Парковка");
        //dbService.InsertExpensesCategoriesData("Обладнання для дому", 11);
        //dbService.InsertExpensesCategoriesData("кава з корицею", 16);
        //dbService.InsertExpensesCategoriesData("Підписка епл", 5);
        //dbService.InsertExpensesCategoriesData("Квіти", 10);
        //dbService.InsertExpensesCategoriesData("Ремонт", 4);
        //dbService.InsertExpensesCategoriesData("Кокальока", 19);
        //dbService.InsertExpensesCategoriesData("Сільпо", 1);
        //dbService.InsertExpensesCategoriesData("LovaLova", 22);
        //dbService.InsertExpensesCategoriesData("McDonalds", 4);


        ////Таблиця Рахунків
        //dbService.InsertAccountsData("карта", "Основна картка", 15000.00, 1, "1234567812345678");
        //dbService.InsertAccountsData("готівка", "Гаманець", 2500.50, 2, null);
        //dbService.InsertAccountsData("карта", "Картка для подорожей", 3000.00, 3, "9876543212345678");
        //dbService.InsertAccountsData("карта", "Зарплатна картка", 50000.75, 4, "1111222233334444");
        //dbService.InsertAccountsData("карта", "Резервна картка", 12000.00, 5, "5555666677778888");
        //dbService.InsertAccountsData("готівка", "Кошти для подорожей", 7000.00, 6, null);
        //dbService.InsertAccountsData("карта", "Картка для покупок онлайн", 1500.00, 7, "9999888877776666");
        //dbService.InsertAccountsData("карта", "Кредитна картка", 10000.00, 8, "2222333344445555");
        //dbService.InsertAccountsData("готівка", "Заначка", 2000.00, 9, null);
        //dbService.InsertAccountsData("карта", "Картка для подарунків", 500.00, 10, "3333444455556666");
        //dbService.InsertAccountsData("карта", "Дебетова картка", 25000.00, 11, "4444555566667777");
        //dbService.InsertAccountsData("карта", "Пенсійна картка", 8000.00, 12, "6666777788889999");
        //dbService.InsertAccountsData("карта", "Бонусна картка", 300.00, 13, "8888999911112222");
        //dbService.InsertAccountsData("карта", "Картка для комунальних платежів", 2000.50, 14, "7777888899990000");
        //dbService.InsertAccountsData("карта", "Запасна картка", 1500.75, 15, "1010101010101010");
        //dbService.InsertAccountsData("готівка", "Кошти для подорожей", 900.00, 16, null);
        //dbService.InsertAccountsData("карта", "Зарплатна картка", 23000.25, 17, "1234432156784321");
        //dbService.InsertAccountsData("карта", "Ощадна картка", 40000.00, 18, "1122334455667788");
        //dbService.InsertAccountsData("карта", "Картка для відпустки", 5000.00, 19, "9988776055443322");
        //dbService.InsertAccountsData("карта", "Картка для бізнесу", 150000.00, 20, "1223344556677889");
        //dbService.InsertAccountsData("готівка", "Гаманець на кожен день", 450.00, 21, null);
        //dbService.InsertAccountsData("карта", "Картка для хобі", 7500.00, 22, "1234567812348765");
        //dbService.InsertAccountsData("карта", "Основна дебетова картка", 24000.50, 23, "3456789034567890");
        //dbService.InsertAccountsData("карта", "Подарункова картка", 1000.00, 24, "1111000099998888");
        //dbService.InsertAccountsData("карта", "Картка для медичних витрат", 12000.00, 25, "5432167890123456");
        //dbService.InsertAccountsData("карта", "Карточка резерв", 9000.00, 26, "6666555544443333");
        //dbService.InsertAccountsData("карта", "Картка для благодійності", 3000.50, 27, "7777111199993333");
        //dbService.InsertAccountsData("карта", "Картка сім'ї", 500.00, 28, "8888222277775555");
        //dbService.InsertAccountsData("карта", "Картка для навчання", 7000.00, 29, "9999333344441111");
        //dbService.InsertAccountsData("карта", "Картка на відпустку", 10000.00, 30, "1212121212121212");
        //dbService.InsertAccountsData("готівка", "Ощадний фонд", 3000.00, 31, null);
        //dbService.InsertAccountsData("карта", "Картка для покупок", 1500.75, 32, "2323232323232323");
        //dbService.InsertAccountsData("карта", "Друга дебетова картка", 45000.00, 33, "9876789876789876");
        //dbService.InsertAccountsData("карта", "Картка на покупку авто", 600000.00, 34, "4567456745674567");
        //dbService.InsertAccountsData("карта", "Картка для резерву", 9000.50, 35, "7654321076543210");
        //dbService.InsertAccountsData("карта", "Зарплатна картка дружини", 40000.00, 36, "5432109876543210");
        //dbService.InsertAccountsData("карта", "Картка для подорожі за кордон", 25000.75, 37, "6543210987654321");
        //dbService.InsertAccountsData("карта", "Картка для ремонтів", 75000.00, 38, "9876543210987654");
        //dbService.InsertAccountsData("карта", "Картка для дитячих витрат", 5000.50, 39, "8765432109876543");
        //dbService.InsertAccountsData("карта", "Картка для оновлення техніки", 30000.00, 40, "7654321098765432");
        //dbService.InsertAccountsData("карта", "Карточка резерв #2", 15000.00, 41, "5432198765432109");
        //dbService.InsertAccountsData("карта", "Картка для рідних", 8000.00, 42, "1111333355557777");
        //dbService.InsertAccountsData("карта", "Картка для витрат на дозвілля", 4000.00, 43, "2222777799995555");
        //dbService.InsertAccountsData("карта", "Картка для побутових витрат", 2500.50, 44, "3333888800006666");
        //dbService.InsertAccountsData("карта", "Картка для інвестицій", 100000.00, 45, "4444999911117777");
        //dbService.InsertAccountsData("карта", "Картка для поїздок", 3500.00, 46, "5555000011118888");
        //dbService.InsertAccountsData("карта", "Картка для покупки техніки", 45000.00, 47, "6666111122229999");
        //dbService.InsertAccountsData("карта", "Картка для навчання", 8000.00, 48, "7777222233338888");
        //dbService.InsertAccountsData("карта", "Картка для благодійності", 3000.00, 49, "8888333344449999");
        //dbService.InsertAccountsData("карта", "Картка для поточних витрат", 1000.00, 50, "9999444455550000");


        ////Таблиця заощаджень
        //dbService.InsertSavingsData("Машина Toyota Corolla", 340000.50, 20000.00, "30.12.2025", 7);
        //dbService.InsertSavingsData("Ноутбук MacBook Pro 2024", 75000.00, 5000.00, "15.08.2024", 10);
        //dbService.InsertSavingsData("Телефон iPhone 15 Pro", 45000.75, 10000.00, "10.03.2025", 15);
        //dbService.InsertSavingsData("McDonald's Мак Кріспі Делюкс Меню", 150.50, 50.00, "01.12.2024", 25);
        //dbService.InsertSavingsData("Кока Кола 1.5 л", 25.00, 5.00, "20.11.2024", 17);
        //dbService.InsertSavingsData("Beauty of Jeonsong Сонцезахисний крем SPF 50", 499.99, 200.00, "01.06.2024", 5);
        //dbService.InsertSavingsData("Подорож до Парижа", 150000.00, 10000.00, "25.07.2025", 21);
        //dbService.InsertSavingsData("Велосипед Trek FX 3", 10000.00, 5000.00, "01.04.2024", 12);
        //dbService.InsertSavingsData("Телевізор LG OLED55C9PLA", 55000.99, 30000.00, "10.05.2024", 8);
        //dbService.InsertSavingsData("Стілець IKEA Markus", 4000.00, 1500.00, "15.09.2024", 14);
        //dbService.InsertSavingsData("PlayStation 5", 18000.00, 5000.00, "10.12.2024", 9);
        //dbService.InsertSavingsData("Годинник Apple Watch Ultra", 25000.50, 10000.00, "15.11.2024", 18);
        //dbService.InsertSavingsData("Обручка Cartier Love", 120000.00, 25000.00, "14.02.2025", 2);
        //dbService.InsertSavingsData("Абонемент у спортзал на 3 місяці", 1800.00, 500.00, "01.03.2024", 27);
        //dbService.InsertSavingsData("Курс англійської мови онлайн", 4000.50, 1500.00, "01.05.2024", 30);
        //dbService.InsertSavingsData("Квиток на концерт Taylor Swift", 5000.00, 1000.00, "01.07.2024", 10);
        //dbService.InsertSavingsData("Ремонт квартири", 300000.00, 50000.00, "15.10.2025", 3);
        //dbService.InsertSavingsData("Пральна машина Samsung WW80K", 18000.00, 4000.00, "10.06.2024", 19);
        //dbService.InsertSavingsData("Електросамокат Xiaomi Mi Scooter Pro 2", 15000.50, 5000.00, "01.08.2024", 12);
        //dbService.InsertSavingsData("Вечеря в ресторані 'Риба у вогні'", 1000.00, 300.00, "01.12.2024", 11);
        //dbService.InsertSavingsData("Нові кросівки Nike Air Max 90", 5000.00, 2000.00, "10.05.2024", 29);
        //dbService.InsertSavingsData("Пуховик Canada Goose", 32000.75, 15000.00, "15.11.2024", 26);
        //dbService.InsertSavingsData("Термос Stanley Classic", 750.00, 300.00, "20.09.2024", 22);
        //dbService.InsertSavingsData("Абонемент на Netflix на рік", 2000.00, 1000.00, "01.01.2024", 5);
        //dbService.InsertSavingsData("Сумка Louis Vuitton Neverfull", 80000.00, 20000.00, "01.07.2025", 6);
        //dbService.InsertSavingsData("Електрична зубна щітка Philips Sonicare", 4000.00, 1500.00, "10.04.2024", 23);
        //dbService.InsertSavingsData("Квиток на поїзд до Одеси", 600.00, 200.00, "01.05.2024", 12);
        //dbService.InsertSavingsData("Набір Lego Star Wars Millennium Falcon", 25000.00, 5000.00, "15.09.2024", 18);
        //dbService.InsertSavingsData("Камера GoPro Hero 11 Black", 12000.50, 3000.00, "01.10.2024", 24);
        //dbService.InsertSavingsData("Планшет Samsung Galaxy Tab S9", 35000.00, 15000.00, "01.06.2024", 28);
        //dbService.InsertSavingsData("Набір косметики Dior", 5000.00, 1000.00, "01.04.2024", 31);
        //dbService.InsertSavingsData("Нові штори для вітальні", 7000.00, 2500.00, "01.07.2024", 13);
        //dbService.InsertSavingsData("Електродуховка Bosch HBA5570S0", 12000.99, 5000.00, "15.10.2024", 20);
        //dbService.InsertSavingsData("Екскурсія в Чорнобильську зону", 4000.00, 1500.00, "01.05.2024", 16);
        //dbService.InsertSavingsData("Куртка Moncler", 45000.00, 15000.00, "01.12.2024", 30);
        //dbService.InsertSavingsData("Мотоцикл Yamaha MT-07", 200000.00, 50000.00, "15.05.2025", 15);
        //dbService.InsertSavingsData("Ноутбук ASUS ROG Zephyrus G14", 90000.00, 30000.00, "01.11.2024", 18);
        //dbService.InsertSavingsData("Круїз по Середземномор’ю", 250000.00, 50000.00, "01.08.2025", 10);
        //dbService.InsertSavingsData("Фотокамера Canon EOS R5", 150000.00, 40000.00, "01.10.2024", 22);
        //dbService.InsertSavingsData("Професійна кавова машина", 100000.00, 30000.00, "01.12.2024", 5);
        //dbService.InsertSavingsData("Дизайнерське крісло Eames Lounge Chair", 50000.00, 20000.00, "01.09.2024", 9);
        //dbService.InsertSavingsData("Набір інструментів Makita", 15000.00, 5000.00, "01.11.2024", 7);
        //dbService.InsertSavingsData("Спінінг Shimano", 8000.00, 2000.00, "01.05.2024", 14);
        //dbService.InsertSavingsData("Подорож на Балі", 300000.00, 50000.00, "01.07.2025", 28);
        //dbService.InsertSavingsData("Електромобіль Tesla Model 3", 800000.00, 100000.00, "01.12.2025", 25);
        //dbService.InsertSavingsData("Екскурсія на Чорнобіль", 8000.00, 1000.00, "01.03.2025", 20);


        ////Таблиця Запланованих Платежів
        //dbService.InsertPlannedExpensesData("Плата за інтернет-провайдера", 500.00, 20, 32);
        //dbService.InsertPlannedExpensesData("Інтернет", 500.00, 5, 1);
        //dbService.InsertPlannedExpensesData("Підписка на Apple Music", 150.00, 12, 2);
        //dbService.InsertPlannedExpensesData("Бензин", 3000.00, 20, 3);
        //dbService.InsertPlannedExpensesData("Комунальні послуги (Вода)", 450.00, 10, 4);
        //dbService.InsertPlannedExpensesData("Електроенергія", 800.00, 15, 5);
        //dbService.InsertPlannedExpensesData("Підписка на Netflix", 250.00, 1, 6);
        //dbService.InsertPlannedExpensesData("Газ", 600.00, 18, 7);
        //dbService.InsertPlannedExpensesData("Оренда квартири", 15000.00, 25, 8);
        //dbService.InsertPlannedExpensesData("Мобільний зв'язок", 200.00, 3, 9);
        //dbService.InsertPlannedExpensesData("Страхування авто", 1200.00, 30, 10);
        //dbService.InsertPlannedExpensesData("Підписка на Adobe Creative Cloud", 600.00, 7, 11);
        //dbService.InsertPlannedExpensesData("Проїзний на громадський транспорт", 300.00, 22, 12);
        //dbService.InsertPlannedExpensesData("Абонемент у спортзал", 1000.00, 1, 13);
        //dbService.InsertPlannedExpensesData("Плата за школу", 2500.00, 14, 14);
        //dbService.InsertPlannedExpensesData("Підписка на Spotify", 170.00, 6, 15);
        //dbService.InsertPlannedExpensesData("Комунальні послуги (Газ)", 650.00, 8, 16);
        //dbService.InsertPlannedExpensesData("Плата за садочок", 1200.00, 16, 17);
        //dbService.InsertPlannedExpensesData("Медичне страхування", 2000.00, 12, 18);
        //dbService.InsertPlannedExpensesData("Підписка на YouTube Premium", 150.00, 13, 19);
        //dbService.InsertPlannedExpensesData("Підписка на PlayStation Plus", 500.00, 19, 20);
        //dbService.InsertPlannedExpensesData("Оренда паркомісця", 1200.00, 27, 21);
        //dbService.InsertPlannedExpensesData("Водопостачання", 300.00, 9, 22);
        //dbService.InsertPlannedExpensesData("Зарядка електромобіля", 1000.00, 4, 23);
        //dbService.InsertPlannedExpensesData("Підписка на Audible", 200.00, 26, 24);
        //dbService.InsertPlannedExpensesData("Плата за техобслуговування авто", 2500.00, 11, 25);
        //dbService.InsertPlannedExpensesData("Страхування житла", 1500.00, 21, 26);
        //dbService.InsertPlannedExpensesData("Підписка на Amazon Prime", 300.00, 2, 27);
        //dbService.InsertPlannedExpensesData("Комунальні послуги (Електроенергія)", 900.00, 28, 28);
        //dbService.InsertPlannedExpensesData("Плата за дитячі гуртки", 1000.00, 17, 29);
        //dbService.InsertPlannedExpensesData("Підписка на Microsoft Office", 400.00, 23, 30);

        ////Таблиця Доходів
        //dbService.InsertIncomesData("З/П", "01.08.2024", 15000.00, 2);
        //dbService.InsertIncomesData("Стипендія", "05.08.2024", 3500.00, 3);
        //dbService.InsertIncomesData("Кишенькові", "10.08.2024", 500.00, 1);
        //dbService.InsertIncomesData("Соц.виплати", "15.08.2024", 2000.00, 4);
        //dbService.InsertIncomesData("Премія", "20.08.2024", 4000.00, 5);
        //dbService.InsertIncomesData("Інше", "25.08.2024", 1000.00, 2);
        //dbService.InsertIncomesData("З/П", "01.09.2024", 15000.00, 3);
        //dbService.InsertIncomesData("Стипендія", "05.09.2024", 3500.00, 4);
        //dbService.InsertIncomesData("Кишенькові", "10.09.2024", 600.00, 5);
        //dbService.InsertIncomesData("Соц.виплати", "15.09.2024", 2200.00, 2);
        //dbService.InsertIncomesData("Премія", "20.09.2024", 5000.00, 1);
        //dbService.InsertIncomesData("Інше", "25.09.2024", 1200.00, 3);
        //dbService.InsertIncomesData("З/П", "01.10.2024", 16000.00, 1);
        //dbService.InsertIncomesData("Стипендія", "05.10.2024", 3700.00, 2);
        //dbService.InsertIncomesData("Кишенькові", "10.10.2024", 700.00, 4);
        //dbService.InsertIncomesData("Соц.виплати", "15.10.2024", 2300.00, 3);
        //dbService.InsertIncomesData("Премія", "20.10.2024", 5500.00, 5);
        //dbService.InsertIncomesData("Інше", "25.10.2024", 1300.00, 4);
        //dbService.InsertIncomesData("З/П", "01.11.2024", 17000.00, 5);
        //dbService.InsertIncomesData("Стипендія", "05.11.2024", 3800.00, 1);
        //dbService.InsertIncomesData("Кишенькові", "10.11.2024", 800.00, 3);
        //dbService.InsertIncomesData("Соц.виплати", "15.11.2024", 2400.00, 2);
        //dbService.InsertIncomesData("Премія", "20.11.2024", 6000.00, 4);
        //dbService.InsertIncomesData("Інше", "25.11.2024", 1400.00, 1);
        //dbService.InsertIncomesData("З/П", "01.12.2024", 18000.00, 3);
        //dbService.InsertIncomesData("Стипендія", "05.12.2024", 3900.00, 5);
        //dbService.InsertIncomesData("Кишенькові", "10.12.2024", 900.00, 2);
        //dbService.InsertIncomesData("Соц.виплати", "15.12.2024", 2500.00, 4);
        //dbService.InsertIncomesData("Премія", "20.12.2024", 6200.00, 1);
        //dbService.InsertIncomesData("Інше", "25.12.2024", 1500.00, 5);
        //dbService.InsertIncomesData("З/П", "01.01.2025", 19000.00, 2);
        //dbService.InsertIncomesData("Стипендія", "05.01.2025", 4000.00, 3);
        //dbService.InsertIncomesData("Кишенькові", "10.01.2025", 1000.00, 4);
        //dbService.InsertIncomesData("Соц.виплати", "15.01.2025", 2600.00, 5);
        //dbService.InsertIncomesData("Премія", "20.01.2025", 6300.00, 1);
        //dbService.InsertIncomesData("Інше", "25.01.2025", 1600.00, 2);
        //dbService.InsertIncomesData("З/П", "01.02.2025", 20000.00, 5);
        //dbService.InsertIncomesData("Стипендія", "05.02.2025", 4100.00, 1);
        //dbService.InsertIncomesData("Кишенькові", "10.02.2025", 1100.00, 3);
        //dbService.InsertIncomesData("Соц.виплати", "15.02.2025", 2700.00, 4);
        //dbService.InsertIncomesData("Премія", "20.02.2025", 6400.00, 2);
        //dbService.InsertIncomesData("Інше", "25.02.2025", 1700.00, 1);

        ////таблиця Витрат
        //for (int i = 0; i < 50; i++)
        //{
        //    int categoryId = random.Next(1, 43);
        //    int accountId = random.Next(1, 51);
        //    double expenseSum = Math.Round(random.NextDouble() * 1000, 2);
        //    string expenseDate = $"{random.Next(1, 29):D2}.{random.Next(1, 13):D2}.{random.Next(2020, 2024)}";

        //    dbService.InsertExpensesData(categoryId, expenseDate, expenseSum, accountId);
        //}


        Console.WriteLine("Таблиця Користувачі:");
        dbService.GetFullUsersData();
        Console.WriteLine("");

        Console.WriteLine("Таблиця Категорії Витрат:");
        dbService.GetFullExpensesCategoriesData();
        Console.WriteLine("");

        Console.WriteLine("Таблиця Рахунків:");
        dbService.GetFullAccountsData();
        Console.WriteLine("");

        Console.WriteLine("Таблиця Заощаджень:");
        dbService.GetFullSavingsData();
        Console.WriteLine("");

        Console.WriteLine("Таблиця Запланованих платежів:");
        dbService.GetFullPlannedExpensesData();
        Console.WriteLine("");

        Console.WriteLine("Таблиця Доходів:");
        dbService.GetFullIncomesData();
        Console.WriteLine("");

        Console.WriteLine("Таблиця Витрат:");
        dbService.GetFullExpensesData();
        Console.WriteLine("");
    }
}
