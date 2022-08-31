using RH_Project.Model;

namespace RH_Project {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = textBox1.Text;
                pessoa.email = textBox2.Text;
                pessoa.dtNascimento = DateTime.Parse(textBox3.Text);
                pessoa.telefones.Add(new Telefone() { ddd = textBox4.Text, numero = textBox5.Text });
                pessoa.telefones.Add(new Telefone() { ddd = textBox4.Text, numero = textBox5.Text });
                pessoa.telefones.Add(new Telefone() { ddd = textBox4.Text, numero = textBox5.Text });
                pessoa.telefones.Add(new Telefone() { ddd = textBox4.Text, numero = textBox5.Text });
                pessoa.telefones.Add(new Telefone() { ddd = textBox4.Text, numero = textBox5.Text });
                pessoa.telefones.Add(new Telefone() { ddd = textBox4.Text, numero = textBox5.Text });

                MessageBox.Show(pessoa.ToString());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}