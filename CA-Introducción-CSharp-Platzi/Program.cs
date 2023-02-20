/*************************************************************************************************************************************************************************/

/*

// Clase 4/26.
// Introducción a Visual Studio y nuestro primer "Hola, mundo" en consola.

// Saludo

Console.WriteLine("What´s your name? Please write your full name");
var fullUserName = Console. ReadLine();

Console.WriteLine("Hello " + fullUserName + ", Welcome to Platzi!");
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 8/26.
//  Variables.

// Calculadora

int number1;
int number2;

Console.WriteLine("Input the first number");
number1 = Convert .ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number");
number2 = Convert .ToInt32(Console.ReadLine());

int result = number1 + number2;

Console.WriteLine("The result is: " + result);
*/

/*************************************************************************************************************************************************************************/

/*
// Clase: 9/26.
// Manejo de Strings 

int height = 170;
int age = 24;
string name = "German Bartoli";

string placeHolderText = "The information you requested is: ";
string information = placeHolderText + "\n Nombre: " + name + "\n Edad: "+ age + "\n Altura: "+ height;

Console.WriteLine(name);

Console.WriteLine(information);
*/

/*************************************************************************************************************************************************************************/

/*
// Class 10/26
// Working with numbers and arithmetic operators 
// Rectangle Area Calculation

// Rectangle values
int sideA = 10;
int sideB = 20;

// Rectangle area formula is a*b;
int area = sideA * sideB;

Console.WriteLine("The rectangle area is: "+ area);
*/

/*************************************************************************************************************************************************************************/

/*
// Class 11/26
// Operadores lógicos 

bool value1 = true;
bool value2 = false;
bool value3 = false;

// &&, || , !

//bool result1 = value1&& value2&& value3;
Console.WriteLine("The result of the logical AND is: " +  result1);

bool result2 = value1 || value2 || value3;
Console.WriteLine("The result of the logical OR is: " + result2);

bool result3 = !value1;

Console.WriteLine("The result of the logical NOT is: " + result3);
*/

/*************************************************************************************************************************************************************************/

/*
// Class 12/26
// Relational Operators 

int value1 = 3;
int value2 = 18;
int value3 = -18;

bool result0 = value1 == value2;
Console.WriteLine("The result of value1 == value2 is: " + result0);

bool result1 = value1 != value2;
Console.WriteLine("The result of value1 != value2 is: " + result1);

bool result2 = value1 > value2;
Console.WriteLine("The result of value1 > value2 is: " + result2);

bool result3 = value1 < value2;
Console.WriteLine("The result of value1 < value2 is: " + result3);

bool result4 = value1 >= value2;
Console.WriteLine("The result of value1 >= value2 is: " + result4);

bool result5 = value1 <= value2;
Console.WriteLine("The result of value1 <= value2 is: " + result5);
*/

/*
 * == Igual a
 * != No igual a
 * > Mayor que
 * < Menor que
 * >= Mayor o igual que
 * <= Menor o igual que
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 13/26
// Cómo leer datos de un usuario en C#. 
// Working with numbers and arithmetic operators

// Rectangle Area Calculation

Console.WriteLine("Please enter the side A of the rectangle, you can use dcecimals:");
Console.WriteLine("Note: Use '.', no ',' ");
float sideA = float.Parse(Console.ReadLine());

Console.WriteLine("Please enter the side B of the rectangle, you can use dcecimals:");
Console.WriteLine("Note: Use '.', no ',' ");
float sideB = float.Parse(Console.ReadLine());

// Rectangle area formula is a*b;
float area = sideA * sideB;

Console.WriteLine("The rectangle area is: " + area);
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 14/26
//Arreglos en C#

string[] coffeeTypes;
float[] coffeePrices;

coffeeTypes = new String[] { "Expresso", "Largo", "Filtrado", "Latte" }; // 4
coffeePrices = new float[] { 1.2f,              1.5f,       5.0f,           5.5f };

coffeeTypes[1] = "Lungo";
for (int i = 0;i < 3; i++)
{
    Console.WriteLine(coffeeTypes[i] + " $" + coffeePrices[i]);

    //Console.WriteLine($"{coffeeTypes[i]} Coffe = $ {coffeePrices[i]}");
}
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 15/26
// Listas.

List<string> tacoShoppingList = new List<string>();

tacoShoppingList.Add("Cinco Tacos de Pollo");
tacoShoppingList.Add("Cuatro Tacos de Carne");
tacoShoppingList.Add("Cuatro Tacos Picantes");
tacoShoppingList.Add("Ocho Tacos con Mayonesa");

//tacoShoppingList.Remove("Cinco Tacos de Pollo");

tacoShoppingList.RemoveAt(0);

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 16/26.
// Métodos o methods.

float[] pricesArray = new float[10];

pricesArray[0] = 1.5f;
pricesArray[1] = 2.5f;
pricesArray[2] = 3f;
pricesArray[3] = 5f;

Random random = new Random();

Console.WriteLine("Hello World of random numbers!");
Console.WriteLine($"{random.Next(1,10)}");
 */

