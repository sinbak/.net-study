// namespace Array_example2
// {
//     class Arrayex2
//     {
//         static void Main(string[] args)
//         {
//             int[,] nArray1 = new int[2,2];
//             nArray1[0,0] = 1;
//             nArray1[0,1] = 2;
//             nArray1[1,0] = 3;
//             nArray1[1,1] = 4;

//             for (int i = 0; i < 2; i++)
//                 for (int j = 0; j < 2; j++)
//                     Console.Write(nArray1[i, j] + " ");
//             Console.Write("\n");

//             int[,] nArray2 = { {1,2}, {3,4}};
//             for (int i = 0; i < 2; i++)
//                 for (int j =0; j < 2; j++)
//                     Console.Write(nArray1[i, j] + " ");
//             Console.Write("\n");

//             string[,,] strArray = { { {"ab", "cd"}, {"ef", "gh"} }, 
//                                     { {"ij","kl"}, {"mn", "op"} } };
//             // int[,,] strArray = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
//             //                      { { 7, 8, 9 }, { 10, 11, 12 } } };
//             for (int i = 0; i < 2; i++)
//                 for (int j = 0; j < 2; j++)
//                     for (int k = 0; k < 2; k++)
//                         Console.Write(strArray[i, j, k] + " ");
//         }
//     }
// }