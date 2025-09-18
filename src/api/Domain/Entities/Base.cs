namespace Domain.Entities;

/// <summary>
/// Базовый класс доменной
/// </summary>
public class Base
{
    /// <summary>
    /// Идентификатор сущности
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Дата обновления
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}