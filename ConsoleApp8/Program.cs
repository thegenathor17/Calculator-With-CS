namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operacion;
            Console.WriteLine("Bienvenido a la calculadora de Nahum!");
            Console.WriteLine("Elije que quieres hacer, marca 1 para sumar dos numeros, marca 2 para restar dos numeros, marca 3 para multiplicar 2 numeros o marca 4 para dividir dos numeros");
            Operacion = Console.ReadLine();
            int Operador = int.Parse(Operacion);
            if (Operador == 1) //Suma
            {
                string num1;
                string num2;
                Console.WriteLine("Escribe el primer numero que quieras sumar: ");
                num1 = Console.ReadLine();
                Console.WriteLine("Escribe el segundo numero que quieras sumar: ");
                num2 = Console.ReadLine();
                decimal miInteger1 = decimal.Parse(num1);
                decimal miInteger2 = decimal.Parse(num2);
                Console.Read();
                decimal res = Sumar(miInteger1, miInteger2);
                Console.WriteLine("Tu resultado es: {0}", res);
            }
            else if (Operador == 2) //Resta
            {
                string num1;
                string num2;
                Console.WriteLine("Escribe el primer numero: ");
                num1 = Console.ReadLine();
                Console.WriteLine("Escribe el numero que le quieres restar: ");
                num2 = Console.ReadLine();
                decimal miInteger1 = decimal.Parse(num1);
                decimal miInteger2 = decimal.Parse(num2);
                Console.Read();
                decimal res = Restar(miInteger1, miInteger2);
                Console.WriteLine("Tu resultado es: {0}", res);
            }
            else  if (Operador == 3) //Multiplicacion
            {
                string num1;
                string num2;
                Console.WriteLine("Escribe el primer numero: ");
                num1 = Console.ReadLine();
                Console.WriteLine("Escribe el numero que le quieres restar: ");
                num2 = Console.ReadLine();
                decimal miInteger1 = decimal.Parse(num1);
                decimal miInteger2 = decimal.Parse(num2);
                Console.Read();
                decimal res = Restar(miInteger1, miInteger2);
                Console.WriteLine("Tu resultado es: {0}", res);
            }
            else if (Operador == 4) //Division
            {
                string num1;
                string num2;
                Console.WriteLine("Escribe el divisor: ");
                num1 = Console.ReadLine();
                Console.WriteLine("Escribe el numero que le quieres dividendo: ");
                num2 = Console.ReadLine();
                decimal miInteger1 = decimal.Parse(num1);
                decimal miInteger2 = decimal.Parse(num2);
                Console.Read();
                decimal res = Dividir(miInteger1, miInteger2);
                Console.WriteLine("Tu resultado es: {0}", res);
            }
        }
        //Nivel de acceso - (static) - Tipo de retorno - Nombre del metodo (Parametro 1, Parametro 2)
        public static decimal Sumar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal Restar(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal Multiplicar(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public static decimal Dividir(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
