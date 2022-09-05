Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int d = a % 100-a % 10;
if(d == 0){
Console.WriteLine(d);
}
else{
int c = d / 10;
Console.WriteLine(c);
}