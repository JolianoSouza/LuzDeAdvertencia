string entradaT, entradaP, entradaR;
bool sensorT, sensorP, sensorR, luzAdvertenciaW;

Console.WriteLine("Simulador de luz de advertência ---\n");
Console.WriteLine("[A]tivado, [D]esativado\n");

Console.Write("sensor de temperatura...:");
entradaT = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaT != "A" && entradaT != "D")
{
    Console.WriteLine("valor inválido.");
    return;
}
sensorT = entradaT == "A";

Console.Write("Sensor de pressão.......:");
entradaP = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaP != "A"&& entradaP != "D")
{
    Console.WriteLine("Valor inválido.");
    return;
}
sensorP = entradaP == "A";

Console.Write("Sensor de rotação.......:");
entradaR = Console.ReadLine()!. Trim().Substring(0, 1).ToUpper();

if (entradaR != "A" && entradaR != "D")
{
    Console.WriteLine("valor inválido.");
    return;
}
sensorR = entradaR == "A";

luzAdvertenciaW = sensorT && (sensorP || !sensorR);

Console.WriteLine($"\nA luz de advertência estará {(luzAdvertenciaW ? "ATIVADA" : "DESATIVADA")}.");