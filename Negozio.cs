using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizionov

    /*i progetti una classe Negozio. 
     Un negozio ha
          un nome,
          un proprietario ed
          una lista di prodotti(da realizzarsi con una List di Prodotto). Si forniscano i costruttori per i seguenti casi:
- un negozio con nome e proprietario(senza prodotti)
- un negozio con nome, proprietario ed un solo prodotto
- un negozio con un numero variabile di articoli.
    */


{
    public class Negozio
    {
        public String NomeNegozio;

        public string Proprietario { get; }

        public List<Product> products_list { get; }

        public Negozio(string nomeNegozio, string proprietario )
        {
            NomeNegozio = nomeNegozio;
            Proprietario = proprietario;
          products_list = new List<Product>();
        }

        public Negozio(List<Product> products_list)
        {
            this.products_list = products_list;
        }

    }
}