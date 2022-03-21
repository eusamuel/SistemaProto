using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.Entity;

namespace Sistema
{
    internal class Repositorio : DbContext
    {
        // Singleton
        private static MySqlConnection mySqlConnection = null;

        // Tabela "usuarios"
        public DbSet<Usuario> Usuarios { get; set; }

        public Repositorio() : base(GetDBConnection(), false)
        {
            // Se o banco não existe e agora foi corretamente criado,...
            if (Database.CreateIfNotExists())
            {
                // ... a partir deste próprio objeto, ...
                using (var dbContext = this)
                {
                    // ... cria um novo usuário com dados padrão ...
                    Usuario usuario = new Usuario()
                    {
                        Nome = "Administrador",
                        Email = "admin@mail.com",
                        Senha = "asdf",
                        Nascimento = DateTime.Now.AddYears(-25)
                    };

                    // ... e o salva no banco de dados.
                    dbContext.Usuarios.Add(usuario);
                    dbContext.SaveChanges();
                }
            }

            // Registro de todas operações no BD em terminal (OPCIONAL)
            Database.Log = Console.WriteLine;
        }

        // Quando for criar o modelo (tabelas) no banco de dados...
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ... o email de Usuario é do tipo único.
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

        // Singleton
        public static MySqlConnection GetDBConnection()
        {
            if (mySqlConnection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SistemaConnectionString"].ConnectionString;
                //  ^^^^^^^^^^^^^^^^^^^^^^^ ConnectionString em App.config
                mySqlConnection = new MySqlConnection(connectionString);
            }
            return mySqlConnection;
        }
    }
}
