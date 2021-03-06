using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibKeyve;

namespace ClassLibKeyve
{
    public class Usuario
    {
         
        // atributos (campos)
        private int id;
        private string nome;
        private string email;
        private Nivel nivel;
        private string password;

        private bool ativo;

        // propriedades
        public int Id { get { return id; } }
        public string Nome { get { return nome; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password
        {
            get
            {
                // restrições
                return password;
            }

        }
        public Nivel Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }


        // métodos Construtores
        public Usuario()
        {

        }
        public Usuario(string nome, string email)
        {
            this.nome = nome;
            this.email = email;            
            ativo = true;
        }

        public Usuario(int id, string nome, string email, string password, Nivel nivel, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.nivel = nivel;
            this.ativo = ativo;

        }



        // métodos da classe
        public int Inserir()
        {
            // chamadas de banco e gravo o registro
            return id;
        }
        public static bool EfetuarLogin(string email, string senha)
        {
            // realiza validação e devolve verdadeiro ou falso
            return false;
        }
    }
}
