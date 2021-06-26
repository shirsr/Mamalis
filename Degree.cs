using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class Degree
    {
        private Dictionary<string, bool> _degreesDictionary = new Dictionary<string, bool>();
        private float _extraRisk;

        public Degree(bool ifExpetrt, bool ifMakeDecisions, float extrarisk)
        {
            this._degreesDictionary.Add("Expert", ifExpetrt);
            this._degreesDictionary.Add("Make Decisions", ifMakeDecisions);
            this._extraRisk = extrarisk;
        }


    }
}
