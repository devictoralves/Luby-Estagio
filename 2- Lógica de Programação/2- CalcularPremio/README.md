### 2️⃣ Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:
    - Tipo: "basic" fator multiplicação do prêmio: 1
    - Tipo: "vip" fator multiplicação do prêmio: 1.2
    - Tipo: "premium" fator multiplicação do prêmio: 1.5
    - Tipo: "deluxe" fator multiplicação do prêmio: 1.8
    - Tipo: "special" fator multiplicação do prêmio: 2
- **Regras**
    - A função também deverá provir um parâmetro para que seja passado fator de multiplicação próprio.
    - Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
    - O prêmio nunca deve ter um valor negativo ou igual a zero.
----------

### RESOLUÇÃO: 
✅ Para resolver o problema, criei a classe 'CalculadoraPremio' com o método 'CalcularPremio', que recebe valores como parâmetros. Utilizei de um dicionário para armazenar os fatores multiplicadores, o método calcula o fator total, levando em consideração o fator do dicionário e um fator multiplicador próprio opcional. Ao final o prêmio total é calculado multiplicando o valor original pelo fator total, retornando o resultado se for maior que 0, caso contrário, retorna 0.
