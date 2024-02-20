### 9️⃣ - Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
    ```csharp
    int[] vetor = new int[] { 1,2,3,4,5 };
    ObterElementosPares(vetor) == new int { 2, 4 }; //true 
    ```
-----

### RESOLUÇÃO: 
✅ Na solução desse problema, solicito ao usuário que insira os números, chamo a função TransformarEmMatriz para processar a entrada e exibo a matriz resultante no console usando um loop foreach e a função Join para formatar a saída. 

Na classe ConversorDeNumeros na função TransformarEmMatriz, faço o Split para dividir a string de entrada nos separadores de vírgula e Select para converter cada substring em um número inteiro, armazenei o resultado em um array chamado "numeros". Em seguida, criei uma matriz chamada "matriz" para armazenar os pares de números. Um loop for para percorrer o array "numeros", agrupando em pares e inserindo na matriz. Quando o último par está incompleto, crio um array com um único elemento para representar esse último par.

