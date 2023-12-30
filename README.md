# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, precisei uutilizar meu conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Fui responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que eu faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Precisei criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Criei suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
Com o código está pela metade, dei continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Além de que tomei a liberdade de criar mais dois métodos na Classe Smartphone:
- Especificacoes: para exibir as especificações do celular.
- MudarNumero: para atualizar o número do celular.