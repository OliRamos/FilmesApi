﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "Título é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "Gênero é obrigatório")]
    [StringLength(50, ErrorMessage = "Máximo de 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "Duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
