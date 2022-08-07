using System;
namespace dayTwoExerciseB
{
    public class QuestionB6
    {
        public static void BSix()
        {
            //questionB6
            Console.Write("Enter for X_One_Coordinates: ");
            int inputXone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter for Y_One_Coordinates: ");
            int inputYone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter for X_Two_Coordinates: ");
            int inputXtwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter for Y_Two_Coordinates: ");
            int inputYtwo = Convert.ToInt32(Console.ReadLine());
            int XCoordinates = (inputXtwo - inputXone) * (inputXtwo - inputXone);
            int YCoordinates = (inputYtwo - inputYone) * (inputYtwo - inputYone);
            double result = System.Math.Sqrt(XCoordinates + YCoordinates);
            Console.Write($"Distance: {result:0.############}");
        }
    }
}
