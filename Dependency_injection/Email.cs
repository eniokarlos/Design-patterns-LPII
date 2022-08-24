using System;
class Email : IEnviar
{
    void IEnviar.enviar(){
        Console.WriteLine("Email enviado com sucesso!");
    }
}