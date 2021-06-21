using System;
namespace ProgramaConsolaAnime.app
{
    public class Misiones
    {
        public string nombreMision;
        public string categoriaMision;
        public string liderDeMision;
        public string integrantesMision1;// primer integrante
        public string integrantesMision2;//Segundo integrante
        public string nacionDeMision;
        public string quienMandaLaMision;// quien asigna la misión
        public string ubicacionDeLaMision;// ubicacion donde toca ir hacer la misión
        public string detalleMision;// de que se trata la misión
        public string valorporMision; // cuanto cuesta hacer la misión

        public void MisionesAsignadas()
        {
            Console.WriteLine("Nombre de la mision que vas a realizar: "+nombreMision);
            Console.WriteLine("El lider de grupo va ser : " + liderDeMision);
            Console.WriteLine("La nacion de la misión: " + nacionDeMision);
            Console.WriteLine("La ubicacion de la mision es: " + ubicacionDeLaMision);
            Console.WriteLine("Quien asigno la misión: " + quienMandaLaMision);
            IngresodeIntegrantes();
            DetalleMisionG();
            CategoriaMisionG();




        }
        public void IngresodeIntegrantes()
        {
            Console.WriteLine("Ingrese nombres de integrantes para la misión:");
            Console.WriteLine("Integrante 1:");
            integrantesMision1 = Console.ReadLine();
            Console.WriteLine("Integrante 2:");
            integrantesMision2 = Console.ReadLine();

        }

        public void DetalleMisionG()
        {
            valorporMision = "50,000$ rion";
            detalleMision = "Tiene que escoltar un jefe de otra aldea , acompañaerlo y llevarlo con vida";
            Console.WriteLine("La misión consta de: " + detalleMision + "y el coste de la misión es: "+valorporMision);
        }
        public void CategoriaMisionG()
        {
            categoriaMision = "S";
            Console.WriteLine("La categoria depende de que rango tienes como ninga en este caso la categoria es:" + categoriaMision);

        }

    }
    
}
