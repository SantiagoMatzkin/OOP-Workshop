namespace Presentation
{
    using Domain;
    using Domain.Media;
    using Domain.Users;

    public static class Menu
    {
        public static void MainMenu()
        {
            Library library = new Library();
            // Inicializa usuarios y medios de ejemplo

            Console.WriteLine("Identifícate como:\n1. Admin\n2. Employee\n3. Borrower");
            string roleInput = Console.ReadLine();

            // Lógica para seleccionar menú según el input, luego mostrar acciones disponibles
            // Ejemplo:
            // Si Borrower: Listar medios, ver detalles, descargar, calificar, pedir prestado, devolver
            // Si Employee/Admin: Añadir/quitar medios; Admin puede crear/modificar usuarios
        }
    }
}
