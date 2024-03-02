using System;
using System.Collections.Generic;

namespace ClassExample02
{
    class PersonBank
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal depositAmount)
        {
            Balance += depositAmount;
            Console.WriteLine($"Yeni bakiye: {Balance}");
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= Balance)
            {
                Balance -= withdrawAmount;
                Console.WriteLine($"Kalan miktar: {Balance}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        public static PersonBank CreateNewAccount()
        {
            PersonBank newAccount = new PersonBank();

            Console.Write("Hesap sahibinin adı: ");
            newAccount.CustomerName = Console.ReadLine();

            Console.Write("Hesap sahibinin soyadı: ");
            newAccount.CustomerSurname = Console.ReadLine();

            Console.Write("Hesap bakiyesi: ");
            newAccount.Balance = decimal.Parse(Console.ReadLine());

            return newAccount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<PersonBank> accounts = new List<PersonBank>();

            while (true)
            {
                Console.WriteLine("1. Yeni hesap oluştur");
                Console.WriteLine("2. Hesap işlemleri");
                Console.WriteLine("3. Çıkış");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Geçerli bir seçenek giriniz.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        PersonBank newAccount = PersonBank.CreateNewAccount();
                        accounts.Add(newAccount);
                        break;
                    case 2:
                        PerformAccountOperations(accounts);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Geçerli bir seçenek giriniz.");
                        break;
                }
            }
        }

        static void PerformAccountOperations(List<PersonBank> accounts)
        {
            Console.Write("Hesap sahibinin adını girin: ");
            string customerName = Console.ReadLine();

            PersonBank selectedAccount = accounts.Find(account => account.CustomerName == customerName);

            if (selectedAccount == null)
            {
                Console.WriteLine("Hesap bulunamadı.");
                return;
            }

            Console.WriteLine($"Mevcut bakiye: {selectedAccount.Balance}");
            // Para çekme veya yatırma işlemleri burada yapılabilir
        }
    }
}
