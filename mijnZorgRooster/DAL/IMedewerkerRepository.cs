﻿using mijnZorgRooster.Models.DTO;
using mijnZorgRooster.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mijnZorgRooster.DAL
{
    public interface IMedewerkerRepository: IGenericRepository<Medewerker>
    {
        Task<MedewerkerMetRollenDto> GetMedewerkerMetRollenMappedDto(int? medewerkerId);
        Task<Medewerker> GetMedewerkerMetRollen(int? medewerkerId);
        void UpdateMedewerkerRollen(Medewerker medewerker, List<int> selectedRollen);
        Contract GetContractVoorMedewerker(DateTime referenceDate, int medewerkerId);
    }
}
