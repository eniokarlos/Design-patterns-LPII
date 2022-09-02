namespace Observer
{
    public class User : IOberver
    {
        public String _Nome{get;set;}

        public User(string nome)
        {
            this._Nome = nome;
        }

        public void Update(Object sender, MessageArgs e)
        {
            System.Console.WriteLine($"\nMenssage recieved from: {e.Nome};\n{e.Message}\n"
            +$"Observer: {this._Nome}");
        }
    }
}