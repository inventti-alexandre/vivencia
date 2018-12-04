using Software.Basico.DB.Base;
using Software.Basico.DB.Estoque;
using System;
using System.Collections.Generic;

namespace Software.Basico.DB.Livros
{
    class LivroBusiness
    {
        LivroDatabase db = new LivroDatabase();

        public void CadastrarLivro(tb_livro dto)
        {
            if (dto.ds_idioma == string.Empty)
                throw new ArgumentException("O idioma é obrigatório!");

            if (dto.ds_tipo == string.Empty)
                throw new ArgumentException("O tipo é obrigatório!");

            if (dto.ds_titulo == string.Empty)
                throw new ArgumentException("O título é obrigatório!");

            if (dto.nm_editora == string.Empty)
                throw new ArgumentException("A editora é obrigatório!");

            if (dto.nu_volume == 0)
                throw new ArgumentException("O volume está incorreto!");

            if (qntLivro == 0)
                throw new ArgumentException("Deve ser adicionado pelo menos 1 livro!");

            db.CadastrarLivro(dto);
        }

        public void AlterarLivro(tb_livro dto, int idLivro)
        {
            if (dto.ds_idioma == string.Empty)
                throw new ArgumentException("O idioma é obrigatório!");

            if (dto.ds_tipo == string.Empty)
                throw new ArgumentException("O tipo é obrigatório!");

            if (dto.ds_titulo == string.Empty)
                throw new ArgumentException("O título é obrigatório!");

            if (dto.nm_editora == string.Empty)
                throw new ArgumentException("A editora é obrigatório!");

            if (dto.nu_volume == 0)
                throw new ArgumentException("O volume está incorreto!");

            db.AlterarLivro(dto, idLivro);
        }

        public void RemoverLivro(int idLivro)
        {
            db.RemoverLivro(idLivro);
        }

        public List<tb_livro> ListarLivros()
        {
            return db.ListarLivros();
        }

        public List<vw_Livro_Autor_Genero> ListarViewLivros(string titulo, string autor, string palavra)
        {
            List<vw_Livro_Autor_Genero> livros = new List<vw_Livro_Autor_Genero>();

            //Sem filtro
            if (titulo == string.Empty && autor == string.Empty && palavra == string.Empty)
                livros = db.ListarViewLivros();
            
            //Filtrar por titulo
            else if (titulo.Length > 0 && autor == string.Empty && palavra == string.Empty)
                livros = db.ListarFiltroTitulo(titulo);

            //Filtrar por autor
            else if (titulo == string.Empty && autor.Length > 0 && palavra == string.Empty)
                livros = db.ListarFiltroAutor(autor);

            //Filtrar por Palavras Chaves
            else if (titulo == string.Empty && autor == string.Empty && palavra.Length > 0)
                livros = db.ListarFiltroPalavraChaves(palavra);
            
            //Filtrar por Titulo e Autor
            else if (titulo.Length > 0 && autor.Length > 0 && palavra == string.Empty)
                livros = db.ListarFiltroTituloAutor(titulo, autor);

            //Filtrar por Titulo e Palavras Chaves
            else if (titulo.Length > 0 && autor == string.Empty && palavra.Length > 0)
                livros = db.ListarFiltroTituloPalavra(titulo, palavra);

            //Filtrar por Autor e Palavras Chaves
            else if (titulo == string.Empty && autor.Length > 0 && palavra.Length > 0)
                livros = db.ListarFiltroAutorPalavra(autor, palavra);
            
            //Filtrar por Titulo, Autor e Palavras Chaves
            else if (titulo.Length > 0 && autor.Length > 0 && palavra.Length > 0)
                livros = db.ListarFiltroTituloAutorPalavra(titulo, autor, palavra);

            return livros;
        }

        public vw_Livro_Autor_Genero ListarLivroPorId(int idLivro)
        {
            return db.ListarLivroPorId(idLivro);
        }
    }
}
