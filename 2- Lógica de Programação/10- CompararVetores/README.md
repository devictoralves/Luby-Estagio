### 🔟 -  Implemente a função abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.
    ```csharp
    // faltam elementos no vetor2
    int[] vetor1 = new int[] { 1,2,3,4,5 };
    int[] vetor2 = new int[] { 1,2,5 };
    ObterElementosFaltantes(vetor1, vetor2) == new int[] { 3, 4 }; //true 

    // faltam elementos no vetor3
    int[] vetor3 = new int[] { 1,4,5 };
    int[] vetor4 = new int[] { 1,2,3,4,5 };
    ObterElementosFaltantes(vetor3, vetor4) == new int[] { 2, 3 }; //true
  
    // faltam elementos em ambos vetores
    int[] vetor5 = new int[] { 1,2,3,4 };
    int[] vetor6 = new int[] { 2,3,4,5 };
    ObterElementosFaltantes(vetor5, vetor6) == new int[] { 1, 5 }; //true

    // não faltam items
    int[] vetor7 = new int[] { 1,3,4,5 };
    int[] vetor8 = new int[] { 1,3,4,5 };
    ObterElementosFaltantes(vetor7, vetor8) == new int[] { }; //true
    ```
-----

### RESOLUÇÃO: 
✅ Na solução desse problema, inicialmente solicito que o usuário forneça os elementos do primeiro e do segundo vetor, que são convertidos em arrays de inteiros chamados vetor1 e vetor2. Depois disso faço a comparação dos elementos usando as funcionalidades LINQ Except e Union, que encontram elementos únicos em cada vetor e os combinam. Após isso armazeno na variável elementosFaltantes e apresentado na tela, separados por vírgula.

