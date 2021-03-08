using System;

namespace _3._4_Mod_Pract
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Thursday;

            Console.WriteLine(MyFavoriteDay);
        }
    }
    enum DaysOfWeek : byte 
            {
                Sunday = 1,
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday
            }
}
