using System;
using System.Collections.Generic;
using ContactRepo.Models;

namespace ContactRepo.Repository
{
    public interface IContactsRepository
    {
       void  Add(Contacts contacts);
       List<Contacts> GetAll();//Not recommended
       Contacts Find(int Id);//Searching a record by id returning as Contact
       void Update(Contacts contacts);//we can update a record by Id or by Mail and returning as a void depends on the requirmet
       void Remove(int Id);// We are removing the record by Id and returning as a void depends on the requirment

    }
}