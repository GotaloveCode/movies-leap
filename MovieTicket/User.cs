using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MovieTicket
{
    public class User
    {
        public int id;
        public string email;
        private string password;
        private List<User> _users;
        

        public User()
        {
        }
        
        public User(List<User> usersList)
        {
            _users = usersList;
        }
        
        string register(string email,string password)
        {
            _users.Add(new User()
            {
                email = email,
                password = password
            });

            return "success";
        }
            
        User Login(string email,string password)
        {
            var user = _users.Select(u => new User()
            {
                id = u.id,
                email = u.email,
            }).First(x => x.email == email && password == this.password);
            
            return user;
        }
    }
}