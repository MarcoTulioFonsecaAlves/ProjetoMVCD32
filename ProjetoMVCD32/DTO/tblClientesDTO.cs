using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCD32.DTO
{
    public class tblClientesDTO
    {
        private string Nome_Cliente, Nome_Mae_Cliente, CPF_Cliente;

        public string Nome_Cliente1 { get => Nome_Cliente; set => Nome_Cliente = value; }
        public string Nome_Mae_Cliente1 { get => Nome_Mae_Cliente; set => Nome_Mae_Cliente = value; }
        public string CPF_Cliente1 { get => CPF_Cliente; set => CPF_Cliente = value; }

        public string CPFCliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.CPF_Cliente = value;
                }
                else
                {
                    throw new Exception("O campo 'CPF' é obrigatório!");
                }
            }
            get { return this.CPF_Cliente; }
        }

        public string NomeMae
        {
            set
            {
                if (value != string.Empty)
                {
                    this.Nome_Mae_Cliente = value;
                }
                else
                {
                    throw new Exception("O campo 'Nome da Mãe' é obrigatório!");
                }
            }
            get { return this.Nome_Mae_Cliente; }
        }

        public string NomeCliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.Nome_Cliente = value;
                }
                else
                {
                    throw new Exception("O campo 'Nome Completo' é obrigatório!");
                }
            }
            get { return this.Nome_Cliente; }
        }
    }
}