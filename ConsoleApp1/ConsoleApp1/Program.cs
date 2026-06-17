while (true)
{
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Statistics");
    Console.WriteLine("4. Exit");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Add Student
            break;

        case 2:
            // View Students
            break;

        case 3:
            // Statistics
            break;

        case 4:
            return;
    }
}