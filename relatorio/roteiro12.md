# Roteiro 12:
## Arvore:

*A Logica da arvore*
--
A estrategia geral se consiste em uma classe que contem informações dos Nodos e a outra classe contem toda a logica de programação

--
*Nodos*
--
Os nodos foram usados de forma estrategica de tal forma que, uma classe NODO iria conter todos nodos possiveis, tais como Nodo PAI, Filho a direita e Filho a esquerda, 
onde a logica a ser aplicada vai percorrer os nodos correspondentes e iria tomar a ação necessaria.

--
*Logica*
--
A logica se consiste em, ao inserir o primeiro numero, ele iria entrar no modo PAI, desta maneira, ele iria analisar de tal forma que, SE o valor a ser inserido for MAIOR
que o Nodo, ele irá criar um novo nodo filho, reajustando de tal forma que, vai transformar o nodo filho em novo nodo pai de seu nivel, atribuindo o valor e inserindo à direita
do pai dele.
caso o valor seja MENOR, ele irá fazer a mesma coisa para o lado esquerdo, usando a mesma logica.
