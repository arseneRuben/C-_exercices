using System;

namespace _12___modele_WPF {
    public class Personne {
        public String Nom { get; set; }
        public int Age { get; set; }

        public override string ToString() {
            return String.Format("{0} ({1} ans)", this.Nom, this.Age);
        }
    }
}
