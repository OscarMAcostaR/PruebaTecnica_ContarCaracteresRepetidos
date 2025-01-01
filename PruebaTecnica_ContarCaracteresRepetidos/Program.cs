//Prueba Tecnica Contar cuantas veces de repite un caracter en una cadena

Console.WriteLine("Ingrese una cadena");
string cadena = Console.ReadLine();

Console.WriteLine("Ingrese el caracter");
string caracter = Console.ReadLine();

//contador 
int contador = 0;

// Todos los strings cuentan con un metodo llamado Enumerable.Count que permite contar cuantas veces se repite un caracter en una cadena
//Estos se pueden contar mediante un ciclo for o un ciclo foreach

//Metodo 1
/*
foreach (var c in cadena)
{
	if(c == caracter[0])
	{
		contador++;
	}

}
*/
//Metodo 2
contador = cadena.Where(c => c == caracter[0]).Count();	


Console.WriteLine($"Se repite la letra {caracter} {contador} veces");