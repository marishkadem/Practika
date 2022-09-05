Console.Write("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a<6) {
    Console.WriteLine("Рабочий день");
}
else if(a>7) {
    Console.WriteLine("В неделе 7 дней");
}
else {
   Console.WriteLine("Выходной"); 
}