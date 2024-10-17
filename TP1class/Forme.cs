using System;

namespace TP1class { 

    public abstract class Forme
    {
        private Point point;

        public Forme(Point point) 
        {
            this.point = point;
        }
        public abstract double Air();

        public abstract double Perimetre();

    }

}

