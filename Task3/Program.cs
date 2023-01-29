/* Частотный словарь - проверяет как часто встречается элемент в массиве данных*/

int [] array = new int [] {1, 9, 2, 3, 4, 5, 2, 4, 3, 1, 4, 6, 4, 3, 2};

Dictionary<int, int> dic = new Dictionary<int, int>();

for (int i = 0; i < array.Length; i++)
{
    if(dic.ContainsKey(array[i]))
        dic[array[i]] = dic[array[i]] + 1;
    else 
        dic.Add(array[i], 1);
}
foreach (var item in dic.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раз.");
}