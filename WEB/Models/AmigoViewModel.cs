using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;

namespace WEB.Models
{
    public class AmigoViewModel
    {
        
        public Amigo Amigo { get; set; }
        public IEnumerable<Amigo> Amigos { get; set; }
        
    }
}