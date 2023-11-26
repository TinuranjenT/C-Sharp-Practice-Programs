//For Loop

for(int i=0; i<5; i++)
{
    Console.WriteLine(i);
}

//While Loop
int j = 5; 
while (j < 10)
{
    Console.WriteLine(j);
    j++;
}

//Do-While Loop
int k = 0;
do
{
    Console.WriteLine(k);
    k++;
}while(k < 5);

//For-each Loop

int[] arr = { 1, 2, 3, 4, 5 };
foreach(int i in arr)
{
    Console.WriteLine(i);
}