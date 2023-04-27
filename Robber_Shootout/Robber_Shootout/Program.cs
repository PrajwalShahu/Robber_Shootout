Console.WriteLine("Enter No of robbers: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the robber with whom sam will start shooting: ");
int Start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the gap between robbers: ");
int gap = Convert.ToInt32(Console.ReadLine());

int[] robbers = new int[n];
int Target = Start - 1;
int ShotsTaken = 0;

for (int i = 0; i < n; i++)
{
    robbers[i] = i + 1;
}


while (n != 0)
{
    if (Target >= n)
    {
        Target = Target % n;
    }

    Console.WriteLine($"Target = {robbers[Target]} , {++ShotsTaken} shots completed");

    for (int i = Target; i < n - 1; i++)
    {
        robbers[i] = robbers[i + 1];
    }
    n--;
    Target += gap;
}

Console.WriteLine(ShotsTaken + " shots taken");