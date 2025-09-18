using Domain.Enums;

namespace Infrastructure.DatabaseEntities.Applications;

/// <summary>
/// Класс заявки для хранения в БД
/// </summary>
public class ApplicationEntity
{
    /// <summary>
    /// Телефон клиента
    /// </summary>
    public required string Phone {get; set;}
    
    /// <summary>
    /// Имя клиента
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Описание заявки
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Статус заявки
    /// </summary>
    public ApplicationStatus Status { get; set; }
}