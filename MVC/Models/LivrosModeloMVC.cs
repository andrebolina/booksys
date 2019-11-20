using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class LivrosModeloMVC
    {
        public int id { get; set; }
        /*
        * #Documentação
        * Nome do livro determinado como obrigatório
        */
        [Required(ErrorMessage = "*O nome do livro é obrigatório")]
        public string nome { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public Nullable<int> ano { get; set; }
        /*
        * #Documentação
        * Estoque determinado como obrigatório
        */
        [Required(ErrorMessage = "*O estoque é obrigatório")]
        public Nullable<int> estoque { get; set; }
        /*
        * #Documentação
        * Valor determinado como obrigatório
        */
        [Required(ErrorMessage = "*O valor é obrigatório")]
        /*
        * #Documentação
        * Adicionado DisplayFormat para exibir o valor em padrão de moeda Real
        */
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public Nullable<double> valor { get; set; }
    }
}