using System;
class Cadastro
{
    private List<IEnviar> usuarios = new List<IEnviar>();

    public void novoUsuario(IEnviar user){
        usuarios.Add(user);
    }

    public void executar(){
        foreach(var usuario in usuarios){
            usuario.enviar();
        }
    }
}