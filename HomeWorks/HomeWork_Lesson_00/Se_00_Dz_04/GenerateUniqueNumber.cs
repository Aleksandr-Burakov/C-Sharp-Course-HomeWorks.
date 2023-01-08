// Размерность массива не играет никакой роли.
// Сверяемся со значениями, которые уже находятся в массиве 
// или сохранять сгенерированные элементы куда-либо,
// например в Hashset<T>, и проверять при последуещей генерации был ли элемент получен ранее.
// Метод генерации с сохранением в HashSet,
// проверяя при последуещей генерации был ли элемент получен ранее 
// будет выглядеть примерно так:


static HashSet<int> numbers = new HashSet<int>();
static Random r = new Random();

public static int GenerateUniqueNumber()
{
    while (true)
    {
        var n = r.Next(0, 1000);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

// Само заполнение Трёхмерного массива будет выглядеть так:

var arr = new int[5,5,5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for (int k = 0; k < 5; k++)
        {
            arr[i, j, k] = GenerateUniqueNumber();
        }
    }
}