namespace PruebaVector10
{
    class PruebaVector10
    {
        private string[] nombres;
        private int[] edades;

        public void Cargar()
        {
            nombres = new string[5];
            edades = new int[5];
            for (int r = 0; r < nombres.Length; r++)
            {
                Console.Write("ingrese nombre:");
                nombres[r] = Console.ReadLine();
                Console.Write("ingrese edad:");
                string linea;
                linea = Console.ReadLine();
                edades[r] = int.Parse(linea);
            }
        }
        public void MayoresEdad()
        {
            Console.WriteLine("Personas mayores de edad.");
            for (int r = 0; r < nombres.Length; r++)
            {
                if (edades[r] > 18)
                {
                    Console.WriteLine(nombres[r]);
                }
                Console.ReadKey();
            }
            static void Main(string[] args)
            {
                PruebaVector10 pv = new PruebaVector10();
                pv.Cargar();
                pv.MayoresEdad();
            }
        }
    }
}
    

        
    

