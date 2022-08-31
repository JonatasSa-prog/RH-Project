using RH_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Project.ExtensionsMethods {
    public static class ExtensionTelefone {
        public static string ExibirTelefones(this List<Telefone> telefones) {

            string telefoneToString = string.Empty;
            foreach(var t in telefones) {
                telefoneToString += t.ToString();
            }

            return telefoneToString;
        }
    }
}
