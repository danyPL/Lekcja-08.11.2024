

using Lekcja;
Zarowka zarowka = new();
Lampa lampa = new Lampa(zarowka);



Console.WriteLine($"Czy lampka jest włączona?{lampa.CheckLight()}");

lampa.TogglePower();


Console.WriteLine($"Czy lampka jest włączona?{lampa.CheckLight()}");
lampa.TogglePower();

Console.WriteLine($"Czy lampka jest włączona?(po wyłączeniu){lampa.CheckLight()}");

Console.WriteLine("Czy lampa jest spalona? " + lampa.CheckBurned());

Console.WriteLine($"Przed rozjasnieniem lampki intensywnosc to {lampa.Intesivity}");

lampa.Rozjasnij(9);
Console.WriteLine($"Po rozjasnienieniu lampki intensywnosc to {lampa.Intesivity}");
lampa.WymienZarowke();

lampa.Zarowka.ToggleLight();
Console.WriteLine($"Czy Zarowka swieci{lampa.Zarowka.CheckLight()}");

Console.WriteLine($"Czy żarówka jest spalona? {lampa.Zarowka.CheckBurned()}");

bool wymiana = lampa.WymienZarowke();
if (wymiana)
{
    Console.WriteLine($"Czy wymieniono żarówke? {wymiana}");
}
else
{
    Console.WriteLine($"Musisz wyłączyć lampke aby wymienić żarówke");
}

Console.WriteLine($"Stan po wymianie\n" +
    $"Czy lampa sie świeci? {lampa.Stan}\n" +
    $"Czy zarowka jest spalona? {lampa.Zarowka.CheckBurned()}\n" +
    $"Czy zarowka sie świeci {lampa.Zarowka.CheckLight()}");