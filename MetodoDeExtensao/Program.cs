using MetodoDeExtensao.Models;

int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par? "par" : "ímpar");
Console.WriteLine(mensagem);
