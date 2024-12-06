using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 배열 기초
            // //배열

            // //string skill1 = "결정타";
            // //string skill2 = "용기";
            // //string skill3 = "심판";
            // //string skill4 = "데마시아";

            // string[] skills;//문자열 여러개를 담을 공간이 필요해
            // skills = new string[4]; //문자열 4개를 담을 공간을 어딘가에 만들어줘
            // //new는 어딘가에 공간을 빌려달라,
            // //이 줄이 지났으면 어딘가엔 string 4개를 만들 공간이 만들어져있음
            // //어딘가인지는 아직 모름

            // skills[0] = "결정타";
            // skills[1] = "용기";
            // skills[2] = "심판";
            // skills[3] = "데마시아";

            // //Console.WriteLine("사용할 스킬");

            // int number = int.Parse(Console.ReadLine());

            //// for(int i = 0; i<skills.Length; i++)
            //// {
            ////     Console.WriteLine($"{i+1}번째 요소는 {skills[i]}입니다");
            //// }

            // foreach(string element in skills)// = skills에 있는 원소 하나하나 반복해봐
            // {
            //     Console.WriteLine("이건 foreach로 나온 반복 " + element);
            // }

            // Console.WriteLine($"{number}번 속 내용은 {skills[number]}입니다.");



            // //switch (int.Parse(Console.ReadLine()))
            // //{
            // //    case 1:
            // //        Console.WriteLine($"{skill1} 사용");
            // //        break;
            // //    case 2:
            // //        Console.WriteLine($"{skill2} 사용");
            // //        break;
            // //    case 3:
            // //        Console.WriteLine($"{skill3} 사용");
            // //        break;
            // //    case 4:
            // //        Console.WriteLine($"{skill4} 사용");
            // //        break;
            // //}

            //-------------------------------------------------

            //string[] shortCuts;
            //shortCuts = new string[4]; //new를 통해 진짜 공간을 만듦

            //shortCuts[0] = "회복약";
            //shortCuts[1] = "부적";
            //shortCuts[2] = "만능물약";
            //shortCuts[3] = "수류탄";

            //for(int i = 0; i < shortCuts.Length; i++)
            //{
            //    shortCuts[i] = $"{i}번째 요소 기입중입니다";
            //    // Console.WriteLine(shortCuts[i]);
            //}

            //foreach(string ele in shortCuts) //배열 속에 있는 요소들을 ele에 임시적으로 저장
            //{
            //    Console.WriteLine(ele);
            //}
            #endregion

            //2차원 배열
            //string[,] shortCuts = new string[3, 4];

            //shortCuts[0, 0] = "고급회복약";
            //shortCuts[0, 1] = "부적";
            //shortCuts[0, 2] = "물약";
            //shortCuts[0, 3] = "수류탄";

            //shortCuts[1, 0] = "고급";
            //shortCuts[1, 1] = "진군";
            //shortCuts[1, 2] = "아드로핀";
            //shortCuts[1, 3] = "파폭";

            ////shortCuts[2, 0] = "각성";
            ////shortCuts[2, 1] = "정가";
            ////shortCuts[2, 2] = "성부";
            ////shortCuts[2, 3] = "암수";

            //string[,] shortCuts = new string[3, 4]
            //{
            //    { "고급회복약", "성스러운부적", "만능물약", "회오리수류탄" },
            //    { "고급회복약", "진군의깃발", "아드로핀물약", "파괴폭탄" },
            //    { "정령의가호", "성스러운부적", "시간정지물약", "암흑수류탄" }
            //};

            //int myNum = 1;
            //var myVar = 2;

            ////for (int i = 0; i < 3; i++)
            ////{
            ////    for (int j = 0; j < 4; j++)
            ////    {
            ////        Console.Write(shortCuts[i,j] + "\t");
            ////    }
            ////    Console.WriteLine();
            ////}

            //// Console.WriteLine(shortCuts.Length);

            //string name = "grid";

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character + " ");
            //}

            //int asd;
            //char asdf;
            //float asg;

            //string name = "ingrid";
            //
            //char[] charArr = name.ToCharArray();
            //
            //foreach(var ele in charArr)
            //{
            //    Console.WriteLine(ele + " ");
            //}
            //
            //charArr[2] = 'a';
            //
            //string changedStr;
            //changedStr = new string(charArr);
            //
            //Console.WriteLine(changedStr);

      


        }
    }
}
