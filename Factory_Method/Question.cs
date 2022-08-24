public class Question
{
    private string id {get; set;}
    private string text {get; set;}
    private IType type {get;set;}

    private Question(string id, string text, IType type){
        this.id = id;
        this.text = text;
        this.type = type;
    }

    public static Question of(string id, string text, IType type){
        return new Question(id,text,type);
    }

    public string toString(){
        return String.Format("id: {0}\ntext: {1}\n{2}",this.id,this.text,type.execute());
    }
}