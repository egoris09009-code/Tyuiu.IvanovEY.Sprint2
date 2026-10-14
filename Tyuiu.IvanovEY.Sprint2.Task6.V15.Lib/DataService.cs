using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovEY.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int dayNumber = ((k - 1) % 7) + 1;

            return dayNumber switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Ошибка"
            };
        }
    }
}