/*************************************************************************************************************************************************************************/

/*
// Clase 17/26
// Métodos de strings

// Reto: Tu reto
//Ya conoces varios de los métodos que puedes utilizar con strings. Estos son los más comunes, pero existen unos más.

//Como reto de esta clase crea un programa donde emplees por lo menos 5 de estos métodos de strings o de algún otro que investigues. Pon a volar tu creatividad y comparte en los comentarios el programa que creaste.

// Mi reto

string text = "Hola, mundo!";

// Imprime el texto original
Console.WriteLine("Imprime el texto original:");
Console.WriteLine(text);
Console.WriteLine();

// Método Length para obtener la longitud del string
Console.WriteLine("Método Length para obtener la longitud del string:");
Console.WriteLine("El string tiene " + text.Length + " caracteres.");
Console.WriteLine();

// Método ToUpper para convertir todo el texto en mayúsculas
Console.WriteLine("Método ToUpper para convertir todo el texto en mayúsculas:");
Console.WriteLine("Texto en mayúsculas: " + text.ToUpper());
Console.WriteLine();

// Método Contains para verificar si el string contiene una palabra específica
Console.WriteLine("Método Contains para verificar si el string contiene una palabra específica:");
if (text.Contains("mundo"))
{
    Console.WriteLine("El texto contiene la palabra 'mundo'.");
}
else
{
    Console.WriteLine("El texto no contiene la palabra 'mundo'.");
}
Console.WriteLine();

// Método Split para separar el string en varias palabras
Console.WriteLine("Método Split para separar el string en varias palabras:");
string[] words = text.Split(' ');
Console.WriteLine("Las palabras del texto son:");
foreach (string word in words)
{
    Console.WriteLine("- " + word);
}
Console.WriteLine();

// Método Replace para reemplazar una palabra por otra
Console.WriteLine("Método Replace para reemplazar una palabra por otra:");
string newText = text.Replace("Hola", "Hello");
Console.WriteLine("Texto con 'Hola' reemplazado por 'Hello': " + newText);
Console.WriteLine();
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 18/26
//Cómo crear tus propios métodos

MyMethods MyProgram = new MyMethods();

MyProgram.IntegerAddition(3, 6);
Console.WriteLine();


int result = MyProgram.IntegerMultiplication(12, 2);
Console.WriteLine("El resultado de la multiplicación es: " + result);
Console.WriteLine();

// Reto
//  crea un método que ejecute la división de dos números. Como tip toma en cuenta que la mayoría de las divisiones no dan resultados enteros, por lo que necesitarás definir tu método y variables con otro tipo de dato.

// Mi reto

// Caso de prueba para IntegerDivision
Console.Write("Ingresa el primer número (dividendo): ");
int a = int.Parse(Console.ReadLine());


Console.Write("Ingresa el segundo número (divisor): ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine();

double resultDivision = MyProgram.IntegerDivision(a, b);

if (b == 0)
{
    Console.WriteLine("Error: no se puede dividir por cero.");
}
else
{
    Console.WriteLine("El resultado de la división es: " + resultDivision);
}
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 19/26
// La sentencia if

int anyValue = 7;
string message = "";

if (anyValue == 7)
{
    message = $"La variable {nameof(anyValue)} tiene como valor {anyValue}";
}
else 
{
    message = "el valor de la variable no es 7";
}

Console.WriteLine($"La respuesta es: {message}");
 */

