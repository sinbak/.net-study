// namespace Grammer2
// {
//     class Grammer2
//     {
//         static void Main(string[] args)
//         {
//             int nValue = 10;
//             if (nValue is float)
//                 Console.WriteLine("호환됨");
//             else
//                 Console.WriteLine("호환 안 됨");
            
//             if (nValue is object) //boxing 호환
//                 Console.WriteLine("호환됨");
//             else
//                 Console.WriteLine("호환이 안 됨");
            
//             object obj = nValue; // boxing
//             if (obj is int) //int 형으로 호환이 되는가
//             {
//                 Console.WriteLine("호환됨");
//             }
//             else
//             {
//                 Console.WriteLine("호환이 안 됨");
//             }
//         }
        
//     }
// }