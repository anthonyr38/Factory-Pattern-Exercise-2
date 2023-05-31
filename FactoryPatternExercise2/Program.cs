namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What db woud you like to use? ('SQL', 'Mongo', or 'list'?");
            var dbType = Console.ReadLine();

            var dataAccess = DataAccessFactory.GetDatabase(dbType);

            List<Product> products = dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
