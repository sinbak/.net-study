// namespace FilestreamWrite1
// {
//     class Filesys
//     {
//         static void Main(string[] args)
//         {
//             int value = 12;
//             float value2 = 3.14f;
//             string str1 = "Hello World";
//             //1번 방법
//             // FileStream fs = new FileStream("test.txt", FileMode.Create);
//             // StreamWriter sw = new StreamWriter(fs);
//             // sw.WriteLine(value);
//             // sw.WriteLine(value2);
//             // sw.WriteLine(str1);
//             // sw.Close();

//             //2번 방법
//             using (StreamWriter sw = new StreamWriter(new FileStream("test1.txt", FileMode.Create)))
//             {
//                 sw.WriteLine(value);
//                 sw.WriteLine(value2);
//                 sw.WriteLine(str1);
//             }
//         }
//     }
// }