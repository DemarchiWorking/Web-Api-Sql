﻿using Domain.Model.Request;
using Domain.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public interface IKpiRepository
    {
        ResponsePlansPerson GetInformationPlanVip();
    }
}
