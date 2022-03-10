using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPostConsole
{
    class Post
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public DateTime createDateTime { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }


        public Post(string title,string text)
        {
            this.Title = title;
            this.Text = text;
            this.createDateTime = DateTime.Now;
        }

         public int VoteUp()
        {
            return UpVote += 1;
        }

        public int VoteDown()
        {
            return DownVote += 1;
        }


        public static void PublicPost()
        {
            Console.WriteLine("Type the text Title.");
            var title = Console.ReadLine();
            Console.WriteLine("Type the Text.");
            var text = Console.ReadLine();

            var post = new Post(title, text);

            while (true)
            {
                Console.WriteLine("\n\n                                 --------------------- {0} ---------------------\n", post.Title.ToUpper());
                Console.WriteLine("{0}", post.Text);
                Console.WriteLine("\nCreation: {0}\n", post.createDateTime);
                Console.WriteLine("UP                                                                            Down");
                Console.WriteLine("{0}                                                                             {1}", post.UpVote, post.DownVote);

                Console.WriteLine("\nVote \"Up\" or \"Down\" to hate this post.");
                var input = Console.ReadLine();
                if (input.ToUpper() == "UP")
                {
                    post.VoteUp();
                    continue;
                }

                else if (input.ToUpper() == "DOWN")
                {
                    post.VoteDown();
                    continue;
                }

            }
        }



    }
}
