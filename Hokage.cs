using System;
namespace ProgramaConsolaAnime.app
{
    public class Hokage
    {
        public string nombreHokage;
        public string apellidoHokage;
        public int edadHokage;
        public string aldeHokage;
        public string habilidadHokage;
        public string numeroHokage;
        public string cargoHokage;
        public string clanHokage;
        public string armamentoHokage;
        public string nacionDeHokage;



        public void CaracteristicaHokage()
        {
            Console.WriteLine("El Hokage acargo de la aldea es:" + "\n");
            Console.Write(nombreHokage + " " + apellidoHokage + " " + "la edad es de" + " " + edadHokage + " " + "tiene un  cargo de" + " " + cargoHokage + " " + "y es el " +" "+ numeroHokage+  "\n");
            InformacionGenerarHokage();
            HabilidadHokage();
            ArmamentoHokage();
        }
        public void InformacionGenerarHokage()
        {
            Console.WriteLine("Ingrese la aldea donde pertenese" + " " + nombreHokage);
            aldeHokage = Console.ReadLine();
            Console.WriteLine("Clan perteneciente");
            clanHokage = Console.ReadLine(); ;

        }
        public void ArmamentoHokage()
        {
            armamentoHokage = "Kunai";
            Console.WriteLine(nombreHokage + " " + " tiene " + " " + armamentoHokage + " " + "para cada misión");
        }
        public void HabilidadHokage()
        {
            habilidadHokage = "Dios del Trueno";
            Console.WriteLine("La habilidad de " + " " + nombreHokage + " " + "es" + " " + habilidadHokage);
        }

    }
}