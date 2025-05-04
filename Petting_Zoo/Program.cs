// using system;
string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

RandomizeAnimals();
    for(int j = 0; j < pettingZoo.Length; j++)
    {
        Console.Write($"{pettingZoo[j]}, ");
    }
// string[,] group = AssignGroup();
// Console.WriteLine("School A");
// PrintGroup(group);
void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);  //Fisher–Yates shuffle 
        Console.Write($" i ={i}, r = {r} ;");

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
    Console.WriteLine();
}