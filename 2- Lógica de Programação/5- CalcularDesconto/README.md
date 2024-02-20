### 5️⃣- Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado. Lembre-se que as entradas e saídas dos dados são strings que devem ser tratadas.
    ```csharp
    CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"; //true 
    ```
-----

### RESOLUÇÃO: 
✅ Na resolução deste problema, primeiramente, solicito ao usuário que insira o valor original e o desconto, ambos em formato de string. Em seguida, utilizo a classe Calculadora para formatar esses valores e calcular o novo valor com desconto. Ainda na classe Calculadora converto as strings de entrada em valores numéricos, aplicando o desconto e formatando o resultado como uma string representando um valor monetário em real (R$) com duas casas decimais. Por fim, o programa imprime o resultado na tela.