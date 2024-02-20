# Lógica de Programação!

### ✅ As questões de Lógica de Programação foram respondidas utilizando C#, conforme solicitado inicialmente. No README de cada uma das questões destaquei uma pequena explicação do que foi feito. Os projetos estão disponíveis de forma integral, para facilitar a execução e avaliação. Todas as questões foram respondidas de forma a respeitar os conceitos básicos da Programação Orientada a Objetos. 
-------

### 1- Implemente a função abaixo para calcular fatorial de um número.
    ```csharp
    // 5! = 5 · 4 · 3 · 2 · 1 = 120
    CalcularFatorial(5) == 120//true
    ```

### 2- Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:
    - Tipo: "basic" fator multiplicação do prêmio: 1
    - Tipo: "vip" fator multiplicação do prêmio: 1.2
    - Tipo: "premium" fator multiplicação do prêmio: 1.5
    - Tipo: "deluxe" fator multiplicação do prêmio: 1.8
    - Tipo: "special" fator multiplicação do prêmio: 2

- **Regras**
    - A função também deverá provir um parâmetro para que seja passado fator de multiplicação próprio.
    - Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
    - O prêmio nunca deve ter um valor negativo ou igual a zero.

```csharp
CalcularPremio(100, "vip", null) == 120.00;//true
CalcularPremio(100, "basic", 3) == 300.00;//true
``` 

### 3-  Implemente a função abaixo para contar quantos números primos existe até o número informado.
    ```csharp   
    //Número primo: 2
    //Número primo: 3
    //Número primo: 5
    //Número primo: 7
    //Total de números primos: 4
    ContarNumerosPrimos(10) == 4//true
    ```

### 4- Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
    ```csharp
    CalcularVogais("Luby Software") == 4//true
    ``` 

### 5- Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado. 
- Lembre-se que as entradas e saídas dos dados são strings que devem ser tratadas.
    ```csharp
    CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"; //true 
    ```

### 6- Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
    ```csharp
    CalcularDiferencaData("10122020", "25122020") == 15; //true 
    ```

### 7- Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
    ```csharp
    int[] vetor = new int[] { 1,2,3,4,5 };
    ObterElementosPares(vetor) == new int { 2, 4 }; //true 
    ```

### 8- Implemente a função abaixo que deve buscar um ou mais elementos no vetor que contém o valor ou parte do valor informado na busca.
    ```csharp
    string[] vetor = new string[] {
        "John Doe",
        "Jane Doe",
        "Alice Jones",
        "Bobby Louis",
        "Lisa Romero"
    };

    BuscarPessoa(vetor, "Doe") == new string[] { "John Doe", "Jane Doe" };//true
    BuscarPessoa(vetor, "Alice") == new string[] { "Alice Jones" };//true
    BuscarPessoa(vetor, "James") == new string[] { };//true
    ```

### 9- Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de inteiros com no máximo dois elementos.
    ```csharp
    TransformarEmMatriz("1,2,3,4,5,6") == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }; //true 
    ```

### 10- Implemente a função abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.
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
