// namespace Array_example3
// {
//     class Arr4
//     {
//         static void Main(string[] args)
//         {
//             // int[][] array = new int[2][];
//             // array[0] = new int[3] {1,2,3};
//             // array[1] = new int[2] {4,5};

//             // for (int i = 0; i < array.Length; i++)
//             // {
//             //     for (int j = 0; j < array[i].Length; j++)
//             //         Console.Write(array[i][j]);
//             // }
//             int[][][] array3 = new int[2][][]; //데이터형[면][행][열]
//             array3[0] = new int[2][];
//             array3[1] = new int[3][];

//             array3[0][0] = new int[3] {1,2,3};
//             array3[0][1] = new int[2] {4,5};

//             array3[1][0] = new int[3] {6,7,8};
//             array3[1][1] = new int[2] {9,10};
//             array3[1][2] = new int[2] {11,12};

//             for (int i = 0; i < array3.Length; i++) //array3 : 면 .Length : 값
//             {
//                 for (int j = 0; j < array3[i].Length; j++)
//                 {
//                     for (int k = 0; j < array3[i][j].Length; k++) // i: 면 , j : 행 , .Length : 열
//                     {
//                         Console.Write("{0} ", array3[i][j][k]);
//                     }
//                 }
//             }
//         }
//     }
// }