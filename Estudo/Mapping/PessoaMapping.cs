using Estudo.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estudo.Mapping
{
    public class PessoaMapping : ClassMap<Pessoa>
    {
        public PessoaMapping()
        {
            Id(obj => obj.Id).GeneratedBy.Identity();
            Map(obj => obj.Nome);
            Map(obj => obj.CpfCnpj);
            Map(obj => obj.DataNascimento);
        }
    }
}