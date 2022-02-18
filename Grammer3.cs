// namespace Grammer3
// {
//     class A
//     {
//     }

//     class B
//     {
//     }

//     class Gram3
//     {
//         static void Main(string[] args)
//         {
//             string str1 = "123";
//             object obj = str1;
//             string str2 = obj as string;
//             Console.WriteLine(str2);

//             A test1 = new A();
//             object obj1 = test1;
//             B test2 = obj1 as B;
//             if (test2 == null)
//                 Console.WriteLine("형변환 실패");
//             else
//                 Console.WriteLine("형변환 성공");
            
//             //null 병합 연산자
//             int? x = null;
//             int y = x ?? -1;
//             Console.WriteLine(y);
//             x = 10;
//             y = x ?? -1;
//             Console.WriteLine(y);
//         }
//     }
// }