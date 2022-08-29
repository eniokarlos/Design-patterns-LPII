public class TextType: IType
{
    private string text;

    public TextType(string text){
        this.text = text;
    }
    public void execute(){
        Console.WriteLine(text);
    }

    public string Text
    {
        get{return this.text;}
        set{this.text = value;}
    }
}
