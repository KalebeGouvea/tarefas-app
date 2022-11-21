# TarefasMVC - Gerenciador de tarefas
### Descrição do projeto

O TarefasMVC é um aplicativo web desenvolvido em ASP.NET Core MVC, com funcionalidades CRUD, destinado a criação e organização de tarefas do usuário, similar ao Google Tarefas, de maneira simplificada.
O projeto foi criado com o objetivo de explorar e desenvolver minhas habilidades em ASP.NET e C#.
Ele encontra-se integrado com o SQL Server e utiliza o Entity Framework para trabalhar com o banco de dados.
No front-end foi utilizado HTML, CSS e o framework Bootstrap, embora ainda não totalmente responsivo, sendo melhor visualizado em desktop.

### Funcionalidades:

- Organiza as tarefas em A Concluir e Concluídas
- Adicionar, visualizar, editar e apagar tarefas

### Requisitos para rodar:
- .NET 6.0
- Entity Framework Core
- SQL Server 2019

### Como rodar:
Instale o .NET 6.0 SDK diretamente da página da Microsoft:
```
https://dotnet.microsoft.com/en-us/download/dotnet/6.0
```
Instale o Entity Framework Core pelo CLI do .NET no terminal:
```
dotnet tool install --global dotnet-ef
```
Com o SQL Server 2019 instalado e rodando, a Autenticação do Windows precisa estar habilitada e o nome do servidor precisa estar definido conforme abaixo:
```
localhost\sqlexpress
```
Caso contrário, a conexão precisa ser alterada no arquivo appsettings.Development.json

No terminal, clone o projeto:
```
git clone https://github.com/KalebeGouvea/tarefas-app.git
```
Acesse a pasta do projeto, rode o seguinte comando e o projeto deve ser aberto no navegador em seguida:
```
dotnet watch run
```
