int myInt = 10;
double myDouble = 5.25;
bool myBool = true;


Console.WriteLine("Enter the number");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("My number is " + input);

Console.WriteLine("Enter the number");
int inputNum = int.Parse(Console.ReadLine());
Console.WriteLine("My number is " + inputNum);

string nullString = null;
int result = int.Parse((nullString));
Console.WriteLine(result);


Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
