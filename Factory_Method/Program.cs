using System;
class Program
{
    static void Main(string[] args)
    {
        var questao1 = AnswerFactory.create(
            "How to create a new c sharp project?",
            new HashSet<string>(){
                "Visual studio",
                "Jetbrains Rider",
                "VS Code"
            },
            Question.Levels.EASY
        );
        
        questao1.Type.execute();

        var questao2 = AnswerFactory.create(
            "How to create a new c sharp project?",
            "VS code is better",
            Question.Levels.MEDIUM
        );

        questao2.Type.execute();
    }
}
