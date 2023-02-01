namespace MedCard.Application.MedCard.Queries.GetMedCardList;
/// <summary>
/// список карт
/// </summary>
public class MedCardListVm
{
    public IList<MedCardLookupDto> MedCard { get; set; }
}