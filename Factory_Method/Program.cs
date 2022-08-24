using System;
class Program
{
    static void Main(string[] args)
    {
        Question q1 = Question.of("1",
        "Quem descobriu o Brasil? Pedro álvares Ca:", 
        AnswerFactory.ofChoice("bral","brel","bril")
        );
        Console.WriteLine(q1.toString());

        Question q2 = Question.of("2",
        "Quem descobriu a América?",
        AnswerFactory.ofText("Cristovão Colombo")
        );
        Console.WriteLine(q2.toString());
    }
}
