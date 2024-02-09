using System.Globalization;

DateTime data = DateTime.Now;
DateTime data2 = DateTime.Now;

string dataString = "2022-12-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
"yyyy-MM-dd HH:mm",
CultureInfo.InvariantCulture,
DateTimeStyles.None, out data2);

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso {data2}");
}