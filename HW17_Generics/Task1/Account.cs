using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Account<T>
    {
        private T _accountNumber;
        private decimal _balance;
        private string _fio;
        private T AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }
        private decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        private string Fio
        {
            get
            {
                return _fio;
            }
            set
            {
                _fio = value;
            }

        }

        //public Account (T an, decimal b, string f )
        //{
        //    AccountNumber = an;
        //    Balance = b;
        //    Fio = f;
        //}

        //public void SetData(T an, decimal b, string f)
        //{
        //    AccountNumber = an;
        //    Balance = b;
        //    Fio = f;
        //}

        public void InputInfo()
        {
            Console.WriteLine("Введите номер счета");
            AccountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите текущий баланс");
            Balance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            Fio = Console.ReadLine();
        }


        public string GetData()
        {
            return $"\nНомер счета: {AccountNumber} Баланс:${Balance} ФИО:{Fio}";
        }


    }
}
