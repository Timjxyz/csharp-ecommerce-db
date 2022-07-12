//Si realizzi un prototipo di un e-commerce con
//approccio code-first usando Entity Framework seguendo lo schema allegato.
//Si consideri la possibilità di poter verificare la bontà
//del prototipo eseguendo alcune operazioni di CRUD sul sistema:

//1. inserire almeno 3 prodotti diversi
//2. inserire almeno 5 ordini su almeno 2 utenti diversi
//3. recuperare la lista di tutti gli ordini effettuati da un cliente
//4. modificare l’ordine di un cliente
//5. cancellare un ordine di un cliente
//6. cancellare un prodotto su cui è attivo almeno un ordine
using (EcommercContext db = new EcommercContext())
{

    //Creo tre prodotti

    //Product piscina = new Product();
    //piscina.Name = "Piscina Idromassaggio Gonfiabile";
    //piscina.Description = "Per massimo 6 persone Il pannello di controllo digitale di facile accesso riscalda l'acqua fino a 40 ° C";
    //piscina.Price = 414;
    
    //Product asciugamano = new Product();
    //asciugamano.Name = "Asciugamano da Spiaggia";
    //asciugamano.Description = "Il telo mare è dotato esclusivamente di un'etichetta UV che cambia colore";
    //asciugamano.Price = 15;

    //Product materassino = new Product();
    //materassino.Name = "Materassino Gonfiabile";
    //materassino.Description = "Può convertirsi in amaca, sedia, drifter o sella per esercizi. Godetevi quattro diversi tipi di divertimento in una sola volta.";
    //materassino.Price = 14;

    //db.Add(piscina);
    //db.Add(asciugamano);
    //db.Add(materassino);
    //db.SaveChanges();

    Console.WriteLine("\t****Lista prodotti mare****");
    List<Product> products = db.Products.OrderBy(product => product.Price).ToList<Product>();

    foreach(Product product in products)
    {
        Console.WriteLine("");
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Description);
        Console.WriteLine($"{product.Price} euro");
        Console.WriteLine("");
    }




}
