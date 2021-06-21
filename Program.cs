using System;
    
namespace ProgramaConsolaAnime.app
{
    class Program
    {
        static void Main(string[] args)
        {
            InformacionNinja(args);
            InformacionMisiones(args);
            InformacionLiderAcargo(args);
            InformacionHokage(args);
            Console.ReadKey();
        }
        static void InformacionNinja(string[] args)
        {
            Ninja infoNinja = new Ninja();
            infoNinja.nombreNinja = "Naruto";
            infoNinja.apellidoNinja = "Uzumaqui";
            infoNinja.edadNinja = 15;
            infoNinja.cargoNinja = "Gening";
            infoNinja.CaracteristicaNinja();
        }
        static void InformacionMisiones(string[] args)
        {
            Misiones infoMision = new Misiones();
            infoMision.nombreMision = "Escolta un Jefe";
            infoMision.liderDeMision = "Kakashi";
            infoMision.quienMandaLaMision = "Hokage";
            infoMision.nacionDeMision = "Suna";
            infoMision.ubicacionDeLaMision = "Aldea Oculta de Las Nubes";
            infoMision.MisionesAsignadas();
        }
        static void InformacionLiderAcargo(string[] args)

        {
            LiderAcargo infolider = new LiderAcargo();
            infolider.nombreLiderAcargo = "Kakashi";
            infolider.apellidoLiderAcargo = "Hatake";
            infolider.edadLiderAcargo = 25;
            infolider.cargoLiderAcargo = "Jonin";
            infolider.nacionDeLider = "Konoha";
            infolider.informacionLider();
        }
        static void InformacionHokage(string[] args)

        {
            Hokage infoHokage = new Hokage();
            infoHokage.nombreHokage = "Minato";
            infoHokage.apellidoHokage = "Namikaze";
            infoHokage.edadHokage = 26;
            infoHokage.cargoHokage = "Hokage";
            infoHokage.numeroHokage = "Cuarto";
            infoHokage.CaracteristicaHokage();

        }

        }
}
