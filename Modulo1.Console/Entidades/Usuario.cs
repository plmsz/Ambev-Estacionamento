﻿namespace Modulo1.Console.Entidades
{
    internal class Usuario
    {
        public int Id { get; private set; }
        public string Senha { get; private set; }
        public string Login { get; private set; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        public TipoUsuario TipoUsuario { get; set; }

        public static Usuario NovoUsuario(string senha, string login, string nome, TipoUsuario tipoUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.Senha = senha;
            usuario.Login = login;
            usuario.Nome = nome;
            usuario.Ativo = true;
            usuario.TipoUsuario = tipoUsuario;

            return usuario;
        }

        public static Usuario UsuarioParaLog(string login, string nome)
        {
            Usuario usuario = new Usuario();
            usuario.Login = login;
            usuario.Nome = nome;

            return usuario;
        }

        public void AlterarSenha(string senha)
        {
            Senha = senha;
        }
    }
}