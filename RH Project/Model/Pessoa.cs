using RH_Project.ExtensionsMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Project.Model {
    public class Pessoa {
        public Guid idPessoa { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime dtNascimento { get; set; }

        public List<Telefone> telefones { get; set; }

        public Pessoa() {
            this.idPessoa = Guid.NewGuid();
            telefones = new List<Telefone>();
            
        }
        public override string ToString() {
            return $"Nome: {this.nome} , Email: {this.email}, Nascimento: {this.dtNascimento}, Telefones: [{telefones.ExibirTelefones()}]";       
        }

    }
}
