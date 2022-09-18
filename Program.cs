Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt16(Console.ReadLine());
if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5 || day == 6 || day == 7) {
  if (day == 1) Console.WriteLine("Введенное число " + day + " соответствует дню недели - ПОНЕДЕЛЬНИК");
  if (day == 2) Console.WriteLine("Введенное число " + day + " соответствует дню недели - ВТОРНИК");
  if (day == 3) Console.WriteLine("Введенное число " + day + " соответствует дню недели - СРЕДА");
  if (day == 4) Console.WriteLine("Введенное число " + day + " соответствует дню недели - ЧЕТВЕРГ");
  if (day == 5) Console.WriteLine("Введенное число " + day + " соответствует дню недели - ПЯТНИЦА");
  if (day == 6) Console.WriteLine("Введенное число " + day + " соответствует дню недели - СУББОТА");
  if (day == 7) Console.WriteLine("Введенное число " + day + " соответствует дню недели - ВОСКРЕСЕНЬЕ");
} else {
  Console.WriteLine("Ошибка: введено не корректное число - " + day + "! Необходимо ввести число в диапазоне от 1 до 7. Перезапустипе программу!");
}
