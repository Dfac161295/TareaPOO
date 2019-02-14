using System;
using System.Collections.Generic;
namespace Tarea2.model

{
    public class Publication
    {



        private string title;
        private DateTime editionDate;
        private string editorial;
        private List<string> autores = new List<string>();


        public string Title{
            get{ return title; }
            set{ title = value; }
        }
        
        public DateTime EditionDate{
            get{return editionDate;}
            set{editionDate = value;}
        }

        public string Editorial{
            get{return editorial;}
            set{editorial = value;}
        }

        public List<string> Autores{
            get{return autores;}
            set{autores = value;}
        }

    }
}