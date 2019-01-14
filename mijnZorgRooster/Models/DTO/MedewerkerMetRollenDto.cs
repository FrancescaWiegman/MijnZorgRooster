﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mijnZorgRooster.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mijnZorgRooster.Models.DTO
{
    public class MedewerkerMetRollenDto : MedewerkerBasisDto
    {
        public MedewerkerMetRollenDto(Medewerker medewerker) : base(medewerker)
        {
        }

        [BindProperty]
        [Display(Name = "Rollen")]
        public List<int> SelectedRollen { get; set; }
        public SelectList RollenOptions { get; set; }
    }
}
