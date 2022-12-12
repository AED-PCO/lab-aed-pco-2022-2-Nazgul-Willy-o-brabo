# Roteiro 7:
# Documentação da aula de laboratório
*Atividade 01*
  Modelagem
-----------------
O Programa irá pedir ao usuario que ele digite alguma coisa, e, ao receber essa informação, o programa irá até um arquivo local chamado Atv02.txt e irá comparar o que o usuario digitou com o que está escrito no arquivo, se o que foi digitado estiver correto, o programa irá avançar com uma mensagem CORRETO caso contrario, ERRADO.

*Complexidade*
--
>O(n) por se tratar de nenhuma repetição

*em execução*
--

![image](https://user-images.githubusercontent.com/101759293/207009179-52bd6fb6-6262-46b8-b887-3563835a0ed4.png)</br>
Informação do arquivo 

![image](https://user-images.githubusercontent.com/101759293/207008694-ad2f0ed4-4ed4-4c7a-8be4-4ed95a3a2099.png)</br>
Informação errada 

![image](https://user-images.githubusercontent.com/101759293/207008840-37ca7c1b-985b-45f4-9559-da1bac7f6ca7.png)</br>
Informação correta 


*Atividade 02*
  Analise de codigo
-----------------
![image](https://user-images.githubusercontent.com/101759293/207009535-826622ad-32c1-49a1-a230-1241992a85dd.png)
</br>
*Funcionalidade do codigo*
--
O codigo apresentado se trata de uma função recursiva onde que, tem a condição de parada o valor recebido menor ou igual a 1. Caso o valor inicial seja menor ou igual, a recursividade não acontece, caso contrario, irá entrar na condição

*codigo*
--
![image](https://user-images.githubusercontent.com/101759293/207010161-9ca8bb83-da99-45c0-9d78-53bc375a19ec.png)
</br>

*Atividade 03*
  Modelagem
 ------------
 O programa tem como finalidade inverter o que está escrito dentro do arquivo, com isso foi utilizado um metodo que utiliza o metodo reverse para que o programa leia tudo que está dentro do arquivo e já venha invertendo todos os valores. O arquivo utilizado é o mesmo do exercicio 1 "Atv02" então a palavra no qual ele irá inverter é JABUTICABA
 
 *Complexidade*
 ---
 O(1)
 Porém, sua operação relevante é O(n) (Por conta do tamanho do texto a ser invertido)
 
 *Execução*
 ---
 ![image](https://user-images.githubusercontent.com/101759293/207011336-917b57b0-feae-4e17-834a-b8e1d20de526.png)</br>
 Codigo
 
 ![image](https://user-images.githubusercontent.com/101759293/207011639-3f6abe96-ddc2-4375-8f90-6f56af7fa19b.png)</br>
 Execução

*Atividade 04*
  Sobre
 ------------
Foi apresentado o cenario onde um especialista de TI sugeriu para um banco, organizar seus CPF's por meio do Insertion Sort.

*Escolha do especialista*
---
A escolha pelo especialista é ruim, pois como o banco de dados do banco já está com muitos registros, isso torna o insertion sort um metodo mais ineficaz do que alguns dos outros metodos

*Algoritimo sugerido*
--
Para o cenario acima, o algoritimo mais adequado seria algum relacionado a divisão e conquista, no caso, foi escolhido o metodo Quick Sort, pois ele teria o menor tempo de execução no sistema, se tornando mais eficiente na hora da execução

*Execução*
--
![image](https://user-images.githubusercontent.com/101759293/207013234-2ebc95bb-b6c3-4fa4-aab4-69800a6ec108.png)

*Atividade 05*
  Sobre
----
A atividade apresenta um alogitimo que deve ser analisado
![image](https://user-images.githubusercontent.com/101759293/207013524-08366789-0a00-44e8-bada-8174c94f132e.png)

*Retorno*
--
A função irá uma chamada recursiva se iniciando pelo numero 6, decrementando até chegar no valor 6>5>4>3>2>*1*, Após isso, ele cai no retorno da recursividade, retornando 10.
porém ao ir desempilhando, o valor no qual ele irá retornar é o valor *22*.

*Execução*
--
![image](https://user-images.githubusercontent.com/101759293/207014150-9380a1a1-43cf-4ad9-a098-25ab7045fb9d.png)

  
