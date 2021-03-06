﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trial2.Models;

namespace trial2.Results
{
    public class ReturnAdo
    {
        public int nPedido { get; set; }
        public DateTime data { get; set; }
        public string estado { get; set; }
        public string cao_idCao { get; set; }
        public int identificacao { get; set; }
        public string permissao { get; set; }
        public string alergia { get; set; }
        public string descAnimais { get; set; }
        public string ausencia { get; set; }
        public string habitacao { get; set; }
        public string exterior { get; set; }
        public string tipoMoradia { get; set; }
        public string motivo { get; set; }
        public string nome_Utilizador { get; set; }
        public string comprovativo { get; set; }
        public string donoAnimal { get; set; }
        public string nome_Canil { get; set; }
        public string cc { get; set; }
        public List<Fotografia> fotos { get; set; }
        public ReturnAdo()
        {
            fotos = new List<Fotografia>();
        }
    }
}
