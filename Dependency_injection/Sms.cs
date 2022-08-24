using System;
public class Sms : IEnviar
{
    void IEnviar.enviar(){
        Console.WriteLine("Sms enviado com sucesso!");
    }
}