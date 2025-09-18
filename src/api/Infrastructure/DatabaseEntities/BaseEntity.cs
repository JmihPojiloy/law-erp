namespace Infrastructure.DatabaseEntities;

/// <summary>
/// Базовый класс для хранения в БД
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Идентификатор в БД
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Дата изменения
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}