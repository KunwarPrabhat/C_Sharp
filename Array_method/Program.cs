// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// //to reverse the array: 
// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2); //we are using the Array.Clear() method to clear the values stored in the elements of the pallets array starting at index 0 and clearing 2 elements.
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//Array clear method
// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// // we're calling the Resize() method passing in the pallets array by reference, 
// //using the ref keyword. In some cases, methods require you pass arguments by value (the default) or by reference (using the ref keyword).
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }
// Use the ToCharArray() to reverse a string
// string value = "abc123";
// char[] valueArray = value.ToCharArray(); //In this example, the ToCharArray() method is used to create an array of char, 
// where each element of the array represents one character of the original string.
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);

//Combine all of the chars into a new comma-separated-value string using Join()
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

//Use the Remove() method

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20); //123455000  3 (Output)
// Console.WriteLine(updatedData);