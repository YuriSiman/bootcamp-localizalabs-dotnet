<h1 align="center">Bootcamp LocalizaLabs .NET Developer</h1>

<p align="center">Implementações de exercícios de programação do Bootcamp LocalizaLabs .NET Developer</p>

## :clipboard: Exercícios

Soluções de Problemas em C#
* [Consumo Médio do Automóvel](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/#consumo-m%C3%A9dio-do-autom%C3%B3vel)  
* [DDD](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/#ddd)  
* [Aumento de Salário](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/#aumento-de-salário)  

Criando uma Aplicação de Transferências Bancárias com .NET 
* [Transferência Bancária](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/#transferência-bancária)  

Desafios Aritméticos em C#
* [Média](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/#média)  

---

### :dart: Objetivo

Tenho como objetivo implementar as atividades propostas pelo Bootcamp LocalizaLabs .NET Developer. São exercícios de programação focados em C# e dotnet.

### Clone

Clone este repositório em sua máquina local usando:

```
git clone https://github.com/YuriSiman/bootcamp-localizalabs-dotnet.git
```

---

## :rocket: Vamos Começar 

### Soluções de Problemas em C#

## Consumo Médio do Automóvel 

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


* [Visualizar Código](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/blob/master/src/1%20-%20Solu%C3%A7%C3%A3o%20de%20Problemas%20em%20CSharp/Consumo%20M%C3%A9dio%20do%20Autom%C3%B3vel/Program.cs)  
* [Voltar ao Início](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet#bootcamp-localizalabs-net-developer)  

---

## DDD

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

Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:  
``` DDD não cadastrado ```


**Entrada**  
A entrada consiste de um único valor inteiro.  

**Saída**  
Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.  

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
11 | São Paulo

* [Visualizar Código](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/blob/master/src/1%20-%20Solu%C3%A7%C3%A3o%20de%20Problemas%20em%20CSharp/DDD/Program.cs)  
* [Voltar ao Início](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet#bootcamp-localizalabs-net-developer)  

---

## Aumento de Salário

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


* [Visualizar Código](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/blob/master/src/1%20-%20Solu%C3%A7%C3%A3o%20de%20Problemas%20em%20CSharp/Aumento%20de%20Sal%C3%A1rio/Program.cs)  
* [Voltar ao Início](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet#bootcamp-localizalabs-net-developer)  

---

### Criando uma Aplicação de Transferências Bancárias com .NET

## Transferência Bancária

**Desafio**  
Criando uma aplicação de transferência bancária com .NET e C#.  
Aprenda como criar um algoritmo simples de transferência bancária para exercer o pensamento orientado a objetos, o principal paradigma de programação utilizado no mercado. Nesse projeto você vai aprender: Como pensar orientado a objetos, como modelar o seu domínio, como utilizar enums.


* [Visualizar Código](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/tree/master/src/2%20-%20Criando%20uma%20Aplica%C3%A7%C3%A3o%20de%20Transfer%C3%AAncias%20Banc%C3%A1rias%20com%20.NET/Transfer%C3%AAncias%20Banc%C3%A1rias)  
* [Voltar ao Início](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet#bootcamp-localizalabs-net-developer)  

---

### Desafios Aritméticos em C#

## Média

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

* [Visualizar Código](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/blob/master/src/3%20-%20Desafios%20Aritm%C3%A9ticos%20em%20CSharp/M%C3%A9dia/Program.cs)  
* [Voltar ao Início](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet#bootcamp-localizalabs-net-developer)  

---

## :vertical_traffic_light: Status do Projeto

:construction: Atividades do Bootcamp sendo implementadas :construction:

---

## :thinking: Contribuindo

> Para começar...

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

[![Github](https://img.shields.io/badge/github-profile-%237159c1?style=for-the-badge&logo=github)](https://github.com/YuriSiman)  
[![Curriculum](https://img.shields.io/badge/site-curriculum-%23563D7C?style=for-the-badge&logo=bootstrap)](https://yurisiman.com.br)  

---

## :pencil: Licença

[![License](https://img.shields.io/badge/license-mit-%23A6CE39?style=for-the-badge&logo=github)](https://github.com/YuriSiman/bootcamp-localizalabs-dotnet/blob/master/LICENSE)   

---

Code your life...
