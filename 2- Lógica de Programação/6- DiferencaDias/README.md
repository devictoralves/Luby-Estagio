### 6️⃣ - Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
    ```csharp
    CalcularDiferencaData("10122020", "25122020") == 15; //true 
    ```
-----

### RESOLUÇÃO: 
✅ Na solução deste problema, inicialmente solicito que o usuário insira a data de início e a data de fim no formato ddMMyyyy. Em seguida, utilizei uma classe chamada "Calculadora" que possui um método público chamado "CalcularDiferencaData", responsável por converter as strings de data em objetos DateTime e chamar o método "CalcularDiferenca" para calcular a diferença em dias entre essas datas. Caso ocorra algum erro, como uma entrada inválida, utilizei o try-catch para capturar a exceção e exibir uma mensagem de erro. 