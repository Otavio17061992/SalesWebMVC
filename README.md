
# SalesWebMVC

SalesWebMVC é uma aplicação web desenvolvida em C# utilizando o framework ASP.NET MVC. Esta aplicação permite gerenciar vendedores, vendas e departamentos, oferecendo funcionalidades de CRUD (Create, Read, Update, Delete) com integração ao banco de dados MySQL.

## Funcionalidades

- Gerenciamento de Vendedores
  - Adicionar, editar, visualizar e excluir vendedores
- Gerenciamento de Vendas
  - Adicionar, editar, visualizar e excluir vendas
- Gerenciamento de Departamentos
  - Adicionar, editar, visualizar e excluir departamentos
- Pesquisa simples e avançada
- Relatórios de vendas

## Tecnologias Utilizadas

- C#
- ASP.NET MVC
- MySQL
- Entity Framework
- Bootstrap (para o design responsivo)
- HTML/CSS/JavaScript

## Requisitos

- .NET Framework 4.7.2 ou superior
- MySQL Server
- Visual Studio 2019 ou superior

## Configuração do Ambiente

1. Clone o repositório para sua máquina local:
   ```bash
   git clone https://github.com/Otavio17061992/SalesWebMVC.git
   ```

2. Abra o projeto no Visual Studio.

3. Configure a string de conexão com o banco de dados MySQL no arquivo `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=saleswebmvc;User=root;Password=yourpassword;"
     }
   }
   ```

4. Execute as migrações do Entity Framework para criar o banco de dados:
   ```bash
   Update-Database
   ```

5. Execute a aplicação:
   ```bash
   dotnet run
   ```

## Estrutura do Projeto

- `Controllers`: Contém os controladores da aplicação.
- `Models`: Contém as classes de modelo que representam as entidades do banco de dados.
- `Views`: Contém as views da aplicação.
- `wwwroot`: Contém arquivos estáticos como CSS, JavaScript e imagens.

## Contribuição

Se você deseja contribuir com este projeto, siga os passos abaixo:

1. Faça um fork do repositório.
2. Crie uma nova branch:
   ```bash
   git checkout -b minha-nova-funcionalidade
   ```
3. Faça suas alterações e commit:
   ```bash
   git commit -m "Adiciona nova funcionalidade"
   ```
4. Envie para o repositório remoto:
   ```bash
   git push origin minha-nova-funcionalidade
   ```
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](https://github.com/Otavio17061992/SalesWebMVC) para mais detalhes.

---
