namespace Gyakorlas
{
    public class Karakter
    {
        private string nev;
        private int szint;
        private int eletero;
        private int ero;

        public Karakter(string nev, int szint, int eletero, int ero)
        {
            this.nev = nev;
            this.szint = szint;
            this.eletero = eletero;
            this.ero = ero;
        }

        public Karakter(string nev, int ero)
        {
            this.nev = nev;
            this.szint = 1;
            this.eletero = 100;
            this.ero = ero;
        }

        public string Nev{ get => nev; set => nev = value;}
        public int Szint{ get => szint; set => szint = value;}
        public int Eletero{ get => eletero; set => eletero = value;}
        public int Ero{ get => ero; set => ero = value;}

        public string Tamadas()
        {
            return $"{this.nev} támadott {this.ero} erővel";
        }

        public void Gyogyulas(int mennyiseg){
            this.eletero += mennyiseg;
        }

        public void SzintLepes()
        {
            this.szint += 1;
            this.ero += 10;
        }

        public override string ToString()
        {
            return $"{this.nev} Szint: {this.szint} Életerő: {this.eletero} Erő: {this.ero}";
        }
    }
}