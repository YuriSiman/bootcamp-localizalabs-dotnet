<div id="top"></div>

<br/>
<div align="center">
    <img src="./readme-imgages/localiza-labs.png" alt="Logo" width="100" height="100" />
    <h1 align="center">Bootcamp LocalizaLabs .NET Developer</h1>
    <p align="center">Implementações de exercícios de programação do Bootcamp LocalizaLabs .NET Developer 1 e 2</p>
</div>

<br/>

<div align="center">
    <a href="https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/blob/master/LICENSE" target="_blank">
      <img alt="LICENSE" src="https://img.shields.io/badge/license-mit-%23A6CE39?style=for-the-badge&logo=github" />
    </a>
    <a href="https://github.com/YuriSiman" target="_blank">
      <img alt="GitHub" src="https://img.shields.io/badge/github-perfil-%237159c1?style=for-the-badge&logo=github" />
    </a>
    <a href="https://yurisiman.com.br" target="_blank">
      <img alt="Site" src="https://img.shields.io/badge/site-yurisiman-E0A80D?style=for-the-badge&logo=Purism" />
    </a>
    <a href="https://www.linkedin.com/in/yurisiman/" target="_blank">
      <img alt="Linkedin" src="https://img.shields.io/badge/linkedin-social-0A66C2?style=for-the-badge&logo=LinkedIn" />
    </a>
    <a href="mailto:contato@yurisiman.com.br" target="_blank">
      <img alt="Gmail" src="https://img.shields.io/badge/email-contato-EA4335?style=for-the-badge&logo=Gmail" />
    </a>
</div>

<br/>

## :clipboard: Sobre o Projeto

Lista de exercícios resolvidos no Bootcamp LocalizaLabs .NET Developer, oferecido pela plataforma Digital Innovation One. Espero contribuir fazendo com que este repositório possa servir como fonte de estudo e consulta a muitos desenvolvedores que, 
assim como eu, realizaram o Bootcamp, ou mesmo aqueles que não o fizeram, mas que gostariam de estudar com desafios propostos. :smiley::coffee:

---

## :pencil: Pré-requisitos

1. Construído com .NET 5.0 e codificado em C#. Se você não possui o dotnet instalado, acesse [aqui](https://dotnet.microsoft.com/) e instale a versão mais recente.
2. Clone este repositório em sua máquina local

   ```sh
   git clone https://github.com/YuriSiman/bootcamp-localizalabs-dotnet.git
   ```

---

## :dart: Tabela de Desafios

<details>
  <summary>Bootcamp LocalizaLabs .NET Developer</summary>
  <ul>
    <li><a href="#desafio01">Consumo Médio do Automóvel</a></li>
    <li><a href="#desafio02">DDD</a></li>
    <li><a href="#desafio03">Aumento de Salário</a></li>
    <li><a href="#desafio04">Criando uma Aplicação de Transferências Bancárias com .NET</a></li>
    <li><a href="#desafio05">Média</a></li>
    <li><a href="#desafio06">Crescimento Populacional</a></li>
    <li><a href="#desafio07">Bazinga!</a></li>
    <li><a href="#desafio08">Tempo de um Evento</a></li>
    <li><a href="#desafio09">Comunicação em Piralândia</a></li>
    <li><a href="#desafio10">Ho Ho Ho</a></li>
    <li><a href="#desafio11">Dividindo X por Y</a></li>
    <li><a href="#desafio12">Esfera</a></li>
    <li><a href="#desafio13">Xenlonguinho</a></li>
    <li><a href="#desafio14">Pedro Bento e o Mundo de OZ</a></li>
    <li><a href="#desafio15">Criando um APP simples de cadastro de séries em .NET</a></li>
    <li><a href="#desafio16">Introdução à orquestração de conteiners com Docker</a></li>
    <li><a href="#desafio17">Desenvolvimento de Aplicações com .NET</a></li>
    <li><a href="#desafio18">Implementando sua stack de testes de unidade e integrados em um projeto .NET de Crowdfunding</a></li>
    <li><a href="#desafio19">Coordenadas de um Ponto</a></li>
    <li><a href="#desafio20">Compras no Supermercado</a></li>
    <li><a href="#desafio21">Pink e Cérebro</a></li>
    <li><a href="#desafio22">Configuração da arquitetura back-end com .NET Core</a></li>
    <li><a href="#desafio23">Construindo um projeto de uma API.NET integrada ao MongoDB</a></li>
  </ul>
</details>

---

