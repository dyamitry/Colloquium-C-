
string[] CreateUserStringArray(int N)
{
    string[]InputArray = new string[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Input array element number {i+1}: ");
        string UserElement = Console.ReadLine();
        InputArray[i] = UserElement;
    }
    return InputArray;
}

string[] CreateRandomStringArray(int N, int MaxSymbolCountUser)
{
    string[]InputArray = new string[N];
    for (int i = 0; i < N; i++)
    {
        Random rnd = new Random();
        int RandomSymbolNumber = rnd.Next(1, MaxSymbolCountUser);
        InputArray[i] = CreateRandomString(RandomSymbolNumber);
    }
    return InputArray;
}

string CreateRandomString(int MaxSymbol)
{
    string[] SymbolArray = new string[] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","1","2","3","4","5","6","7","8","9","0"};
    string Result = "";
    for (int i = 0; i < MaxSymbol; i++)
    {
        Random rnd = new Random();
        Result = Result + SymbolArray[rnd.Next(0,35)];
    }
    return Result;
}

int CertainElementCounter(string[]array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            result++;
    }
    return result;
}

string[] FillArrayWithCertainElements(string[]InitialArray, string[]ResultArray)
{
    int j = 0;
    for (int i = 0; i < InitialArray.Length; i++)
    {
        if(InitialArray[i].Length <= 3)
        {
            ResultArray[j] = InitialArray[i];
            j++;
        }
    }
    return ResultArray;
}

string DemonstrateArray(string[] array)
{
    string S = "[";
    if (array.Length == 0)
    {
        S = S + "]";
    }
    else
    {
        for(int i = 0; i < array.Length; i++)
        {
            if(i == 0)
                {
                    S = S + " " + array[i];
                }
                else
                {
                    S = S + ", " + array[i];
                }
        }
        S = S + " ]";
    }
    return(S);
}



Console.WriteLine("Hello, <User_name>, this program is supposed to help you to create a new single-dimensional array of string type elements from the existing single-dimensional one.");
Console.WriteLine("Oh, one more thing - it will filter out all elements that contain more than 3 symbols.");
Console.WriteLine("Do you want to input array manually? Y/N");
string Decision = Console.ReadLine();
if(Decision == "Y" || Decision == "y")
{
    Console.Write("Input array length: ");
    int Size = Convert.ToInt32(Console.ReadLine());
    string[]MyArray = CreateUserStringArray(Size);
    int Total = CertainElementCounter(MyArray);
    Console.WriteLine($"Total number of elements that are '<=' than 3 is {Total}");
    string[]MyFinalArray = new string[Total];
    Console.WriteLine($"Your initial array is {DemonstrateArray(MyArray)}");
    Console.WriteLine($"Your final array is {DemonstrateArray(FillArrayWithCertainElements(MyArray,MyFinalArray))}");
}
else
{
    if(Decision == "N" || Decision == "n")
    {
        Console.Write("Input array length: ");
        int Size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input max length of an element: ");
        int MaxElementSize = Convert.ToInt32(Console.ReadLine());
        string[]MyArray = CreateRandomStringArray(Size, MaxElementSize); 
        int Total = CertainElementCounter(MyArray);
        Console.WriteLine($"Total number of elements that are '<=' than 3 is {Total}");
        string[]MyFinalArray = new string[Total];
        Console.WriteLine($"Your initial array is {DemonstrateArray(MyArray)}");
        Console.WriteLine($"Your final array is {DemonstrateArray(FillArrayWithCertainElements(MyArray,MyFinalArray))}");
    }
    else
    {
        Console.WriteLine("Incorrect input.");
    }
}
