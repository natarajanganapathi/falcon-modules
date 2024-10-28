namespace Falcon.Menu.Domain.Models;

public record MenuId(long id);

[TenantDb]
public class MenuItem : Entity<MenuId>, IAggregateRoot, IConcurrencyEntity, IAuditableEntity, IDeletableEntity
{
    public MenuId? ParentMenuId { get; set; }
    public long? ModuleId { get; set; }
    public string? ModuleCode { get; set; }
    public string? MenuCode { get; set; }
    public string? ParentMenuCode { get; set; }
    public string? MenuType { get; set; }
    public string? MenuPosition { get; set; }
    public string? Label { get; set; }
    public string? SRef { get; set; }
    public string? IconRef { get; set; }
    public int DisplayOrder { get; set; }

    //IConcurrencyEntity 
    public int Revision { get; set; }

    // IDeletableEntity
    public DeletableEntityStatus Status { get; set; }

    // IAuditableEntity
    public DateTime CreatedAtUtc { get; set; }
    public IUserId? CreatedByUserId { get; set; }
    public DateTime ModifiedAtUtc { get; set; }
    public IUserId? ModifiedByUserId { get; set; }
}