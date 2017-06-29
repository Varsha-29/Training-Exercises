using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
        public abstract class Feature
        {
            internal Feature(string name, int rating, float cost)
            {
                this._name = name;
                this._rating = rating;
                this._cost = cost;
            }

            internal string _name;

            public string Name
            {
                get { return _name; }
            }

            internal int _rating;

            public int Rating
            {
                get
                {
                    return _rating;
                }
            }

            internal float _cost;

            public float Cost
            {
                get
                {
                    return _cost;
                }
            }
            

        }

    }
