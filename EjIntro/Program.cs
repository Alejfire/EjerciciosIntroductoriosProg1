using System.Net;

/*1.Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.



Console.WriteLine("Cual es su numero de dos digitos?");



int num1 = Convert.ToInt32(Console.ReadLine());



int num2 = num1 / 10;

int num3 = num1 % 10;



int answer = num2 + num3;



Console.Write("La suma de los dos digitos es: ");

Console.WriteLine(answer);


*/
/*2.Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.



Console.WriteLine("Cual es su numero de dos digitos?");



static string PrimeCheck()

{

    int num1 = Convert.ToInt32(Console.ReadLine());



    if (num1 < 0)

    {

        return "Ese numero es negativo.";

    }

    if (num1 < 2)

    {

        return "El numero no es primo";

    }

    for (int i = 2; i <= Math.Sqrt(num1); i++)

    {

        if (num1 % i == 0)

        {

            return "El numero no es primo";

        }



    }

    return "El numero es primo";

}



Console.WriteLine(PrimeCheck());


*/
/*3.Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.



Console.WriteLine("Cual es su numero de dos digitos?");

int num1 = Convert.ToInt32(Console.ReadLine());



static string PrimeCheck(int dig)

{

    if (dig < 0)

    {

        return "digito es negativo.";

    }

    if (dig < 2)

    {

        return "digito no es primo";

    }

    for (int i = 2; i <= Math.Sqrt(dig); i++)

    {

        if (dig % i == 0)

        {

            return "digito no es primo";

        }



    }

    return "digito es primo";

}

string answer1 = PrimeCheck(num1 / 10);

string answer2 = PrimeCheck(num1 % 10);



Console.WriteLine("El primer " + answer1 + " y " + "el segundo " + answer2);


*/
/*4.Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.



Console.WriteLine("Escriba el primer numero de dos digitos");

int num1 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Escriba el segundo numero de dos digitos");

int num2 = Convert.ToInt32(Console.ReadLine());



int num3 = num1 + num2;



if (num3 % 2 == 0)

{

    Console.WriteLine("La suma de estos numeros es par");

}

else

{

    Console.WriteLine("La suma de estos numeros no es par");

}


*/
/*5.Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.



Console.WriteLine("Escriba un numero de tres digitos");

int num1 = Convert.ToInt32(Console.ReadLine());



int dig1 = num1 / 100;

int dig2 = num1 / 10 % 10;

int dig3 = num1 % 10;



Console.WriteLine(dig1);

Console.WriteLine(dig2);

Console.WriteLine(dig3);



if (dig1 >= dig2 && dig1 >= dig3)

{

    Console.WriteLine("El primer digito es mayor o igual que los demas");

}



if (dig2 >= dig1 && dig2 >= dig3)

{

    Console.WriteLine("El segundo digito es mayor o igual que los demas");

}

if (dig3 >= dig1 && dig3 >= dig2)

{

    Console.WriteLine("El tercer digito es mayor o igual que los demas");

}


*/
/*6.Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.



Console.WriteLine("Escriba un numero de tres digitos");

int num1 = Convert.ToInt32(Console.ReadLine());



int dig1 = num1 / 100;

int dig2 = num1 / 10 % 10;

int dig3 = num1 % 10;



Console.WriteLine(dig1);

Console.WriteLine(dig2);

Console.WriteLine(dig3);



if (dig1 != 0 && (dig2 % dig1 == 0 || dig3 % dig1 == 0))

{

    Console.WriteLine("El primer digito es multiplo de al menos uno de los otros digitos.");

}



if (dig2 != 0 && (dig1 % dig2 == 0 || dig3 % dig2 == 0))

{

    Console.WriteLine("El segundo digito es multiplo de al menos uno de los otros digitos.");

}



if (dig3 != 0 && (dig1 % dig3 == 0 || dig2 % dig3 == 0))

{

    Console.WriteLine("El tercer digito es multiplo de al menos uno de los otros digitos.");

}


*/
/*7.Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.



Console.WriteLine("Escriba el primer numero");

int numMayor = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Escriba el segundo numero");

int newNumber = Convert.ToInt32(Console.ReadLine());



if (numMayor < newNumber)

{

    numMayor = newNumber;

}



Console.WriteLine("Escriba el tercer numero");

newNumber = Convert.ToInt32((Console.ReadLine()));



if (numMayor < newNumber)

{

    numMayor = newNumber;

}



Console.Write("El numero mas grande es: ");

Console.WriteLine(numMayor);


*/
/*8.Leer un número entero de cinco dígitos y determinar si es un número Capicúa. 

    Ej. 15651, 59895. 



Console.WriteLine("Escriba un numero de 5 digitos");

int num = Convert.ToInt32(Console.ReadLine());



int dig1 = num / 10000;

int dig2 = num % 10;



Console.WriteLine(dig1);

Console.WriteLine(dig2);



if (dig1 == dig2)

{

    Console.WriteLine("CAPICUUAAAA!");

}

else

{

    Console.WriteLine("El numero no es capicua");


*/
/*    9.Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.



Console.WriteLine("Escriba un numero de 5 digitos");

    int num = Convert.ToInt32(Console.ReadLine());



    int dig1 = num / 100 % 10;

    int dig2 = num / 10 % 10;



    Console.WriteLine(dig1);

    Console.WriteLine(dig2);



    if (dig1 == dig2)

    {

        Console.WriteLine("El segundo digito es igual al penultimo.");

    }

    else

    {

        Console.WriteLine("El segundo digito y el penultimo no son iguales.");

    }


*/
/*    10.Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.



Console.WriteLine("Escriba el primer numero");

    int num1 = Convert.ToInt32(Console.ReadLine());



    Console.WriteLine("Escriba el segundo numero");

    int num2 = Convert.ToInt32(Console.ReadLine());



    int numMayor = num1;

    int numMenor = num2;



    if (num2 >= num1)

    {

        numMayor = num2;

        numMenor = num1;

    }



    if (numMayor == numMenor)

    {

        Console.WriteLine("Estos numeros son iguales");

    }

    else

    {

        int diff = numMayor - numMenor;



        if (diff <= 10)

        {

            Console.WriteLine("Los numeros entre estos dos numeros son");

            for (int i = numMenor + 1; i < numMayor; i++)

            {

                Console.WriteLine(i + " ");

            }

        }

        else

        {

            Console.WriteLine("La diferencia entre los numeros es mayor de 10");

        }

    }
*/