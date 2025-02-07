namespace Gyakorlas
{
    public class Konyv
    {
        private string cim;
        private string szerzo;
        private int kiadasEve;
        private int oldalszam;
        private int ar;

        public Konyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar){
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasEve = kiadasEve;
            this.oldalszam = oldalszam;
            this.ar = ar;
        }

        public Konyv(string cim, string szerzo){
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasEve = DateTime.Now.Year;
            this.oldalszam = 200;
            this.ar = 3000;
        }

        public string Cim{get => cim; set => cim = value;}
        public string Szerzo{get => szerzo; set => szerzo = value;}
        public int KiadasEve{get => kiadasEve; set => kiadasEve = value;}
        public int Oldalszam{get => oldalszam; set => oldalszam = value;}
        public int Ar{get => ar; set => ar = value;}

        public void Arnoveles(int osszeg){
            this.ar += osszeg;
        }

        public void Kedvezmeny(double szazalek){
            this.ar -= (int)(this.ar * szazalek / 100);
        }

        public int HanyOldalMaradt(int elolvasott){
            return this.oldalszam - elolvasott;
        }

        public override string ToString()
        {
            return $"{this.szerzo} : {this.cim} Kiadas eve: {this.kiadasEve} Oldalszam: {this.oldalszam} Ar: {this.ar}";
        }
    }
}