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
    //1
    /*
    *Creo tre prodotti
    */
    Product piscina = new Product();
    piscina.Name = "Piscina Idromassaggio Gonfiabile";
    piscina.Description = "Per massimo 6 persone Il pannello di controllo digitale di facile accesso riscalda l'acqua fino a 40 ° C";
    piscina.Price = 414;

    Product asciugamano = new Product();
    asciugamano.Name = "Asciugamano da Spiaggia";
    asciugamano.Description = "Il telo mare è dotato esclusivamente di un'etichetta UV che cambia colore";
    asciugamano.Price = 15;

    Product materassino = new Product();
    materassino.Name = "Materassino Gonfiabile";
    materassino.Description = "Può convertirsi in amaca, sedia, drifter o sella per esercizi. Godetevi quattro diversi tipi di divertimento in una sola volta.";
    materassino.Price = 14;

    /*
    *Aggiungo i prodotti al DB
    */
    //db.Add(piscina);
    //db.Add(asciugamano);
    //db.Add(materassino);

    /*
    *Salvo i prodotti
    */
    //db.SaveChanges();


    /*
   *Stampo lista prodotti
   */
    Console.WriteLine("\t****Lista prodotti mare****");
    List<Product> products = db.Products.OrderBy(product => product.Price).ToList<Product>();

    foreach (Product product in products)
    {
        Console.WriteLine("");
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Description);
        Console.WriteLine($"{product.Price} euro");
        Console.WriteLine("");
    }

    

    //2
    /*
    *Creo due utenti
    */
    Customer mario = new Customer();
    mario.Name = "Mario";
    mario.Surname = "Bros";
    mario.Email = "superMario@gmail.com";

    Customer luigi = new Customer();
    luigi.Name = "Luigi";
    luigi.Surname = "Bros";
    luigi.Email = "superLuigi@gmail.com";

    /*
    *Aggiungo utenti al DB
    */
    //db.Add(mario);
    //db.Add(luigi);


    /*
   *Salvo i nuovi utenti
   */
    //db.SaveChanges();


    /*
     * Creo ordini
     */
    Order primoOrdineMario = new Order();
    primoOrdineMario.Date = DateTime.Now;
    primoOrdineMario.Amount = primoOrdineMario.GetAmount();
    primoOrdineMario.Status = "In consegna";
    primoOrdineMario.CustomerId = 1;

    Order primoOrdineLuigi = new Order();
    primoOrdineLuigi.Date = DateTime.Now;
    primoOrdineLuigi.Amount = primoOrdineMario.GetAmount();
    primoOrdineLuigi.Status = "In consegna";
    primoOrdineLuigi.CustomerId = 2;


    Order secondoOrdineMario = new Order();
    secondoOrdineMario.Date = DateTime.Now;
    secondoOrdineMario.Amount = secondoOrdineMario.GetAmount();
    secondoOrdineMario.Status = "In consegna";
    secondoOrdineMario.CustomerId = 1;

    /*
    *Aggiungo ordini al DB
    */
    db.Add(primoOrdineLuigi);
    db.Add(primoOrdineMario);
    db.Add(secondoOrdineMario);


    /*
   *Salvo i nuovi ordini
   */
    db.SaveChanges();




}