using System;
namespace ProgramaConsolaAnime.app
{
    class LiderAcargo
    {

        public string nombreLiderAcargo;
        public string apellidoLiderAcargo;
        public int edadLiderAcargo;
        public string aldeaLiderAcargo;
        public string habilidadLiderAcargo;
        public string cargoLiderAcargo;
        public string clanLiderAcargo;
        public string nacionDeLider;
        public string armamentoLiderAcargo;
        public int cantidadArmamentoLider;

        public void informacionLider()
        {
            Console.WriteLine("El lider de grupo es " + nombreLiderAcargo + "y su apellido es " + apellidoLiderAcargo + ", su edad es:" + edadLiderAcargo + " el tiene cargo de " + " " + cargoLiderAcargo);
            aldealider();
            Console.WriteLine("La aldea perteneciente es " + aldeaLiderAcargo + ", su clan es: " + clanLiderAcargo+ " y su nacion es:"+nacionDeLider);
            Habilidad();
            ArmamentoLider();
        }
        public void aldealider()
        {
            Console.WriteLine("Ingrese mas informacion de " + " " + nombreLiderAcargo);
            Console.WriteLine("La aldea perteneciente es: ");
            aldeaLiderAcargo = Console.ReadLine();
            Console.WriteLine("El clan que pertenese es :");
            clanLiderAcargo = Console.ReadLine();
        }
        public void Habilidad()
        {
            habilidadLiderAcargo = "Sharingan";
            Console.WriteLine("La habilidad de " + " " + nombreLiderAcargo + "" + "es" + habilidadLiderAcargo);
        }
        public void ArmamentoLider()
        {
            armamentoLiderAcargo = "Shuriken";
            int cantidadArmamentoLider = IngresarCantidadArmanentoLider();
            Console.WriteLine(nombreLiderAcargo + " " + " tiene " + cantidadArmamentoLider + " " + armamentoLiderAcargo);
        }
        static int IngresarCantidadArmanentoLider()
        {
            Console.Write("Ingrese cantidad de su Armamento: " );

            int cantidadArmamentoLider1;
            while (true)
            {
                var cantidadArmamentoLider = Console.ReadLine();
                if (!int.TryParse(cantidadArmamentoLider, out cantidadArmamentoLider1))
                {
                    Console.Write("Ingrese un valor numerico");
                }
                else
                {
                    break;
                };
            };
            return cantidadArmamentoLider1;
        }
    }




}
