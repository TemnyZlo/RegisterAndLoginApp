using RegistrationAndLoginApp.Models;

namespace RegistrationAndLoginApp.Services
{
    public class SecurityService
    {

       

        UserDAO userDAO = new UserDAO();

        public SecurityService()
        {
            
        }


        public bool IsValid (UserModel user)
        {

            return userDAO.FindUserByNameAndPassword(user);
            //return true if found in the list
           
        }

    }
}
