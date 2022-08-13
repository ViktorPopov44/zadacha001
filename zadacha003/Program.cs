Console.Write("Введи номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("нет столько дней в неделе");
  }
  else Console.WriteLine("не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);
