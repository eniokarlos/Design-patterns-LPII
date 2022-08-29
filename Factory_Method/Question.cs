public class Question
{
    private string text;
    private IType type;
    private Levels level;

    public Question(string text,IType type, Levels level){
        this.text = text;
        this.level = level;
        this.type = type;
    }

    public void update(string text,IType type, Levels level){
        this.text = text;
        this.level = level;
        this.type = type;
    }

    public enum Levels{
        EASY = 25,
        MEDIUM = 50,
        HARD = 75,
        EXPERT = 100
    }

    public string Text{
        get{return this.text;}
    }
    public Levels Level{
        get{return this.Level;}
    }

    public IType Type{
        get{return this.type;}
    }
}