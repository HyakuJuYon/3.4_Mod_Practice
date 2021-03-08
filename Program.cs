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

            Semaphore GoGoGo;

            GoGoGo = Semaphore.Green;

            Console.WriteLine(GoGoGo);
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
    enum Semaphore : ushort 
            {
            Red = 100,
            Yellow = 200,
            Green = 300
            }
}
