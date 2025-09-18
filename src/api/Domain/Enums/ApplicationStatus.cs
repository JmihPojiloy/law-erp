namespace Domain.Enums;

/// <summary>
/// Статус заявки
/// </summary>
public enum ApplicationStatus
{
    /// <summary>
    /// Новая
    /// </summary>
    New = 1,
    
    /// <summary>
    /// Обработана
    /// </summary>
    Processed = 2,
    
    /// <summary>
    /// Не доступен
    /// </summary>
    NotAvailable = 3,
    
    /// <summary>
    /// На удаление
    /// </summary>
    Delete = 4
}