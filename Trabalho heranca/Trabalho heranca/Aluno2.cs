using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Trabalho_heranca
{
   public class Aluno2 : Pessoa
    {
        private string curso;


        public Aluno2()
        {
             this.curso=null;
        }
        public  Aluno2(string nome, int idade, string curso) 
        {
        
        this.Nome=nome;
       this.Idade=idade;
            this.Curso = curso;
        }
        public string Curso 
        {
        get { return curso; }
        set { curso = value; }
        }
        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Idade.ToString(), " ", this.Curso);
            return s;
        }



    }
}
