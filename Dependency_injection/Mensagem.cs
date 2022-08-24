using System;
class Mensagem : IEnviar
{
    void IEnviar.enviar()
    {
        Console.WriteLine("Mensagem enviada com sucesso!");
    }
}