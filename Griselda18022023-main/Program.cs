using Griselda18022023.entidades;
using Griselda18022023.negocio;

Datos datos = new Datos();
ClasDatos clasDatos = new ClasDatos();
Console.WriteLine(@"
 Bienvenido a su contador de caracteres


Advertencia: Si la frase que ingresa lleva espacios se contará como un caracter

Presione la tecla 'Enter' para continuar");
Console.ReadLine();

Console.WriteLine("Ingrese su frase o palabra");

datos.datos = Console.ReadLine();

Console.WriteLine($"\nSu frase o palabra contiene: {clasDatos.Contador(datos)} caracteres");