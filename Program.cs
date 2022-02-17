// // See https://aka.ms/new-console-template for more information
// using System;
// namespace Program
// {
//     class Helloworld
//     {
//         static  void Main(string[] args)
//         {
//            /*Console.WriteLine("Helloworld");
//             Console.WriteLine("{0} {1}", 3.14f, 12);
//             Console.WriteLine("{0} + {1} = {2}", 1,2,1+2);
//             Console.WriteLine("{0:C} {1:P} {0:X}", 123, 123.45);
//             */
//             int Result;
//             byte x = 1, y = 2;
//             Result = x + y;
//             Console.WriteLine(Result);
//             Console.WriteLine("{0} ~ {1}", short.MinValue, short.MaxValue);
//             float test = 3.14f;
//             Console.WriteLine(test);
//             string str1 = "Hello ";
//             string str2 = "World!";
//             string str3 = str1 + str2;
//             string str4 = "program" + "ming";
//             Console.WriteLine("{0} {1}", str3, str4);
//             Console.WriteLine(str3[4]);
//             Console.WriteLine("문자 개수 : {0}", str3.Length);

//             if (str3 == "Hello World!")
//             {
//                 Console.WriteLine("Same");
//             }
//             else {
//                 Console.WriteLine("Different");
//             }

//             var value1 = 3.14f;
//             float value2 = 10.12f;
//             float sum = value1 + value2;
//             Console.WriteLine("{0} {1:f2} {2}", value1, value2, sum); //{1:f1} 여기서 :f(숫자) -> 소수점 몇자리까지 표시할지 결정하는 것

//             int? Num1 = null;
//             if(Num1.HasValue){
//                 Console.WriteLine("올바른 값");
//             }
//             else{
//                 Console.WriteLine("null 값");
//             }
//             Console.WriteLine("null : {0}", Num1);

//             //변환
//             int value3 = 127;
//             string str5 = value3.ToString();
//             Console.WriteLine(str5);

//             int value4 = Convert.ToInt32(str5);
//             Console.WriteLine(value4);

//             string str6 = "3.14";
//             float value5 = float.Parse(str6);
//             Console.WriteLine(value5);

//             //Boxing & UnBoxing
//             // int i = 123;
//             // object obj = i;
//             // Console.WriteLine("{0}", (int)obj);

//             int i = 123;
//             object o = i;
//             i = 456;
//             Console.WriteLine("{0} {1}", i, (int)o); //별도의 메모리를 사용되는 것을 알 수 있다

//             //표준 입력
//             ConsoleKeyInfo KeyInfo;
//             // do
//             // {
//             //     KeyInfo = Console.ReadKey();
//             //     if (KeyInfo.Key == ConsoleKey.A)
//             //         Console.WriteLine("a가 눌렸다");
//             // } while (KeyInfo.Key != ConsoleKey.Escape);
//             do
//             {
//                 KeyInfo = Console.ReadKey(true);
//                 if(KeyInfo.KeyChar == 'a')
//                     Console.WriteLine("a가 눌렀어");
//                 Console.Write(KeyInfo.KeyChar);
//             } while (KeyInfo.Key != ConsoleKey.Escape); 

//             int Kor, Eng, Math, Total;
//             float Average;

//             Console.Write("국어 점수를 입력해 주세요 : ");
//             Kor = Convert.ToInt32(Console.ReadLine());

//             Console.Write("영어 점수를 입력해 주세요 : ");
//             Eng = Convert.ToInt32(Console.ReadLine());

//             Console.Write("수학 점수를 입력해 주세요 : ");
//             Math = Convert.ToInt32(Console.ReadLine());
//             Total = Kor + Eng + Math;
//             Average = Total / 3.0f;
//             Console.WriteLine("{0} {1} {2} {3} {4:f1}", Kor, Eng, Math, Total, Average);

//         }
//     }
// } 