/*************************************************************************************************************************************************************************/

/*
// Clase 20/26.
// La sentencia Switch.

Console.WriteLine("Enter the selected soda: ");
string caseSwitch = Console.ReadLine();

switch (caseSwitch)
{
    case "cola":
        Console.WriteLine("Cola soda - $2 USD");
        break;
    case "lime":
        Console.WriteLine("Lime soda - $1 USD");
        break;
    case "orange":
        Console.WriteLine("Orange soda - $1.5 USD");
        break;
    case "apple":
        Console.WriteLine("Apple soda - $1 USD");
        break;
    default:
        Console.WriteLine("ERROR: You did not select a soda or you entered an incorrect value.");
        break;
}
 */

/*************************************************************************************************************************************************************************/

/*
// Clases 21/26
// Ciclo For

for (int i = 0; i < 50; i++)
{
    Console.WriteLine($"Variable {i}");
}
*/

/*************************************************************************************************************************************************************************/

/*
// Clase 22/26.
// Ciclo while.

bool continueSoftwareExecution = true;

while (continueSoftwareExecution == true)
{
    Console.WriteLine("Desea que el software continue ejecutandose? 1 para si, 0 para no");
    int keepGoing = Convert.ToInt16(Console.ReadLine());

    if (keepGoing == 1)
        Console.WriteLine("El software seguirá ejecutandose");
    else if (keepGoing == 0)
    {
        Console.WriteLine("El software se detuvo");
        continueSoftwareExecution = false;
    }

    else
        Console.WriteLine("Error");

    Console.WriteLine($"La variable {nameof(continueSoftwareExecution)} tiene como valor {continueSoftwareExecution}");
}
*/

/*************************************************************************************************************************************************************************/

// Clases 23/26 y 24/26
// Introducción del proyecto: sistema de registros de usuarios.

/*
 * 1. Validar si es usuario es existente o si se debe registrar y generar un sistema de registro o login.
 * 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe.
 * 3. El programa debe repetirse hasta que se registren las 10 personas.
*/

/*

// Declaración de variables
string[] userNames = new string[10] { "German", "", "", "", "", "", "", "", "", "", };
int arrayCurrentIndex = 1;
bool userType = false;

// Mensaje de bienvenida
Console.WriteLine("¡Bienvenido al mejor restaurante del Mundo!");

// Bucle principal del programa
while (arrayCurrentIndex <= 10) // Salir del bucle cuando se hayan registrado las 10 personas
{
    // Preguntar si el usuario es existente
    Console.WriteLine("¿Eres un usuario registrado? Escribe 1 por sí, 0 por no.");

    // Validar la entrada del usuario
    int input;
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Por favor, ingresa un valor numérico (1 o 0).");
    }

    // Establecer el tipo de usuario
    userType = (input == 1);

    // Si el usuario existe, pedir su nombre de usuario y buscarlo en la lista
    if (userType)
    {
        Console.WriteLine("Hola, eres un usuario registrado. Por favor, ingresa tu nombre de usuario.");
        string userToSearch = Console.ReadLine();

        if (Array.IndexOf(userNames, userToSearch) != -1)
        {
            Console.WriteLine($"¡Bienvenido de vuelta, {userToSearch}!");
        }
        else
        {
            Console.WriteLine($"Lo siento, no encontramos el usuario {userToSearch} en nuestra base de datos.");
        }
    }
    // Si el usuario no existe, pedir su nombre y registrarlo
    else
    {
        Console.WriteLine("Por favor, ingresa tu nombre para registrarte.");
        string newUser = Console.ReadLine();

        if (arrayCurrentIndex < 10)
        {
            userNames[arrayCurrentIndex] = newUser;
            arrayCurrentIndex++;
            Console.WriteLine($"¡Bienvenido al restaurante, {newUser}! Tu registro ha sido exitoso.");
        }
        else
        {
            Console.WriteLine("Lo siento, ya hemos alcanzado el límite de usuarios registrados.");
        }
    }
}
*/

