using System.Globalization;

var date1 = new DateTime(2022, 06, 21).ToString();
var date2 = "21/06/2022 08:19:06";
//var date2 = "21/06/2022 00:00:00";

var dateP1 = DateTime.ParseExact(s: date1, format: "dd/MM/yyyy HH:mm:ss", provider: CultureInfo.GetCultureInfo("pt-BR"));
var dateP2 = DateTime.ParseExact(s: date2, format: "dd/MM/yyyy HH:mm:ss", provider: CultureInfo.GetCultureInfo("pt-BR"));
int result = DateTime.Compare(dateP1.Date, dateP2.Date);

Console.WriteLine(result);
