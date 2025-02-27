﻿using API_Filmes_SENAI.Domains;

namespace API_Filmes_SENAI.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme novoFilme);

        List<Filme> Listar();

        void Atualizar(Guid id, Filme filme);

        void Deletar (Guid id);

        Filme BuscarPorId(Guid id);

        List<Filme> ListarPorGenero(Guid idGenero);
    }
}
