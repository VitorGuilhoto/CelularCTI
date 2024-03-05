using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.model.Entidades
{
    public class Fabricante
    {
        //atributos

        private Int64 id_Fabricante;
        private string nome;
        private string observacao;
        
        //propriedades

        public Int64 Id_Fabricante 
        { 
            get 
            { 
                return id_Fabricante; 
            } 
            set 
            {  
                id_Fabricante = value;
            } 
        }
        
        public string Nome 
        { 
            get { return nome; }
            set { nome = value;}
        }
        
        public String Observacao 
        { 
            get { return observacao; }
            set { observacao = value;}
        }
        //metodo

    }
}
