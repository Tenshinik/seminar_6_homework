/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Ввод чисел");
string ? input = Console.ReadLine();
var result = input.Split(','); 
List<int> int_result = new();
for(int i = 0; i < result.Length; i++)
{
    int_result.Add(Convert.ToInt32(result[i]));
} 
int num = 0;
for(int i = 0; i < int_result.Count; i++)
{
    if(int_result[i] > 0)
    {
        num++;
    }
}
Console.WriteLine(num);   


    