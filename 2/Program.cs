Console.Write("Введите число: ");
long a = Convert.ToInt64(Console.ReadLine());
long c = a / 100;
if(c == 0){         
    Console.WriteLine("В разряде сотен - ноль");
}
else if (c > 10){
    c = c % 10;
    Console.WriteLine($"Цифра в разряде сотен равна {c}");  
}
else {
    Console.WriteLine($"Цифра в разряде сотен равна {c}");
}