/*************************************************************************************************************************************************************************/

// Clase 25/26
//Finalizado del proyecto: mostrando la lista de usuarios registrados 

/*
 * 1. Validar si es usuario es existente o si se debe registrar y generar un sistema de registro o login.
 * 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe.
 * 3. El programa debe repetirse hasta que se registren las 3 personas.
*/

// Declaración de variables
string[] userNames = new string[3] { "German", "",""};
int arrayCurrentIndex = 1;
bool userType = false;

// Mensaje de bienvenida
Console.WriteLine("¡Bienvenido al mejor restaurante del Mundo dirigido por German!");
Console.WriteLine();

// Bucle principal del programa
while (arrayCurrentIndex <= 2) // Salir del bucle cuando se hayan registrado las 3 personas
{
    // Preguntar si el usuario es existente
    Console.WriteLine("¿Eres un usuario registrado? Escribe 1 por sí, 0 por no.");

    // Validar la entrada del usuario
    int input;
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine();
        Console.WriteLine("Por favor, ingresa un valor numérico (1 o 0).");
    }

    // Establecer el tipo de usuario
    userType = (input == 1);

    // Si el usuario existe, pedir su nombre de usuario y buscarlo en la lista
    if (userType)
    {
        Console.WriteLine();
        Console.WriteLine("Hola, eres un usuario registrado. Por favor, ingresa tu nombre de usuario.");
        string userToSearch = Console.ReadLine();

        if (Array.IndexOf(userNames, userToSearch) != -1)
        {
            Console.WriteLine();
            Console.WriteLine($"¡Bienvenido de vuelta, {userToSearch}! Adelante!");
            Console.WriteLine();
            Console.WriteLine("Siguiente!!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Lo siento, no encontramos el usuario {userToSearch} en nuestra base de datos.");
            Console.WriteLine($"Ingrese a continuación 0 y cree su usuario.");
            Console.WriteLine();
        }
    }
    // Si el usuario no existe, pedir su nombre y registrarlo
    else
    {
        Console.WriteLine();
        Console.WriteLine("Por favor, ingresa tu nombre para registrarte.");

        string newUser = Console.ReadLine();

        if (arrayCurrentIndex < 4)
        {
            userNames[arrayCurrentIndex] = newUser;
            arrayCurrentIndex++;

            Console.WriteLine();
            Console.WriteLine($"¡Bienvenido al restaurante, {newUser}! Tu registro ha sido exitoso.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Lo siento, ya hemos alcanzado el límite de usuarios registrados.");
            Console.WriteLine();
        }
    }
}

// Mensaje de despedida
Console.WriteLine("Hemos alcanzado el límite de usuarios registrados!");
Console.WriteLine();
Console.WriteLine("Gracias por visitar el mejor restaurante del Mundo.");
Console.WriteLine();
Console.WriteLine("Estos son los invitados al restaurante:");
Console.WriteLine();

int auxIndex = 0;

foreach (string element in userNames)
{
    //Console.WriteLine("Usuario Número: {0} Nombre de usuario: {1}", auxIndex+1, userNames[auxIndex]);
    Console.WriteLine("Usuario Número: {0}", auxIndex+1);
    Console.WriteLine("Nombre de usuario: {0}", userNames[auxIndex]);
    Console.WriteLine();
    auxIndex++;
}

/*************************************************************************************************************************************************************************/
