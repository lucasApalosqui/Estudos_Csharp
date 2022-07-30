using System;
using PostComments.Entities;

namespace PostComments
{
    class Program
    {
        static void Main(string[] args)
        {
            string title, content, comment1, comment2;
            int likes;

            Console.WriteLine("Titulo: ");
            title = Console.ReadLine();

            Console.WriteLine("Conteudo: ");
            content = Console.ReadLine();

            likes = 5;

            Post post = new Post()
            {
                Moment = DateTime.Now,
                Title = title,
                Content = content,
                Likes = likes
            };

            Console.WriteLine("Deixe um comentario: ");
            comment1 = Console.ReadLine();
            Comment comentPost1 = new Comment();
            comentPost1.text = comment1;

            Console.WriteLine("Deixe um comentario: ");
            comment2 = Console.ReadLine();
            Comment comentPost2 = new Comment();
            comentPost2.text = comment2;

            post.Comments.Add(comentPost1);
            post.Comments.Add(comentPost2);
            Console.WriteLine(post);


        }
    }
}


