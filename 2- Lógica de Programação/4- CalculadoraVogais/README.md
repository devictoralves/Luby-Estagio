### 4️⃣- Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
    ```csharp
    CalcularVogais("Luby Software") == 4//true
    ``` 
-----

### RESOLUÇÃO: 
✅ Neste problema, começo solicitando que o usuário digite um texto. Em seguida, a partir de uma instância da classe CalcularVogais, chamo o método ContarVogais, passando o texto inserido como um argumento. Com o ContarVogais utilizo um array de caracteres contendo as vogais ('a', 'e', 'i', 'o', 'u') quee percorre cada caractere do texto verificando se ele é uma vogal por meio do VogalExisteNaLista. A contagem é realizada após isso é exibida a quantidade de vogais encontradas no texto.