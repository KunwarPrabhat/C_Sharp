// // Student names
// int currentAssignments = 5;

// int[] sophiaScores = new int[]  {90, 86, 87, 98, 100 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// foreach(string name in studentNames){
//     if(name == "Sophia"){
//         int sophiaSum = 0;
//         decimal sophiaScore = 0;
//         foreach(int score in sophiaScores){
//             sophiaSum += score;
//         }
//         sophiaScore = (decimal)(sophiaSum) / currentAssignments;
//         Console.WriteLine("Student\t\tGrade\n");
//         Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
//     }
//     // Console.WriteLine($"{name}"); 
// }
//     Console.WriteLine("Press the Enter key to continue");
//     Console.ReadLine();

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));
int saleAmount = 1001;
int discount  = saleAmount > 1000 ? 100: 50;
Console.WriteLine($"Discount: {discount}");
