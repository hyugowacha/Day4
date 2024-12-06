using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class gwaje3
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            bool isCorrect;

            while (true)
            {
                Console.WriteLine("몇 칸의 인벤토리를 생성하시겠습니까?");
                isCorrect = int.TryParse(Console.ReadLine(), out num1);
                if (num1 > 0 && num1 < 10)
                {
                    Console.WriteLine($"{num1}칸의 인벤토리가 생성되었습니다.\n");
                    break;        
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.\n");
                }
            }
            
            string[] Inventory = new string[num1];

            for(int i = 0; i < Inventory.Length; i++)
            {
                Inventory[i] = "";
            }

            while (true)
            {
                Console.WriteLine("몇 번째 칸을 열람하시겠습니까?");
                while (true)
                {
                    while(true)
                    {
                        isCorrect = int.TryParse(Console.ReadLine(), out num2);
                        if (num2 > num1)
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        else
                            break;
                    }
                    
                    if (num2 > 0 && num2 < 10)
                    {
                        break;
                    }       
                    else
                        Console.WriteLine("잘못된 입력입니다.");
                }

                if (Inventory[num2-1] == "")
                {
                    Console.WriteLine("비어있습니다. 넣고자 하는 값을 입력하세요.\n");
                    string Input = Console.ReadLine();
                    Inventory[num2 - 1] = Input;
                }
                else
                {
                    Console.WriteLine($"{Inventory[num2-1]}이(가) 들어있습니다.\n");
                }
                Console.WriteLine("\n계속하려면 아무 키나 누르세요. 종료하려면 0을 누르세요.\n");
                String Input2 = Console.ReadLine();
                Console.Clear();

                if(Input2 == "0")
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("계속합니다.\n");
                }

            }
            
        }
        
    }
}
