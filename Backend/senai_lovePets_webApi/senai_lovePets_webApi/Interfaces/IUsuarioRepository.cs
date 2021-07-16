﻿using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IUsuarioRepository
    {

        List<Usuario> Listar();

        Usuario BuscarPorId(int idUsuario);

        void Cadastrar(Usuario usuarioCadastrado);

        void Atualizar(int idUsuario, Usuario usuarioAtualizado);

        void Deletar(int idUsuario);

        Usuario Login(string Email, string Senha);
    }
}
