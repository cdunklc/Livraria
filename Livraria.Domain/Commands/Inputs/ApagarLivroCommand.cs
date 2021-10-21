using Flunt.Notifications;
using Livraria.Infra.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Commands.Inputs
{
    public class ApagarLivroCommand : Notifiable, ICommandPadrao
    {

        public long Id { get; set; }

        public bool ValidarCommad()
        {
            try
            {
                if (Id <= 0)
                    AddNotification("Id", "Id inválido");

                return Valid;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
