public class Menu
{
    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Statistics");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;

                case 3:
                    ShowStatistics();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine();
        }
    }

    private void AddStudent()
    {
        Console.WriteLine("Add Student selected.");
        // Code for adding student here
    }

    private void ViewStudents()
    {
        Console.WriteLine("View Students selected.");
        // Code for viewing students here
    }

    private void ShowStatistics()
    {
        Console.WriteLine("Statistics selected.");
        // Code for statistics here
    }
}