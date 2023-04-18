List<string> favouriteFoods = new List<string>();

Console.WriteLine("Quanti sono i tuoi cibi preferiti? ");
int numbersOfFavouriteFood = int.Parse(Console.ReadLine());

for(int i = 0; i < numbersOfFavouriteFood; i++)
{
    Console.WriteLine("Inserisci il piatto in posizione " + (i+1));
    favouriteFoods.Add(Console.ReadLine());
}


Console.WriteLine("---------------- INFO ----------------");
Console.WriteLine();
Console.WriteLine("La classifica contiene " + favouriteFoods.Count + " piatti!");
Console.WriteLine();
printRanking(favouriteFoods);
Console.WriteLine();
Console.Write("Il primo piatto in classifica è: ");
printFirst(favouriteFoods);
Console.Write("L'ultimo piatto in classifica è: ");
printLast(favouriteFoods);
Console.WriteLine("Il/i piatto/i di metà classifica è/sono: ");
printMedian(medianIndex(favouriteFoods.Count), favouriteFoods);
Console.WriteLine("--------------------------------------");

void printRanking(List<string> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.Write((i + 1) + "] ");
        Console.WriteLine(list[i]);
    }
}

void printFirst(List<string> list)
{
    Console.WriteLine(list[0]);
}

void printLast(List<string> list)
{
    Console.WriteLine(list[list.Count - 1]);
}

int[] medianIndex(int listSize)
{
    int[] result = new int[2];
    if (listSize % 2 == 0)
    {
        result[0] = listSize / 2;
        result[1] = listSize / 2 + 1;
    } else
    {
        result[0] = listSize / 2;
        result[1] = 0;
    }
    return result;
}

void printMedian(int[] medianIndexes, List<string> list)
{
    if (medianIndexes[1] == 0)
    {
    Console.WriteLine(medianIndexes[0] + "]" + list[medianIndexes[0]]);
    }  else
    {
    Console.WriteLine(medianIndexes[0] + "]" + list[medianIndexes[0]]);
    Console.WriteLine(medianIndexes[1] + "]" + list[medianIndexes[1]]);
    }
}