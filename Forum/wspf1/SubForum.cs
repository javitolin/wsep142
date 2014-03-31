using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wspf1
{
    class SubForum
    {
        private String name;
        private List<Thread> threads;
        private int moderator;

        public SubForum(String name, int moderator)
        {
            if (name == null || name.Length < 1)
            {
                Console.Out.WriteLine("Error: u idiot in sub forum");
            }
            else
            {
                this.name = name;
                this.moderator = moderator;
            }
        }

        public void publishThread(String subject, String content, User publisher)
        {
            Thread thread = new Thread(subject, content, publisher);
            threads.Add(thread);
        }

        public List<Thread> getThreads()
        {
            return this.threads;
        }

    }
}
