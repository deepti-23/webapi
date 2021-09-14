using System.Collections.Generic;
using System.Linq;
using ContactRepo.Models;

namespace ContactRepo.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        List<Contacts> listcontacts=new List<Contacts>(); //listcontacts is an object to perform the manupulation
        void IContactsRepository.Add(Contacts contacts)
        {
            listcontacts.Add(contacts);
        }

        Contacts IContactsRepository.Find(int Id)
        {
            var contacts =listcontacts.Where(ctr=>ctr.EmployeeId==Id).FirstOrDefault();  //Delete the first contact in the list
            return contacts;
        }

        List<Contacts> IContactsRepository.GetAll()
        {
            /* listcontacts.Add(new Contacts{
                EmployeeId=101,
                EmployeeName="abc",
                EmployeeMail="deepti@gmail.com"
            });
            listcontacts.Add(new Contacts{
                EmployeeId=102,
                EmployeeName="Deepti Bansal",
                EmployeeMail="deeptibansal@gmail.com"
            }); */
            return listcontacts;
        }

        void IContactsRepository.Remove(int Id)
        {
           var contactToRemove =listcontacts.Where(ctr=>ctr.EmployeeId==Id).SingleOrDefault();
           if(contactToRemove!=null)
           {
               listcontacts.Remove(contactToRemove);
           } 
        }

        void IContactsRepository.Update(Contacts contacts)
        {
          var contactToUpdate =listcontacts.Where(ctr=>ctr.EmployeeId==contacts.EmployeeId).FirstOrDefault(); 
          if(contactToUpdate!=null)
          {
            contactToUpdate.EmployeeName=contacts.EmployeeName;
            contactToUpdate.EmployeeMail=contacts.EmployeeMail;
          } 
        }
    }
}