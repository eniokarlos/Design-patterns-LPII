namespace Observer
{
    public interface IOberver
    {
        String _Nome {get;set;}
        void Update(Object sender, MessageArgs e);
    }
}