using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaarstpel___Form
{
    class SpeelKaart
    {
            //properties
            int waarde;
            Symbool symbool;
            bool isZichtbaar;
            Personage personage;

            //constructor
            public SpeelKaart(int waarde, Symbool symbool, bool isZichtbaar)
            {
                Waarde = waarde;
                Symbool = symbool;
                IsZichtbaar = isZichtbaar;
            }
            public SpeelKaart(int waarde, Symbool symbool, bool isZichtbaar, Personage personage)
            {
                Waarde = waarde;
                Symbool = symbool;
                IsZichtbaar = isZichtbaar;
                Personage = personage;
            }

            //methodes (werkwoorden)
            public void Draaien()
            {
                if (IsZichtbaar)
                {
                    IsZichtbaar = false;
                }
                else
                {
                    IsZichtbaar = true;
                }
            }

            public string Tonen()
            {
                String returnValue = "kaart is onzichtbaar";

                if (IsZichtbaar)
                {
                    if (Waarde > 10 || Waarde < 2)
                        returnValue = Symbool + " - " + Personage;
                    else returnValue = Symbool + "-" + Waarde;

                }
                return returnValue;
            }


            //getset
            private int Waarde
            {
                get { return this.waarde; }
                set { this.waarde = value; }
            }

            private Symbool Symbool
            {
                get { return this.symbool; }
                set { this.symbool = value; }
            }

            public bool IsZichtbaar
            {
                get { return this.isZichtbaar; }
                set { this.isZichtbaar = value; }
            }

            public Personage Personage
            {
                get { return this.personage; }
                set { this.personage = value; }
            }
        }
    }
