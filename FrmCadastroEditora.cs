using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema {
    public partial class FrmCadastroEditora : Form {
        // Singleton
        private static FrmCadastroEditora _instance;

        // Singleton
        private FrmCadastroEditora() {
            InitializeComponent();
        }

        // Singleton
        public static FrmCadastroEditora GetInstance() {
            if (_instance == null
                // Quando esta filha é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed)) {
                _instance = new FrmCadastroEditora();
            }
            return _instance;
        }

        private void button1_Click(object sender, EventArgs e) {
            Editora editora = new Editora();
            editora.Nome = txtNome.Text;
            editora.Email = txtEmail.Text;
            editora.Telefone = UInt64.Parse(txtTelefone.Text);

            //Console.WriteLine(editora);

            RepositorioEditora.Salvar(editora);
        }
    }
}
