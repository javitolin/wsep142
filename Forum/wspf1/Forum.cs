using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wspf1
{
    class Forum
    {
        private String name;
        private List<User> members = new List<User>();
        private List<SubForum> subforums;
        private List<int> admins = new List<int>();
        private List<int> moderators = new List<int>();
        private Policy policy;

        public Forum(String name, List<User> admins, Policy policy)
        {
            if (name == null || name.Length < 1)
            {
                Console.Out.WriteLine("Error: u idiot");
            }
            else if (admins == null || admins.Count < 1)
            {
                Console.Out.WriteLine("Error: u idiot2");
            }
            else if (policy == null)
            {
                Console.Out.WriteLine("Error: u idiot3");
            }
            else
            {
                this.name = name;
                for (int i = 0; i < admins.Count; i++)
                {
                    this.members.Add(admins.ElementAt(i));
                    this.admins.Add(i);
                }
                subforums = new List<SubForum>();
                this.policy = policy;
            }
        }

        public void createSubForum(String name, User mod)
        {
            int index = members.IndexOf(mod);
            SubForum sub = new SubForum(name, index);
            subforums.Add(sub);
            moderators.Add(index);
        }

        public List<SubForum> getSubForums()
        {
            return subforums;
        }

        public bool isRegistered(User u)
        {
            return members.Contains(u);
        }

        public void setPolicy(Policy p)
        {
            if(p== null)
                Console.Out.WriteLine("Error: u idiot in setting policy");
            this.policy = p;
        }

        public void register(User u)
        {
            if(u==null)
                Console.Out.WriteLine("Error: u idiot in registering");
            members.Add(u);
        }
    }
}
