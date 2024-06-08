using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    class Review
    {
        private string name;
        private string recommend;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Recommend
        {
            get { return recommend; }
            set { recommend = value; }
        }
        public Review(string name , string recommend)
        {
            this.name = name;
            this.recommend = recommend;
        }

    }
}
