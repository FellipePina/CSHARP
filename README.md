**Grupo**:
- Airton Alfair Perico Lemes - RGM: 38326922
- Felipe Gonsalves de Pina Miranda - RGM: 37837915
- Gabriel Lopes do Nascimento - RGM: 37669125

## Exercícios:
### ex01 - Validador de Senhas Fortes
No Exercício 1, criamos uma verificação de senha. Referente as variáveis de diferente foi utilizado o bool(Booleana)  que faz a representação lógica de Verdadeiro ou falso, também foi utilizado a expressão regular REGEX que é usada para procurar, validar, substituir ou extrair padrões de textos.Se todos os critérios fossem verdadeiros, a senha seria válida, e , caso contrário, o programa informaria que a senha é inválida, e apresentaria a falta de algum critério, que seria impresso para o usuário.

###  ex02 - Tabuada Completa com Laço
No Exercício 2, foi solicitado do usuário um valor onde vai ser usado para mostrar na tela a tabuada do numero informado do 1 ao 10. Foi utilizado um for para criar uma estrutura de repetição (loop) que no caso se encerrou no 10. Para evitar que o programa tenha problemas com uma entrada inválida, foi utilizado uma validação onde, declaramos uma variável bool, que através do TryParse, ela tenta converter o valor informado pelo usuário para inteiro, e caso seja um número, ela retorna "true", se não "false".

###  ex03 - Cálculo de Fatorial com while
3 - Exercício 3 se refere a numeros fatoriais, então foi necessário criar um Loop de decremento, onde foi solicitado do usuário o número e validado o se o mesmo era abaixo de 0 (valor inválido e fim da execução), e depois, se era igual a 0(exceção na validação, tendo o numero 1 como fatorial). logo em seguida feito o cálculo. EX:  !3 = 3 x 2 x 1. Resultado: 6. Conforme foi explicado no exercício 2, foi utilizado também neste exercício o método tryParse,para ter um controle na validação, aceitando apenas números, e evitando uma quebra no código.

###  ex04 - Conversor de Temperaturas com Menu
4 - Exercício 4 foi solicitado a conversão de temperatura, foi utilizado o While onde repete o bloco de execução enquanto a condição da Escolha for verdadeira, também utilizada a função Switch case, onde dentro dela foi validada a variável "escolha" que basicamente se torna uma decisão onde mostra ao usuário as decisões que deverão ser tomadas no decorrer de sua escolha. Foi adicionado também a validação do TryParse, mantendo uma validação um pouco mais forte, e evitando tanto a entrada de algo que não seja número, como também, a verificação da entrada dos números que devem ser entre 1 e 3.

###  ex05 - Verificador de Palíndromos
5 - Exercício 5 foi bem complicado em razão da manipulação de um string onde tivemos que criar uma validação, convertendo tudo para minúsculo, retirando espaços,concatenando a string e removendo caracteres especiais. Também foram usadas atribuições de texto referente a biblioteca Text, um exemplo foi o texto.Replace que altera parte de uma string por outra e em seguida foi feita a logica utilizando um array para retornar o texto corrijido. Após o tratamento da string que o usuário digitou, foi feito a comparação da entrada, com a entrada invertida(utilização do Array.Reverse()), e , caso eles sejam iguais, o texto é palíndromo, se não, não é palíndromo.

###  ex06 - Cadastro Simples de Produtos
6 - Exercício 6 foi solicitado um cadastro de um Produto, então, foi criado uma classe produto com construtores, get e set para manipular qualquer alteração, criado o construtor para definir os valores dos atributos da classe e criado a função ExibirDetalhes da classe Produto para mostrar as informações do produto criado , na classe Main foi criado uma lista e um loop para adicionar as informações do produto e enviar para a classe e em seguida solicitar o ExibirDetalhes para informar todos os produtos criados. O loop foi definido para 3 repetições pois no exercício foi pedido o cadastro de 3 produtos. Novamente foi utlizado o tryParse, tanto no valor do preço, como na quantidade para melhorar a validação do código, e atribuir os valores apenas quando estiverem corretos.

###  ex07 -  Soma de Números Pares de um Array
7 - Exercício 7 solicita a soma dos pares dentro de um array de 10 posições, então foi criado um loop que percorre as 10 posições e em seguida feito uma condição, após a entrada do valor feito pelo usuário, onde, se o valor informado dividido por 2, tenha o resto igual a 0 significa que ele é par. Se for par, ele é adicionado em uma variável de soma, se não, é verificado a condição de iniciar o loop novamente. Para evitar erros de entrada de valores, foi utilizado o TryParse, para que sejam válidos apenas números inteiros.

###  ex08 -  Cálculo de IMC com Classificação
8 - Exercício 8 solicita ao usuário o peso e a altura, calcula o IMC (Índice de Massa Corporal)  através de sua fórmula, e, com base na condição, informa em qual faixa de classificação a pessoa se encontra.

###  ex09 -  Jogo da Adivinhação
9 - O exercício 9 solicita a criação de um valor aleatórioentre 1 e 100, em seguida a adivinhação desse valor. Foi criado uma variável que recebe a função "Random" onde cria valores aleatórios no intervalo de 1 a 100, depois, a partir do número informado ele começa a fazer a validação da condição que informa se o valor é maior ou menor até encontrar o valor correto, ao final mostra a mensagem de acerto com o número de tentativas.

###  ex10 -  Lista de Tarefas (To-Do List)
10 - O exercício 10 consiste na criação de uma lista de tarefas. O programa começa inicializando a lista e, em seguida, entra em um laço de repetição que verifica se o usuário está inserindo opções válidas. Foi feito um ajuste, inserindo o TryParse para validar apenas a entrada de números inteiros, e além disso, se eles estão dentro das opções de escolha(1 a 3). A lógica principal é conduzida por uma estrutura switch case, onde cada escolha do usuário permite adicionar ou concluir tarefas na lista, conforme o caso selecionado. Caso o usuário queira encerrar sua execução, basta informar o valor 3 e assim é encerrado o programa.
