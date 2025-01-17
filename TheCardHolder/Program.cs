﻿//1.Создайте класс BankAccount, который имеет поля:

//баланс(decimal),
//владелец(string).
//Реализуйте методы для:

//Deposit(decimal amount) — пополнение счета,
//Withdraw(decimal amount) — снятие со счета,
//GetBalance() — возвращение текущего баланса.

//Заблокируйте доступ к полям напрямую, предоставив только методы для работы с ними.
//Проверьте работу класса, создав объект и выполняя операции пополнения и снятия средств.


class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = null!;
        while (true)
        {
            if (bankAccount == null)
            {
                Console.WriteLine("Выберите раздел:");
                Console.WriteLine("1. Создания карты");
                Console.WriteLine("2. Выход");

                int input;
                while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 2)
                {
                    Console.WriteLine("Пожалуйста, выберите раздел от 1 до 2");
                }

                switch (input)
                {
                    case 1:
                        Console.Write("Введите имя владельца карты: ");
                        string ownerName = Console.ReadLine()!;
                        bankAccount = new BankAccount(ownerName);
                        Console.WriteLine($"Карта успешно создана для {ownerName}.");
                        break;

                    case 2:
                        Console.WriteLine("Спасибо за использование нашей системы!");
                        return;

                    default:
                        Console.WriteLine("Непредвиденная ошибка.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nВыберите раздел:");
                Console.WriteLine("1. Проверка баланса");
                Console.WriteLine("2. Пополнение баланса");
                Console.WriteLine("3. Снятие денег");
                Console.WriteLine("4. Выход");
                int input;
                while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 4)
                {
                    Console.WriteLine("Пожалуйста, выберите раздел от 1 до 4");
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine($"Текущий баланс: {bankAccount.GetBalance():C}");
                        break;

                    case 2:
                        Console.Write("Введите сумму для пополнения: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount >= 0)
                        {
                            bankAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма.");
                        }
                        break;

                    case 3:
                        Console.Write("Введите сумму для снятия: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount >= 0)
                        {
                            bankAccount.WithDraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Спасибо за использование нашей системы!");
                        return;

                    default:
                        Console.WriteLine("Непредвиденная ошибка.");
                        break;
                }
            }
        }
    }

    internal class BankAccount
    {
        private string ownerName;
        private decimal balance;


        internal string OwnerName
        {
            get
            {
                return ownerName;

            }

            set
            {
                ownerName = value;
            }
        }

        internal decimal Balance
        {
            get { return balance; }
            private set { }
        }


        public BankAccount(string ownerName)
        {
            OwnerName = ownerName;
            balance = 0;
        }


        // Пополнение счета
        internal void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Ваш баланс пополнен на : {amount}");
        }

        // Снятие со счета
        internal void WithDraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Не хватает средств для снятие денегь");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Успешно прошло\nОстаток счета : {balance}");
            }
        }

        // Проверка баланса
        internal decimal GetBalance()
        {
            return Balance;
        }

    }
}




