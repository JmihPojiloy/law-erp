## Обзор

Сервис отвечает за:

- Приём заявок с лендинга  
- Хранение заявок в базе данных  
- CRUD-операции над заявками (создание, просмотр, изменение статуса, удаление)  
- Авторизация администраторов через JWT  
- Логирование всех операций  
- Архитектурная документация и спецификации

---

## Технологии и стек

- **Backend**: ASP.NET Core Web API (версия 9.0)  
- **ORM**: Entity Framework Core  
- **База данных**: PostgreSQL  
- **Аутентификация**: JWT (ASP.NET Identity)  
- **Спецификация API**: OpenAPI (Swagger)  
- **Контейнеризация**: Docker + Docker Compose (для локальной разработки / деплоя)  

---

## Документация

- Текстовая спецификация API: [`docs/API_SPEC.md`](docs/API_SPEC.md)  
- Машинно-читаемая спецификация: [`docs/openapi.yaml`](docs/openapi.yaml)  
- Архитектура (системный контекст и контейнер): [`docs/ARCHITECTURE.md`](docs/ARCHITECTURE.md)  
- Диаграммы:  
  - [`docs/diagrams/system-context.svg`](docs/diagrams/context.svg)  
  - [`docs/diagrams/container.svg`](docs/diagrams/container.svg)  