## :rocket: Vamos Começar 

<div id="desafio01"></div>

### Consumo Médio do Automóvel 

**Desafio**  
Você deve calcular o consumo médio de um automóvel onde será informada a distância total percorrida (em Km) e o total de combustível consumido (em litros).  

**Entrada**  
Você receberá dois valores: um valor inteiro X com a distância total percorrida (em Km), e um valor real Y que representa o total de combustível consumido, com um dígito após o ponto decimal.  

**Saída**  
Exiba o valor que representa o consumo médio do automóvel (3 casas após a vírgula), incluindo no final a mensagem "km/l".  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
Distância: 500 - Combustível Gasto: 35,0 | 14,286 km/l
Distância: 2254 - Combustível Gasto: 124,4 | 18,119 km/l
Distância: 4554 - Combustível Gasto: 464,6 | 9,802 km/l

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio02"></div>

### DDD

**Desafio**  
Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:  

DDD | Destination
------------ | -------------
61 | Brasília
71 | Salvador
11 | São Paulo
21 | Rio de Janeiro
32 | Juiz de Fora
19 | Campinas
27 | Vitória
31 | Belo Horizonte  

Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:  ``` DDD não cadastrado ```  

**Entrada**  
A entrada consiste de um único valor inteiro.  

**Saída**  
Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
11 | São Paulo

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio03"></div>

### Aumento de Salário

**Desafio**  
A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:  

Salário | Percentual de Reajuste
------------ | -------------
0 - 400.00 | 15%
400.01 - 800.00 | 12%
800.01 - 1200.00 | 10%
1200.01 - 2000.00 | 7%
Acima de 2000.00 | 4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.  

**Entrada**  
A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.  

**Saída**  
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
400.00 | Novo salario: 460.00 - Reajuste ganho: 60.00 - Em percentual: 15 %
800.01 | Novo salario: 880.01 - Reajuste ganho: 80.00 - Em percentual: 10 %
2000.00 | Novo salario: 2140.00 - Reajuste ganho: 140.00 - Em percentual: 7 %

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio04"></div>

### Criando uma Aplicação de Transferências Bancárias com .NET

**Desafio**  
Criando uma aplicação de transferência bancária com .NET e C#.  
Aprenda como criar um algoritmo simples de transferência bancária para exercer o pensamento orientado a objetos, o principal paradigma de programação utilizado no mercado. Nesse projeto você vai aprender: Como pensar orientado a objetos, como modelar o seu domínio, como utilizar enums.

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio05"></div>

### Média

**Desafio**  
Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.  

**Entrada**  
O arquivo de entrada contém 2 valores com uma casa decimal cada um.  

**Saída**  
Calcule e imprima a variável MEDIA conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade. Utilize variáveis de dupla precisão (double) e como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
5.0 - 7.1 | MEDIA = 6.43182
0.0 - 7.1 | MEDIA = 4.84091
10.0 - 10.0 | MEDIA = 10.00000

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio06"></div>

### Crescimento Populacional

**Desafio**  
O Governador do Estado quer saber sobre as taxas de crescimento das cidades. De acordo com dados da população e a taxa de crescimento de duas cidades quaisquer (A e B), ele quer que você calcule quantos anos levará para que a cidade menor (A) cresça mais em população que a cidade maior (B).

Claro que o Governador quer saber apenas para as cidades cuja taxa de crescimento da cidade A é maior do que a taxa de crescimento da cidade B, portanto, previamente já separou para você apenas os casos de teste que tem a taxa de crescimento maior para a cidade A.

Desenvolva um programa que apresente o tempo, em anos, para cada caso.

Porém, em alguns casos o tempo pode ser muito grande, e o Governador não se interessa em saber exatamente o tempo para estes casos, já que ele pode não estar mais eleito. Basta que você informe, nesta situação, a mensagem "Mais de 1 século.".  

**Entrada**  
A primeira linha da entrada contém um único inteiro T, indicando o número de casos de teste (1 ≤ T ≤ 3000). Cada caso de teste contém 4 números: dois inteiros PA e PB (100 ≤ PA < 1000000, PA < PB ≤ 1000000) indicando respectivamente a população de A e B, e dois valores G1 e G2 (0.1 ≤ G1 ≤ 10.0, 0.0 ≤ G2 ≤ 10.0, G2 < G1) com um digito após o ponto decimal cada, indicando respectivamente o crescimento populacional de A e B (em percentual).

