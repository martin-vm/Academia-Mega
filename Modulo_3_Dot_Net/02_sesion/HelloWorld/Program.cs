// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.ComponentModel;


//@->20250512T0910 Mi primer programilla con Liderly con C#

class Program
{

    private static Dictionary<string,string> usuarios = new Dictionary<string, string>
    {
        {"admin","qwerty"},
        {"mvillasenor","12345"},
        {"test","test"}
    };

    private const int MAX_ATTEMPS = 3;

   static void Main ( string[] args ) 
   {
        //Mensaje de bienvenida
        
        Console.WriteLine("Este es el programa oficinal de Hola Mundo");
        Console.WriteLine("Tienes que iniciar sesión \n");                
        //Definir el usuario y la contraseña        

         
        Console.WriteLine("Escribe tu usuario");        
        string? usuarioCapturado =  TryLogin(); //Console.ReadLine();

        if ( usuarioCapturado != null )
        {
            Console.WriteLine($"Hola {usuarioCapturado}");
        }
        else
        {
            Console.WriteLine("Has excedido el número de intentos");
        }
        
            
        Console.WriteLine("\n Presiona enter para salir del programa ");
        Console.ReadLine();                
   }

    private static string? TryLogin()
    {
        int intentosRestantes = MAX_ATTEMPS ;
        while ( intentosRestantes > 0 )
        {
            Console.WriteLine($"\nIntentos restantes: {intentosRestantes}");
            Console.Write("Ingresa tu nombre de usuario: ");            
            string? userLogged = Console.ReadLine();
            Console.WriteLine( "Escribe tu contraseña: " );
            string? passIngresada = ReadPassword();

            if ( string.IsNullOrWhiteSpace(userLogged) || string.IsNullOrWhiteSpace(passIngresada) ) //Aquí va el password
            {
                Console.WriteLine("Debe de especificar un dato valido");
                intentosRestantes--;
                continue;
            }        

            if ( usuarios.ContainsKey(userLogged)  && usuarios[userLogged] ==  passIngresada)
            {
                Console.WriteLine("Autenticación conseguida de manera adecuada");
                return userLogged;                                
            }
            else
            {
                Console.WriteLine("Usuario o contarseña incorrecta, intente nuevamente.");
                intentosRestantes--;
            }
                            
        }
        return null;
        
    }

   private static string ReadPassword()
   {
        
        StringBuilder password = new StringBuilder();
        ConsoleKeyInfo keyInfo;
        //return null;

        do
        {
            keyInfo = Console.ReadKey(true);
            if ( !char.IsControl(keyInfo.KeyChar ) )
            {
                password.Append( keyInfo.KeyChar );
                Console.WriteLine("*");
            }
            else if( keyInfo.Key == ConsoleKey.Backspace && password.Length > 0 )
            {
                password.Remove( password.Length -1 ,1 );
                Console.Write("\b \b");
            }
        }
        while(keyInfo.Key != ConsoleKey.Enter ); 
        Console.WriteLine();
        return password.ToString();


   }   
}


