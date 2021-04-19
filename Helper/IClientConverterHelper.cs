using JETech.JEDayCare.Core.Clients.Models;
using JETech.JEDayCare.Web.Models.Client;

namespace JETech.JEDayCare.Web.Helper
{
    public interface IClientConverterHelper
    {
        ClientModel ToClientModel(AddClientViewModel model);
    }
}