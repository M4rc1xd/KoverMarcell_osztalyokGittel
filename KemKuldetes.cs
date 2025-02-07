namespace Gyakorlas
{
    public class KemKuldetes
    {
        private string kodnev;
        private string orszag;
        private int veszelySzint;
        private int sikerEsej;

        public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsej)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsej = sikerEsej;
        }
        
        public KemKuldetes(string kodnev, string orszag){
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = 5;
            this.sikerEsej = 50;
        }

        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsej { get => sikerEsej; set => sikerEsej = value; }

        public string kuldetesInditasa(){
            return $"A {this.kodnev} nevu kuldetes elindult";
        }

        public void veszelySzintNovelese(int mennyiseg){
            this.veszelySzint += mennyiseg;
        }

        public void sikerEsejNovelese(int szazalek){
            this.sikerEsej += (int)(this.sikerEsej * szazalek / 100);
        }


        public override string ToString()
        {
            return $"{this.kodnev} Orszag: {this.orszag} VeszelySzint: {this.veszelySzint} SikerEsej: {this.sikerEsej}";
        }
    }
}