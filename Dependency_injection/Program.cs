using System;
public class main
{
    static void Main(){
        Cadastro c = new Cadastro();
        IEnviar usuario1 = new Sms();
        IEnviar usuario2 = new Email();
        IEnviar usuario3 = new Mensagem();
        c.novoUsuario(usuario1);
        c.novoUsuario(usuario2);
        c.novoUsuario(usuario3);
        c.executar();
    }
}