# HNG12 API Task - C# (ASP.NET Core)

An API that classifies numbers based on mathematical properties and provides a fun fact.


## 📌 API Features

- Prime, Perfect, Armstrong, Even/Odd detection
- Fetches fun facts using the Numbers API
- Supports **CORS** (Cross-Origin Resource Sharing)
- Uses **ASP.NET Core Web API**
- **Publicly deployed** for access

---

## 📥 Installation & Running Locally

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)
- A code editor like **VS Code** or **Rider**

### Steps

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/hng12-s0-t1.git
   cd hng12-s0-t1
   ```
2. Restore Dependencies: `dotnet restore`

3. Run Locally: `dotnet run`

### API Documentation

### GET /api/classify-number?number=371

Returns:

```json
{
  "number": 371,
  "is_prime": false,
  "is_perfect": false,
  "properties": ["armstrong", "odd"],
  "digit_sum": 11,
  "fun_fact": "371 is an Armstrong number because 3^3 + 7^3 + 1^3 = 371"
}
```

## Deployment

Live URL: https://hng12s1t1-production.up.railway.app/api/classify-number

GitHub Repo: https://github.com/Odili1/hngHNG12S1T1

## Useful Links
- [Fun Fact API](http://numbersapi.com/#42)
- [Parity(mathematics)](https://en.wikipedia.org/wiki/Parity_(mathematics))
- [ASP.NET Core Docs](https://learn.microsoft.com/en-us/aspnet/core/)
