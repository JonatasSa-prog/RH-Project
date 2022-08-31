namespace RH_Project.Model {
    public class Telefone {
        public Guid idTelefone { get; set; }
        public string ddd { get; set; }
        public string numero { get; set; }

        public Telefone() {
            idTelefone = Guid.NewGuid();
        }

        public override string ToString() {
            return $"({ddd}) {numero} ";
        }
    }
}