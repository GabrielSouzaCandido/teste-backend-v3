// InvoiceDTO.cs


namespace TheatricalWebApi.Models;
public class InvoiceDTO
{

    public string Customer { get; set; }
    public List<PerformanceDTO> Performances { get; set; }

    // Construtor padr�o para desserializa��o
    public InvoiceDTO() { }

    // Construtor com par�metros
    public InvoiceDTO(string customer, List<PerformanceDTO> performances)
    {
        Customer = customer;
        Performances = performances;
    }
}
