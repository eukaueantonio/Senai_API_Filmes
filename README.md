# 🎬 MovieAPI - Gerenciador de Filmes e Gêneros

Bem-vindo ao **MovieAPI**, um projeto de API simples para cadastro e gerenciamento de filmes e gêneros. 🚀

## 📌 Funcionalidades

- 📌 **CRUD de Gêneros**: Criar, listar, atualizar e deletar gêneros.
- 🎞️ **CRUD de Filmes**: Criar, listar, atualizar e deletar filmes associados a um gênero.
- 🔗 **Relacionamento**: Cada filme pertence a um gênero.

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C# e SQL
- **Framework**: ASP.NET Core e Entity Framework Core (EF Core)
- **Banco de Dados**: SQL Server
- **ORM**: Entity Framework Core (EF Core)
- **Ferramentas Auxiliares**: Postman

## 🚀 Como Rodar o Projeto

1. Clone o repositório:
   ```sh
   git clone https://github.com/eukaueantonio/Senai_API_Filmes.git
   ```
2. Abra o Visual Studio Community e acesse o projeto ou uma solução

## 🔥 Exemplos de Rotas

### 🎬 Filmes

- **Criar Filme**
  ```json
  POST /filmes
  {
    "titulo": "Inception",
    "genero_id": 1
  }
  ```

- **Listar Filmes**
  ```sh
  GET /filmes
  ```

### 📌 Gêneros

- **Criar Gênero**
  ```json
  POST /generos
  {
    "nome": "Ação"
  }
  ```

- **Listar Gêneros**
  ```sh
  GET /generos
  ```


## 🤝 Contribuindo

Sinta-se à vontade para abrir issues e pull requests!
