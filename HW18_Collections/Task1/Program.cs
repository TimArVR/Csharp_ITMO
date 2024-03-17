//Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
//Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно,
//а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо;
//для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка
//в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
//в конце прохода стек должен быть пуст.

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
        }
        static bool Check(string str) 
        { 
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>()
            {
                {'(',')' },
                {'{','}' },
                {'[',']' },
            };

            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(keyValuePairs[c]);
                }
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count==0||stack.Pop()!=c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}