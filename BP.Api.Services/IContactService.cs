using BP.Api.Models;

namespace BP.Api.Services
{
    public interface IContactService
    {
        public ContactDVO GetContactDVOById(int id);
    }
}