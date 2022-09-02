namespace Observer
{
    public interface ISubject
    {
         public void subscribe(IOberver observer);
         public void Unsubscribe(IOberver observer);
         public void Notify(MessageArgs e);
    }
}