**Atenção:** A população é sempre um valor inteiro, portanto, um crescimento de 2.5 % sobre uma população de 100 pessoas resultará em 102 pessoas, e não 102.5 pessoas, enquanto um crescimento de 2.5% sobre uma população de 1000 pessoas resultará em 1025 pessoas. Além disso, não utilize variáveis de precisão simples para as taxas de crescimento.  

**Saída**  
Imprima, para cada caso de teste, quantos anos levará para que a cidade A ultrapasse a cidade B em número de habitantes. Obs.: se o tempo for mais do que 100 anos o programa deve apresentar a mensagem: Mais de 1 seculo. Neste caso, é melhor interromper o programa imediatamente após passar de 100 anos, caso contrário você poderá receber como resposta da submissão deste problema "Time Limit Exceeded".  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
6 | 
100 150 1.0 0 | 51 anos.
90000 120000 5.5 3.5 | 16 anos.
56700 72000 5.2 3.0 | 12 anos.
123 2000 3.0 2.0 | Mais de 1 seculo.
100000 110000 1.5 0.5 | 10 anos.
62422 484317 3.1 1.0 | 100 anos.

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio07"></div>

### Bazinga!

**Desafio**  
Em um episódio da aclamada série The Big Ban Theor dois pernagens, Sheldon e Raj, discutem qual dos dois é o melhor: o filme Saturn 3 ou a série Deep Space 9. A sugestão de Raj para a resolução do impasse é uma disputa de Pedra-Papel-Tesoura. Contudo, Sheldon argumenta que, se as partes envolvidas se conhecem, entre 75% e 80% das disputas de Pedra-Papel-Tesoura terminam empatadas, e então sugere o Pedra-Papel-Tesoura-Lagarto-Spock.

As regras do jogo proposto são:

1. a tesoura corta o papel;
2. o papel embrulha a pedra;
3. a pedra esmaga o lagarto;
4. o lagarto envenena Spock;
5. Spock destrói a tesoura;
6. a tesoura decapita o lagarto;
7. o lagarto come o papel;
8. o papel contesta Spock;
9. Spock vaporiza a pedra;
10. a pedra quebra a tesoura.  

Conhecendo os personagens, sabemos que caso Sheldon vencesse, ele gritaria a vitória com um "Bazinga!". Se Raj vencesse, Sheldon o acusaria de ter trapaceado. Agora, se desse empate, Sheldon não descansaria e insistira para jogarem de novo até que seja decidido. Sabendo dessas ações, faça um programa que imprima a provável reação de Sheldon.  

**Entrada**  
A entrada consiste em uma série de casos de teste. A primeira linha contém um inteiro positivo T (T ≤ 100), que representa o número de casos de teste. Cada caso de teste é representado por uma linha da entrada, contendo as escolhas de Sheldon e Raj, respectivamente, separadas por um espaço em branco. As escolhas possíveis são as personagens do jogo: pedra, papel, tesoura, lagarto e Spock.  

**Saída**  
Para cada caso de teste deverá ser impressa a mensagem "Caso #t: R", onde t é o número do caso de teste (cuja contagem se inicia no número um) e R é uma das três reações possíveis de Sheldon: "Bazinga!", "Raj trapaceou!", ou "De novo!".  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
3 | 
papel pedra | Caso #1: Bazinga!
lagarto tesoura | Caso #2: Raj trapaceou!
Spock Spock | Caso #3: De novo!

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio08"></div>

### Tempo de um Evento

**Desafio**  

Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.  

**Entrada**  
Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.  

**Saída**  
Na saída, deve ser apresentada a duração do evento, no seguinte formato:

W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)

Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
Dia 5 | 3 dia(s)
08 : 12 : 23 | 22 hora(s)
Dia 9 | 1 minuto(s)
06 : 13 : 23 | 0 segundo(s)

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio09"></div>

### Comunicação em Piralândia

**Desafio**  
Os cientistas brasileiros descobriram um exoplaneta a 1 bilhão de anos luz da terra. Ele foi carinhosamente batizado de Piralândia, uma homenagem a cidade de Piracicaba, onde moram os cientistas. Após algum tempo observando esse planeta, os cientistas puderam ver que nele haviam habitantes e, além disso, esses habitantes estavam tentando fazer contato com os cientistas através de uma comunicação numérica. 

Só que a numeração que encontraram estava invertida e como muitas delas foram descobertas, os cientistas chamaram você para conseguir automatizar esse processo. Logo, dado um número grande, sua tarefa é imprimir esse número invertido.  

