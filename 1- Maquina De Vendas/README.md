### Desenvolver programa que rode uma **Vending Machine (Máquina de venda de bebidas em lata)** utilizando orientação objetos conforme as regras abaixo.
> - Crie uma interface de usuário simples para execução da máquina. (Utilizando Console por exemplo)
> - A máquina deverá possuir um estoque de produtos com valor e quantidade de cada produto. 
>   A quantidade de produto no estoque da máquina deve ser alterado conforme realização de vendas dos produtos.
> - A máquina deverá ter opção para visualizar estoque e quantidade disponível.
> - A máquina só pode vender produtos com quantidade em estoque disponível.
> - A máquina deverá contabilizar as vendas e mostrar o valor total das vendas realizadas.
> - Uma venda só poderá ser concluída ao inserir o valor total do produto.
> - A máquina deverá contabilizar e solicitar o valor faltante para finalizar a venda, caso haja valor de troco para deverá informar o valor.
> - A máquina não necessita de lógica de contagem de notas, será apenas necessário informar os valores.
> - Caso necessário crie um documento simples com informações de como executar o programa.

# ⚠️ SENHA PARA ACESSO A AREA RESTRITA: 8708 ⚠️

Na solução, optei por isolar em uma "area restrita" a opção de mostrar o valor total das vendas, assim como também opções adicionais para adicionar, editar e excluir itens, visando uma maior operacionalidade para a maquina.

Sobre o código, iniciei definindo uma variável booleana chamada continuarOperacao como verdadeira e uma instância da classe VendingMachine chamada maquinaVendas.

Em seguida, iniciei um loop while que continua enquanto a variável continuarOperacao for verdadeira. Dentro desse loop, é exibido um menu no console com várias opções, onde o usuário deve escolher uma opção digitando um número. Dependendo da opção escolhida, diferentes métodos da classe VendingMachine e da classe MenuGerenciamento são chamados para realizar a operação correspondente.

No código utilizei algumas classes adicionais, como a classe Produto, que representa os produtos disponíveis na máquina, a classe Estoque que gerencia o estoque dos produtos, e a classe MenuGerenciamento que lida com operações restritas, como visualizar vendas, adicionar e editar produtos.

Os métodos ComprarProduto, VisualizarProdutos, e outros na classe VendingMachine implementam as funcionalidades principais da máquina de vendas, como a compra de produtos, a visualização do estoque e a manipulação do dinheiro.

O código também inclui métodos para formatar a exibição de produtos e ler entradas do usuário com opção de cancelamento.

Em resumo, o programa simula uma máquina de vendas com funcionalidades como compra de produtos, visualização do estoque e operações restritas de gerenciamento. 