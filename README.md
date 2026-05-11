# Teste de Perfomance TP1 - Desenvolvimento Web com .NET e Bases de Dados [26E2_4]

## Ponto de Partida
Neste primeiro Teste de Performance (TP), iremos focar no domínio dos conceitos fundamentais de Delegates, Events e aplicações web com Razor Pages utilizando o framework ASP.NET Core.

Esses temas são essenciais para a construção de sistemas back-end modernos, flexíveis e escaláveis, permitindo que métodos sejam tratados como parâmetros e que aplicações possam reagir a eventos de forma organizada e segura.

Ao longo dos exercícios, você irá aplicar esses conceitos em cenários práticos que simulam demandas reais do mercado de desenvolvimento de sistemas.

### 1 Implementação de Delegate Personalizado para Descontos

Imagine que você está desenvolvendo um módulo de regras de negócio para uma aplicação de vendas online. Esse sistema deve aplicar diferentes políticas de desconto conforme o perfil do cliente. Para isso, é necessário encapsular as regras de cálculo de desconto em uma estrutura reutilizável.

Tarefas:

Crie uma aplicação de console em C#.
Solicite ao usuário que informe o preço original de um produto.
Crie um delegate chamado CalculateDiscount que receba esse valor como decimal e retorne o preço com 10% de desconto aplicado.
Implemente um método compatível com esse delegate.
Utilize o delegate no fluxo da aplicação para calcular e exibir o valor final ao usuário.
Este exercício introduz o uso de delegates personalizados para encapsular lógicas de negócio com alta reutilização e manutenção.

### 2 Ações Multilíngues com Action<string>

Uma aplicação SaaS voltada ao público internacional precisa exibir mensagens de boas-vindas em diferentes idiomas, conforme a configuração do cliente.

Tarefas:

Crie um programa de console em C#.
Solicite ao usuário que escolha um idioma (português, inglês ou espanhol).
Crie uma estrutura com Action<string> para exibir a mensagem de boas-vindas no idioma escolhido.
Implemente ao menos três versões de mensagens encapsuladas nos delegates.
Este exercício mostra como delegates com Action são úteis em interações que envolvem ações sem retorno, como feedback ao usuário.

### 3 Cálculo de Área Utilizando Func

Um sistema de engenharia precisa realizar cálculos de área com base em entradas fornecidas pelo operador.

Tarefas:

Crie um programa de console em C#.
Solicite ao usuário que insira a base e a altura de um retângulo.
Crie um Func<double, double, double> para calcular a área.
Utilize o delegate para exibir o resultado ao final do processo.
Esse exercício demonstra o uso prático do Func como abstração de cálculos com retorno.

### 4 Monitoramento de Temperatura com Evento Personalizado

Sistemas embarcados em ambientes industriais monitoram sensores em tempo real. Uma funcionalidade comum é emitir alertas quando a temperatura ultrapassa o limite seguro.

Tarefas:

Crie uma classe TemperatureSensor com um evento TemperatureExceeded.
Solicite entradas do usuário para simular leituras de temperatura.
Dispare o evento sempre que o valor ultrapassar 100ºC.
Crie um manipulador que mostre um alerta no console.
Com este exercício, você aprende a usar eventos para tornar aplicações mais reativas e seguras.

### 5 Notificação de Conclusão de Download com Eventos

Ao lidar com tarefas assíncronas, como downloads, sistemas devem informar o usuário sobre a finalização do processo.

Tarefas:

Crie uma classe DownloadManager.
Simule o tempo de download usando Thread.Sleep.
Crie um evento DownloadCompleted.
Dispare o evento ao final do processo e exiba uma mensagem no console.
Este exercício ensina como eventos são utilizados para notificar o sistema sobre o fim de uma operação.

### 6 Sistema de Registro com Multicast Delegate

Uma aplicação corporativa precisa registrar logs simultaneamente em vários destinos: console, arquivo e banco (simulado).

Tarefas:

