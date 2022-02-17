// namespace struct_ex
// {
//     public struct Mystruct
//     {
//         public int Kor, Eng, Math, Total;
//         public float Average;

//         public void Compute()
//         {
//             Total = Kor + Eng + Math;
//             Average = Total / 3.0f;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Mystruct Test1 = new Mystruct();
//             Test1.Kor = 80;
//             Test1.Eng = 90;
//             Test1.Math = 88;
//             Test1.Compute();
//             Console.WriteLine("총점 : {0} 평균 : {1:f1}", Test1.Total, Test1.Average);
//         }
//     }
// }