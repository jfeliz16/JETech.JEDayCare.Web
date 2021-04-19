using JETech.JEDayCare.Core.Administration.Models;
using JETech.JEDayCare.Core.Clients.Models;
using JETech.JEDayCare.Web.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.JEDayCare.Web.Helper
{
    public class ClientConverterHelper : IClientConverterHelper
    {
        public ClientModel ToClientModel(AddClientViewModel model) => new ClientModel
        {
            BirthDate = model.BirthDateChild,
            FirstNameChild = model.FirstNameChild,
            LastNameChild = model.LastNameChild,
            Parent = new PersonModel
            {
                Address = model.Address,
                CellPhone = model.CellPhone,
                ContryId = int.TryParse(model.ContryId, out var c) ? c : default(int?),
                Email = model.Email,
                FirstName = model.FirstName,
                HomePhone = model.HomePhone,
                LastName = model.LastName,
                ZipCode = model.ZipCode
            }
        };

    }
}
