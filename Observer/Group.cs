namespace Observer
{
    public class Group : ISubject
    {
        private String nome;
        public event EventHandler<MessageArgs>? MessageChange;
        
        public Group(string nome)
        {
            this.nome = nome;
        }

        public void SendMessage(string message)
        {
            Notify(new MessageArgs{Nome = nome, Message = message});
        }

        public void Notify(MessageArgs e)
        {
            System.Console.WriteLine("\nSending Message...\n");
            if(MessageChange != null)
            {
                MessageChange(this, e);
            }
        }

        public void subscribe(IOberver observer)
        {
            System.Console.WriteLine($"\n{observer._Nome} entrou no grupo: {this.nome}\n");
            MessageChange += observer.Update!;
        }

        public void Unsubscribe(IOberver observer)
        {
            System.Console.WriteLine($"\n{observer._Nome} saiu no grupo: {this.nome}\n");
            MessageChange -= observer.Update!;
        }
    }
}