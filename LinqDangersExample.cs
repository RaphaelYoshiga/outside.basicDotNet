using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outside.BasicDotNet
{
    public class LinqDangersExample
    {
        public void Execute()
        {
            var users = new List<User>();
            var userIds = new List<int>();
            SetupUserAndUserIds(users, userIds, 100000);
            var userDictionary = users.ToDictionary(p => p.Id, p => p);

            DoSomething(userIds, userDictionary);
        }

        private void DoSomething(List<int> userIds, Dictionary<int, User> users)
        {
            int numberOfIterations = 0;
            userIds.Select(userId =>
            {
                numberOfIterations++;
                var foundUser = users[userId];
                Console.WriteLine(numberOfIterations);

                return DoSomethingWith(foundUser);
            }).ToList();

        }

        private string DoSomethingWith(User user)
        {
            return user.Id + user.Name;
        }

        private static void SetupUserAndUserIds(List<User> users, List<int> userIds, int ofUsers)
        {
            for (int i = 0; i < ofUsers; i++)
            {
                users.Add(new User()
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString()
                });

                userIds.Add(i);
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
