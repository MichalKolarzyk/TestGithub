using System;
using System.Collections.Generic;
using System.Text;

namespace HelloGithub.Models
{
    public class Dog : IAnimal
    {
        public string Descripsion => "I like my owner";

        public string Sound => "wrrrrrr";
    }
}
