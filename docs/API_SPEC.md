# API Specification - Application Service
**Дата:** 04-09-2025

## 1. Общая информация
API для работы с заявками, поступающими с лендинга.
Все запросы используют JSON.
Авторизация для административных эндпоинтов - через JWT Bearer Token.

## 2. Базовый URL
- Dev: `https://localhost:5000/api/v1`
- Prod `https://<domain>.ru/api/v1`

## 3. Модели данных

## Application (Заявка)
```json
{
    "id":"int",
    "name": "string",
    "phone": "string",
    "message": "string",
    "status": "New | Processed",
    "createdAt": "DateTime"
}
```

## 4. Эндпоинты

### 4.1  Создать заявку
**POST /applications**

**Request**
```json
{
    "name": "Иван",
    "phone": "+79008888888",
    "message": "Хочу консультацию"
}
```
**Response 201**
```json
{
    "id": 1,
    "status": "New",
    "createdAt": "2025-09-04T10:00:00Z"
}
```

**Ошибки**

- 400 — валидация не прошла (пустое имя, неправильный телефон)
- 429 — слишком много запросов (антиспам)

### 4.2 Получить список заявок (только админ)

**GET /applications?page=1&limit=50**

**Response 200**
```json
[
    {
        "id": "1",
        "name": "Иван Иванов",
        "phone": "+79008888888",
        "message": "Хочу консультацию",
        "status": "New",
        "createdAt": "2025-09-04T10:00:00Z"
    }
]
```

**Ошибки**

- 401 — нет токена или токен неверный
- 403 — недостаточно прав
- 500 — ошибка сервера

### 4.3 Обновить статус заявки

**PATCH /applications/{id}**

**Request**
```json
{
    "status": "Processed"
}
```

**Response 200**
```json
{
  "id": 1,
  "name": "Иван Иванов",
  "phone": "+79008888888",
  "message": "Хочу консультацию",
  "status": "Processed",
  "createdAt": "2025-09-04T10:00:00Z",
}
```
**Ошибки**

- 400 — передан некорректный статус
- 404 — заявка не найдена

### 4.4 Удалить заявку

**DELETE /applications/{id}**

**Response 204 (No Content)**

**Ошибки**

- 404 — заявка не найдена

### 4.5 Авторизация

**POST /auth/login**

**Request**
```json
{
  "username": "admin",
  "password": "secret123"
}
```
**Response 200**
```json
{
  "accessToken": "<jwt_token>",
  "expiresIn": 3600
}
```

**Ошибки**

- 400 — пустой логин или пароль
- 401 — неверные учетные данные


## 5. Ошибки (общие)
400 Bad Request — валидация не прошла

- 401 Unauthorized — нет токена или токен неверный
- 403 Forbidden — доступ запрещён
- 404 Not Found — сущность не найдена
- 429 Too Many Requests — ограничение частоты запросов
- 500 Internal Server Error — ошибка сервера

## 6. Примечания
- Все даты — ISO8601 UTC.
- Телефоны — в формате +79998887766.
- JWT токен передаётся в заголовке: Authorization: Bearer <token>.
- Документация будет доступна в Swagger UI (/swagger/index.html).