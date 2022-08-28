# Documentação da aula de laboratório
*Atividade 01*
  Enunciado
-----------------
01- Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 

Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.


*metodo de resolução*
--
> Primeiro peguei a divisão e depois o resto do numero, caso ambos somados e multiplicados chegasse ao mesmo valor do numero testado, ele seria esse numero perfeito.

*em execução*
--
> ![image](https://user-images.githubusercontent.com/101759293/187095930-3d14e55c-0ba8-4013-9084-1ee365f02dad.png)


*Atividade 02*
  Enunciado
-----------------
02 - Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras palavras, um Número Primo possui dois divisores de 1 até ele.

Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é Primo.

Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.

Faça um programa que liste os números perfeitos de 1 a 1000.



*metodo de resolução*
--
>primeiro fiz um teste com contador para saber se o numero era ou não primo, independente se retornasse true ou false, aconteceria a verificação do numero perfeito, no qual, usando resto da divisão dos numeros  e os somando, e depois comparando, me diria se ele é um numero perfeito ou não.

*em execução*
--
![image](https://user-images.githubusercontent.com/101759293/187096162-3b90c7d2-6b10-468a-bb71-d582b05d8039.png)



*Atividade 03*
  Enunciado
-----------------
03-Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. Considere que nenhum dos vetores possui elementos repetidos.

Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.



*metodo de resolução*
--
> Utilizei um metodo bool para comparar se A[i] é o mesmo de B[j], caso fosse, ele se uniria aos conjuntos de vetor C, caso não, iria para o vetor D

*em execução*
--
![image](https://user-images.githubusercontent.com/101759293/187096792-d0918748-d332-409c-b45f-bbd26059568f.png)
OBS: Os 5 primeiros são referentes aos vetor C e os demais ao vetor D.



*Atividade 04*
  Enunciado
-----------------
04- Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

*metodo de resolução*
--
>utilizei da estretegia de, caso a linha da matriz auxiliar (k) fosse igual a coluna (c), ele iria somar 1x a coluna k, até repetir 3x para ter a soma da coluna, enquanto a linha somei (l) e (i) para saber certinho qual linha estavamos e quando mudava de coluna.

*em execução*
--
![image](https://user-images.githubusercontent.com/101759293/187097008-a386f5b2-5ecb-48bf-a963-3aef3d067f0a.png)



*Atividade 05*
  Enunciado
-----------------
05-Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

*metodo de resolução*
--
>puxei o numero da main para a função e fiz a logica de fatorial, simples.

*em execução*
--
![image](https://user-images.githubusercontent.com/101759293/187097123-ee7569c3-44fc-4ec5-b92b-61bff69fa2f4.png)



*Atividade 06*
  Enunciado
-----------------
06-Faça um programa que chame uma função capaz de calcular 𝑥^𝑦 , sendo 𝑥 e 𝑦 inteiros. 
Utilize passagem de parâmetros por referência. 

*metodo de resolução*
--
>puxei por referencia da main para ja retornar com o valor alterado, após isso usei na função o math.pow para potencializar os numeros, simples.

*em execução*
--
![image](https://user-images.githubusercontent.com/101759293/187097216-3ccad2d8-0a89-42c0-b386-01906828f2ce.png)
