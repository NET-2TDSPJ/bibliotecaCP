# Projeto BibliotecaCP - Web API .NET (CP2)

Esse é o nosso trabalho para a disciplina de **Advanced Business Development**. A ideia é uma Web API de sistema de biblioteca feita com .NET e seguindo o padrão de Clean Architecture. 

---

## 👥 Integrantes do Grupo
* **Gabriel Garcia Mayo Delatore** - RM: 563298
* **Vitor Augusto Oliveira de Abreu** - RM: 564227
* **André Bellandi Vital Rodrigues** - RM: 564662

## 🎯 O que o projeto faz (Domínio)
Escolhemos o tema de **Biblioteca**. O sistema serve para controlar o acervo de livros, os cadastros de usuários, os empréstimos e também permite que os usuários deixem um feedback sobre os livros.

## 🏗️ Entidades do Projeto
As classes que a gente criou no Domain (conforme o MER) são:

* **LIVROS:** Guarda título, autor, status, páginas e o ano que foi publicado.
* **USUARIOS:** Nome, e-mail e CPF da galera.
* **EMPRESTIMOS:** Onde a gente registra quando alguém pega ou devolve um livro.
* **CATEGORIAS:** Os gêneros dos livros (Terror, Ficção, etc).
* **FEEDBACKS:** Notas e comentários que os usuários dão pros livros.
* **CATEGORIAS_LIVROS:** Tabela pra ligar os livros com as categorias (N:N).

## 🔑 Identificação (PKs)
Em todas as entidades, a gente usou **ID inteiro (int)** com autoincremento como chave primária.

## 🔗 Relacionamentos
* **Livros e Empréstimos:** Um livro pode ter vários registros de empréstimo.
* **Usuários e Empréstimos:** Um usuário pode pegar vários livros.
* **Livros e Feedbacks:** O pessoal pode deixar vários comentários em um livro.
* **Livros e Categorias:** Um livro pode ter várias categorias e uma categoria pode ter vários livros (tabela intermediária).

## 💾 Banco de Dados (Oracle)
Pra CP2, a gente usou o **Oracle Database** que foi pedido e configurou a connection string certinho pelo Entity Framework Core. 

**Importante:** Por questões de segurança (e pra seguir as regras de não subir segredos), a gente tirou a nossa senha real do `appsettings.json` na hora de dar push pro GitHub. O valor lá ficou como `SUA_SENHA_AQUI`. Pra rodar local e testar no seu banco, tem que colocar a senha certa lá.

## 🚀 Como testar e gerar as tabelas
1. Colocar a senha de conexão correta no `appsettings.json` do projeto `Biblioteca.Api`.
2. Abrir o terminal na raiz do projeto e rodar o comando pra gerar o banco:
   `dotnet ef database update -p Biblioteca.Infrastructure -s Biblioteca.Api`

*(Nota: Os prints comprovando as tabelas já criadas no nosso banco Oracle a gente deixou salvos na pasta `/docs` do repositório).*
