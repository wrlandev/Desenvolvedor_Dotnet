using Encapsulamento.Models;

ContaConrrente c1 = new(100, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();