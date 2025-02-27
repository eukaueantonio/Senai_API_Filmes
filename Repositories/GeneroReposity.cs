using API_Filmes_SENAI.Context;
using API_Filmes_SENAI.Interfaces;
using API_Filmes_SENAI.NovaPasta;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API_Filmes_SENAI.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja, vamos implementar os métodos, toda a lógica dos métodos 
    /// </summary>
    public class GeneroReposity : IGeneroRepository
    {
        /// <summary>
        /// Variável privada e somente leitura que "guarda" os dados do contexto
        /// </summary>
        private readonly Filmes_Context _context;
        /// <summary>
        /// Construtor do repositório
        /// Aqui, toda vez que o construtor for chamado, os dados do contexto estarão disponíveis 
        /// </summary>
        /// <param name="contexto">Dados do contexto</param>
        public GeneroReposity(Filmes_Context contexto)
        {
            _context = contexto;
        }

        public void Atualizar(Guid id, Genero genero)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null) 
                { 
                generoBuscado.Nome = genero.Nome;
                }
                
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;

            }
        }

        public Genero BuscarPorId(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                return generoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Método para cadastrar um novo gênero 
        /// </summary>
        /// <param name="novoGenero">objeto gênero a ser cadastrado</param>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo gênero na tabela Generos(BD)
                _context.Genero.Add(novoGenero);

                //Ápos o cadastro, salva as alterações(BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null)
                {
                    _context.Genero.Remove(generoBuscado);
                }

                _context.SaveChanges();

            }
            catch (Exception)
            {


            }
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGeneros = _context.Genero.ToList();

                return listaGeneros;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
