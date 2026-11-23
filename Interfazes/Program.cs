using System;

public interface IPago
{
    bool ProcesarPago(decimal monto);
}

public class PagoSinpe : IPago
{
    public bool ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando SINPE por ₡{monto:N2}");
        return true;
    }
}

public class PagoTarjeta : IPago
{
    public bool ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago con tarjeta por ₡{monto:N2}");
        return true;
    }
}

public class Tienda
{
    public void Cobrar(decimal monto, IPago metodoPago)
    {
        if (metodoPago == null)
            throw new ArgumentNullException(nameof(metodoPago));

        bool aprobado = metodoPago.ProcesarPago(monto);

        Console.WriteLine(aprobado
            ? "Pago aprobado."
            : "Pago rechazado.");
    }
}

public class Program
{
    public static void Main()
    {
        var tienda = new Tienda();

        IPago pagoSinpe = new PagoSinpe();
        IPago pagoTarjeta = new PagoTarjeta();

        tienda.Cobrar(5000m, pagoSinpe);
        tienda.Cobrar(12000m, pagoTarjeta);
    }
}