using System;

namespace MedCard.Domain;

public class MedCard
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime? EditDate { get; set; }
}