using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users=new() ;
    static Repository(){
        _users.Add(new UserInfo (){Id=1,Name="Ata",Phone="555 555 5555",Email="atayucel@gmail.com",WillAttend=true}
        );
          _users.Add(new UserInfo (){Id =2,Name="Mehmet",Phone="444 555 5555",Email="memo@gmail.com",WillAttend=true}
        );
          _users.Add(new UserInfo (){Id=3,Name="Joe",Phone="444 848 222",Email="jojo@gmail.com",WillAttend=false}
        );
    }


        public static List<UserInfo> Users{
            get{
                return _users;
            }
        } 
        public static void CreateUser(UserInfo user){
            user.Id=Users.Count+1;
            _users.Add(user);
        } 

        public static UserInfo? GetById(int id){
            return _users.FirstOrDefault(m=> m.Id==id);
        } 
    }
}