**Entrada**  
O arquivo contém apenas uma linha de teste que é o número encontrado (0 < n < 9999999999).

Obs.: Perceba que o número lido é muito alto para armazenar em uma variável do tipo int, logo você irá precisar utilizar o tipo long, que para a leitura e impressão em C, você deve utilizar o %llu.  

**Saída**  
Imprimir o número lido invertido. Não esqueça de imprimir a quebra de linha (\n) no final, caso contrário você receberá (Presentation Error).  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
1234 | 4321
9876543210 | 0123456789

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio10"></div>

### Ho Ho Ho

**Desafio**  
Papai Noel está brincando com seus duendes para entretê-los durante a véspera do Natal. A brincadeira consiste nos elfos escreverem números em pedaços de papel e colocarem no gorro do Papai Noel. Após todos 
terminarem de colocar os números Noel sorteia um papel e aquele número representa quantos "Ho" o Noel deve falar.

Seu trabalho é ajudar o Papai Noel montando um problema que mostre todos os "Ho" que ele deve falar dado o número sorteado.

**Entrada**  
A entrada é composta por um único inteiro N (0 < N ≤ 106) representando quantos "Ho" serão falados por Noel.

**Saída**  
A saída é composta por todos "Ho" que Papai Noel deve falar separados por um espaço. Após o último "Ho" deve ser apresentado um "!" encerrando o programa.

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
5 | Ho Ho Ho Ho Ho!

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio11"></div>

### Dividindo X por Y

**Desafio**  
Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.

**Entrada**  
A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

**Saída**  
Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
3 | -1.5
3 -2 | divisao impossivel
-8 0 | 0.0
0 8 | 

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio12"></div>

### Esfera

**Desafio**  
Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro.

**Entrada**  
O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

**Saída**  
A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
3 | VOLUME = 113.097
15 | VOLUME = 14137.155
1523 | VOLUME = 14797486501.627

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio13"></div>

### Xenlonguinho

**Desafio**  
Kogu está buscando as esferas do dragão para invocar Xenlonguinho e pedir para ele reviver seu amigo Kuriri, que infelizmente morreu na última batalha dos guerreiros Zê.

Porém Kogu está tendo muita dificuldade para encontrar as esferas, por isso Xenlonguinho que é seu conhecido há muito tempo, decidiu abrir uma exceção e aceitou ser invocado caso Kogu encontre todas as esferas cujo o número de 
divisores da quantidade de estrelas da esfera sejam par.

Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro estrelas, pois elas tem uma quantidade ímpar de divisores, então ele só precisa pegar 5 esferas para invocar Xenlonguinho.

<img src="./readme-images/xenlonguinho.png" />

Como Kogu não é muito bom em contas, ele pediu para você escrever um programa que dado o total de esferas existentes, mostre a quantidade mínima de esferas que ele precisa procurar.

**Entrada**  
A primeira linha consiste de um inteiro C que representa a quantidade de casos de teste. As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 1000) que representa a quantidade de esferas necessárias para invocar Xenlonguinho.

**Saída**  
Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
1 | 5
7 | 

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio14"></div>

### Pedro Bento e o Mundo de OZ

**Desafio**  
No jogo, O Mundo de Oz, Pedro Bento é o líder do Tribunal, por causa disso ele é uma das pessoas mais importantes do mundo, no jogo. Além disso, Pedro Bento possui um grande tesouro, o qual possui diversos tipos de jóias.

Pedro Bento está muito curioso para saber quantos tipos de jóias diferentes seu tesouro possui.

Sabendo que você é o melhor programador do mundo, Pedro Bento te contratou para verificar quantos tipos de jóias distintas ele tem em seu tesouro.

**Entrada**  
A entrada consiste de várias linhas e cada uma contém uma string que descreve uma das jóias de Pedro Bento. Essa string é composta apenas dos caracteres '(' e ')', a soma do tamanho de todas as string não excede 106.