Crie uma classe Logger com três métodos: LogToConsole, LogToFile, LogToDatabase.
Crie um Action<string> multicast delegate.
Adicione os três métodos ao delegate.
Ao chamar o delegate com uma mensagem, todas as saídas devem ser executadas.
Esse exercício reforça como delegates podem ser encadeados para criar comportamentos complexos com baixa acoplamento.

### 7 Garantia de Robustez em Invocação de Delegates

Ao usar delegates em tempo de execução, é fundamental garantir que invocações não gerem erros caso não haja métodos associados.

Tarefas:

Reutilize o código do exercício anterior (Logger).
Substitua todas as invocações diretas por chamadas usando ?.Invoke().
Teste o sistema sem nenhum método associado ao delegate e verifique que não ocorrem exceções.
Esse exercício promove boas práticas para escrita de código mais robusto.

### 8 Construção de Aplicação Web com Razor Pages

Aplicativos web baseados em Razor Pages são comuns em sistemas internos e portais administrativos.

Tarefas:

Crie um novo projeto ASP.NET Core com Razor Pages.
Crie uma página inicial (Index.cshtml) que exiba uma lista com três produtos (nome e preço).
As informações podem estar fixas ou armazenadas em uma lista na página.
Configure navegação básica entre as páginas.
Com este exercício você começa a construir aplicações web completas com estrutura MVC simplificada.

### 9 Exploração da Estrutura de Projeto ASP.NET Core

Compreender a estrutura do projeto ASP.NET Core é essencial para manutenção e evolução de aplicações.

Tarefas:

A partir do projeto criado no exercício anterior, responda:
Qual a função da pasta Pages?
O que faz o arquivo Program.cs?
Onde são configurados os serviços da aplicação?
Como é feito o roteamento de URLs?
Entregue as respostas no arquivo markdown README.md deste exercício.

### 10 Implementação de Formulário em Razor Pages

Cadastros são uma funcionalidade central em aplicações web.

Tarefas:

No projeto ProductCatalog, crie uma página AddProduct.cshtml.
Implemente um formulário com dois campos: Nome e Preço.
Ao submeter o formulário, exiba os dados preenchidos de volta na página.
Esse exercício mostra o ciclo básico de entrada e exibição de dados no modelo Razor Pages.

### 11 Manipulação de Strings com Delegates Encadeados

Transformações encadeadas são comuns em pipelines de processamento.

Tarefas:

Crie um Func<string, string, string> que concatene nome e sobrenome.
Encadeie mais dois métodos no delegate:
Um que converta a string para maiúsculas.
Outro que remova espaços em branco.
Observe e analise o comportamento do resultado.
Esse exercício ajuda a compreender o comportamento de retorno em delegates multicast.

### 12 Integração de Delegates e Eventos em Aplicação Web

Sistemas modernos integram lógica de negócio com eventos para rastrear operações de forma centralizada.

Tarefas:

No projeto ASP.NET, crie uma entidade Event com Título, Data e Local.
Crie uma página que permita cadastrar eventos.
Sempre que um novo evento for criado, dispare um delegate Action<Event> que registre a criação no console.
Este exercício conecta conceitos de eventos com aplicações web reais.

#### Orientações para a entrega
O código-fonte deve ser entregue organizado por exercício (um projeto para cada exercício)
Crie no Visual Studio apenas uma única solução (.sln) com todos os projetos
Inclua prints de tela que demonstrem o funcionamento das aplicações.
Todos os prints de tela devem capturar toda a tela do monitor, inclusive data/hora.
Crie um arquivo markdown README.md na raiz de cada projeto com referência para as capturas de tela.
O moodle possui um limite de 20MB para upload, portanto, exclua todas as pastas "bin" e "obj" de cada um dos projetos ou execute a limpeza da solução (Clear Solution).
Quando concluir todos os exercícios e a limpeza, compacte a pasta raiz da solução com todos os projetos. Utilize o formato zip (apenas ZIP) para compactação.
