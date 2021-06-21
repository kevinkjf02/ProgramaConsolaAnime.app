using System;
namespace ProgramaConsolaAnime.app
{
    public class Ninja
    {
        public string nombreNinja;
        public string apellidoNinja;
        public int edadNinja;
        public string aldeNinja;// donde el nija vive
        public string habilidadNinja;// que habilidad tiene el ninja
        public int cantidadArmamentoNinja;//la cantidad de sus armas para la misión
        public string cargoNinja;// cargo del ninjaeneste caso hay hokage, genin, chinin
        public string clanNinja; // el clan que pertenese 
        public string armamentoNinja; //que tipo de armamento tiene
        public string nacionDeMision;// a que nacion pertenese la aldea



        public void CaracteristicaNinja()
        {
            Console.WriteLine("El ninja que va realizar la misión es:" + "\n");
            ArmamentoNinja();
            HabilidadNija();
            Console.Write(nombreNinja + " " + apellidoNinja + " " + "la edad es de" + " " + edadNinja + " " + "va realizar la mision con el siguiente armamento" + " " + armamentoNinja + "" + "tiene un  cargo de" + " " + cargoNinja + "\n");
            InformacionGenerarNinja();
        }
        public void InformacionGenerarNinja()
        {
            Console.WriteLine("Ingrese la aldea donde pertenese: ");
            aldeNinja = Console.ReadLine();
            Console.WriteLine("Clan perteneciente: ");
            clanNinja = Console.ReadLine(); ;

        }
        public void ArmamentoNinja()
        {
            armamentoNinja = "Shuriken";
            int cantidadArmamentoNinja = IngresarCantidadArmanentoNinja();
            
            Console.WriteLine(nombreNinja + " " + " tiene " + cantidadArmamentoNinja + " " + armamentoNinja);
        }
        public void HabilidadNija()
        {
            habilidadNinja = "Rasengan";
            Console.WriteLine("La habilidad de " + " " + nombreNinja + "" + "es" + habilidadNinja);
        }
        static int IngresarCantidadArmanentoNinja()
        {
            Console.Write("Ingrese cantidad de su Armamento: ");

            int cantidadArmamentoNinja1;
            while (true)
            {
                var cantidadArmamentoNinja = Console.ReadLine();
                if (!int.TryParse(cantidadArmamentoNinja, out cantidadArmamentoNinja1))
                {
                    Console.Write("Ingrese un valor numérico");
                }
                else
                {
                    break;
                };
            };
            return cantidadArmamentoNinja1;
        }
    }
}
