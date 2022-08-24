public class AnswerFactory{
    public static IType ofText(string text){
        return new TextType(text);
    }
    public static IType ofChoice(string arg1, string arg2, string arg3){
        return new ChoiceType(arg1, arg2, arg3);
    }
}