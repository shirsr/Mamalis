using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class Degree
    {
        private Dictionary<string, bool> _degreesDictionary = new Dictionary<string, bool>();
        private double _extraRisk;

        public Degree(bool ifExpetrt, bool ifMakeDecisions, double extrarisk)
        {
            this._degreesDictionary.Add("Expert", ifExpetrt);
            this._degreesDictionary.Add("Make Decisions", ifMakeDecisions);
            this._extraRisk = extrarisk;
        }

        //Get and Set :
        public double GetExtraRisk() { return this._extraRisk; }
        public void SetExtraRisk(double NewExtraRisk) { this._extraRisk = NewExtraRisk;  }

        public bool GetIfExpert() { return this._degreesDictionary["Expert"]; }
        public void SetIfExpert(bool newExtraRisk) { this._degreesDictionary["Expert"] = newExtraRisk; }

        public bool GetIfMakeDecisions() { return this._degreesDictionary["Make Decisions"]; }
        public void SetIfMakeDecisions(bool newIfMakeDecisions) { this._degreesDictionary["Make Decisions"] = newIfMakeDecisions; }


    }
}
