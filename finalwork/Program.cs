// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

Console.Clear();
void PrintStrArray(string[] array) 
{
    for(int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
}
 string[] array = {"hello", "2", "world", ":-)"};
 //string[] array = {"1234", "1567", "-2", "computer science"};
 //string[] array = {"Russia", "Denmark", "Kazan"};
int findLength = 3;
string[] newArray = new string[array.Length];
int index = 0;

for(int i = 0; i < array.Length; i++) 
{
    if (array[i].Length <= findLength) 
    {
        newArray[index++] = array[i];
    }
}
PrintStrArray(newArray);