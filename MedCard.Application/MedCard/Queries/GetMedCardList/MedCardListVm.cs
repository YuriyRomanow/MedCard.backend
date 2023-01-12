namespace MedCard.Aplication.MedCard.Queries.GetMedCardList;
/// <summary>
/// список карт
/// </summary>
public class MedCardListVm
{
    public IList<MedCardLookupDto> MedCard { get; set; }
}