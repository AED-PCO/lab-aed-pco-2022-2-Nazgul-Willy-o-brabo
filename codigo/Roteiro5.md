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
* Variação de casos: </br>
Pior caso: O(n) </br>
Medio caso: 2n + 1 / 2 / n = N </br>
Melhor caso: O(n) </br>

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
* Operações: Atribuição, Comparação, condição, Repetição.
* Variação de casos: </br>
Pior caso: O(n) </br>
Medio caso: (n-1)+n+1/2/n == 2n = N </br>
Melhor caso: O(n) </br>

## Exercício 3:
~~~C#
double[] alg3(double []arr1){  
   double[] res;        //1
   for(int pos = 0; pos<arr1.length; pos++){        //n-1
        for(int j = 0; j<arr1.length; j++){     //n-1
            if(j!=pos)      //n+1
                res[pos] += arr1[pos]/arr1[j];          
       }
   }
   return res;  //1
}
~~~
* Operação mais relevante: repetição
* Operações: comparação, condição, somatorio, divisão, repetição
* Variação de casos: </br>
Pior caso: O(n^2) </br>
Medio caso: (n-1)x(n-1)+(n+1)+2/2/n = n^2+n </br>
Melhor caso: O(n^2) </br>

## Exercício 4:
~~~C#
public double[] alg4(int[] dados){        
    double[] vet = new double[dados.length];        //1
    for(int i=0; i<dados.length; i++){      //n-1
        double soma=0.0;        //1
        for(int j=0; j<=i; j++)     //n-1
            soma += dados[j];       //n
            vet[i] = soma/(i+1);        //n
        }
    return vet;     //1
}
~~~
* Operação mais relevante: 
* Operações: 
* Variação de casos: </br>
Pior caso: O(n^2) </br>
Medio caso: 2+n^2-2+2n == n^2+n </br>
Melhor caso: O(n^2) </br>
