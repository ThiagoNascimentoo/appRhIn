using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRhIn.Classes
{
    internal class UsuarioLogado
    {
        private static UsuarioLogado instancia;

        public string Nome { get; set; }
        public int Id { get; set; }

        private UsuarioLogado()
        {
        }

        public static UsuarioLogado Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new UsuarioLogado();
                }
                return instancia;
            }
        }
        public void Deslogar()
        {
            Nome = "";
            Id = 0;
            instancia = null;
        }
    }
}
