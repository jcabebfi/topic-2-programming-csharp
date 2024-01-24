namespace topic_2_programming_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LEGAL_DRINKING_AGE = 21;

            string? name;
            int age;
            double height;

            Console.WriteLine("Welcome to your Personal Information System");

            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            //age validation
            if (age < 0)
                Console.WriteLine("Error: Age must be positive.");

            Console.WriteLine("Please enter your height in meters:");
            height = Convert.ToDouble(Console.ReadLine());

            //height validation
            if (height < 0)
                Console.WriteLine("Error: Height must be positive.");

            Console.WriteLine($@"------------------------
Your Personal Details:
Name: {name}
Age: {age}
Height: {height} meters");
            //conversion
            double doubleAge = Convert.ToDouble(age);
            int roundedHeight = Convert.ToInt32(height);
            
            //check if user is a minor or adult
            if (doubleAge >= 18)
                Console.WriteLine("Age Check:\nYou are an adult.\n");
            else
                Console.WriteLine("Age Check:\nYou are a minor.\n");

            if (doubleAge >= LEGAL_DRINKING_AGE)
                Console.WriteLine("Legal Drinking Age Verification:\nYou are legally allowed to drink.\n");
            else
                Console.WriteLine("Legal Drinking Age Verification:\nSorry, you are underage for drinking.\n");

            string personalInfo = $"Personal Details Presentation: {name}, {age}, {height} meters tall.\n";
            Console.WriteLine($@"{personalInfo}
------------------------
Thank you for using Your Personal Information System!");
        }
    }
}
