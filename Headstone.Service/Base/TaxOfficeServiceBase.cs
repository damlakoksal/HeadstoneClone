﻿using Headstone.Models;
using Headstone.Service.DataAccess;
using Headstone.Framework.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headstone.Service.Base
{
    public class TaxOfficeServiceBase : EFServiceBase<TaxOffice, TaxOfficeDAO, HeadstoneDbContext>
    {

    }
}
