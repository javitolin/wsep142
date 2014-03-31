using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wspf1
{
    class Thread
    {
        private List<Post> posts;

        public Thread(String subject, String content, User u)
        {
            String checkStat = Post.checkPost(subject, content, u);
            if (checkStat.Length > 0) Console.Out.WriteLine(checkStat);
            posts = new List<Post>();
            posts.Add(new Post(subject, content, u, null));
        }

        public void postResponse(String subject, String content, Post parent, User u)
        {
            String checkStat = Post.checkPost(subject, content, u);
            if (checkStat.Length > 0) Console.Out.WriteLine(checkStat);
            posts.Add(new Post(subject, content, u, parent));
        }
        public Post getPost(int postId){
            if(postId > this.posts.Count)
            {
                Console.Out.WriteLine("PostId too large");
                return null;
            }
            else
            {
                return this.posts.ElementAt(postId);
            }
        }
        public List<Post> getPosts()
        {
            return this.posts;
        }

    }
}
