namespace Gyakorlas
{
    public class Urhajo
    {
        private string nev;
        private int sebesseg;
        private int utaskapacitas;
        private int uzemanyagSzint;

        public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public Urhajo(string nev, int utaskapacitas)
        {
            this.nev = nev;
            this.sebesseg = 0;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = 100;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
        public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

        public void indulas(){
            this.uzemanyagSzint -= 10;
            this.sebesseg += 100;
        }

        public void tankolas(int mennyiseg){
            this.uzemanyagSzint += mennyiseg;
        }

        public void landolas(){
            this.sebesseg = 0;
        }

        public override string ToString()
        {
            return $"{this.nev} Sebesség: {this.sebesseg} Utaskapacitás: {this.utaskapacitas} Üzemanyag szint: {this.uzemanyagSzint}";
        }
    }
}