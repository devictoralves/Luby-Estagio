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
✅ Para solucionar esse problema, decidi criar uma classe denominada 'CalculadoraPremio', nela inseri a base para calcular um método chamado 'CalcularPremio', este método recebe três parâmetros: valor (um número decimal que representa algum valor), tipo (uma string que indica o tipo de prêmio) e multProprio (um número decimal opcional que representa um fator multiplicador próprio).

O método utiliza um dicionário que chamei de fatores, onde são armazenados os fatores multiplicadores dos vários tipos de prêmios fornecidos na chamada do teste. Logo em seguida ele recebe o fator multiplicador correspondente ao tipo de prêmio e se o prêmio não estiver no dicionário, é utilizado um fator multiplicador padrão de 1.0.

Depois disso, o método calcula o fator multiplicador total (multTotal) usando o valor máximo entre o fator do dicionário e multProprio (se for fornecido), ou 0 se multProprio não estiver presente.

Depois o prêmio total é determinado multiplicando o valor original -que o usuario inserir- pelo fator multiplicador total. Se o resultado for maior que 0, esse valor é retornado como o prêmio total; caso contrário, é retornado 0.
