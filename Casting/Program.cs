// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");
// int first = 7;
// int second = 5;
// string message  = first.ToString() + second.ToString();
// Console.WriteLine(message);
// string first = "7";
// string second = "8";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

//Convert a string to a int using the Convert class
// string value1 = "10";
// string value2 = "20";

// int result = Convert.ToInt32(value1) + Convert.ToInt32(value2);
// Console.WriteLine(result);

//TryParse() a string into an int
// string value ="hello";
// int result = 0;
// if(int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }else 
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
//Exercise - Complete a challenge to combine string array values as strings and as integers
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string Message = "";
foreach(var value in values){
    decimal number;  // stores the TryParse "out" value

    if(decimal.TryParse(value, out number))
    //out is a C# keyword that passes a variable by reference.

    //It means TryParse will write the parsed number into number if it succeeds.

    //number is the output variable where the result will be stored.
    {
        // Console.WriteLine($"integer : {value}");
        total += number;
    }
    else{
        Message += value;
    }
}
    Console.WriteLine($"Messsage: {Message}");
    Console.WriteLine($"Total: {total}");