namespace App_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student[] students =
            //{
            //    new Student("Ahmed","112233", 22),
            //    new Student("muhanad","112211", 32),
            //    new Student("mohammed","112211", 10)

            //};

            //Console.WriteLine(Student.validateStudent(students));

            //Task 1
            Console.WriteLine("Task 1");

            BankAccount coustomer = new BankAccount(500);
            Console.WriteLine(coustomer.Withdraw(550));
        }
    }
}