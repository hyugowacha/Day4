using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class gwaje1
    {
        static void Main(string[] args)
        {
            #region 과제0
            //int[] arr = new int[4];

            //for(int i = 0; i< arr.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}번째 요소를 입력하여 주십시오");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("입력된 요소는 다음과 같습니다.");
            //foreach(int i in arr)
            //{
            //    Console.Write(i+" ");
            //}
            #endregion

            int[] skillCooldowns = new int[4];
            skillCooldowns[0] = 5;
            skillCooldowns[1] = 3;
            skillCooldowns[2] = 10;
            skillCooldowns[3] = 7;

            ConsoleKeyInfo skill;

            while(true)
            {
                
                Console.WriteLine("------스킬 선택------");

                Console.Write("Q스킬: "); //Q스킬 상태 출력
                if (skillCooldowns[0] == 0)
                {
                    Console.WriteLine("Q스킬 준비 완료");
                }
                else
                {
                    Console.WriteLine($"{skillCooldowns[0]}초 남음");
                }

                Console.Write("W스킬: "); //W스킬 상태 출력
                if (skillCooldowns[1] == 0)
                {
                    Console.WriteLine("W스킬 준비 완료");
                }
                else
                {
                    Console.WriteLine($"{skillCooldowns[1]}초 남음");
                }

                Console.Write("E스킬: "); //E스킬 상태 출력
                if (skillCooldowns[2] == 0)
                {
                    Console.WriteLine("E스킬 준비 완료");
                }
                else
                {
                    Console.WriteLine($"{skillCooldowns[2]}초 남음");
                }

                Console.Write("R스킬: "); //R스킬 상태 출력
                if (skillCooldowns[3] == 0)
                {
                    Console.WriteLine("R스킬 준비 완료");
                }
                else
                {
                    Console.WriteLine($"{skillCooldowns[3]}초 남음");
                }

                Console.WriteLine("------------------------\n");

                skill = Console.ReadKey(true); //키 입력받기

                if (skill.Key == ConsoleKey.Q) //Q스킬 입력
                {
                    if (skillCooldowns[0] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("적은 여럿, 검은 하나!\n");
                        skillCooldowns[0] = 6;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("아직 스킬이 준비되지 않았습니다.\n");
                    }
                        
                }

                else if (skill.Key == ConsoleKey.W) //W스킬 입력
                {
                    if (skillCooldowns[1] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("정신과 육체.\n");
                        skillCooldowns[1] = 5;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("아직 스킬이 준비되지 않았습니다.\n");
                    }
                        
                }

                else if (skill.Key == ConsoleKey.E) //E스킬 입력
                {
                    if (skillCooldowns[2] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("완벽한 일격.\n");
                        skillCooldowns[2] = 11;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("아직 스킬이 준비되지 않았습니다.\n");
                    }
                }

                else if (skill.Key == ConsoleKey.R) //R스킬 입력
                {
                    if (skillCooldowns[3] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("생각의 속도!\n");
                        skillCooldowns[3] = 8;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("아직 스킬이 준비되지 않았습니다.\n");
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.\n");
                    continue;//아래에 있는 코드 무시하고 처음으로 롤백
                }

                for(int i = 0; i < skillCooldowns.Length; i++)
                {
                    skillCooldowns[i]--;

                    if (skillCooldowns[i] < 0)
                    {
                        skillCooldowns[i] = 0;
                    }
                }

            }

        }
    }
}
