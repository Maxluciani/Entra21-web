using System;

namespace Domain
{

    static class UsersRepository
    {
      private static List<User> _users = new List<User> ();
      public static IReadOnlyCollection<User> User => _users;

      public static void Add(User user)
     {
        _user.add(user);
     }
    }
}