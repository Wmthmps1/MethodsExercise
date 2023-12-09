namespace MethodsExercise
{
    public class Program
    {

        public static int Add(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int Multiply(params int[] numbers)
        {
            int product = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                product += numbers[i];
            }
            return product;
        }


        
        static void Main(string[] args)
        {
            var addedNumbers = Add(4, 2);
            var multipliedNumbers = Multiply(8, 5, 4, 3);
            Console.WriteLine(addedNumbers);
            Console.WriteLine(multipliedNumbers);



            // Exercise 1
            Console.WriteLine("Time for a fun story:");
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("What would your ideal superhero suffix be? For example: the suffix for Spiderman would be man.");
            var suffix = Console.ReadLine();
            Console.WriteLine("Enter your favorite animal: ");
            var favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Enter your least favorite animal: ");
            var leastFavAnimal = Console.ReadLine();
            Console.WriteLine("What superpower would you like to have? ");
            var superpower = Console.ReadLine();
            string superheroName = String.Join("", favoriteAnimal, suffix);
            string villain = String.Join(" ", "Dr.", leastFavAnimal);


            Console.WriteLine($"One day, {name} was out in the woods and was attacked by a radioactive {favoriteAnimal}." +
                $" {name} passed out, but woke up the next day to discover they had superpowers. {name} was now {superheroName}!" +
                $" {superheroName} was out on the town when there was an attack. They looked up only to see {villain}." +
                $" {superheroName} has to stop {villain}! So, using the power of {superpower}, {superheroName} was able to save the day!");
        }

    }
}
