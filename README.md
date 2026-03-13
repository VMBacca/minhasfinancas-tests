# Minhas Finanças — Automated Tests

## Project Overview

This repository contains automated tests created to validate the business rules of the **Minhas Finanças** system.

The goal of this project is to analyze the existing application and verify whether its implementation correctly follows the expected business rules.

The application code was **not modified** and **is not included in this repository**, as required by the technical test instructions.
Only the automated tests and bug documentation are provided.

---

# Test Strategy

The test strategy follows the **Test Pyramid**, prioritizing fast and reliable unit tests while also validating integration points and full system behavior.

```
           E2E Tests (Playwright)
        Integration Tests (.NET)
     Unit Tests (xUnit)
```

### Unit Tests

Validate business rules at the domain level.

### Integration Tests

Validate communication with the API.

### End-to-End Tests

Simulate real user interaction with the application through the UI.

---

# Technologies Used

## Backend Testing

- C#
- .NET
- xUnit

## Frontend / E2E Testing

- React
- TypeScript
- Playwright
- Vitest

---

# Project Structure

```
minhasfinancas-tests
│
├── backend-tests
│   └── MinhasFinancas.BackendTests
│       ├── Unit
│       │   ├── CategoriaTests.cs
│       │   ├── PessoaTests.cs
│       │   └── TransacaoTests.cs
│       │
│       └── Integration
│           └── ApiTests.cs
│
├── e2e
│   ├── tests
│   │   └── fluxo-transacao.spec.ts
│   ├── package.json
│   └── playwright.config.ts
│
├── bugs
│   ├── categoria-permite-receita.md
│   ├── cpf-duplicado.md
│   ├── transacao-data-futura.md
│   ├── transacao-valor-negativo.md
│   ├── transacao-valor-zero.md
│   └── api-nao-responde.md
│
└── README.md
```

---

# Business Rules Tested

The following business rules were validated through automated tests:

- Categories must respect their purpose (Income / Expense / Both)
- CPF must be unique for each person
- Transactions cannot have negative values
- Transactions cannot have zero value
- Transactions cannot have future dates
- API should respond correctly to requests

---

# Running Backend Tests

Navigate to the backend test project and run:

```
cd backend-tests/MinhasFinancas.BackendTests
dotnet test
```

This will execute:

- Unit Tests
- Integration Tests

---

# Running End-to-End Tests

Navigate to the E2E test folder:

```
cd e2e
npm install
npm run test:e2e
```

This will execute Playwright tests that simulate real user interactions with the system.

---

# Bugs Found

Several inconsistencies between the expected business rules and the system behavior were identified during testing.

All discovered issues are documented in the **bugs** folder.

Documented issues include:

- Category allowing invalid transaction type
- Duplicate CPF registration
- Transactions accepting negative values
- Transactions accepting zero value
- Transactions allowing future dates
- API integration issue during test execution

Each bug report includes:

- Description
- Expected behavior
- Actual behavior
- Test demonstrating the issue
- Impact of the problem

---

# Notes

This repository follows the constraints defined in the technical test:

- The original application code is **not included**
- The application code was **not modified**
- Only **tests and documentation** are provided

The focus of the implementation was to validate the **business rules of the system** and identify potential defects through automated testing.
