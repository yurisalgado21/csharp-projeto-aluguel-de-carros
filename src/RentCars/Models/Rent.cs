using System.Security.Cryptography;
using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Vehicle = vehicle;
        Person = person;
        if (person.GetType() == typeof(PhysicalPerson))
        {   
            Price = vehicle.PricePerDay * daysRented;
        }
        else if (person.GetType() == typeof(LegalPerson))
        {
            var discount = vehicle.PricePerDay * (10 / 100);
            Price = vehicle.PricePerDay * daysRented - discount;
        }
        Status = RentStatus.Confirmed;
        Vehicle!.IsRented = true;
        Person!.Debit = Price;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        throw new NotImplementedException();
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        throw new NotImplementedException();
    }
}