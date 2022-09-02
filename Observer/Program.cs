namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var SchoolGroup = new Group("School Group");
            var WorkGroup = new Group("Work Group");
            var User1 = new User("John");
            var User2 = new User("Mary");
            var User3 = new User("Elizabeth");

            SchoolGroup.subscribe(User1);
            SchoolGroup.subscribe(User2);
            WorkGroup.subscribe(User3);

            SchoolGroup.SendMessage("Hi! Teacher has come in Monday"); 
            WorkGroup.SendMessage("Time To Work!");

            SchoolGroup.Unsubscribe(User2);
            SchoolGroup.SendMessage("Vacation!!!");
        }
    }
}