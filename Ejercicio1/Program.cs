/* Crear un programa que permita ingresar el nombre, cantidad y precio de 10 productos */

string productName;
int productQuantity, maxProducts = 10;
double productPrice, totalPricePerProduct, totalPrice = 0, IVA = 1.13;

for (int i = 1; i <= maxProducts; i++)
{
    Console.Write($"Nombre de producto #{i}:");
    productName = Console.ReadLine();

    Console.Write($"Precio de {productName}: ");
    productPrice = double.Parse(Console.ReadLine());

    Console.Write("Cantidad: ");
    productQuantity = int.Parse(Console.ReadLine());

    totalPricePerProduct = (productQuantity * productPrice) * IVA;

    totalPrice += totalPricePerProduct;

    Console.Clear();
}

Console.WriteLine($"Total a pagar: ${double.Round(totalPrice, 2)}");