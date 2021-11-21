// 30. Показать кубы чисел, заканчивающихся на четную цифру (не понятно каких чисел/Пусть будут от 1 до N)

// Status: решено

void EvenCube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        int lastNumber = i % 10;
        if (lastNumber % 2 == 0 && lastNumber != 0) 
        {
        System.Console.WriteLine($"Число {i} заканчивается на четную цифру {lastNumber}, {i}^3 = {i*i*i}");
        }
    }
}

EvenCube(25);