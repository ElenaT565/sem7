// Задача 47

Console.WriteLine("Колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Колличество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, -5, 15);
PrintArray(array);


 

 //Задача 52

/*Console.WriteLine("Колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Колличество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 1, 9);
PrintArray(array);

double summ = 0;
for (int j = 0; j < array.GetLength(1) ; j++){
    for(int i = 0; i < array.GetLength(0); i++){
               summ += array[i,j];
     }
double summ1 = summ / array.GetLength(0);
Console.WriteLine($"Среднее арифм. по столбцу = {summ1:f2}"); 
summ = 0;
}*/




 // Задача 50

/*Console.WriteLine("Колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Колличество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 1, 9);
PrintArray(array);


for (int i = 0; i < array.GetLength(0) ; i++){
    for(int j = 0; j < array.GetLength(0); j++){
             
}
Console.WriteLine("Введите номер строки ");
        int a = int.Parse(Console.ReadLine()!);
   
        Console.WriteLine("Введите номер столбца: ");
        int b = int.Parse(Console.ReadLine()!);
    
    if (a <= array.GetLength(0) && b <= array.GetLength(1))
        Console.WriteLine($"элемент в массиве = {array[a,b]}");
    else
        Console.WriteLine("такого элемента нет");  
}*/


int[,] GetArray(int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

 void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
 }