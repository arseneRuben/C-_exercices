using System;

namespace _07___DoorOpen {
    class Door {
        //  a.
        public int Id { get; set; }
        private bool isOpen;

        //  b.
        public bool IsOpen {
            get {
                return this.isOpen;
            }
            set {
                if (!this.isOpen && value) {
                    this.isOpen = value;
                    this.DoorOpenEvent(this, new DoorOpenEventArgs());
                }
                else {
                    this.isOpen = value;
                }
            }
        }

        //  d.
        public event EventHandler<DoorOpenEventArgs> DoorOpenEvent;

    }

    //  c.
    class DoorOpenEventArgs {
        public DateTime Time { get; set; }
        public DoorOpenEventArgs() {
            this.Time = DateTime.Now;
        }
    }

    //  e.
    class SafetyGuard {
        private Door theDoorToCheck;

        internal void DoorOpened(object sender, DoorOpenEventArgs args) {
            Door theDoor = (Door)sender;
            Console.WriteLine("La porte #{0} s'ouvre, il est {1}",
                theDoor.Id, args.Time);
        }

        public void SwitchDoor(Door newDoorToCheck) {
            if (this.theDoorToCheck != null) {
                this.theDoorToCheck.DoorOpenEvent -= this.DoorOpened;
            }
            newDoorToCheck.DoorOpenEvent += this.DoorOpened;
            this.theDoorToCheck = newDoorToCheck;
        }
    }

    class Owner {
        internal void OhVoleur(object sender, DoorOpenEventArgs args) {
            Console.WriteLine("Que fait le gardien!?!?");
        }
    }

    class Program {
        static void Main(string[] args) {
            //  f.
            //  creation de l'observé
            Door aDoor = new Door() { Id = 666, IsOpen = false };

            //  creation de l'observateur
            SafetyGuard robert = new SafetyGuard();

            //  enregistrement de l'écouté auprès de l'écouteur
            aDoor.DoorOpenEvent += robert.DoorOpened;

            //  creation d'una autre observateur
            Owner leProprio = new Owner();

            //  enregistrement du nouvel ecouteur aupres de la porte
            aDoor.DoorOpenEvent += leProprio.OhVoleur;

            //  déclencher l'évènement sur l'observé
            aDoor.IsOpen = true;

            //  desenregistrer le proetaire aupres de la porte
            aDoor.DoorOpenEvent -= leProprio.OhVoleur;

            aDoor.IsOpen = false;
            aDoor.IsOpen = true;

            Door anotherDoor = new Door { Id = 1234 };
            robert.SwitchDoor(anotherDoor);

            anotherDoor.IsOpen = true;
        }
    }
}
