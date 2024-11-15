using System.Diagnostics;

class Program

{
    static void Main(string[] args)
    {
        //Antes que nada voy a iniciar el archivo de filtro
        string fileRoute = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "filter.txt");
        List<string> listaPalabrasFiltradas = new List<string>();

        try
        {
            if (File.Exists(fileRoute))
            {

                //Ahora inicializamos la lista con el rango del archivo
                listaPalabrasFiltradas.AddRange(File.ReadAllLines(fileRoute));
                Console.WriteLine("Se ha abierto el archivo y se ha cargado el filtro");

            }
        }
        //TODO Manejar la excepción
        catch (System.Exception)
        {

            throw;
        }
        //En este punto ya tenenmos una lista con las palabras que hay que filtrar

        //Process procesoHijo = new Process();



    }

}
