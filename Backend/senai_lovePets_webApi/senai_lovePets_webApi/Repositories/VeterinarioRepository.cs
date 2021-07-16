﻿using senai_lovePets_webApi.Context;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class VeterinarioRepository : IVeterinarioRepository
    {

        lovePetsContext ctx = new lovePetsContext();
        public void Atualizar(int idVeterinario, Veterinario veterinarioAtualizado)
        {
            Veterinario veterinarioBuscado = BuscarPorId(idVeterinario);

            if (veterinarioAtualizado.NomeVeterinario != null)
            {
                veterinarioBuscado.NomeVeterinario = veterinarioAtualizado.NomeVeterinario;
            }

            ctx.Veterinarios.Update(veterinarioBuscado);

            ctx.SaveChanges();
        }

        public Veterinario BuscarPorId(int idVeterinario)
        {
            return ctx.Veterinarios.Find(idVeterinario);
        }

        public void Cadastrar(Veterinario veterinarioCadastrado)
        {
            ctx.Veterinarios.Add(veterinarioCadastrado);

            ctx.SaveChanges();
        }

        public void Deletar(int IdVeterinario)
        {
            ctx.Veterinarios.Remove(BuscarPorId(IdVeterinario));

            ctx.SaveChanges();
        }

        public List<Veterinario> List()
        {
            return ctx.Veterinarios.ToList();
        }
    }
}
