bool? receberEmail = null;

if (receberEmail.HasValue && receberEmail.Value)
{
    Console.WriteLine("O usuário quer receber email?");
}
else
{
    Console.WriteLine("O usuário não respondeu ou não quer receber email");
}