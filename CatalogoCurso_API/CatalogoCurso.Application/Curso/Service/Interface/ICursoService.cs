﻿using CatalogoCurso.Application.Curso.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Service.Interface
{
    public interface ICursoService
    {
        Task<CursoOutputDto> Salvar(CursoInputDto cursoDto);
        Task<CursoOutputDto> Desativar(Guid cursoDto);
        Task<CursoOutputDto> Atualizar(CursoUpdateDto cursoDto);
        Task<CursoOutputDto> ObterPorId(Guid cursoId);
        Task<List<CursoOutputDto>> ObterTodos();
    }
}
