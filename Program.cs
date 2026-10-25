/*Receba 4 notas, com somente uma casa decimal. Valide se todas estão entre 0.0 e 10.0. Se alguma delas não estiver, exiba "Digite somente notas entre 0 e 10.". Caso todas as notas sejam válidas, calcule a média aritmética das notas. Exiba uma mensagem no seguinte padrão: "Você ficou com média 7,5. Resultado: Aprovado".

Resultados possíveis:
"Reprovado" para médias menores que 5.0
"Em recuperação" para médias entre 5.0 e 6.0
"Aprovado", para médias acima de 6.0
*/

Console.WriteLine("---media notas---");
Console.Write("NOTA 1: ");
double nota01 = Convert.ToDouble(Console.ReadLine());
Console.Write("NOTA 2: ");
double nota02 = Convert.ToDouble(Console.ReadLine());
Console.Write("NOTA 3: ");
double nota03 = Convert.ToDouble(Console.ReadLine());
Console.Write("NOTA 4: ");
double nota04 = Convert.ToDouble(Console.ReadLine());
if (nota01 < 0 || nota01 > 10 || nota02 < 0 || nota02 > 10 || nota03 < 0 || nota03 > 10 || nota04 < 0 || nota04 > 10)
{
    Console.WriteLine("DIGITE UMA NOTA VALIDA!");
}
else
{
    double media = ((nota01 + nota02 + nota03 + nota04) / 4); 
Console.WriteLine($"Sua media é: {media:N1}");
if (media > 6)
{
    Console.WriteLine("Aprovado!");
}
if (media >= 5 && media <= 6)
{
    Console.WriteLine("Em recuperaçaõ");
}
if (media < 5)
{
    Console.WriteLine("reprovado");
}

}

