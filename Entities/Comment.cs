using System;
using System.Collections.Generic;
using System.Text;

namespace PostComments.Entities
{
    class Comment
    {
        public string  text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            this.text = text;
        }


    }
}
