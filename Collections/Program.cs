// See https://aka.ms/new-console-template for more information

using Collections;
Console.WriteLine("Hello world");

// List Kullanımı
//Ekleme
/*var customers = new List<Customer>();
customers.Add(new Customer { Name = "Ahmet", Surname = "Evkaya"});
customers.Add(new Customer { Name = "Kemal", Surname = "Şahin" });
customers.Add(new Customer { Name = "Enes", Surname = "Çömez" });


// Listeleme
customers.ForEach(c =>
{
    Console.WriteLine($"{c.Name} - {c.Surname}");
});

Console.WriteLine("-----------------------");

// Silme
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

// Filtreleme
var customer2 = customers.Find(c => c.Name == "Enes");
if (customer2 is not null)
{
    Console.WriteLine($"{customer2.Name} adlı müşteri bulunmuştur");
}*/


//LinkedList
//Ekleme
/*var customers2 = new LinkedList<Customer>();
customers2.AddFirst(new Customer {Name = "Ahmet", Surname = "Evkaya"});
customers2.AddLast(new Customer {Name = "Kemal", Surname = "Şahin"});
customers2.AddFirst(new Customer {Name = "Enes", Surname = "Çömez"});

//Listeleme
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

//Silme
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

//Filtreleme
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


//Dictionary
//Ekleme
/*Dictionary<int , Customer> customers3 = new Dictionary<int , Customer>();
customers3.Add(1, new Customer() {Name = "Ahmet", Surname = "Evkaya"});
customers3.Add(2, new Customer() {Name = "Kemal", Surname = "Şahin"});
customers3.Add(3, new Customer() {Name = "Enes", Surname = "Çömez"});

//Listeleme
foreach (var customer in customers3)
{
    Console.WriteLine($"{customer.Key} - {customer.Value.Name} {customer.Value.Surname}");
}

Console.WriteLine("---------------------");
// Silme
int customerKey = 0;
foreach (var customer in customers3)
{
    if (customer.Value.Name == "Betül")
    {
        customerKey = customer.Key;
        break;
    }
}

if (customerKey > 0)
{
    Console.WriteLine($"{customers3.FirstOrDefault(c=>c.Key == customerKey).Value.Name} adlı müşteri silinmiştir");
    customers3.Remove(customerKey);
}
else
{
    Console.WriteLine("Müşteri bulunamamıştır");
}

Console.WriteLine("---------------------");
//Filtreleme
var customer3 = customers3.FirstOrDefault(c => c.Key == 2);
if (customer3.Value is not null)
{
    Console.WriteLine($"{customer3.Value.Name} adlı müşteri bulunmuştur.");
}
else
{
    Console.WriteLine("Müşteri bulunamamıştır.");
}
*/

