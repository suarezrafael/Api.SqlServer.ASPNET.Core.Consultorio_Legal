# Api.Consultorio

## Resumo
Web API ASP NET Core 3.1, localdb MSSQL , Swagger, EF Core, Fluent Validation, Auto Mapper, Validações personalizadas, Relacionamento UM x Um, Um x MUITOS, Muitos x Muitos, Enum e Testes Unitários XUnit. 

1. - Estrutura - 15 min
1. - Swagger - EF Core - Migrations - 47 min
1. - Repository - 30 min  
1. - Post, Put, Delete - 28 min
1. - Fluent Validation - 26 min
1. - AutoMapper - 45 min
1. - Organizando Startup - 15 min
1. - Swagger - 32 min
1. - Swagger + FluentValidation - 11 min
1. - EF Core - Garantindo integridade estrutural(No startup contexto.Migrate()) - 16 min
1. - Logs - 68 min
1. - Gerenciamento de erros - 29 min
1. - EF Core - Fluent API - 18 min
1. - EF Core - Relacionamento Um para UM - 33 min
1. - EF Core - Relacionamento Um para Muitos - 23 min
1. - EF Core - Relacionamento Muitos para Muitos - 35 min
1. - Validação personalizada -40+ 22 min
1. - Enum - 20 min
1. - Testes unitários controller - XUnit, FluenteAssertions, NSubstitute, Bogus - 60 min
1. - Testes unitários controller parte 2 - XUnit, FluenteAssertions, NSubstitute, Bogus - 40 min
1. - Testes unitários repositório parte 3 - InMemoryDatabase - 51 min
1. - Armazenando senhas de forma segura com AspNetCore Identity - 30 min
1. - Autenticação e autorização com JWT - 72 min
1. - Migrando o DotNet do 3.1 para 6.0 - 18 min
1. - Implementando filed scope namespaces e global usings - 15 min

## Como executar

1. Clone o projeto  
1. Instalando o LocalDb no computador de desenvolvimento
Quando fazemos uma instalação padrão do Visual Studio utilizando as workloads para desenvolvimento desktop ou web, o LocalDb será instalado no mesmo bolo. Se você der uma olhada na parte de “Individual components“, você perceberá que o item “SQL Server Express  LocalDb” foi marcado automaticamente
1. Caso você não tenha certeza, abra o setup do Visual Studio e veja se essa opção está marcada no seu ambiente. Se ela estiver marcada, isso significa que o LocalDb já está instalado no seu computador de desenvolvimento e está pronto para ser utilizado. Caso contrário, marque essa opção para que você possa utilizar o LocalDb durante a aplicação.
1. A instalação padrão do LocalDb criará uma instância chamada “MSSQLLocalDB“. Você pode listar as instâncias do LocalDb em um prompt utilizando o comando “sqllocaldb info".
1. Rode o projeto. o banco de dados será criado automaticamente.

### Bibliotecas utilizadas
- automapper	 
- automapper.extensions.microsoft.dependencyinjection
- FluentValidation.AspNetCore
- MicroElements.Swashbuckle.FluentValidation
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design   
- Microsoft.EntityFrameworkCore.SqlServer 
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Azure.Containers.Tools.Targets
- Serilog.AspNetCore
- Serilog.Exceptions
- Serilog.Formatting.Compact
- Serilog.Settings.COnfiguration
- Serilog.Sinks.Async
- Serilog.Sinks.File
- SerilogTImings
- Swashbuckle.AspNetCore



