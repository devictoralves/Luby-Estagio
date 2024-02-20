### 8️⃣ - Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
    ```csharp
    int[] vetor = new int[] { 1,2,3,4,5 };
    ObterElementosPares(vetor) == new int { 2, 4 }; //true 
    ```
-----

### RESOLUÇÃO: 
✅ Na solução, começo com um vetor contendo os nomes e solicito ao usuário que digite o valor que deseja buscar. Em seguida, utilizei uma classe chamada Buscador, que possui um método para realizar a busca. O método Buscar utiliza LINQ para encontrar todas as strings no vetor que contêm o valor fornecido pelo usuário. Por fim, exibo os resultados da busca na tela. 