namespace NetCoreYouTube.Models
{
    public class Usuario
    {
        public string idUsuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public static List<Usuario> Db()
        {
            var list = new List<Usuario>()
            {
                new Usuario
                {
                    idUsuario = "1",
                    usuario = "Mateo",
                    password = "12345",
                    rol = "empleado",
                },
                new Usuario
                {
                    idUsuario = "2",
                    usuario = "Marcos",
                    password = "12345",
                    rol = "empleado",
                },
                new Usuario
                {
                    idUsuario = "3",
                    usuario = "Lucas",
                    password = "12345",
                    rol = "asesor",
                },
                new Usuario
                {
                    idUsuario = "4",
                    usuario = "Juan",
                    password = "12345",
                    rol = "administrador",
                }
            };
            return list;
        }
    }
}
