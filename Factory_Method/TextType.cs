public class TextType: IType
{
    private string text {get;set;}

    public TextType(string text){
        this.text = text;
    }
    public string execute(){
        return "Resposta: "+ this.text;
    }
}
