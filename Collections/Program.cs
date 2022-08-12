// See https://aka.ms/new-console-template for more information

using Collections;

// List Kullanımı
/*var customers = new List<Customer>();
customers.Add(new Customer { Name = "Ahmet", Surname = "Evkaya"});
customers.Add(new Customer { Name = "Kemal", Surname = "Şahin" });
customers.Add(new Customer { Name = "Enes", Surname = "Çömez" });


customers.ForEach(c =>
{
    Console.WriteLine($"{c.Name} - {c.Surname}");
});

Console.WriteLine("-----------------------");
var customer = customers.Find(c => c.Name == "Ahmet");
if (customer is not null)
{
    customers.Remove(customer);
}
else
{
    Console.WriteLine("müşteri bulunamamıştır");
}

customers.ForEach(c =>
{
    Console.WriteLine($"{c.Name} - {c.Surname}");
});

Console.WriteLine("-----------------------");
var customer2 = customers.Find(c => c.Name == "Enes");
if (customer2 is not null)
{
    Console.WriteLine($"{customer2.Name} adlı müşteri bulunmuştur");
}*/


//LinkedList
/*var customers2 = new LinkedList<Customer>();
customers2.AddFirst(new Customer {Name = "Ahmet", Surname = "Evkaya"});
customers2.AddLast(new Customer {Name = "Kemal", Surname = "Şahin"});
customers2.AddFirst(new Customer {Name = "Enes", Surname = "Çömez"});

foreach (var c in customers2)
{
    Console.WriteLine($"{c.Name} - {c.Surname}");
}

Console.WriteLine("-------------------------------");

Customer customer2 = null;
foreach (var c in customers2)
{
    
    if (c.Name == "Enes")
    {
        customer2 = c;
        break;
    }
}

if (customer2 is not null)
{
    Console.WriteLine($"{customer2.Name} adlı kullanıcı silinmiştir");
    customers2.Remove(customer2);
}
else
{
    Console.WriteLine("Müşteri bulunamamıştır");
}

Console.WriteLine("-----------------------");

Customer customerr2 = null;
foreach (var c in customers2)
{

    if (c.Name == "Kemal")
    {
        customerr2 = c;
        break;
    }
}

if (customerr2 is not null)
{
    Console.WriteLine($"{customerr2.Name} adlı müşteri bulunmuştur");
}*/


Dictionary<int , Customer> customers3 = new Dictionary<int , Customer>();
customers3.Add(1, new Customer() {Name = "Ahmet", Surname = "Evkaya"});
customers3.Add(2, new Customer() {Name = "Kemal", Surname = "Şahin"});
customers3.Add(3, new Customer() {Name = "Enes", Surname = "Çömez"});



