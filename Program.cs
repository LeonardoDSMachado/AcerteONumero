Console.WriteLine("##Advinhe o número de 1 a 100##\n");

int numAle = Random.Shared.Next(1,100);

for (int i = 1; i < 6; i++)
{
    Console.WriteLine($"Digite sua tentativa n°{i}");
    int chute = Convert.ToInt32(Console.ReadLine());
        if (chute > numAle && i<5)
        {
            Console.WriteLine("Seu chute é maior do que o número sorteado...");
        }
        else if (chute < numAle && i<5)
        {
            Console.WriteLine("Seu chute é menor que o número sorteado...");
        }
        else if (chute != numAle && i==5)
        {
            Console.WriteLine("Você perdeu...");
        }
        else 
        {
            Console.WriteLine("Parabéns! Você acertou!");
            i = 7;
        }
}

Console.ReadKey();



