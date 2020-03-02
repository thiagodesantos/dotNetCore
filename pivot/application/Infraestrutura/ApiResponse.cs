using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pivot.Application.Infraestrutura
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            data = DateTime.Now;
            tamanho = 0;
            meta = new Meta();
            paginacao = new Paginacao();
        }

        public ApiResponse(object Dados)
        {

            if (Dados is ICollection)
            {
                this.dados = ((ICollection)Dados);
                tamanho = this.dados.Count != null ? this.dados.Count : 0;
            }
            // else if (Dados is IEnumerable)
            // {
            //     this.dados = ((IEnumerable)Dados);
            //     tamanho = ((IEnumerable)this.dados).Count();
            // }
            else
            {
                this.dados = new List<object> { Dados };
                this.tamanho = 1;

                if (Dados == null)
                {
                    this.tamanho = 0;
                }
            }
            data = DateTime.Now;
            meta = new Meta();
            paginacao = new Paginacao { pagina = 1, qtdRegistrosTotal = tamanho };
        }

        public ApiResponse(ICollection Dados, int Pagina, int QtdRegistrosTotal)
        {
            data = DateTime.Now;
            this.dados = Dados;
            tamanho = this.dados.Count;
            meta = new Meta();
            paginacao = new Paginacao { pagina = Pagina, qtdRegistrosTotal = QtdRegistrosTotal };
        }

        public int tamanho { get; set; }
        public DateTime data { get; set; }
        public dynamic dados { get; set; }
        public Meta meta { get; set; }
        public Paginacao paginacao { get; set; }

        public class Meta
        {
            public int status { get; set; }
            public string mensagem { get; set; }
        }

        public class Paginacao
        {
            public int pagina { get; set; }
            public int qtdRegistrosTotal { get; set; }
        }
    }
}