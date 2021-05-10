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
        public ClientModel ToClientModel(ClientViewModel model) => new ClientModel
        {
            Id = !string.IsNullOrEmpty(model.Id) ? int.Parse(model.Id) : default,
            BirthDate = model.BirthDateChild,
            FirstNameChild = model.FirstNameChild,
            LastNameChild = model.LastNameChild,
            StatusId = !string.IsNullOrEmpty(model.StatusId) ? int.Parse(model.StatusId) : default,
            Parent = new PersonModel
            {
                Address = model.Address,
                CellPhone = model.CellPhone,
                StateId = int.TryParse(model.StateId, out var c) ? c : default(int?),
                Email = model.Email,
                FirstName = model.FirstName,
                HomePhone = model.HomePhone,
                LastName = model.LastName,
                ZipCode =int.TryParse(model.ZipCode, out var z) ? z :default(int?)
            }
        };

        public ClientViewModel ToClientViewModel(ClientModel model) => new ClientViewModel
        {            
            Id = model.Id.ToString(),
            BirthDateChild = DateTime.TryParse(model.BirthDate.ToString(),out var d) ? d : default,
            FirstNameChild = model.FirstNameChild,
            LastNameChild = model.LastNameChild,
            Address = model.Parent.Address,
            CellPhone = model.Parent.CellPhone,
            StateId = model.Parent.StateId.HasValue ? model.Parent.StateId.ToString():default,
            Email = model.Parent.Email,
            FirstName = model.Parent.FirstName,
            HomePhone = model.Parent.HomePhone,
            LastName = model.Parent.LastName,
            ZipCode = model.Parent.ZipCode.HasValue ? model.Parent.ZipCode.ToString() :default,
            StatusId = model.StatusId.ToString()
            
        };

    }
}
