using AutoMapper;
using BP.Api.Data.Models;
using BP.Api.Models;
using System;

namespace BP.Api.Services
{
    public class ContactService : IContactService
    {
        private readonly IMapper _mapper;

        public ContactService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ContactDVO GetContactDVOById(int id)
        {
           Contact dbcontact = GetDummyContact();
           ContactDVO resultContact = _mapper.Map<ContactDVO>(dbcontact);



            return resultContact;

            
        }


        private Contact GetDummyContact()
        {

            return new Contact()
            {
                Id = 1,
                FirstName = "usame",
                LastName = "delihasan"
            };
        }
    }
}
