# Roteiro 10:
## Exercício 1:

*Estrategia geral*
--
A estrategia geral se consiste em uma classe que contem as informações FUNCIONARIO e ELEMENTO, onde:
Funcionario irá receber Nome e Matricula e Elemento irá receber uma "variavel" que se chama PROXIMO, onde a mesma aponta para Null.
Nesta estrategia então basicamente será utilizado um apontador que aponta para Nulo e em cima dela, irá ser utilizadas operações como inserir, e atualizando este ponteiro, irá afetar operações como remover e visualizar.

*Fila*
--
A fila consiste em utilizar a estrategia de primeiro a entrar e primeiro a sair, porém, diferente da outra fila, este metodo foi utilizado de modo dinamico, ou seja, sem limite de inserções

*Inserção*
--
A inserção acontece de forma dinamica, ou seja, ele utiliza de um ponteiro de referencia chamado .proximo onde ele tem a função de apontar para nulo, e após isto, ele insere um novo bloco de informações nessa antigo nulo, dando um novo bloco de inserção

![image](https://user-images.githubusercontent.com/101759293/207180619-633525ed-4441-455f-be77-b4b0b14f0caf.png)

*Remoção*
--

A remoção acontece de forma semelhante a inserção, o sistema irá analisar o primeiro elemento que está salvo e depois irá pular para o proximo elemento, e irá sobrepor o elemento passado, tirando assim ele da lista

![image](https://user-images.githubusercontent.com/101759293/207182064-254c8ee8-eafa-404b-92c5-7d829d3e17b0.png)

*Visualização*
--
A visualização acontece enquanto o sistema percorre os elementos inseridos até encontrar o valor nulo, após isto ele printa na tela.

![image](https://user-images.githubusercontent.com/101759293/207182255-962b61af-aaa3-49f9-adc5-09180d717ee5.png)


*pilha*
--

A pilha consiste em utilizar a estrategia de primeiro a entrar e ultimo a sair, porém, diferente da outra pilha, este metodo foi utilizado de modo dinamico, ou seja, sem limite de inserções

*Inserção*
--
A inserção acontece de forma dinamica, ou seja, ele utiliza de um ponteiro de referencia chamado .proximo onde ele tem a função de apontar para nulo, e após isto, ele insere um novo bloco de informações nessa antigo nulo, dando um novo bloco de inserção

![image](https://user-images.githubusercontent.com/101759293/207182532-2b4cf2f4-803c-4128-b8a9-1dd4b3826709.png)

*Remoção*
--

A remoção vai acontecer de forma em que, o sistema vai verificar os blocos de informações até o proximo do proximo ser igual a nulo, ao chegar neste tipo, ele vai atribuir um novo final para a pilha.

![image](https://user-images.githubusercontent.com/101759293/207182853-483bbbdf-caba-4974-8a2d-a944efb5c2ae.png)

*Visualização*
--

A visualização acontece enquanto o sistema percorre os elementos inseridos até encontrar o valor nulo, após isto ele printa na tela.

![image](https://user-images.githubusercontent.com/101759293/207182255-962b61af-aaa3-49f9-adc5-09180d717ee5.png)


