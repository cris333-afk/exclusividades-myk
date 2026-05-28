namespace exclusividades_myk

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 login = new Form1();

            Sistema.Productos.Add(
               new Producto(1, "Blusa Tirantes", 3500, 10));

            Sistema.Productos.Add(
                new Producto(2, "Jeans", 14000, 5));

            Sistema.Productos.Add(
                new Producto(3, "Camiseta", 7500, 3));

            Sistema.Usuarios.Add(
               new Usuario("admin", "1234", "Administrador"));

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form2());
            }

            Sistema.Clientes.Add(
    new Cliente(402510409, "Lathrell", "88564588"));

            Sistema.Clientes.Add(
                new Cliente(111234864, "Cris", "77569877"));

        }
    }
}