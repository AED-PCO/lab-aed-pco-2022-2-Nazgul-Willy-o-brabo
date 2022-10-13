# Roteiro 5:
## Exercício 1:
~~~C#
public int alg1(int n){
    int res = 1;        //1
    for(int i=n; i>1; i--){     //n-1
        res = res*i;        //n
    }
    return res;     //1
}
~~~
* Operação mais relevante: Repetição
* Operações: Atribuição, Comparação, Multiplicação, Repetição.
* Variação de casos:
-Pior caso: O(n) </br>
-Medio caso: 2n + 1 / 2 / n = N </br>
-Melhor caso: O(n) </br>

## Exercício 2:
~~~C#
public int alg2(int[] arr, int x){
    for(int i=0; i<arr.length; i++){        //n-1
        if(arr[i] == x) return x;       //n
    }
    return -1;      //1
}
~~~
* Operação mais relevante: Repetição
* Operações: Atribuição, Comparação, Multiplicação, Repetição.
* Variação de casos:
Pior caso: </br>
Medio caso: </br>
Melhor caso: </br>
