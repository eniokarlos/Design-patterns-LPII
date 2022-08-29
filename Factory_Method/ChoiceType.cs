public class ChoiceType: IType
{
    private HashSet<string> choices = new HashSet<string>();

    public ChoiceType(HashSet<string> choices){
        this.choices = choices;
        validade();
    }

    public HashSet<string> Choices{
        get{return this.choices;}
        set{this.choices = value; validade();}
    }

    public void validade(){
        if(choices.Count != 3){
            throw new ArgumentException("O número de alternativas deve ser igual a tres");
        }
    }

    public void execute(){
        foreach(var val in choices)
        {
            Console.WriteLine(val);
        }
    }
}