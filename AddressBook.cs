public class AddressBook
{
    private Dictionary <string, Contact> contactList { get; set; } = new Dictionary <string, Contact>();
    public void AddContact(Contact singleContact){
        contactList.Add(singleContact.Email, singleContact);

    }

    public Contact GetByEmail(string email)
    {
        
        Contact matchingEmail = contactList[email];
        return matchingEmail;
       
    }
}