**Saída**  
Imprima quantos tipos de jóias distintas Pedro Bento possui.

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
(( | 3
)) | 
(( | 
)) | 
( | 

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio15"></div>

### Criando um APP simples de cadastro de séries em .NET

**Desafio**  
Aprenda como criar um algoritmo simples de cadastro de séries para praticar seus conhecimentos de orientação a objetos, o principal paradigma de programação utilizada no mercado. Nesse projeto você vai aprender: Como pensar orientado a objetos, como modelar o seu domínio, como utilizar recursos de coleção.  

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio16"></div>

### Introdução à orquestração de conteiners com Docker

Implementação do último exercício proposto na etapa **Introdução à orquestração de conteiners com Docker** do Bootcamp LocalizaLabs .NET Developer.  

Link para o repositório do exercício: [Docker](https://github.com/YuriSiman/bootcamp-localizalabs-docker)  

<p align="right"><a href="#top">Início ↑</a></p>
---

<div id="desafio17"></div>

### Desenvolvimento de Aplicações com .NET

Aprenda sobre o Entity Framework, como criar aplicativos web ASP.NET API e ASP.NET MVC. Você também vai criar testes na aplicação e um projeto com Unit Tests.  

Referente aos projetos implementados, os desenvolvi implementando boas práticas de desenvolvimento, aplicando **Pattern Repository**, mapeando entidades entre Models e ViewModels com **AutoMapper**, criando uma arquitetura distribuída para o projeto MVC com Class Library para a camada de negócios (**Business**), para a camada de dados (**Data**) e para a camada da aplicação MVC (**App**), também foi criado uma API para a utilização das camadas de negócios e dados.

Utilizei o **Entity Framework Core** criando um contexto de dados e implementando um mapeamento com o **Fluent Api**, e para o versionamento do bando de dados, implementeis as **Migrations**.

O projeto segue conforme o que as aulas pedem, basicamente um CRUD completo entre as entidades **Categoria** e **Produto**, porém, o grande diferencial é que implementei de uma forma diferente, fazendo uso de uma arquitetura mais desacoplada, distribuída e de fácil manutenção.

O passo a passo da arquitetura utilizada neste projeto pode ser conferido neste meu [repositório!](https://github.com/YuriSiman/complete-app-crud-aspnetcore-mvc)  

#### Aplicação MVC

<img src="./readme-images/lista-categoria.png" />
<img src="./readme-images/lista-produtos-categorias.png" />
<img src="./readme-images/detalhes.png" />

#### WebAPI utilizando o Swagger para documentação  

<img src="./readme-images/swagger.png" />

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio18"></div>

### Implementando sua stack de testes de unidade e integrados em um projeto .NET de Crowdfunding

Que se sentir mais seguro nas entregas de suas aplicações? Aprenda a testar um projeto de crowdfunding (vaquinha online) desenvolvida em .NET Core com a arquitetura MVC. Você irá baixar uma aplicação completa feita por expert e sua missão será implementar a parte de testes desta aplicação. Veja na teoria e na prática os principais conceitos de testes para aumentar a qualidade de entrega de seus projetos com testes de unidade, integrados e TDD.   

Link para o repositório do exercício: [Crowdfunding](https://github.com/YuriSiman/dotnet-vaquinha-tests)  

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio19"></div>

### Coordenadas de um Ponto  

**Desafio**  
Leia **2** valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).  
Se o ponto estiver na origem, escreva a mensagem **Origem**. Se o ponto estiver sobre um dos eixos escreva **Eixo X** ou **Eixo Y**, conforme for a situação.  

<img src="./readme-images/coordenadas-de-um-ponto.png" />

**Entrada**  
A entrada contem as coordenadas de um ponto.    

**Saída**  
A saída deve apresentar o quadrante em que o ponto se encontra.  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
4.5 -2.2 | Q4
0.1 0.1 | Q1
0.0 0.0 | Origem

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio20"></div>

### Compras no Supermercado  

**Desafio**  
Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.  
O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.  

**Entrada**  
A primeira linha de entrada contém um inteiro **N** (N < 100) com a quantidade de casos de teste que vem a seguir, ou melhor, a quantidade de listas de compras para organizar. Cada lista de compra consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras minúsculas (de 1 a 20 letras), sem acentos e separadas por um espaço.  

**Saída**  
A saída contém **N** linhas, cada uma representando uma lista de compra, sem os itens repetidos e em ordem alfabética.  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
2 |
carne laranja suco picles laranja picles | carne laranja picles suco
laranja pera laranja pera pera | laranja pera

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio21"></div>

### Pink e Cérebro  

**Desafio**  
Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia. Para passar o temp, Pink cria problemas matemáticos para Cérebro resolver, o último deles foi uma lista de números com a seguinte pergunta: quantos números da lista são múltiplos de **2, 3, 4 e 5**?  
Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro se confunde e acaba errando alguns cálculos. Ajude Cérebro a resolver o desadio de Pink.  

**Entrada**  
A primeira linha da entrada consiste em um inteiro **N** (1 ≤ N ≤1000), representando a quantidade de números na lista de Pink. A segunda linha contém **N** inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.  

**Saída**  
Imprima a quantidade de números múltiplos de **2, 3, 4 e 5** presentes na lista. Observe a formatação da saída nos exemplos, pois ela deve ser seguida rigorosamente.  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
5 |
2 5 4 20 10 | 4 Multiplo(s) de 2 - 0 Multiplo(s) de 3 - 2 Multiplo(s) de 4 - 3 Multiplo(s) de 5

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio22"></div>

### Configuração da arquitetura back-end com .NET Core

#### API .NET Core

Aprenda de forma 100% prática a desenvolver um projeto com .NET Core usando RESTful API's e outras funções que otimizam o trabalho com a tecnologia. Neste projeto, tenho como objetivo implementar uma arquitetura back-end de uma API em ASP.NET Core, organizando os componentes da aplicação, documentando a API e aplicar Design Pattern na aplicação.  

Faremos o **Cadastro** de usuários, **Login** de usuários, também iremos realizar o **Cadastro** de um curso do usuário autenticado e teremos uma **Lista** de cursos deste usuário autenticado na aplicação.  

#### Setup da Aplicação

Nossa aplicação poderá ser utilizada por aplicações Web Front-end e também por aplicações mobile.

<img src="./readme-images/arquitetura-backend.png" />

#### API documentada com o Swagger

<img src="./readme-images/curso-api-backend-swagger.png" />

<p align="right"><a href="#top">Início ↑</a></p>

---

<div id="desafio23"></div>

### Construindo um projeto de uma API.NET integrada ao MongoDB

#### API MongoDB

Construiremos um projeto de uma API em .NET Core integrada a um cluster MongoDB, que será criado no service cloud Mongo Atlas. O projeto consiste em uma API que cadastra, altera, deleta e retorna pessoas infectadas pelo coronavirus. **As informações do projeto são fictícias, apenas para fins didáticos**.  

Implementei pequenas modificações no projeto que não foram implementadas nas aulas da etapa Construindo um projeto de uma API.NET integrada ao MongoDB.

#### API documentada com o Swagger

<img src="./readme-images/api-mongodb-swagger.png" />

#### Criando um Cluster no MongoDB Atlas

<img src="./readme-images/create-a-shared-cluster.png" />
<img src="./readme-images/cluster-tier.png" />

#### Conectando sua aplicação ao Cluster

<img src="./readme-images/connect-to-cluster.png" />

#### Adicionando como usuário uma Base de Dados 

<img src="./readme-images/add-new-database-user.png" />

#### Adicionando um IP de Acesso

<img src="./readme-images/add-ip-access-list-entry.png" />

#### Informações do Cluster

<img src="./readme-images/cluster.png" />

#### Dashboard MongoDB Atlas

<img src="./readme-images/dashboards.png" />

<p align="right"><a href="#top">Início ↑</a></p>

---

## :vertical_traffic_light: Status do Projeto

:heavy_check_mark: Bootcamps 1 e 2 Finalizados!  

---

## :thinking: Contribuindo

> Passo a passo de como contribuir...

### Passo 1

* :fork_and_knife: Fork este repositório!

### Passo 2

* :dancers: Clone este repositório para sua máquina local usando `git clone https://github.com/YuriSiman/bootcamp-localizalabs-dotnet.git`

### Passo 3

* :trident: Crie sua feature branch usando `git checkout -b minha-feature`

### Passo 4

* :white_check_mark: Commit suas mudanças usando `git commit -m "feat: Minha nova feature"`

### Passo 5

* :pushpin: Dê um push usando `git push -u origin minha-feature`

### Passo 6

* :arrows_clockwise: Crie um novo pull request

Depois que seu pull request for mesclado, você pode excluir sua feature branch  

> Caso tenha dúvidas, confira este guia de como [contribuir no GitHub](https://github.com/firstcontributions/first-contributions)  

---

## :speech_balloon: Suporte

> Entre em contato comigo...  

* Me chame pelo [Linkedin](https://www.linkedin.com/in/yurisiman/)  
* Me mande um e-mail [contato@yurisiman.com.br](mailto:contato@yurisiman.com.br)  

---

## :pencil: Licença

<a href="https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/blob/master/LICENSE" target="_blank">
  <img alt="LICENSE" src="https://img.shields.io/badge/license-mit-%23A6CE39?style=for-the-badge&logo=github" />
</a>

##

Code your life :octocat:

<p align="right"><a href="#top">Início ↑</a></p>
