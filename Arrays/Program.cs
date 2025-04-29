// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B123";
// fraudulentOrderIDs[2] = "C123";

// Console.WriteLine($"First element :{fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second element :{fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third element :{fraudulentOrderIDs[2]}");


// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Changed: {fraudulentOrderIDs[0]}");

// string[] names = {"abc", "cbc", "dbc", "Bao"};
// foreach(string name in names){
//     Console.WriteLine(name);
// }
// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// foreach (int items in inventory)
// {
//     sum += items;
// }
// Console.WriteLine($"We have {sum} items in inventory.");

string[] fraudulentOrderIDs = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach(string ids in fraudulentOrderIDs){
    if(ids.StartsWith("B")){
        Console.WriteLine(ids);
    }
}