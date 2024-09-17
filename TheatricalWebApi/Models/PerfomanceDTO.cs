// PerformanceDTO.cs


namespace TheatricalWebApi.Models;
public class PerformanceDTO
{
    public PlayDTO Play { get; set; }
    public int Audience { get; set; }

    // Construtor padr�o para desserializa��o
    public PerformanceDTO() { }

    // Construtor com par�metros
    public PerformanceDTO(PlayDTO play, int audience)
    {
        Play = play;
        Audience = audience;
    }
}

