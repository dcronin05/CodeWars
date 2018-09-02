using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FriendOrFoe
    {
        public static IEnumerable<string> IsMyFriend(string[] names)
        {
            List<string> friends = new List<string>();
            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    friends.Add(name);
                }
            }

            IEnumerable<string> new_friends = friends;

            return new_friends;
        }
    }
}
