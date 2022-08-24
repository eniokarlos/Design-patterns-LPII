public class ChoiceType: IType
{
    private string[] choices{get;set;} = new string[3];

    public ChoiceType(string arg1, string arg2, string arg3){
        this.choices[0] = arg1;
        this.choices[1] = arg2;
        this.choices[2] = arg3;
    }

    public string execute(){
        return String.Format("Alternativas:\nA: {0}\nB: {1}\nC: {2}", this.choices[0], this.choices[1], this.choices[2]);
    }
}