using System;


    public class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sorokSzama,int helyekSzama)
        {
            try
            {
                foglalasok =  new bool[sorokSzama, helyekSzama];
            }
            catch (ArgumentException e)
            {

            throw e;
            }
        }

        public bool Lefoglal() {

            for (int i = 0; i < foglalasok.Length; i++)
            {
                for (int j = 0; j < foglalasok.Length; j++)
                {
                    if (foglalasok[i,j]==false)
                    {
                       return foglalasok[i, j] = true;
                    }
                    
                }
            }
            return false;
            
        }

        private int szabadHelyek()
        {
            int db = 0;
            for (int i = 0; i < foglalasok.Length; i++)
            {
                for (int j = 0; j < foglalasok.Length; j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        db++;
                    }
                }
            }
            return db;
        }

        public int SzabadHelyek { get => szabadHelyek();}


        public bool Teli() {
           
            for (int i = 0; i < foglalasok.Length; i++)
            {
                for (int j = 0; j < foglalasok.Length; j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        return false;   
                    }
                }
            }
            return true;
        }


        public bool Foglalt(int sorSzam, int helySzam) {
            if (foglalasok[sorSzam-1,helySzam-1]==false)
            {
                return false;
            }
            return true;
        }

    }

