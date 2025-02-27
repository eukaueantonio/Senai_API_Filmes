# 🎬 MovieAPI - Gerenciador de Filmes e Gêneros

Bem-vindo ao **MovieAPI**, um projeto de API simples para cadastro e gerenciamento de filmes e gêneros. 🚀

## 📌 Funcionalidades

- 📌 **CRUD de Gêneros**: Criar, listar, atualizar e deletar gêneros.
- 🎞️ **CRUD de Filmes**: Criar, listar, atualizar e deletar filmes associados a um gênero.
- 🔗 **Relacionamento**: Cada filme pertence a um gênero.

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: [Nome da linguagem] (ex: Python, JavaScript)
- **Framework**: [Nome do framework] (ex: FastAPI, Express.js)
- **Banco de Dados**: [Banco usado] (ex: PostgreSQL, MySQL, MongoDB)
- **ORM (se usado)**: (ex: SQLAlchemy, Prisma)
- **Ferramentas Auxiliares**: (ex: Docker, Postman)

## 🚀 Como Rodar o Projeto

1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/seu-repositorio.git
   ```
2. Entre na pasta do projeto:
   ```sh
   cd movieapi
   ```
3. Instale as dependências:
   ```sh
   [Comando para instalar dependências] (ex: npm install, pip install -r requirements.txt)
   ```
4. Configure o banco de dados e as variáveis de ambiente:
   ```sh
   [Instruções para configurar .env]
   ```
5. Rode a API:
   ```sh
   [Comando para rodar a API] (ex: npm start, uvicorn main:app --reload)
   ```
6. Acesse a documentação interativa (se houver):
   - [http://localhost:porta/docs](http://localhost:porta/docs) (Exemplo: Swagger)

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

## 📄 Estrutura do Projeto

```
/movieapi
│-- src/
│   ├── models/
│   ├── routes/
│   ├── controllers/
│   ├── database/
│-- tests/
│-- README.md
│-- .env.example
│-- requirements.txt / package.json
```

## 🤝 Contribuindo

Sinta-se à vontade para abrir issues e pull requests!
