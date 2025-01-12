﻿using CatalogoCurso.CrossCutting.Entity;
using CatalogoCurso.Domain.Curso.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Curso
{
    public class Curso : Entity<Curso>
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public string? Objetivo { get; set; }
        public string? Bibliografia { get; set; }
        public string? Avaliacao { get; set; }
        public string? Certificacao { get; set; }

        public Guid ModalidadeEnsinoId { get; set; } // Ead ou prensencial
        public ModalidadeEnsino ModalidadeEnsino { get; set; } // Ead ou prensencial

        public Guid TipoCursoId { get; set; }
        public TipoCurso TipoCurso { get; set; }

        public Guid ModalidadeEducacaoId { get; set; }
        public ModalidadeEducacao ModalidadeEducacao { get; set; }

        public Guid EixoTecnologicoId { get; set; }
        public EixoTecnologico EixoTecnologico { get; set; }

        public Guid SegmentoId { get; set; }
        public Segmento Segmento { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public void Destivar()
        {
            Ativo = false;
            DataAtualizacao = DateTime.Now;
        }

        public Curso Cadastrar(Curso curso)
        {
            return CursoFactory.Cadastrar(curso);
        }

        public void Atualizar(Curso curso)
        {
            Id = curso.Id;
            Nome = curso.Nome;
            CargaHoraria = curso.CargaHoraria;
            Objetivo = curso.Objetivo;
            Bibliografia = curso.Bibliografia;
            Avaliacao = curso.Avaliacao;
            Certificacao = curso.Certificacao;
            ModalidadeEnsinoId = curso.ModalidadeEnsinoId;
            TipoCursoId = curso.TipoCursoId;
            ModalidadeEducacaoId = curso.ModalidadeEducacaoId;
            EixoTecnologicoId = curso.EixoTecnologicoId;
            SegmentoId = curso.SegmentoId;
            DataAtualizacao = DateTime.Now;
        }
    }
}
