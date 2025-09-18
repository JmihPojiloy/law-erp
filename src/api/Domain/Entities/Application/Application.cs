using Domain.Enums;

namespace Domain.Entities.Application;

/// <summary>
/// Класс заявки
/// </summary>
public class Application : Base
{
    /// <summary>
    /// Телефон клиента
    /// </summary>
    public required string Phone {get; set;}
    
    /// <summary>
    /// Имя клиента
    /// </summary>
    public string? Name {get; set;}
    
    /// <summary>
    /// Текст заявки
    /// </summary>
    public string? Description {get; set;}
    
    /// <summary>
    /// Статус заявки
    /// </summary>
    public ApplicationStatus Status {get; set;}
}