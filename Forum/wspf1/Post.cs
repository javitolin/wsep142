using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wspf1
{
    class Post
    {
        private String subject;
        private String content;
        private User publisher;
        private Post parent;

        public Post(String subject, String content, User publisher, Post parent)
        {
            
            String checkStat = Post.checkPost(subject, content, publisher);
            if (checkStat.Length > 0) Console.Out.WriteLine(checkStat);

            this.subject = subject;
            this.content = content;
            this.publisher = publisher;
            this.parent = parent;
        }
 
        public static String checkPost(String subject, String content, User u)
        {
            String ans = "";
            if (u == null)
            {
                ans += "Error: u idiot in thread3";
            }

            if ((subject == null || subject.Length < 1) && (content == null || content.Length < 1))
            {
               ans += "Error: u idiot in thread4";
            }
            return ans;
        }
    }
}
