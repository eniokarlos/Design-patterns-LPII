public interface AnswerFactory{

    static Question create(
        string text,
        HashSet<string> options,
        Question.Levels level){

            return new Question(text,new ChoiceType(options), level);
    }

    static Question create(
        string text,
        string answer,
        Question.Levels level){

            return new Question(text, new TextType(answer), level);
    }

}