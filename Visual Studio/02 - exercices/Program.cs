using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___exercices {
    using Enumerations;

    namespace Type_et_variables {
        class TypesEtVariables {

        }
    }

    namespace Controle_de_flot {

        class ControleDeFlot {

        }
    }

    namespace Enumerations {
        enum Sexe {
            HOMME = 7, FEMME, AUTRE
        }

        enum ChatStatus {
            ONLINE, OFFLINE, BUSY
        }

        class Chat {
            String username;
            Sexe usergender;
            byte userage;
            String eMail;
            ChatStatus etat;
        
            public static void Test() {
                Chat messagerie = new Chat();

                Console.WriteLine(messagerie.username);
                Console.WriteLine(messagerie.usergender);
                Console.WriteLine(messagerie.userage);
                Console.WriteLine(messagerie.eMail);
                Console.WriteLine(messagerie.etat);

                Console.WriteLine(messagerie);
            }
        }
    }

    namespace arrays {

        class Arrays {

        }
    }


    class Program {
        static void Main(string[] args) {
            Chat.Test();

            Console.WriteLine("C'est fini!");
            Console.ReadLine();
        }
    }
}
