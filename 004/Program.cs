// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int a = 1;
while (a<=N)
{
    int b = a * a * a;                          
    int c = b % 10;                             
    if(c % 2 == 0)                              
    {
    Console.WriteLine($"Число {a} в кубе  {b}.");
    }
    a++;

}